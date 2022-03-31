using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace businessLayer
{
    public class BLFichaTecnica
    {

        public static void infoGenAlumno(TextBox alumnoAl, int id_alumno)
        {

            _1dataLayer.SP_FichaTecnicaAlumno_Result alumno = new _1dataLayer.SP_FichaTecnicaAlumno_Result();

            alumno = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);

            alumnoAl.Text = alumno.nombre;




        }
    }
}
