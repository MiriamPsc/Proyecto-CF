using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace _2P
{
    public partial class E1 : Form
    {
        Form MenuPrimero = new Primero();
        Salida Exit = new Salida();
        int resp1, resp2, resp3, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, t;
        bool c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;

        public E1()
        {
            InitializeComponent();
            resp1 = 3;
            resp2 = 1;
            resp3 = 2;
            c1 = cb1.Checked;
            c2 = cb2.Checked;
            c3 = cb3.Checked;
            c4 = cb4.Checked;
            c5 = cb5.Checked;
            c6 = cb6.Checked;
            c7 = cb7.Checked;
            c8 = cb8.Checked;
            c9 = cb9.Checked;
            c10 = cb10.Checked;

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MenuPrimero.Show();
        }

        private void E1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit.Salir();

        }

        //REVISAR ESTO PARA LOS PUNTOS


        private void BtnCalificar_Click(object sender, EventArgs e)
        {
            switch (c1)
            {
                case true:
                    c11 = 2;
                    break;
                case false:
                    c11 = 0;
                    break;
            }
            switch (c2)
            {
                case true:
                    c12 = -2;
                    break;
            }
            switch (c3)
            {
                case true:
                    c13 = -2;
                    break;
            }
            switch (c4)
            {
                case true:
                    c14 = 2;
                    break;
            }
            switch (c5)
            {
                case true:
                    c15 = 2;
                    break;
            }
            switch (c6)
            {
                case true:
                    c16 = -2;
                    break;
            }
            switch (c7)
            {
                case true:
                    c17 = c17 - 2;
                    break;
            }
            switch (c8)
            {
                case true:
                    c18 = -2;
                    break;
            }
            switch (c9)
            {
                case true:
                    c19 = 2;
                    break;
            }
            switch (c10)
            {
                case true:
                    c20 = 2;
                    break;
            }
            t = c11 + c12 + c13 + c14 + c15 + c16 + c17 + c18 + c19 + c20;
            lblCalificacion.Text = ("" + t);

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youtu.be/2REkk9SCRn0");
        }

        public void Pregunta1()
        {
            if (rb3.Checked == true)
            {
                lbl1.Text = ("MUY BIEN");
            }
            else if (rb2.Checked == true)
            {
                lbl1.Text = ("INTENTA DE NUEVO");
            }
            else if (rb1.Checked == true)
            {
                lbl1.Text = ("INTENTA DE NUEVO");
            }
        }
        public void Pregunta2()
        {
            if (rb6.Checked == true)
            {
                lbl2.Text = ("MUY BIEN");
            }
            else if (rb5.Checked == true)
            {
                lbl2.Text = ("INTENTA DE NUEVO");
            }
            else if (rb4.Checked == true)
            {
                lbl2.Text = ("INTENTA DE NUEVO");
            }
        }

        private void R1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void R2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void R3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void Pregunta3()
        {
            if (rb9.Checked == true)
            {
                lbl3.Text = ("MUY BIEN");
            }
            else if (rb7.Checked == true)
            {
                lbl3.Text = ("INTENTA DE NUEVO");
            }
            else if (rb8.Checked == true)
            {
                lbl3.Text = ("INTENTA DE NUEVO");
            }
        }

        private void BtnCalificar2_Click(object sender, EventArgs e)
        {
            Pregunta1();
            Pregunta2();
            Pregunta3();

        }

        private void BtnCalificar4_Click(object sender, EventArgs e)
        {
            int iresp1 = int.Parse(r1.Text);
            int iresp2 = int.Parse(r2.Text);
            int iresp3 = int.Parse(r3.Text);

            if (resp1 == iresp1 && resp2 == iresp2 && resp3 == iresp3)
            {
                calif3.Text = ("EXCELENTE");
            }
            else if (resp1 != iresp1)
            {
                calif3.Text = ("VUELVE A INTENTARLO");
            }
            else if (resp2 != iresp2)
            {
                calif3.Text = ("VUELVE A INTENTARLO");
            }
            else if (resp3 != iresp3)
            {
                calif3.Text = ("VUELVE A INTENTARLO");
            }

        }
    }
}
