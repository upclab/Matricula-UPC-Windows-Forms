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
    public partial class frm_Reportes : Form
    {
        public frm_Reportes()
        {
            InitializeComponent();
        }

        private void frm_Reportes_Load(object sender, EventArgs e)
        {
            var responsables = Program.ctx.Proyectoes
                .GroupBy(x => new
                {
                    x.Desarrollador,
                })
                .Select(x => new
                {
                    Siglas = x.Key.Desarrollador.TipoDocumento.Siglas,
                    NroDocumento = x.Key.Desarrollador.NroDocumento,
                    Nombre = x.Key.Desarrollador.Nombre,
                    Apellido = x.Key.Desarrollador.Apellido,
                    Finalizados = x.Sum(y => y.EstaFinalizado ? 1 : 0),
                    NoFinalizados = x.Sum(y => y.EstaFinalizado ? 0 : 1),
                    PorcentajePromedio = x.Select(y => y.Avances
                            .Where(z => z.Proyecto.EstaFinalizado == false)
                            .Average(z => z.Porcentaje))
                        .FirstOrDefault()
                })
                .ToList();

            dgv_responsables.DataSource = responsables;

            foreach (DataGridViewColumn col in dgv_responsables.Columns)
            {
                switch (col.Name)
                {
                    case "Siglas":
                        col.HeaderText = "Documento";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "NroDocumento":
                        col.HeaderText = "Nro de Documento";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "Nombre":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "Apellido":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "Finalizados":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "NoFinalizados":
                        col.HeaderText = "No Finalizados";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "PorcentajePromedio":
                        col.HeaderText = "% Promedio";
                        col.DefaultCellStyle.Format = "N2";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }

            var proyectos = Program.ctx.Avances
                .GroupBy(x => new
                {
                    x.Proyecto,
                })
                .AsEnumerable()
                .Select(x => new
                {
                    Finalizado = x.Key.Proyecto.EstaFinalizado,
                    FechaDeInicio = x.Key.Proyecto.Fecha.Date,
                    Nombre = x.Key.Proyecto.Nombre,
                    Avance = x.Sum(y => y.Porcentaje),
                    Horas = x.Sum(y => y.Horas),
                    Desarrolladores = x.Select(y => y.Proyecto
                            .DesarrolladorProyectoes.Count())
                        .FirstOrDefault(),
                    UltimaFecha = x.Max(y => y.Fecha).Date,
                    UltimoDesarrollador = x.OrderByDescending(y => y.Fecha).Select(y => y.Desarrollador.Nombre + " " + y.Desarrollador.Apellido).FirstOrDefault()
                })
                .ToList();

            dgv_proyectos.DataSource = proyectos;

            foreach (DataGridViewColumn col in dgv_proyectos.Columns)
            {
                switch (col.Name)
                {
                    case "Finalizado":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 20;
                        break;
                    case "FechaDeInicio":
                        col.HeaderText = "Fecha De Inicio";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "Nombre":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "Avance":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 20;
                        break;
                    case "Desarrolladores":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "UltimaFecha":
                        col.HeaderText = "Ultima Fecha";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "UltimoDesarrollador":
                        col.HeaderText = "Ultima Desarrollador";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void CerrarForm()
        {
            this.Hide();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            CerrarForm();
        }
    }
}
