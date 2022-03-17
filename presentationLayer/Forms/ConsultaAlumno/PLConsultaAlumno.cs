using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    public class PLConsultaAlumno
    {

        public static void consultaBotonesAlumnos(Button agregar, Button modificar, Button eliminar)
        {

            agregar.Location = new Point(1130, 150);
            modificar.Location = new Point(1190, 150);
            eliminar.Location = new Point(1250, 150);

            agregar.Size = new Size(50, 50);
            modificar.Size = new Size(50, 50);
            eliminar.Size = new Size(50, 50);
        }

    }
}
