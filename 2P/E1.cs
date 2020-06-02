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
        int Calificacion, resp1, resp2, resp3;
     
        public E1()
        {
            InitializeComponent();
            Calificacion = 0;
            resp1 = 3;
            resp2 = 1;
            resp3 = 2;

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
            {
                if (cb1.Checked == true)
                {
                    Calificacion = 2;
                }
                else if (cb2.Checked == true)
                {
                    Calificacion = (Calificacion - 1);
                }
                else if (cb3.Checked == true)
                {
                    Calificacion = (Calificacion - 1);
                }
                else if (cb4.Checked == true)
                {
                    Calificacion = (Calificacion + 2);
                    if (cb4.Checked == false)
                    {
                        Calificacion = (Calificacion - 1);
                    }
                }
                else if (cb5.Checked == true)
                {
                    Calificacion = (Calificacion + 2);
                    if (cb5.Checked == false)
                    {
                        Calificacion = (Calificacion - 1);
                    }
                }
                else if (cb6.Checked == true)
                {
                    Calificacion = (Calificacion - 1);
                }
                else if (cb7.Checked == true)
                {
                    Calificacion = (Calificacion - 1);
                }
                else if (cb8.Checked == true)
                {
                    Calificacion = (Calificacion - 1);
                }
                else if (cb9.Checked == true)
                {
                    Calificacion = (Calificacion + 2);
                    if (cb9.Checked == false)
                    {
                        Calificacion = (Calificacion - 1);
                    }
                }
                else if (cb10.Checked == true)
                {
                    Calificacion = (Calificacion - 1);

                }

                lblCalificacion.Text = ("" + Calificacion);
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youtu.be/2REkk9SCRn0");
        }

        public void Pregunta1()
        {
           if(rb3.Checked==true)
            {
                lbl1.Text = ("MUY BIEN");
            }
           else if(rb2.Checked==true)
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
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
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
                calif3.Text=("EXCELENTE");
            }
            else if(resp1!=iresp1)
            {
                calif3.Text = ("VUELVE A INTENTARLO");
            }
            else if (resp2 !=iresp2)
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
