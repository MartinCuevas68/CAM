using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class DLEliminacionAlumno
    {

        public static void eliminacion(int id)
        {
            using(BDCAMEntities db = new BDCAMEntities())
            {
                db.SP_Eliminar_Alumno(id);
            }
        }
    }
}
