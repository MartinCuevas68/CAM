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

        public static void posicionLabel(PictureBox logo , Label ficha, Label info, Label nombre, Label nombreq, Label edad, Label edadq,
                                        Label fecha, Label fechaq, Label lugar, Label lugarq, Label curp, Label curpq, 
                                        Label direccion, Label direccionq, Label telefono, Label telefonoq, Label escuela, Label escuelaq,
                                        Label canalizado, Label canalizadoq, Label ciclo, Label cicloq, Label ingreso, Label ingresoq)
        {
            int centro = (fichaTecnica.ActiveForm.Width / 2) - ficha.Width;
            int pos = fichaTecnica.ActiveForm.Width / 5;

            ficha.Location = new Point(centro, 25);
            logo.Location = new Point(25, 25);
            info.Location = new Point(pos, 80);

            nombre.Location = new Point(pos, 140);
            nombreq.Location = new Point(pos+nombre.Width+10, 140);

            edad.Location = new Point(pos, 180);
            edadq.Location = new Point(pos + edad.Width + 10, 180);

            fecha.Location = new Point(pos, 220);
            fechaq.Location = new Point(pos + fecha.Width + 10, 220);

            lugar.Location = new Point(pos, 260);
            lugarq.Location = new Point(pos + lugar.Width + 10, 260);

            curp.Location = new Point(pos, 300);
            curpq.Location = new Point(pos + curp.Width + 10, 300);

            direccion.Location = new Point(pos, 340);
            direccionq.Location = new Point(pos + direccion.Width + 10, 340);

            telefono.Location = new Point(pos, 380);
            telefonoq.Location = new Point(pos + telefono.Width + 10, 380);

            escuela.Location = new Point(pos, 420);
            escuelaq.Location = new Point(pos + escuela.Width + 10, 420);

            canalizado.Location = new Point(pos, 460);
            canalizadoq.Location = new Point(pos + canalizado.Width + 10, 460);

            ciclo.Location = new Point(pos, 500); 
           cicloq.Location = new Point(pos + ciclo.Width + 10, 500);

            ingreso.Location = new Point(pos, 540);
            ingresoq.Location = new Point(pos + ingreso.Width + 10, 540);
        }

        public static void posicionFotoButtons(PictureBox foto, Button tutor, Button medico)
        {
            int pos = fichaTecnica.ActiveForm.Width / 4;
            pos = pos *3;
            foto.Location = new Point(pos - (foto.Width/2), 140);
            tutor.Location = new Point(pos - (tutor.Width/2), foto.Location.Y + foto.Height + 50);
            medico.Location = new Point(pos - (medico.Width/2), tutor.Location.Y + tutor.Height + 50);

        }


    }
}
