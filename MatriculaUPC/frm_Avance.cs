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
    public partial class frm_Avance : Form
    {
        public Avance avance = null;
        public Proyecto proyecto = null;
   
        public frm_Avance()
        {
            InitializeComponent();
            datepicker_fecha.Value = DateTime.Now;
            combo_desarrollador.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frm_Avance_Load(object sender, EventArgs e)
        {
            var desarrolladores = Program.ctx.DesarrolladorProyectoes.Where(x => x.ProyectoId == proyecto.ProyectoId).Select(x => x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido).ToList();
            combo_desarrollador.DataSource = desarrolladores;
        }

        private bool CamposSonValidos()
        {
            if (Validators.TextoVacio(text_descripcion.Text))
                return false;
            if (Validators.TextoVacio(text_avance.Text))
                return false;
            if (Validators.TextoVacio(txt_horas.Text))
                return false;

            if (Validators.TextoEsPorcetaje(text_avance.Text) == false)
            {
                MessageBox.Show("Porfavor utilize un porcentaje adecuado (0.00 - 100)!");
                return false;
            }

            return true;
        }

        private void FormToElement()
        {
            avance.DesarrolladorReponsableId = Program.ctx.Desarrolladors.AsEnumerable().Where(x => x.Nombre + " " + x.Apellido == combo_desarrollador.SelectedItem.ToString()).Select(x => x.DesarrolladorId).First();
            avance.Fecha = datepicker_fecha.Value.Date;
            avance.Descripcion = text_descripcion.Text;
            avance.Porcentaje = Convert.ToDecimal(text_avance.Text);
            avance.Horas = Convert.ToDecimal(txt_horas.Text);
            avance.ProyectoId = proyecto.ProyectoId;
        }

        public void ActualizarOtrosFormularios()
        {
            if (Program.frm_avances.proyecto != null && Program.frm_avances.proyecto.ProyectoId == proyecto.ProyectoId)
            {
                Program.frm_avances.Preparar(proyecto.ProyectoId);
            }

            if (Program.frm_proyectos.Visible)
            {
                Program.frm_proyectos.RefrescarGrilla();
            }

            if (Program.frm_equipo.proyecto != null && Program.frm_equipo.proyecto.ProyectoId == proyecto.ProyectoId)
            {
                Program.frm_equipo.Preparar(proyecto.ProyectoId);
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (avance == null) {
                if (CamposSonValidos() == false)
                {
                    MessageBox.Show("Por favor llene todos los datos correctamente!");
                    return;
                }
                avance = new Avance();
                FormToElement();
                Program.ctx.Avances.Add(avance);
            }

            Program.ctx.SaveChanges();
            ActualizarOtrosFormularios();

            CerrarForm();
        }

        private void text_avance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validators.GetOnlyDecimals(sender, e);
        }

        private void txt_horas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validators.GetOnlyDecimals(sender, e);
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            CerrarForm();
        }

        public void CerrarForm()
        {
            this.Hide();
            text_avance.Text = "";
            txt_horas.Text = "";
            text_descripcion.Text = "";
            if(combo_desarrollador.Items.Count > 0)
            {
                combo_desarrollador.SelectedIndex = 0;
            }
            datepicker_fecha.Value = DateTime.Now;
            avance = null;
            proyecto = null;
            Program.frm_avances.Activate();
        }
    }
}
