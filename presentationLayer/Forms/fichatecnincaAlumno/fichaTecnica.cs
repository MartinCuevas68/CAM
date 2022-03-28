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
        _1dataLayer.foto_alumno foto = new _1dataLayer.foto_alumno();
        public fichaTecnica(int id)
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
            foto = _1dataLayer.DLConsultaAlumno.ConsultaFoto(id);
            MessageBox.Show(foto.nombre);
            fotopictureBox.Image = byteArrayToImage(foto.imagen_alumno.ToArray());
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

        private void informaciontutorButton_Click(object sender, EventArgs e)
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
