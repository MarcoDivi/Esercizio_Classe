using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercizioComune
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRiccardo_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "Riccardo Somigli";
        }

        private void btnNurul_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "Nurul Najmul";
        }

        private void btnRusso_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "Mattia Russo";
        }

        private void btnCini_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "Lorenzo Cini ";
        }

        private void btnDangelo_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "Gabriele D'Angelo ";
        }

        private void buttonTarchi_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "Lorenzo Tarchi ";
        }

        private void btnVannozzi_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "Tommaso Vannozzi";
        }

        private void BTN_Landi_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "Federico Landi ";
        }

        private void btnNerucci_Click(object sender, EventArgs e)
        {
            lblTesto.Text = "Nerucci Davide ";
        }
    }
}
