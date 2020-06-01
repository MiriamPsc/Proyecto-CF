using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2P
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
        }
        
        private void P1_Click(object sender, EventArgs e)
        {
            Form PrimerGrado = new Primero();
            PrimerGrado.Show();
            this.Hide();
        }

        private void P2_Click(object sender, EventArgs e)
        {
           Form SegundoGrado = new Segundo();
            SegundoGrado.Show();
            this.Hide();

        }

        private void P3_Click(object sender, EventArgs e)
        {
            Form TercerGrado = new Tercero();
            TercerGrado.Show();
            this.Hide();

        }

        private void P4_Click(object sender, EventArgs e)
        {
            Form CuartoGrado = new Cuarto();
            CuartoGrado.Show();
            this.Hide();
        
        }

        private void P5_Click(object sender, EventArgs e)
        {
            Form QuintoGrado = new Quinto();
            QuintoGrado.Show();
            this.Hide();
        }

        private void P6_Click(object sender, EventArgs e)
        {
            Form SextoGrado = new Sexto();
            SextoGrado.Show();
            this.Hide();
        }
    }
}
