using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace businessLayer
{
    public class Hueso
    {
        //Altas
        
        public static void SetAlumno(string nombre, string ciclo_escolar)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };

            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.alumno>();
                    query.Add(new _1dataLayer.alumno
                    {
                        fecha_registro = x,
                        ciclo_escolar = ciclo_escolar,
                        nombre = nombre,
                        apellido_paterno = "hueso",
                        fecha_nacimiento = DateTime.Now,
                        años_alumno = "40",
                        CURP_alumno = "asd",
                        estado_nacimiento_alumno = "Tamaulipas",
                        ciudad_nacimiento_alumno = "Necaxa",
                        colonia_alumno = "Atizapan",
                        calle_alumno = "Elote #120",
                        numero_alumno = "777",
                        telefono_personal_alumno = "68662524",
                        escuela_procedencia_alumno = "Harvard",
                        documentacion_alumno = "FORZAR",
                        atendido_por = "Abad",
                        

                    });

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
