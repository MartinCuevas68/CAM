using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            PLfichatecnicaAlumno.posicionLabel(logoPictureBox , fichaLabel, nombreLabel, nombretxtBox, matriculaLabel,
                matriculaTxtBox, edadLabel, edadtextBox, tipoingresoLabel, tipoingresotxtBox, fotopictureBox, informaciontutorPanel,
                generalButton, escolarButton, TutorButton, medicaButton, nombretutorLabel, nombretutortextBox, direccionLabel,
                direcciontextBox, ocupacionLabel, ocupaciontextBox, telefonosLabel, casaLabel, movilLabel, trabajoLabel,
                casatextBox, moviltextBox, trabajotextBox, regresarButton, editarButton, subirfotoButton,servicioLabel,
                telefonoLabel,grupoLabel, serviciotextBox,telefonotextBox,grupotextBox, discapacidadesLabel, enfermedadesLabel,
                tratamientosLabel,alergiasLabel,discapacidadesrichTextBox,enfermedadesrichTextBox,alergiasrichTextBox,tratamientosrichTextBox);
            
            nombretutorLabel.Visible = false;
            nombretutortextBox.Visible = false;
            direccionLabel.Visible = false;
            direcciontextBox.Visible = false;
            ocupacionLabel.Visible = false;
            ocupaciontextBox.Visible = false;
            telefonosLabel.Visible = false;
            casaLabel.Visible = false;
            movilLabel.Visible = false;
            trabajoLabel.Visible = false;
            casatextBox.Visible = false;
            moviltextBox.Visible = false;
            trabajotextBox.Visible = false;
            servicioLabel.Visible = false;
            serviciotextBox.Visible = false;
            telefonoLabel.Visible = false;
            telefonotextBox.Visible = false;
            grupoLabel.Visible = false;
            grupotextBox.Visible = false;
            discapacidadesLabel.Visible = false;
            discapacidadesrichTextBox.Visible = false;
            enfermedadesLabel.Visible = false;
            enfermedadesrichTextBox.Visible = false;
            alergiasLabel.Visible = false;
            alergiasrichTextBox.Visible = false;
            tratamientosLabel.Visible = false;
            tratamientosrichTextBox.Visible = false;

            //Información del alumno
            //alumno = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);
            //nombreAl.Text = alumno.nombre + " " + alumno.apellido_paterno + " " + alumno.apellido_materno;
            //edad.Text = alumno.edad_alumno;
            //matricula.Text = id_alumno.ToString();
            //fechaNa.Text = alumno.fecha_nacimiento.Day.ToString() + "/" + alumno.fecha_nacimiento.Month.ToString() + "/" + alumno.fecha_nacimiento.Year.ToString();
            //lugarNa.Text = alumno.ciudad_nacimiento_alumno + " " + alumno.estado_nacimiento_alumno;
            //curp.Text = alumno.CURP_alumno;
            //telPersonal.Text = alumno.telefono_personal_alumno;
            //direccion.Text = alumno.calle_alumno + " " + alumno.numero_alumno + " " + alumno.colonia_alumno;
            //tipoIngreso.Text = alumno.tipo_ingreso;
            //cicloEsc.Text = alumno.ciclo_escolar;
            //escuelaP.Text = alumno.escuela_procedencia_alumno;
            //canalizado.Text = alumno.atendido_por;
            //foto.Image = alumno.

            //Información del tutor

            //Información médica


            //Sentencia que manda a llamar el método para cerrar Consultas usando la X
            this.FormClosed += new FormClosedEventHandler(cerrarForm);


            //foto = _1dataLayer.DLConsultaAlumno.ConsultaFoto(id);
            //MessageBox.Show(foto.nombre);
            // fotopictureBox.Image = byteArrayToImage(foto.imagen_alumno.ToArray());
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void informacionmedicaButton_Click(object sender, EventArgs e)
        {

        }

        //Metodo para cerrar Consultas usando la X ya que antes se cerraba pero se seguía ejecutando.
        private void cerrarForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoGeneralButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSystem1_Click(object sender, EventArgs e)
        {

        }

        private void medicaButton_Click(object sender, EventArgs e)
        {
            nombretutorLabel.Visible = false;
            nombretutortextBox.Visible = false;
            direccionLabel.Visible = false;
            direcciontextBox.Visible = false;
            ocupacionLabel.Visible = false;
            ocupaciontextBox.Visible = false;
            telefonosLabel.Visible = false;
            casaLabel.Visible = false;
            movilLabel.Visible = false;
            trabajoLabel.Visible = false;
            casatextBox.Visible = false;
            moviltextBox.Visible = false;
            trabajotextBox.Visible = false;
            servicioLabel.Visible = true;
            serviciotextBox.Visible = true;
            telefonoLabel.Visible = true;
            telefonotextBox.Visible = true;
            grupoLabel.Visible = true;
            grupotextBox.Visible = true;
            discapacidadesLabel.Visible = true;
            discapacidadesrichTextBox.Visible = true;
            enfermedadesLabel.Visible = true;
            enfermedadesrichTextBox.Visible = true;
            alergiasLabel.Visible = true;
            alergiasrichTextBox.Visible = true;
            tratamientosLabel.Visible = true;
            tratamientosrichTextBox.Visible = true;
        }

        private void regresarMenuButton_Click(object sender, EventArgs e)
        {
            ConsultaAlumno consultas = new ConsultaAlumno();
            consultas.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TutorButton_Click(object sender, EventArgs e)
        {
            nombretutorLabel.Visible = true;
            nombretutortextBox.Visible = true;
            direccionLabel.Visible = true;
            direcciontextBox.Visible = true;
            ocupacionLabel.Visible = true;
            ocupaciontextBox.Visible = true;
            telefonosLabel.Visible = true;
            casaLabel.Visible = true;
            movilLabel.Visible = true;
            trabajoLabel.Visible = true;
            casatextBox.Visible = true;
            moviltextBox.Visible = true;
            trabajotextBox.Visible = true;
            servicioLabel.Visible = false;
            serviciotextBox.Visible = false;
            telefonoLabel.Visible = false;
            telefonotextBox.Visible = false;
            grupoLabel.Visible = false;
            grupotextBox.Visible = false;
            discapacidadesLabel.Visible = false;
            discapacidadesrichTextBox.Visible = false;
            enfermedadesLabel.Visible = false;
            enfermedadesrichTextBox.Visible = false;
            alergiasLabel.Visible = false;
            alergiasrichTextBox.Visible = false;
            tratamientosLabel.Visible = false;
            tratamientosrichTextBox.Visible = false;
        }

        private void fotopictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
