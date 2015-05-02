namespace CourseProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxLatin = new System.Windows.Forms.TextBox();
            this.TextBoxTranslated = new System.Windows.Forms.TextBox();
            this.ButtonDoTranslation = new System.Windows.Forms.Button();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(584, 24);
            this.TopMenu.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFile,
            this.about,
            this.exit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // uploadFile
            // 
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(152, 22);
            this.uploadFile.Text = "Upload File";
            this.uploadFile.Click += new System.EventHandler(this.uploadFile_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(152, 22);
            this.about.Text = "About project";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(152, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // TextBoxLatin
            // 
            this.TextBoxLatin.Location = new System.Drawing.Point(12, 27);
            this.TextBoxLatin.Multiline = true;
            this.TextBoxLatin.Name = "TextBoxLatin";
            this.TextBoxLatin.Size = new System.Drawing.Size(250, 180);
            this.TextBoxLatin.TabIndex = 1;
            // 
            // TextBoxTranslated
            // 
            this.TextBoxTranslated.Location = new System.Drawing.Point(322, 27);
            this.TextBoxTranslated.Multiline = true;
            this.TextBoxTranslated.Name = "TextBoxTranslated";
            this.TextBoxTranslated.Size = new System.Drawing.Size(250, 180);
            this.TextBoxTranslated.TabIndex = 2;
            // 
            // ButtonDoTranslation
            // 
            this.ButtonDoTranslation.BackgroundImage = global::CourseProject.Properties.Resources.arrow;
            this.ButtonDoTranslation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonDoTranslation.Location = new System.Drawing.Point(275, 27);
            this.ButtonDoTranslation.Name = "ButtonDoTranslation";
            this.ButtonDoTranslation.Size = new System.Drawing.Size(35, 35);
            this.ButtonDoTranslation.TabIndex = 3;
            this.ButtonDoTranslation.UseVisualStyleBackColor = true;
            this.ButtonDoTranslation.Click += new System.EventHandler(this.ButtonDoTranslation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 221);
            this.Controls.Add(this.ButtonDoTranslation);
            this.Controls.Add(this.TextBoxTranslated);
            this.Controls.Add(this.TextBoxLatin);
            this.Controls.Add(this.TopMenu);
            this.MainMenuStrip = this.TopMenu;
            this.MaximumSize = new System.Drawing.Size(600, 260);
            this.MinimumSize = new System.Drawing.Size(600, 260);
            this.Name = "MainForm";
            this.Text = "Translator";
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uploadFile;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.TextBox TextBoxLatin;
        private System.Windows.Forms.TextBox TextBoxTranslated;
        private System.Windows.Forms.Button ButtonDoTranslation;
    }
}

