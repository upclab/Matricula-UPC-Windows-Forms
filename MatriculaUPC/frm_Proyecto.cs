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
    public partial class frm_Proyecto : Form
    {
        public Proyecto proyecto = null;

        public frm_Proyecto()
        {
            InitializeComponent();
            datepicker_finicio.Value = DateTime.Now;
            combo_desarrollador.DropDownStyle = ComboBoxStyle.DropDownList;
            var lista = Program.ctx.Desarrolladors.Select(x => x.Nombre + " " + x.Apellido).ToList();
            combo_desarrollador.DataSource = lista;
        }

        private bool CamposSonValidos()
        {
            if (Validators.TextoVacio(text_nombre.Text))
                return false;
            if (Validators.TextoVacio(text_descripcion.Text))
                return false;

            return true;
        }

        private void CerrarForm()
        {
            text_nombre.Text = "";
            text_descripcion.Text = "";
            combo_desarrollador.SelectedIndex = 0;
            datepicker_finicio.Value = DateTime.Now;
            check_finalizado.Checked = false;
            this.Hide();
        }

        public void PrepararModoAgregar()
        {
            this.Text = "Agregar Proyecto";
            this.btn_agregar.Text = "Agregar";
            proyecto = null;
        }

        public void PrepararModoEditar(int ProyectoId)
        {
            this.Text = "Editar Proyecto";
            this.btn_agregar.Text = "Guardar";
            proyecto = Program.ctx.Proyectoes.Find(ProyectoId);
            Desarrollador d = Program.ctx.Desarrolladors.Find(proyecto.DesarrolladorReponsableId);
            text_nombre.Text = proyecto.Nombre;
            text_descripcion.Text = proyecto.Descripcion;
            combo_desarrollador.SelectedItem = d.Nombre + " " + d.Apellido;
            datepicker_finicio.Value = proyecto.Fecha;
            check_finalizado.Checked = proyecto.EstaFinalizado;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            CerrarForm();
        }

        private void FormToElement()
        {
            proyecto.DesarrolladorReponsableId = Program.ctx.Desarrolladors.AsEnumerable().Where(x => x.Nombre + " " + x.Apellido == combo_desarrollador.SelectedItem.ToString()).Select(x => x.DesarrolladorId).First();
            proyecto.Nombre = text_nombre.Text;
            proyecto.Descripcion = text_descripcion.Text;
            proyecto.Fecha = datepicker_finicio.Value.Date;
            proyecto.EstaFinalizado = check_finalizado.Checked;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (CamposSonValidos() == false)
            {
                MessageBox.Show("Por favor llene todos los datos correctamente!");
                return;
            }

            if (proyecto == null)
            {
                proyecto = new Proyecto();
                FormToElement();
                Program.ctx.Proyectoes.Add(proyecto);
            }
            else
            {
                FormToElement();
            }

            Program.ctx.SaveChanges();

            frm_Principal.frm_proyectos.RefrescarGrilla();
            CerrarForm();
        }
    }
}
