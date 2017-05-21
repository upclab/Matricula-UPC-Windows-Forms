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
    public partial class frm_Principal : Form
    {
        public static frm_Desarrolladores frm_desarrollares;

        public frm_Principal()
        {
            InitializeComponent();
            frm_desarrollares = new frm_Desarrolladores();
        }

        private void btn_desarrolladores_Click(object sender, EventArgs e)
        {
            frm_desarrollares.Show();
        }
    }
}
