using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    class AltaAlumno
    {
        static ObjectResult<decimal?> e;
        static ObjectResult<SP_FichaTecnicaAlumno_Result> i;
        public static void Main(string[] args)
        {
            DateTime thisdate;
            int id = 0;
            thisdate = DateTime.Today;
            
            using(BDCAMEntities1 db = new BDCAMEntities1())
            {
               //db.SP_AltaAlumno(thisdate, "2022", "Pedro", "Parker", "Parker", thisdate, "20", "abc", "sonora", "hermosillo", "scally", "juarez", "23", "234", "Andes", "de todo", "julio");
               e = db.sp_regresarid();
               
            foreach(decimal? a in e)
                {
                    Console.WriteLine("entre");
                    Console.WriteLine(a);
                    id = Convert.ToInt32(a);
                }
               Console.WriteLine(id);
                i = db.SP_FichaTecnicaAlumno(id);
                foreach (SP_FichaTecnicaAlumno_Result result in i)
                {
                    Console.WriteLine("{0}", result.nombre);

                    Console.WriteLine("{0}", result.telefono_personal_alumno);

                }
                Console.ReadKey();
            }
           
        }
    }
}
