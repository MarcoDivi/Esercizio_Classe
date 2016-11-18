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
    }
}
