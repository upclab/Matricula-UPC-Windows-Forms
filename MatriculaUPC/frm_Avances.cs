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
    public partial class frm_Avances : Form
    {
        public Proyecto proyecto = null;
 
        public frm_Avances()
        {
            InitializeComponent();
        }

        public void Preparar(int ProyectoId)
        {
            proyecto = Program.ctx.Proyectoes.Find(ProyectoId);
            this.Text = "Avances de " + proyecto.Nombre;

            var lista = Program.ctx.Avances
                .Where(x => x.ProyectoId == ProyectoId)
                .AsEnumerable()
                .OrderByDescending(x => x.Fecha.Year)
                .ThenByDescending(x => x.Fecha.Month)
                .ThenByDescending(x => x.Fecha.Day)
                .Select(x => new
                {
                    AvanceId = x.AvanceId,
                    FechaAvance = x.Fecha.Date,
                    SiglasDeDocumento = x.Desarrollador.TipoDocumento.Siglas,
                    NombreCompleto = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                    Porcentaje = x.Porcentaje,
                    Horas = x.Horas,
                })
                .ToList();

            datagridview.DataSource = lista;

            foreach (DataGridViewColumn col in datagridview.Columns)
            {
                switch (col.Name)
                {
                    case "AvanceId":
                        col.Visible = false;
                        break;
                    case "FechaAvance":
                        col.HeaderText = "Fecha";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 20;
                        break;
                    case "SiglasDeDocumento":
                        col.HeaderText = "Documento";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "NombreCompleto":
                        col.HeaderText = "Nombre Completo";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 60;
                        break;
                    case "Porcentaje":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "Horas":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }

        }

        public void ActualizarOtrosFormularios()
        {
            Preparar(proyecto.ProyectoId);

            if (Program.frm_proyectos.Visible)
            {
                Program.frm_proyectos.RefrescarGrilla();
            }

            if (Program.frm_equipo.proyecto != null && Program.frm_equipo.proyecto.ProyectoId == proyecto.ProyectoId)
            {
                Program.frm_equipo.Preparar(proyecto.ProyectoId);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor seleccione una fila!");
                return;
            }
            int AvanceId = Convert.ToInt32(datagridview.SelectedRows[0].Cells[0].Value);
            Program.ctx.Avances.Remove(Program.ctx.Avances.Find(AvanceId));
            Program.ctx.SaveChanges();
            ActualizarOtrosFormularios();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Program.frm_avance.proyecto = proyecto;
                Program.frm_avance.Show();
            }
            catch (Exception ex)
            {
                btn_registrar_Click(sender, e);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        public void Cerrar()
        {
            this.Hide();
            proyecto = null;
            datagridview.DataSource = null;
            Program.frm_proyectos.Activate();
        }
    }
}
