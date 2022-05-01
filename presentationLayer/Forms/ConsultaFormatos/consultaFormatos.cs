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
            PLConsultaFormatos.plantillaConsulta(logo,regresarMenuButton,formatoLabel);
            PLConsultaFormatos.carpetasFormatos(FCI1Panel,FCI2Panel,FCI3Panel,FCI4Panel,FCI5Panel,FCI6Panel,FCI7Panel,FCI8Panel,FCI9Panel);
            PLConsultaFormatos.titulosCarpetasFormatos(FCI1Label, FCI2Label, FCI3Label, FCI4Label, FCI5Label, FCI6Label, FCI7Label, FCI8Label, FCI9Label);
            PLConsultaFormatos.pestañasCarpetasFormatos(FCILabel1, FCILabel2, FCILabel3, FCILabel4, FCILabel5, FCILabel6, FCILabel7, FCILabel8, FCILabel9);
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
