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
        public static frm_Desarrolladores frm_desarrolladores;
        public static frm_Desarrollador frm_desarrollador;
        public static frm_Proyectos frm_proyectos;
        public static frm_Proyecto frm_proyecto;

        public frm_Principal()
        {
            InitializeComponent();
            frm_desarrolladores = new frm_Desarrolladores();
            frm_desarrollador = new frm_Desarrollador();
            frm_proyectos = new frm_Proyectos();
            frm_proyecto = new frm_Proyecto();
        }

        private void btn_desarrolladores_Click(object sender, EventArgs e)
        {
            frm_desarrolladores.Show();
        }

        private void btn_proyectos_Click(object sender, EventArgs e)
        {
            frm_proyectos.Show();

        }
    }
}
