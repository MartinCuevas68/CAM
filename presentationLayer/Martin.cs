using System.Drawing;
using System.Windows.Forms;

namespace presentationLayer
{
    internal class Martin
    {
        public static void panelNavBar(Panel navBarPanel)
        {
            navBarPanel.Location = new Point(-1, 0);
            navBarPanel.Size = new Size(1371, 100);
        }

        public static void etiquetafuncionLabel(Label funcionLabel)
        {

            funcionLabel.Location = new Point(700, 150);
            funcionLabel.Font = new Font("Leelawadee UI", 36, FontStyle.Bold);

        }

        public static void nodificacion(Label idLabel, Label nombreLabel)
        {

            idLabel.Location = new Point(400, 200);
            nombreLabel.Location = new Point(500, 200);

        }

    }
}
