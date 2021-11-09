using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    public class AlexisDTO
    {
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

}
