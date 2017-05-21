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
    public partial class frm_Proyectos : Form
    {
        public frm_Proyectos()
        {
            InitializeComponent();
            RefrescarGrilla();
        }

        private decimal GetAvance(int ProyectoId)
        {
            decimal avance = 0;
            avance = Convert.ToDecimal(Program.ctx.Avances.Where(x => x.ProyectoId == ProyectoId).AsEnumerable().Sum(o => o.Porcentaje));

            return avance;
        }

        private decimal GetHoras(int ProyectoId)
        {
            decimal horas = 0;
            horas = Convert.ToDecimal(Program.ctx.Avances.Where(x => x.ProyectoId == ProyectoId).AsEnumerable().Sum(o => o.Horas));

            return horas;
        }

        public void RefrescarGrilla(object lista = null)
        {
            if (lista == null)
            {
                lista = Program.ctx.Proyectoes.AsEnumerable().Select(x => new
                {
                    ProyectoId = x.ProyectoId,
                    Finalizado = x.EstaFinalizado,
                    Fecha = x.Fecha,
                    Nombre = x.Nombre,
                    DesarrolladorReponsable = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                    PorcentajeAcumulado = GetAvance(x.ProyectoId),
                    HorasTotales = GetHoras(x.ProyectoId),
                }).ToList();
            }

            datagridview.DataSource = lista;

            foreach (DataGridViewColumn col in datagridview.Columns)
            {
                switch (col.Name)
                {
                    case "ProyectoId":
                        col.Visible = false;
                        break;
                    case "Finalizado":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 20;
                        break;
                    case "Fecha":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 20;
                        break;
                    case "Nombre":
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 50;
                        break;
                    case "DesarrolladorReponsable":
                        col.HeaderText = "Desarrollador Responsable";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 100;
                        break;
                    case "PorcentajeAcumulado":
                        col.HeaderText = "Porcentaje acumulado";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    case "HorasTotales":
                        col.HeaderText = "Horas Totales";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.FillWeight = 30;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Program.frm_proyecto.PrepararModoAgregar();
            Program.frm_proyecto.Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor seleccione una fila!");
                return;
            }

            Program.frm_proyecto.PrepararModoEditar(Convert.ToInt32(datagridview.SelectedRows[0].Cells[0].Value));
            try
            {
                Program.frm_proyecto.Show();
            }
            catch (Exception ex)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            String texto = txt_filtro.Text;
            object lista = null;

            if (Validators.TextoVacio(texto) == false)
            {
                lista = Program.ctx.Proyectoes
                    .Where(x => x.Nombre.Contains(texto) || texto.Contains(x.Nombre) || x.Descripcion.Contains(texto) || texto.Contains(x.Descripcion))
                    .AsEnumerable().Select(x => new
                    {
                        ProyectoId = x.ProyectoId,
                        Finalizado = x.EstaFinalizado,
                        Fecha = x.Fecha,
                        Nombre = x.Nombre,
                        DesarrolladorReponsable = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                        PorcentajeAcumulado = GetAvance(x.ProyectoId),
                        HorasTotales = GetHoras(x.ProyectoId),
                    }).ToList();
            }

            RefrescarGrilla(lista);
        }

        private void btn_ver_equipo_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor seleccione una fila!");
                return;
            }

            Program.frm_equipo.Preparar(Convert.ToInt32(datagridview.SelectedRows[0].Cells[0].Value));
            try
            {
                Program.frm_equipo.Show();
            }
            catch (Exception ex)
            {
                btn_ver_equipo_Click(sender, e);
            }
        }

        private void btn_asociar_equipo_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor seleccione una fila!");
                return;
            }

            Program.frm_asignar_equipo.Preparar(Convert.ToInt32(datagridview.SelectedRows[0].Cells[0].Value));
            try
            {
                Program.frm_asignar_equipo.Show();
            }
            catch (Exception ex)
            {
                btn_asociar_equipo_Click(sender, e);
            }
        }

        private void btn_avances_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor seleccione una fila!");
                return;
            }

            Program.frm_avances.Preparar(Convert.ToInt32(datagridview.SelectedRows[0].Cells[0].Value));
            try
            {
                Program.frm_avances.Show();
            }
            catch (Exception ex)
            {
                btn_avances_Click(sender, e);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frm_principal.Activate();
        }
    }
}
