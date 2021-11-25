using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubDesktop
{
    public partial class Form1 : Form
    {
        private string CommandPath { get; set; }
        public Form1()
        {
            InitializeComponent();
            //SetUser();
        }

        ////
        // START CONTROLS AREA //
        ////
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
        		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            	process.StartInfo.FileName = "cmd.exe";
                if (!gitCommand)
                    process.StartInfo.Arguments = command;
                else
                    process.StartInfo.Arguments = firstCommand + command;
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
                outp += process.StandardOutput.ReadToEnd();
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
            outp = outp.Substring(outp.IndexOf('*') + 2);
            try
            {
                outp = outp.Remove(outp.IndexOf(' '));
                StatusBranchNameLabel.Text = outp;
            }
            catch
            {
                StatusBranchNameLabel.Text = outp;
            }
        }

        private void SetUser()
        {
            UserNameLabel.Text = Command("git config --global --get-all user.name", false, false);
            UserEmailLabel.Text = Command("git config --global --get-all user.email", false, false);
        }
        ////
        // END CONTROLS AREA //
        ////

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
        ////
        // END CHECKING AREA //
        ////

        ////
        // START BUTTONS AREA //
        ////
        //# control buttons
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
            if (CheckInit())
                SetCurrentBranch();
            SetUser();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                FileSelectedLabel.Text = openFileDialog1.SafeFileName;
        }

        //# git buttons
        private void StatusButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea()) return;
            Command("git status");
        }
        
        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if(!CheckFileSelected(FileSelectedLabel) || !CheckWorkingArea()) return;
            Command("git add " + FileSelectedLabel.Text);
            Command("git status");
        }
        
        private void PullButton_Click(object sender, EventArgs e) 
        {
            if (!CheckWorkingArea() || !CheckInit()) return;
            if (!CheckField(SurgentTextBox)) return;
            Command("git pull " + SurgentTextBox.Text);
        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea()) return;
            Command("git init");
        }

        private void PushButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit()) return;
            List<TextBox> checks = new List<TextBox>() {
                BranchTextBox, 
                SurgentTextBox };
            foreach(TextBox text in checks)
                if (!CheckField(text)) return;
            Command("git push " + SurgentTextBox.Text + " " + BranchTextBox.Text);
        }

        private void AddAllButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea()) return;
            Command("git add .");
            Command("git status");
        }

        private void RemoveFileButton_Click(object sender, EventArgs e)
        {
            if (!CheckFileSelected(FileSelectedLabel) || !CheckWorkingArea()) return;
            Command("git rm --cached " + FileSelectedLabel.Text);
            Command("git status");
        }

        private void AddSurgentButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckField(AddNameRemoteTextBox) || !CheckField(UrlRemoteTextBox)) return;
            Command("git remote add " + AddNameRemoteTextBox.Text + " " + UrlRemoteTextBox.Text);
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckField(UrlCloneTextBox)) return;
            Command("git clone " + UrlCloneTextBox.Text);
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit() || !CheckField(CommitTextBox)) return;
            Command("git commit -m " + CommitTextBox.Text);
        }

        private void NewBranchButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit() ||!CheckField(BranchNameTextBox)) return;
            Command("git branch " + BranchNameTextBox.Text);
        }

        private void ViewBranchButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit()) return;
            Command("git branch");
        }

        private void ChangeBranchButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit() || !CheckField(BranchNameTextBox)) return;
            Command("git checkout " + BranchNameTextBox.Text);
            SetCurrentBranch();
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

        private void ViewSurgentButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea() || !CheckInit()) return;
            Command("git remote -v");
        }
        ////
        // END BUTTONS AREA //
        ////
    }
}
