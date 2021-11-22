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


    public class alumnoDTO
    {
        public int id_alumno { get; set;  }

        public DateTime fecha_registo { get; set; }
        public string ciclo_escolar { get; set; }
        public string nombre { get; set; }
        public string apellido_mat { get; set; }
        public string apellido_pat { get; set; }

        public DateTime fecha_nacimiento { get; set; }
        public string edad_alumno { get; set; }
        public string estado_nacimiento_alumno { get; set; }
        public string ciudad_nacimiento_alumno { get; set; }
        public string colonia_alumno { get; set; }
        public string calle_alumno { get; set; }
        public string numero_alumno { get; set; }
        public string telefono_personal_alumno { get; set; }
        public string discapacidad { get; set; }
        public string escuela_procedencia_alumno { get; set; }

        public string documentacion_alumno { get; set; }

        public string atendido_por { get; set; }
    }
   



    public class info_medica
    {
        public int id_alumno { get; }
        public int id_cartilla_medica { get; set; }
        public string servicio_medico { get; set; }
        public string grupo_sanguineo { get; set; }
        public string telefono_contacto { get; set; }

    }
    public class enfermedadesDTO
    {
        public int id_cartilla_medica { get; }
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
        public string discapacidad { get; set; }
    }

}
