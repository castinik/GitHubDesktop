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

        public void PrintStatus(Process process)
        {
            string outp = "";
            while (!process.HasExited)
                outp += process.StandardOutput.ReadToEnd();
            DisplayStatus.Text = outp;
        }
        
        private bool CheckWorkingArea() 
        {
        	string path = MooveToWorkingDirectory();
        	using (Process process = MakeCMDProcess(path)) 
        	{
        		process.Start();
        		if(folderBrowserDialog1.)
        	}
        	if()
        }
        
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                WorkingDirectoryLabel.Text = folderBrowserDialog1.SelectedPath;
            CommandPath = MooveToWorkingDirectory();
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            Process process = MakeCMDProcess(CommandPath + " && git status");
            process.Start();
            PrintStatus(process);
        }
        
        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if(FileSelectedLabel.Text.Length == 0)
            {
                FileSelectedLabel.Text = "Please select a file";
                return;
            }
            string fileName = FileSelectedLabel.Text;
            using (Process process = MakeCMDProcess(CommandPath + " && git add " + fileName))
            {
                process.Start();
                PrintStatus(process);
            }
            StatusButton_Click(sender, e);
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                FileSelectedLabel.Text = openFileDialog1.SafeFileName;
        }
        
        private void PullButton_Click(object sender, EventArgs e) 
        {
        	
        }
    }
}
