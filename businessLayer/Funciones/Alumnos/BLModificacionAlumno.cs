using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer
{
    class BLModificacionAlumno
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Ingrese la enfermedad nueva: ");
            String enf = Console.ReadLine();
            Console.WriteLine("Ingrese la discapacidad nueva: ");
            String disc = Console.ReadLine();
            Console.WriteLine("Ingrese la alergia nueva: ");
            String alerg = Console.ReadLine();
            Console.WriteLine("Ingrese el id del tutor: ");
            int id = int.Parse(Console.ReadLine());
            _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result tutor = new _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result(); 
            tutor = _1dataLayer.DLConsultaAlumno.FichaTecnicaTutor(id);
            Console.WriteLine("Tutor escogido: " + tutor.nombre+" "+tutor.apellido_paterno + " ID: "+tutor.id_tutor);
            Console.WriteLine("Ingrese el nombre del tutor nuevo: ");
            string nombre = Console.ReadLine();
            Console.ReadKey();
            enf.Trim();
            disc.Trim();
            alerg.Trim();
            _1dataLayer.DLModificacionAlumno.ModificacionTutor(tutor.id_tutor, tutor);
            tutor = _1dataLayer.DLConsultaAlumno.FichaTecnicaTutor(id);
            Console.WriteLine("Nombre del tutor nuevo: " + tutor.nombre);
            Console.ReadKey();

        }
    }
}
