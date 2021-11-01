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
            button.Location = new Point(1000,650);
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
            label.Location = new Point(600, distancia);
            label.Size = new Size(100, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static int altasGroupBox(GroupBox groupBox, int distancia)
        {
            groupBox.Location = new Point(600, distancia);
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
            textBox.Location = new Point(715, distancia);
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

        public static int altasDomicilioLabel(Label domicilio, Label calle, Label colonia, int distancia)
        {
            //casa.Location = new Point(215, distancia + 4);
            //celular.Location = new Point(355, distancia + 4);
            //trabajo.Location = new Point(515, distancia + 4);
            //casa.Size = new Size(120, 30);
            //celular.Size = new Size(120, 30);
            //trabajo.Size = new Size(120, 30);
            distancia = distancia + 30;
            return distancia;
        }

        public static void altasDomicilioTextBox(TextBox calle, TextBox colonia, int distancia)
        {
            //casa.Location = new Point(255, distancia);
            //celular.Location = new Point(415, distancia);
            //trabajo.Location = new Point(575, distancia);
            //casa.Size = new Size(90, 30);
            //celular.Size = new Size(90, 30);
            //trabajo.Size = new Size(90, 30);
        }


        public static int altasResponsableAlumnoCheckBox(CheckBox madre, CheckBox padre, int distancia)
        {
            madre.Location = new Point(365, distancia + 4);
            padre.Location = new Point(445, distancia + 4);
            distancia = distancia + 30;

            return distancia;
        }

    }
}
