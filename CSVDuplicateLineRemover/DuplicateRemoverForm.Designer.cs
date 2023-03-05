namespace AchFindInvalidChars
{
    partial class DuplicateRemoverForm
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
            this.btnBrowseFileRead = new System.Windows.Forms.Button();
            this.btnCheckFile = new System.Windows.Forms.Button();
            this.inpFileRead = new System.Windows.Forms.TextBox();
            this.lblFileRead = new System.Windows.Forms.Label();
            this.inpFileWrite = new System.Windows.Forms.TextBox();
            this.lblFileWrite = new System.Windows.Forms.Label();
            this.btnBrowseFileWrite = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseFileRead
            // 
            this.btnBrowseFileRead.Location = new System.Drawing.Point(239, 44);
            this.btnBrowseFileRead.Name = "btnBrowseFileRead";
            this.btnBrowseFileRead.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseFileRead.TabIndex = 0;
            this.btnBrowseFileRead.Text = "Browse Files";
            this.btnBrowseFileRead.UseVisualStyleBackColor = true;
            this.btnBrowseFileRead.Click += new System.EventHandler(this.btnBrowseFileRead_Click);
            // 
            // btnCheckFile
            // 
            this.btnCheckFile.Location = new System.Drawing.Point(239, 120);
            this.btnCheckFile.Name = "btnCheckFile";
            this.btnCheckFile.Size = new System.Drawing.Size(75, 23);
            this.btnCheckFile.TabIndex = 1;
            this.btnCheckFile.Text = "Check";
            this.btnCheckFile.UseVisualStyleBackColor = true;
            this.btnCheckFile.Click += new System.EventHandler(this.btnCheckFile_Click);
            // 
            // inpFileRead
            // 
            this.inpFileRead.Location = new System.Drawing.Point(12, 44);
            this.inpFileRead.Name = "inpFileRead";
            this.inpFileRead.Size = new System.Drawing.Size(221, 20);
            this.inpFileRead.TabIndex = 2;
            this.inpFileRead.Text = "C:\\";
            // 
            // lblFileRead
            // 
            this.lblFileRead.AutoSize = true;
            this.lblFileRead.Location = new System.Drawing.Point(12, 28);
            this.lblFileRead.Name = "lblFileRead";
            this.lblFileRead.Size = new System.Drawing.Size(90, 13);
            this.lblFileRead.TabIndex = 3;
            this.lblFileRead.Text = "File to Read From";
            // 
            // inpFileWrite
            // 
            this.inpFileWrite.Location = new System.Drawing.Point(12, 90);
            this.inpFileWrite.Name = "inpFileWrite";
            this.inpFileWrite.Size = new System.Drawing.Size(221, 20);
            this.inpFileWrite.TabIndex = 4;
            this.inpFileWrite.Text = "C:\\";
            // 
            // lblFileWrite
            // 
            this.lblFileWrite.AutoSize = true;
            this.lblFileWrite.Location = new System.Drawing.Point(12, 74);
            this.lblFileWrite.Name = "lblFileWrite";
            this.lblFileWrite.Size = new System.Drawing.Size(75, 13);
            this.lblFileWrite.TabIndex = 5;
            this.lblFileWrite.Text = "File to Write to";
            // 
            // btnBrowseFileWrite
            // 
            this.btnBrowseFileWrite.Location = new System.Drawing.Point(239, 89);
            this.btnBrowseFileWrite.Name = "btnBrowseFileWrite";
            this.btnBrowseFileWrite.Size = new System.Drawing.Size(75, 20);
            this.btnBrowseFileWrite.TabIndex = 6;
            this.btnBrowseFileWrite.Text = "Browse Files";
            this.btnBrowseFileWrite.UseVisualStyleBackColor = true;
            this.btnBrowseFileWrite.Click += new System.EventHandler(this.btnBrowseFileWrite_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(236, 157);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(33, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Done";
            this.lblResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnBrowseFileWrite);
            this.Controls.Add(this.lblFileWrite);
            this.Controls.Add(this.inpFileWrite);
            this.Controls.Add(this.lblFileRead);
            this.Controls.Add(this.inpFileRead);
            this.Controls.Add(this.btnCheckFile);
            this.Controls.Add(this.btnBrowseFileRead);
            this.Name = "Form1";
            this.Text = "Duplicate Line Remover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseFileRead;
        private System.Windows.Forms.Button btnCheckFile;
        private System.Windows.Forms.TextBox inpFileRead;
        private System.Windows.Forms.Label lblFileRead;
        private System.Windows.Forms.TextBox inpFileWrite;
        private System.Windows.Forms.Label lblFileWrite;
        private System.Windows.Forms.Button btnBrowseFileWrite;
        private System.Windows.Forms.Label lblResult;
    }
}

