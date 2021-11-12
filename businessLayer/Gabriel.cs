using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer
{
    public class Gabriel
    {
        public static List<_1dataLayer.alumnoDTO> alumnosGet()
        {
            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())
                {
                    var query = (from a in db.alumno
                                 select new _1dataLayer.alumnoDTO
                                 {
                                     id_alumno = a.id_alumno,

                                 }).ToList();
                    return query;
                }
            }
            catch (Exception)
            {
                throw;
            }



        }
    }
}
