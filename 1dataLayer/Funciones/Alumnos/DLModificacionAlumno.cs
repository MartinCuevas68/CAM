using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class DLModificacionAlumno
    {
        public static void Main(String[] args) 
        {
            Console.WriteLine("Ingrese la enfermedad nueva: ");
            String enf = Console.ReadLine();
            Console.WriteLine("Ingrese la discapacidad nueva: ");
            String disc = Console.ReadLine();
            ModificacionDiscapacidad(5, disc);
            ModificacionEnfermedad(7, enf);
        }
        public static void Modificacionalumno(int id,alumnoDTO alumno)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_ModificacionAlumno(id, alumno.ciclo_escolar, alumno.nombre, alumno.apellido_paterno, alumno.apellido_materno, alumno.fecha_nacimiento, alumno.edad_alumno, alumno.CURP_alumno, alumno.estado_nacimiento_alumno, alumno.ciudad_nacimiento_alumno, alumno.colonia_alumno, alumno.calle_alumno, alumno.numero_alumno, alumno.telefono_personal_alumno, alumno.escuela_procedencia_alumno, alumno.documentacion_alumno, alumno.atendido_por,alumno.tipo_ingreso);
            }
        }

        public static void ModificacionEnfermedad(int id,String en)
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
    }
}
