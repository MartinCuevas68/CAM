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
        static _1dataLayer.SP_FichaTecnicaAlumno_Result alumno = new _1dataLayer.SP_FichaTecnicaAlumno_Result();

        public fichaTecnica(int id_alumno)
        {
            InitializeComponent();

            infoGeneralPanel.Visible = true;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;

            PLfichatecnicaAlumno.centrarLabel(fichaLabel, logo, nombreAlLabel, nombreAl, matriculaLabel, matricula, edadLabel, edad, foto, infoGeneralPanel,infoEscolarPanel, infoTutorPanel, infoMedicaPanel, infoGeneralButton, infoEscolarButton, infoTutorButton, infoMedicaButton,regresarMenuButton,editarInfoButton);
            PLfichatecnicaAlumno.infoAlumno(nombreAlLabel, nombreAl, matriculaLabel, matricula, edadLabel, edad);
            PLfichatecnicaAlumno.infoGeneral(fechaNaLabel, fechaNa, lugarNaLabel, lugarNa, direccionLabel, direccion, curpLabel, curp, telPersonalLabel, telPersonal);
            PLfichatecnicaAlumno.infoEscolar(tipoIngresoLabel, tipoIngreso, escuelaPLabel, escuelaP, canalizadoLabel, canalizado, cicloEscLabel, cicloEsc);

            //Información del alumno
            alumno = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);
            nombreAl.Text = alumno.nombre + " " + alumno.apellido_paterno + " " + alumno.apellido_materno;
            edad.Text = alumno.edad_alumno;
            matricula.Text = id_alumno.ToString();
            fechaNa.Text = alumno.fecha_nacimiento.Day.ToString() + "/" + alumno.fecha_nacimiento.Month.ToString() + "/" + alumno.fecha_nacimiento.Year.ToString();
            lugarNa.Text = alumno.ciudad_nacimiento_alumno + " " + alumno.estado_nacimiento_alumno;
            curp.Text = alumno.CURP_alumno;
            telPersonal.Text = alumno.telefono_personal_alumno;
            direccion.Text = alumno.calle_alumno + " " + alumno.numero_alumno + " " + alumno.colonia_alumno;
            tipoIngreso.Text = alumno.tipo_ingreso;
            cicloEsc.Text = alumno.ciclo_escolar;
            escuelaP.Text = alumno.escuela_procedencia_alumno;
            canalizado.Text = alumno.atendido_por;
            //foto.Image = alumno.

            //Información del tutor

            //Información médica


            //Sentencia que manda a llamar el método para cerrar Consultas usando la X
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        //Metodo para cerrar Consultas usando la X ya que antes se cerraba pero se seguía ejecutando.
        private void cerrarForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoGeneralButton_Click(object sender, EventArgs e)
        {
            infoGeneralPanel.Visible = true;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;
        }

        private void infoEscolarButton_Click(object sender, EventArgs e)
        {
            infoEscolarPanel.Visible = true;
            infoGeneralPanel.Visible = false;            
            infoTutorPanel.Visible = false;
            infoMedicaPanel.Visible = false;
        }

        private void infoTutorButton_Click(object sender, EventArgs e)
        {
            infoTutorPanel.Visible = true;
            infoGeneralPanel.Visible = false;
            infoEscolarPanel.Visible = false;            
            infoMedicaPanel.Visible = false;
        }

        private void infoMedicaButton_Click(object sender, EventArgs e)
        {
            infoMedicaPanel.Visible = true;
            infoGeneralPanel.Visible = false;
            infoEscolarPanel.Visible = false;
            infoTutorPanel.Visible = false;            
        }

        private void regresarMenuButton_Click(object sender, EventArgs e)
        {
            ConsultaAlumno consultas = new ConsultaAlumno();
            consultas.Show();
            this.Hide();
        }
    }
}
