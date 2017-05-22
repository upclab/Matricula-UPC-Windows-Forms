namespace MatriculaUPC
{
    partial class frm_Proyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.check_finalizado = new System.Windows.Forms.CheckBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_desarrollador = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.datepicker_finicio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // check_finalizado
            // 
            this.check_finalizado.AutoSize = true;
            this.check_finalizado.Location = new System.Drawing.Point(15, 208);
            this.check_finalizado.Name = "check_finalizado";
            this.check_finalizado.Size = new System.Drawing.Size(73, 17);
            this.check_finalizado.TabIndex = 4;
            this.check_finalizado.Text = "Finalizado";
            this.check_finalizado.UseVisualStyleBackColor = true;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(138, 17);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(203, 20);
            this.text_nombre.TabIndex = 0;
            // 
            // text_descripcion
            // 
            this.text_descripcion.Location = new System.Drawing.Point(138, 52);
            this.text_descripcion.Multiline = true;
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(203, 64);
            this.text_descripcion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desarrollador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // combo_desarrollador
            // 
            this.combo_desarrollador.FormattingEnabled = true;
            this.combo_desarrollador.Location = new System.Drawing.Point(138, 135);
            this.combo_desarrollador.Name = "combo_desarrollador";
            this.combo_desarrollador.Size = new System.Drawing.Size(203, 21);
            this.combo_desarrollador.TabIndex = 2;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::MatriculaUPC.Properties.Resources.guardar;
            this.btn_agregar.Location = new System.Drawing.Point(169, 229);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::MatriculaUPC.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(266, 229);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // datepicker_finicio
            // 
            this.datepicker_finicio.Location = new System.Drawing.Point(138, 173);
            this.datepicker_finicio.Name = "datepicker_finicio";
            this.datepicker_finicio.Size = new System.Drawing.Size(200, 20);
            this.datepicker_finicio.TabIndex = 3;
            // 
            // frm_Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 263);
            this.ControlBox = false;
            this.Controls.Add(this.datepicker_finicio);
            this.Controls.Add(this.check_finalizado);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_desarrollador);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Proyecto";
            this.Text = "Agregar Proyecto";
            this.Load += new System.EventHandler(this.frm_Proyecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_finalizado;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_desarrollador;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DateTimePicker datepicker_finicio;
    }
}