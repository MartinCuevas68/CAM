using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace businessLayer
{
    public class Hueso
    {
        
        public static List<_1dataLayer.alumnoDTO> alumnosGet()
        {
            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())
                {
                    var query = (from a in db.pruebas
                                 select new _1dataLayer.alumnoDTO
                                 {


                                     idPrueba = a.idPrueba,
                                     nombre = a.nombre,
                                     edad = a.edad



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
