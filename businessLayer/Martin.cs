using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer
{
    public class Martin
    {

        public static void EliminarColaborador(int id)
        {


            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())
                {
                    var query = new _1dataLayer.alumno { id_alumno = id };

                    db.alumno.Attach(query);
                    db.alumno.Remove(query);
                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
