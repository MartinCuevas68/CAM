using System;
using System.Collections.Generic;

namespace businessLayer
{
    public class BLAltaAlumno
    {
        static int id_alumno;
        static int id_tutor;
        static int id_medica;
        static int id_alergia;
        static int id_discapacidad;
        static int id_tratamiento;

        //Altas Enfermedades
      

        //Altas alumno
        public static void SetAlumno2(string cicloEsc, string nombreAl, string apellidoP, string apellidoM,
            DateTime fechaNa, string añosCum, string curp, string estado, string ciudad, string colonia,
            string calle, string numeroCasa, string telPersonal, string escuelaP, string canalizado, string value)
        {
            _1dataLayer.alumnoDTO al = new _1dataLayer.alumnoDTO();
            try
            {
                al.fecha_registro = DateTime.Now;
                al.ciclo_escolar = cicloEsc;
                al.nombre = nombreAl;
                al.apellido_paterno = apellidoP;
                al.apellido_materno = apellidoM;
                al.fecha_nacimiento = fechaNa.Date;
                al.edad_alumno = añosCum;
                al.CURP_alumno = curp;
                al.estado_nacimiento_alumno = estado;
                al.ciudad_nacimiento_alumno = ciudad;
                al.colonia_alumno = colonia;
                al.calle_alumno = calle;
                al.numero_alumno = numeroCasa;
                al.telefono_personal_alumno = telPersonal;
                al.escuela_procedencia_alumno = escuelaP;
                al.documentacion_alumno = "";
                al.atendido_por = canalizado;
                al.tipo_ingreso = value;

                id_alumno = _1dataLayer.DLAltaAlumno.Altaalumno(al);

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas tutor
        public static void SetTutor2(string nombreT, string apellidoPT, string apellidoMT, string coloniaT, string calleT, string numeroCasaT,
            string ocupacion, string colonia_trabajo_tutor, string calle_trabajo_tutor, string telTrabajoT)
        //, string telCasaT, string telMovilT, string telTrabajoT
        {
            //byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            //int y = 1;

            _1dataLayer.tutorDTO tuto = new _1dataLayer.tutorDTO();
            try
            {
                tuto.nombre = nombreT;
                tuto.apellido_paterno = apellidoPT;
                tuto.apellido_materno = apellidoMT;
                tuto.colonia_tutor = coloniaT;
                tuto.calle_tutor = calleT;
                tuto.numero_tutor = numeroCasaT;
                tuto.ocupacion_tutor = ocupacion;
                tuto.colonia_trabajo_tutor = colonia_trabajo_tutor;
                tuto.calle_trabajo_tutor = calle_trabajo_tutor;
                tuto.numero_trabajo_tutor = telTrabajoT;
                

                id_tutor = _1dataLayer.DLAltaAlumno.Altatutor(tuto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas información médica del alumno
        public static void SetInfoMedAlumno2(string servMedico, string grupoSanguineoComboBox, string telefono, string peso, string color_textura_piel, string estatura)
        {
            //byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            //int y = 1;

            _1dataLayer.tabla_medicaDTO tablita = new _1dataLayer.tabla_medicaDTO();

            try
            {
                tablita.servicio_medico = servMedico;
                tablita.grupo_sanguineo = grupoSanguineoComboBox;
                tablita.telefono_contacto = telefono;
                tablita.genero = null;
                tablita.peso = 82;
                tablita.color_textura_piel = "aaa";
                tablita.estatura = 1.98;


                id_medica = _1dataLayer.DLAltaAlumno.Altacartilla(tablita);

                Console.WriteLine(id_medica + " " + id_alumno + " " + id_tutor);
                _1dataLayer.DLAltaAlumno.Altaalumnocartilla(id_alumno, id_medica);
                _1dataLayer.DLAltaAlumno.Altaalumnotutor(id_alumno, id_tutor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void SetFotoAlumno(_1dataLayer.imagenalumnoDTO foto)
        {
            foto.id_alumno = id_alumno;
            _1dataLayer.DLAltaAlumno.AltaImagenAlumno(foto);
        }

        //Altas Alergias
        public static void SetAlergias(string alergias)
        {
            _1dataLayer.alergiasDTO alg = new _1dataLayer.alergiasDTO();

            List<_1dataLayer.alergiasDTO> lista_alergia = new List<_1dataLayer.alergiasDTO>();

            try
            {
                alg.alergia = alergias;
       //        _1dataLayer.DLAltaAlumno.Altaalergias(id_alergia, lista_alergia);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas Enfermedades
        public static void SetEnfermedades(List<String> enfermedades)
        {
            //_1dataLayer.enfermedadesDTO enf = new _1dataLayer.enfermedadesDTO();

            //List<_1dataLayer.enfermedadesDTO> lista_enfermedad = new List<_1dataLayer.enfermedadesDTO>();

                try
                {
            //        _1dataLayer.DLAltaAlumno.Altaenfermedades(id_medica, enfermedades);
                }
                catch (Exception)
                {
                    throw;
                }
        }

        //Altas Discapacidades
        public static void SetDiscapacidades(string discapacidad)
        {
            _1dataLayer.discapacidadesDTO disc = new _1dataLayer.discapacidadesDTO();

            List<_1dataLayer.discapacidadesDTO> lista_discapacidad = new List<_1dataLayer.discapacidadesDTO>();

            try
            {
                disc.discapacidades = discapacidad;
                //_1dataLayer.DLAltaAlumno.Altadiscapacidades(id_discapacidad, lista_discapacidad);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas Tratamientos
        public static void SetTratamiento(string tratamiento)
        {
            _1dataLayer.Tratamientos trat = new _1dataLayer.Tratamientos();

           // List<_1dataLayer.Tratamientos> lista_tratamiento = new List<_1dataLayer.Tratamientos>();

            try
            {
                trat.Tratamiento = tratamiento;
                //_1dataLayer.DLAltaAlumno.Altatratamiento(id_tratamiento, lista_tratamiento);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }


}
