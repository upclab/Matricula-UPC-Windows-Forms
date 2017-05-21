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
    public partial class frm_Desarrollador : Form
    {
        private Desarrollador desarollador = null;

        public frm_Desarrollador()
        {
            InitializeComponent();
            combo_tipo_documento.DropDownStyle = ComboBoxStyle.DropDownList;
            var lista = Program.ctx.TipoDocumentoes.Select(x => x.Siglas).ToList();
            combo_tipo_documento.DataSource = lista;
        }

        private bool CamposSonValidos()
        {
            if (Validators.TextoVacio(text_n_documento.Text))
                return false;
            if (Validators.TextoVacio(text_nombre.Text))
                return false;
            if (Validators.TextoVacio(text_apellido.Text))
                return false;

            return true;
        }

        private void CerrarForm()
        {
            combo_tipo_documento.SelectedIndex = 0;
            check_activo.Checked = false;
            text_n_documento.Text = "";
            text_nombre.Text = "";
            text_apellido.Text = "";
            desarollador = null;
            this.Hide();
            Program.frm_desarrolladores.Activate();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            CerrarForm();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (desarollador == null)
            {
                if (CamposSonValidos() == false)
                {
                    MessageBox.Show("Por favor llene todos los datos correctamente!");
                    return;
                }

                desarollador = new Desarrollador();
                desarollador.TipoDocumentoId = Program.ctx.TipoDocumentoes.AsEnumerable().Where(x => x.Siglas == combo_tipo_documento.SelectedItem.ToString()).Select(x => x.TipoDocumentoId).First();
                desarollador.Nombre = text_nombre.Text;
                desarollador.Apellido = text_apellido.Text;
                desarollador.NroDocumento = text_n_documento.Text;
                desarollador.Estado = check_activo.Checked ? "ACT" : "INA";
            }

            Program.ctx.Desarrolladors.Add(desarollador);
            Program.ctx.SaveChanges();
 
            Program.frm_desarrolladores.RefrescarGrilla();

            if (Program.frm_asignar_equipo.proyecto != null)
            {
                Program.frm_asignar_equipo.Preparar(Program.frm_asignar_equipo.proyecto.ProyectoId);
            }

            CerrarForm();
        }
    }
}
