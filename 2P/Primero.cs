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
    public partial class Primero : Form
    {
        Form Volver = new Inicio();
        public Primero()
        {
            InitializeComponent();
        }

        private void E1_Click(object sender, EventArgs e)
        {
            Form Español1 = new E1();
            Español1.Show();
            this.Hide();
        }

        private void M2_Click(object sender, EventArgs e)
        {
            Form Mate1 = new M1();
            Mate1.Show();
            this.Hide();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Form MA1 = new MA1();
            MA1.Show();
            this.Hide();
        }

        private void Primero_FormClosed(object sender, FormClosedEventArgs e)
        {
            Volver.Show();
        }
    }
}
