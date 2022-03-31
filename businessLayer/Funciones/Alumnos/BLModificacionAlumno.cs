using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer
{
    class BLModificacionAlumno
    {
        _1dataLayer.DLConsultaAlumno listaAlumnos = new _1dataLayer.DLConsultaAlumno();
        public static void Main(String[] args)
        {
            _1dataLayer.DLConsultaAlumno listaAlumnos = new _1dataLayer.DLConsultaAlumno();
            _1dataLayer.SP_FichaTecnicaAlumno_Result alumnobuscado = new _1dataLayer.SP_FichaTecnicaAlumno_Result();
            _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result tutor = new _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result();
            _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result medica = new _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result();



            int opc = 1;
            int opa = 1;
            int id_alumno;

            List<_1dataLayer.SP_ListaAlumnos_Result> alumnos = new List<_1dataLayer.SP_ListaAlumnos_Result>();


            do
            {
                alumnos = listaAlumnos.AlumnoLista();
                Console.WriteLine("Menu de modificaciones ");
                foreach (_1dataLayer.SP_ListaAlumnos_Result alu in alumnos)
                {
                    Console.WriteLine(alu.id_alumno + " " + alu.nombre);
                }
                Console.WriteLine("Escoga al alumno a modificar: ");
                id_alumno = int.Parse(Console.ReadLine());

                alumnobuscado = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);
                tutor = _1dataLayer.DLConsultaAlumno.FichaTecnicaTutor(id_alumno);
                medica = _1dataLayer.DLConsultaAlumno.FichaTecnicaMedica(id_alumno);

                Console.WriteLine("Seleccione la opcion que desea modificar para el alumno: " + alumnobuscado.nombre + " " + alumnobuscado.apellido_paterno + " " + alumnobuscado.apellido_materno);
                Console.WriteLine("Su tutor siendo: " + tutor.nombre + " " + tutor.apellido_paterno + " " + tutor.apellido_materno);
                Console.WriteLine("Modificar infomacion sobre el alumno [1]");
                Console.WriteLine("Modificar informacion sobre el tutor [2]");
                //Console.WriteLine("Modificar informacion sobre sus datos medicos [3]");
                Console.WriteLine("Salir [0]");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:

                        Console.WriteLine("Selecciona la opcion que desees modificar del alumno: ");
                        Console.WriteLine("1.-Nombre del alumno");
                        Console.WriteLine("2.-Apellido paterno");
                        Console.WriteLine("3.-Apellido Materno");
                        opa = int.Parse(Console.ReadLine());
                        switch (opa)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el nombre del alumno: ");
                                alumnobuscado.nombre = Console.ReadLine();
                                _1dataLayer.DLModificacionAlumno.Modificacionalumno(id_alumno, alumnobuscado);
                                break;

                            case 2:
                                Console.WriteLine("Ingrese el apellido paterno del alumno: ");
                                alumnobuscado.apellido_paterno = Console.ReadLine();
                                _1dataLayer.DLModificacionAlumno.Modificacionalumno(id_alumno, alumnobuscado);
                                break;

                            case 3:
                                Console.WriteLine("Ingrese el apellido materno del alumno: ");
                                alumnobuscado.apellido_materno = Console.ReadLine();
                                _1dataLayer.DLModificacionAlumno.Modificacionalumno(id_alumno, alumnobuscado);
                                break;
                        }

                        break;


                    case 2:

                        Console.WriteLine("Selecciona la opcion que desees modificar del tutor: ");
                        Console.WriteLine("1.-Nombre");
                        Console.WriteLine("2.-Apellido paterno");
                        Console.WriteLine("3.-Apellido Materno");
                        opa = int.Parse(Console.ReadLine());
                        switch (opa)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el nombre del tutor: ");
                                tutor.nombre = Console.ReadLine();
                                _1dataLayer.DLModificacionAlumno.ModificacionTutor(tutor.id_tutor, tutor);
                                break;

                            case 2:
                                Console.WriteLine("Ingrese el apellido paterno del tutor: ");
                                tutor.apellido_paterno = Console.ReadLine();
                                _1dataLayer.DLModificacionAlumno.ModificacionTutor(tutor.id_tutor, tutor);
                                break;

                            case 3:
                                Console.WriteLine("Ingrese el apellido materno del alumno: ");
                                tutor.apellido_materno = Console.ReadLine();
                                _1dataLayer.DLModificacionAlumno.ModificacionTutor(tutor.id_tutor, tutor);
                                break;
                        }

                        break;

                }

            } while (opc != 0);
        }
    }
}
