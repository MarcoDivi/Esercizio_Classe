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
            this.btnRiccardo = new System.Windows.Forms.Button();
            this.lblTesto = new System.Windows.Forms.Label();
            this.btnNurul = new System.Windows.Forms.Button();
            this.btnRusso = new System.Windows.Forms.Button();
            this.btnCini = new System.Windows.Forms.Button();
            this.btnDangelo = new System.Windows.Forms.Button();
            this.buttonTarchi = new System.Windows.Forms.Button();
            this.btnVannozzi = new System.Windows.Forms.Button();
            this.BTN_Landi = new System.Windows.Forms.Button();
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
            // btnNurul
            // 
            this.btnNurul.Location = new System.Drawing.Point(12, 126);
            this.btnNurul.Name = "btnNurul";
            this.btnNurul.Size = new System.Drawing.Size(95, 23);
            this.btnNurul.TabIndex = 3;
            this.btnNurul.Text = "Mostra Nurul";
            this.btnNurul.UseVisualStyleBackColor = true;
            this.btnNurul.Click += new System.EventHandler(this.btnNurul_Click);
            // 
            // btnRusso
            // 
            this.btnRusso.Location = new System.Drawing.Point(12, 165);
            this.btnRusso.Name = "btnRusso";
            this.btnRusso.Size = new System.Drawing.Size(95, 23);
            this.btnRusso.TabIndex = 4;
            this.btnRusso.Text = "Mostra Russo";
            this.btnRusso.UseVisualStyleBackColor = true;
            this.btnRusso.Click += new System.EventHandler(this.btnRusso_Click);
            // 
            // btnCini
            // 
            this.btnCini.Location = new System.Drawing.Point(12, 206);
            this.btnCini.Name = "btnCini";
            this.btnCini.Size = new System.Drawing.Size(95, 23);
            this.btnCini.TabIndex = 5;
            this.btnCini.Text = "Mostra Cini";
            this.btnCini.UseVisualStyleBackColor = true;
            this.btnCini.Click += new System.EventHandler(this.btnCini_Click);
            // 
            // btnDangelo
            // 
            this.btnDangelo.Location = new System.Drawing.Point(12, 245);
            this.btnDangelo.Name = "btnDangelo";
            this.btnDangelo.Size = new System.Drawing.Size(95, 23);
            this.btnDangelo.TabIndex = 6;
            this.btnDangelo.Text = "Mostra D\'Angelo";
            this.btnDangelo.UseVisualStyleBackColor = true;
            this.btnDangelo.Click += new System.EventHandler(this.btnDangelo_Click);
            // 
            // buttonTarchi
            // 
            this.buttonTarchi.Location = new System.Drawing.Point(139, 84);
            this.buttonTarchi.Name = "buttonTarchi";
            this.buttonTarchi.Size = new System.Drawing.Size(95, 23);
            this.buttonTarchi.TabIndex = 7;
            this.buttonTarchi.Text = "Mostra Tarchi";
            this.buttonTarchi.UseVisualStyleBackColor = true;
            this.buttonTarchi.Click += new System.EventHandler(this.buttonTarchi_Click);
            // 
            // btnVannozzi
            // 
            this.btnVannozzi.Location = new System.Drawing.Point(139, 126);
            this.btnVannozzi.Name = "btnVannozzi";
            this.btnVannozzi.Size = new System.Drawing.Size(95, 23);
            this.btnVannozzi.TabIndex = 8;
            this.btnVannozzi.Text = "Mostra Vannozzi";
            this.btnVannozzi.UseVisualStyleBackColor = true;
            this.btnVannozzi.Click += new System.EventHandler(this.btnVannozzi_Click);
            // 
            // BTN_Landi
            // 
            this.BTN_Landi.Location = new System.Drawing.Point(139, 165);
            this.BTN_Landi.Name = "BTN_Landi";
            this.BTN_Landi.Size = new System.Drawing.Size(95, 23);
            this.BTN_Landi.TabIndex = 9;
            this.BTN_Landi.Text = "Mostra Landi";
            this.BTN_Landi.UseVisualStyleBackColor = true;
            this.BTN_Landi.Click += new System.EventHandler(this.BTN_Landi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 280);
            this.Controls.Add(this.BTN_Landi);
            this.Controls.Add(this.btnVannozzi);
            this.Controls.Add(this.buttonTarchi);
            this.Controls.Add(this.btnDangelo);
            this.Controls.Add(this.btnCini);
            this.Controls.Add(this.btnRusso);
            this.Controls.Add(this.btnNurul);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.btnRiccardo);
            this.Name = "Form1";
            this.Text = "Esercizio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRiccardo;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.Button btnNurul;
        private System.Windows.Forms.Button btnRusso;
        private System.Windows.Forms.Button btnCini;
        private System.Windows.Forms.Button btnDangelo;
        private System.Windows.Forms.Button buttonTarchi;
        private System.Windows.Forms.Button btnVannozzi;
        private System.Windows.Forms.Button BTN_Landi;
    }
}

