
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
            this.label1 = new System.Windows.Forms.Label();
            this.WorkingDirectoryLabel = new System.Windows.Forms.Label();
            this.DisplayStatus = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatusBranchNameLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StatusInitLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.InitIndicator = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddNameRemoteTextBox = new System.Windows.Forms.TextBox();
            this.AddSurgentButton = new System.Windows.Forms.Button();
            this.UrlRemoteTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ViewSurgentButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CloneButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.InitButton = new System.Windows.Forms.Button();
            this.InitLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UrlCloneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NewBranchButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BranchNameTextBox = new System.Windows.Forms.TextBox();
            this.ViewBranchButton = new System.Windows.Forms.Button();
            this.ChangeBranchButton = new System.Windows.Forms.Button();
            this.DeleteBranchButton = new System.Windows.Forms.Button();
            this.StagePage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveFileButton = new System.Windows.Forms.Button();
            this.AddAllButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.FileSelectedLabel = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UseGitPage = new System.Windows.Forms.TabPage();
            this.FileToChangeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CommitTextBox = new System.Windows.Forms.TextBox();
            this.CommitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BranchTextBox = new System.Windows.Forms.TextBox();
            this.PullButton = new System.Windows.Forms.Button();
            this.PushButton = new System.Windows.Forms.Button();
            this.SurgentTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserEmailLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.StagePage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.UseGitPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.WorkingDirectoryLabel.Size = new System.Drawing.Size(277, 15);
            this.WorkingDirectoryLabel.TabIndex = 6;
            this.WorkingDirectoryLabel.Text = "Please choose a working directory in Set Repository";
            // 
            // DisplayStatus
            // 
            this.DisplayStatus.Location = new System.Drawing.Point(2, 243);
            this.DisplayStatus.Name = "DisplayStatus";
            this.DisplayStatus.ReadOnly = true;
            this.DisplayStatus.Size = new System.Drawing.Size(795, 173);
            this.DisplayStatus.TabIndex = 5;
            this.DisplayStatus.Text = "";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UserNameLabel);
            this.groupBox1.Controls.Add(this.UserEmailLabel);
            this.groupBox1.Controls.Add(this.StatusBranchNameLabel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.StatusInitLabel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.InitIndicator);
            this.groupBox1.Location = new System.Drawing.Point(584, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status panel";
            // 
            // StatusBranchNameLabel
            // 
            this.StatusBranchNameLabel.AutoSize = true;
            this.StatusBranchNameLabel.Location = new System.Drawing.Point(120, 29);
            this.StatusBranchNameLabel.Name = "StatusBranchNameLabel";
            this.StatusBranchNameLabel.Size = new System.Drawing.Size(34, 15);
            this.StatusBranchNameLabel.TabIndex = 4;
            this.StatusBranchNameLabel.Text = ". . . . .";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Current branch: ";
            // 
            // StatusInitLabel
            // 
            this.StatusInitLabel.AutoSize = true;
            this.StatusInitLabel.Location = new System.Drawing.Point(85, 59);
            this.StatusInitLabel.Name = "StatusInitLabel";
            this.StatusInitLabel.Size = new System.Drawing.Size(34, 15);
            this.StatusInitLabel.TabIndex = 2;
            this.StatusInitLabel.Text = ". . . . .";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Init: ";
            // 
            // InitIndicator
            // 
            this.InitIndicator.BackColor = System.Drawing.Color.White;
            this.InitIndicator.Location = new System.Drawing.Point(23, 59);
            this.InitIndicator.Name = "InitIndicator";
            this.InitIndicator.Size = new System.Drawing.Size(15, 15);
            this.InitIndicator.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ViewSurgentButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.UrlRemoteTextBox);
            this.tabPage2.Controls.Add(this.AddNameRemoteTextBox);
            this.tabPage2.Controls.Add(this.AddSurgentButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(560, 167);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Set User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddNameRemoteTextBox
            // 
            this.AddNameRemoteTextBox.Location = new System.Drawing.Point(321, 82);
            this.AddNameRemoteTextBox.Name = "AddNameRemoteTextBox";
            this.AddNameRemoteTextBox.Size = new System.Drawing.Size(232, 23);
            this.AddNameRemoteTextBox.TabIndex = 9;
            // 
            // AddSurgentButton
            // 
            this.AddSurgentButton.Location = new System.Drawing.Point(3, 81);
            this.AddSurgentButton.Name = "AddSurgentButton";
            this.AddSurgentButton.Size = new System.Drawing.Size(172, 23);
            this.AddSurgentButton.TabIndex = 4;
            this.AddSurgentButton.Text = "Add surgent remote url";
            this.AddSurgentButton.UseVisualStyleBackColor = true;
            this.AddSurgentButton.Click += new System.EventHandler(this.AddSurgentButton_Click);
            // 
            // UrlRemoteTextBox
            // 
            this.UrlRemoteTextBox.Location = new System.Drawing.Point(200, 110);
            this.UrlRemoteTextBox.Name = "UrlRemoteTextBox";
            this.UrlRemoteTextBox.Size = new System.Drawing.Size(353, 23);
            this.UrlRemoteTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Name of remote origin: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Paste the url of remote repository:";
            // 
            // ViewSurgentButton
            // 
            this.ViewSurgentButton.Location = new System.Drawing.Point(8, 138);
            this.ViewSurgentButton.Name = "ViewSurgentButton";
            this.ViewSurgentButton.Size = new System.Drawing.Size(545, 23);
            this.ViewSurgentButton.TabIndex = 13;
            this.ViewSurgentButton.Text = "View all surgent remote";
            this.ViewSurgentButton.UseVisualStyleBackColor = true;
            this.ViewSurgentButton.Click += new System.EventHandler(this.ViewSurgentButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteBranchButton);
            this.tabPage1.Controls.Add(this.ChangeBranchButton);
            this.tabPage1.Controls.Add(this.ViewBranchButton);
            this.tabPage1.Controls.Add(this.BranchNameTextBox);
            this.tabPage1.Controls.Add(this.UrlCloneTextBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.NewBranchButton);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.InitLabel);
            this.tabPage1.Controls.Add(this.InitButton);
            this.tabPage1.Controls.Add(this.BrowseButton);
            this.tabPage1.Controls.Add(this.CloneButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 167);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Set Repository";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CloneButton
            // 
            this.CloneButton.Location = new System.Drawing.Point(3, 28);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(272, 23);
            this.CloneButton.TabIndex = 3;
            this.CloneButton.Text = "Clone";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(281, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(273, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // InitButton
            // 
            this.InitButton.Location = new System.Drawing.Point(281, 28);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(273, 23);
            this.InitButton.TabIndex = 5;
            this.InitButton.Text = "Init";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.Location = new System.Drawing.Point(446, 58);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(36, 15);
            this.InitLabel.TabIndex = 6;
            this.InitLabel.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Use Browse to choose or make a working directory";
            // 
            // UrlCloneTextBox
            // 
            this.UrlCloneTextBox.Location = new System.Drawing.Point(127, 55);
            this.UrlCloneTextBox.Name = "UrlCloneTextBox";
            this.UrlCloneTextBox.Size = new System.Drawing.Size(230, 23);
            this.UrlCloneTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Folder to init: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Paste the url to clone: ";
            // 
            // NewBranchButton
            // 
            this.NewBranchButton.Location = new System.Drawing.Point(3, 84);
            this.NewBranchButton.Name = "NewBranchButton";
            this.NewBranchButton.Size = new System.Drawing.Size(272, 23);
            this.NewBranchButton.TabIndex = 11;
            this.NewBranchButton.Text = "Create new branch";
            this.NewBranchButton.UseVisualStyleBackColor = true;
            this.NewBranchButton.Click += new System.EventHandler(this.NewBranchButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Specify a name for the branch:";
            // 
            // BranchNameTextBox
            // 
            this.BranchNameTextBox.Location = new System.Drawing.Point(413, 109);
            this.BranchNameTextBox.Name = "BranchNameTextBox";
            this.BranchNameTextBox.Size = new System.Drawing.Size(141, 23);
            this.BranchNameTextBox.TabIndex = 13;
            // 
            // ViewBranchButton
            // 
            this.ViewBranchButton.Location = new System.Drawing.Point(3, 138);
            this.ViewBranchButton.Name = "ViewBranchButton";
            this.ViewBranchButton.Size = new System.Drawing.Size(551, 23);
            this.ViewBranchButton.TabIndex = 14;
            this.ViewBranchButton.Text = "View all branch";
            this.ViewBranchButton.UseVisualStyleBackColor = true;
            this.ViewBranchButton.Click += new System.EventHandler(this.ViewBranchButton_Click);
            // 
            // ChangeBranchButton
            // 
            this.ChangeBranchButton.Location = new System.Drawing.Point(3, 111);
            this.ChangeBranchButton.Name = "ChangeBranchButton";
            this.ChangeBranchButton.Size = new System.Drawing.Size(230, 23);
            this.ChangeBranchButton.TabIndex = 15;
            this.ChangeBranchButton.Text = "Change branch";
            this.ChangeBranchButton.UseVisualStyleBackColor = true;
            this.ChangeBranchButton.Click += new System.EventHandler(this.ChangeBranchButton_Click);
            // 
            // DeleteBranchButton
            // 
            this.DeleteBranchButton.Location = new System.Drawing.Point(281, 83);
            this.DeleteBranchButton.Name = "DeleteBranchButton";
            this.DeleteBranchButton.Size = new System.Drawing.Size(273, 23);
            this.DeleteBranchButton.TabIndex = 16;
            this.DeleteBranchButton.Text = "Delete a branch";
            this.DeleteBranchButton.UseVisualStyleBackColor = true;
            this.DeleteBranchButton.Click += new System.EventHandler(this.DeleteBranchButton_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
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
            // RemoveFileButton
            // 
            this.RemoveFileButton.Location = new System.Drawing.Point(278, 30);
            this.RemoveFileButton.Name = "RemoveFileButton";
            this.RemoveFileButton.Size = new System.Drawing.Size(273, 23);
            this.RemoveFileButton.TabIndex = 4;
            this.RemoveFileButton.Text = "Remove file";
            this.RemoveFileButton.UseVisualStyleBackColor = true;
            this.RemoveFileButton.Click += new System.EventHandler(this.RemoveFileButton_Click);
            // 
            // AddAllButton
            // 
            this.AddAllButton.Location = new System.Drawing.Point(3, 4);
            this.AddAllButton.Name = "AddAllButton";
            this.AddAllButton.Size = new System.Drawing.Size(548, 23);
            this.AddAllButton.TabIndex = 3;
            this.AddAllButton.Text = "Add all";
            this.AddAllButton.UseVisualStyleBackColor = true;
            this.AddAllButton.Click += new System.EventHandler(this.AddAllButton_Click);
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
            // FileSelectedLabel
            // 
            this.FileSelectedLabel.AutoSize = true;
            this.FileSelectedLabel.Location = new System.Drawing.Point(231, 61);
            this.FileSelectedLabel.Name = "FileSelectedLabel";
            this.FileSelectedLabel.Size = new System.Drawing.Size(0, 15);
            this.FileSelectedLabel.TabIndex = 5;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "File selected: ";
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
            // FileToChangeLabel
            // 
            this.FileToChangeLabel.AutoSize = true;
            this.FileToChangeLabel.Location = new System.Drawing.Point(23, 133);
            this.FileToChangeLabel.Name = "FileToChangeLabel";
            this.FileToChangeLabel.Size = new System.Drawing.Size(0, 15);
            this.FileToChangeLabel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CommitButton);
            this.panel1.Controls.Add(this.CommitTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 71);
            this.panel1.TabIndex = 7;
            // 
            // CommitTextBox
            // 
            this.CommitTextBox.Location = new System.Drawing.Point(184, 38);
            this.CommitTextBox.Name = "CommitTextBox";
            this.CommitTextBox.Size = new System.Drawing.Size(367, 23);
            this.CommitTextBox.TabIndex = 5;
            // 
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(3, 9);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(548, 23);
            this.CommitButton.TabIndex = 2;
            this.CommitButton.Text = "Commit";
            this.CommitButton.UseVisualStyleBackColor = true;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add a comment before commit";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SurgentTextBox);
            this.panel3.Controls.Add(this.PushButton);
            this.panel3.Controls.Add(this.PullButton);
            this.panel3.Controls.Add(this.BranchTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 83);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surgent: ";
            // 
            // BranchTextBox
            // 
            this.BranchTextBox.Location = new System.Drawing.Point(50, 48);
            this.BranchTextBox.Name = "BranchTextBox";
            this.BranchTextBox.Size = new System.Drawing.Size(209, 23);
            this.BranchTextBox.TabIndex = 4;
            // 
            // PullButton
            // 
            this.PullButton.Location = new System.Drawing.Point(277, 14);
            this.PullButton.Name = "PullButton";
            this.PullButton.Size = new System.Drawing.Size(274, 23);
            this.PullButton.TabIndex = 1;
            this.PullButton.Text = "Pull";
            this.PullButton.UseVisualStyleBackColor = true;
            this.PullButton.Click += new System.EventHandler(this.PullButton_Click);
            // 
            // PushButton
            // 
            this.PushButton.Location = new System.Drawing.Point(3, 14);
            this.PushButton.Name = "PushButton";
            this.PushButton.Size = new System.Drawing.Size(274, 23);
            this.PushButton.TabIndex = 0;
            this.PushButton.Text = "Push";
            this.PushButton.UseVisualStyleBackColor = true;
            this.PushButton.Click += new System.EventHandler(this.PushButton_Click);
            // 
            // SurgentTextBox
            // 
            this.SurgentTextBox.Location = new System.Drawing.Point(319, 50);
            this.SurgentTextBox.Name = "SurgentTextBox";
            this.SurgentTextBox.Size = new System.Drawing.Size(232, 23);
            this.SurgentTextBox.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UseGitPage);
            this.tabControl1.Controls.Add(this.StagePage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 195);
            this.tabControl1.TabIndex = 7;
            // 
            // UserEmailLabel
            // 
            this.UserEmailLabel.AutoSize = true;
            this.UserEmailLabel.Location = new System.Drawing.Point(20, 155);
            this.UserEmailLabel.Name = "UserEmailLabel";
            this.UserEmailLabel.Size = new System.Drawing.Size(61, 15);
            this.UserEmailLabel.TabIndex = 5;
            this.UserEmailLabel.Text = "user.email";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(20, 137);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(62, 15);
            this.UserNameLabel.TabIndex = 6;
            this.UserNameLabel.Text = "user.name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WorkingDirectoryLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DisplayStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusButton);
            this.Name = "Form1";
            this.Text = "GitHubDesktop";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.StagePage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.UseGitPage.ResumeLayout(false);
            this.UseGitPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // Status button
        private System.Windows.Forms.Button StatusButton;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DisplayStatus;
        private System.Windows.Forms.Label WorkingDirectoryLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label StatusInitLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel InitIndicator;
        private System.Windows.Forms.Label StatusBranchNameLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UseGitPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SurgentTextBox;
        private System.Windows.Forms.Button PushButton;
        private System.Windows.Forms.Button PullButton;
        private System.Windows.Forms.TextBox BranchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CommitButton;
        private System.Windows.Forms.TextBox CommitTextBox;
        private System.Windows.Forms.Label FileToChangeLabel;
        private System.Windows.Forms.TabPage StagePage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label FileSelectedLabel;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button AddAllButton;
        private System.Windows.Forms.Button RemoveFileButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button DeleteBranchButton;
        private System.Windows.Forms.Button ChangeBranchButton;
        private System.Windows.Forms.Button ViewBranchButton;
        private System.Windows.Forms.TextBox BranchNameTextBox;
        private System.Windows.Forms.TextBox UrlCloneTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button NewBranchButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label InitLabel;
        private System.Windows.Forms.Button InitButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button CloneButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ViewSurgentButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UrlRemoteTextBox;
        private System.Windows.Forms.TextBox AddNameRemoteTextBox;
        private System.Windows.Forms.Button AddSurgentButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserEmailLabel;
    }
}

