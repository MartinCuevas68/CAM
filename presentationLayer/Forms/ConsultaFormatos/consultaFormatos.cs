using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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
            PLConsultaFormatos.plantillaConsulta(logo,regresarMenuButton,formatosLabel);
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
        private void FCI2Panel_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI2Label); }
        private void FCI2Panel_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI2Label); }
        private void FCI3Panel_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI3Label); }
        private void FCI3Panel_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI3Label); }
        private void FCI4Panel_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI4Label); }
        private void FCI4Panel_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI4Label); }
        private void FCI5Panel_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI5Label); }
        private void FCI5Panel_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI5Label); }
        private void FCI6Panel_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI6Label); }
        private void FCI6Panel_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI6Label); }
        private void FCI7Panel_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI7Label); }
        private void FCI7Panel_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI7Label); }
        private void FCI8Panel_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI8Label); }
        private void FCI8Panel_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI8Label); }
        private void FCI9Panel_MouseEnter(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseEnter(FCI9Label); }
        private void FCI9Panel_MouseLeave(object sender, EventArgs e) { PLConsultaFormatos.Panel_MouseLeave(FCI9Label); }



        private void vistaFormato_Click(object sender, EventArgs e)
        {
            vistaPreviaFormato vistaFormato = new vistaPreviaFormato();
            vistaFormato.Show();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI1.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            //PDF.src = FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI2.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI3.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI4.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI5.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI6.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI7.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI8.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI9.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }*/
    }
}
