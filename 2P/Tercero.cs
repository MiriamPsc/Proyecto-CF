﻿using System;
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
    public partial class Tercero : Form
    {
        Salida Exit = new Salida();

        public Tercero()
        {
            InitializeComponent();
        }

        private void Tercero_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit.Salir();
        }
    }
}
