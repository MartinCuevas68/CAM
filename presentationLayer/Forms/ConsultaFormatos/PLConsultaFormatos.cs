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

        public static void plantillaConsulta(PictureBox logo, Button regresarMenuButton, Label titulo)
        {

            logo.Location = new Point(50, 20);
            logo.Size = new Size(150, 148);

            regresarMenuButton.Size = new Size(300, 55);
            regresarMenuButton.Location = new Point(210, 700);

            titulo.Location = new Point(640, 40);
        }

        public static void vistaPrevia(AxAcroPDFLib.AxAcroPDF vistaPreviaPDF, Label titulo, Label formato)
        {
           
            formato.Location = new Point(265, 40);
            formato.Size = new Size(100, 40); 

            titulo.Location = new Point(150, 100);
            titulo.Size = new Size(100, 40);
            titulo.Visible = false;

           vistaPreviaPDF.Location = new Point(120, 140);
            vistaPreviaPDF.Size = new Size(500, 590);
        }

        public static void carpetasFormatos(Panel carpetaFCI1, Panel carpetaFCI2, Panel carpetaFCI3, Panel carpetaFCI4,
                                            Panel carpetaFCI5, Panel carpetaFCI6, Panel carpetaFCI7, Panel carpetaFCI8,
                                            Panel carpetaFCI9)
        {

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

        public static void titulosCarpetasFormatos(Label FCI1, Label FCI2, Label FCI3, Label FCI4, Label FCI5, Label FCI6, Label FCI7, Label FCI8, Label FCI9)
        {
            FCI1.Location = new Point(45, 70);
            FCI1.Size = new Size(200, 140);

            FCI2.Location = new Point(30, 70);
            FCI2.Size = new Size(160, 140);

            FCI3.Location = new Point(20, 70);
            FCI3.Size = new Size(200, 140);

            FCI4.Location = new Point(55, 70);
            FCI4.Size = new Size(200, 140);

            FCI5.Location = new Point(55, 70);
            FCI5.Size = new Size(200, 140);

            FCI6.Location = new Point(55, 70);
            FCI6.Size = new Size(200, 140);

            FCI7.Location = new Point(30, 70);
            FCI7.Size = new Size(200, 140);

            FCI8.Location = new Point(12, 70);
            FCI8.Size = new Size(200, 140);

            FCI9.Location = new Point(30, 70);
            FCI9.Size = new Size(200, 140);
        }

        public static void pestañasCarpetasFormatos(Label FCI1, Label FCI2, Label FCI3, Label FCI4, Label FCI5, Label FCI6, Label FCI7, Label FCI8, Label FCI9)
        {
            FCI1.Location = new Point(20, 7);
            FCI1.Size = new Size(60, 20);

            FCI2.Location = new Point(20, 7);
            FCI2.Size = new Size(60, 20);

            FCI3.Location = new Point(20, 7);
            FCI3.Size = new Size(60, 20);

            FCI4.Location = new Point(20, 7);
            FCI4.Size = new Size(60, 20);

            FCI5.Location = new Point(20, 7);
            FCI5.Size = new Size(60, 20);

            FCI6.Location = new Point(20, 7);
            FCI6.Size = new Size(60, 20);

            FCI7.Location = new Point(20, 7);
            FCI7.Size = new Size(60, 20);

            FCI8.Location = new Point(20, 7);
            FCI8.Size = new Size(60, 20);

            FCI9.Location = new Point(20, 7);
            FCI9.Size = new Size(60, 20);
        }

        public static void Panel_MouseEnter(Label titulo)
        {
            titulo.ForeColor = Color.White;
        }
        public static void Panel_MouseLeave(Label titulo)
        {
            titulo.ForeColor = Color.Black;
        }
    }
}
