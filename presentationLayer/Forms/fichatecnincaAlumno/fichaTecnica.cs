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
using presentationLayer.Forms.BajaAlumno;

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

        ComboBox enfermedadestempcmb = new ComboBox();
        ComboBox discapacidadestempcmb = new ComboBox();
        ComboBox alergiastempcmb = new ComboBox();

        List<int> alergiasids = new List<int>();
        List<int> discapacidadesids = new List<int>();
        List<int> enfermedadesids = new List<int>();
        List<int> alergiasidsvar = new List<int>();
        List<int> discapacidadesidsvar = new List<int>();
        List<int> enfermedadesidsvar = new List<int>();

        int idalumno;
        int idtutor;
        int idcartilla;

        public fichaTecnica(int id_alumno, int bandera)
        {
            InitializeComponent();
            loaddata();
            infoGeneralPanel.Visible = true;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;
            colorearEtiqueta(infoGeneralButton, infoEscolarButton, infoTutorButton, infoMedicaButton);

            PLfichatecnicaAlumno.centrarLabel(fichaLabel, logo, nombreAlLabel, nombreAl, matriculaLabel, matricula, edadLabel, edad, foto, infoGeneralPanel, infoEscolarPanel,infoTutorPanel, 
                                infoMedicaPanel, infoGeneralButton, infoEscolarButton, infoTutorButton, infoMedicaButton, regresarMenuButton, editarInfoButton, cancelarEdiButton, terminarEdiButton, bajaAlumnoButton);
            PLfichatecnicaAlumno.infoAlumno(nombreAlLabel, nombreAl, apellidoP, apellidoM, matriculaLabel, matricula, edadLabel, edad, nombreL, apellidoPL, apellidoML,nombreAlLinea,apellidoPLinea,apellidoMLinea);
            PLfichatecnicaAlumno.infoGeneral(fechaNaLabel, fechaNa, lugarNaLabel, ciudad, estado, direccionLabel, calle, numeroCasa, colonia, curpLabel, curp, telPersonalLabel, telPersonal, calleAlL, 
                                numeroCasaAlL, coloniaAlL, ciudadAlL, estadoAlL, ciudadLinea, estadoLinea, calleLinea,numeroCasaLinea,coloniaLinea, curpLinea, telPersonalLinea);
            PLfichatecnicaAlumno.infoEscolar(tipoIngresoLabel, tipoIngreso, escuelaPLabel, escuelaP, canalizadoLabel, canalizado, cicloEscLabel, cicloEsc, escuelaPLinea,canalizadoLinea,cicloEscLinea);
            PLfichatecnicaAlumno.infoTutor(nombreCTLabel, nombreT, apellidoPT, apellidoMT, direccionTLabel, calleT, numeroCasaT, coloniaT, ocupacionLabel, ocupacion, telefonosTLabel,
                                telCasaTLabel, telMovilTLabel, telTrabajoTLabel, telCasaT, telMovilT, telTrabajoT, nombreTLabel, apellidoPTLabel, apellidoMTLabel, calleTLabel, numeroCasaTLabel, coloniaTLabel,
                                nombreTLinea,apellidoPTLinea,apellidoMTLinea, calleTLinea, numeroCasaTLinea, coloniaTLinea, ocupacionLinea,telCasaTLinea,telMovilTLinea, telTrabajoTLinea);
            PLfichatecnicaAlumno.infoMedica(servMedicoLabel, servMedico, telefonoLabel, telefono, grupoSanguineoLabel, grupoSanguineo, discapacidadLabel, enfermedadesLabel, alergiasLabel,
                                            tratamientoLabel, discapacidades, enfermedades, alergias, tratamientos, discapacidadPanel, enfermedadesPanel, alergiasPanel, tratamientoPanel, grupoSanguineoComboBox, servMedicoLinea, telefonoLinea,
                                              eliminarDiscapacidadesButton, eliminarEnfermedadesButton,eliminarAlergiasButton, discapacidadesCombobox, enfermedadesCombobox,alergiasCombobox, agregarDiscapacidadesButton,agregarEnfermedadesButton, agregarAlergiasButton);

            String vista = "";
            vista = "consulta informacion";

            if (vista == "consulta informacion")
                ocultarEditarInformacion();
            else
                mostrarEditarInformacion();


            //Información del alumno
            idalumno = businessLayer.BLFichaTecnica.infoGenAlumno(nombreAl, apellidoP, apellidoM, edad, matricula, fechaNa, ciudad, estado, curp, telPersonal, calle, numeroCasa, colonia, tipoIngreso, id_alumno);

            //Informacion escolar del alumno
            businessLayer.BLFichaTecnica.infoEscAlumno(tipoIngreso, escuelaP, canalizado, cicloEsc, id_alumno);

            //Información del tutor
            idtutor = businessLayer.BLFichaTecnica.infoTutor(nombreT, apellidoPT, apellidoMT, calleT, numeroCasaT, coloniaT, ocupacion, telCasaT, telMovilT, telTrabajoT, id_alumno);
            
            //Información médica
            idcartilla = businessLayer.BLFichaTecnica.infoMedAlumno(servMedico, telefono, grupoSanguineo, id_alumno);

            //Discapacidades, enfermedades, alergias y tratamientos
            businessLayer.BLFichaTecnica.infoMedAlumno2(discapacidades, enfermedades, alergias, tratamientos, id_alumno,alergiasids,discapacidadesids,enfermedadesids, alergiasidsvar, discapacidadesidsvar, enfermedadesidsvar);

            //Foto
            fotol = _1dataLayer.DLConsultaAlumno.ConsultaFoto(id_alumno);
            foto.Image = byteArrayToImage(fotol.imagen_alumno.ToArray());
            
            if(bandera == 1)
            {
                mostrarEditarInformacion();
            }

            //Sentencia que manda a llamar el método para cerrar Consultas usando la X
            //this.FormClosed += new FormClosedEventHandler(cerrarForm);
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
            PLfichatecnicaAlumno.mostrarEditarInformacion(regresarMenuButton, editarInfoButton, cancelarEdiButton, terminarEdiButton, bajaAlumnoButton, fotoBtn,
                                nombreAl, apellidoP, apellidoM, edadLabel, edad, ciudad, estado, fechaNa, curp, telPersonal, calle, numeroCasa, colonia,
                                tipoIngreso, cicloEsc, escuelaP, canalizado, nombreT, apellidoPT, apellidoMT, calleT, numeroCasaT, coloniaT,
                                ocupacion, telCasaT, telMovilT, telTrabajoT, servMedico, telefono, grupoSanguineo, discapacidadPanel, enfermedadesPanel,
                                alergiasPanel, tratamientoPanel, tratamientos, tipoIngresoComboBox, grupoSanguineoComboBox,
                                nombreTLabel, apellidoPTLabel, apellidoMTLabel, calleTLabel, numeroCasaTLabel, coloniaTLabel, calleAlL, numeroCasaAlL, coloniaAlL,
                                ciudadAlL, estadoAlL,nombreL,apellidoPL,apellidoML, nombreAlLinea, apellidoPLinea, apellidoMLinea,ciudadLinea, estadoLinea, calleLinea, numeroCasaLinea, coloniaLinea,
                                curpLinea, telPersonalLinea, escuelaPLinea, canalizadoLinea, cicloEscLinea, nombreTLinea, apellidoPTLinea, apellidoMTLinea,calleTLinea, numeroCasaTLinea, coloniaTLinea,ocupacionLinea,
                                telCasaTLinea,telMovilTLinea, telTrabajoTLinea, servMedicoLinea, telefonoLinea,  eliminarDiscapacidadesButton, eliminarEnfermedadesButton,eliminarAlergiasButton,
                                discapacidadesCombobox, enfermedadesCombobox, alergiasCombobox, agregarDiscapacidadesButton, agregarEnfermedadesButton, agregarAlergiasButton);
        }

        private void ocultarEditarInformacion()
        {
        PLfichatecnicaAlumno.ocultarEditarInformacion(regresarMenuButton, editarInfoButton, cancelarEdiButton, terminarEdiButton, bajaAlumnoButton, fotoBtn,
                                        nombreAl, apellidoP, apellidoM, edadLabel, edad, ciudad, estado, fechaNa, curp, telPersonal, calle, numeroCasa, colonia,
                                        tipoIngreso, cicloEsc, escuelaP, canalizado, nombreT, apellidoPT, apellidoMT, calleT, numeroCasaT, coloniaT,
                                        ocupacion, telCasaT, telMovilT, telTrabajoT, servMedico, telefono, grupoSanguineo, discapacidadPanel, enfermedadesPanel,
                                        alergiasPanel, tratamientoPanel, tratamientos, tipoIngresoComboBox, grupoSanguineoComboBox
                                        , nombreTLabel, apellidoPTLabel, apellidoMTLabel, calleTLabel, numeroCasaTLabel, coloniaTLabel, calleAlL, numeroCasaAlL, coloniaAlL,
                                        ciudadAlL, estadoAlL, nombreL, apellidoPL, apellidoML, nombreAlLinea, apellidoPLinea, apellidoMLinea,ciudadLinea, estadoLinea, calleLinea, numeroCasaLinea, coloniaLinea,
                                        curpLinea, telPersonalLinea, escuelaPLinea, canalizadoLinea, cicloEscLinea, nombreTLinea, apellidoPTLinea, apellidoMTLinea, calleTLinea, numeroCasaTLinea, coloniaTLinea, ocupacionLinea,
                                        telCasaTLinea, telMovilTLinea, telTrabajoTLinea,servMedicoLinea,telefonoLinea,  eliminarDiscapacidadesButton, eliminarEnfermedadesButton,eliminarAlergiasButton,
                                        discapacidadesCombobox, enfermedadesCombobox, alergiasCombobox, agregarDiscapacidadesButton, agregarEnfermedadesButton, agregarAlergiasButton);
        }

        private void editarInfoButton_Click(object sender, EventArgs e)
        {
            mostrarEditarInformacion();
        }

        private void cancelarEdiButton_Click(object sender, EventArgs e)
        {
            discapacidades.Text = "";
            enfermedades.Text = "";
            alergias.Text = "";
            tratamientos.Text = "";
            ocultarEditarInformacion();//Información del alumno
            idalumno = businessLayer.BLFichaTecnica.infoGenAlumno(nombreAl, apellidoP, apellidoM, edad, matricula, fechaNa, ciudad, estado, curp, telPersonal, calle, numeroCasa, colonia, tipoIngreso, idalumno);

            //Informacion escolar del alumno
            businessLayer.BLFichaTecnica.infoEscAlumno(tipoIngreso, escuelaP, canalizado, cicloEsc, idalumno);

            //Información del tutor
            idtutor = businessLayer.BLFichaTecnica.infoTutor(nombreT, apellidoPT, apellidoMT, calleT, numeroCasaT, coloniaT, ocupacion, telCasaT, telMovilT, telTrabajoT, idalumno);

            //Información médica
            businessLayer.BLFichaTecnica.infoMedAlumno(servMedico, telefono, grupoSanguineo, idalumno);

            //Discapacidades, enfermedades, alergias y tratamientos
            businessLayer.BLFichaTecnica.infoMedAlumno2(discapacidades, enfermedades, alergias, tratamientos, idalumno, alergiasids, discapacidadesids,enfermedadesids, alergiasidsvar, discapacidadesidsvar, enfermedadesidsvar);

            //Foto
            fotol = _1dataLayer.DLConsultaAlumno.ConsultaFoto(idalumno);
            foto.Image = byteArrayToImage(fotol.imagen_alumno.ToArray());
        }

        private void terminarEdiButton_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            int bandera2 = 0;
            string mensaje = "";

            if (nombreAl.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje += "◉Nombre del alumno\n";
            }

            if(apellidoP.Text.Trim().Equals("") && apellidoM.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Apellido del alumno\n");
            }

            

            if (ciudad.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Ciudad del alumno\n");
            }

            if (edad.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Edad del alumno\n");
            }

            if (calle.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Calle del alumno\n");
            }

            if (colonia.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Colonia del alumno\n");
            }

            if (estado.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje += ("◉Estado del alumno\n");
            }

            if (curp.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Curp del alumno\n");
            }

            if (tipoIngreso.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Tipo de ingreso del alumno\n");
            }

            if (numeroCasa.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Número de casa del alumno\n");
            }

            if (canalizado.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Nombre del que canalizo al alumno\n");
            }

            if (escuelaP.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Escuela de procedencia del alumno\n");
            }

            if (telPersonal.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Teléfono personal del alumno\n");
            }

            if (cicloEsc.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Ciclo escolar del alumno\n");
            }

            if (nombreT.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Nombre del tutor\n");
            }

            if (apellidoPT.Text.Trim().Equals("") && apellidoMT.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Apellido del tutor\n");
            }

          

            if (ocupacion.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Ocupación del tutor\n");
            }

            if (calleT.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Calle del tutor\n");
            }

            if (coloniaT.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Colonia del tutor\n");
            }

            if (numeroCasaT.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Número de casa del tutor\n");
            }
            if (telCasaT.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje += ("◉Teléfono de casa del tutor\n");
            }

            if (telMovilT.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje += ("◉Teléfono móvil del tutor\n");
            }

            if (telTrabajoT.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje += ("◉Teléfono de trabajo del tutor\n");
            }

            if (servMedico.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Servicio médico del alumno\n");
            }

            if (telefono.Text.Trim().Equals(""))
            {
                if (bandera == 0)
                {
                    bandera = 1;
                    mensaje += "No puede dejar espacios en blanco en los siguientes campos:\n\n";
                }
                mensaje +=("◉Teléfono de contacto del alumno en caso de emergencia\n");
            }

            if(telPersonal.Text.Length != 10)
            {
                
                if(bandera2 == 0)
                {
                    bandera2 = 1;
                    mensaje += "\n\nCampos inválidos \n\n";
                }
                string res = Convert.ToString(10 - telPersonal.Text.Length);
                mensaje += "◉Le faltan " + res + " caracteres al telefono personal del alumno\n";
            }


            if (telCasaT.Text.Length != 10)
            {

                if (bandera2 == 0)
                {
                    bandera2 = 1;
                    mensaje += "\n\nCampos inválidos \n\n";
                }
                string res = Convert.ToString(10 - telCasaT.Text.Length);
                mensaje += "◉Le faltan " + res + " caracteres al telefono de casa del tutor\n";
            }

            if (telMovilT.Text.Length != 10)
            {

                if (bandera2 == 0)
                {
                    bandera2 = 1;
                    mensaje += "\n\nCampos inválidos \n\n";
                }
                string res = Convert.ToString(10 - telMovilT.Text.Length);
                mensaje += "◉Le faltan " + res + " caracteres al telefono móvil del tutor\n";
            }

            if (telTrabajoT.Text.Length != 10)
            {

                if (bandera2 == 0)
                {
                    bandera2 = 1;
                    mensaje += "\n\nCampos inválidos \n\n";
                }
                string res = Convert.ToString(10 - telTrabajoT.Text.Length);
                mensaje += "◉Le faltan " + res + " caracteres al telefono de trabajo del tutor\n";
            }

            if (telefono.Text.Length != 10)
            {

                if (bandera2 == 0)
                {
                    bandera2 = 1;
                    mensaje += "\n\nCampos inválidos \n\n";
                }
                string res = Convert.ToString(10 - telefono.Text.Length);
                mensaje += "◉Le faltan " + res + " caracteres al telefono de contacto en caso de emergencia\n";
            }





            if (bandera == 1 || bandera2 == 1)
            {
                MessageBox.Show(mensaje, "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                alumno.id_alumno = idalumno;
                alumno.nombre = nombreAl.Text;
                alumno.apellido_paterno = apellidoP.Text;
                alumno.apellido_materno = apellidoM.Text;
                alumno.estado_nacimiento_alumno = estado.Text;
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
                tutor.id_tutor = idtutor;
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
                businessLayer.BLModificacionAlumno.modificarAlumno(alumno);
                businessLayer.BLModificacionAlumno.modificartutor(tutor);
                businessLayer.BLModificacionAlumno.modificarinfomed(infoMed);
                businessLayer.BLModificacionAlumno.modificartelefonotutor(idtutor, telMovilT.Text, 1);
                businessLayer.BLModificacionAlumno.modificartelefonotutor(idtutor, telCasaT.Text,2);
                businessLayer.BLModificacionAlumno.modificartelefonotutor(idtutor, telTrabajoT.Text,3);
                businessLayer.BLModificacionAlumno.modificaralergias(alergiasids, alergiasidsvar,idcartilla);
                businessLayer.BLModificacionAlumno.modificarenfermedades(enfermedadesids, enfermedadesidsvar, idcartilla);
                businessLayer.BLModificacionAlumno.modificardiscapacidades(discapacidadesids, discapacidadesidsvar, idcartilla);
                businessLayer.BLModificacionAlumno.actualizartratamiento(tratamientos.Text, idcartilla);
                ocultarEditarInformacion();
            }
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


        private void numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

       

        private void letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void bajaAlumnoButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = idalumno;
            bajaAlumnoFicha bajaFT = new bajaAlumnoFicha(id,this);
            bajaFT.ShowDialog();
            this.Update();
        }

        private void loaddata()
        {

            foreach (var item in _1dataLayer.DLAltaAlumno.catalogoalergias())
            {
                alergiasCombobox.Items.Add(item.alergia);
                alergiastempcmb.Items.Add(item.id_alergias);
                
            }
            foreach (var item2 in _1dataLayer.DLAltaAlumno.catalogoenfermedades())
            {

                enfermedadesCombobox.Items.Add(item2.enfermedades);
                enfermedadestempcmb.Items.Add(item2.id_enfermedades);

            }
            foreach (var item3 in _1dataLayer.DLAltaAlumno.catalogodiscapacidades())
            {
                discapacidadesCombobox.Items.Add(item3.discapacidades);
                discapacidadestempcmb.Items.Add(item3.id_discapacidades);
            }

        }

        private void agregarEnfermedadesButton_Click(object sender, EventArgs e)
        {
            int idseleccionado;
            string informacion = this.enfermedadesCombobox.GetItemText(this.enfermedadesCombobox.SelectedItem);
            if (enfermedades.Text.Contains(informacion))
            {
                MessageBox.Show("No se puede ingresar información duplicada");
            }
            else
            {
                enfermedades.Text = enfermedades.Text + informacion + "\n"; 
                idseleccionado = enfermedadesCombobox.SelectedIndex + 1;
                enfermedadesids.Add(idseleccionado);
            }
        }

        private void eliminarEnfermedadesButton_Click(object sender, EventArgs e)
        {
            int idseleccionada;
            string informacion = this.enfermedadesCombobox.GetItemText(this.enfermedadesCombobox.SelectedItem);
            enfermedades.Text = enfermedades.Text.Replace("\n"+informacion, " ");
            enfermedades.Text = enfermedades.Text.Replace(informacion+"\n", "");

            idseleccionada = enfermedadesCombobox.SelectedIndex + 1;

            for (int i = 0; i < enfermedadesids.Count(); i++)
            {
                if (enfermedadesids[i] == idseleccionada)
                {
                    enfermedadesids.Remove(idseleccionada);
                }
            }
        }

        private void agregarDiscapacidadesButton_Click(object sender, EventArgs e)
        {
            int idseleccionado;
            string informacion = this.discapacidadesCombobox.GetItemText(this.discapacidadesCombobox.SelectedItem);
            if (discapacidades.Text.Contains(informacion))
            {
                MessageBox.Show("No se puede ingresar información duplicada");
            }
            else
            {
                discapacidades.Text = discapacidades.Text + informacion + "\n"; 
                idseleccionado = discapacidadesCombobox.SelectedIndex + 1;
                discapacidadesids.Add(idseleccionado);
            }
        }

        private void eliminarDiscapacidadesButton_Click(object sender, EventArgs e)
        {
            int idseleccionada;

            string informacion = this.discapacidadesCombobox.GetItemText(this.discapacidadesCombobox.SelectedItem);
            discapacidades.Text = discapacidades.Text.Replace("\n" + informacion, " ");
            discapacidades.Text = discapacidades.Text.Replace(informacion+"\n", "");

            idseleccionada = discapacidadesCombobox.SelectedIndex + 1;

            for (int i = 0; i < discapacidadesids.Count(); i++)
            {
                if (discapacidadesids[i] == idseleccionada)
                {
                    discapacidadesids.Remove(idseleccionada);
                }
            }
        }

        private void agregarAlergiasButton_Click(object sender, EventArgs e)
        {
            string informacion = this.alergiasCombobox.GetItemText(this.alergiasCombobox.SelectedItem);
            int posicioncomboboxTemporal;

            if (alergias.Text.Contains(informacion))
            {
                MessageBox.Show("No se puede ingresar información duplicada");
            }
            else
            {
                alergias.Text = alergias.Text + informacion + "\n";
                posicioncomboboxTemporal = alergiasCombobox.SelectedIndex+1;
                alergiasids.Add(posicioncomboboxTemporal);
            }
        }

        private void eliminarAlergiasButton_Click(object sender, EventArgs e)
        {
            int idseleccionada;
            string informacion = this.alergiasCombobox.GetItemText(this.alergiasCombobox.SelectedItem);
            alergias.Text = alergias.Text.Replace("\n" + informacion, " ");
            alergias.Text = alergias.Text.Replace( informacion+"\n", " ");
            idseleccionada = alergiasCombobox.SelectedIndex+1;
             for(int i = 0; i < alergiasids.Count(); i++)
            {
                if (alergiasids[i] == idseleccionada)
                {
                    alergiasids.Remove(idseleccionada);
                }
            }
        }

        private void fichaTecnica_Load(object sender, FormClosedEventArgs e)
        {
            ConsultaAlumno formConsultas = new ConsultaAlumno();
            this.Hide();
            formConsultas.Show();
        }
    }
}
