using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    public class PLmodificacionAlumno
    {

        public static void informacionMedicaGroupBox(GroupBox groupBox)
        {
            groupBox.Location = new Point(300, 250);
            groupBox.Size = new Size(1150, 550);
            groupBox.Font = new Font("Leelawadee UI", 12);
        }

        public static void eliminarBotones(Button eliminarEnfermedades, Button eliminarDiscapacidad, Button eliminarAlergias)
        {
            //Texto a botones
            var tt = new ToolTip();
            tt.SetToolTip(eliminarAlergias, "ELIMINAR ALERGIAS");
            tt.SetToolTip(eliminarDiscapacidad, "ELIMINAR DISCAPACIDADES");
            tt.SetToolTip(eliminarEnfermedades, "ELIMINAR  ENFERMEDADES");

            eliminarDiscapacidad.Location = new Point(282, 315);
            eliminarEnfermedades.Location = new Point(622, 315);
            eliminarAlergias.Location = new Point(941, 315);
        }

        public static void altasInformacionMedicaAlumno(Label servicioMedico, Label discapacidad, Label enfermedades, Label alergias,
            Label telefonoContacto, Label grupoSanguineo, Label documentacion, Label mostrarDiscapacidad, Label mostrarEnfermedades,
            Label mostrarAlergias, TextBox servicioMedicoTB, ComboBox discapacidadCB, ComboBox enfermedadesCB, ComboBox alergiasCB,
            TextBox telefonoContactoTB, TextBox grupoSanguineoTB, GroupBox documentacionGB, RichTextBox mostrarDiscapacidadTB,
            RichTextBox mostrarEnfermedadTB, RichTextBox mostrarAlergiasTB, Button agregarAlergias, Button agregarEnfermedad, Button agregarDiscapacidad)
        {
            int aux = 40;
            servicioMedico.Location = new Point(20, aux);
            servicioMedicoTB.Location = new Point(240, aux - 4);

            grupoSanguineo.Location = new Point(360, aux);
            grupoSanguineoTB.Location = new Point(540, aux);

            documentacion.Location = new Point(680, aux);

            aux = aux + 40;
            telefonoContacto.Location = new Point(20, aux);
            telefonoContactoTB.Location = new Point(240, aux);

            documentacionGB.Location = new Point(680, aux);
            documentacionGB.Font = new Font("Leelawadee UI", 12);

            //Info
            aux = aux + 80;
            discapacidad.Location = new Point(20, aux);
            discapacidadCB.Location = new Point(240, aux);
            agregarDiscapacidad.Location = new Point(360, aux - 4);

            aux = aux + 40;

            //Texto a botones
            var tt = new ToolTip();
            tt.SetToolTip(agregarAlergias, "AGREGAR ALERGIA");
            tt.SetToolTip(agregarDiscapacidad, "AGREGAR DISCAPACIDAD");
            tt.SetToolTip(agregarEnfermedad, "AGREGAR ENFERMEDAD");

            enfermedades.Location = new Point(20, aux);
            enfermedadesCB.Location = new Point(240, aux - 4);
            agregarEnfermedad.Location = new Point(360, aux - 4);

            aux = aux + 40;
            alergias.Location = new Point(20, aux);
            alergiasCB.Location = new Point(240, aux - 4);
            agregarAlergias.Location = new Point(360, aux - 4);

            aux = aux + 80;
            mostrarDiscapacidad.Location = new Point(20, aux);
            mostrarEnfermedades.Location = new Point(360, aux);
            mostrarAlergias.Location = new Point(680, aux);

            aux = aux + 40;

            mostrarDiscapacidadTB.Location = new Point(20, aux);
            mostrarDiscapacidadTB.Enabled = false;
            mostrarEnfermedadTB.Location = new Point(360, aux);
            mostrarEnfermedadTB.Enabled = false;
            mostrarAlergiasTB.Location = new Point(680, aux);
            mostrarAlergiasTB.Enabled = false;


            servicioMedico.Size = new Size(100, 30);
            discapacidad.Size = new Size(100, 30);
            enfermedades.Size = new Size(100, 30);
            alergias.Size = new Size(100, 30);
            documentacion.Size = new Size(100, 30);
            telefonoContacto.Size = new Size(100, 30);
            grupoSanguineo.Size = new Size(100, 30);
            mostrarDiscapacidad.Size = new Size(100, 30);
            mostrarEnfermedades.Size = new Size(100, 30);
            mostrarAlergias.Size = new Size(100, 30);

            servicioMedicoTB.Size = new Size(100, 30);
            discapacidadCB.Size = new Size(100, 30);
            enfermedadesCB.Size = new Size(100, 30);
            alergiasCB.Size = new Size(100, 30);
            documentacionGB.Size = new Size(320, 200);
            telefonoContactoTB.Size = new Size(100, 150);
            grupoSanguineoTB.Size = new Size(100, 30);
            mostrarDiscapacidadTB.Size = new Size(300, 150);
            mostrarEnfermedadTB.Size = new Size(300, 150);
            mostrarAlergiasTB.Size = new Size(300, 150);
        }

        public static void altasBotonesPanel(Button alumnos)
        {
            alumnos.Size = new Size(100, 75);
            var tt = new ToolTip();
            //tt.SetToolTip(docentes, "MENÚ DOCENTES");
            tt.SetToolTip(alumnos, "MENÚ ALUMNOS");

            //docentes.Font = new Font("Leelawadee UI", 12);
            alumnos.Font = new Font("Leelawadee UI", 12);
        }
    }
}
