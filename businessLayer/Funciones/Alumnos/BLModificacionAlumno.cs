using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer
{
    public class BLModificacionAlumno
    {
        _1dataLayer.DLConsultaAlumno listaAlumnos = new _1dataLayer.DLConsultaAlumno();
        public static void Main(String[] args)
        {/*
            _1dataLayer.DLConsultaAlumno listaAlumnos = new _1dataLayer.DLConsultaAlumno();
            _1dataLayer.SP_FichaTecnicaAlumno_Result alumnobuscado = new _1dataLayer.SP_FichaTecnicaAlumno_Result();
            _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result tutor = new _1dataLayer.SP_FichaTecnicaAlumnoTutor_Result();
            _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result medica = new _1dataLayer.SP_FichaTecnicaAlumnoMedica_Result();
            _1dataLayer.telefono_tutorDTO telito = new _1dataLayer.telefono_tutorDTO();
            List< _1dataLayer.SP_ListaTelefonosTutor_Result> teletuto = new List<_1dataLayer.SP_ListaTelefonosTutor_Result>();
           

            int opc = 1;
            int opa = 1;
            int id_alumno;

            List<_1dataLayer.SP_ListaAlumnos_Result> alumnos = new List<_1dataLayer.SP_ListaAlumnos_Result>();


            do
            {
                alumnos = listaAlumnos.AlumnoLista();
                Console.Clear();
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
                teletuto = _1dataLayer.DLConsultaAlumno.consultartelefonotutor(tutor.id_tutor);
                Console.Clear();
                Console.WriteLine("Seleccione la opcion que desea modificar para el alumno: " + alumnobuscado.nombre + " " + alumnobuscado.apellido_paterno + " " + alumnobuscado.apellido_materno);
                Console.WriteLine("Su tutor siendo: " + tutor.nombre + " " + tutor.apellido_paterno + " " + tutor.apellido_materno);
                Console.WriteLine("Su información medica siendo: " + medica.servicio_medico + " " + medica.grupo_sanguineo + " " + medica.telefono_contacto);
                Console.WriteLine("Modificar infomacion sobre el alumno [1]");
                Console.WriteLine("Modificar informacion sobre el tutor [2]");
                Console.WriteLine("Modificar informacion sobre sus datos medicos [3]");
                Console.WriteLine("Salir [0]");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
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
                        Console.Clear();
                        Console.WriteLine("Selecciona la opcion que desees modificar del tutor: ");
                        Console.WriteLine("1.-Nombre");
                        Console.WriteLine("2.-Apellido paterno");
                        Console.WriteLine("3.-Apellido Materno");
                        Console.WriteLine("4.-Telefono");
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

                            case 4:
                                Console.WriteLine("Seleccione el telefono a modificar");
                                foreach(_1dataLayer.SP_ListaTelefonosTutor_Result papa in teletuto)
                                {
                                    Console.WriteLine(papa.id_telefono+" "+papa.telefono);
                                }

                                int opt = int.Parse(Console.ReadLine());

                                switch (opt)
                                {
                                    case 1:
                                        Console.WriteLine("Ingrese el nuevo telefono personal");
                                        telito.telefono = int.Parse(Console.ReadLine());
                                        telito.id_telefono = opt;
                                        _1dataLayer.DLModificacionAlumno.modificaciontelefono(tutor.id_tutor, telito);
                                        break;

                                    case 2:
                                        Console.WriteLine("Ingrese el nuevo telefono de casa");
                                        telito.telefono = int.Parse(Console.ReadLine());
                                        telito.id_telefono = opt;
                                        _1dataLayer.DLModificacionAlumno.modificaciontelefono(tutor.id_tutor, telito);
                                        break;

                                    case 3:
                                        Console.WriteLine("Ingrese el nuevo telefono de trabajo");
                                        telito.telefono = int.Parse(Console.ReadLine());
                                        telito.id_telefono = opt;
                                        _1dataLayer.DLModificacionAlumno.modificaciontelefono(tutor.id_tutor, telito);
                                        break;
                                }
                                    
                                break;
                        }
                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine("Selecciona la opcion que desees modificar de la tabla medica: ");
                        Console.WriteLine("1.-Tipo de sangre");
                        Console.WriteLine("2.-Telefono de contacto");
                        Console.WriteLine("3.-Servicio medico");
                        opa = int.Parse(Console.ReadLine());
                        switch (opa)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el tipo de sangre:");
                                medica.grupo_sanguineo = Console.ReadLine();
                                _1dataLayer.DLModificacionAlumno.modificacionmedica(medica.id_cartilla_medica, medica);
                                break;

                            case 2:
                                Console.WriteLine("Ingrese el telefono de contacto:");
                                medica.telefono_contacto = Console.ReadLine();
                                _1dataLayer.DLModificacionAlumno.modificacionmedica(medica.id_cartilla_medica, medica);
                                break;

                            case 3:
                                Console.WriteLine("Ingrese el servicio medico:");
                                medica.servicio_medico = Console.ReadLine();
                                _1dataLayer.DLModificacionAlumno.modificacionmedica(medica.id_cartilla_medica, medica);
                                break;
                        }
                        break;
                }
            } while (opc != 0);
        */}

        public static void modificarAlumno(_1dataLayer.SP_FichaTecnicaAlumno_Result alumno)
        {
            _1dataLayer.DLModificacionAlumno.Modificacionalumno(alumno.id_alumno, alumno);
        }

        public static void modificartutor(_1dataLayer.SP_FichaTecnicaAlumnoTutor_Result tutor)
        {
            _1dataLayer.DLModificacionAlumno.ModificacionTutor(tutor.id_tutor, tutor);
        }

        public static void modificartelefonotutor(int idtutor, string telefono,int id_telefono)
        {
            _1dataLayer.DLModificacionAlumno.modificaciontelefono(idtutor, telefono, id_telefono);
        }

        public static void modificarinfomed(_1dataLayer.SP_FichaTecnicaAlumnoMedica_Result medica)
        {
            _1dataLayer.DLModificacionAlumno.modificacionmedica(medica.id_cartilla_medica, medica);
        }


        public static void modificaralergias(List<int> alergiasids, List<int> alergiasvar, int idcartilla)
        {
            List<int> eliminar = new List<int>();
            List<int> nuevas = new List<int>();

            foreach (int id in alergiasids)
            {
                Console.WriteLine(id);
                if (!alergiasvar.Contains(id))
                {
                    nuevas.Add(id);
                }
            }

            foreach (int id in alergiasvar)
            {
                Console.WriteLine(id);
                if (!alergiasids.Contains(id))
                {
                    eliminar.Add(id);
                }
            }

            foreach(int id in nuevas)
            {
                _1dataLayer.DLModificacionAlumno.agregaralergia(idcartilla,id);
                
            }

            foreach (int id in eliminar)
            {
                Console.WriteLine(id + " " + idcartilla);
                _1dataLayer.DLModificacionAlumno.eliminaralergia(idcartilla,id);
            }
        }

        public static void modificarenfermedades(List<int> enfermedadesids, List<int> enfermedadesvar, int idcartilla)
        {
            List<int> eliminar = new List<int>();
            List<int> nuevas = new List<int>();
            
            foreach (int id in enfermedadesids)
            {
                Console.WriteLine("Nuevas: " + id);
                if (!enfermedadesvar.Contains(id))
                {
                    nuevas.Add(id);
                }
            }

            foreach (int id in enfermedadesvar)
            {
                Console.WriteLine("Eliminar: " + id);
                if (!enfermedadesids.Contains(id))
                {
                    eliminar.Add(id);
                }
            }

            foreach (int id in nuevas)
            {
                Console.WriteLine("Nuevas enfermedades " + id);
                _1dataLayer.DLModificacionAlumno.agregarenfermedad(idcartilla, id);

            }

            foreach (int id in eliminar)
            {
                Console.WriteLine("Viejas enfermedades" + id);
                _1dataLayer.DLModificacionAlumno.eliminarenfermedad(idcartilla, id);
            }
        }




        public static void modificardiscapacidades(List<int> discapacidadesids, List<int> discapacidadesvar, int idcartilla)
        {
            List<int> eliminar = new List<int>();
            List<int> nuevas = new List<int>();

            foreach (int id in discapacidadesids)
            {
                Console.WriteLine(id);
                if (!discapacidadesvar.Contains(id))
                {
                    nuevas.Add(id);
                }
            }

            foreach (int id in discapacidadesvar)
            {
                Console.WriteLine(id);
                if (!discapacidadesids.Contains(id))
                {
                    eliminar.Add(id);
                }
            }

            foreach (int id in nuevas)
            {
                _1dataLayer.DLModificacionAlumno.agregardiscapacidad(idcartilla, id);

            }

            foreach (int id in eliminar)
            {
                Console.WriteLine(id + " " + idcartilla);
                _1dataLayer.DLModificacionAlumno.eliminardiscapacidad(idcartilla, id);
            }
        }



        public static void actualizartratamiento(string tratamiento, int cartilla)
        {
            _1dataLayer.DLModificacionAlumno.modificartratamiento(cartilla, tratamiento);
        }
    }



}