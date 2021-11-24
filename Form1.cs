using System;
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

        public Process MakeCMDProcess(string command)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C " + command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            return process;
        }
        
        public void Command(string command, bool output = true)
        {
        	using(Process process = new Process()){
        		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            	process.StartInfo.FileName = "cmd.exe";
            	process.StartInfo.Arguments = "/C " + CommandPath + " && " + command;
            	process.StartInfo.UseShellExecute = false;
        		process.StartInfo.CreateNoWindow = true;
            	process.StartInfo.RedirectStandardOutput = true;
            	process.StartInfo.RedirectStandardInput = true;
            	process.Start();
            	if (output)
            		PrintStatus(process);
        	}
        }
        
        public void PrintStatus(Process process)
        {
            string outp = "";
            while (!process.HasExited)
                outp += process.StandardOutput.ReadToEnd();
            DisplayStatus.Text = outp;
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
                MessageBox.Show("Please choose or make a working directory");
                return false;
            }
            return true;
        }

        private bool CheckFileSelected(Label fileSelected)
        {
            if (string.IsNullOrEmpty(fileSelected.Text))
            {
                MessageBox.Show("Please choose a file");
                return false;
            }
            return true;
        }

        private bool CheckField(TextBox field)
        {
            if (string.IsNullOrEmpty(field.Text))
            {
                MessageBox.Show("Please wrote a message");
                return false;
            }
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
                InitLabel.Text = selPath.Substring(selPath.LastIndexOf('\\'));
            }
            CommandPath = MooveToWorkingDirectory();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                FileSelectedLabel.Text = openFileDialog1.SafeFileName;
        }

        //# git buttons
        private void StatusButton_Click(object sender, EventArgs e)
        {
            Command("git status");
        }
        
        private void AddFileButton_Click(object sender, EventArgs e)
        {

            if(!CheckFileSelected(FileSelectedLabel))
                return;
            string fileName = FileSelectedLabel.Text;
            Command("git add " + fileName);
            StatusButton_Click(sender, e);
        }
        
        private void PullButton_Click(object sender, EventArgs e) 
        {
            string branch = BranchTextBox.Text;
            string surgent = SurgentTextBox.Text;
            if (!CheckWorkingArea() || (string.IsNullOrEmpty(branch) || string.IsNullOrEmpty(surgent)))
                return;
            Command("git pull " + surgent + " " + branch);
        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea())
                return;
            Command("git init");
        }

        private void PushButton_Click(object sender, EventArgs e)
        {
            if (!CheckWorkingArea())
                return;    
                        
            List<TextBox> checks = new List<TextBox>()
            {
                BranchTextBox, 
                SurgentTextBox,
                CommitTextBox
            };
            foreach(TextBox text in checks)
            {
                if (!CheckField(text))
                    return;
            }
            Command("git commit -m " + CommitTextBox.Text);
            Command("git push " + SurgentTextBox.Text + " " + BranchTextBox.Text);
        }
        ////
        // END BUTTONS AREA //
        ////
    }
}
