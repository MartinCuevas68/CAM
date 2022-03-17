using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace businessLayer
{
    public class BLAltaAlumno
    {
        //Altas

        //Altas alumno

        public static void SetAlumno(string cicloEsc, string nombreAl, string apellidoP, string apellidoM,
            DateTime fechaNa, string añosCum, string curp, string estado, string ciudad, string colonia,
            string calle, string numeroCasa, string telPersonal, string escuelaP, string canalizado)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;

            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.alumno>();
                    query.Add(new _1dataLayer.alumno
                    {
                        id_alumno = y++,
                        fecha_registro = DateTime.Now,
                        ciclo_escolar = cicloEsc,
                        nombre = nombreAl,
                        apellido_paterno = apellidoP,
                        apellido_materno = apellidoM,
                        fecha_nacimiento = fechaNa.Date,
                        edad_alumno = añosCum,
                        CURP_alumno = curp,
                        estado_nacimiento_alumno = estado,
                        ciudad_nacimiento_alumno = ciudad,
                        colonia_alumno = colonia,
                        calle_alumno = calle,
                        numero_alumno = numeroCasa,
                        telefono_personal_alumno = telPersonal,
                        escuela_procedencia_alumno = escuelaP,
                        //documentacion_alumno = documentacion_alumno,
                        atendido_por = canalizado
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas tutor
        public static void SetTutor(string nombreT, string apellidoPT, string apellidoMT, string coloniaT, string calleT, string numeroCasaT,
            string ocupacion, string colonia_trabajo_tutor, string calle_trabajo_tutor, string numero_trabajo_tutor)
            //, string telCasaT, string telMovilT, string telTrabajoT
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.tutor>();
                    query.Add(new _1dataLayer.tutor
                    {
                        id_tutor = y++,
                        nombre = nombreT,
                        apellido_paterno = apellidoPT,
                        apellido_materno = apellidoMT,
                        colonia_tutor = coloniaT,
                        calle_tutor = calleT,
                        numero_tutor = numeroCasaT,
                        ocupacion_tutor = ocupacion,
                        colonia_trabajo_tutor = colonia_trabajo_tutor,
                        calle_trabajo_tutor = calle_trabajo_tutor,
                        numero_trabajo_tutor = numero_trabajo_tutor,
                        //telCasaT = telCasaT,
                        //telMovilT = telMovilT,
                        //telTrabajoT = telTrabajoT

                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas telefono tutor
        /*public static void SetTelefonoTutor(telCasa, telMovil, telTrabajo)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.telefono_tutores>();
                    query.Add(new _1dataLayer.telefono_tutores
                    {
                        telCsa =
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/


        //Altas información médica del alumno
        public static void SetInfoMedAlumno(string servMedico, string grupoSanguineo, string telefono, string peso, string color_textura_piel, string estatura)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.tabla_medica>();
                    query.Add(new _1dataLayer.tabla_medica
                    {
                        id_cartilla_medica = y++,
                        servicio_medico = servMedico,
                        grupo_sanguineo = grupoSanguineo,
                        telefono_contacto = telefono,
                        //genero = genero,
                        peso = peso,
                        color_textura_piel = color_textura_piel,
                        estatura = estatura
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Altas Discapacidad
        /*public static void SetDiscapacidades(string discapacidad)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.discapacidades>();
                    query.Add(new _1dataLayer.discapacidades
                    {
                        id_cartilla_medica = y++,
                        discapacidades1 = discapacidad
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/

        //Altas Enfermedad
        /*public static void SetEnfermedades(string enfermedades)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.enfermedade>();
                    query.Add(new _1dataLayer.enfermedade
                    {
                        id_cartilla_medica = y++,
                        enfermedad = enfermedades
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/

        //Altas Alergias
        /*public static void SetAlergias(string alergias)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.alergias>();
                    query.Add(new _1dataLayer.alergias
                    {
                        id_cartilla_medica = y++,
                        alergia = alergias
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/

        //Altas Tratamiento
        /*public static void SetTratamiento(string tratamiento)
        {
            byte[] x = { (byte)204, 29, (byte)207, (byte)217 };
            int y = 1;



            try
            {
                using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())

                {
                    var query = db.Set<_1dataLayer.tratamientos>();
                    query.Add(new _1dataLayer.tratamientos
                    {
                        id_cartilla_medica = y++,
                        tratamiento = tratamiento
                    });

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/

    }


}