namespace MatriculaUPC
{
    partial class frm_Avance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Avance));
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.text_avance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_desarrollador = new System.Windows.Forms.ComboBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.datepicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // text_descripcion
            // 
            this.text_descripcion.Location = new System.Drawing.Point(138, 92);
            this.text_descripcion.Multiline = true;
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(203, 66);
            this.text_descripcion.TabIndex = 2;
            // 
            // text_avance
            // 
            this.text_avance.Location = new System.Drawing.Point(138, 169);
            this.text_avance.Name = "text_avance";
            this.text_avance.Size = new System.Drawing.Size(203, 20);
            this.text_avance.TabIndex = 3;
            this.text_avance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_avance_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "% Avance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Desarrollador";
            // 
            // combo_desarrollador
            // 
            this.combo_desarrollador.FormattingEnabled = true;
            this.combo_desarrollador.Location = new System.Drawing.Point(138, 24);
            this.combo_desarrollador.Name = "combo_desarrollador";
            this.combo_desarrollador.Size = new System.Drawing.Size(203, 21);
            this.combo_desarrollador.TabIndex = 0;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Image = global::MatriculaUPC.Properties.Resources.guardar;
            this.btn_registrar.Location = new System.Drawing.Point(162, 234);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(82, 23);
            this.btn_registrar.TabIndex = 5;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::MatriculaUPC.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(266, 234);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Horas";
            // 
            // txt_horas
            // 
            this.txt_horas.Location = new System.Drawing.Point(138, 201);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(203, 20);
            this.txt_horas.TabIndex = 4;
            this.txt_horas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_horas_KeyPress);
            // 
            // datepicker_fecha
            // 
            this.datepicker_fecha.Location = new System.Drawing.Point(138, 58);
            this.datepicker_fecha.Name = "datepicker_fecha";
            this.datepicker_fecha.Size = new System.Drawing.Size(200, 20);
            this.datepicker_fecha.TabIndex = 1;
            // 
            // frm_Avance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 276);
            this.ControlBox = false;
            this.Controls.Add(this.datepicker_fecha);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.txt_horas);
            this.Controls.Add(this.text_avance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_desarrollador);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Avance";
            this.Text = "Registrar Avance";
            this.Load += new System.EventHandler(this.frm_Avance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.TextBox text_avance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_desarrollador;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_horas;
        private System.Windows.Forms.DateTimePicker datepicker_fecha;
    }
}