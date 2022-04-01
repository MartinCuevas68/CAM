using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class DLModificacionAlumno
    {

        public static void Modificacionalumno(int id, SP_FichaTecnicaAlumno_Result alumno)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_ModificacionAlumno(id, alumno.ciclo_escolar, alumno.nombre, alumno.apellido_paterno, alumno.apellido_materno, alumno.fecha_nacimiento, alumno.edad_alumno, alumno.CURP_alumno, alumno.estado_nacimiento_alumno, alumno.ciudad_nacimiento_alumno, alumno.colonia_alumno, alumno.calle_alumno, alumno.numero_alumno, alumno.telefono_personal_alumno, alumno.escuela_procedencia_alumno, alumno.documentacion_alumno, alumno.atendido_por, alumno.tipo_ingreso);
            }
        }

        public static void ModificacionEnfermedad(int id, String en)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.Modificar_enfermedades(id, en);
            }
        }

        public static void ModificacionDiscapacidad(int id, string disc)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.Modificar_discapacidades(id, disc);
            }
        }

        public static void ModificacionAlergia(int id, string alergia)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_Modificar_alergias(id, alergia);
            }
        }

        public static void ModificacionTutor(int id, SP_FichaTecnicaAlumnoTutor_Result tutor)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                Console.WriteLine("Desde data layer: ", tutor.nombre);
                Console.WriteLine("ID: " + id);
                db.SP_ModificacionTutor(id, tutor.nombre, tutor.apellido_paterno, tutor.apellido_materno, tutor.calle_tutor, tutor.colonia_tutor, tutor.numero_tutor, tutor.ocupacion_tutor);
            }
        }

        public static void modificacionmedica(int id, SP_FichaTecnicaAlumnoMedica_Result medica)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_ModificacionCartilla(id, medica.servicio_medico, medica.grupo_sanguineo, medica.telefono_contacto);
            }
        }

         public static void modificaciontelefono(int id_tutor, telefono_tutorDTO tuto)
        {
            using(BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_ModificarTelefonoTutor(id_tutor, tuto.id_telefono, tuto.telefono.ToString());
            }
        }

    }
}
