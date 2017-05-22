namespace MatriculaUPC
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.btn_desarrolladores = new System.Windows.Forms.Button();
            this.btn_proyectos = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_desarrolladores
            // 
            this.btn_desarrolladores.Location = new System.Drawing.Point(30, 55);
            this.btn_desarrolladores.Name = "btn_desarrolladores";
            this.btn_desarrolladores.Size = new System.Drawing.Size(96, 23);
            this.btn_desarrolladores.TabIndex = 0;
            this.btn_desarrolladores.Text = "Desarrolladores";
            this.btn_desarrolladores.UseVisualStyleBackColor = true;
            this.btn_desarrolladores.Click += new System.EventHandler(this.btn_desarrolladores_Click);
            // 
            // btn_proyectos
            // 
            this.btn_proyectos.Location = new System.Drawing.Point(30, 94);
            this.btn_proyectos.Name = "btn_proyectos";
            this.btn_proyectos.Size = new System.Drawing.Size(96, 23);
            this.btn_proyectos.TabIndex = 1;
            this.btn_proyectos.Text = "Proyectos";
            this.btn_proyectos.UseVisualStyleBackColor = true;
            this.btn_proyectos.Click += new System.EventHandler(this.btn_proyectos_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Location = new System.Drawing.Point(248, 94);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(75, 23);
            this.btn_reportes.TabIndex = 2;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 147);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.btn_proyectos);
            this.Controls.Add(this.btn_desarrolladores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Principal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_desarrolladores;
        private System.Windows.Forms.Button btn_proyectos;
        private System.Windows.Forms.Button btn_reportes;
    }
}

