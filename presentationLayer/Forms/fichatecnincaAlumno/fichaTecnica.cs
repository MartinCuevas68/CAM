using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public partial class fichaTecnica : Form
    {
       
        public fichaTecnica()
        {
            InitializeComponent();

            infoGeneralPanel.Visible = true;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;

            PLfichatecnicaAlumno.centrarLabel(fichaLabel, logo, nombreAlLabel, nombreAl, matriculaLabel, matricula, edadLabel, edad, foto, infoGeneralPanel,infoEscolarPanel, infoTutorPanel, infoMedicaPanel, infoGeneralButton, infoEscolarButton, infoTutorButton, infoMedicaButton,regresarMenuButton,editarInfoButton);
            PLfichatecnicaAlumno.infoAlumno(nombreAlLabel, nombreAl, matriculaLabel, matricula, edadLabel, edad);
            PLfichatecnicaAlumno.infoGeneral(fechaNaLabel, fechaNa, lugarNaLabel, lugarNa, direccionLabel, direccion, curpLabel, curp, telPersonalLabel, telPersonal);
            PLfichatecnicaAlumno.infoEscolar(tipoIngresoLabel, tipoIngreso, escuelaPLabel, escuelaP, canalizadoLabel, canalizado, cicloEscLabel, cicloEsc);
        }

        
        private void infoGeneralButton_Click(object sender, EventArgs e)
        {
            infoGeneralPanel.Visible = true;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;
        }

        private void infoEscolarButton_Click(object sender, EventArgs e)
        {
            infoEscolarPanel.Visible = true;
            infoGeneralPanel.Visible = false;            
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;
        }

        private void infoTutorButton_Click(object sender, EventArgs e)
        {
            infoTutorPanel.Visible = true;
            infoGeneralPanel.Visible = false;
            infoEscolarPanel.Visible = false;            
            infoMedicaPanel.Visible = false;
        }

        private void infoMedicaButton_Click(object sender, EventArgs e)
        {
            infoMedicaPanel.Visible = true;
            infoGeneralPanel.Visible = false;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;            
        }
    }
}
