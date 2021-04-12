namespace UI_Cursos
{
    partial class Form1
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
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.tBoxMateria = new System.Windows.Forms.TextBox();
            this.tBoxCarrera = new System.Windows.Forms.TextBox();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.labelAyC = new System.Windows.Forms.Label();
            this.tBoxAnio = new System.Windows.Forms.TextBox();
            this.tBoxCuatri = new System.Windows.Forms.TextBox();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(223, 324);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMateria.TabIndex = 0;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // tBoxMateria
            // 
            this.tBoxMateria.Location = new System.Drawing.Point(109, 272);
            this.tBoxMateria.Name = "tBoxMateria";
            this.tBoxMateria.Size = new System.Drawing.Size(189, 20);
            this.tBoxMateria.TabIndex = 1;
            // 
            // tBoxCarrera
            // 
            this.tBoxCarrera.Location = new System.Drawing.Point(109, 298);
            this.tBoxCarrera.Name = "tBoxCarrera";
            this.tBoxCarrera.Size = new System.Drawing.Size(189, 20);
            this.tBoxCarrera.TabIndex = 2;
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(12, 277);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(42, 13);
            this.labelMateria.TabIndex = 3;
            this.labelMateria.Text = "Materia";
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.Location = new System.Drawing.Point(12, 301);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(41, 13);
            this.labelCarrera.TabIndex = 4;
            this.labelCarrera.Text = "Carrera";
            // 
            // labelAyC
            // 
            this.labelAyC.AutoSize = true;
            this.labelAyC.Location = new System.Drawing.Point(12, 329);
            this.labelAyC.Name = "labelAyC";
            this.labelAyC.Size = new System.Drawing.Size(94, 13);
            this.labelAyC.TabIndex = 5;
            this.labelAyC.Text = "Año y cuatrimestre";
            // 
            // tBoxAnio
            // 
            this.tBoxAnio.Location = new System.Drawing.Point(109, 326);
            this.tBoxAnio.Name = "tBoxAnio";
            this.tBoxAnio.Size = new System.Drawing.Size(31, 20);
            this.tBoxAnio.TabIndex = 6;
            // 
            // tBoxCuatri
            // 
            this.tBoxCuatri.Location = new System.Drawing.Point(146, 326);
            this.tBoxCuatri.Name = "tBoxCuatri";
            this.tBoxCuatri.Size = new System.Drawing.Size(31, 20);
            this.tBoxCuatri.TabIndex = 7;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(15, 13);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(391, 232);
            this.dgvMaterias.TabIndex = 8;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(412, 13);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(21, 23);
            this.btnRecargar.TabIndex = 9;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 405);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.tBoxCuatri);
            this.Controls.Add(this.tBoxAnio);
            this.Controls.Add(this.labelAyC);
            this.Controls.Add(this.labelCarrera);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.tBoxCarrera);
            this.Controls.Add(this.tBoxMateria);
            this.Controls.Add(this.btnAgregarMateria);
            this.Name = "Form1";
            this.Text = "Gestor de cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.TextBox tBoxMateria;
        private System.Windows.Forms.TextBox tBoxCarrera;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.Label labelAyC;
        private System.Windows.Forms.TextBox tBoxAnio;
        private System.Windows.Forms.TextBox tBoxCuatri;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnRecargar;
    }
}

