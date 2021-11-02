using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    class fernandoDTO
    {
        public class padre
        {
            int id_padre { get; }
            string nombre { get; set; }
            string apellido_mat { get; set; }
            string apellido_pat { get; set; }
            string colonia_padre { get; set; }
            string calle_padre { get; set; }
            string numero_padre { get; set; }
            string ocupacion_padre { get; set; }
            string colonia_trabajo_padre { get; set; }
            string calle_trabajo_padre { get; set; }
            string numero_trabajo_padre { get; set; }
        }

        public class padrehijo
        {
            int idalumno { get; }
            int idpadre { get; }
        }

        public class padretelefono
        {
            int idpadre { get; }
            int idtelefono { get; }
            int telefono { get; set; }
        }

        public class identidicadorestelefonos
        {
            int idtelefono { get; }
            string tipotelefono { get; set; }
        }
    }
}
