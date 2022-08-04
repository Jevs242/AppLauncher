namespace AppLauncher
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
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_RunApps = new System.Windows.Forms.Button();
            this.lbl_ProgramsList = new System.Windows.Forms.Label();
            this.lbx_ProgramBox = new System.Windows.Forms.ListBox();
            this.btn_DeleteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(349, 302);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(93, 38);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_RunApps
            // 
            this.btn_RunApps.Location = new System.Drawing.Point(349, 346);
            this.btn_RunApps.Name = "btn_RunApps";
            this.btn_RunApps.Size = new System.Drawing.Size(93, 38);
            this.btn_RunApps.TabIndex = 1;
            this.btn_RunApps.Text = "Run Apps";
            this.btn_RunApps.UseVisualStyleBackColor = true;
            this.btn_RunApps.Click += new System.EventHandler(this.btn_RunApps_Click);
            // 
            // lbl_ProgramsList
            // 
            this.lbl_ProgramsList.AutoSize = true;
            this.lbl_ProgramsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProgramsList.Location = new System.Drawing.Point(314, 35);
            this.lbl_ProgramsList.Name = "lbl_ProgramsList";
            this.lbl_ProgramsList.Size = new System.Drawing.Size(186, 31);
            this.lbl_ProgramsList.TabIndex = 2;
            this.lbl_ProgramsList.Text = "Program\'s List";
            // 
            // lbx_ProgramBox
            // 
            this.lbx_ProgramBox.FormattingEnabled = true;
            this.lbx_ProgramBox.Location = new System.Drawing.Point(205, 84);
            this.lbx_ProgramBox.Name = "lbx_ProgramBox";
            this.lbx_ProgramBox.Size = new System.Drawing.Size(416, 199);
            this.lbx_ProgramBox.TabIndex = 3;
            // 
            // btn_DeleteFile
            // 
            this.btn_DeleteFile.Location = new System.Drawing.Point(358, 394);
            this.btn_DeleteFile.Name = "btn_DeleteFile";
            this.btn_DeleteFile.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteFile.TabIndex = 4;
            this.btn_DeleteFile.Text = "Delete File";
            this.btn_DeleteFile.UseVisualStyleBackColor = true;
            this.btn_DeleteFile.Click += new System.EventHandler(this.btn_DeleteFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DeleteFile);
            this.Controls.Add(this.lbx_ProgramBox);
            this.Controls.Add(this.lbl_ProgramsList);
            this.Controls.Add(this.btn_RunApps);
            this.Controls.Add(this.btn_OpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_RunApps;
        private System.Windows.Forms.Label lbl_ProgramsList;
        private System.Windows.Forms.ListBox lbx_ProgramBox;
        private System.Windows.Forms.Button btn_DeleteFile;
    }
}

