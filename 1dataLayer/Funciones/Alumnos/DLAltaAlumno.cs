using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class DLAltaAlumno
    {

        //Metodo para dar de alta alergias. Mandas el id del alumno despues de dar la alta y el listado con los ints de la alergia (QUEDA PENDIENTE CHECAR EL PROCEDIMIENTO EN LA SQL MANAGER)
        public static void Altaalergias(int id, List<int> alergia)
        {
           
            using (BDCAMEntities db = new BDCAMEntities())
            {
                foreach (int al in alergia)
                {
                    db.sp_altaalergias(id, al);
                }
            }
        }

        //Metodo para dar de alta enfermedades. Mandas el id del alumno despues de dar la alta y el listado con los ints de la enfermedad(QUEDA PENDIENTE CHECAR EL PROCEDIMIENTO EN LA SQL MANAGER)
        public static void Altaenfermedades(int id, List<int> enfermedad)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                foreach (int enfer in enfermedad)
                {
                    db.sp_altaenfermedades(id, enfer);
                }
            }
        }

        //Metodo para dar de alta discapacidades. Mandas el id del alumno despues de dar la alta y el listado con los ints de la discapacidad(QUEDA PENDIENTE CHECAR EL PROCEDIMIENTO EN LA SQL MANAGER)
        public static void Altadiscapacidades(int id, List<int> discapacidad)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                foreach (int disc in discapacidad)
                {
                    db.sp_altadiscapacidades(id, disc);
                }

            }
        }
        public static int Altaalumno(alumnoDTO alumno)
        {
            ObjectResult<decimal?> e;
            int id = 0;
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_AltaAlumno(alumno.fecha_registro, alumno.ciclo_escolar, alumno.nombre, alumno.apellido_paterno, alumno.apellido_materno, alumno.fecha_nacimiento, alumno.edad_alumno, alumno.CURP_alumno, alumno.estado_nacimiento_alumno, alumno.ciudad_nacimiento_alumno, alumno.colonia_alumno, alumno.calle_alumno, alumno.numero_alumno, alumno.telefono_personal_alumno, alumno.escuela_procedencia_alumno, alumno.documentacion_alumno, alumno.tipo_ingreso, alumno.atendido_por);
                e = db.sp_regresarid();
                foreach (decimal? a in e)
                {
                    id = Convert.ToInt32(a);
                }
            }
            return id;
        }

        public static void Altaalumnocartilla(int idalumno, int idcartilla)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.sp_altaalumnocartilla(idalumno, idcartilla);
            }
        }

        public static int Altatutor(tutorDTO tutor)
        {
            ObjectResult<decimal?> e;
            int id = 0;
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.sp_altatutor(tutor.nombre, tutor.apellido_paterno, tutor.apellido_materno, tutor.colonia_tutor, tutor.calle_tutor, tutor.numero_tutor, tutor.ocupacion_tutor, tutor.colonia_trabajo_tutor, tutor.calle_trabajo_tutor, tutor.numero_trabajo_tutor);
                e = db.sp_regresaridtutor();
                foreach (decimal? a in e)
                {
                    id = Convert.ToInt32(a);
                }
            }
            return id;
        }

        public static int Altacartilla(tabla_medicaDTO tabla)
        {
            ObjectResult<decimal?> e;
            int id = 0;
            String p = tabla.peso.ToString();
            String s = tabla.estatura.ToString();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.sp_altacartilla(tabla.servicio_medico, tabla.grupo_sanguineo, tabla.telefono_contacto, p, tabla.genero, tabla.color_textura_piel, s);
                e = db.sp_regresaridcartilla();
                foreach (decimal? a in e)
                {
                    id = Convert.ToInt32(a);
                }
            }
            return id;
        }

        //Primero manda el id del tutor, despues manda el telefono personal, despues el telefono de casa y al final el telefono del trabajo.
        public static void Altatelefonotutor(int id_tutor, string tel_personal, string tel_casa, string tel_trabajo)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                //ID 1 PARA EL PERSONAL
                db.sp_telefonotutores(id_tutor,1, tel_personal);
                //ID 2 PARA EL CASA
                db.sp_telefonotutores(id_tutor, 2, tel_casa);
                //ID 3 PARA EL TRABAJO
                db.sp_telefonotutores(id_tutor, 3, tel_trabajo);
            }
        }


        public static void Altaalumnotutor(int idalumno, int idtutor)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.sp_tutoralumno(idalumno, idtutor);
            }
        }

        public static void AltaImagenAlumno(imagenalumnoDTO imagen)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_AltaImagenAlumno(imagen.id_alumno, imagen.imagen, imagen.nombre);
            }
        }

        public static void altatratamiento(int cartilla,tratamientoDTO tratamiento)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_AltaTratamientos(cartilla, tratamiento.tratamiento);
            }
        }
        public static List<sp_catalogoenfermedades_Result> catalogoenfermedades()
        {
            List<sp_catalogoenfermedades_Result> enfermedades = new List<sp_catalogoenfermedades_Result>();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<sp_catalogoenfermedades_Result> x = db.sp_catalogoenfermedades();

                foreach (sp_catalogoenfermedades_Result result in x)
                {
                    enfermedades.Add(result);
                }
            }
            return enfermedades;
        }

        public static List<sp_catalogoalergias_Result> catalogoalergias()
        {
            List<sp_catalogoalergias_Result> alergias = new List<sp_catalogoalergias_Result>();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<sp_catalogoalergias_Result> x = db.sp_catalogoalergias();

                foreach (sp_catalogoalergias_Result result in x)
                {
                    alergias.Add(result);
                }
            }
            return alergias;
        }


        public static List<sp_catalogodiscapacidades_Result> catalogodiscapacidades()
        {
            List<sp_catalogodiscapacidades_Result> discapacidades = new List<sp_catalogodiscapacidades_Result>();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<sp_catalogodiscapacidades_Result> x = db.sp_catalogodiscapacidades();

                foreach (sp_catalogodiscapacidades_Result result in x)
                {
                    discapacidades.Add(result);
                }
            }
            return discapacidades;
        }

    }
}

