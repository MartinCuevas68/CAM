using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public class PLBajaAlumno
    {
        public static void datosAlumno(PictureBox foto, Label nombre, TextBox nombreTB, Label matricula, TextBox matriculaTB,
                Label tipoIng, TextBox tipoIngTB, Label edad, TextBox edadTB, Label curp, TextBox curpTB) {

                foto.Location = new Point(50, 80);
                foto.Size = new Size(110, 140);

                nombre.Location = new Point(180, 90);
                nombreTB.Location = new Point(270, 90);
                nombreTB.Size = new Size(430, 40);

                tipoIng.Location = new Point(395, 140);
                tipoIngTB.Location = new Point(550, 140);
                tipoIngTB.Size = new Size(150, 40);

                matricula.Location = new Point(180, 140);
                matriculaTB.Location = new Point(280, 140);
                matriculaTB.Size = new Size(80, 40);

                edad.Location = new Point(180, 190);
                edadTB.Location = new Point(240, 190);
                edadTB.Size = new Size(40, 40);

                curp.Location = new Point(395, 190);
                curpTB.Location = new Point(460, 190);
                curpTB.Size = new Size(300, 40);

        }


        public static void plantillaBajas(Label titulo, Label pregunta, Button cancelar, Button continuar){
                
                titulo.Location = new Point(220, 25);
                pregunta.Location = new Point(180, 280);
                cancelar.Location = new Point(160, 310);
                cancelar.Size = new Size(200, 40);
                continuar.Location = new Point(380, 310);
                continuar.Size = new Size(230, 40);
        }
    }
}
