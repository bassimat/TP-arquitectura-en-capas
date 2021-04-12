using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Cursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            BLL.Materia objMateria = new BLL.Materia( this.tBoxMateria.Text );

            if (!objMateria.SetMomentoDeLaCarrera((BLL.Carrera)this.cBoxCarrera.SelectedItem, 
                                                  Convert.ToInt32(this.tBoxAnio.Text),
                                                  Convert.ToInt32(this.tBoxCuatri.Text)) )
            {
                MessageBox.Show("No se pudo agregar la materia", "Error de datos");
                return;
            }

            if (objMateria.Persistir())
                MessageBox.Show("Materia agregada satisfactoriamente");
            else
                MessageBox.Show("No se pudo agregar la materia", "Error de datos");
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            //BLL.Materia objMateria = new BLL.Materia();
            //this.dgvMaterias.DataSource = objMateria.ObtenerReporte();
            this.dgvMaterias.DataSource = BLL.Materia.ObtenerReporte();
        }

        private void cBoxCarrera_DropDown(object sender, EventArgs e)
        {
            this.cBoxCarrera.DataSource = BLL.Carrera.ObtenerCarreras();
            this.cBoxCarrera.DisplayMember = "Nombre";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnRecargar_Click(this, e);
            this.cBoxCarrera_DropDown(this, e);
            return;
        }
    }
}

