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

        //Metodo para dar de alta alergias
        public static void Altaalergias(int id, List<alergiasDTO> alergia)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                foreach (alergiasDTO alergias in alergia)
                {
                    db.sp_altaenfermedades(id, alergias.alergia);
                }

            }
        }

        public static void Altaenfermedades(int id, List<string> enfermedad)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                foreach (string enfer in enfermedad)
                {
                    db.sp_altaenfermedades(id, enfer);
                }
            }
        }

        public static void Altadiscapacidades(int id, List<discapacidadesDTO> discapacidad)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                foreach (discapacidadesDTO disc in discapacidad)
                {
                    db.sp_altaenfermedades(id, disc.discapacidades);
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

        public static void Altatelefonotutor(telefono_tutorDTO telefono)
        {
            String tel = telefono.telefono.ToString();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.sp_telefonotutores(telefono.id_tutor, telefono.id_telefono, tel);
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

       
    }
}

