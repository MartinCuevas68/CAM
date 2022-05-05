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
        int fc1ban = 0;
        int fc2ban = 0;
        int fc3ban = 0;
        int fc4ban = 0;
        int fc5ban = 0;
        int fc6ban = 0;
        int fc7ban = 0;
        int fc8ban = 0;
        int fc9ban = 0;
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


        //Metodo para cambiar las banderas para poder abrir otro form en caso de haber cerrado el anterior
        public void cambiarbandera(int formato)
        {
            switch (formato)
            {
                case 1:
                    fc1ban = 0;
                    break;

                case 2:
                    fc2ban = 0;
                    break;

                case 3:
                    fc3ban = 0;
                    break;

                case 4:
                    fc4ban = 0;
                    break;

                case 5:
                    fc5ban = 0;
                    break;

                case 6:
                    fc6ban = 0;
                    break;

                case 7:
                    fc7ban = 0;
                    break;

                case 8:
                    fc8ban = 0;
                    break;

                case 9:
                    fc9ban = 0;
                    break;

            }

          
        }

        //Metodo donde se manda el formato al form
        private void vistaFormato_Click(object sender, EventArgs e)
        {
            try
            {
                Label lb = (Label)sender;
                switch (lb.Name)
                {
                    case "FCI1Label":
                        if (fc1ban == 0)
                        {
                            fc1ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(1,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI2Label":
                        if (fc2ban == 0)
                        {
                            fc2ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(2,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI3Label":
                        if (fc3ban == 0)
                        {
                            fc3ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(3, this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI4Label":
                        if (fc4ban == 0)
                        {
                            fc4ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(4,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI5Label":
                        if (fc5ban == 0)
                        {
                            fc5ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(5,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI6Label":
                        if (fc6ban == 0)
                        {
                            fc6ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(6, this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI7Label":
                        if (fc7ban == 0)
                        {
                            fc7ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(7,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI8Label":
                        if (fc8ban == 0)
                        {
                            fc8ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(8, this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI9Label":
                        if (fc9ban == 0)
                        {
                            fc9ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(9,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                }
            }
            catch (Exception ex)
            {
                Panel lb = (Panel)sender;
                MessageBox.Show(lb.Name);
                switch (lb.Name)
                {
                    case "FCI1Panel":
                        if (fc1ban == 0)
                        {
                            fc1ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(1,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI2Panel":
                        if (fc2ban == 0)
                        {
                            fc2ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(2,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI3Panel":
                        if (fc3ban == 0)
                        {
                            fc3ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(3,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI4Panel":
                        if (fc4ban == 0)
                        {
                            fc4ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(4,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI5Panel":
                        if (fc5ban == 0)
                        {
                            fc5ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(5,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI6Panel":
                        if (fc6ban == 0)
                        {
                            fc6ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(6,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI7Panel":
                        if (fc7ban == 0)
                        {
                            fc7ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(7,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI8Panel":
                        if (fc8ban == 0)
                        {
                            fc8ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(8,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;

                    case "FCI9Panel":
                        if (fc9ban == 0)
                        {
                            fc9ban = 1;
                            vistaPreviaFormato vistaFormato = new vistaPreviaFormato(9,this);
                            vistaFormato.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ya se encuentra abierta una ventana con el pdf seleccionado");
                        }
                        break;
                }

            }
        }
    }
}
