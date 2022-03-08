﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    class AltaAlumno
    {
        //Metodo para dar de alta alergias
        public void Altaalergias(alergiasDTO alergia)
        {
            using(BDCAMEntities1 db = new BDCAMEntities1())
            {
                db.sp_altaalergias(alergia.id_cartilla_medica, alergia.alergia);
            }
        }

        public void Altaenfermedades(enfermedadesDTO enfermedad)
        {
            using(BDCAMEntities1 db = new BDCAMEntities1())
            {
                db.sp_altaenfermedades(enfermedad.id_cartilla_medica, enfermedad.enfermedad);
            }
        }

        public void Altadiscapacidades(discapacidadesDTO discapacidad)
        {
            using(BDCAMEntities1 db = new BDCAMEntities1())
            {
                db.sp_altadiscapacidades(discapacidad.id_cartilla_medica, discapacidad.discapacidades);
            }
        }
        public int Altaalumno(alumnoDTO alumno)
        {
            ObjectResult<decimal?> e;
            int id = 0;
            using(BDCAMEntities1 db = new BDCAMEntities1())
            {
               db.SP_AltaAlumno(alumno.fecha_registro,alumno.ciclo_escolar, alumno.nombre, alumno.apellido_paterno,alumno.apellido_materno,alumno.fecha_nacimiento,alumno.edad_alumno,alumno.CURP_alumno,alumno.estado_nacimiento_alumno, alumno.ciudad_nacimiento_alumno,alumno.colonia_alumno,alumno.calle_alumno,alumno.numero_alumno,alumno.telefono_personal_alumno,alumno.escuela_procedencia_alumno,alumno.documentacion_alumno,alumno.atendido_por);
               e = db.sp_regresarid();
            foreach(decimal? a in e)
                {
                    id = Convert.ToInt32(a);
                }
            }
            return id;
        }

        public void Altaalumnocartilla(int idalumno, int idcartilla)
        {
            using(BDCAMEntities1 db = new BDCAMEntities1())
            {
                db.sp_altaalumnocartilla(idalumno, idcartilla);
            }
        }

        public int Altatutor(tutorDTO tutor)
        {
            ObjectResult<decimal?> e;
            int id = 0;
            using(BDCAMEntities1 db = new BDCAMEntities1())
            {
                db.sp_altatutor(tutor.nombre, tutor.apellido_paterno, tutor.apellido_materno, tutor.colonia_tutor, tutor.calle_tutor, tutor.numero_tutor, tutor.ocupacion_tutor, tutor.colonia_trabajo_tutor, tutor.calle_trabajo_tutor, tutor.numero_trabajo_tutor);
                e = db.sp_regresaridtutor();
                foreach (decimal? a in e)
                {
                    id = Convert.ToInt32(a);
                }
            }
            return id;
        }

        public int Altacartilla(tabla_medicaDTO tabla)
        {
            ObjectResult<decimal?> e;
            int id = 0;

            using (BDCAMEntities1 db = new BDCAMEntities1()) {
                db.sp_altacartilla(tabla.servicio_medico, tabla.grupo_sanguineo, tabla.telefono_contacto, tabla.peso, tabla.genero, tabla.color_textura_piel, tabla.estatura);
                e = db.sp_regresaridcartilla();
            foreach (decimal? a in e)
                {
                    id = Convert.ToInt32(a);
                }
            }
            return id;
        }

        public void Altatelefonotutor(telefono_tutorDTO telefono)
        {
           using(BDCAMEntities1 db = new BDCAMEntities1())
            {
                db.sp_telefonotutores(telefono.id_tutor, telefono.id_telefono, telefono.telefono);
            }
        }


        public void Altaalumnotutor(int idalumno,int idtutor)
        {
            using(BDCAMEntities1 db = new BDCAMEntities1())
            {
                db.sp_tutoralumno(idalumno, idtutor);
            }
        }

      
    }
}
