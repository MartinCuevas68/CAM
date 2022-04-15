using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer
{
    public class BLConsultaAlumno
    {
        /*public static List<_1dataLayer.alumnoDTO> alumnosGet()
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
        }*/
        
        public static List<_1dataLayer.alumnoenfermedadDTO> alumnosGet()
        {
            
            try
            {
                List<_1dataLayer.alumnoenfermedadDTO> student = new List<_1dataLayer.alumnoenfermedadDTO>();
                _1dataLayer.alumnoenfermedadDTO var = new _1dataLayer.alumnoenfermedadDTO();

                _1dataLayer.DLConsultaAlumno listaAlumnos = new _1dataLayer.DLConsultaAlumno();

                List<_1dataLayer.SP_ListaAlumnos_Result> mostrarAlumnos = new List<_1dataLayer.SP_ListaAlumnos_Result>();
                List<_1dataLayer.SP_ListaAlergia_Result> mostrarAlergias = new List<_1dataLayer.SP_ListaAlergia_Result>();
                List<_1dataLayer.SP_ListaDiscapacidad_Result> mostrarDiscapacidades = new List<_1dataLayer.SP_ListaDiscapacidad_Result>();
                String discapacidades = null;
                String alergias = null;

                mostrarAlumnos = listaAlumnos.AlumnoLista();

                List<_1dataLayer.SP_ListaAlumnos_Result> alumnos = new List<_1dataLayer.SP_ListaAlumnos_Result>();
                foreach (_1dataLayer.SP_ListaAlumnos_Result result in mostrarAlumnos)
                {
                    var.id_alumno = result.id_alumno;
                    var.nombre = result.nombre + " ";
                    var.nombre += result.apellido_paterno + " ";
                    var.nombre += result.apellido_materno;
                    var.telefono_contacto = result.telefono_contacto;
                    mostrarAlergias = _1dataLayer.DLConsultaAlumno.ListaAlergias(result.id_alumno);
                    foreach (_1dataLayer.SP_ListaAlergia_Result a in mostrarAlergias)
                    {
                        alergias += ("• " + a.alergia + "\n");
                    }
                    var.alergias = alergias;
                    alergias = "";


                    mostrarDiscapacidades = _1dataLayer.DLConsultaAlumno.ListaDiscapacidad(result.id_alumno);
                    foreach (_1dataLayer.SP_ListaDiscapacidad_Result d in mostrarDiscapacidades)
                    {
                        discapacidades += ("• " + d.discapacidades + "\n");
                    }
                    var.discapacidad = discapacidades;
                    discapacidades = "";
                    student.Add(var);
                    var = new _1dataLayer.alumnoenfermedadDTO();
                }
                return student;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static String alumnosGetAlergias()
        {
            try
            {
              
                String alergias = null;
                _1dataLayer.DLConsultaAlumno listaAlumnos = new _1dataLayer.DLConsultaAlumno();
                List<_1dataLayer.SP_ListaAlumnos_Result> mostrarAlumnos = new List<_1dataLayer.SP_ListaAlumnos_Result>();
                List<_1dataLayer.SP_ListaAlergia_Result> mostrarAlergias = new List<_1dataLayer.SP_ListaAlergia_Result>();
                List<int> ids = new List<int>();

                foreach (_1dataLayer.SP_ListaAlumnos_Result result in mostrarAlumnos)
                {
                    ids.Add(result.id_alumno);
                }

                foreach (int i in ids)
                {
                    //mostrarAlergias = listaAlumnos.ListaAlergias(i);
                    foreach (_1dataLayer.SP_ListaAlergia_Result a in mostrarAlergias)
                    {
                        alergias += (a.alergia + "\n");
                    }
                } 
               
                return alergias;
            }
            catch (Exception)
            {
                throw;
            }


        }

        public static String alumnosGetDiscapacidades(int id_alumno)
        {
            try
            {
                _1dataLayer.DLConsultaAlumno listaAlumnos = new _1dataLayer.DLConsultaAlumno();
                List<_1dataLayer.SP_ListaDiscapacidad_Result> mostrarDiscapacidades = new List<_1dataLayer.SP_ListaDiscapacidad_Result>();
                String discapacidades = null;
                //mostrarDiscapacidades = listaAlumnos.ListaDiscapacidad(id_alumno);
                foreach (_1dataLayer.SP_ListaDiscapacidad_Result d in mostrarDiscapacidades)
                {
                    discapacidades += (d.discapacidades + "\n");
                }
                return discapacidades;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable ConvertToDatatable(List<_1dataLayer.alumnoenfermedadDTO> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id_alumno");
            dt.Columns.Add("nombre");
            dt.Columns.Add("telefono_contacto");
            dt.Columns.Add("alergias");
            dt.Columns.Add("discapacidad");

            foreach (var item in list)
            {
                dt.Rows.Add(item.id_alumno, item.nombre, item.telefono_contacto, item.alergias, item.discapacidad);
            }
            return dt;
        }
    }
}


