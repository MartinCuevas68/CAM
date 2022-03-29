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
            colorearEtiqueta(infoGeneralButton, infoEscolarButton, infoTutorButton, infoMedicaButton);

            PLfichatecnicaAlumno.centrarLabel(fichaLabel, logo, nombreAlLabel, nombreAl, matriculaLabel, matricula, edadLabel, edad, foto, infoGeneralPanel, infoEscolarPanel,infoTutorPanel, 
                                infoMedicaPanel, infoGeneralButton, infoEscolarButton, infoTutorButton, infoMedicaButton, regresarMenuButton, editarInfoButton, cancelarEdiButton, terminarEdiButton);
            PLfichatecnicaAlumno.infoAlumno(nombreAlLabel, nombreAl,apellidoP,apellidoM, matriculaLabel, matricula, edadLabel, edad);
            PLfichatecnicaAlumno.infoGeneral(fechaNaLabel, fechaNa, lugarNaLabel, ciudad, estado, direccionLabel, calle, numeroCasa, colonia, curpLabel, curp, telPersonalLabel, telPersonal);
            PLfichatecnicaAlumno.infoEscolar(tipoIngresoLabel, tipoIngreso, escuelaPLabel, escuelaP, canalizadoLabel, canalizado, cicloEscLabel, cicloEsc);
            PLfichatecnicaAlumno.infoTutor(nombreCTLabel, nombreT, apellidoPT, apellidoMT, direccionTLabel, calleT, numeroCasaT, coloniaT, ocupacionLabel, ocupacion, telefonosTLabel,
                                telCasaTLabel, telMovilTLabel, telTrabajoTLabel, telCasaT, telMovilT, telTrabajoT);
            PLfichatecnicaAlumno.infoMedica(servMedicoLabel, servMedico, telefonoLabel, telefono, grupoSanguineoLabel, grupoSanguineo, discapacidadLabel, enfermedadesLabel, alergiasLabel,
                                            tratamientoLabel, discapacidades, enfermedades, alergias, tratamientos, discapacidadPanel, enfermedadesPanel, alergiasPanel, tratamientoPanel);
            
            
            String vista = "";
            vista = "consulta informacion";

            if (vista == "consulta informacion")
            {
                ocultarEditarInformacion();
            }
            else
                mostrarEditarInformacion();


            //Ejemplo de alumno
            nombreAl.Text = "Marcos";apellidoP.Text = "Zavala";apellidoM.Text = "Martinez"; edad.Text = "21";
            ciudad.Text = "Mexicali"; estado.Text = "Baja California Sur"; calle.Text = "Av. San Luis Potosi";
            curp.Text = "SASAS5D4555555455";

        }

        private void infoGeneralButton_Click(object sender, EventArgs e)
        {
            infoGeneralPanel.Visible = true;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;
            cambioDeColorEtiquetas();
        }

        private void infoEscolarButton_Click(object sender, EventArgs e)
        {
            infoEscolarPanel.Visible = true;
            infoGeneralPanel.Visible = false;
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;
            cambioDeColorEtiquetas();
        }

        private void infoTutorButton_Click(object sender, EventArgs e)
        {
            infoTutorPanel.Visible = true;
            infoGeneralPanel.Visible = false;
            infoEscolarPanel.Visible = false;
            infoMedicaPanel.Visible = false;
            cambioDeColorEtiquetas();
        }

        private void infoMedicaButton_Click(object sender, EventArgs e)
        {
            infoMedicaPanel.Visible = true;
            infoGeneralPanel.Visible = false;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;
            cambioDeColorEtiquetas();
        }

        public void cambioDeColorEtiquetas()
        {
            if (infoGeneralPanel.Visible == true)
                colorearEtiqueta(infoGeneralButton, infoEscolarButton, infoTutorButton, infoMedicaButton);

            if (infoEscolarPanel.Visible == true)
                colorearEtiqueta(infoEscolarButton, infoGeneralButton, infoTutorButton, infoMedicaButton);

            if (infoTutorPanel.Visible == true)
                colorearEtiqueta(infoTutorButton, infoGeneralButton, infoEscolarButton, infoMedicaButton);

            if (infoMedicaPanel.Visible == true)
                colorearEtiqueta(infoMedicaButton, infoGeneralButton, infoEscolarButton, infoTutorButton);
        }

        public void colorearEtiqueta(Button etiquetaSeleccionada, Button etiquetaSinColor1, Button etiquetaSinColor2, Button etiquetaSinColor3) {

            etiquetaSeleccionada.BackColor = Color.FromArgb(162, 98, 242);
            etiquetaSeleccionada.ForeColor = Color.White;

            etiquetaSinColor1.ForeColor = Color.FromArgb(162, 98, 242);
            etiquetaSinColor1.BackColor = Color.White;

            etiquetaSinColor2.ForeColor = Color.FromArgb(162, 98, 242);
            etiquetaSinColor2.BackColor = Color.White;

            etiquetaSinColor3.ForeColor = Color.FromArgb(162, 98, 242);
            etiquetaSinColor3.BackColor = Color.White;
        }


        private void regresarMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaAlumno formConsulta = new ConsultaAlumno();
            formConsulta.Show();
        }

        private void mostrarEditarInformacion()
        {
            PLfichatecnicaAlumno.mostrarEditarInformacion(regresarMenuButton, editarInfoButton, cancelarEdiButton, terminarEdiButton, fotoBtn,
                                nombreAl,apellidoP, apellidoM, edadLabel,edad, ciudad, estado, fechaNa, curp, telPersonal, calle, numeroCasa, colonia, 
                                tipoIngreso, cicloEsc, escuelaP, canalizado, nombreT, apellidoPT, apellidoMT, calleT, numeroCasaT, coloniaT,
                                ocupacion, telCasaT, telMovilT, telTrabajoT, servMedico, telefono, grupoSanguineo, discapacidadPanel, enfermedadesPanel,
                                alergiasPanel, tratamientoPanel, infoMedicaTableLayoutPanel, tipoIngresoComboBox);
        }

        private void ocultarEditarInformacion()
        {
        PLfichatecnicaAlumno.ocultarEditarInformacion(regresarMenuButton, editarInfoButton, cancelarEdiButton, terminarEdiButton, fotoBtn,
                                        nombreAl, apellidoP, apellidoM, edadLabel, edad, ciudad, estado, fechaNa, curp, telPersonal, calle, numeroCasa, colonia,
                                        tipoIngreso, cicloEsc, escuelaP, canalizado, nombreT, apellidoPT, apellidoMT, calleT, numeroCasaT, coloniaT,
                                        ocupacion, telCasaT, telMovilT, telTrabajoT, servMedico, telefono, grupoSanguineo, discapacidadPanel, enfermedadesPanel,
                                        alergiasPanel, tratamientoPanel, infoMedicaTableLayoutPanel, tipoIngresoComboBox);
        }

        private void editarInfoButton_Click(object sender, EventArgs e)
        {
            mostrarEditarInformacion();
        }

        private void cancelarEdiButton_Click(object sender, EventArgs e)
        {
            ocultarEditarInformacion();
        }

        private void terminarEdiButton_Click(object sender, EventArgs e)
        {
            ocultarEditarInformacion();
        }


    }
}
