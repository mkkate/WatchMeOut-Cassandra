﻿
namespace WatchMeOut
{
    partial class BrisanjeFilmaForm
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
            this.lblAdminBrisanje = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminBrisanje
            // 
            this.lblAdminBrisanje.AutoSize = true;
            this.lblAdminBrisanje.Location = new System.Drawing.Point(52, 40);
            this.lblAdminBrisanje.Name = "lblAdminBrisanje";
            this.lblAdminBrisanje.Size = new System.Drawing.Size(177, 13);
            this.lblAdminBrisanje.TabIndex = 0;
            this.lblAdminBrisanje.Text = "Unesite sifru da biste izvrsili brisanje:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(88, 75);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 20);
            this.txtSifra.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(97, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // BrisanjeFilmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 196);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.lblAdminBrisanje);
            this.Name = "BrisanjeFilmaForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminBrisanje;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Button btnOK;
    }
}