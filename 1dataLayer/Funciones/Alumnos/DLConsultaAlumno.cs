using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class DLConsultaAlumno
    {


        //Todo lo comentado son pruebas y demostracion de como revisar y obtener los datos

        static void Main(string[] args)
        {
            /* 


             ConsultaAlumno awa= new ConsultaAlumno();
             List<SP_FichaTecnicaAlumno_Result> mostrar = new List<SP_FichaTecnicaAlumno_Result>();

           mostrar=  awa.FichaTenicaAlumno(1);
             foreach(SP_FichaTecnicaAlumno_Result result in mostrar)
             {
                 Console.WriteLine("" + result.nombre + "\n" + result.apellido_paterno + "\n" + result.apellido_materno);
             }
             Console.ReadKey();
                  List<SP_ListaAlumnos_Result> mostrar = new List<SP_ListaAlumnos_Result>();
                  mostrar = awa.AlumnoLista();
                  foreach (SP_ListaAlumnos_Result result in mostrar)
                  {
                      Console.WriteLine("nombres: " + result.nombre);
                  }

                  List<SP_ListaAlergia_Result> mostrar2 = new List<SP_ListaAlergia_Result>();
                    mostrar2  = awa.ListaAlergias(2);
                  foreach (SP_ListaAlergia_Result result in mostrar2)
                  {
                      Console.WriteLine("alergia: " + result.alergia);
                      Console.WriteLine("id: " + result.id_cartilla_medica);
                  }
                  List<SP_ListaDiscapacidad_Result> mostrar3 = awa.ListaDiscapacidad(2);
                  foreach (SP_ListaDiscapacidad_Result result in mostrar3)
                  {
                      Console.WriteLine("discapacidad: " + result.discapacidades);
                      Console.WriteLine("id: " + result.id_cartilla_medica);
                  }
                  List<SP_ListaEnfermedad_Result> mostrar4 = awa.ListaEnfermedades(2);
                  foreach (SP_ListaEnfermedad_Result result in mostrar4)
                  {
                      Console.WriteLine("enfermedad: " + result.enfermedad);
                      Console.WriteLine("id: " + result.id_cartilla_medica);
                  }

                  Console.ReadKey();
              */
        }
        //regresa el listado de todos los alumnos del cam
        public List<SP_ListaAlumnos_Result> AlumnoLista()
        {
            List<SP_ListaAlumnos_Result> alumnos = new List<SP_ListaAlumnos_Result>();

            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_ListaAlumnos_Result> y = db.SP_ListaAlumnos();
                foreach (SP_ListaAlumnos_Result result in y)
                {
                    alumnos.Add(result);


                }
            }

            return alumnos;
        }

        public List<SP_Lista_Egresados_Result> EgresadoLista()
        {
            List<SP_Lista_Egresados_Result> alumnos = new List<SP_Lista_Egresados_Result>();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_Lista_Egresados_Result> y = db.SP_Lista_Egresados();
                foreach (SP_Lista_Egresados_Result result in y)
                {
                    alumnos.Add(result);


                }
            }

            return alumnos;
        }
        //regresa la ficha tecnica de 1 solo alumno 
        public static SP_FichaTecnicaAlumno_Result FichaTenicaAlumno(int id)
        {
            SP_FichaTecnicaAlumno_Result FichaTecnicaAlumno = new SP_FichaTecnicaAlumno_Result();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_FichaTecnicaAlumno_Result> x = db.SP_FichaTecnicaAlumno(id);
                foreach (SP_FichaTecnicaAlumno_Result result in x)
                    FichaTecnicaAlumno = result;
            }
            return FichaTecnicaAlumno;
        }

        //regresa la ficha tecnica del tutor de 1 alumno
        public static SP_FichaTecnicaAlumnoTutor_Result FichaTecnicaTutor(int id)
        {
            SP_FichaTecnicaAlumnoTutor_Result FTtutor = new SP_FichaTecnicaAlumnoTutor_Result();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_FichaTecnicaAlumnoTutor_Result> x = db.SP_FichaTecnicaAlumnoTutor(id);
                foreach (SP_FichaTecnicaAlumnoTutor_Result result in x)
                    FTtutor = result;
            }

            return FTtutor;
        }
        //regresa la ficha tecnica medica de 1 solo alumno
        public static SP_FichaTecnicaAlumnoMedica_Result FichaTecnicaMedica(int id)
        {
            SP_FichaTecnicaAlumnoMedica_Result FTMedica = new SP_FichaTecnicaAlumnoMedica_Result();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_FichaTecnicaAlumnoMedica_Result> x = db.SP_FichaTecnicaAlumnoMedica(id);
                foreach (SP_FichaTecnicaAlumnoMedica_Result result in x)
                    FTMedica = result;
            }
            return FTMedica;
        }
        //regresa la lista de todas las alergias que 1 alumno tiene
        public static List<SP_ListaAlergia_Result> ListaAlergias(int id)
        {
            List<SP_ListaAlergia_Result> alergias = new List<SP_ListaAlergia_Result>();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_ListaAlergia_Result> x = db.SP_ListaAlergia(id);
                foreach (SP_ListaAlergia_Result result in x)
                {

                    alergias.Add(result);

                }
            }

            return alergias;
        }
        //regresa la lista de todas las enfermedades que 1 alumno tiene

        public static List<SP_ListaEnfermedad_Result> ListaEnfermedades(int id)
        {
            List<SP_ListaEnfermedad_Result> enfermedades = new List<SP_ListaEnfermedad_Result>();

            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_ListaEnfermedad_Result> x = db.SP_ListaEnfermedad(id);
                foreach (SP_ListaEnfermedad_Result result in x)
                {

                    enfermedades.Add(result);
                }

            }

            return enfermedades;
        }
        //regresa la lista de todas las discapacidades que 1 alumno tiene

        public static List<SP_ListaDiscapacidad_Result> ListaDiscapacidad(int id)
        {
            List<SP_ListaDiscapacidad_Result> discapacidades = new List<SP_ListaDiscapacidad_Result>();

            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_ListaDiscapacidad_Result> x = db.SP_ListaDiscapacidad(id);
                foreach (SP_ListaDiscapacidad_Result result in x)
                {
                    discapacidades.Add(result);
                }

            }

            return discapacidades;
        }
        public static List<SP_ListaTratamiento_Result> ListaTratamiento(int id)
        {
            List<SP_ListaTratamiento_Result> tratamientos = new List<SP_ListaTratamiento_Result>();

            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_ListaTratamiento_Result> x = db.SP_ListaTratamiento(id);
                foreach (SP_ListaTratamiento_Result result in x)
                {
                    tratamientos.Add(result);
                }

            }

            return tratamientos;
        }
        //supuesto metodo para obtener la foto no se ha probado
        /*public SP_MostrarFotoAlumno_Result Foto_alumno(int id)
        {
            SP_MostrarFotoAlumno_Result foto = new SP_MostrarFotoAlumno_Result();
            using (BDCAMEntities db = new BDCAMEntities())
            {

                ObjectResult<SP_MostrarFotoAlumno_Result> x = db.SP_MostrarFotoAlumno(id);
        
                foreach(SP_MostrarFotoAlumno_Result result in x)
                {
                    foto = result;
                }
            }
            return foto;
        }*/



        public static foto_alumno ConsultaFoto(int id)
        {
            foto_alumno foto = new foto_alumno();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_consulta_foto_alumno_Result> x = db.SP_consulta_foto_alumno(id);
                foreach (SP_consulta_foto_alumno_Result result in x)
                {
                    foto.id_alumno = id;
                    foto.imagen_alumno = result.imagen_alumno;
                    foto.nombre = result.nombre;
                }
            }
            return foto;
        }


        public static List<SP_ListaTelefonosTutor_Result> consultartelefonotutor(int id)
        {
            List<SP_ListaTelefonosTutor_Result> telefonos = new List<SP_ListaTelefonosTutor_Result>();
            using (BDCAMEntities db = new BDCAMEntities())
            {
                ObjectResult<SP_ListaTelefonosTutor_Result> x = db.SP_ListaTelefonosTutor(id);
                foreach (SP_ListaTelefonosTutor_Result result in x)
                {
                    telefonos.Add(result);
                }
            }
            return telefonos;
        }


    }
}


