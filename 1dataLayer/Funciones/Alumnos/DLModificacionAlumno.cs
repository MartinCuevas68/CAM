using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class DLModificacionAlumno
    {
        public static void Modificacionalumno(int id,alumnoDTO alumno)
        {
            using (BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_ModificacionAlumno(id, alumno.ciclo_escolar, alumno.nombre, alumno.apellido_paterno, alumno.apellido_materno, alumno.fecha_nacimiento, alumno.edad_alumno, alumno.CURP_alumno, alumno.estado_nacimiento_alumno, alumno.ciudad_nacimiento_alumno, alumno.colonia_alumno, alumno.calle_alumno, alumno.numero_alumno, alumno.telefono_personal_alumno, alumno.escuela_procedencia_alumno, alumno.documentacion_alumno, alumno.atendido_por,alumno.tipo_ingreso);
            }
        }
    }
}
