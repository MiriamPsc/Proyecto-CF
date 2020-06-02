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
    public partial class MA1 : Form
    {
        Salida Exit = new Salida();
        Form MenuPrimero = new Primero();
        public MA1()
        {
            InitializeComponent();
        }

        private void MA1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit.Salir();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MenuPrimero.Show();
        }
    }
}
