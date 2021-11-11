using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    class Claudia
    {
        public static void altasGroupBox(GroupBox groupBox) {
            groupBox.Location = new Point(20,150);
            groupBox.Size = new Size(1150, 410);
            groupBox.Font = new Font("Leelawadee UI", 12);
        }

        public static void altasGroupBox2(GroupBox groupBox2)
        {
            groupBox2.Location = new Point(20, 580);
            groupBox2.Size = new Size(400, 250);
            groupBox2.Font = new Font("Leelawadee UI", 12);
        }

        public static int altasLabel(Label label, int distancia)
        {
            label.Location = new Point(20, distancia);
            label.Size = new Size(100, 30);
            distancia = distancia + 40;
            return distancia;
        }

        public static int altasTextBox(TextBox textBox, int distancia)
        {
            textBox.Location = new Point(240, distancia);
            textBox.Size = new Size(300, 30);
            distancia = distancia + 40;
            return distancia;
        }

        public static int altasDateTimePicker(DateTimePicker dateTimePicker, int distancia)
        {
            dateTimePicker.Location = new Point(240, distancia);
            dateTimePicker.Size = new Size(300, 30);
            distancia = distancia + 40;
            return distancia;
        }

        public static int altasNombre(Label nombre,Label apellidoP, Label apellidoM, TextBox nombreTB, TextBox apellidoPTB, TextBox apellidoMTB, int distancia) {
            nombre.Location = new Point(20, distancia);
            nombreTB.Location = new Point(240, distancia);

            apellidoP.Location = new Point(550, distancia);
            apellidoPTB.Location = new Point(710, distancia);

            apellidoM.Location = new Point(840, distancia);
            apellidoMTB.Location = new Point(1010, distancia);

            nombre.Size = new Size(100, 30);
            apellidoP.Size = new Size(100, 30);
            apellidoM.Size = new Size(100, 30);
            nombreTB.Size = new Size(300, 30);
            apellidoPTB.Size = new Size(120, 30);
            apellidoMTB.Size = new Size(120, 30);

            distancia = distancia + 40;
            return distancia;
        }

        public static int altasLugarNacimiento(Label titulo, Label ciudad, Label estado, TextBox ciudadTB, TextBox estadoTB, int distancia){
            titulo.Location = new Point(20, distancia);
            ciudad.Location = new Point(240,distancia);
            ciudadTB.Location = new Point(340, distancia);
            estado.Location = new Point(460, distancia);
            estadoTB.Location = new Point(550, distancia);

            titulo.Size = new Size(100, 30);
            ciudad.Size = new Size(100,30);
            ciudadTB.Size = new Size(100, 30);
            estado.Size = new Size(100, 30);
            estadoTB.Size = new Size(100, 30);

            distancia = distancia + 40;
            return distancia;
        }

        public static int altasDireccion(Label titulo, Label calle, Label numero, Label colonia, TextBox calleTB, TextBox numeroTB, TextBox coloniaTB, int distancia) {
            titulo.Location = new Point(20, distancia);
            calle.Location = new Point(240, distancia);
            calleTB.Location = new Point(340, distancia);
            numero.Location = new Point(460, distancia);
            numeroTB.Location = new Point(550, distancia);
            colonia.Location = new Point(660, distancia);
            coloniaTB.Location = new Point(750, distancia);

            titulo.Size = new Size(100, 30);
            calle.Size = new Size(100, 30);
            calleTB.Size = new Size(100, 30);
            numero.Size = new Size(100, 30);
            numeroTB.Size = new Size(100, 30);
            colonia.Size = new Size(100, 30);
            coloniaTB.Size = new Size(100, 30);

            distancia = distancia + 40;
            return distancia;
        }

        public static void altasInformacionEscolar(Label ciclo, Label curp, Label edad, TextBox cicloTB, TextBox curpTB, TextBox edadTB, GroupBox ingreso, RadioButton radioButton1, RadioButton radioButton2) {
            int aux = 40;
            ciclo.Location = new Point(20, aux);
            cicloTB.Location = new Point(180, aux - 4);
            aux = aux + 40;
            curp.Location = new Point(20, aux);
            curpTB.Location = new Point(180, aux - 4);
            aux = aux + 40;
            edad.Location = new Point(20, aux);
            edadTB.Location = new Point(180, aux - 4);
            aux = aux + 40;
            ingreso.Location = new Point(20, aux);
            radioButton1.Location = new Point(20, 40);
            radioButton2.Location = new Point(200, 40);

            ciclo.Size = new Size(100, 30);
            curp.Size = new Size(100, 30);
            edad.Size = new Size(100, 30);
            cicloTB.Size = new Size(100, 30);
            curpTB.Size = new Size(100, 30);
            edadTB.Size = new Size(100, 30);
            ingreso.Size = new Size(350, 80);
            radioButton1.Size = new Size(100, 30);
            radioButton2.Size = new Size(100, 30);
        }

        /*        public static void altasButton(Button button) {
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
                }*/


    }
}
