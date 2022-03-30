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
            /*Console.WriteLine("Ingrese la enfermedad nueva: ");
            String enf = Console.ReadLine();
            Console.WriteLine("Ingrese la discapacidad nueva: ");
            String disc = Console.ReadLine();
            Console.WriteLine("Ingrese la alergia nueva: ");
            String alerg = Console.ReadLine();
            Console.WriteLine("Ingrese el id del tutor: ");
            int id = int.Parse(Console.ReadLine());*/
            Console.WriteLine("Ingrese el id de la cartilla: ");
            int id_cartilla = int.Parse(Console.ReadLine());

            //_1dataLayer.SP_FichaTecnicaAlumnoTutor_Result tutor = new _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result();
            _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result medica = new _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result();

            //tutor = _1dataLayer.DLConsultaAlumno.FichaTecnicaTutor(id);
            medica = _1dataLayer.DLConsultaAlumno.FichaTecnicaMedica(id_cartilla);

            /*Console.WriteLine("Tutor escogido: " + tutor.nombre+" "+tutor.apellido_paterno + " ID: "+tutor.id_tutor);
            Console.WriteLine("Ingrese el nombre del tutor nuevo: ");

            string nombre = Console.ReadLine();
            tutor.nombre = nombre;*/
            Console.WriteLine("Servicio medico: " + medica.servicio_medico);
            Console.WriteLine("Grupo Sanguineo: " + medica.grupo_sanguineo);
            Console.ReadKey();
            Console.WriteLine("Ingrese el tipo de sangre: ");
            medica.grupo_sanguineo = Console.ReadLine();
            
            Console.ReadKey();
            //_1dataLayer.DLModificacionAlumno.ModificacionTutor(tutor.id_tutor, tutor);
            _1dataLayer.DLModificacionAlumno.modificacionmedica(medica.id_cartilla_medica,medica);
            //tutor = _1dataLayer.DLConsultaAlumno.FichaTecnicaTutor(id);
            medica = _1dataLayer.DLConsultaAlumno.FichaTecnicaMedica(id_cartilla);

            //Console.WriteLine("Nombre del tutor nuevo: " + tutor.nombre);
        }
    }
}
