using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentationLayer
{
    public class PLfichatecnicaAlumno
    {

        public static void centrarLabel(Label fichaLabel, PictureBox logo, Label nombreAlLabel, TextBox nombreAl, Label matriculaLabel, TextBox matricula,
            Label edadLabel, TextBox edad, PictureBox foto, Panel infoGeneralPanel, Panel infoEscolarPanel, Panel infoTutorPanel, Panel infoMedicaPanel, Button infoGeneral, Button infoEscolar, Button infoTutor, Button infoMedica,
            Button regresarMenuButton, Button editarInfoButton, Button cancelarEdicion, Button terminarEdicion, Button bajaAlumno)
        {

            logo.Location = new Point(50, 20);
            logo.Size = new Size(150, 148);

            //TITULO PRINCIPAL
            fichaLabel.Location = new Point(560, 50);

            //Foto
            foto.Size = new Size(160, 180);
            foto.Location = new Point(1175, 50);

            //Botones
            infoGeneral.Size = new Size(285, 50);
            infoGeneral.Location = new Point(200, 300);

            infoEscolar.Size = new Size(285, 50);
            infoEscolar.Location = new Point(485, 300);

            infoTutor.Size = new Size(285, 50);
            infoTutor.Location = new Point(770, 300);

            infoMedica.Size = new Size(285, 50);
            infoMedica.Location = new Point(1055, 300);

            //Paneles
            infoGeneralPanel.Size = new Size(1140, 330);
            infoGeneralPanel.Location = new Point(200, 350);

            infoEscolarPanel.Size = new Size(1140, 330);
            infoEscolarPanel.Location = new Point(200, 350);

            infoTutorPanel.Size = new Size(1140, 330);
            infoTutorPanel.Location = new Point(200, 350);

            infoMedicaPanel.Size = new Size(1140, 330);
            infoMedicaPanel.Location = new Point(200, 350);

            //Botones
            regresarMenuButton.Location = new Point(200, 700);
            editarInfoButton.Location = new Point(1090, 700);
            cancelarEdicion.Location = new Point(200, 700);
            bajaAlumno.Location = new Point(820, 700);
            terminarEdicion.Location = new Point(1090, 700);

            regresarMenuButton.Size = new Size(300,55);
            editarInfoButton.Size = new Size(250,55);
            cancelarEdicion.Size = new Size(250, 55);
            bajaAlumno.Size = new Size(250, 55);
            terminarEdicion.Size = new Size(250, 55);
            
        }

        public static void infoAlumno(Label nombreAlLabel, TextBox nombreAl, TextBox apellidoP, TextBox apellidoM, Label matriculaLabel, TextBox matricula, Label edadLabel, TextBox edad,
            Label nombreL,Label apellidoPL, Label apellidoML, UserControl nombreAlLinea, UserControl apellidoPLinea, UserControl apellidoMLinea)
        {
            nombreAl.Size = new Size(220, 40);
            apellidoP.Size = new Size(220, 40);
            apellidoM.Size = new Size(220, 40);
            matricula.Size = new Size(100, 40);
            edad.Size = new Size(50, 40);

            //Tamaño lineas
            nombreAlLinea.Size = new Size(200, 5);
            apellidoPLinea.Size = new Size(200, 5);
            apellidoMLinea.Size = new Size(200, 5);

            nombreAlLabel.Location = new Point(300, 150);
            nombreAl.Location = new Point(400, 150);
            apellidoP.Location = new Point(630, 150);
            apellidoM.Location = new Point(860, 150);

            //Lineas
            nombreAlLinea.Location = new Point(410, 170);
            apellidoPLinea.Location = new Point(640, 170);
            apellidoMLinea.Location = new Point(870, 170);

            nombreL.Location = new Point(475, 190);
            apellidoPL.Location = new Point(690, 190);
            apellidoML.Location = new Point(915, 190);          

            matriculaLabel.Location = new Point(300, 230);
            matricula.Location = new Point(400, 230);
            matricula.ReadOnly = true;

            edadLabel.Location = new Point(970, 230);
            edad.Location = new Point(1030, 230);
        }

        public static void infoGeneral(Label fechaNaLabel, DateTimePicker fechaNa, Label lugarNaLabel, TextBox ciudad, TextBox estado,
            Label direccionLabel, TextBox calle, TextBox numero, TextBox colonia, Label curpLabel, TextBox curp, Label telPersonalLabel, TextBox telPersonal,
            Label calleAlL, Label numCasaAlL, Label coloniaAlL, Label ciudadAlL, Label estadoAlL,UserControl ciudadLinea, UserControl estadoLinea, UserControl calleAlLinea,
            UserControl numCasaAlLinea,UserControl coloniaAlLinea, UserControl curpLinea, UserControl telPersonalLinea)
        {
            fechaNa.Size = new Size(220, 40);
            //fechaNa.Enabled = false;
            ciudad.Size = new Size(250, 40);
            estado.Size = new Size(250, 40);
            calle.Size = new Size(300, 40);
            numero.Size = new Size(100, 40);
            colonia.Size = new Size(300, 30);
            curp.Size = new Size(230, 40);
            telPersonal.Size = new Size(120, 30);
            //Tamaños de lineas
            ciudadLinea.Size = new Size(250, 5);
            estadoLinea.Size = new Size(250, 5);
            calleAlLinea.Size = new Size(300, 5);
            numCasaAlLinea.Size = new Size(100, 5);
            coloniaAlLinea.Size = new Size(300, 5);
            curpLinea.Size = new Size(230, 5);
            telPersonalLinea.Size = new Size(120, 5);

            fechaNaLabel.Location = new Point(50, 40);
            fechaNa.Location = new Point(250, 40);

            lugarNaLabel.Location = new Point(50, 120);
            ciudad.Location = new Point(250, 120);
            estado.Location = new Point(510, 120);

            ciudadAlL.Location = new Point(350, 160);
            estadoAlL.Location = new Point(610, 160);

            ciudadLinea.Location = new Point(250, 140);
            estadoLinea.Location = new Point(510, 140);

            direccionLabel.Location = new Point(50, 210);
            calle.Location = new Point(150, 210);
            numero.Location = new Point(460, 210);
            colonia.Location = new Point(570, 210);

            calleAlLinea.Location = new Point(150, 230);
            numCasaAlLinea.Location = new Point(460, 230);
            coloniaAlLinea.Location = new Point(570, 230);

            calleAlL.Location = new Point(280, 250);
            numCasaAlL.Location = new Point(485, 250);
            coloniaAlL.Location = new Point(700, 250);


            curpLabel.Location = new Point(790, 40);
            curp.Location = new Point(860, 40);

            curpLinea.Location = new Point(860, 60);

            telPersonalLabel.Location = new Point(790, 120);
            telPersonal.Location = new Point(970, 120);

            telPersonalLinea.Location = new Point(970, 140);

        }

        public static void infoEscolar(Label tipoIngresoLabel, TextBox tipoIngreso, Label escuelaPLabel, TextBox escuelaP, Label canalizadoLabel, TextBox canalizado,
            Label cicloEscLabel, TextBox cicloEsc, UserControl escuelaPLinea, UserControl canalizadoLinea, UserControl cicloEscLinea)
        {
            tipoIngreso.Size = new Size(260, 30);
            escuelaP.Size = new Size(350, 30);
            canalizado.Size = new Size(420, 30);
            cicloEsc.Size = new Size(80, 30);
            escuelaPLinea.Size = new Size(350, 5);
            canalizadoLinea.Size = new Size(420, 5);
            cicloEscLinea.Size = new Size(80, 5);

            tipoIngresoLabel.Location = new Point(50, 40);
            tipoIngreso.Location = new Point(240, 40);

            escuelaPLabel.Location = new Point(50, 120);
            escuelaP.Location = new Point(280, 120);
            escuelaPLinea.Location = new Point(280, 140);

            canalizadoLabel.Location = new Point(50, 210);
            canalizado.Location = new Point(210, 210);
            canalizadoLinea.Location = new Point(210, 230);

            cicloEscLabel.Location = new Point(860, 40);
            cicloEsc.Location = new Point(990, 40);
            cicloEscLinea.Location = new Point(990, 60);
        }

        public static void infoTutor(Label nombreL, TextBox nombre, TextBox apellidoP, TextBox apellidoM, Label direccionL, TextBox calle, TextBox numero,
                                    TextBox colonia, Label ocupacionL, TextBox ocupacion, Label telefonos, Label casaL, Label movilL, Label trabajoL,
                                    TextBox casa, TextBox movil, TextBox trabajo, Label nombreTL, Label apePTL, Label apeMTL, Label calleTL, Label numCasaTL, Label coloniaTL,
                                    UserControl nombreTLinea, UserControl apellidoPLinea, UserControl apellidoMLinea, UserControl calleLinea, UserControl numCasaLinea,
                                    UserControl coloniaLinea, UserControl ocupacionLinea, UserControl telCasaTLinea, UserControl telMovilTLinea, UserControl telTrabajoTLinea)
        {

            nombre.Size = new Size(220, 40);
            apellidoP.Size = new Size(220, 40);
            apellidoM.Size = new Size(220, 40);

            //Tamaños de lineas
            nombreTLinea.Size = new Size(200, 5);
            apellidoPLinea.Size = new Size(200, 5);
            apellidoMLinea.Size = new Size(200, 5);
            calleLinea.Size = new Size(300, 5);
            numCasaLinea.Size = new Size(100, 5);
            coloniaLinea.Size = new Size(300, 5);
            ocupacionLinea.Size = new Size(400,5);
            telCasaTLinea.Size = new Size(120, 5);
            telMovilTLinea.Size = new Size(120, 5);
            telTrabajoTLinea.Size = new Size(120, 5);

            nombreL.Location = new Point(50, 40);
            nombre.Location = new Point(150, 40);
            apellidoP.Location = new Point(380, 40);
            apellidoM.Location = new Point(610, 40);

            //Labels inferiores
            nombreTL.Location = new Point(230, 80);
            apePTL.Location = new Point(440, 80);
            apeMTL.Location = new Point(670, 80);

            nombreTLinea.Location = new Point(160, 60);
            apellidoPLinea.Location = new Point(390, 60);
            apellidoMLinea.Location = new Point(620, 60);

            calle.Size = new Size(300, 40);
            numero.Size = new Size(100, 40);
            colonia.Size = new Size(300, 30);

            direccionL.Location = new Point(50, 120);
            calle.Location = new Point(150, 120);
            numero.Location = new Point(460, 120);
            colonia.Location = new Point(570, 120);

            calleLinea.Location = new Point(150, 140);
            numCasaLinea.Location = new Point(460, 140);
            coloniaLinea.Location = new Point(570, 140);

            calleTL.Location = new Point(280, 160);
            numCasaTL.Location = new Point(485, 160);
            coloniaTL.Location = new Point(700, 160);

            ocupacion.Size = new Size(400, 40);
            ocupacionL.Location = new Point(50, 210);
            ocupacion.Location = new Point(160, 210);
            ocupacionLinea.Location = new Point(160, 230);

            telefonos.Location = new Point(1000, 85);
            casaL.Location = new Point(900, 120);
            movilL.Location = new Point(900, 170);
            trabajoL.Location = new Point(900, 220);

            casa.Location = new Point(990, 120);
            movil.Location = new Point(990, 170);
            trabajo.Location = new Point(990, 220);

            telCasaTLinea.Location = new Point(990, 140);
            telMovilTLinea.Location = new Point(990, 190);
            telTrabajoTLinea.Location = new Point(990, 240);
        }

        public static void infoMedica(Label servicioL, TextBox servicioTB, Label telefonoL, TextBox telefonoTB, Label grupoL, 
                                    TextBox grupoTB,Label discapacidadesL, Label enfermedadesL, Label alergiasL, Label tratamientosL, 
                                    RichTextBox discapacidadesRTB, RichTextBox enfermedadesRTB, RichTextBox alergiasRTB, RichTextBox tratamientosRTB,
                                    Panel discapacidadesP, Panel enfermedadesP, Panel alergiasP, Panel tratamientosP, ComboBox grupoSanComboBox,
                                    UserControl servMedicoLinea, UserControl telefonoLinea,  Button eliDiscapacidad,Button eliEnfermedad,
                                    Button eliAlergia, ComboBox discapacidadesCB, ComboBox enfermedadesCB, ComboBox alergiasCB,
                                    Button agrDiscapacidad, Button agrEnfermedad, Button agrAlergia) {

            servicioL.Location = new Point(50, 40);
            telefonoL.Location = new Point(50, 90);
            grupoL.Location = new Point(860, 40);

            servicioTB.Location = new Point(210, 40);
            telefonoTB.Location = new Point(270, 90);
            grupoTB.Location = new Point(1050, 40);
            grupoSanComboBox.Location = new Point(1050, 40);
            grupoSanComboBox.Size = new Size(60,40);


            servMedicoLinea.Size = new Size(270, 5);
            telefonoLinea.Size = new Size(120, 5);

            servMedicoLinea.Location = new Point(210, 60);
            telefonoLinea.Location = new Point(270, 110);

            discapacidadesL.Location = new Point(50, 130);
            enfermedadesL.Location = new Point(320, 130);
            alergiasL.Location = new Point(590, 130);
            tratamientosL.Location = new Point(860, 130);

            discapacidadesRTB.Location = new Point(10,10);
            enfermedadesRTB.Location = new Point(10, 10);
            alergiasRTB.Location = new Point(10, 10);
            tratamientosRTB.Location = new Point(10, 10);

            discapacidadesRTB.Enabled = true;
            enfermedadesRTB.Enabled = true;
            alergiasRTB.Enabled = true;
            tratamientosRTB.Enabled = true;

            discapacidadesRTB.Size = new Size(230, 110);
            discapacidadesRTB.ReadOnly = true;
            enfermedadesRTB.Size = new Size(230, 110);
            enfermedadesRTB.ReadOnly = true;
            alergiasRTB.Size = new Size(230, 110);
            alergiasRTB.ReadOnly = true;
            tratamientosRTB.Size = new Size(230, 110);
            tratamientosRTB.ReadOnly = true;

            discapacidadesP.Location = new Point(50, 150);
            discapacidadesP.Size = new Size(250, 135);
            enfermedadesP.Location = new Point(320, 150);
            enfermedadesP.Size = new Size(250, 135);
            alergiasP.Location = new Point(590, 150);
            alergiasP.Size = new Size(250, 135);
            tratamientosP.Location = new Point(860, 150);
            tratamientosP.Size = new Size(250, 135);

            eliDiscapacidad.Size = new Size(30, 30);
            eliDiscapacidad.Location = new Point(50, 290);
            eliEnfermedad.Size = new Size(30, 30);
            eliEnfermedad.Location = new Point(320, 290);
            eliAlergia.Size = new Size(30, 30);
            eliAlergia.Location = new Point(590, 290);

            discapacidadesCB.Size = new Size(175, 25);
            discapacidadesCB.Location = new Point(85, 290);
            enfermedadesCB.Size = new Size(175, 25);
            enfermedadesCB.Location = new Point(355, 290);
            alergiasCB.Size = new Size(175, 25);
            alergiasCB.Location = new Point(625, 290);

            agrDiscapacidad.Size = new Size(30, 30);
            agrDiscapacidad.Location = new Point(265, 290);
            agrEnfermedad.Size = new Size(30, 30);
            agrEnfermedad.Location = new Point(535, 290);
            agrAlergia.Size = new Size(30, 30);
            agrAlergia.Location = new Point(805, 290);


        }

        public static void mostrarEditarInformacion(Button regresarMenu, Button editarInfo, Button cancelar, Button terminar, Button bajaAlumno, Button añadirFoto, TextBox nombreAl,
                                TextBox apellidoP, TextBox apellidoM, Label edadL, TextBox edad, TextBox ciudadNac, TextBox estadoNac, DateTimePicker fechaNac,
                                TextBox curp, TextBox telefonoP, TextBox calleAl, TextBox numCasaAl, TextBox coloniaAl, TextBox ingreso, TextBox ciclo,
                                TextBox escuela, TextBox canalizado, TextBox nomTutor, TextBox apePTutor, TextBox apeMTutor, TextBox calleTu,
                                TextBox numCasaTu, TextBox colTu, TextBox ocupacion, TextBox telCasa, TextBox telMovil, TextBox telTrabajo,
                                TextBox servicioM, TextBox telContacto, TextBox grupoS, Panel discapacidades, Panel enferemedades,
                                Panel alergias, Panel tratamiento, RichTextBox tratamientosRTB, ComboBox tipoIngresoCB, ComboBox grupoSan,
                                Label nombreTL, Label apePTL, Label apeMTL, Label calleTL, Label numCasaTL, Label coloniaTL,
                                Label calleAlL, Label numCasaAlL, Label coloniaAlL, Label ciudadAlL, Label estadoAlL,Label nombreL, Label apellidoPL, Label apellidoML,
                                UserControl nombreAlLinea, UserControl apellidoPLinea, UserControl apellidoMLinea, UserControl ciudadLinea,UserControl estadoLinea,
                                UserControl calleAlLinea,UserControl numCasaAlLinea, UserControl coloniaAlLinea, UserControl curpLinea, UserControl telPersonalLinea,
                                UserControl escuelaPLinea, UserControl canalizadoLinea, UserControl cicloEscLinea, UserControl nombreTLinea, UserControl apellidoPTLinea, UserControl apellidoMTLinea,
                                UserControl calleLinea, UserControl numCasaLinea, UserControl coloniaLinea, UserControl ocupacionLinea, UserControl telCasaTLinea,
                                UserControl telMovilTLinea, UserControl telTrabajoTLinea, UserControl servMedicoLinea, UserControl telefonoLinea,
                                Button eliDiscapacidad,Button eliEnfermedad, Button eliAlergia, ComboBox discapacidadesCB, ComboBox enfermedadesCB, ComboBox alergiasCB,
                                Button agrDiscapacidad, Button agrEnfermedad, Button agrAlergia)
        {

            //Mostrar 
            regresarMenu.Visible = false;
            editarInfo.Visible = false;
            cancelar.Visible = true;
            terminar.Visible = true;
            añadirFoto.Visible = true;
            bajaAlumno.Visible = false;

            //Posisionar en...
            añadirFoto.Size = new Size(160, 45);
            añadirFoto.Location = new Point(1175, 235);

            //Encabezado
            nombreAl.ReadOnly = false; apellidoP.ReadOnly = false; apellidoM.ReadOnly = false; edad.Visible = false; edadL.Visible = false;
            nombreL.Visible = true; apellidoPL.Visible = true; apellidoML.Visible = true;
            nombreAlLinea.Visible = true; apellidoPLinea.Visible = true; apellidoMLinea.Visible = true;

            //Seccion 1
            ciudadNac.ReadOnly = false; estadoNac.ReadOnly = false; fechaNac.Enabled = true; curp.ReadOnly = false; telefonoP.ReadOnly = false;
            ciudadAlL.Visible = true; estadoAlL.Visible = true;
            calleAl.ReadOnly = false; numCasaAl.ReadOnly = false; coloniaAl.ReadOnly = false;
            calleAlL.Visible = true; numCasaAlL.Visible = true; coloniaAlL.Visible = true;
            ciudadLinea.Visible = true; estadoLinea.Visible = true;
            calleAlLinea.Visible = true; numCasaAlLinea.Visible = true; coloniaAlLinea.Visible = true;
            curpLinea.Visible = true; telPersonalLinea.Visible = true;

            //Seccion 2
            ingreso.Visible = true; ciclo.ReadOnly = false; escuela.ReadOnly = false; canalizado.ReadOnly = false;
            tipoIngresoCB.Visible = false;
            escuelaPLinea.Visible = true; canalizadoLinea.Visible = true; cicloEscLinea.Visible = true;

            //Seccion 3
            nomTutor.ReadOnly = false; apePTutor.ReadOnly = false; apeMTutor.ReadOnly = false;
            calleTu.ReadOnly = false; numCasaTu.ReadOnly = false; colTu.ReadOnly = false; ocupacion.ReadOnly = false;
            telCasa.ReadOnly = false; telMovil.ReadOnly = false; telTrabajo.ReadOnly = false;
            nombreTL.Visible = true; apePTL.Visible = true; apeMTL.Visible = true; calleTL.Visible = true; numCasaTL.Visible = true; coloniaTL.Visible = true;
            nombreTLinea.Visible = true; apellidoPTLinea.Visible = true; apellidoMTLinea.Visible = true;
            calleLinea.Visible = true; numCasaLinea.Visible = true; coloniaLinea.Visible = true; ocupacionLinea.Visible = true;
            telCasaTLinea.Visible = true; telMovilTLinea.Visible = true; telTrabajoTLinea.Visible = true;

            //Seccion 4
            servicioM.ReadOnly = false; telContacto.ReadOnly = false; grupoS.Visible = false; grupoSan.Visible = true; ;
            servMedicoLinea.Visible = true; telefonoLinea.Visible = true;


            tipoIngresoCB.Size = new Size(230, 40);
            tipoIngresoCB.Location = new Point(240, 40);
            tipoIngresoCB.Visible = true;

            eliEnfermedad.Visible = true; eliDiscapacidad.Visible = true; eliAlergia.Visible = true;
            enfermedadesCB.Visible = true; discapacidadesCB.Visible = true; alergiasCB.Visible = true;
            tratamientosRTB.ReadOnly = false;
            agrEnfermedad.Visible = true; agrDiscapacidad.Visible = true; agrAlergia.Visible = true;

        }

        public static void ocultarEditarInformacion(Button regresarMenu, Button editarInfo, Button cancelar, Button terminar, Button bajaAlumno, Button añadirFoto, TextBox nombreAl,
                                            TextBox apellidoP, TextBox apellidoM, Label edadL, TextBox edad, TextBox ciudadNac, TextBox estadoNac, DateTimePicker fechaNac,
                                            TextBox curp, TextBox telefonoP, TextBox calleAl, TextBox numCasaAl, TextBox coloniaAl, TextBox ingreso, TextBox ciclo,
                                            TextBox escuela, TextBox canalizado, TextBox nomTutor, TextBox apePTutor, TextBox apeMTutor, TextBox calleTu,
                                            TextBox numCasaTu, TextBox colTu, TextBox ocupacion, TextBox telCasa, TextBox telMovil, TextBox telTrabajo,
                                            TextBox servicioM, TextBox telContacto, TextBox grupoS, Panel discapacidades, Panel enferemedades,
                                            Panel alergias, Panel tratamiento, RichTextBox tratamientosRTB,  ComboBox tipoIngresoCB, ComboBox grupoSan,
                                            Label nombreTL, Label apePTL, Label apeMTL, Label calleTL, Label numCasaTL, Label coloniaTL,
                                            Label calleAlL, Label numCasaAlL, Label coloniaAlL, Label ciudadAlL, Label estadoAlL, Label nombreL, Label apellidoPL, Label apellidoML,
                                            UserControl nombreAlLinea, UserControl apellidoPLinea, UserControl apellidoMLinea, UserControl ciudadLinea, UserControl estadoLinea,
                                            UserControl calleAlLinea,UserControl numCasaAlLinea, UserControl coloniaAlLinea, UserControl curpLinea, UserControl telPersonalLinea,
                                            UserControl escuelaPLinea, UserControl canalizadoLinea, UserControl cicloEscLinea, UserControl nombreTLinea, UserControl apellidoPTLinea, 
                                            UserControl apellidoMTLinea, UserControl calleLinea, UserControl numCasaLinea, UserControl coloniaLinea, UserControl ocupacionLinea,
                                            UserControl telCasaTLinea, UserControl telMovilTLinea, UserControl telTrabajoTLinea, UserControl servMedicoLinea, UserControl telefonoLinea,
                                            Button eliDiscapacidad,Button eliEnfermedad, Button eliAlergia, ComboBox discapacidadesCB, ComboBox enfermedadesCB, ComboBox alergiasCB,
                                            Button agrDiscapacidad, Button agrEnfermedad, Button agrAlergia)
        {
            regresarMenu.Visible = true;
            editarInfo.Visible = true;
            cancelar.Visible = false;
            terminar.Visible = false;
            añadirFoto.Visible = false;
            bajaAlumno.Visible = true;

            //Encabezado
            nombreAl.Enabled = true; apellidoP.Enabled = true; apellidoM.Enabled = true; edad.Visible = true; edadL.Visible = true;
            nombreAl.ReadOnly = true; apellidoP.ReadOnly = true; apellidoM.ReadOnly = true; edad.ReadOnly = true;
            nombreL.Visible = false; apellidoPL.Visible = false; apellidoML.Visible = false;
            nombreAlLinea.Visible = false; apellidoPLinea.Visible = false; apellidoMLinea.Visible = false;

            //Seccion 1
            ciudadNac.Enabled = true; fechaNac.Enabled = false; curp.Enabled = true; telefonoP.Enabled = true;
            ciudadNac.ReadOnly = true; curp.ReadOnly = true; telefonoP.ReadOnly = true;
            estadoNac.Enabled = true; estadoNac.ReadOnly = true;
            ciudadAlL.Visible = false; estadoAlL.Visible = false;
            calleAl.Enabled = true; numCasaAl.Enabled = true; coloniaAl.Enabled = true;
            calleAl.ReadOnly = true; numCasaAl.ReadOnly = true; coloniaAl.ReadOnly = true;
            calleAlL.Visible = false; numCasaAlL.Visible = false; coloniaAlL.Visible = false;
            ciudadLinea.Visible = false; estadoLinea.Visible = false;
            calleAlLinea.Visible = false; numCasaAlLinea.Visible = false; coloniaAlLinea.Visible = false;
            curpLinea.Visible = false; telPersonalLinea.Visible = false;

            //Seccion 2
            ingreso.Enabled = true; ciclo.Enabled = true; escuela.Enabled = true; canalizado.Enabled = true;
            ingreso.ReadOnly = true; ciclo.ReadOnly = true; escuela.ReadOnly = true; canalizado.ReadOnly = true;
            escuelaPLinea.Visible = false; canalizadoLinea.Visible = false; cicloEscLinea.Visible = false;

            //Seccion 3
            nomTutor.Enabled = true; apePTutor.Enabled = true; apeMTutor.Enabled = true;
            nomTutor.ReadOnly = true; apePTutor.ReadOnly = true; apeMTutor.ReadOnly = true;
            calleTu.Enabled = true; numCasaTu.Enabled = true; colTu.Enabled = true; ocupacion.Enabled = true;
            calleTu.ReadOnly = true; numCasaTu.ReadOnly = true; colTu.ReadOnly = true; ocupacion.ReadOnly = true;
            telCasa.Enabled = true; telMovil.Enabled = true; telTrabajo.Enabled = true;
            telCasa.ReadOnly = true; telMovil.ReadOnly = true; telTrabajo.ReadOnly = true;
            nombreTL.Visible = false; apePTL.Visible = false; apeMTL.Visible = false; calleTL.Visible = false; numCasaTL.Visible = false; coloniaTL.Visible = false;
            nombreTLinea.Visible = false; apellidoPTLinea.Visible = false; apellidoMTLinea.Visible = false;
            calleLinea.Visible = false; numCasaLinea.Visible = false; coloniaLinea.Visible = false; ocupacionLinea.Visible = false;
            telCasaTLinea.Visible = false; telMovilTLinea.Visible = false; telTrabajoTLinea.Visible = false;

            //Seccion 4
            servicioM.Enabled = true; telContacto.Enabled = true; grupoS.Enabled = true; grupoS.Visible = true;
            servicioM.ReadOnly = true; telContacto.ReadOnly = true; grupoS.ReadOnly = true; grupoSan.Visible = false;
            discapacidades.Visible = true; enferemedades.Visible = true; alergias.Visible = true; tratamiento.Visible = true;
            servMedicoLinea.Visible = false; telefonoLinea.Visible = false;

            tipoIngresoCB.Visible = false;
            tratamientosRTB.ReadOnly = true;
            eliEnfermedad.Visible = false; eliDiscapacidad.Visible = false; eliAlergia.Visible = false;
            enfermedadesCB.Visible = false; discapacidadesCB.Visible = false; alergiasCB.Visible = false;
            agrEnfermedad.Visible = false; agrDiscapacidad.Visible = false; agrAlergia.Visible = false;
        }
    }
}