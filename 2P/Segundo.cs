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
    public partial class Segundo : Form
    {
        Salida Exit = new Salida();

        public Segundo()
        {
            InitializeComponent();
        }

        private void Segundo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit.Salir();
        }
    }
}
