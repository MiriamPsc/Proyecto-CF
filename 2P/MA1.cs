using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2P
{
    public partial class MA1 : Form
    {
        Salida Exit = new Salida();
        Form MenuPrimero = new Primero();
        string carpeta, archivo;
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
            this.Hide();
        }
        private void BtnCalificar_Click(object sender, EventArgs e)
        {
            if (cbb1.Text == "1" &&
                cbb2.Text == "5" &&
                cbb3.Text == "8" &&
                cbb4.Text == "9" &&
                cbb5.Text == "6" &&
                cbb6.Text == "7" &&
                cbb7.Text == "3" &&
                cbb8.Text == "4" &&
                cbb9.Text == "2")
            {
                label11.Text = ("EXCELENTE");
            }
            else if (cbb1.Text!="1")
            {
                label11.Text = ("INTENTA DE NUEVO");
            }
            else if (cbb2.Text != "5")
            {
                label11.Text = ("INTENTA DE NUEVO");
            }
            else if (cbb3.Text != "8")
            {
                label11.Text = ("INTENTA DE NUEVO");
            }
            else if (cbb4.Text != "9")
            {
                label11.Text = ("INTENTA DE NUEVO");
            }
            else if (cbb5.Text != "6")
            {
                label11.Text = ("INTENTA DE NUEVO");
            }
            else if (cbb6.Text != "7")
            {
                label11.Text = ("INTENTA DE NUEVO");
            }
            else if (cbb7.Text != "3")
            {
                label11.Text = ("INTENTA DE NUEVO");
            }
            else if (cbb8.Text != "4")
            {
                label11.Text = ("INTENTA DE NUEVO");
            }
            else if (cbb9.Text != "2")
            {
                label11.Text = ("INTENTA DE NUEVO");
            }
        }

        private void MA1_Load(object sender, EventArgs e)
        {
            AbrirTexto();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (rbt1.Checked == true)
            {
                lbl.Text = ("MUY BIEN");
            }
            else if (rbt2.Checked == true)
            {
                lbl.Text = ("INTENTA DE NUEVO");
            }
            else if (rbt3.Checked == true)
            {
                lbl.Text = ("INTENTA DE NUEVO");
            }
        }

        public void AbrirTexto()
        {
            carpeta = @"C:\Users\miria\Desktop\PROYECTOCF\LAVACAPACA.txt";
            archivo = File.ReadAllText(carpeta);
            textBox1.Text = archivo;
        }

    }
}
