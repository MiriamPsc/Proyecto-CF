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
    public partial class E1 : Form
    {
        Form MenuPrimero = new Primero();
        Salida Exit = new Salida();

        public E1()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MenuPrimero.Show();
        }

        private void E1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit.Salir();

        }
    }
}
