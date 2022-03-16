using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class BDDTO
    {
    }

    public class alumnoenfermedadDTO
    {
        public int id_alumno { get; set; }
        public string nombre { get; set; }
        public string telefono_contacto { get; set; }
        public string alergias { get; set; }
        public string discapacidad { get; set; }
    }


    public class alumnoDTO
    {
        public int id_alumno { get; set; }
        public DateTime fecha_registro { get; set; }
        public string ciclo_escolar { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string edad_alumno { get; set; }
        public string CURP_alumno { get; set; }
        public string estado_nacimiento_alumno { get; set; }
        public string ciudad_nacimiento_alumno { get; set; }
        public string colonia_alumno { get; set; }
        public string calle_alumno { get; set; }
        public string numero_alumno { get; set; }
        public string telefono_personal_alumno { get; set; }
        public string escuela_procedencia_alumno { get; set; }
        public string documentacion_alumno { get; set; }
        public string atendido_por { get; set; }
        public byte[] imagen { get; set; }
    }
   
    public class tabla_medicaDTO
    {
        public int id_alumno { get; }
        public int id_cartilla_medica { get; set; }
        public string servicio_medico { get; set; }
        public string grupo_sanguineo { get; set; }
        public string telefono_contacto { get; set; }
        public string genero { get; set; }
        public int peso { get; set; }
        public string color_textura_piel { get; set; }
        public double estatura { get; set; }
    }

    public class enfermedadesDTO
    {
        public int id_cartilla_medica { get; set; }
        public string enfermedad { get; set; }
    }

    public class alergiasDTO
    {
        public int id_cartilla_medica { get; }
        public  string alergia { get; set; }
    }
    public class discapacidadesDTO
    {
        public int id_cartilla_medica { get; }
        public string discapacidades { get; set; }
    }

    public class tutorDTO{
        public int id_tutor { get; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string colonia_tutor { get; set; }
        public string calle_tutor { get; set; }
        public string numero_tutor { get; set; }
        public string ocupacion_tutor { get; set; }
        public string colonia_trabajo_tutor { get; set; }
        public string calle_trabajo_tutor { get; set; }
        public string numero_trabajo_tutor { get; set; }
    }

    public class tutor_alumnoDTO
    {
        public int id_alumno { get; }
        public int id_tutor { get; }
    }

    public class telefono_tutorDTO
    {
        public int id_tutor { get; }
        public int id_telefono { get; }
        public int telefono { get; set; }
    }

    public class identidicadores_telefonosDTO
    {
        public int id_telefono { get; }
        public string tipo_telefono { get; set; }
    }

    public class programaDTO
    {
        public int id_programa { get; }
        public string nombre_programa { get; set; }
        public string tiempo { get; set; }
        public string secuencia { get; set; }
        public string criterios { get; set; }
        public string objetivo { get; set; }
        public string modulos { get; set; }
        public string proyecto { get; set; }
    }

    public class recursosDTO
    {
        public int id_recurso { get; }
        public string recurso { get; set; }
    }

    public class turnosDTO
    {
        public int id_turno { get; }
        public string turno { get; set; }
    }

    public class imagenalumnoDTO
    {
        public int id_alumno { get; set; }
        public byte[] imagen { get; set; }
        public string nombre { get; set; }
    }
}
