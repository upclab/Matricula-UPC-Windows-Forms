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
    public partial class frm_Desarrolladores : Form
    {
        public frm_Desarrolladores()
        {
            InitializeComponent();
            RefrescarGrilla();
        }

        public void RefrescarGrilla(object lista = null)
        {
            if (lista == null)
            {
                lista = Program.ctx.Desarrolladors.Select(x => new
                    {
                        DesarrolladorId = x.DesarrolladorId,
                        SiglasDeDocumento = x.TipoDocumento.Siglas,
                        NroDocumento = x.NroDocumento,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                    }).ToList();
            }
            
            dataGridView1.DataSource = lista;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                switch (col.Name)
                {
                    case "DesarrolladorId":
                        col.Visible = false;
                        break;
                    case "SiglasDeDocumento":
                        col.HeaderText = "Siglas de Documento";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 15;
                        break;
                    case "NroDocumento":
                        col.HeaderText = "Nro de Documento";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "Nombre":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 50;
                        break;
                    case "Apellido":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 50;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frm_principal.Activate();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Program.frm_desarrollador.Show();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            String texto = txt_filtro.Text;
            object lista = null;

            if  (Validators.TextoVacio(texto) == false)
            {
                lista = Program.ctx.Desarrolladors
                    .Where(x => x.Nombre.Contains(texto) || texto.Contains(x.Nombre) || x.Apellido.Contains(texto) || texto.Contains(x.Apellido))
                    .Select(x => new {
                        DesarrolladorId = x.DesarrolladorId,
                        SiglasDeDocumento = x.TipoDocumento.Siglas,
                        NroDocumento = x.NroDocumento,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                    }).ToList();
            }

            RefrescarGrilla(lista);
        }
    }
}
