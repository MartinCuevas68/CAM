using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class alumnoDTOprueba
    {
        public int idPrueba { get; set; }
        public string nombre { get; set; } 
        public string edad { get; set; }

    }

    public class maestroDTOprueba
    {
        public int idPrueba { get; set; }
        public string nombre { get; set; }
        public string edad { get; set; }

    }
    public class alumno
    {
        int id_alumno { get; }

        DateTime fecha_registo { get; set; }
        string ciclo_escolar { get; set; }
        string nombre { get; set; }
        string apellido_mat { get; set; }
        string apellido_pat { get; set; }

        DateTime fecha_nacimiento { get; set; }
        string edad_alumno { get; set; }
        string estado_nacimiento_alumno { get; set; }
        string ciudad_nacimiento_alumno { get; set; }
        string colonia_alumno { get; set; }
        string calle_alumno { get; set; }
        string numero_alumno { get; set; }
        string telefono_personal_alumno { get; set; }
        string discapacidad { get; set; }
        string escuela_procedencia_alumno { get; set; }

        string documentacion_alumno { get; set; }

        string atendido_por { get; set; }
    }




    public class info_medica
    {
        int id_alumno { get; }
        int id_cartilla_medica { get; set; }
        string servicio_medico { get; set; }
        string grupo_sanguineo { get; set; }
        string telefono_contacto { get; set; }

    }
    public class enfermedades
    {
        int id_cartilla_medica { get; }
        string enfermedad { get; set; }
    }
    public class alergias
    {
        int id_cartilla_medica { get; }
        string alergia { get; set; }
    }
    public class discapacidades
    {
        int id_cartilla_medica { get; }
        string discapacidad { get; set; }
    }
    public class tutor
    {
        int id_tutor { get; }
        string Nombre { get; set; }
        string Apellido_paterno { get; set; }
        string Apellido_materno { get; set; }
        string colonia_tutor { get; set; }
        string calle_tutor { get; set; }
        string numero_tutor { get; set; }
        string ocupacion_tutor { get; set; }
        string colonia_trabajo_tutor { get; set; }
        string calle_trabajo_tutor { get; set; }
        string numero_trabajo_tutor { get; set; }
    }

    public class tutor_alumno
    {
        int id_alumno { get; }
        int id_tutor { get; }
    }

    public class telefono_tutor
    {
        int id_tutor { get; }
        int id_telefono { get; }
        int telefono { get; set; }
    }

    public class identidicadores_telefonos
    {
        int id_telefono { get; }
        string tipo_telefono { get; set; }
    }
}
