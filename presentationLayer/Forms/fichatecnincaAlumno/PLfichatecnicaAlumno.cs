using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentationLayer
{
    public class PLfichatecnicaAlumno
    {

        public static void centrarLabel(Label fichaLabel, PictureBox logo, Label nombreAlLabel, TextBox nombreAl, Label matriculaLabel, TextBox matricula,
            Label edadLabel, TextBox edad, PictureBox foto, Panel infoGeneralPanel, Panel infoEscolarPanel, Panel infoTutorPanel, Panel infoMedicaPanel, Button infoGeneral, Button infoEscolar, Button infoTutor, Button infoMedica,
            Button regresarMenuButton, Button editarInfoButton)
        {

            logo.Location = new Point(50, 20);

            //TITULO PRINCIPAL
            fichaLabel.Location = new Point(530, 50);

            //Foto
            foto.Size = new Size(140, 150);
            foto.Location = new Point(1060, 50);

            //Botones
            infoGeneral.Size = new Size(250, 50);
            infoGeneral.Location = new Point(200, 300);

            infoEscolar.Size = new Size(250, 50);
            infoEscolar.Location = new Point(450, 300);

            infoTutor.Size = new Size(250, 50);
            infoTutor.Location = new Point(700, 300);

            infoMedica.Size = new Size(250, 50);
            infoMedica.Location = new Point(950, 300);



            //Paneles
            infoGeneralPanel.Size = new Size(1000, 300);
            infoGeneralPanel.Location = new Point(200, 350);

            infoEscolarPanel.Size = new Size(1000, 300);
            infoEscolarPanel.Location = new Point(200, 350);

            infoTutorPanel.Size = new Size(1000, 300);
            infoTutorPanel.Location = new Point(200, 350);

            infoMedicaPanel.Size = new Size(1000, 300);
            infoMedicaPanel.Location = new Point(200, 350);

            //Botones
            regresarMenuButton.Location = new Point(200, 700);
            editarInfoButton.Location = new Point(1000, 700);

        }

        public static void infoAlumno(Label nombreAlLabel, TextBox nombreAl, Label matriculaLabel, TextBox matricula, Label edadLabel, TextBox edad)
        {
            nombreAl.Size = new Size(300, 30);
            matricula.Size = new Size(100, 300);
            edad.Size = new Size(50, 30);

            nombreAlLabel.Location = new Point(300, 150);
            nombreAl.Location = new Point(410, 150);

            matriculaLabel.Location = new Point(300, 220);
            matricula.Location = new Point(410, 220);

            edadLabel.Location = new Point(820, 150);
            edad.Location = new Point(900, 150);
        public static void posicionLabel(PictureBox logo, Label fichaLabel, Label nombreLabel, TextBox nombretxtBox, Label matriculaLabel,
           TextBox matriculatxtBox, Label edadLabel, TextBox edadtxtBox, Label tipoingresoLabel, TextBox tipoingresotxtBox,
           PictureBox fotopictureBox, Panel informaciontutorPanel, Button generalButton, Button escolarButton, Button TutorButton, Button medicaButton,
           Label nombretutorLabel, TextBox nombretutortextBox, Label direccionLabel, TextBox direcciontextBox, Label ocupacionLabel,
           TextBox ocupaciontextBox, Label telefonosLabel, Label casaLabel, Label movilLabel, Label trabajoLabel, TextBox casatextBox,
           TextBox moviltextBox, TextBox trabajotextBox, Button regresarButton, Button editarButton, Button subirfotoButton,
           Label servicioLabel, Label telefonoLabel, Label grupoLabel, TextBox serviciotextBox, TextBox telefonotextBox,
           TextBox grupotextBox, Label discapacidadesLabel, Label enfermedadesLabel, Label alergiasLabel, Label tratamientosLabel,
           RichTextBox discapacidadesrichTextBox, RichTextBox enfermedadesrichTextBox, RichTextBox alergiasrichTextBox, RichTextBox tratamientosrichTextBox
            )
            //, Label info, Label nombre, Label nombreq, Label edad, Label edadq,
            //                            Label fecha, Label fechaq, Label lugar, Label lugarq, Label curp, Label curpq, 
            //                            Label direccion, Label direccionq, Label telefono, Label telefonoq, Label escuela, Label escuelaq,
            //                            Label canalizado, Label canalizadoq, Label ciclo, Label cicloq, Label ingreso, Label ingresoq)
        {
           // int centro = (fichaTecnica.ActiveForm.Width / 2) - ficha.Width;
           // int pos = fichaTecnica.ActiveForm.Width / 5;

            //seccion 3
            fichaLabel.Location = new Point(565, 11);

            logo.Location = new Point(25, 25);
            matriculaLabel.Location = new Point(205, 161);
            matriculatxtBox.Location = new Point(312, 164);
            

            nombreLabel.Location = new Point(204, 100);
            nombretxtBox.Location = new Point(301, 105);

            edadLabel.Location = new Point(703, 101);
            edadtxtBox.Location = new Point(769, 101);

            tipoingresoLabel.Location = new Point(704, 167);
            tipoingresotxtBox.Location = new Point(865, 167);

            fotopictureBox.Location = new Point(1186, 24);
            subirfotoButton.Location = new Point(1186, 157);

            informaciontutorPanel.Size = new Size(972, 366);
            informaciontutorPanel.Location = new Point(209, 323);

            generalButton.Location = new Point(209, 292);
            escolarButton.Location = new Point(418, 292);
            TutorButton.Location = new Point(613, 292);
            medicaButton.Location = new Point(793, 292);

            nombretutorLabel.Location = new Point(132, 79);
            nombretutortextBox.Location = new Point(227, 79);

            direccionLabel.Location = new Point(132, 133);
            direcciontextBox.Location = new Point(237, 133);

            ocupacionLabel.Location = new Point(132, 186);
            ocupaciontextBox.Location = new Point(249, 186);

            telefonosLabel.Location = new Point(742, 36);
            casaLabel.Location = new Point(678, 79);
            movilLabel.Location = new Point(678, 133);
            trabajoLabel.Location = new Point(678, 186);
            casatextBox.Location = new Point(739, 79);
            moviltextBox.Location = new Point(750, 133);
            trabajotextBox.Location = new Point(767, 186);

            regresarButton.Location = new Point(209, 683);
            editarButton.Location = new Point(937, 683);

            //seccion 4

            servicioLabel.Location = new Point(132, 76);
            telefonoLabel.Location = new Point(132, 133);
            grupoLabel.Location = new Point(652, 76);
            serviciotextBox.Location = new Point(291, 76);
            telefonotextBox.Location = new Point(342, 133);
            grupotextBox.Location = new Point(829, 79);

            discapacidadesLabel.Location = new Point(51, 180);
            enfermedadesLabel.Location = new Point(303, 180);
            alergiasLabel.Location = new Point(562, 180);
            tratamientosLabel.Location = new Point(786, 180);

            discapacidadesrichTextBox.Location = new Point(16, 202);
            enfermedadesrichTextBox.Location = new Point(259, 202);
            alergiasrichTextBox.Location = new Point(498, 202);
            tratamientosrichTextBox.Location = new Point(738, 202);
            discapacidadesrichTextBox.Size = new Size(205, 128);
            enfermedadesrichTextBox.Size = new Size(205, 128);
            alergiasrichTextBox.Size = new Size(205, 128);
            tratamientosrichTextBox.Size = new Size(205, 128);

            // edad.Location = new Point(pos, 180);
            // edadq.Location = new Point(pos + edad.Width + 10, 180);

            // fecha.Location = new Point(pos, 220);
            // fechaq.Location = new Point(pos + fecha.Width + 10, 220);

            // lugar.Location = new Point(pos, 260);
            // lugarq.Location = new Point(pos + lugar.Width + 10, 260);

            // curp.Location = new Point(pos, 300);
            // curpq.Location = new Point(pos + curp.Width + 10, 300);

            // direccion.Location = new Point(pos, 340);
            // direccionq.Location = new Point(pos + direccion.Width + 10, 340);

            // telefono.Location = new Point(pos, 380);
            // telefonoq.Location = new Point(pos + telefono.Width + 10, 380);

            // escuela.Location = new Point(pos, 420);
            // escuelaq.Location = new Point(pos + escuela.Width + 10, 420);

            // canalizado.Location = new Point(pos, 460);
            // canalizadoq.Location = new Point(pos + canalizado.Width + 10, 460);

            // ciclo.Location = new Point(pos, 500); 
            //cicloq.Location = new Point(pos + ciclo.Width + 10, 500);

            // ingreso.Location = new Point(pos, 540);
            // ingresoq.Location = new Point(pos + ingreso.Width + 10, 540);
        }

        public static void infoGeneral(Label fechaNaLabel, TextBox fechaNa, Label lugarNaLabel, TextBox lugarNa, Label direccionLabel, TextBox direccion,
            Label curpLabel, TextBox curp, Label telPersonalLabel, TextBox telPersonal)
        {
            fechaNa.Size = new Size(350, 30);
            lugarNa.Size = new Size(350, 30);
            direccion.Size = new Size(450, 30);
            curp.Size = new Size(230, 30);
            telPersonal.Size = new Size(120, 30);
            //
            fechaNaLabel.Location = new Point(50,30);
            fechaNa.Location = new Point(250,30);

            lugarNaLabel.Location = new Point(50,100);
            lugarNa.Location = new Point(250,100);

            direccionLabel.Location = new Point(50, 170);
            direccion.Location = new Point(150, 170);
            //
            curpLabel.Location = new Point(650, 30);
            curp.Location = new Point(720, 30);

            telPersonalLabel.Location = new Point(650, 100);
            telPersonal.Location = new Point(830, 100);
           // int pos = fichaTecnica.ActiveForm.Width / 4;
           // pos = pos *3;
         //   foto.Location = new Point(pos - (foto.Width/2), 140);
         //   tutor.Location = new Point(pos - (tutor.Width/2), foto.Location.Y + foto.Height + 50);
        //    medico.Location = new Point(pos - (medico.Width/2), tutor.Location.Y + tutor.Height + 50);

        }

        public static void infoEscolar(Label tipoIngresoLabel, TextBox tipoIngreso, Label escuelaPLabel, TextBox escuelaP, Label canalizadoLabel, TextBox canalizado,
            Label cicloEscLabel, TextBox cicloEsc)
        {
            tipoIngreso.Size = new Size(280, 30);
            escuelaP.Size = new Size(300, 30);
            canalizado.Size = new Size(300, 30);
            cicloEsc.Size = new Size(200, 30);

            tipoIngresoLabel.Location = new Point(50, 30);
            tipoIngreso.Location = new Point(210, 30);

            escuelaPLabel.Location = new Point(50, 100);
            escuelaP.Location = new Point(280, 100);

            canalizadoLabel.Location = new Point(50, 170);
            canalizado.Location = new Point(210, 170);

            cicloEscLabel.Location = new Point(620, 30);
            cicloEsc.Location = new Point(750, 30);
        }
    }
}
