using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class ConsultaAlumno
    {
        
       //Todo lo comentado son pruebas y demostracion de como revisar y obtener los datos

        static void Main(string[] args) {
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
        public List<SP_FichaTecnicaAlumno_Result> FichaTenicaAlumno(int id)
        {
            List<SP_FichaTecnicaAlumno_Result> FichaTecnicaAlumno = new List<SP_FichaTecnicaAlumno_Result>();
            using(BDCAMEntities db= new BDCAMEntities())
            {
                ObjectResult<SP_FichaTecnicaAlumno_Result> x = db.SP_FichaTecnicaAlumno(id);
                foreach (SP_FichaTecnicaAlumno_Result result in x)
                    FichaTecnicaAlumno.Add(result);
            }
            return FichaTecnicaAlumno;
        }
        public List<SP_ListaAlergia_Result> ListaAlergias(int id)
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
        public List<SP_ListaEnfermedad_Result> ListaEnfermedades(int id)
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
        public List<SP_ListaDiscapacidad_Result> ListaDiscapacidad(int id)
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

    }
}
