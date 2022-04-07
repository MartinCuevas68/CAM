using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public partial class fichaTecnica : Form
    {
        _1dataLayer.SP_FichaTecnicaAlumno_Result alumno = new _1dataLayer.SP_FichaTecnicaAlumno_Result();
        _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result tutor = new _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result();
        _1dataLayer.SP_ListaTelefonosTutor_Result telefonos = new _1dataLayer.SP_ListaTelefonosTutor_Result();
        _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result infoMed = new _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result();
        _1dataLayer.SP_ListaDiscapacidad_Result discapacidad = new _1dataLayer.SP_ListaDiscapacidad_Result();
        _1dataLayer.SP_ListaEnfermedad_Result enfermedad = new _1dataLayer.SP_ListaEnfermedad_Result();
        _1dataLayer.SP_ListaAlergia_Result alergia = new _1dataLayer.SP_ListaAlergia_Result();
        _1dataLayer.SP_ListaTratamiento_Result tratamiento = new _1dataLayer.SP_ListaTratamiento_Result();
        _1dataLayer.foto_alumno fotol = new _1dataLayer.foto_alumno();

        public fichaTecnica(int id_alumno)
        {
            InitializeComponent();
            infoGeneralPanel.Visible = true;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;
            colorearEtiqueta(infoGeneralButton, infoEscolarButton, infoTutorButton, infoMedicaButton);

            PLfichatecnicaAlumno.centrarLabel(fichaLabel, logo, nombreAlLabel, nombreAl, matriculaLabel, matricula, edadLabel, edad, foto, infoGeneralPanel, infoEscolarPanel,infoTutorPanel, 
                                infoMedicaPanel, infoGeneralButton, infoEscolarButton, infoTutorButton, infoMedicaButton, regresarMenuButton, editarInfoButton, cancelarEdiButton, terminarEdiButton);
            PLfichatecnicaAlumno.infoAlumno(nombreAlLabel, nombreAl, apellidoP, apellidoM, matriculaLabel, matricula, edadLabel, edad, nombreL, apellidoPL, apellidoML,nombreAlLinea,apellidoPLinea,apellidoMLinea);
            PLfichatecnicaAlumno.infoGeneral(fechaNaLabel, fechaNa, lugarNaLabel, ciudad, estado, direccionLabel, calle, numeroCasa, colonia, curpLabel, curp, telPersonalLabel, telPersonal, calleAlL, numeroCasaAlL, coloniaAlL, ciudadAlL, estadoAlL, ciudadLinea, estadoLinea, calleLinea,numeroCasaLinea,coloniaLinea, curpLinea, telPersonalLinea);
            PLfichatecnicaAlumno.infoEscolar(tipoIngresoLabel, tipoIngreso, escuelaPLabel, escuelaP, canalizadoLabel, canalizado, cicloEscLabel, cicloEsc, escuelaPLinea,canalizadoLinea,cicloEscLinea);
            PLfichatecnicaAlumno.infoTutor(nombreCTLabel, nombreT, apellidoPT, apellidoMT, direccionTLabel, calleT, numeroCasaT, coloniaT, ocupacionLabel, ocupacion, telefonosTLabel,
                                telCasaTLabel, telMovilTLabel, telTrabajoTLabel, telCasaT, telMovilT, telTrabajoT, nombreTLabel, apellidoPTLabel, apellidoMTLabel, calleTLabel, numeroCasaTLabel, coloniaTLabel,
                                nombreTLinea,apellidoPTLinea,apellidoMTLinea, calleTLinea, numeroCasaTLinea, coloniaTLinea, ocupacionLinea,telCasaTLinea,telMovilTLinea, telTrabajoTLinea);
            PLfichatecnicaAlumno.infoMedica(servMedicoLabel, servMedico, telefonoLabel, telefono, grupoSanguineoLabel, grupoSanguineo, discapacidadLabel, enfermedadesLabel, alergiasLabel,
                                            tratamientoLabel, discapacidades, enfermedades, alergias, tratamientos, discapacidadPanel, enfermedadesPanel, alergiasPanel, tratamientoPanel, grupoSanguineoComboBox, servMedicoLinea, telefonoLinea);

            String vista = "";
            vista = "consulta informacion";

            if (vista == "consulta informacion")
                ocultarEditarInformacion();
            else
                mostrarEditarInformacion();


            //Ejemplo de alumno
            /*nombreAl.Text = "Marcos";apellidoP.Text = "Zavala";apellidoM.Text = "Martinez"; edad.Text = "21";
            ciudad.Text = "Mexicali"; estado.Text = "Baja California Sur"; calle.Text = "Av. San Luis Potosi"; numeroCasa.Text = "2563"; colonia.Text = "Azteca";
            curp.Text = "SASAS5D4555555455"; telPersonal.Text = "6867895266"; matricula.Text = "10236"; tipoIngreso.Text = "Nuevo Ingreso";
            escuelaP.Text = "Esc. Estatal Prof. Emilio Miramontes Ordoñez"; canalizado.Text = "";cicloEsc.Text = "";
            nombreT.Text = "Armando"; apellidoMT.Text = "Alvarez"; apellidoPT.Text = "Apodaca"; ocupacion.Text = "Supervisor de Area de Calidad"; telCasaT.Text = "6867894102";
            telMovilT.Text = "6861236985";telTrabajoT.Text = "6867418523";servMedico.Text = "IMSS"; telefono.Text = "6867894561";grupoSanguineo.Text = "B+";
            canalizado.Text = "Lic. Maria Leticia Sepulveda Ruiz"; calleT.Text = "Av. Rio San Lorenzo"; numeroCasaT.Text = "2365"; coloniaT.Text = "Independencia";*/

            //Información del alumno
            alumno = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);
            apellidoP.Text = alumno.apellido_paterno;
            apellidoM.Text = alumno.apellido_materno;
            edad.Text = alumno.edad_alumno;
            matricula.Text = alumno.id_alumno.ToString();
            fechaNa.Value = alumno.fecha_nacimiento;
            //fechaNa.Text = alumno.fecha_nacimiento.Day.ToString() + "/" + alumno.fecha_nacimiento.Month.ToString() + "/" + alumno.fecha_nacimiento.Year.ToString();
            ciudad.Text = alumno.ciudad_nacimiento_alumno;
            estado.Text = alumno.estado_nacimiento_alumno;
            curp.Text = alumno.CURP_alumno;
            telPersonal.Text = alumno.telefono_personal_alumno;
            calle.Text = alumno.calle_alumno;
            numeroCasa.Text = alumno.numero_alumno;
            colonia.Text = alumno.colonia_alumno;
            tipoIngreso.Text = alumno.tipo_ingreso;

            businessLayer.BLFichaTecnica.infoGenAlumno(nombreAl, id_alumno);

            //Informacion escolar del alumno
            tipoIngreso.Text = alumno.tipo_ingreso;
            escuelaP.Text = alumno.escuela_procedencia_alumno;
            canalizado.Text = alumno.atendido_por;
            cicloEsc.Text = alumno.ciclo_escolar;

            //Información del tutor
            tutor = _1dataLayer.DLConsultaAlumno.FichaTecnicaTutor(id_alumno);
            nombreT.Text = tutor.nombre;
            apellidoPT.Text = tutor.apellido_paterno;
            apellidoMT.Text = tutor.apellido_materno;
            calleT.Text = tutor.calle_tutor;
            numeroCasaT.Text = tutor.numero_tutor;
            coloniaT.Text = tutor.colonia_tutor;
            ocupacion.Text = tutor.ocupacion_tutor;
            telCasaT.Text = telefonos.telefono;
            telTrabajoT.Text = telefonos.telefono;
           

            //Información médica
            infoMed = _1dataLayer.DLConsultaAlumno.FichaTecnicaMedica(id_alumno);
            servMedico.Text = infoMed.servicio_medico;
            telefono.Text = infoMed.telefono_contacto;
            grupoSanguineo.Text = infoMed.grupo_sanguineo;

            //Discapacidades
            discapacidades.Text = discapacidad.discapacidades;

            //Enfermedades
            enfermedades.Text = enfermedad.enfermedad;

            //Alergias
            alergias.Text = alergia.alergia;

            //Tratamientos
            tratamientos.Text = tratamiento.Tratamiento;

            //Sentencia que manda a llamar el método para cerrar Consultas usando la X
            //this.FormClosed += new FormClosedEventHandler(cerrarForm);


            fotol = _1dataLayer.DLConsultaAlumno.ConsultaFoto(id_alumno);
            foto.Image = byteArrayToImage(fotol.imagen_alumno.ToArray());

        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
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
                                nombreAl, apellidoP, apellidoM, edadLabel, edad, ciudad, estado, fechaNa, curp, telPersonal, calle, numeroCasa, colonia,
                                tipoIngreso, cicloEsc, escuelaP, canalizado, nombreT, apellidoPT, apellidoMT, calleT, numeroCasaT, coloniaT,
                                ocupacion, telCasaT, telMovilT, telTrabajoT, servMedico, telefono, grupoSanguineo, discapacidadPanel, enfermedadesPanel,
                                alergiasPanel, tratamientoPanel, infoMedicaTableLayoutPanel, tipoIngresoComboBox, grupoSanguineoComboBox,
                                nombreTLabel, apellidoPTLabel, apellidoMTLabel, calleTLabel, numeroCasaTLabel, coloniaTLabel, calleAlL, numeroCasaAlL, coloniaAlL,
                                ciudadAlL, estadoAlL,nombreL,apellidoPL,apellidoML, nombreAlLinea, apellidoPLinea, apellidoMLinea,ciudadLinea, estadoLinea, calleLinea, numeroCasaLinea, coloniaLinea,
                                curpLinea, telPersonalLinea, escuelaPLinea, canalizadoLinea, cicloEscLinea, nombreTLinea, apellidoPTLinea, apellidoMTLinea,calleTLinea, numeroCasaTLinea, coloniaTLinea,ocupacionLinea,
                                telCasaTLinea,telMovilTLinea, telTrabajoTLinea, servMedicoLinea, telefonoLinea);
        }

        private void ocultarEditarInformacion()
        {
        PLfichatecnicaAlumno.ocultarEditarInformacion(regresarMenuButton, editarInfoButton, cancelarEdiButton, terminarEdiButton, fotoBtn,
                                        nombreAl, apellidoP, apellidoM, edadLabel, edad, ciudad, estado, fechaNa, curp, telPersonal, calle, numeroCasa, colonia,
                                        tipoIngreso, cicloEsc, escuelaP, canalizado, nombreT, apellidoPT, apellidoMT, calleT, numeroCasaT, coloniaT,
                                        ocupacion, telCasaT, telMovilT, telTrabajoT, servMedico, telefono, grupoSanguineo, discapacidadPanel, enfermedadesPanel,
                                        alergiasPanel, tratamientoPanel, infoMedicaTableLayoutPanel, tipoIngresoComboBox, grupoSanguineoComboBox
                                        , nombreTLabel, apellidoPTLabel, apellidoMTLabel, calleTLabel, numeroCasaTLabel, coloniaTLabel, calleAlL, numeroCasaAlL, coloniaAlL,
                                        ciudadAlL, estadoAlL, nombreL, apellidoPL, apellidoML, nombreAlLinea, apellidoPLinea, apellidoMLinea,ciudadLinea, estadoLinea, calleLinea, numeroCasaLinea, coloniaLinea,
                                        curpLinea, telPersonalLinea, escuelaPLinea, canalizadoLinea, cicloEscLinea, nombreTLinea, apellidoPTLinea, apellidoMTLinea, calleTLinea, numeroCasaTLinea, coloniaTLinea, ocupacionLinea,
                                        telCasaTLinea, telMovilTLinea, telTrabajoTLinea,servMedicoLinea,telefonoLinea);
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
            alumno.nombre = nombreAl.Text;
            alumno.apellido_paterno = apellidoP.Text;
            alumno.apellido_materno = apellidoM.Text;
            alumno.ciudad_nacimiento_alumno = ciudad.Text;
            alumno.fecha_nacimiento = fechaNa.Value;
            alumno.edad_alumno = edad.Text;
            alumno.calle_alumno = calle.Text;
            alumno.colonia_alumno = colonia.Text;
            alumno.CURP_alumno = curp.Text;
            alumno.tipo_ingreso = tipoIngreso.Text;
            alumno.numero_alumno = numeroCasa.Text;
            alumno.atendido_por = canalizado.Text;
            alumno.escuela_procedencia_alumno = escuelaP.Text;
            alumno.telefono_personal_alumno = telPersonal.Text;
            alumno.ciclo_escolar = cicloEsc.Text;
            tutor.nombre = nombreT.Text;
            tutor.apellido_paterno = apellidoPT.Text;
            tutor.apellido_materno = apellidoMT.Text;
            tutor.ocupacion_tutor = ocupacion.Text;
            tutor.calle_tutor = calleT.Text;
            tutor.colonia_tutor = coloniaT.Text;
            tutor.numero_tutor = numeroCasaT.Text;
            if (grupoSanguineoComboBox.SelectedItem != null)
            {
                infoMed.grupo_sanguineo = grupoSanguineoComboBox.SelectedItem.ToString();
            }
            infoMed.servicio_medico = servMedico.Text;
            infoMed.telefono_contacto = telefono.Text;
            MessageBox.Show(alumno.nombre);
            businessLayer.BLModificacionAlumno.modificarAlumno(alumno);
            businessLayer.BLModificacionAlumno.modificartutor(tutor);
            businessLayer.BLModificacionAlumno.modificarinfomed(infoMed);
            ocultarEditarInformacion();
        }


        private void fechaNa_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = fechaNa.Value;
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - fechaNacimiento;
            double dias = diferencia.TotalDays;
            double anios = Math.Floor(dias / 365);
            edad.Text = anios.ToString();
        }


        private void fichaTecnica_Load(object sender, EventArgs e)
        {

        }
    }
}
