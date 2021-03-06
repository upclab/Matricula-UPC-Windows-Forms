﻿namespace MatriculaUPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Proyectos));
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_ver_equipo = new System.Windows.Forms.Button();
            this.btn_asociar_equipo = new System.Windows.Forms.Button();
            this.btn_avances = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Image = global::MatriculaUPC.Properties.Resources.filtrar;
            this.btn_filtrar.Location = new System.Drawing.Point(400, 14);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 3;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(12, 17);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(382, 20);
            this.txt_filtro.TabIndex = 2;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::MatriculaUPC.Properties.Resources.registrar;
            this.btn_agregar.Location = new System.Drawing.Point(714, 342);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.datagridview.TabIndex = 8;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = global::MatriculaUPC.Properties.Resources.salir;
            this.btn_cerrar.Location = new System.Drawing.Point(714, 17);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Image = global::MatriculaUPC.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(633, 342);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_ver_equipo
            // 
            this.btn_ver_equipo.Image = global::MatriculaUPC.Properties.Resources.equipo;
            this.btn_ver_equipo.Location = new System.Drawing.Point(12, 342);
            this.btn_ver_equipo.Name = "btn_ver_equipo";
            this.btn_ver_equipo.Size = new System.Drawing.Size(93, 23);
            this.btn_ver_equipo.TabIndex = 4;
            this.btn_ver_equipo.Text = "Ver Equipo";
            this.btn_ver_equipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ver_equipo.UseVisualStyleBackColor = true;
            this.btn_ver_equipo.Click += new System.EventHandler(this.btn_ver_equipo_Click);
            // 
            // btn_asociar_equipo
            // 
            this.btn_asociar_equipo.Image = global::MatriculaUPC.Properties.Resources.asociar;
            this.btn_asociar_equipo.Location = new System.Drawing.Point(116, 342);
            this.btn_asociar_equipo.Name = "btn_asociar_equipo";
            this.btn_asociar_equipo.Size = new System.Drawing.Size(107, 23);
            this.btn_asociar_equipo.TabIndex = 5;
            this.btn_asociar_equipo.Text = "Asociar Equipo";
            this.btn_asociar_equipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_asociar_equipo.UseVisualStyleBackColor = true;
            this.btn_asociar_equipo.Click += new System.EventHandler(this.btn_asociar_equipo_Click);
            // 
            // btn_avances
            // 
            this.btn_avances.Image = global::MatriculaUPC.Properties.Resources.avance;
            this.btn_avances.Location = new System.Drawing.Point(229, 342);
            this.btn_avances.Name = "btn_avances";
            this.btn_avances.Size = new System.Drawing.Size(101, 23);
            this.btn_avances.TabIndex = 6;
            this.btn_avances.Text = "Ver Avances";
            this.btn_avances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_avances.UseVisualStyleBackColor = true;
            this.btn_avances.Click += new System.EventHandler(this.btn_avances_Click);
            // 
            // frm_Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btn_asociar_equipo);
            this.Controls.Add(this.btn_avances);
            this.Controls.Add(this.btn_ver_equipo);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.btn_cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btn_avances;
    }
}