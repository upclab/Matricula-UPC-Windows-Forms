namespace MatriculaUPC
{
    partial class frm_Proyectos
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
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_ver_equipo = new System.Windows.Forms.Button();
            this.btn_asociar_equipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(400, 14);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 1;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(12, 17);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(382, 20);
            this.txt_filtro.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(714, 342);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Location = new System.Drawing.Point(12, 54);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.Size = new System.Drawing.Size(777, 282);
            this.datagridview.TabIndex = 6;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(714, 17);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(633, 342);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_ver_equipo
            // 
            this.btn_ver_equipo.Location = new System.Drawing.Point(12, 342);
            this.btn_ver_equipo.Name = "btn_ver_equipo";
            this.btn_ver_equipo.Size = new System.Drawing.Size(75, 23);
            this.btn_ver_equipo.TabIndex = 2;
            this.btn_ver_equipo.Text = "Ver Equipo";
            this.btn_ver_equipo.UseVisualStyleBackColor = true;
            this.btn_ver_equipo.Click += new System.EventHandler(this.btn_ver_equipo_Click);
            // 
            // btn_asociar_equipo
            // 
            this.btn_asociar_equipo.Location = new System.Drawing.Point(93, 342);
            this.btn_asociar_equipo.Name = "btn_asociar_equipo";
            this.btn_asociar_equipo.Size = new System.Drawing.Size(90, 23);
            this.btn_asociar_equipo.TabIndex = 3;
            this.btn_asociar_equipo.Text = "Asociar Equipo";
            this.btn_asociar_equipo.UseVisualStyleBackColor = true;
            this.btn_asociar_equipo.Click += new System.EventHandler(this.btn_asociar_equipo_Click);
            // 
            // frm_Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btn_asociar_equipo);
            this.Controls.Add(this.btn_ver_equipo);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.btn_cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Proyectos";
            this.Text = "Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_ver_equipo;
        private System.Windows.Forms.Button btn_asociar_equipo;
    }
}