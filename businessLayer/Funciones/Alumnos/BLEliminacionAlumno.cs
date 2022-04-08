using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace businessLayer
{
    public class BLEliminacionAlumno
    {
        /*
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

        public static List<_1dataLayer.alergiasDTO> alergiasGet()
        {
            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())
                {
                    var query = (from a in db.alergias
                                 select new _1dataLayer.alergiasDTO
                                 {

                                     alergia = a.alergia

                                 }).ToList();
                    return query;
                }

            }
            catch (Exception)
            {
                throw;
            }


        }

        public static void InformacionGeneral(TextBox nombreAL, int id_alumno)
        {
            _1dataLayer.SP_FichaTecnicaAlumno_Result alumno = new _1dataLayer.SP_FichaTecnicaAlumno_Result();

            alumno = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);

            nombreAL.Text = alumno.nombre;

        }

        public static List<_1dataLayer.discapacidadesDTO> discapacidadesGet()
        {
            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())
                {
                    var query = (from a in db.discapacidades
                                 select new _1dataLayer.discapacidadesDTO
                                 {

                                     discapacidades = a.discapacidades1

                                 }).ToList();
                    return query;
                }

            }
            catch (Exception)
            {
                throw;
            }


        }

        public static List<_1dataLayer.enfermedadesDTO> enfermedadesGet()
        {
            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())
                {
                    var query = (from a in db.enfermedades
                                 select new _1dataLayer.enfermedadesDTO
                                 {

                                     enfermedad = a.enfermedad

                                 }).ToList();
                    return query;
                }

            }
            catch (Exception)
            {
                throw;
            }


        }


        public static void ModAlumno(string ciclo_escolar, string nombre, string apellido_paterno, string apellido_materno,
            DateTime fecha_nacimiento, string edad_alumno, string CURP_alumno, string estado_nacimiento_alumno, string ciudad_nacimiento_alumno,
            string colonia_alumno, string calle_alumno, string numero_alumno, string telefono_personal_alumno, string escuela_procedencia_alumno,
            string atendido_por, int id)
        {

            try
            {

                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())
                {


                    var query = db.alumno.SingleOrDefault(b => b.id_alumno == id);
                    if (query != null)
                    {
                        query.fecha_registro = DateTime.Now;
                        query.ciclo_escolar = ciclo_escolar;
                        query.nombre = nombre;
                        query.apellido_paterno = apellido_paterno;
                        query.apellido_materno = apellido_materno;
                        query.fecha_nacimiento = fecha_nacimiento.Date;
                        query.edad_alumno = edad_alumno;
                        query.CURP_alumno = CURP_alumno;
                        query.estado_nacimiento_alumno = estado_nacimiento_alumno;
                        query.ciudad_nacimiento_alumno = ciudad_nacimiento_alumno;
                        query.colonia_alumno = colonia_alumno;
                        query.calle_alumno = calle_alumno;
                        query.numero_alumno = numero_alumno;
                        query.telefono_personal_alumno = telefono_personal_alumno;
                        query.escuela_procedencia_alumno = escuela_procedencia_alumno;
                        //documentacion_alumno = documentacion_alumno,
                        query.atendido_por = atendido_por;


                        db.SaveChanges();
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static List<_1dataLayer.alumnoDTO> nombreGetid(int id)
        {
            try
            {

                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())
                {
                    var query = (from p in db.alumno
                                 where p.id_alumno == id
                                 select new _1dataLayer.alumnoDTO
                                 {
                                     nombre = p.nombre


                                 }).ToList();

                    return query;

                }

            }
            catch (Exception)
            {
                throw;
            }


        }

    }*/
}

