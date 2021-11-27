using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GitHubDesktop
{
    public partial class Form1 : Form
    {
        private string CommandPath { get; set; }
        private string WorkingPath { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        ////
        // START CONTROLS AREA //
        ////
        
        public void PrintBranchs()
        {
            string branchs = Command("git branch");
            if (branchs == "")
                DisplayStatus.Text = "* master";
            else
                DisplayStatus.Text = branchs;
        }
        public string MooveToWorkingDirectory()
        {
            string path = WorkingDirectoryLabel.Text;
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '\\')
                    path.Insert(i, "\\\\");
            }
            return "cd " + path;

        }
        
        public string Command(string command, bool output = true, bool gitCommand = true)
        {
            string firstCommand = "/C " + CommandPath + " && ";
        	using(Process process = new Process()){
                if (!gitCommand)
                    process.StartInfo.Arguments = command;
                else
                    process.StartInfo.Arguments = firstCommand + command;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
        		process.StartInfo.CreateNoWindow = true;
            	process.StartInfo.RedirectStandardOutput = true;
            	process.StartInfo.RedirectStandardInput = true;
            	process.Start();
                string outp = PrintStatus(process, output);
                return outp;
        	}
        }
        
        public string PrintStatus(Process process, bool print)
        {
            string outp = "";
            while (!process.HasExited)
            {
                outp += process.StandardOutput.ReadToEnd();
            }
            if (print)
            {
                DisplayStatus.Text = outp;
                return outp;
            }
            else
                return outp;
        }

        private void SetCurrentBranch()
        {
            string outp = Command("git branch", false);
            if (outp == "")
            {
                StatusBranchNameLabel.Text = "master";
                return;
            }
            try
            {
                outp = outp.Substring(outp.IndexOf('*') + 2);
                outp = outp.Remove(outp.IndexOf('\n'));
                StatusBranchNameLabel.Text = outp;
            }
            catch
            {
                StatusBranchNameLabel.Text = outp;
            }
        }

        private void SetUser()
        {
            UserNameLabel.Text = Command("git config --global --get-all user.name", false);
            UserEmailLabel.Text = Command("git config --global --get-all user.email", false);
        }
        ////
        // END CONTROLS AREA //
        ////
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        ////
        // START CHECKING AREA //
        ////
        private bool CheckWorkingArea() 
        {
            if (string.IsNullOrEmpty(CommandPath))
            {
                DisplayStatus.Text = "Please choose or make a working directory.";
                return false;
            }
            return true;
        }

        private bool CheckFileSelected(Label fileSelected)
        {
            if (string.IsNullOrEmpty(fileSelected.Text))
            {
                DisplayStatus.Text = "Please choose a file.";
                return false;
            }
            return true;
        }

        private bool CheckField(TextBox field)
        {
            if (string.IsNullOrEmpty(field.Text))
            {
                DisplayStatus.Text = "Please fill in the required field.";
                return false;
            }
            return true;
        }

        private bool CheckInit()
        {
            string path = WorkingDirectoryLabel.Text + "\\.git";
            if (!Directory.Exists(path))
            {
                DisplayStatus.Text = "Please initialize a working directory.";
                InitIndicator.BackColor = Color.FromArgb(247, 27, 38);
                StatusInitLabel.Text = "NOT OK";
                return false;
            }
            InitIndicator.BackColor = Color.FromArgb(81, 242, 17);
            StatusInitLabel.Text = "OK";
            return true;
        }

        private bool CheckFirstCommit()
        {
            if(Command("git log") == "")
            {
                DisplayStatus.Text = "Please make the first commit on branch master\nbefore creating a new one";
                return false;
            }
            return true;
        }
        ////
        // END CHECKING AREA //
        ////
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        ////
        // START BUTTONS AREA //
        ////
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //# control buttons
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                WorkingDirectoryLabel.Text = folderBrowserDialog1.SelectedPath;
                string selPath = folderBrowserDialog1.SelectedPath;
                InitLabel.Text = selPath.Substring(selPath.LastIndexOf('\\') + 1);
                CommandPath = MooveToWorkingDirectory();
            }
            folderBrowserDialog1.Dispose();
            folderBrowserDialog1.Reset();
            if (CheckInit())
                SetCurrentBranch();
            SetUser();
        }
        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit()) return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileSelectedLabel.Text = openFileDialog1.SafeFileName;
                openFileDialog1.Dispose();
                openFileDialog1.Reset();
            }
        }
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //# git buttons
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        private void InitUserButton_Click(object sender, EventArgs e)
        {
            if (!CheckField(UserNameTextBox) || !CheckField(UserEmailTextBox)) return;
            string name = UserNameTextBox.Text;
            string email = UserEmailTextBox.Text;
            Command("git config --global user.name " + name);
            Command("git config --global user.email " + email);
            SetUser();
        }
        private void StatusButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea()) return;
            Command("git status");
        }
        private void InitButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea()) return;
            Command("git init");
            CheckInit();
            SetCurrentBranch();
        }
        private void CloneButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckField(UrlCloneTextBox)) return;
            string url = UrlCloneTextBox.Text;
            Command("git clone " + url);
            url = url.Substring(url.LastIndexOf('/') + 1);
            url = url.Remove(url.IndexOf('.'));
            WorkingDirectoryLabel.Text = WorkingDirectoryLabel.Text + "\\" + url;
            CommandPath = MooveToWorkingDirectory();
            InitLabel.Text = url;
            if(CheckInit())
                SetCurrentBranch();
            Command("git status");
        }
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        private void PullButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit() || !CheckField(SurgentTextBox)) return;
            Command("git pull " + SurgentTextBox.Text);
        }
        private void PushButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit()) return;
            SetCurrentBranch();
            if (StatusBranchNameLabel.Text != BranchTextBox.Text)
            {
                DisplayStatus.Text = "Please make sure you are working in the right branch";
                return;
            }
            List<TextBox> checks = new List<TextBox>() {BranchTextBox, SurgentTextBox };
            foreach (TextBox text in checks)
                if (!CheckField(text)) return;
            Command("git push " + SurgentTextBox.Text + " " + BranchTextBox.Text);
            DisplayStatus.Text = "pushed";
        }
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if(!CheckFileSelected(FileSelectedLabel) || !CheckWorkingArea()) return;
            string fileSelected = FileSelectedLabel.Text;
            if (fileSelected.Contains(' '))
                fileSelected = "\"" + fileSelected + "\"";
            FileSelectedLabel.Text = "";
            Command("git add " + fileSelected);
            Command("git status");
        }
        private void AddAllButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea()) return;
            FileSelectedLabel.Text = "";
            Command("git add .");
            Command("git status");
        }
        private void RemoveFileButton_Click(object sender, EventArgs e)
        {
            if (!CheckFileSelected(FileSelectedLabel) || !CheckWorkingArea()) return;
            string fileSelected = FileSelectedLabel.Text;
            if (fileSelected.Contains(' '))
                fileSelected = "\"" + fileSelected + "\"";
            FileSelectedLabel.Text = "";
            Command("git rm --cached " + fileSelected);
            Command("git status");
        }
        private void CommitButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit() || !CheckField(CommitTextBox)) return;
            Command("git commit -m \"" + CommitTextBox.Text + "\"");
        }
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        private void AddSurgentButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckField(AddNameRemoteTextBox) || !CheckField(UrlRemoteTextBox)) return;
            Command("git remote add " + AddNameRemoteTextBox.Text + " " + UrlRemoteTextBox.Text);
            Command("git remote -v");
        }
        private void ViewSurgentButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit()) return;
            Command("git remote -v");
        }
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        private void NewBranchButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit() ||!CheckField(BranchNameTextBox) || !CheckFirstCommit()) return;
            Command("git branch " + BranchNameTextBox.Text);
            SetCurrentBranch();
            PrintBranchs();
        }
        private void ViewBranchButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit()) return;
            PrintBranchs();
        }
        private void ChangeBranchButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit() || !CheckField(BranchNameTextBox) || !CheckFirstCommit()) return;
            string tryy = Command("git checkout " + BranchNameTextBox.Text);
            SetCurrentBranch();
            PrintBranchs();
        }
        private void DeleteBranchButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit() || !CheckField(BranchNameTextBox)) return;
            if (BranchNameTextBox.Text == StatusBranchNameLabel.Text)
            {
                DisplayStatus.Text = "Please change the branch before delete it.";
                return;
            }
            Command("git branch -d " + BranchNameTextBox.Text);
        }
        ////
        // END BUTTONS AREA //
        ////
    }
}
