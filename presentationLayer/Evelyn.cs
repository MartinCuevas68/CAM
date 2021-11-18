using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    class Evelyn
    {
        public static void informacionMedicaGroupBox(GroupBox groupBox)
        {
            groupBox.Location = new Point(130, 100);
            groupBox.Size = new Size(1150, 550);
            groupBox.Font = new Font("Leelawadee UI", 12);
        }
        public static void altasInformacionMedicaAlumno(Label servicioMedico, Label discapacidad, Label enfermedades, Label alergias,
            Label telefonoContacto, Label grupoSanguineo, Label documentacion, Label mostrarDiscapacidad, Label mostrarEnfermedades,
            Label mostrarAlergias, TextBox servicioMedicoTB, TextBox discapacidadTB, TextBox enfermedadesTB, TextBox alergiasTB,
            TextBox telefonoContactoTB, TextBox grupoSanguineoTB, ListBox documentacionLB, RichTextBox mostrarDiscapacidadTB,
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

            documentacionLB.Location = new Point(680, aux);

            //Info
            aux = aux + 80;
            discapacidad.Location = new Point(20, aux);
            discapacidadTB.Location = new Point(240, aux);
            agregarDiscapacidad.Location = new Point(360, aux - 4);

            aux = aux + 40;
            enfermedades.Location = new Point(20, aux);
            enfermedadesTB.Location = new Point(240, aux - 4);
            agregarEnfermedad.Location = new Point(360, aux - 4);

            aux = aux + 40;
            alergias.Location = new Point(20, aux);
            alergiasTB.Location = new Point(240, aux - 4);
            agregarAlergias.Location = new Point(360, aux - 4);

            aux = aux + 80;
            mostrarDiscapacidad.Location = new Point(20, aux);
            mostrarEnfermedades.Location = new Point(360, aux);
            mostrarAlergias.Location = new Point(680, aux);

            aux = aux + 40;

            mostrarDiscapacidadTB.Location = new Point(20, aux);
            mostrarEnfermedadTB.Location = new Point(360, aux);
            mostrarAlergiasTB.Location = new Point(680, aux);


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
            discapacidadTB.Size = new Size(100, 30);
            enfermedadesTB.Size = new Size(100, 30);
            alergiasTB.Size = new Size(100, 30);
            documentacionLB.Size = new Size(300, 180);
            telefonoContactoTB.Size = new Size(100, 150);
            grupoSanguineoTB.Size = new Size(100, 30);
            mostrarDiscapacidadTB.Size = new Size(300, 150);
            mostrarEnfermedadTB.Size = new Size(300, 150);
            mostrarAlergiasTB.Size = new Size(300, 150);
        }

        public static void altasBotonesParaNavegar(Button siguiente, Button regresar, Button guardar)
        {
            siguiente.Location = new Point(1180, 740);
            guardar.Location = new Point(1180, 740);
            regresar.Location = new Point(1070, 740);

            siguiente.Size = new Size(100, 30);
            regresar.Size = new Size(100, 30);
            guardar.Size = new Size(135, 30);

            siguiente.Font = new Font("Leelawadee UI", 12);
            regresar.Font = new Font("Leelawadee UI", 12);
            guardar.Font = new Font("Leelawadee UI", 12);
        }

        public static void altasBotonesPanel(Button alumnos, Button docentes)
        {
            docentes.Font = new Font("Leelawadee UI", 12);
            alumnos.Font = new Font("Leelawadee UI", 12);
        }

            
    }
}
