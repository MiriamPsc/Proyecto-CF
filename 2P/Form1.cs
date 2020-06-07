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
        Salida Exit = new Salida();
        IDeshabilitar D = new Deshab();

        public Inicio()
        {
            InitializeComponent();

        }

        private void P1_Click(object sender, EventArgs e)
        {
            Form PrimerGrado = new Primero();
            PrimerGrado.Show();
            Hide();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit.Salir();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            P2.Enabled = D.Limpiar();
            P3.Enabled = D.Limpiar();
            P4.Enabled = D.Limpiar();
            P5.Enabled = D.Limpiar();
            P6.Enabled = D.Limpiar();
        }
        
        

    }
}
