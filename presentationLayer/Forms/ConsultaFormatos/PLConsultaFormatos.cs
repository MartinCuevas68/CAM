using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer.Forms.ConsultaFormatos
{
    class PLConsultaFormatos
    {

        public static void plantillaConsulta(PictureBox logo, Button regresarMenuButton) { 

            logo.Location = new Point(50, 20);
            logo.Size = new Size(150, 148);

            regresarMenuButton.Size = new Size(300, 55);
            regresarMenuButton.Location = new Point(210, 700);
        }

        public static void carpetasFormatos(Panel carpetaFCI1, Panel carpetaFCI2, Panel carpetaFCI3, Panel carpetaFCI4,
                                            Panel carpetaFCI5, Panel carpetaFCI6, Panel carpetaFCI7, Panel carpetaFCI8,
                                            Panel carpetaFCI9) { 
        
            carpetaFCI1.Location = new Point(310, 130);
            carpetaFCI1.Size = new Size(210, 160);

            carpetaFCI2.Location = new Point(670, 130);
            carpetaFCI2.Size = new Size(210, 160);

            carpetaFCI3.Location = new Point(1030, 130);
            carpetaFCI3.Size = new Size(210, 160);

            carpetaFCI4.Location = new Point(310, 320);
            carpetaFCI4.Size = new Size(210, 160);

            carpetaFCI5.Location = new Point(670, 320);
            carpetaFCI5.Size = new Size(210, 160);

            carpetaFCI6.Location = new Point(1030, 320);
            carpetaFCI6.Size = new Size(210, 160);

            carpetaFCI7.Location = new Point(310, 510);
            carpetaFCI7.Size = new Size(210, 160);

            carpetaFCI8.Location = new Point(670, 510);
            carpetaFCI8.Size = new Size(210, 160);

            carpetaFCI9.Location = new Point(1030, 510);
            carpetaFCI9.Size = new Size(210, 160);

        }



    }
}
