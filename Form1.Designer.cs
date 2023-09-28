
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StatusButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkingDirectoryLabel = new System.Windows.Forms.Label();
            this.DisplayStatus = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserEmailLabel = new System.Windows.Forms.Label();
            this.StatusBranchNameLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StatusInitLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.InitIndicator = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UserEmailTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.InitUserButton = new System.Windows.Forms.Button();
            this.ViewSurgentButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UrlRemoteTextBox = new System.Windows.Forms.TextBox();
            this.AddNameRemoteTextBox = new System.Windows.Forms.TextBox();
            this.AddSurgentButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteBranchButton = new System.Windows.Forms.Button();
            this.ChangeBranchButton = new System.Windows.Forms.Button();
            this.ViewBranchButton = new System.Windows.Forms.Button();
            this.BranchNameTextBox = new System.Windows.Forms.TextBox();
            this.UrlCloneTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NewBranchButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InitLabel = new System.Windows.Forms.Label();
            this.InitButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.CloneButton = new System.Windows.Forms.Button();
            this.StagePage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FileSelectedLabel = new System.Windows.Forms.Label();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.AddAllButton = new System.Windows.Forms.Button();
            this.RemoveFileButton = new System.Windows.Forms.Button();
            this.UseGitPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SurgentTextBox = new System.Windows.Forms.TextBox();
            this.PushButton = new System.Windows.Forms.Button();
            this.PullButton = new System.Windows.Forms.Button();
            this.BranchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CommitButton = new System.Windows.Forms.Button();
            this.CommitTextBox = new System.Windows.Forms.TextBox();
            this.FileToChangeLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.StagePage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.UseGitPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusButton
            // 
            this.StatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StatusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StatusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StatusButton.Location = new System.Drawing.Point(2, 554);
            this.StatusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(909, 35);
            this.StatusButton.TabIndex = 0;
            this.StatusButton.Text = "Verify the git repository status";
            this.StatusButton.UseVisualStyleBackColor = false;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(385, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status operations";
            // 
            // WorkingDirectoryLabel
            // 
            this.WorkingDirectoryLabel.AutoSize = true;
            this.WorkingDirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkingDirectoryLabel.Location = new System.Drawing.Point(5, 5);
            this.WorkingDirectoryLabel.Name = "WorkingDirectoryLabel";
            this.WorkingDirectoryLabel.Size = new System.Drawing.Size(401, 23);
            this.WorkingDirectoryLabel.TabIndex = 6;
            this.WorkingDirectoryLabel.Text = "Please choose a working directory in Set Repository";
            // 
            // DisplayStatus
            // 
            this.DisplayStatus.BackColor = System.Drawing.Color.Thistle;
            this.DisplayStatus.Location = new System.Drawing.Point(2, 324);
            this.DisplayStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisplayStatus.Name = "DisplayStatus";
            this.DisplayStatus.ReadOnly = true;
            this.DisplayStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.DisplayStatus.Size = new System.Drawing.Size(908, 229);
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
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.UserNameLabel);
            this.groupBox1.Controls.Add(this.UserEmailLabel);
            this.groupBox1.Controls.Add(this.StatusBranchNameLabel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.StatusInitLabel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.InitIndicator);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(667, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(229, 224);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status panel";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(7, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 23);
            this.label17.TabIndex = 17;
            this.label17.Text = "User email:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(7, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 23);
            this.label16.TabIndex = 16;
            this.label16.Text = "User name: ";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(114, 92);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(44, 17);
            this.UserNameLabel.TabIndex = 6;
            this.UserNameLabel.Text = ". . . . .";
            // 
            // UserEmailLabel
            // 
            this.UserEmailLabel.AutoSize = true;
            this.UserEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserEmailLabel.Location = new System.Drawing.Point(110, 139);
            this.UserEmailLabel.Name = "UserEmailLabel";
            this.UserEmailLabel.Size = new System.Drawing.Size(44, 17);
            this.UserEmailLabel.TabIndex = 5;
            this.UserEmailLabel.Text = ". . . . .";
            // 
            // StatusBranchNameLabel
            // 
            this.StatusBranchNameLabel.AutoSize = true;
            this.StatusBranchNameLabel.Location = new System.Drawing.Point(142, 39);
            this.StatusBranchNameLabel.Name = "StatusBranchNameLabel";
            this.StatusBranchNameLabel.Size = new System.Drawing.Size(50, 23);
            this.StatusBranchNameLabel.TabIndex = 4;
            this.StatusBranchNameLabel.Text = ". . . . .";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(7, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Current branch: ";
            // 
            // StatusInitLabel
            // 
            this.StatusInitLabel.AutoSize = true;
            this.StatusInitLabel.Location = new System.Drawing.Point(75, 179);
            this.StatusInitLabel.Name = "StatusInitLabel";
            this.StatusInitLabel.Size = new System.Drawing.Size(50, 23);
            this.StatusInitLabel.TabIndex = 2;
            this.StatusInitLabel.Text = ". . . . .";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(30, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Init: ";
            // 
            // InitIndicator
            // 
            this.InitIndicator.BackColor = System.Drawing.Color.White;
            this.InitIndicator.Location = new System.Drawing.Point(9, 179);
            this.InitIndicator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InitIndicator.Name = "InitIndicator";
            this.InitIndicator.Size = new System.Drawing.Size(17, 20);
            this.InitIndicator.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPage2.Controls.Add(this.UserEmailTextBox);
            this.tabPage2.Controls.Add(this.UserNameTextBox);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.InitUserButton);
            this.tabPage2.Controls.Add(this.ViewSurgentButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.UrlRemoteTextBox);
            this.tabPage2.Controls.Add(this.AddNameRemoteTextBox);
            this.tabPage2.Controls.Add(this.AddSurgentButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(641, 227);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Set User";
            // 
            // UserEmailTextBox
            // 
            this.UserEmailTextBox.BackColor = System.Drawing.Color.Thistle;
            this.UserEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserEmailTextBox.Location = new System.Drawing.Point(85, 77);
            this.UserEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserEmailTextBox.Name = "UserEmailTextBox";
            this.UserEmailTextBox.Size = new System.Drawing.Size(547, 27);
            this.UserEmailTextBox.TabIndex = 18;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.Thistle;
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTextBox.Location = new System.Drawing.Point(85, 43);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(547, 27);
            this.UserNameTextBox.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "User email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "User name: ";
            // 
            // InitUserButton
            // 
            this.InitUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InitUserButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InitUserButton.Location = new System.Drawing.Point(3, 5);
            this.InitUserButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InitUserButton.Name = "InitUserButton";
            this.InitUserButton.Size = new System.Drawing.Size(629, 33);
            this.InitUserButton.TabIndex = 14;
            this.InitUserButton.Text = "Initialize user";
            this.InitUserButton.UseVisualStyleBackColor = true;
            this.InitUserButton.Click += new System.EventHandler(this.InitUserButton_Click);
            // 
            // ViewSurgentButton
            // 
            this.ViewSurgentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewSurgentButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ViewSurgentButton.Location = new System.Drawing.Point(3, 181);
            this.ViewSurgentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewSurgentButton.Name = "ViewSurgentButton";
            this.ViewSurgentButton.Size = new System.Drawing.Size(629, 33);
            this.ViewSurgentButton.TabIndex = 13;
            this.ViewSurgentButton.Text = "View all surgent remote";
            this.ViewSurgentButton.UseVisualStyleBackColor = true;
            this.ViewSurgentButton.Click += new System.EventHandler(this.ViewSurgentButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Paste the url of remote repository:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Name of remote origin: ";
            // 
            // UrlRemoteTextBox
            // 
            this.UrlRemoteTextBox.BackColor = System.Drawing.Color.Thistle;
            this.UrlRemoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlRemoteTextBox.Location = new System.Drawing.Point(248, 147);
            this.UrlRemoteTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UrlRemoteTextBox.Name = "UrlRemoteTextBox";
            this.UrlRemoteTextBox.Size = new System.Drawing.Size(384, 27);
            this.UrlRemoteTextBox.TabIndex = 11;
            // 
            // AddNameRemoteTextBox
            // 
            this.AddNameRemoteTextBox.BackColor = System.Drawing.Color.Thistle;
            this.AddNameRemoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNameRemoteTextBox.Location = new System.Drawing.Point(378, 112);
            this.AddNameRemoteTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddNameRemoteTextBox.Name = "AddNameRemoteTextBox";
            this.AddNameRemoteTextBox.Size = new System.Drawing.Size(254, 27);
            this.AddNameRemoteTextBox.TabIndex = 9;
            // 
            // AddSurgentButton
            // 
            this.AddSurgentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSurgentButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddSurgentButton.Location = new System.Drawing.Point(3, 111);
            this.AddSurgentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddSurgentButton.Name = "AddSurgentButton";
            this.AddSurgentButton.Size = new System.Drawing.Size(197, 33);
            this.AddSurgentButton.TabIndex = 4;
            this.AddSurgentButton.Text = "Add surgent remote url";
            this.AddSurgentButton.UseVisualStyleBackColor = true;
            this.AddSurgentButton.Click += new System.EventHandler(this.AddSurgentButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumPurple;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(641, 227);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Set Repository";
            // 
            // DeleteBranchButton
            // 
            this.DeleteBranchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBranchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteBranchButton.Location = new System.Drawing.Point(321, 109);
            this.DeleteBranchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBranchButton.Name = "DeleteBranchButton";
            this.DeleteBranchButton.Size = new System.Drawing.Size(312, 33);
            this.DeleteBranchButton.TabIndex = 16;
            this.DeleteBranchButton.Text = "Delete a branch";
            this.DeleteBranchButton.UseVisualStyleBackColor = true;
            this.DeleteBranchButton.Click += new System.EventHandler(this.DeleteBranchButton_Click);
            // 
            // ChangeBranchButton
            // 
            this.ChangeBranchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeBranchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChangeBranchButton.Location = new System.Drawing.Point(3, 144);
            this.ChangeBranchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeBranchButton.Name = "ChangeBranchButton";
            this.ChangeBranchButton.Size = new System.Drawing.Size(263, 33);
            this.ChangeBranchButton.TabIndex = 15;
            this.ChangeBranchButton.Text = "Change branch";
            this.ChangeBranchButton.UseVisualStyleBackColor = true;
            this.ChangeBranchButton.Click += new System.EventHandler(this.ChangeBranchButton_Click);
            // 
            // ViewBranchButton
            // 
            this.ViewBranchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBranchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ViewBranchButton.Location = new System.Drawing.Point(3, 179);
            this.ViewBranchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewBranchButton.Name = "ViewBranchButton";
            this.ViewBranchButton.Size = new System.Drawing.Size(630, 33);
            this.ViewBranchButton.TabIndex = 14;
            this.ViewBranchButton.Text = "View all branch";
            this.ViewBranchButton.UseVisualStyleBackColor = true;
            this.ViewBranchButton.Click += new System.EventHandler(this.ViewBranchButton_Click);
            // 
            // BranchNameTextBox
            // 
            this.BranchNameTextBox.BackColor = System.Drawing.Color.Thistle;
            this.BranchNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BranchNameTextBox.Location = new System.Drawing.Point(489, 145);
            this.BranchNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BranchNameTextBox.Name = "BranchNameTextBox";
            this.BranchNameTextBox.Size = new System.Drawing.Size(144, 27);
            this.BranchNameTextBox.TabIndex = 13;
            // 
            // UrlCloneTextBox
            // 
            this.UrlCloneTextBox.BackColor = System.Drawing.Color.Thistle;
            this.UrlCloneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlCloneTextBox.Location = new System.Drawing.Point(370, 76);
            this.UrlCloneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UrlCloneTextBox.Name = "UrlCloneTextBox";
            this.UrlCloneTextBox.Size = new System.Drawing.Size(263, 27);
            this.UrlCloneTextBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Specify a name for the branch:";
            // 
            // NewBranchButton
            // 
            this.NewBranchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBranchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewBranchButton.Location = new System.Drawing.Point(3, 109);
            this.NewBranchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewBranchButton.Name = "NewBranchButton";
            this.NewBranchButton.Size = new System.Drawing.Size(311, 33);
            this.NewBranchButton.TabIndex = 11;
            this.NewBranchButton.Text = "Create new branch";
            this.NewBranchButton.UseVisualStyleBackColor = true;
            this.NewBranchButton.Click += new System.EventHandler(this.NewBranchButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Paste the url to clone: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Folder to init: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Use Browse to choose or make a working directory";
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.Location = new System.Drawing.Point(102, 80);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(45, 20);
            this.InitLabel.TabIndex = 6;
            this.InitLabel.Text = "None";
            // 
            // InitButton
            // 
            this.InitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InitButton.Location = new System.Drawing.Point(3, 40);
            this.InitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(312, 33);
            this.InitButton.TabIndex = 5;
            this.InitButton.Text = "Init";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BrowseButton.Location = new System.Drawing.Point(353, 4);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(280, 33);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // CloneButton
            // 
            this.CloneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloneButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CloneButton.Location = new System.Drawing.Point(321, 40);
            this.CloneButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(312, 33);
            this.CloneButton.TabIndex = 3;
            this.CloneButton.Text = "Clone";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // StagePage
            // 
            this.StagePage.BackColor = System.Drawing.Color.MediumPurple;
            this.StagePage.Controls.Add(this.panel2);
            this.StagePage.Location = new System.Drawing.Point(4, 29);
            this.StagePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StagePage.Name = "StagePage";
            this.StagePage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StagePage.Size = new System.Drawing.Size(641, 227);
            this.StagePage.TabIndex = 1;
            this.StagePage.Text = "Set Stage Git";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.SelectFileButton);
            this.panel2.Controls.Add(this.FileSelectedLabel);
            this.panel2.Controls.Add(this.AddFileButton);
            this.panel2.Controls.Add(this.AddAllButton);
            this.panel2.Controls.Add(this.RemoveFileButton);
            this.panel2.Location = new System.Drawing.Point(3, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 116);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "File selected: ";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectFileButton.Location = new System.Drawing.Point(3, 76);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(159, 33);
            this.SelectFileButton.TabIndex = 6;
            this.SelectFileButton.Text = "Select a file";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // FileSelectedLabel
            // 
            this.FileSelectedLabel.AutoSize = true;
            this.FileSelectedLabel.Location = new System.Drawing.Point(264, 81);
            this.FileSelectedLabel.Name = "FileSelectedLabel";
            this.FileSelectedLabel.Size = new System.Drawing.Size(0, 20);
            this.FileSelectedLabel.TabIndex = 5;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddFileButton.Location = new System.Drawing.Point(3, 40);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(307, 33);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.Text = "Add file";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // AddAllButton
            // 
            this.AddAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAllButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddAllButton.Location = new System.Drawing.Point(3, 5);
            this.AddAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddAllButton.Name = "AddAllButton";
            this.AddAllButton.Size = new System.Drawing.Size(626, 33);
            this.AddAllButton.TabIndex = 3;
            this.AddAllButton.Text = "Add all";
            this.AddAllButton.UseVisualStyleBackColor = true;
            this.AddAllButton.Click += new System.EventHandler(this.AddAllButton_Click);
            // 
            // RemoveFileButton
            // 
            this.RemoveFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveFileButton.Location = new System.Drawing.Point(318, 40);
            this.RemoveFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveFileButton.Name = "RemoveFileButton";
            this.RemoveFileButton.Size = new System.Drawing.Size(312, 33);
            this.RemoveFileButton.TabIndex = 4;
            this.RemoveFileButton.Text = "Remove file";
            this.RemoveFileButton.UseVisualStyleBackColor = true;
            this.RemoveFileButton.Click += new System.EventHandler(this.RemoveFileButton_Click);
            // 
            // UseGitPage
            // 
            this.UseGitPage.BackColor = System.Drawing.Color.MediumPurple;
            this.UseGitPage.Controls.Add(this.panel3);
            this.UseGitPage.Controls.Add(this.panel1);
            this.UseGitPage.Controls.Add(this.FileToChangeLabel);
            this.UseGitPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UseGitPage.Location = new System.Drawing.Point(4, 29);
            this.UseGitPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UseGitPage.Name = "UseGitPage";
            this.UseGitPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UseGitPage.Size = new System.Drawing.Size(641, 227);
            this.UseGitPage.TabIndex = 0;
            this.UseGitPage.Text = "Use Git";
            this.UseGitPage.ToolTipText = "Use this section to execute the commit and push or pull a repository.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.SurgentTextBox);
            this.panel3.Controls.Add(this.PushButton);
            this.panel3.Controls.Add(this.PullButton);
            this.panel3.Controls.Add(this.BranchTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 104);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 111);
            this.panel3.TabIndex = 8;
            // 
            // SurgentTextBox
            // 
            this.SurgentTextBox.BackColor = System.Drawing.Color.Thistle;
            this.SurgentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurgentTextBox.Location = new System.Drawing.Point(365, 67);
            this.SurgentTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SurgentTextBox.Name = "SurgentTextBox";
            this.SurgentTextBox.Size = new System.Drawing.Size(265, 27);
            this.SurgentTextBox.TabIndex = 5;
            // 
            // PushButton
            // 
            this.PushButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PushButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PushButton.Location = new System.Drawing.Point(3, 19);
            this.PushButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PushButton.Name = "PushButton";
            this.PushButton.Size = new System.Drawing.Size(313, 33);
            this.PushButton.TabIndex = 0;
            this.PushButton.Text = "Push";
            this.PushButton.UseVisualStyleBackColor = true;
            this.PushButton.Click += new System.EventHandler(this.PushButton_Click);
            // 
            // PullButton
            // 
            this.PullButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PullButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PullButton.Location = new System.Drawing.Point(317, 19);
            this.PullButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PullButton.Name = "PullButton";
            this.PullButton.Size = new System.Drawing.Size(313, 33);
            this.PullButton.TabIndex = 1;
            this.PullButton.Text = "Pull";
            this.PullButton.UseVisualStyleBackColor = true;
            this.PullButton.Click += new System.EventHandler(this.PullButton_Click);
            // 
            // BranchTextBox
            // 
            this.BranchTextBox.BackColor = System.Drawing.Color.Thistle;
            this.BranchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BranchTextBox.Location = new System.Drawing.Point(59, 68);
            this.BranchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BranchTextBox.Name = "BranchTextBox";
            this.BranchTextBox.Size = new System.Drawing.Size(239, 27);
            this.BranchTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surgent: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CommitButton);
            this.panel1.Controls.Add(this.CommitTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 95);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add a comment before commit: ";
            // 
            // CommitButton
            // 
            this.CommitButton.BackColor = System.Drawing.Color.Gray;
            this.CommitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CommitButton.Location = new System.Drawing.Point(3, 8);
            this.CommitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(626, 33);
            this.CommitButton.TabIndex = 2;
            this.CommitButton.Text = "Commit";
            this.CommitButton.UseVisualStyleBackColor = false;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // CommitTextBox
            // 
            this.CommitTextBox.BackColor = System.Drawing.Color.Thistle;
            this.CommitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommitTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommitTextBox.Location = new System.Drawing.Point(235, 49);
            this.CommitTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommitTextBox.Name = "CommitTextBox";
            this.CommitTextBox.Size = new System.Drawing.Size(394, 30);
            this.CommitTextBox.TabIndex = 5;
            // 
            // FileToChangeLabel
            // 
            this.FileToChangeLabel.AutoSize = true;
            this.FileToChangeLabel.Location = new System.Drawing.Point(26, 177);
            this.FileToChangeLabel.Name = "FileToChangeLabel";
            this.FileToChangeLabel.Size = new System.Drawing.Size(0, 20);
            this.FileToChangeLabel.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UseGitPage);
            this.tabControl1.Controls.Add(this.StagePage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(3, 35);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 260);
            this.tabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(912, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WorkingDirectoryLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DisplayStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(930, 636);
            this.MinimumSize = new System.Drawing.Size(930, 636);
            this.Name = "Form1";
            this.Text = "GitHubDesktop v1.0";
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox UserEmailTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button InitUserButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

