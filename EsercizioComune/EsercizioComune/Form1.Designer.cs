﻿namespace EsercizioComune
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
            this.btnRiccardo = new System.Windows.Forms.Button();
            this.lblTesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRiccardo
            // 
            this.btnRiccardo.Location = new System.Drawing.Point(12, 84);
            this.btnRiccardo.Name = "btnRiccardo";
            this.btnRiccardo.Size = new System.Drawing.Size(95, 23);
            this.btnRiccardo.TabIndex = 0;
            this.btnRiccardo.Text = "Mostra Riccardo";
            this.btnRiccardo.UseVisualStyleBackColor = true;
            this.btnRiccardo.Click += new System.EventHandler(this.btnRiccardo_Click);
            // 
            // lblTesto
            // 
            this.lblTesto.AutoSize = true;
            this.lblTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesto.Location = new System.Drawing.Point(47, 22);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(290, 31);
            this.lblTesto.TabIndex = 2;
            this.lblTesto.Text = "Visualizzazione testo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 280);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.btnRiccardo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRiccardo;
        private System.Windows.Forms.Label lblTesto;
    }
}

