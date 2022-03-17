using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace businessLayer
{
    public class Hueso
    {
        static int id_alumno;
        static int id_tutor;
        static int id_medica;
        //Altas

        //Altas alumno

        public static void SetAlumno(string cicloEsc, string nombreAl, string apellidoP, string apellidoM,
            DateTime fechaNa, string añosCum, string curp, string estado, string ciudad, string colonia,
            string calle, string numeroCasa, string telPersonal, string escuelaP, string canalizado)
        {
            //byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            //int y = 1;
           

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
                id_alumno = _1dataLayer.AltaAlumno.Altaalumno(al);
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas tutor
        public static void SetTutor(string nombreT, string apellidoPT, string apellidoMT, string coloniaT, string calleT, string numeroCasaT,
            string ocupacion, string colonia_trabajo_tutor, string calle_trabajo_tutor, string numero_trabajo_tutor)
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
                tuto.numero_trabajo_tutor = numero_trabajo_tutor;
                //telCasaT = telCasaT,
                //telMovilT = telMovilT,
                //telTrabajoT = telTrabajoT
                id_tutor = _1dataLayer.AltaAlumno.Altatutor(tuto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas telefono tutor
        /*public static void SetTelefonoTutor(telCasa, telMovil, telTrabajo)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.telefono_tutores>();
                    query.Add(new _1dataLayer.telefono_tutores
                    {
                        telCsa =
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/


        //Altas información médica del alumno
        public static void SetInfoMedAlumno(string servMedico, string grupoSanguineo, string telefono, string genero, string peso, string color_textura_piel, string estatura)
        {
            //byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            //int y = 1;

            _1dataLayer.tabla_medicaDTO tablita = new _1dataLayer.tabla_medicaDTO();

            try
            {
                tablita.servicio_medico = servMedico;
                tablita.grupo_sanguineo = grupoSanguineo;
                tablita.telefono_contacto = telefono;
                tablita.genero = null;
                tablita.peso = 82;
                tablita.color_textura_piel = "Carton";
                tablita.estatura = 1.98;
                id_medica = _1dataLayer.AltaAlumno.Altacartilla(tablita);
                _1dataLayer.AltaAlumno.Altaalumnocartilla(id_alumno, id_medica);
                _1dataLayer.AltaAlumno.Altaalumnotutor(id_alumno, id_tutor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas Discapacidad
        public static void SetDiscapacidades(string discapacidad)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.discapacidade>();
                    query.Add(new _1dataLayer.discapacidade
                    {
                        id_cartilla_medica = y++,
                        discapacidades = discapacidad
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas Enfermedad
        public static void SetEnfermedades(string enfermedades)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.enfermedade>();
                    query.Add(new _1dataLayer.enfermedade
                    {
                        id_cartilla_medica = y++,
                        enfermedad = enfermedades
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas Alergias
        public static void SetAlergias(string alergias)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.alergias>();
                    query.Add(new _1dataLayer.alergias
                    {
                        id_cartilla_medica = y++,
                        alergia = alergias
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas Tratamiento
        /*public static void SetTratamiento(string tratamiento)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.tratamientos>();
                    query.Add(new _1dataLayer.tratamientos
                    {
                        id_cartilla_medica = y++,
                        tratamiento = tratamiento
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/

    }


}
