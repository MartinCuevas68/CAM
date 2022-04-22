using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace businessLayer
{
    public class BLFichaTecnica
    {

        public static int infoGenAlumno(TextBox alumnoAl, TextBox apellidoP, TextBox apellidoM, TextBox edad, TextBox matricula,
            DateTimePicker fechaNa, TextBox ciudad, TextBox estado, TextBox curp, TextBox telPersonal, TextBox calle, TextBox numeroCasa,
            TextBox colonia, TextBox tipoIngreso, int id_alumno)
        {

            _1dataLayer.SP_FichaTecnicaAlumno_Result alumno = new _1dataLayer.SP_FichaTecnicaAlumno_Result();

            alumno = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);
            alumnoAl.Text = alumno.nombre;
            apellidoP.Text = alumno.apellido_paterno;
            apellidoM.Text = alumno.apellido_materno;
            edad.Text = alumno.edad_alumno;
            matricula.Text = alumno.id_alumno.ToString();
            fechaNa.Value = alumno.fecha_nacimiento;
            ciudad.Text = alumno.ciudad_nacimiento_alumno;
            estado.Text = alumno.estado_nacimiento_alumno;
            curp.Text = alumno.CURP_alumno;
            telPersonal.Text = alumno.telefono_personal_alumno;
            calle.Text = alumno.calle_alumno;
            numeroCasa.Text = alumno.numero_alumno;
            colonia.Text = alumno.colonia_alumno;
            tipoIngreso.Text = alumno.tipo_ingreso;

            return alumno.id_alumno;
        }

        public static void infoEscAlumno(TextBox tipoIngreso, TextBox escuelaP, TextBox canalizado, TextBox cicloEsc, int id_alumno) 
        { 
            _1dataLayer.SP_FichaTecnicaAlumno_Result alumno = new _1dataLayer.SP_FichaTecnicaAlumno_Result();

            alumno = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);
            tipoIngreso.Text = alumno.tipo_ingreso;
            escuelaP.Text = alumno.escuela_procedencia_alumno;
            canalizado.Text = alumno.atendido_por;
            cicloEsc.Text = alumno.ciclo_escolar;
        }

        public static int infoTutor(TextBox nombreT, TextBox apellidoPT, TextBox apellidoMT, TextBox calleT, TextBox numeroCasaT, TextBox coloniaT, TextBox ocupacion, TextBox telCasaT, TextBox telMovilT, TextBox telTrabajoT, int id_alumno)
        {
            
            //id alumno: 92 tiene el id tutor: 77 y el tutor tiene los 3 numeros

            List<_1dataLayer.SP_ListaTelefonosTutor_Result> ListaTelefonoTutor = new List<_1dataLayer.SP_ListaTelefonosTutor_Result>();
            _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result tutor = new _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result();

            
            tutor = _1dataLayer.DLConsultaAlumno.FichaTecnicaTutor(id_alumno);
            ListaTelefonoTutor = _1dataLayer.DLConsultaAlumno.consultartelefonotutor(tutor.id_tutor);

            
            nombreT.Text = tutor.nombre;
            apellidoPT.Text = tutor.apellido_paterno;
            apellidoMT.Text = tutor.apellido_materno;
            calleT.Text = tutor.calle_tutor;
            numeroCasaT.Text = tutor.numero_tutor;
            coloniaT.Text = tutor.colonia_tutor;
            ocupacion.Text = tutor.ocupacion_tutor;

            telCasaT.Text = ListaTelefonoTutor.ElementAt(0).telefono.ToString();
            telMovilT.Text = ListaTelefonoTutor.ElementAt(1).telefono.ToString();
            telTrabajoT.Text = ListaTelefonoTutor.ElementAt(2).telefono.ToString();

            return tutor.id_tutor;
        }

        public static int infoMedAlumno(TextBox servMedico, TextBox telefono, TextBox grupoSanguineo, int id_alumno)
        { 
            _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result infoMed = new _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result();

            infoMed = _1dataLayer.DLConsultaAlumno.FichaTecnicaMedica(id_alumno);
            servMedico.Text = infoMed.servicio_medico;
            telefono.Text = infoMed.telefono_contacto;
            grupoSanguineo.Text = infoMed.grupo_sanguineo;
            return infoMed.id_cartilla_medica;
        }

        public static void infoMedAlumno2(RichTextBox discapacidades, RichTextBox enfermedades, RichTextBox alergias, RichTextBox tratamientos, int id_alumno,List<int> alergiasid,List<int> discapacidadesids,List<int> enfermedadesids,List<int> alergiasidsvar,List<int> discapacidadesidsvar, List<int> enfermedadesidsvar)
        {
            List<_1dataLayer.SP_ListaDiscapacidad_Result> ListaDiscapacidades = new List<_1dataLayer.SP_ListaDiscapacidad_Result>();
            List<_1dataLayer.SP_ListaEnfermedad_Result>  ListaEnfermedades = new List <_1dataLayer.SP_ListaEnfermedad_Result>();
            List<_1dataLayer.SP_ListaAlergia_Result> ListaAlergias = new List<_1dataLayer.SP_ListaAlergia_Result>();
            List<_1dataLayer.SP_ListaTratamiento_Result> ListaTratamientos = new List<_1dataLayer.SP_ListaTratamiento_Result>();

            ListaDiscapacidades = _1dataLayer.DLConsultaAlumno.ListaDiscapacidad(id_alumno);
            ListaEnfermedades = _1dataLayer.DLConsultaAlumno.ListaEnfermedades(id_alumno);
            ListaAlergias = _1dataLayer.DLConsultaAlumno.ListaAlergias(id_alumno);
            ListaTratamientos = _1dataLayer.DLConsultaAlumno.ListaTratamiento(id_alumno);

            foreach (var discapacidad in ListaDiscapacidades)
            {
                discapacidades.Text = discapacidades.Text + discapacidad.discapacidades + "\n";
                discapacidadesids.Add(discapacidad.id_discapacidades);
                discapacidadesidsvar.Add(discapacidad.id_discapacidades);
            }

            foreach (var enfermedad in ListaEnfermedades)
            {
                enfermedades.Text = enfermedades.Text + enfermedad.enfermedades + "\n";
                enfermedadesids.Add(enfermedad.id_enfermedades);
                enfermedadesidsvar.Add(enfermedad.id_enfermedades);
            }

            foreach (var alergia in ListaAlergias)
            {
                alergias.Text = alergias.Text + alergia.alergia + "\n";
                alergiasid.Add(alergia.id_alergias);
                alergiasidsvar.Add(alergia.id_alergias);
            }

            foreach (var tratamiento in ListaTratamientos)
            {
                tratamientos.Text = tratamientos.Text + tratamiento.Tratamiento + "\n";
            }


        }


     

    }
}
