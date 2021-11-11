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
            int distanciaLabel = 40;
            //int distanciaLabelDerecha = 220;
            int distanciaTextBox = 36;
            int distanciaGroupBox = 1000;
            //int distanciaTextBoxDerecha = 216;

            InitializeComponent();

            Claudia.altasGroupBox(informacionGeneralAlumnoGroupBox);
            Claudia.altasGroupBox2(informacionEscolarGroupBox);

            distanciaLabel = Claudia.altasLabel(fechaElaboracionLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasDateTimePicker(fechaElaboracionDateTimePicker, distanciaTextBox);

            distanciaLabel = Claudia.altasNombre(nombreAlumnoLabel,apellidoPaternoAlumnoLabel,apellidoMaternoAlumnoLabel,nombreAlumnoTextBox,apellidoPaternoAlumnoTextBox,apellidoMaternoAlumnoTextBox, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            distanciaLabel = Claudia.altasLabel(fechaNacimientoLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasDateTimePicker(fechaNacimientoDateTimePicker, distanciaTextBox); 

            //Lugar nacimiento Alumno
            distanciaLabel = Claudia.altasLugarNacimiento(lugarNacimientoLabel, ciudadNacimientoAlumnoLabel,estadoNacimientoAlumnoLabel,ciudadNacimientoAlumnoTextBox,estadoNacimientoAlumnoTextBox, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            //Direccion Alumno
            distanciaLabel = Claudia.altasDireccion(direccionAlumnoLabel,calleDireccionAlumnoLabel,numeroDireccionAlumnoLabel,coloniaDireccionAlumnoLabel,calleDireccionAlumnoTextBox,numeroDireccionAlumnoTextBox,coloniaDireccionAlumnoTextBox, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            distanciaLabel = Claudia.altasLabel(telefonoAlumnoLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(telefonoAlumnoTextBox, distanciaTextBox);

            distanciaLabel = Claudia.altasLabel(discapacidadLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(discapacidadTextBox, distanciaTextBox);

            distanciaLabel = Claudia.altasLabel(escuelaProcedenciaLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(escuelaProcedenciaTextBox, distanciaTextBox);

            distanciaLabel = Claudia.altasLabel(canalizadoPorLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(canalizadoPorTextBox, distanciaTextBox);


            Claudia.altasInformacionEscolar(cicloEscolarLabel, curpLabel, añosCumplidosLabel, cicloEscolarTextBox, curpTextBox, añosCumplidosTextBox, tipoIngresoGroupBox,nuevoIngresoRadioButton,reingresoRadioButton);
           
            
            
            /*
            Claudia.altasButton(realizarAltaButton);
            distanciaLabel = Claudia.altasLabel(fechaElaboracionLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(nombreAlumnoLabel, distanciaLabel);
            Claudia.altasApellidosLabel(apellidoPaternoAlumnoLabel, apellidoMaternoAlumnoLabel, distanciaLabel);

            distanciaLabel = Claudia.altasLabel(fechaNacimientoLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(LugarNacimientoLabel, distanciaLabel);
            Claudia.altasNacimientoAlumnoLabel(ciudadNacimientoAlumnoLabel, estadoNacimientoAlumnoLabel, distanciaLabel);
            Claudia.altasNacimientoAlumnoTextBox(ciudadNacimientoAlumnoTextBox, estadoNacimientoAlumnoTextBox, distanciaLabel);

            distanciaLabel = Claudia.altasLabel(direccionAlumnoLabel, distanciaLabel);
            Claudia.altasDireccionLabel(calleDireccionAlumnoLabel, numeroDireccionAlumnoLabel, coloniaDireccionAlumnoLabel, distanciaLabel);
            Claudia.altasDireccionTextBox(calleDireccionAlumnoTextBox, numeroDireccionAlumnoTextBox, coloniaDireccionAlumnoTextBox, distanciaLabel);

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
            distanciaLabel = Claudia.altasResponsablesOtroAlumnoGroupBox(otroAlumnoMadreGroupBox,distanciaLabel);
            distanciaLabel = distanciaLabel + 40;

            //Label datos Madre
            distanciaLabel = Claudia.altasLabel(nombreMadreLabel, distanciaLabel);
            Claudia.altasApellidosLabel(apellidoPaternoMadreLabel, apellidoMaternoMadreLabel, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(domicilioMadreLabel, distanciaLabel);
            Claudia.altasDireccionLabel(calleDireccionMadreLabel, numeroDireccionMadreLabel, coloniaDireccionMadreLabel, distanciaLabel);
            Claudia.altasDireccionTextBox(calleDireccionMadreTextBox, numeroDireccionMadreTextBox, coloniaDireccionMadreTextBox, distanciaLabel);

            distanciaLabel = Claudia.altasLabel(ocupacionMadreLabel, distanciaLabel);
            distanciaLabelDerecha = Claudia.altasLabelDerecha(lugarTrabajoMadreLabel, distanciaLabel - 30);
            distanciaLabel = Claudia.altasLabel(telefonosMadreLabel, distanciaLabel);

            distanciaLabel = distanciaLabel + 30;
            distanciaLabel = Claudia.altasResponsablesOtroAlumnoGroupBox(otroAlumnoPadreGroupBox, distanciaLabel);
            distanciaLabel = distanciaLabel + 30;
            //Label datos Padre
            distanciaLabel = Claudia.altasLabel(nombrePadreLabel, distanciaLabel);
            Claudia.altasApellidosLabel(apellidoPaternoPadreLabel, apellidoMaternoPadreLabel, distanciaLabel);
            Claudia.altasApellidosTextBox(nombrePadreTextBox, apellidoPaternoPadreTextBox, apellidoMaternoPadreTextBox, distanciaLabel);
            distanciaLabel = Claudia.altasLabel(domicilioPadreLabel, distanciaLabel);
            Claudia.altasDireccionLabel(calleDireccionPadreLabel, numeroDireccionPadreLabel, coloniaDireccionPadreLabel, distanciaLabel);
            Claudia.altasDireccionTextBox(calleDireccionPadreTextBox, numeroDireccionPadreTextBox, coloniaDireccionPadreTextBox, distanciaLabel);

            distanciaLabel = Claudia.altasLabel(ocupacionPadreLabel, distanciaLabel);
            
            distanciaLabelDerecha = distanciaLabelDerecha + 145;
            
            distanciaLabelDerecha = Claudia.altasLabelDerecha(lugarTrabajoPadreLabel, distanciaLabel - 30);
            distanciaLabel = Claudia.altasLabel(telefonosPadreLabel, distanciaLabel);

            distanciaTextBox = Claudia.altasDateTimePicker(fechaElaboracionDateTimePicker, distanciaTextBox);
            distanciaTextBox = Claudia.altasApellidosTextBox(nombreAlumnoTextBox, apellidoPaternoAlumnoTextBox, apellidoMaternoAlumnoTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasDateTimePicker(fechaNacimientoDateTimePicker, distanciaTextBox);
            distanciaTextBox = distanciaTextBox + 60;
            distanciaTextBox = Claudia.altasTextBox(telefonoPersonalTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(discapacidadTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(canalizadoPorTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTextBox(escuelaProcedenciaTextBox, distanciaTextBox);
            distanciaTextBoxDerecha = Claudia.altasTextBoxDerecha(cicloEscolarTextBox, distanciaTextBoxDerecha);
            distanciaTextBoxDerecha = Claudia.altasTextBoxDerecha(curpTextBox, distanciaTextBoxDerecha);
            distanciaTextBoxDerecha = Claudia.altasTextBoxDerecha(añosCumplidosTextBox, distanciaTextBoxDerecha);

            distanciaTextBox = Claudia.altasResponsableAlumnoCheckBox(madreCheckBox, padreCheckBox, distanciaTextBox);

            distanciaTextBox = distanciaTextBox + 90;

            distanciaTextBox = Claudia.altasApellidosTextBox(nombreMadreTextBox, apellidoPaternoMadreTextBox, apellidoMaternoMadreTextBox, distanciaTextBox);
            distanciaTextBox = distanciaTextBox + 34;
            distanciaTextBox = Claudia.altasOcupacionPadres(ocupacionMadreTextBox, lugarTrabajoMadreLabel, calleTrabajoMadreLabel, calleTrabajoMadreTextBox, numeroTrabajoMadreLabel, numeroTrabajoMadreTextBox, coloniaTrabajoMadreLabel, coloniaTrabajoMadreTextBox, distanciaTextBox);
            Claudia.altasTelefonosTextBox(telefonoCasaMadreTextBox, telefonoCelularMadreTextBox, telefonoTrabajoMadreTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTelefonosLabel(telefonoCasaMadreLabel, telefonoCelularMadreLabel, telefonoTrabajoMadreLabel, distanciaTextBox);
            

            //Datos del padre
            distanciaTextBox = distanciaTextBox + 90;
            distanciaTextBox = Claudia.altasApellidosTextBox(nombrePadreTextBox, apellidoPaternoPadreTextBox, apellidoMaternoPadreTextBox, distanciaTextBox);
            distanciaTextBox = distanciaTextBox + 34;
            distanciaTextBox = Claudia.altasOcupacionPadres(ocupacionPadreTextBox,lugarTrabajoPadreLabel,calleTrabajoPadreLabel,calleTrabajoPadreTextBox,numeroTrabajoPadreLabel,numeroTrabajoPadreTextBox,coloniaTrabajoPadreLabel,coloniaTrabajoPadreTextBox, distanciaTextBox);
            Claudia.altasTelefonosTextBox(telefonoCasaPadreTextBox, telefonoCelularPadreTextBox, telefonoTrabajoPadreTextBox, distanciaTextBox);
            distanciaTextBox = Claudia.altasTelefonosLabel(telefonoCasaPadreLabel, telefonoCelularPadreLabel, telefonoTrabajoPadreLabel, distanciaTextBox);



            distanciaLabel = distanciaLabel + 50;
            distanciaLabel = Claudia.altasLabel(informacionMedicaAlumnoLabel,distanciaLabel);
            distanciaLabel = Claudia.altasInformacionMedicaAlumno(servicioMedicoAlumnoLabel,servicioMedicoTextBox,grupoSanguineoAlumnoLabel,grupoSanguineoTextBox,documentacionAlumnoLabel,enfermedaresAlumnoLabel,enfermedadesAlumnoTextBox,documentacionListBox,alergiasAlumnoLabel,alergiasAlumnoTextBox,telefonoContactoMedicoAlumnoLabel,telefonoContactoMedicoAlumnoTextBox,distanciaLabel);

            distanciaTextBox = distanciaLabel - 4;
            Claudia.altasLabel(atendidoPorLabel, distanciaLabel);
            Claudia.altasComboBox(atendidoPorComboBox, distanciaTextBox);

            */

        }

    }
}
