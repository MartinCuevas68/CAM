using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    class fernandoDTO
    {
        public class tutor
        {
            int id_tutor { get; }
            string Nombre { get; set; }
            string Apellido_paterno { get; set; }
            string Apellido_materno { get; set; }
            string colonia_tutor { get; set; }
            string calle_tutor { get; set; }
            string numero_tutor { get; set; }
            string ocupacion_tutor { get; set; }
            string colonia_trabajo_tutor { get; set; }
            string calle_trabajo_tutor { get; set; }
            string numero_trabajo_tutor { get; set; }
        }

        public class tutor_alumno
        {
            int id_alumno { get; }
            int id_tutor { get; }
        }

        public class telefono_tutor
        {
            int id_tutor { get; }
            int id_telefono { get; }
            int telefono { get; set; }
        }

        public class identidicadores_telefonos
        {
            int id_telefono { get; }
            string tipo_telefono { get; set; }
        }
    }
}
