
namespace GitHubDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.CloneButton = new System.Windows.Forms.Button();
            this.PushButton = new System.Windows.Forms.Button();
            this.PullButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.AddAllButton = new System.Windows.Forms.Button();
            this.AddSurgentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkingDirectoryLabel = new System.Windows.Forms.Label();
            this.FileToChangeLabel = new System.Windows.Forms.Label();
            this.DisplayStatus = new System.Windows.Forms.RichTextBox();
            this.CommitTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UseGitPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FileSelectedLabel = new System.Windows.Forms.Label();
            this.RemoveFileButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.StagePage = new System.Windows.Forms.TabPage();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BranchTextBox = new System.Windows.Forms.TextBox();
            this.SurgentTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.UseGitPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusButton
            // 
            this.StatusButton.Location = new System.Drawing.Point(2, 422);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(795, 23);
            this.StatusButton.TabIndex = 0;
            this.StatusButton.Text = "Verify the git repository status";
            this.StatusButton.UseVisualStyleBackColor = true;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(17, 15);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(104, 27);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // CloneButton
            // 
            this.CloneButton.Location = new System.Drawing.Point(17, 48);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(104, 27);
            this.CloneButton.TabIndex = 3;
            this.CloneButton.Text = "Clone";
            this.CloneButton.UseVisualStyleBackColor = true;
            // 
            // PushButton
            // 
            this.PushButton.Location = new System.Drawing.Point(3, 6);
            this.PushButton.Name = "PushButton";
            this.PushButton.Size = new System.Drawing.Size(548, 23);
            this.PushButton.TabIndex = 0;
            this.PushButton.Text = "Push";
            this.PushButton.UseVisualStyleBackColor = true;
            // 
            // PullButton
            // 
            this.PullButton.Location = new System.Drawing.Point(3, 13);
            this.PullButton.Name = "PullButton";
            this.PullButton.Size = new System.Drawing.Size(548, 23);
            this.PullButton.TabIndex = 1;
            this.PullButton.Text = "Pull";
            this.PullButton.UseVisualStyleBackColor = true;
            this.PullButton.Click += new System.EventHandler(this.PullButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(3, 30);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(269, 23);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.Text = "Add file";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // AddAllButton
            // 
            this.AddAllButton.Location = new System.Drawing.Point(3, 4);
            this.AddAllButton.Name = "AddAllButton";
            this.AddAllButton.Size = new System.Drawing.Size(548, 23);
            this.AddAllButton.TabIndex = 3;
            this.AddAllButton.Text = "Add all";
            this.AddAllButton.UseVisualStyleBackColor = true;
            // 
            // AddSurgentButton
            // 
            this.AddSurgentButton.Location = new System.Drawing.Point(17, 82);
            this.AddSurgentButton.Name = "AddSurgentButton";
            this.AddSurgentButton.Size = new System.Drawing.Size(178, 23);
            this.AddSurgentButton.TabIndex = 4;
            this.AddSurgentButton.Text = "Add surgent remote url";
            this.AddSurgentButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status operations";
            // 
            // WorkingDirectoryLabel
            // 
            this.WorkingDirectoryLabel.AutoSize = true;
            this.WorkingDirectoryLabel.Location = new System.Drawing.Point(2, 5);
            this.WorkingDirectoryLabel.Name = "WorkingDirectoryLabel";
            this.WorkingDirectoryLabel.Size = new System.Drawing.Size(102, 15);
            this.WorkingDirectoryLabel.TabIndex = 6;
            this.WorkingDirectoryLabel.Text = "Working directory";
            // 
            // FileToChangeLabel
            // 
            this.FileToChangeLabel.AutoSize = true;
            this.FileToChangeLabel.Location = new System.Drawing.Point(23, 133);
            this.FileToChangeLabel.Name = "FileToChangeLabel";
            this.FileToChangeLabel.Size = new System.Drawing.Size(0, 15);
            this.FileToChangeLabel.TabIndex = 6;
            // 
            // DisplayStatus
            // 
            this.DisplayStatus.Location = new System.Drawing.Point(2, 243);
            this.DisplayStatus.Name = "DisplayStatus";
            this.DisplayStatus.Size = new System.Drawing.Size(795, 173);
            this.DisplayStatus.TabIndex = 5;
            this.DisplayStatus.Text = "";
            // 
            // CommitTextBox
            // 
            this.CommitTextBox.Location = new System.Drawing.Point(166, 42);
            this.CommitTextBox.Name = "CommitTextBox";
            this.CommitTextBox.ReadOnly = true;
            this.CommitTextBox.Size = new System.Drawing.Size(385, 23);
            this.CommitTextBox.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UseGitPage);
            this.tabControl1.Controls.Add(this.StagePage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 195);
            this.tabControl1.TabIndex = 7;
            // 
            // UseGitPage
            // 
            this.UseGitPage.Controls.Add(this.panel3);
            this.UseGitPage.Controls.Add(this.panel1);
            this.UseGitPage.Controls.Add(this.FileToChangeLabel);
            this.UseGitPage.Location = new System.Drawing.Point(4, 24);
            this.UseGitPage.Name = "UseGitPage";
            this.UseGitPage.Padding = new System.Windows.Forms.Padding(3);
            this.UseGitPage.Size = new System.Drawing.Size(560, 167);
            this.UseGitPage.TabIndex = 0;
            this.UseGitPage.Text = "Use Git";
            this.UseGitPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SelectFileButton);
            this.panel2.Controls.Add(this.FileSelectedLabel);
            this.panel2.Controls.Add(this.AddFileButton);
            this.panel2.Controls.Add(this.AddAllButton);
            this.panel2.Controls.Add(this.RemoveFileButton);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 87);
            this.panel2.TabIndex = 8;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(3, 57);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(139, 23);
            this.SelectFileButton.TabIndex = 6;
            this.SelectFileButton.Text = "Select a file";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // FileSelectedLabel
            // 
            this.FileSelectedLabel.AutoSize = true;
            this.FileSelectedLabel.Location = new System.Drawing.Point(148, 61);
            this.FileSelectedLabel.Name = "FileSelectedLabel";
            this.FileSelectedLabel.Size = new System.Drawing.Size(106, 15);
            this.FileSelectedLabel.TabIndex = 5;
            this.FileSelectedLabel.Text = "File selected: None";
            // 
            // RemoveFileButton
            // 
            this.RemoveFileButton.Location = new System.Drawing.Point(278, 30);
            this.RemoveFileButton.Name = "RemoveFileButton";
            this.RemoveFileButton.Size = new System.Drawing.Size(273, 23);
            this.RemoveFileButton.TabIndex = 4;
            this.RemoveFileButton.Text = "Remove file";
            this.RemoveFileButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CommitTextBox);
            this.panel1.Controls.Add(this.PushButton);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 71);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add a comment before push";
            // 
            // StagePage
            // 
            this.StagePage.Controls.Add(this.panel2);
            this.StagePage.Location = new System.Drawing.Point(4, 24);
            this.StagePage.Name = "StagePage";
            this.StagePage.Padding = new System.Windows.Forms.Padding(3);
            this.StagePage.Size = new System.Drawing.Size(560, 167);
            this.StagePage.TabIndex = 1;
            this.StagePage.Text = "Set Stage Git";
            this.StagePage.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.DirectoryName;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddSurgentButton);
            this.tabPage1.Controls.Add(this.BrowseButton);
            this.tabPage1.Controls.Add(this.CloneButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 167);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SurgentTextBox);
            this.panel3.Controls.Add(this.BranchTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.PullButton);
            this.panel3.Location = new System.Drawing.Point(3, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 83);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surgent: ";
            // 
            // BranchTextBox
            // 
            this.BranchTextBox.Location = new System.Drawing.Point(50, 52);
            this.BranchTextBox.Name = "BranchTextBox";
            this.BranchTextBox.Size = new System.Drawing.Size(209, 23);
            this.BranchTextBox.TabIndex = 4;
            // 
            // SurgentTextBox
            // 
            this.SurgentTextBox.Location = new System.Drawing.Point(319, 52);
            this.SurgentTextBox.Name = "SurgentTextBox";
            this.SurgentTextBox.Size = new System.Drawing.Size(232, 23);
            this.SurgentTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WorkingDirectoryLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DisplayStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusButton);
            this.Name = "Form1";
            this.Text = "GitHubDesktop";
            this.tabControl1.ResumeLayout(false);
            this.UseGitPage.ResumeLayout(false);
            this.UseGitPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StagePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // Status button
        private System.Windows.Forms.Button StatusButton;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button CloneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DisplayStatus;
        private System.Windows.Forms.Label WorkingDirectoryLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UseGitPage;
        private System.Windows.Forms.TabPage StagePage;
        private System.Windows.Forms.Button RemoveFileButton;
        private System.Windows.Forms.Button AddAllButton;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button PullButton;
        private System.Windows.Forms.Button PushButton;
        private System.Windows.Forms.Button AddSurgentButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label FileToChangeLabel;
        private System.Windows.Forms.TextBox CommitTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FileSelectedLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SurgentTextBox;
        private System.Windows.Forms.TextBox BranchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

