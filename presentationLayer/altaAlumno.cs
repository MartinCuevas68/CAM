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
    public partial class altaAlumno : Form
    {
        public altaAlumno()
        {
            int distanciaLabel = 70;
            int distanciaLabelDerecha = 70;
            int distanciaTextBox = 66;
            int distanciaTextBoxDerecha = 66;

            InitializeComponent();
            
            Claudia.altasButton(realizarAltaButton);
            distanciaLabel = Claudia.altasLabel(fechaElaboracionLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(nombreAlumnoLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(fechaNacimientoLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(LugarNacimientoLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(direccionAlumnoLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(telefonoAlumnoLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(discapacidadLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(canalizadoPorLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(escuelaProcedenciaLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(responablesAlumnoLabel, distanciaLabel);
            
            distanciaLabelDerecha = Claudia.altasLabelDerecha(cicloEscolarLabel, distanciaLabelDerecha);
            distanciaLabelDerecha = Claudia.altasLabelDerecha(curpLabel, distanciaLabelDerecha);
            distanciaLabelDerecha = Claudia.altasLabelDerecha(añosCumplidosLabel, distanciaLabelDerecha);
            distanciaLabelDerecha = Claudia.altasGroupBox(tipoIngresoGroupBox, distanciaLabelDerecha);

            
            distanciaLabel = distanciaLabel + 20;
            //Label datos Madre
            distanciaLabel = Claudia.altasLabel(nombreMadreLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(domicilioMadreLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(ocupacionMadreLabel, distanciaLabel);
            distanciaLabelDerecha = Claudia.altasLabelDerecha(lugarTrabajoMadreLabel, distanciaLabelDerecha);
            distanciaLabel = Claudia.altasLabel(telefonosMadreLabel, distanciaLabel);
            
            distanciaLabel = distanciaLabel + 20;
            //Label datos Padre
            distanciaLabel = Claudia.altasLabel(nombrePadreLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(domicilioPadreLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(ocupacionPadreLabel, distanciaLabel);
            
            distanciaLabelDerecha = distanciaLabelDerecha + 145;
            
            distanciaLabelDerecha = Claudia.altasLabelDerecha(lugarTrabajoPadreLabel, distanciaLabelDerecha);
            distanciaLabel = Claudia.altasLabel(telefonosPadreLabel, distanciaLabel);

           distanciaTextBox = Claudia.altasDateTimePicker(fechaElaboracionDateTimePicker, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(nombreAlumnoTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasDateTimePicker(fechaNacimientoDateTimePicker, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(lugarNacimientoTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(direccionTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(telefonoPersonalTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(discapacidadTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(canalizadoPorTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(escuelaProcedenciaTextBox, distanciaTextBox);

            distanciaTextBoxDerecha = Claudia.altasTextBoxDerecha(cicloEscolarTextBox, distanciaTextBoxDerecha);
            distanciaTextBoxDerecha = Claudia.altasTextBoxDerecha(curpTextBox, distanciaTextBoxDerecha);
            distanciaTextBoxDerecha = Claudia.altasTextBoxDerecha(añosCumplidosTextBox, distanciaTextBoxDerecha);

            distanciaTextBox = Claudia.altasResponsableAlumnoCheckBox(madreCheckBox, padreCheckBox, distanciaTextBox);

            distanciaTextBox = distanciaTextBox + 20;

            //Datos de la madre
            /*nombreMadreTextBox.Enabled = false;
            domicilioMadreTextBox.Enabled = false;
            ocupacionMadreTextBox.Enabled = false;
            telefonoCasaMadreTextBox.Enabled = false;
            telefonoCelularMadreTextBox.Enabled = false;
            telefonoTrabajoMadreTextBox.Enabled = false;*/


            distanciaTextBox = Claudia.altasTextBox(nombreMadreTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(domicilioMadreTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(ocupacionMadreTextBox, distanciaTextBox);
            distanciaTextBoxDerecha = distanciaTextBoxDerecha + 290;
            distanciaTextBoxDerecha = Claudia.altasTextBoxDerecha(lugarTrabajoMadreTextBox,distanciaTextBoxDerecha);
           
            Claudia.altasTelefonosTextBox(telefonoCasaMadreTextBox, telefonoCelularMadreTextBox, telefonoTrabajoMadreTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTelefonosLabel(telefonoCasaMadreLabel, telefonoCelularMadreLabel, telefonoTrabajoMadreLabel, distanciaTextBox);
            

            //Datos del padre
            distanciaTextBox = distanciaTextBox + 20;
            distanciaTextBox = Claudia.altasTextBox(nombrePadreTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(domicilioPadreTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(ocupacionPadreTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(ocupacionPadreTextBox, distanciaTextBox);
            

            Claudia.altasTelefonosTextBox(telefonoCasaPadreTextBox, telefonoCelularPadreTextBox, telefonoTrabajoPadreTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTelefonosLabel(telefonoCasaPadreLabel, telefonoCelularPadreLabel, telefonoTrabajoPadreLabel, distanciaTextBox);

        }

        private void altaAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
