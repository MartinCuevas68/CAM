using System;
using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    class PLAltaAlumno
    {

        //CENTRAR TITULO
        public static void centrarLabel(Label nomLabel, Label infoTutorL, Label infoMedLabel, PictureBox logo, Label infGenLabel, GroupBox infoGeneral,
            GroupBox infoGeneral2, GroupBox infoTutor, GroupBox infoMedica, Label infoTutorLabel)
        {
            //tamaño pantalla

            logo.Location = new Point(50, 20);
            logo.Size = new Size(150, 148);

            //TITULO PRINCIPAL
            nomLabel.Location = new Point(620, 50);

            //SUBTITULOS
            infGenLabel.Location = new Point(620, 120);
            infoTutorLabel.Location = new Point(670, 120);
            infoMedLabel.Location = new Point(620, 120);


            //GROUPBOXS
            infoGeneral.Size = new Size(1220, 480);
            infoGeneral.Location = new Point(180, 180);

            infoGeneral2.Size = new Size(580, 460);
            infoGeneral2.Location = new Point(510, 180);

            infoTutor.Size = new Size(1100, 480);
            infoTutor.Location = new Point(260, 180);

            infoMedica.Size = new Size(1220, 440);
            infoMedica.Location = new Point(180, 180);
        }

        //INFORMACION GENERAL ALUMNO
        public static void infoGen(Label nombreL, TextBox nombre, Panel nombreP, Label apellidoPL, TextBox apellidoP, Panel apellidoPP, Label apellidoML,
            TextBox apellidoM, Panel apellidoMP,
            Label fechaNaL, DateTimePicker fechaNa, Label añosCumL, TextBox añosCum, Panel añosCumP, Label curpL, TextBox curp, Panel curpP,
            Label direccion, Label calleL,
            TextBox calle, Panel calleP, Label numL, TextBox num, Panel numP, Label coloniaL, TextBox colonia, Panel coloniaP, Label lugarNa,
            Label ciudadL, TextBox ciudad, Panel ciudadP, Label estadoL, TextBox estado, Panel estadoP, PictureBox foto, Button fotoB)
        {

            foto.Location = new Point(1000, 50);
            foto.Size = new Size(200, 220);
            fotoB.Location = new Point(1000, 285);
            fotoB.Size = new Size(200, 45);
            fotoB.Font = new Font("Gadugi", 14);

            nombreL.Location = new Point(50, 50);
            nombreP.Location = new Point(260, 50);
            nombreP.Size = new Size(300, 45);
            //nombreP.Padding = new Padding(2,2,2,2);

            apellidoPL.Location = new Point(50, 110);
            apellidoPP.Location = new Point(260, 110);
            apellidoPP.Size = new Size(300, 45);

            apellidoML.Location = new Point(50, 170);
            apellidoMP.Location = new Point(260, 170);
            apellidoMP.Size = new Size(300, 45);

            fechaNaL.Location = new Point(50, 230);
            fechaNa.Location = new Point(260, 230);

            añosCumL.Location = new Point(50, 290);
            añosCumP.Location = new Point(260, 290);
            añosCumP.Size = new Size(150, 45);

            curpL.Location = new Point(50, 350);
            curpP.Location = new Point(260, 350);
            curpP.Size = new Size(300, 45);

            //DIRECCION
            direccion.Location = new Point(650, 50);

            calleL.Location = new Point(650, 110);
            calleP.Location = new Point(740, 110);
            calleP.Size = new Size(240, 45);

            numL.Location = new Point(650, 170);
            numP.Location = new Point(740, 170);
            numP.Size = new Size(150, 45);

            coloniaL.Location = new Point(650, 230);
            coloniaP.Location = new Point(740, 230);
            coloniaP.Size = new Size(240, 45);

            //LUGAR NACIMIENTO
            lugarNa.Location = new Point(650, 290);


            ciudadL.Location = new Point(650, 350);
            ciudadP.Location = new Point(740, 350);
            ciudadP.Size = new Size(240, 45);

            estadoL.Location = new Point(650, 410);
            estadoP.Location = new Point(740, 410);
            estadoP.Size = new Size(240, 45);
        }

        //INFORMACION GENERAL ALUMNO 2
        public static void infoGen2(Label telL, TextBox tel, Panel telP, Label escuelaPL, TextBox escuelaP, Panel escuelaPP, Label canalizadoL, TextBox canalizado, Panel canalizadoP, Label cicloL,
            TextBox ciclo, Panel cicloP, Label tipoIng, GroupBox ingresos)
        {
            telL.Location = new Point(50, 50);
            telP.Location = new Point(280, 50);
            telP.Size = new Size(150, 45);

            escuelaPL.Location = new Point(50, 110);
            escuelaPP.Location = new Point(280, 110);
            escuelaPP.Size = new Size(250, 45);

            canalizadoL.Location = new Point(50, 170);
            canalizadoP.Location = new Point(280, 170);
            canalizadoP.Size = new Size(250, 45);

            cicloL.Location = new Point(50, 230);
            cicloP.Location = new Point(280, 230);
            cicloP.Size = new Size(150, 45);

            tipoIng.Location = new Point(50, 290);

            ingresos.Location = new Point(50, 330);
        }

        //INFORMACION TUTOR
        public static void infoTutor(Label nombreL, TextBox nombre, Panel nombreP, Label apellidoPL, TextBox apellidoP, Panel apellidoPP,
            Label apellidoML, TextBox apellidoM, Panel apellidoMP, Label direccion, Label calleL, TextBox calle, Panel calleP,
            Label numL, TextBox num, Panel numP, Label coloniaL, TextBox colonia, Panel coloniaP, Label datoCalle, Label datoNumeroCasa, Label datoColonia,
            Label infoCon, Label telCasaL, TextBox telCasa, Panel telCasaP, Label telMovilL, TextBox telMovil, Panel telMovilP, Label telTrabajoL, TextBox telTrabajo, Panel telTrabajoP,
            Label ocupacionL, TextBox ocupacion, Panel ocupacionP, CheckBox mismaDireccion)
        {

            nombreL.Location = new Point(50, 50);
            nombreP.Location = new Point(215, 50);
            nombreP.Size = new Size(300, 50);

            apellidoPL.Location = new Point(50, 110);
            apellidoPP.Location = new Point(215, 110);
            apellidoPP.Size = new Size(300, 50);

            apellidoML.Location = new Point(50, 170);
            apellidoMP.Location = new Point(215, 170);
            apellidoMP.Size = new Size(300, 50);

            direccion.Location = new Point(650, 45);

            mismaDireccion.Location = new Point(770, 45);
            mismaDireccion.Checked = false;

            calleL.Location = new Point(650, 90);
            calleP.Location = new Point(740, 90);
            calleP.Size = new Size(300, 50);

            numL.Location = new Point(650, 150);
            numP.Location = new Point(740, 150);
            numP.Size = new Size(150, 50);

            coloniaL.Location = new Point(650, 210);
            coloniaP.Location = new Point(740, 210);
            coloniaP.Size = new Size(300, 50);

            infoCon.Location = new Point(50, 250);

            telCasaL.Location = new Point(50, 290);
            telCasaP.Location = new Point(215, 290);
            telCasaP.Size = new Size(150, 50);

            telMovilL.Location = new Point(400, 290);
            telMovilP.Location = new Point(550, 290);
            telMovilP.Size = new Size(150, 50);

            telTrabajoL.Location = new Point(50, 410);
            telTrabajoP.Location = new Point(215, 410);
            telTrabajoP.Size = new Size(150, 50);

            ocupacionL.Location = new Point(50, 350);
            ocupacionP.Location = new Point(215, 350);
            ocupacionP.Size = new Size(300, 50);
        }

        public static void infoMedica(Label servMedicoL, TextBox servMed, Panel servMedP, Label grupoSanL,
            ComboBox grupoSanCB, Label telL, TextBox tel, Panel telP, Label discapacidadL, RichTextBox discapacidad, Panel discapacidadP,
            Label enfermedadL, RichTextBox enfermedad, Panel enfermedadP, Label alergiaL, RichTextBox alergia, Panel alergiaP,
            Label tratamientoL, RichTextBox tratamiento, Panel tratamientoP, ComboBox discapacidadCB, ComboBox enfermedadCB, ComboBox alergiaCB,
            Button eliEnf, Button eliDisc, Button eliAle, Button eliTra,Button agregarDisc, Button agregarEnf, Button agregarAler, Button eliminarDisc, Button eliminarEnf, Button eliminarAler)
        {
            servMedicoL.Location = new Point(50, 50);
            servMedP.Location = new Point(210, 50);
            servMedP.Size = new Size(300, 50);

            grupoSanL.Location = new Point(530, 50);
            grupoSanCB.Location = new Point(700, 50);
            grupoSanCB.Size = new Size(110, 50);

            telL.Location = new Point(830, 50);
            telP.Location = new Point(1030, 50);
            telP.Size = new Size(150, 45);

            discapacidad.ReadOnly = true;
            enfermedad.ReadOnly = true;
            alergia.ReadOnly = true;

            discapacidad.BackColor = Color.White;
            enfermedad.BackColor = Color.White;
            alergia.BackColor = Color.White;

            discapacidadL.Location = new Point(50, 150);
            eliDisc.Location = new Point(290, 150);
            discapacidad.Location = new Point(10, 10);
            discapacidadCB.Location = new Point(72, 340);
            discapacidadP.Location = new Point(50, 180);

            discapacidad.Size = new Size(250, 125);
            discapacidadP.Size = new Size(270, 150);
            discapacidadCB.Size = new Size(212, 60);
            agregarDisc.Size = new Size(25, 25);
            agregarDisc.Location = new Point(292, 342);
            agregarDisc.Text = "";

            eliminarDisc.Size = new Size(25, 25);
            eliminarDisc.Location = new Point(42, 342);
            eliminarDisc.Text = "";

            enfermedadL.Location = new Point(340, 150);
            eliEnf.Location = new Point(580, 150);
            enfermedad.Location = new Point(10, 10);
            enfermedadCB.Location = new Point(364, 340);
            enfermedadP.Location = new Point(340, 180);

            enfermedad.Size = new Size(250, 125);
            enfermedadP.Size = new Size(270, 150);
            enfermedadCB.Size = new Size(210, 60);
            agregarEnf.Size = new Size(25, 25);
            agregarEnf.Location = new Point(582, 342);
            agregarEnf.Text = "";

            eliminarEnf.Size = new Size(25, 25);
            eliminarEnf.Location = new Point(335, 342);
            eliminarEnf.Text = "";

            alergiaL.Location = new Point(630, 150);
            eliAle.Location = new Point(870, 150);
            alergia.Location = new Point(10, 10);
            alergiaCB.Location = new Point(654, 340);
            alergiaP.Location = new Point(630, 180);

            alergia.Size = new Size(250, 125);
            alergiaP.Size = new Size(270, 150);
            alergiaCB.Size = new Size(210, 60);
            agregarAler.Size = new Size(25, 25);
            agregarAler.Location = new Point(872, 342);
            agregarAler.Text = "";

            eliminarAler.Size = new Size(25, 25);
            eliminarAler.Location = new Point(625, 342);
            eliminarAler.Text = "";

            tratamiento.Size = new Size(250, 125);
            tratamientoL.Location = new Point(920, 150);
            eliTra.Location = new Point(1160, 150);
            tratamientoP.Location = new Point(920, 180);
            tratamientoP.Size = new Size(270, 150);
        }

        public static void altasInformacionTutorGroupBox(GroupBox informacionTutor)
        {
            informacionTutor.Location = new Point(300, 250);
            informacionTutor.Size = new Size(1150, 360);
            informacionTutor.Font = new Font("Leelawadee UI", 12);
        }

        public static void altasGroupBox(GroupBox groupBox)
        {
            groupBox.Location = new Point(300, 250);
            groupBox.Size = new Size(1150, 360);
            groupBox.Font = new Font("Leelawadee UI", 12);
        }

        public static void altasGroupBox2(GroupBox groupBox2)
        {
            groupBox2.Location = new Point(300, 620);
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

        public static int altasNombre(Label nombre, Label apellidoP, Label apellidoM, TextBox nombreTB, TextBox apellidoPTB, TextBox apellidoMTB, int distancia)
        {
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

        public static int altasLugarNacimiento(Label titulo, Label ciudad, Label estado, TextBox ciudadTB, TextBox estadoTB, int distancia)
        {
            titulo.Location = new Point(20, distancia);
            ciudad.Location = new Point(240, distancia);
            ciudadTB.Location = new Point(340, distancia);
            estado.Location = new Point(460, distancia);
            estadoTB.Location = new Point(550, distancia);

            titulo.Size = new Size(100, 30);
            ciudad.Size = new Size(100, 30);
            ciudadTB.Size = new Size(100, 30);
            estado.Size = new Size(100, 30);
            estadoTB.Size = new Size(200, 30);

            distancia = distancia + 40;
            return distancia;
        }

        public static int altasDireccion(Label titulo, Label calle, Label numero, Label colonia, TextBox calleTB, TextBox numeroTB, TextBox coloniaTB, int distancia)
        {
            titulo.Location = new Point(20, distancia);
            calle.Location = new Point(150, distancia);
            calleTB.Location = new Point(220, distancia);
            numero.Location = new Point(460, distancia);
            numeroTB.Location = new Point(550, distancia);
            colonia.Location = new Point(660, distancia);
            coloniaTB.Location = new Point(750, distancia);

            titulo.Size = new Size(100, 30);
            calle.Size = new Size(100, 30);
            calleTB.Size = new Size(200, 30);
            numero.Size = new Size(100, 30);
            numeroTB.Size = new Size(100, 30);
            colonia.Size = new Size(100, 30);
            coloniaTB.Size = new Size(200, 30);

            distancia = distancia + 40;
            return distancia;
        }

        public static void altasInformacionEscolar(Label ciclo, Label curp, Label edad, TextBox cicloTB, TextBox curpTB, TextBox edadTB, GroupBox ingreso, RadioButton radioButton1, RadioButton radioButton2)
        {
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

        public static int altasTutorOtroAlumno(GroupBox otroAlumno, Label seleccion, ComboBox tutor, int distancia)
        {

            otroAlumno.Location = new Point(60, distancia);
            otroAlumno.Size = new Size(500, 55);
            distancia = distancia + 70;

            seleccion.Location = new Point(60, distancia);
            seleccion.Size = new Size(180, 30);
            distancia = distancia + 30;

            tutor.Location = new Point(60, distancia);
            tutor.Size = new Size(300, 40);
            distancia = distancia + 80;

            return distancia;
        }

        public static int altasNombreTutor(Label nombre, TextBox nombreTB, Label apellidoP, TextBox apellidoPTB, Label apellidoM, TextBox apellidoMTB, int distancia)
        {

            nombre.Location = new Point(60, distancia);
            nombre.Size = new Size(100, 30);
            nombreTB.Location = new Point(150, distancia - 3);
            nombreTB.Size = new Size(190, 30);

            apellidoP.Location = new Point(360, distancia);
            apellidoP.Size = new Size(100, 30);
            apellidoPTB.Location = new Point(530, distancia - 3);
            apellidoPTB.Size = new Size(130, 30);

            apellidoM.Location = new Point(680, distancia);
            apellidoM.Size = new Size(100, 30);
            apellidoMTB.Location = new Point(850, distancia - 3);
            apellidoMTB.Size = new Size(130, 30);

            distancia = distancia + 40;
            return distancia;
        }

        public static int altasDireccionTutor(Label domicilio, Label calle, TextBox calleTB, Label numero, TextBox numeroTB, Label colonia, TextBox coloniaTB, int distancia)
        {

            domicilio.Location = new Point(60, distancia);
            domicilio.Size = new Size(100, 30);

            calle.Location = new Point(160, distancia);
            calle.Size = new Size(100, 30);
            calleTB.Location = new Point(220, distancia - 3);
            calleTB.Size = new Size(260, 30);

            numero.Location = new Point(500, distancia);
            numero.Size = new Size(100, 30);
            numeroTB.Location = new Point(590, distancia - 3);
            numeroTB.Size = new Size(70, 30);

            colonia.Location = new Point(680, distancia);
            colonia.Size = new Size(100, 30);
            coloniaTB.Location = new Point(770, distancia - 3);
            coloniaTB.Size = new Size(210, 30);

            distancia = distancia + 40;
            return distancia;
        }

        public static int altasOcupacionTutor(Label ocupacion, TextBox ocupacionTB, int distancia)
        {

            ocupacion.Location = new Point(60, distancia);
            ocupacion.Size = new Size(100, 30);
            ocupacionTB.Location = new Point(170, distancia - 3);
            ocupacionTB.Size = new Size(310, 30);

            distancia = distancia + 40;
            return distancia;
        }

        public static int altasTelefonosTutor(Label telefonos, Label casa, TextBox casaTB, Label celular, TextBox celularTB, Label trabajo, TextBox trabajoTB, int distancia)
        {

            telefonos.Location = new Point(60, distancia);
            telefonos.Size = new Size(100, 30);

            casa.Location = new Point(170, distancia);
            casa.Size = new Size(100, 30);
            casaTB.Location = new Point(225, distancia - 3);
            casaTB.Size = new Size(80, 30);

            celular.Location = new Point(315, distancia);
            celular.Size = new Size(100, 30);
            celularTB.Location = new Point(400, distancia - 3);
            celularTB.Size = new Size(80, 30);

            trabajo.Location = new Point(500, distancia);
            trabajo.Size = new Size(100, 30);
            trabajoTB.Location = new Point(580, distancia - 3);
            trabajoTB.Size = new Size(80, 30);

            distancia = distancia + 40;
            return distancia;
        }

        public static void limpiarFormatosBotones(Button formato1, Button formato2, Button formato3)
        {
            formato1.Location = new Point(1115,325);
            formato2.Location = new Point(1115, 415);
            formato3.Location = new Point(1115, 515);

            formato1.Size = new Size(35, 35);
            formato2.Size = new Size(35, 35);
            formato3.Size = new Size(35, 35);

            var tt = new ToolTip();
            tt.SetToolTip(formato1, "LIMPIAR ESPACIOS");
            tt.SetToolTip(formato2, "LIMPIAR ESPACIOS");
            tt.SetToolTip(formato3, "LIMPIAR ESPACIOS");
        }  
    }
}
