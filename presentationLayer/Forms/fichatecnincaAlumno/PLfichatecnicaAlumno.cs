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
