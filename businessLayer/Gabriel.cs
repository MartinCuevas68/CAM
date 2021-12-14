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
                                     fecha_registro = a.fecha_registro,
                                     ciclo_escolar = a.ciclo_escolar,
                                     nombre = a.nombre,
                                     apellido_paterno = a.apellido_paterno,
                                     apellido_materno = a.apellido_materno,
                                     fecha_nacimiento = a.fecha_nacimiento,
                                     edad_alumno = a.edad_alumno,
                                     CURP_alumno = a.CURP_alumno,
                                     estado_nacimiento_alumno = a.estado_nacimiento_alumno,
                                     ciudad_nacimiento_alumno = a.ciudad_nacimiento_alumno,
                                     colonia_alumno = a.colonia_alumno,
                                     calle_alumno = a.calle_alumno,
                                     numero_alumno = a.numero_alumno,
                                     telefono_personal_alumno = a.telefono_personal_alumno,
                                     escuela_procedencia_alumno = a.escuela_procedencia_alumno,
                                     //documentacion_alumno = a.documentacion_alumno,
                                     atendido_por = a.atendido_por,
                                    
                                 }).ToList();
                    return query;
                }

            }
            catch (Exception)
            {
                throw;
            }

            /*//Consultas
            public static List<Data_Tutuli.EspacioDTO> GetEspacios()
            {
                try
                {

                    using (Data_Tutuli.DB_tutuliEntities db = new Data_Tutuli.DB_tutuliEntities())
                    {
                        var query = (from p in db.espacios

                                     select new Data_Tutuli.EspacioDTO
                                     {
                                         tamaño = p.tamaño,
                                         numeroEspacio = p.numeroEspacio

                                     }).ToList();

                        return query;

                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }*/



        }
    }
}
