using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace presentationLayer
{
    class Claudia
    {
        public static void altasButton(Button button) {
            button.Location = new Point(1100,1100);
            button.Size = new Size(100,30);
        }

        public static int altasLabel(Label label, int distancia) { 
            label.Location = new Point(60, distancia);
            label.Size = new Size(100, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static int altasLabelDerecha(Label label, int distancia)
        {
            label.Location = new Point(660, distancia);
            label.Size = new Size(100, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static int altasGroupBox(GroupBox groupBox, int distancia)
        {
            groupBox.Location = new Point(660, distancia);
            groupBox.Size = new Size(220, 55);
            distancia = distancia + 260;
            return distancia;
        }

        public static int altasDateTimePicker(DateTimePicker dateTimePicker, int distancia)
        {
            dateTimePicker.Location = new Point(220, distancia);
            dateTimePicker.Size = new Size(300, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static int altasTextBox(TextBox textBox, int distancia)
        {
            textBox.Location = new Point(220, distancia);
            textBox.Size = new Size(300, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static int altasTextBoxDerecha(TextBox textBox, int distancia)
        {
            textBox.Location = new Point(775, distancia);
            textBox.Size = new Size(120, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static int altasTelefonosLabel(Label casa, Label celular, Label trabajo, int distancia)
        {
            casa.Location = new Point(215, distancia + 4);
            celular.Location = new Point(355, distancia + 4);
            trabajo.Location = new Point(515, distancia + 4);
            casa.Size = new Size(120, 30);
            celular.Size = new Size(120, 30);
            trabajo.Size = new Size(120, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static void altasTelefonosTextBox(TextBox casa, TextBox celular, TextBox trabajo, int distancia)
        {
            casa.Location = new Point(255, distancia);
            celular.Location = new Point(415, distancia);
            trabajo.Location = new Point(575, distancia);
            casa.Size = new Size(90, 30);
            celular.Size = new Size(90, 30);
            trabajo.Size = new Size(90, 30);
        }

        public static int altasResponsableAlumnoCheckBox(CheckBox madre, CheckBox padre, int distancia)
        {
            madre.Location = new Point(365, distancia + 4);
            padre.Location = new Point(480, distancia + 4);
            distancia = distancia + 30;

            return distancia;
        }

        public static void altasApellidosLabel(Label apellidoP, Label apellidoM , int distancia)
        {
            distancia = distancia - 30;
            apellidoP.Location = new Point(400, distancia);
            apellidoM.Location = new Point(660, distancia);
            apellidoP.Size = new Size(120, 30);
            apellidoM.Size = new Size(120, 30);
            distancia = distancia + 30;
        }

        public static void altasNacimientoAlumnoLabel(Label ciudad, Label estado, int distancia)
        {
            distancia = distancia - 30;
            ciudad.Location = new Point(220, distancia);
            estado.Location = new Point(400, distancia);
            ciudad.Size = new Size(120, 30);
            estado.Size = new Size(120, 30);
            distancia = distancia + 30;
        }

        public static void altasDireccionLabel(Label calle, Label numero, Label colonia, int distancia)
        {
            distancia = distancia - 30;
            calle.Location = new Point(220, distancia);
            numero.Location = new Point(400, distancia);
            colonia.Location = new Point(540, distancia);
            calle.Size = new Size(120, 30);
            numero.Size = new Size(120, 30);
            colonia.Size = new Size(120, 30);
            distancia = distancia + 30;
        }

        public static int altasDireccionTextBox(TextBox calle, TextBox numero, TextBox colonia, int distancia)
        {
            distancia = distancia - 30;
            calle.Location = new Point(270, distancia - 4);
            numero.Location = new Point(460, distancia - 4);
            colonia.Location = new Point(600, distancia - 4);
            calle.Size = new Size(120, 30);
            numero.Size = new Size(60, 30);
            colonia.Size = new Size(120, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static int altasApellidosTextBox(TextBox nombre, TextBox apellidoP, TextBox apellidoM, int distancia)
        { 
            nombre.Location = new Point(220, distancia);
            apellidoP.Location = new Point(520, distancia);
            apellidoM.Location = new Point(780, distancia);
            apellidoP.Size = new Size(120, 30);
            apellidoM.Size = new Size(120, 30);
            nombre.Size = new Size(170, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static void altasNacimientoAlumnoTextBox(TextBox ciudad, TextBox estado, int distancia)
        {
            distancia = distancia - 34;
            ciudad.Location = new Point(270, distancia);
            estado.Location = new Point(460, distancia);
            ciudad.Size = new Size(120, 30);
            estado.Size = new Size(120, 30);
            distancia = distancia + 34;
        }

        public static int altasResponsablesOtroAlumnoGroupBox(GroupBox otroAlumno, int distancia)
        {
            otroAlumno.Location = new Point(60, distancia + 4);
            otroAlumno.Size = new Size(410, 50);
            distancia = distancia + 30;

            return distancia;
        }


        public static int altasOcupacionPadres(TextBox ocupacion, Label lugar, Label calle, TextBox calleTB, Label numero, TextBox numeroTB, Label colonia, TextBox coloniaTB, int distancia)
        {
            ocupacion.Location = new Point(220, distancia - 4);
            lugar.Location = new Point(355, distancia);
            calle.Location = new Point(515, distancia);
            calleTB.Location = new Point(565, distancia - 4);
            numero.Location = new Point(700, distancia);
            numeroTB.Location = new Point(760, distancia - 4);
            colonia.Location = new Point(830, distancia);
            coloniaTB.Location = new Point(890, distancia - 4);

            ocupacion.Size = new Size(120, 30);
            lugar.Size = new Size(120, 30);
            calle.Size = new Size(120, 30);
            calleTB.Size = new Size(120, 30);
            numero.Size = new Size(120, 30);
            numeroTB.Size = new Size(60, 30);
            colonia.Size = new Size(120, 30);
            coloniaTB.Size = new Size(120, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static int altasInformacionMedicaAlumno(Label servicio, TextBox servicioTB,  
                        Label grupoSanguineo, TextBox grupoSanguineoTB, Label documentacion, Label enfermedades, TextBox enfermedadesTB, ListBox documentacionLB,
                        Label alergias, TextBox alergiasTB, Label telefono, TextBox telefonoTB, int distancia) { 
            
            
            servicio.Location = new Point(60, distancia);
            servicioTB.Location = new Point(220, distancia);
            grupoSanguineo.Location = new Point(355, distancia);
            grupoSanguineoTB.Location = new Point(480, distancia - 4);
            documentacion.Location = new Point(550, distancia);
            distancia = distancia + 30;
            enfermedades.Location = new Point(60, distancia);
            enfermedadesTB.Location = new Point(220, distancia - 4);
            documentacionLB.Location = new Point(550, distancia);
            distancia = distancia + 30;
            alergias.Location = new Point(60, distancia);
            alergiasTB.Location = new Point(220, distancia - 4);
            distancia = distancia + 30;
            telefono.Location = new Point(60, distancia);
            telefonoTB.Location = new Point(220, distancia - 4);


            servicioTB.Size = new Size(120, 30);
            grupoSanguineoTB.Size = new Size(40, 30);
            enfermedadesTB.Size = new Size(120, 30);
            alergiasTB.Size = new Size(120, 30);
            telefonoTB.Size = new Size(60, 30);
            documentacionLB.Size = new Size(190, 95);

            distancia = distancia + 120;

            return distancia;

        }

        public static int altasComboBox(ComboBox comboBox, int distancia)
        {
            comboBox.Location = new Point(220, distancia);
            comboBox.Size = new Size(300, 30);
            distancia = distancia + 30;
            return distancia;
        }


    }
}
