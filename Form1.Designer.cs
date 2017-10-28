namespace Android_Language_Helper
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputBrowseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPathTB = new System.Windows.Forms.TextBox();
            this.saveAsBtn = new System.Windows.Forms.Button();
            this.outputPathTB = new System.Windows.Forms.TextBox();
            this.appDetailsGB = new System.Windows.Forms.GroupBox();
            this.appSummaryTB = new System.Windows.Forms.TextBox();
            this.languageTB = new System.Windows.Forms.TextBox();
            this.appDescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.appNameTB = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.LinkLabel();
            this.inputPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveGB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.appDetailsGB.SuspendLayout();
            this.saveGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.inputBrowseBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputPathTB);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load";
            // 
            // inputBrowseBtn
            // 
            this.inputBrowseBtn.Location = new System.Drawing.Point(203, 91);
            this.inputBrowseBtn.Name = "inputBrowseBtn";
            this.inputBrowseBtn.Size = new System.Drawing.Size(75, 33);
            this.inputBrowseBtn.TabIndex = 7;
            this.inputBrowseBtn.Text = "Browse...";
            this.inputBrowseBtn.UseVisualStyleBackColor = true;
            this.inputBrowseBtn.Click += new System.EventHandler(this.inputBrowseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Load Excel/strings.xml file";
            // 
            // inputPathTB
            // 
            this.inputPathTB.AllowDrop = true;
            this.inputPathTB.Location = new System.Drawing.Point(113, 57);
            this.inputPathTB.Name = "inputPathTB";
            this.inputPathTB.Size = new System.Drawing.Size(266, 20);
            this.inputPathTB.TabIndex = 7;
            this.inputPathTB.TextChanged += new System.EventHandler(this.inputPathTB_TextChange);
            this.inputPathTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputFileDropHandler);
            this.inputPathTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Location = new System.Drawing.Point(199, 79);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(75, 33);
            this.saveAsBtn.TabIndex = 11;
            this.saveAsBtn.Text = "Save as...";
            this.saveAsBtn.UseVisualStyleBackColor = true;
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // outputPathTB
            // 
            this.outputPathTB.AllowDrop = true;
            this.outputPathTB.Location = new System.Drawing.Point(109, 47);
            this.outputPathTB.Name = "outputPathTB";
            this.outputPathTB.Size = new System.Drawing.Size(266, 20);
            this.outputPathTB.TabIndex = 3;
            // 
            // appDetailsGB
            // 
            this.appDetailsGB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.appDetailsGB.Controls.Add(this.appSummaryTB);
            this.appDetailsGB.Controls.Add(this.languageTB);
            this.appDetailsGB.Controls.Add(this.appDescriptionRTB);
            this.appDetailsGB.Controls.Add(this.appNameTB);
            this.appDetailsGB.Location = new System.Drawing.Point(23, 284);
            this.appDetailsGB.Name = "appDetailsGB";
            this.appDetailsGB.Size = new System.Drawing.Size(497, 334);
            this.appDetailsGB.TabIndex = 2;
            this.appDetailsGB.TabStop = false;
            this.appDetailsGB.Text = "App Details";
            // 
            // appSummaryTB
            // 
            this.appSummaryTB.AllowDrop = true;
            this.appSummaryTB.Location = new System.Drawing.Point(104, 82);
            this.appSummaryTB.Multiline = true;
            this.appSummaryTB.Name = "appSummaryTB";
            this.appSummaryTB.Size = new System.Drawing.Size(193, 33);
            this.appSummaryTB.TabIndex = 15;
            this.appSummaryTB.Tag = "App Summary";
            // 
            // languageTB
            // 
            this.languageTB.AllowDrop = true;
            this.languageTB.Location = new System.Drawing.Point(137, 17);
            this.languageTB.Name = "languageTB";
            this.languageTB.Size = new System.Drawing.Size(203, 20);
            this.languageTB.TabIndex = 13;
            this.languageTB.Tag = "Translation Language";
            // 
            // appDescriptionRTB
            // 
            this.appDescriptionRTB.Location = new System.Drawing.Point(104, 129);
            this.appDescriptionRTB.Name = "appDescriptionRTB";
            this.appDescriptionRTB.Size = new System.Drawing.Size(307, 189);
            this.appDescriptionRTB.TabIndex = 12;
            this.appDescriptionRTB.Tag = "App Description...";
            this.appDescriptionRTB.Text = "";
            // 
            // appNameTB
            // 
            this.appNameTB.AllowDrop = true;
            this.appNameTB.Location = new System.Drawing.Point(104, 52);
            this.appNameTB.Name = "appNameTB";
            this.appNameTB.Size = new System.Drawing.Size(126, 20);
            this.appNameTB.TabIndex = 9;
            this.appNameTB.Tag = "App Name";
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(222, 624);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(102, 43);
            this.goBtn.TabIndex = 11;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.AutoSize = true;
            this.logBtn.Location = new System.Drawing.Point(486, 654);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(29, 13);
            this.logBtn.TabIndex = 18;
            this.logBtn.TabStop = true;
            this.logBtn.Text = "LOG";
            this.logBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logBtn_LinkClicked);
            // 
            // inputPathDialog
            // 
            this.inputPathDialog.FileName = "inputPathDialog";
            this.inputPathDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveGB
            // 
            this.saveGB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveGB.Controls.Add(this.label2);
            this.saveGB.Controls.Add(this.saveAsBtn);
            this.saveGB.Controls.Add(this.outputPathTB);
            this.saveGB.Location = new System.Drawing.Point(23, 157);
            this.saveGB.Name = "saveGB";
            this.saveGB.Size = new System.Drawing.Size(497, 121);
            this.saveGB.TabIndex = 9;
            this.saveGB.TabStop = false;
            this.saveGB.Text = "Save";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Save output in";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(532, 679);
            this.Controls.Add(this.saveGB);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.appDetailsGB);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Android Strings Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.appDetailsGB.ResumeLayout(false);
            this.appDetailsGB.PerformLayout();
            this.saveGB.ResumeLayout(false);
            this.saveGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button inputBrowseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPathTB;
        private System.Windows.Forms.GroupBox appDetailsGB;
        private System.Windows.Forms.TextBox appNameTB;
        private System.Windows.Forms.RichTextBox appDescriptionRTB;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.LinkLabel logBtn;
        private System.Windows.Forms.TextBox outputPathTB;
        private System.Windows.Forms.Button saveAsBtn;
        private System.Windows.Forms.TextBox languageTB;
        private System.Windows.Forms.OpenFileDialog inputPathDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.GroupBox saveGB;
        private System.Windows.Forms.TextBox appSummaryTB;
        private System.Windows.Forms.Label label2;
    }
}

