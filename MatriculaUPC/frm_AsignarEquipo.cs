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
        public Proyecto proyecto = null;

        public frm_AsignarEquipo()
        {
            InitializeComponent();
        }

        public void Preparar(int ProyectoId)
        {
            proyecto = Program.ctx.Proyectoes.Find(ProyectoId);
            this.Text = "Asignar desarrollador a " + proyecto.Nombre;

            var desarrolladores = Program.ctx.Desarrolladors.ToList();
            var desarrolladores_en_el_equipo = Program.ctx.DesarrolladorProyectoes.Where(x => x.ProyectoId == ProyectoId).ToList();

            var lista = desarrolladores
                .Where(x => desarrolladores_en_el_equipo.Any(y => y.DesarrolladorId == x.DesarrolladorId) == false)
                .OrderBy(x => x.Apellido)
                .ThenBy(x => x.Nombre)
                .Select(x => new
                {
                    DesarrolladorId = x.DesarrolladorId,
                    SiglasDocumento = x.TipoDocumento.Siglas,
                    NumeroDocumento = x.NroDocumento,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                })
                .ToList();

            datagridview.DataSource = lista;

            foreach (DataGridViewColumn col in datagridview.Columns)
            {
                switch (col.Name)
                {
                    case "DesarrolladorId":
                        col.Visible = false;
                        break;
                    case "SiglasDocumento":
                        col.HeaderText = "Documento";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 35;
                        break;
                    case "NumeroDocumento":
                        col.HeaderText = "Nro Documento";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 50;
                        break;
                    case "Nombre":
                        col.HeaderText = "Nombre";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 70;
                        break;
                    case "Apellido":
                        col.HeaderText = "Apellido";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 70;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor seleccione una fila!");
                return;
            }

            int DesarrolladorID = Convert.ToInt32(datagridview.SelectedRows[0].Cells[0].Value);

            DesarrolladorProyecto dp = new DesarrolladorProyecto();
            dp.DesarrolladorId = DesarrolladorID;
            dp.ProyectoId = proyecto.ProyectoId;
            dp.Fecha = DateTime.Now;

            Program.ctx.DesarrolladorProyectoes.Add(dp);

            Program.ctx.SaveChanges();

            Preparar(proyecto.ProyectoId);

            if (Program.frm_equipo.proyecto != null && Program.frm_equipo.proyecto.ProyectoId == proyecto.ProyectoId)
            {
                Program.frm_equipo.Preparar(proyecto.ProyectoId);
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
