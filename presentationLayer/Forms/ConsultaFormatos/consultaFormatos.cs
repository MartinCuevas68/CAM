using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer.Forms.ConsultaFormatos
{
    public partial class consultaFormatos : Form
    {
        public consultaFormatos()
        {
            InitializeComponent();
            PLConsultaFormatos.plantillaConsulta(logo,regresarMenuButton);
            PLConsultaFormatos.carpetasFormatos(FCI1Panel,FCI2Panel,FCI3Panel,FCI4Panel,FCI5Panel,FCI6Panel,FCI7Panel,FCI8Panel,FCI9Panel);
        }

        private void regresarMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaAlumno formConsulta = new ConsultaAlumno();
            formConsulta.Show();
        }

        private void consultaFormatos_Load(object sender, FormClosedEventArgs e)
        {
            ConsultaAlumno formConsultas = new ConsultaAlumno();
            this.Hide();
            formConsultas.Show();
        }
    }
}
