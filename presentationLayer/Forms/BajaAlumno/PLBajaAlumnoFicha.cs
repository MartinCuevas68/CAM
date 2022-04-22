using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public class PLBajaAlumnoFicha
    {

        public static void datosAlumnoFicha(Label nombre, TextBox nombreTB, Label matricula, TextBox matriculaTB)
        {
            nombre.Location = new Point(120, 110);
            nombreTB.Location = new Point(220, 110);
            nombreTB.Size = new Size(430, 40);

            matricula.Location = new Point(120, 170);
            matriculaTB.Location = new Point(230, 170);
            matriculaTB.Size = new Size(80, 40);

        }

        public static void plantillaBajas(Label titulo, Label pregunta, Button cancelar, Button continuar)
        {
            titulo.Location = new Point(160, 25);
            pregunta.Location = new Point(120, 250);
            cancelar.Location = new Point(100, 310);
            cancelar.Size = new Size(200, 40);
            continuar.Location = new Point(320, 310);
            continuar.Size = new Size(230, 40);
        }

    }
}
