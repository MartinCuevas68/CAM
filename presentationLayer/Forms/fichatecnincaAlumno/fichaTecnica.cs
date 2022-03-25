using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public partial class fichaTecnica : Form
    {
        int id;
        _1dataLayer.alumnoDTO alumnito = new _1dataLayer.alumnoDTO();
        _1dataLayer.SP_FichaTecnicaAlumno_Result3 alumno = new _1dataLayer.SP_FichaTecnicaAlumno_Result3();
        public fichaTecnica(int id_alumno)
        {
            InitializeComponent();
            PLfichatecnicaAlumno.posicionLabel(logoPictureBox, fichaLabel, infogenLabel, nombreLabel, nombre_text, edadLabel, edadqueryLabel, fechanacLabel, fechaqueryLabel,
                                    lugarnacLabel, lugarqueryLabel, curpLabel, curpqueryLabel, direccionLabel, direccionqueryLabel,
                                telefonoLabel, telefonoqueryLabel, escuelaLabel, escuelaproqueryLabel, canalizadoLabel, canalizadoqueryLabel, cicloLabel, cicloqueryLabel, tipoingresoLabel, tipoingresoqueryLabel);

            PLfichatecnicaAlumno.posicionFotoButtons(fotoalumnoPictureBox, informaciontutorButton, informacionmedicaButton);
            alumno = _1dataLayer.DLConsultaAlumno.FichaTecnicaAlumno(id_alumno);
            id = id_alumno;
            alumnito.ciclo_escolar = alumno.ciclo_escolar;
            alumnito.nombre = alumno.nombre;
            alumnito.apellido_paterno = alumno.apellido_paterno;
            alumnito.apellido_materno = alumno.apellido_materno;
            alumnito.fecha_nacimiento = alumno.fecha_nacimiento;
            alumnito.edad_alumno = alumno.edad_alumno;
            alumnito.CURP_alumno = alumno.CURP_alumno;
            alumnito.estado_nacimiento_alumno = alumno.estado_nacimiento_alumno;
            alumnito.ciudad_nacimiento_alumno = alumno.ciudad_nacimiento_alumno;
            alumnito.colonia_alumno = alumno.colonia_alumno;
            alumnito.calle_alumno = alumno.calle_alumno;
            alumnito.numero_alumno = alumno.numero_alumno;
            alumnito.telefono_personal_alumno = alumno.telefono_personal_alumno;
            alumnito.escuela_procedencia_alumno = alumno.escuela_procedencia_alumno;
            alumnito.documentacion_alumno = "";
            alumnito.atendido_por = alumno.atendido_por;
            nombre_text.Text = alumno.nombre;
        }

        

        private void informacionmedicaButton_Click(object sender, EventArgs e)
        {

        }

        private void informaciontutorButton_Click(object sender, EventArgs e)
        {

        }

        private void fichaTecnica_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            alumnito.nombre = nombre_text.Text;
            alumnito.telefono_personal_alumno = "6681022989";
            _1dataLayer.DLModificacionAlumno.Modificacionalumno(id, alumnito);
            ConsultaAlumno consulta = new ConsultaAlumno();
            consulta.Show();
            this.Hide();
        }
    }
}
