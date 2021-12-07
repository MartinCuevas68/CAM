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
        
        public static void SetAlumno(int id_alumno, string ciclo_escolar, string nombre, string apellido_paterno, string apellido_materno,
            DateTime fecha_nacimiento, string edad_alumno, string CURP_alumno, string estado_nacimiento_alumno, string ciudad_nacimiento_alumno,
            string colonia_alumno, string calle_alumno, string numero_alumno, string telefono_personal_alumno, string escuela_procedencia_alumno,
            string documentacion_alumno, string atendido_por)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };

            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.alumno>();
                    query.Add(new _1dataLayer.alumno
                    {
                        id_alumno = id_alumno,
                        fecha_registro = x,
                        ciclo_escolar = ciclo_escolar,
                        nombre = nombre,
                        apellido_paterno = apellido_paterno,
                        fecha_nacimiento = DateTime.Now,
                        edad_alumno = edad_alumno,
                        CURP_alumno = CURP_alumno,
                        estado_nacimiento_alumno = estado_nacimiento_alumno,
                        ciudad_nacimiento_alumno = ciudad_nacimiento_alumno,
                        colonia_alumno = colonia_alumno,
                        calle_alumno = calle_alumno,
                        numero_alumno = numero_alumno,
                        telefono_personal_alumno = telefono_personal_alumno,
                        escuela_procedencia_alumno = escuela_procedencia_alumno,
                        documentacion_alumno = documentacion_alumno,
                        atendido_por = atendido_por
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
