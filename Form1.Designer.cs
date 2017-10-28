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
            this.saveAsBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.inputBrowseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputPathTB = new System.Windows.Forms.TextBox();
            this.inputPathTB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.translationTB = new System.Windows.Forms.TextBox();
            this.appDescriptionTB = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.appNameTB = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.LinkLabel();
            this.inputPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.saveAsBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.inputBrowseBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.outputPathTB);
            this.groupBox1.Controls.Add(this.inputPathTB);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Xml/Xlsx file";
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Location = new System.Drawing.Point(222, 175);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(75, 33);
            this.saveAsBtn.TabIndex = 11;
            this.saveAsBtn.Text = "Save as...";
            this.saveAsBtn.UseVisualStyleBackColor = true;
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Output file path";
            // 
            // inputBrowseBtn
            // 
            this.inputBrowseBtn.Location = new System.Drawing.Point(222, 76);
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
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "XML/XLSX file path";
            // 
            // outputPathTB
            // 
            this.outputPathTB.AllowDrop = true;
            this.outputPathTB.Location = new System.Drawing.Point(145, 140);
            this.outputPathTB.Name = "outputPathTB";
            this.outputPathTB.Size = new System.Drawing.Size(266, 20);
            this.outputPathTB.TabIndex = 3;
            // 
            // inputPathTB
            // 
            this.inputPathTB.AllowDrop = true;
            this.inputPathTB.Location = new System.Drawing.Point(145, 40);
            this.inputPathTB.Name = "inputPathTB";
            this.inputPathTB.Size = new System.Drawing.Size(266, 20);
            this.inputPathTB.TabIndex = 7;
            this.inputPathTB.TextChanged += new System.EventHandler(this.inputPathTB_TextChange);
            this.inputPathTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputFileDropHandler);
            this.inputPathTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.translationTB);
            this.groupBox3.Controls.Add(this.appDescriptionTB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.appNameTB);
            this.groupBox3.Location = new System.Drawing.Point(18, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 303);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "App Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Translation Language";
            // 
            // translationTB
            // 
            this.translationTB.AllowDrop = true;
            this.translationTB.Location = new System.Drawing.Point(222, 33);
            this.translationTB.Name = "translationTB";
            this.translationTB.Size = new System.Drawing.Size(75, 20);
            this.translationTB.TabIndex = 13;
            // 
            // appDescriptionTB
            // 
            this.appDescriptionTB.Location = new System.Drawing.Point(104, 121);
            this.appDescriptionTB.Name = "appDescriptionTB";
            this.appDescriptionTB.Size = new System.Drawing.Size(307, 154);
            this.appDescriptionTB.TabIndex = 12;
            this.appDescriptionTB.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "App Description";
            // 
            // appNameTB
            // 
            this.appNameTB.AllowDrop = true;
            this.appNameTB.Location = new System.Drawing.Point(104, 87);
            this.appNameTB.Name = "appNameTB";
            this.appNameTB.Size = new System.Drawing.Size(75, 20);
            this.appNameTB.TabIndex = 9;
            this.appNameTB.Text = "AppName";
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(222, 565);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(102, 43);
            this.goBtn.TabIndex = 11;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.AutoSize = true;
            this.logBtn.Location = new System.Drawing.Point(486, 595);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(532, 621);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Android Strings Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button inputBrowseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPathTB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox appNameTB;
        private System.Windows.Forms.RichTextBox appDescriptionTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.LinkLabel logBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox outputPathTB;
        private System.Windows.Forms.Button saveAsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox translationTB;
        private System.Windows.Forms.OpenFileDialog inputPathDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;

    }
}

