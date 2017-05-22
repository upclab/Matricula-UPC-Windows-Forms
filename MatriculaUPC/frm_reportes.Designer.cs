namespace MatriculaUPC
{
    partial class frm_Reportes
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
            this.dgv_responsables = new System.Windows.Forms.DataGridView();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_proyectos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_responsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_responsables
            // 
            this.dgv_responsables.AllowUserToAddRows = false;
            this.dgv_responsables.AllowUserToDeleteRows = false;
            this.dgv_responsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_responsables.Location = new System.Drawing.Point(12, 41);
            this.dgv_responsables.Name = "dgv_responsables";
            this.dgv_responsables.ReadOnly = true;
            this.dgv_responsables.Size = new System.Drawing.Size(777, 211);
            this.dgv_responsables.TabIndex = 9;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(714, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reporte de Responsable";
            // 
            // dgv_proyectos
            // 
            this.dgv_proyectos.AllowUserToAddRows = false;
            this.dgv_proyectos.AllowUserToDeleteRows = false;
            this.dgv_proyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proyectos.Location = new System.Drawing.Point(12, 287);
            this.dgv_proyectos.Name = "dgv_proyectos";
            this.dgv_proyectos.ReadOnly = true;
            this.dgv_proyectos.Size = new System.Drawing.Size(777, 211);
            this.dgv_proyectos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reporte por Proyectos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nota: Solo se mosrarán los proyectos que presenten avances";
            // 
            // frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 529);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_proyectos);
            this.Controls.Add(this.dgv_responsables);
            this.Controls.Add(this.btn_cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frm_Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_responsables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_responsables;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_proyectos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}