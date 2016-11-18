namespace EsercizioComune
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
            this.btnPersona = new System.Windows.Forms.Button();
            this.cbPersona = new System.Windows.Forms.ComboBox();
            this.lblTesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(167, 129);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(75, 23);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Mostra";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // cbPersona
            // 
            this.cbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersona.FormattingEnabled = true;
            this.cbPersona.Items.AddRange(new object[] {
            "Riccardo Somigli"});
            this.cbPersona.Location = new System.Drawing.Point(89, 41);
            this.cbPersona.Name = "cbPersona";
            this.cbPersona.Size = new System.Drawing.Size(233, 21);
            this.cbPersona.TabIndex = 1;
            // 
            // lblTesto
            // 
            this.lblTesto.AutoSize = true;
            this.lblTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesto.Location = new System.Drawing.Point(118, 196);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(179, 20);
            this.lblTesto.TabIndex = 2;
            this.lblTesto.Text = "Visualizzazione testo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 280);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.cbPersona);
            this.Controls.Add(this.btnPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.ComboBox cbPersona;
        private System.Windows.Forms.Label lblTesto;
    }
}

