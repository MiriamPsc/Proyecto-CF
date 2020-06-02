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
    public partial class M1 : Form
    {
        Salida Exit = new Salida();
        Form MenuPrimero = new Primero();
        int  r1=27, r2=36, r3=14, r12=240,r22=77, r32=68;
        public M1()
        {
            InitializeComponent();
            nud1.Value = 0;
            nud1.Maximum = 20;
            nud1.Minimum = 1;
            nud2.Value = 0;
            nud2.Maximum = 20;
            nud2.Minimum = 1;
            nud3.Value = 0;
            nud3.Maximum = 20;
            nud3.Minimum = 1;
        }

        private void M1_FormClosed(object sender, FormClosedEventArgs e)
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
            if(nud1.Value==16 && nud2.Value==15 && nud3.Value==14)
            {
                lblc1.Text = ("EXCELENTE");
            }
            else if(nud1.Value!=16)
            {
                lblc1.Text = ("INTENTA DE NUEVO");
            }
            else if (nud2.Value != 15)
            {
                lblc1.Text = ("INTENTA DE NUEVO");
            }
            else if (nud3.Value != 14)
            {
                lblc1.Text = ("INTENTA DE NUEVO");
            }
        }

        private void Tbt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Tbt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Tbt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void BtnCalificar3_Click(object sender, EventArgs e)
        {
            int i2resp1 = int.Parse(txb1.Text);
            int i2resp2 = int.Parse(tbx2.Text);
            int i2resp3 = int.Parse(tbx3.Text);

            if (r12 == i2resp1 && r22 == i2resp2 && r32 == i2resp3)
            {
                lblc3.Text = ("EXCELENTE");
            }
            else if (r12 != i2resp1)
            {
                lblc3.Text = ("VUELVE A INTENTARLO");
            }
            else if (r22 != i2resp2)
            {
                lblc3.Text = ("VUELVE A INTENTARLO");
            }
            else if (r32 != i2resp3)
            {
                lblc3.Text = ("VUELVE A INTENTARLO");
            }
        }

        private void BtnCalificar2_Click(object sender, EventArgs e)
        {

            int iresp1 = int.Parse(txb1.Text);
            int iresp2 = int.Parse(tbx2.Text);
            int iresp3 = int.Parse(tbx3.Text);

            if (r1 == iresp1 && r2 == iresp2 && r3 == iresp3)
            {
                lblc2.Text = ("EXCELENTE");
            }
            else if (r1 != iresp1)
            {
                lblc2.Text = ("VUELVE A INTENTARLO");
            }
            else if (r2 != iresp2)
            {
                lblc2.Text = ("VUELVE A INTENTARLO");
            }
            else if (r3 != iresp3)
            {
                lblc2.Text = ("VUELVE A INTENTARLO");
            }

        }


    }
}