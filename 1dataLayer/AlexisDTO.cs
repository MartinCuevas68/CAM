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
    public class madre_hijo
    {
        int id_alumno { get; }
        int id_madre { get; }
    }
    public class madre
    {
        int id_madre { get; }
        string Nombre { get; set; }
        string apellido_mat { get; set; }
        string apellido_pat { get; set; }
        string colonia_madre { get; set; }
        string calle_madre { get; set; }
        string numero_madre { get; set; }
        string ocupacion_madre { get; set; }
        string colonia_trabajo_madre { get; set; }
        string calle_trabajo_madre { get; set; }
        string numero_trabajo_madre { get; set; }

    }
    public class telefono_madre
    {
        int id_madre { get; }

        int id_telefono { get; }
        string telefono { get; set; }
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

}
