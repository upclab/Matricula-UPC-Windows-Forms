﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaUPC
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
            
        }

        private void btn_desarrolladores_Click(object sender, EventArgs e)
        {
            Program.frm_desarrolladores.Show();
        }

        private void btn_proyectos_Click(object sender, EventArgs e)
        {
            Program.frm_proyectos.Show();

        }
    }
}
