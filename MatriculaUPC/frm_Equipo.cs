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
    public partial class frm_Equipo : Form
    {
        public Proyecto proyecto = null;
   
        public frm_Equipo()
        {
            InitializeComponent();
        }

        private decimal GetAvanceDesarrollador(int DesarrolladorId)
        {
            decimal avance = 0;
            avance = Convert.ToDecimal(Program.ctx.Avances.Where(x => x.ProyectoId == proyecto.ProyectoId && x.DesarrolladorReponsableId == DesarrolladorId).AsEnumerable().Sum(o => o.Porcentaje));

            return avance;
        }

        private decimal GetHorasDesarrollador(int DesarrolladorId)
        {
            decimal horas = 0;
            horas = Convert.ToDecimal(Program.ctx.Avances.Where(x => x.ProyectoId == proyecto.ProyectoId && x.DesarrolladorReponsableId == DesarrolladorId).AsEnumerable().Sum(o => o.Horas));

            return horas;
        }

        public void Preparar(int ProyectoId)
        {
            proyecto = Program.ctx.Proyectoes.Find(ProyectoId);
            this.Text = "Equipo de " + proyecto.Nombre;

            var lista = Program.ctx.DesarrolladorProyectoes.Where(x => x.ProyectoId == ProyectoId).AsEnumerable().Select(x => new
                {
                    FechaAsociacion = x.Fecha,
                    SiglasDocumento = x.Desarrollador.TipoDocumento.Siglas,
                    NumeroDocumento = x.Desarrollador.NroDocumento,
                    NombreApellido = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                    PorcentajeAvance = GetAvanceDesarrollador(x.DesarrolladorId),
                    HorasTotales = GetHorasDesarrollador(x.DesarrolladorId),
                }).ToList();

            datagridview.DataSource = lista;

            foreach (DataGridViewColumn col in datagridview.Columns)
            {
                switch (col.Name)
                {
                    case "FechaAsociacion":
                        col.HeaderText = "Fecha de Asociación";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 35;
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
                    case "NombreApellido":
                        col.HeaderText = "Nombre Completo";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 65;
                        break;
                    case "PorcentajeAvance":
                        col.HeaderText = "Porcentaje";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "HorasTotales":
                        col.HeaderText = "Horas";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        public void Cerrar()
        {
            this.Hide();
            datagridview.DataSource = null;
            Program.frm_proyectos.Activate();
        }
    }
}
