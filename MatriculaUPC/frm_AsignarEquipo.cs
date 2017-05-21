using System;
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
    public partial class frm_AsignarEquipo : Form
    {
        public frm_AsignarEquipo()
        {
            InitializeComponent();
        }

        public void Preparar(int ProyectoId)
        {

        }

        public void Cerrar()
        {
            this.Hide();
            Program.frm_proyectos.Activate();
        }
    }
}
