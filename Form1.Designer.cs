﻿namespace LabComparison
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
            this.importBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(111, 42);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(190, 41);
            this.importBtn.TabIndex = 0;
            this.importBtn.Text = "Import Database (JSON)";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 113);
            this.Controls.Add(this.importBtn);
            this.Name = "Form1";
            this.Text = "Import Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importBtn;
    }
}

