using System;

namespace ATEC_OOP_Desktop_form
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
            this.button1 = new System.Windows.Forms.Button();
            this.Filename = new System.Windows.Forms.TextBox();
            this.Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(185, 168);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(165, 20);
            this.Filename.TabIndex = 1;
            this.Filename.TextChanged += new System.EventHandler(this.Filename_TextChanged);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(274, 254);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(145, 43);
            this.Export.TabIndex = 2;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 437);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.Button Export;
    }
}

