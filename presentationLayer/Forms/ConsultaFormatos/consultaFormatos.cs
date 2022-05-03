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

        //Efectos Mouse Enter y Leave en carpetas
        private void FCI1Panel_MouseEnter(object sender, EventArgs e){ PLConsultaFormatos.Panel_MouseEnter(FCI1Label); }
        private void FCI1Panel_MouseLeave(object sender, EventArgs e){ PLConsultaFormatos.Panel_MouseLeave(FCI1Label); }
        private void FCI1Pane2_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI2Label); }
        private void FCI1Pane2_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI2Label); }
        private void FCI1Pane3_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI3Label); }
        private void FCI1Pane3_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI3Label); }
        private void FCI1Pane4_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI4Label); }
        private void FCI1Pane4_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI4Label); }
        private void FCI1Pane5_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI5Label); }
        private void FCI1Pane5_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI5Label); }
        private void FCI1Pane6_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI6Label); }
        private void FCI1Pane6_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI6Label); }
        private void FCI1Pane7_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI7Label); }
        private void FCI1Pane7_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI7Label); }
        private void FCI1Pane8_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI8Label); }
        private void FCI1Pane8_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI8Label); }
        private void FCI1Pane9_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI9Label); }
        private void FCI1Pane9_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI9Label); }

    }
}
