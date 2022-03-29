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
            Button regresarMenuButton, Button editarInfoButton, Button cancelarEdicion, Button terminarEdicion)
        {

            logo.Location = new Point(50, 20);
            logo.Size = new Size(150, 148);

            //TITULO PRINCIPAL
            fichaLabel.Location = new Point(530, 50);

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
            terminarEdicion.Location = new Point(1090, 700);

            regresarMenuButton.Size = new Size(300,55);
            editarInfoButton.Size = new Size(250,55);
            cancelarEdicion.Size = new Size(250, 55);
            terminarEdicion.Size = new Size(250, 55);
        }

        public static void infoAlumno(Label nombreAlLabel, TextBox nombreAl, TextBox apellidoP, TextBox apellidoM, Label matriculaLabel, TextBox matricula, Label edadLabel, TextBox edad)
        {
            nombreAl.Size = new Size(220, 40);
            apellidoP.Size = new Size(220, 40);
            apellidoM.Size = new Size(220, 40);
            matricula.Size = new Size(100, 40);
            edad.Size = new Size(50, 40);

            nombreAlLabel.Location = new Point(300, 150);
            nombreAl.Location = new Point(400, 150);
            apellidoP.Location = new Point(630, 150);
            apellidoM.Location = new Point(860, 150);

            matriculaLabel.Location = new Point(300, 220);
            matricula.Location = new Point(400, 220);

            edadLabel.Location = new Point(970, 220);
            edad.Location = new Point(1030, 220);
        }

        public static void infoGeneral(Label fechaNaLabel, DateTimePicker fechaNa, Label lugarNaLabel, TextBox ciudad, TextBox estado,
            Label direccionLabel, TextBox calle, TextBox numero, TextBox colonia, Label curpLabel, TextBox curp, Label telPersonalLabel, TextBox telPersonal)
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
            //
            fechaNaLabel.Location = new Point(50,40);
            fechaNa.Location = new Point(250,40);

            lugarNaLabel.Location = new Point(50,120);
            ciudad.Location = new Point(250,120);
            estado.Location = new Point(510, 120);

            direccionLabel.Location = new Point(50, 210);
            calle.Location = new Point(150, 210);
            numero.Location = new Point(460, 210);
            colonia.Location = new Point(570, 210);

            //
            curpLabel.Location = new Point(790, 40);
            curp.Location = new Point(860, 40);

            telPersonalLabel.Location = new Point(790, 120);
            telPersonal.Location = new Point(970, 120);

        }

        public static void infoEscolar(Label tipoIngresoLabel, TextBox tipoIngreso, Label escuelaPLabel, TextBox escuelaP, Label canalizadoLabel, TextBox canalizado,
            Label cicloEscLabel, TextBox cicloEsc)
        {
            tipoIngreso.Size = new Size(280, 30);
            escuelaP.Size = new Size(350, 30);
            canalizado.Size = new Size(420, 30);
            cicloEsc.Size = new Size(80, 30);

            tipoIngresoLabel.Location = new Point(50, 40);
            tipoIngreso.Location = new Point(210, 40);

            escuelaPLabel.Location = new Point(50, 120);
            escuelaP.Location = new Point(280, 120);

            canalizadoLabel.Location = new Point(50, 210);
            canalizado.Location = new Point(210, 210);

            cicloEscLabel.Location = new Point(860, 40);
            cicloEsc.Location = new Point(990, 40);
        }

        public static void infoTutor(Label nombreL, TextBox nombre, TextBox apellidoP, TextBox apellidoM, Label direccionL, TextBox calle, TextBox numero,
                                    TextBox colonia, Label ocupacionL, TextBox ocupacion, Label telefonos , Label casaL, Label movilL, Label trabajoL, 
                                    TextBox casa, TextBox movil, TextBox trabajo) {
            
            nombre.Size = new Size(220, 40);
            apellidoP.Size = new Size(220, 40);
            apellidoM.Size = new Size(220, 40);

            nombreL.Location = new Point(50, 40);
            nombre.Location = new Point(150, 40);
            apellidoP.Location = new Point(380, 40);
            apellidoM.Location = new Point(610, 40);

            calle.Size = new Size(300, 40);
            numero.Size = new Size(100, 40);
            colonia.Size = new Size(300, 30);
            
            direccionL.Location = new Point(50, 120);
            calle.Location = new Point(150, 120);
            numero.Location = new Point(460, 120);
            colonia.Location = new Point(570, 120);

            ocupacion.Size = new Size(400,40);
            ocupacionL.Location = new Point(50, 210);
            ocupacion.Location = new Point(160, 210);

            telefonos.Location = new Point(1000, 85);
            casaL.Location = new Point(900, 120);
            movilL.Location = new Point(900, 170);
            trabajoL.Location = new Point(900, 220);
            casa.Location = new Point(990, 120);
            movil.Location = new Point(990, 170);
            trabajo.Location = new Point(990, 220);
        }

        public static void infoMedica(Label servicioL, TextBox servicioTB, Label telefonoL, TextBox telefonoTB, Label grupoL, 
                                    TextBox grupoTB,Label discapacidadesL, Label enfermedadesL, Label alergiasL, Label tratamientosL, 
                                    RichTextBox discapacidadesRTB, RichTextBox enfermedadesRTB, RichTextBox alergiasRTB, RichTextBox tratamientosRTB,
                                    Panel discapacidadesP, Panel enfermedadesP, Panel alergiasP, Panel tratamientosP) {

            servicioL.Location = new Point(50, 40);
            telefonoL.Location = new Point(50, 90);
            grupoL.Location = new Point(860, 40);

            servicioTB.Location = new Point(210, 40);
            telefonoTB.Location = new Point(270, 90);
            grupoTB.Location = new Point(1050, 40);

            discapacidadesL.Location = new Point(50, 145);
            enfermedadesL.Location = new Point(320, 145);
            alergiasL.Location = new Point(590, 145);
            tratamientosL.Location = new Point(860, 145);

            discapacidadesRTB.Location = new Point(10,10);
            enfermedadesRTB.Location = new Point(10, 10);
            alergiasRTB.Location = new Point(10, 10);
            tratamientosRTB.Location = new Point(10, 10);

            discapacidadesRTB.Size = new Size(225, 128);
            enfermedadesRTB.Size = new Size(225, 128);
            alergiasRTB.Size = new Size(225, 128);
            tratamientosRTB.Size = new Size(225, 128);

            discapacidadesP.Location = new Point(50, 165);
            discapacidadesP.Size = new Size(240, 150);
            enfermedadesP.Location = new Point(320, 165);
            enfermedadesP.Size = new Size(240, 150);
            alergiasP.Location = new Point(590, 165);
            alergiasP.Size = new Size(240, 150);
            tratamientosP.Location = new Point(860, 165);
            tratamientosP.Size = new Size(240, 150);

        }

        public static void mostrarEditarInformacion(Button regresarMenu, Button editarInfo, Button cancelar, Button terminar, Button añadirFoto, TextBox nombreAl,
                                TextBox apellidoP, TextBox apellidoM, Label edadL, TextBox edad, TextBox ciudadNac, TextBox estadoNac, DateTimePicker fechaNac,
                                TextBox curp, TextBox telefonoP, TextBox calleAl, TextBox numCasaAl, TextBox coloniaAl, TextBox ingreso, TextBox ciclo,
                                TextBox escuela, TextBox canalizado, TextBox nomTutor, TextBox apePTutor, TextBox apeMTutor, TextBox calleTu,
                                TextBox numCasaTu, TextBox colTu, TextBox ocupacion, TextBox telCasa, TextBox telMovil, TextBox telTrabajo,
                                TextBox servicioM, TextBox telContacto, TextBox grupoS, Panel discapacidades, Panel enferemedades,
                                Panel alergias, Panel tratamiento, TableLayoutPanel infoMedica, ComboBox tipoIngresoCB)
        {

            //Mostrar 
            regresarMenu.Visible = false;
            editarInfo.Visible = false;
            cancelar.Visible = true;
            terminar.Visible = true;
            añadirFoto.Visible = true;

            //Posisionar en...
            añadirFoto.Size = new Size(160, 45);
            añadirFoto.Location = new Point(1175, 235);

            //Encabezado
            nombreAl.Enabled = true; apellidoP.Enabled = true; apellidoM.Enabled = true; edad.Visible = false; edadL.Visible = false;

            //Seccion 1
            ciudadNac.Enabled = true; fechaNac.Enabled = true; curp.Enabled = true; telefonoP.Enabled = true;
            calleAl.Enabled = true; numCasaAl.Enabled = true; coloniaAl.Enabled = true;

            //Seccion 2
            ingreso.Visible = true; ciclo.Enabled = true; escuela.Enabled = true; canalizado.Enabled = true;

            //Seccion 3
            nomTutor.Enabled = true; apePTutor.Enabled = true; apePTutor.Enabled = true;
            calleTu.Enabled = true; numCasaTu.Enabled = true; colTu.Enabled = true; ocupacion.Enabled = true;
            telCasa.Enabled = true; telMovil.Enabled = true; telTrabajo.Enabled = true;

            //Seccion 4
            servicioM.Enabled = true; telContacto.Enabled = true; grupoS.Enabled = true;
            discapacidades.Enabled = false; enferemedades.Enabled = false; alergias.Enabled = false; tratamiento.Enabled = false;
            discapacidades.Visible = false; enferemedades.Visible = false; alergias.Visible = false; tratamiento.Visible = false;

            infoMedica.Enabled = true;
            infoMedica.Location = new Point(50, 165);
            infoMedica.Size = new Size(1000, 150);
            infoMedica.Visible = true;

            tipoIngresoCB.Size = new Size(280, 30);
            tipoIngresoCB.Location = new Point(210, 40);
            tipoIngresoCB.Visible = true;

        }

        public static void ocultarEditarInformacion(Button regresarMenu, Button editarInfo, Button cancelar, Button terminar, Button añadirFoto,TextBox  nombreAl, 
                                            TextBox  apellidoP, TextBox  apellidoM, Label edadL, TextBox  edad, TextBox ciudadNac,TextBox estadoNac, DateTimePicker fechaNac,
                                            TextBox  curp, TextBox telefonoP, TextBox  calleAl, TextBox  numCasaAl, TextBox  coloniaAl, TextBox  ingreso, TextBox  ciclo,
                                            TextBox  escuela,TextBox  canalizado, TextBox  nomTutor, TextBox  apePTutor, TextBox  apeMTutor,TextBox  calleTu,
                                            TextBox  numCasaTu,TextBox  colTu, TextBox  ocupacion, TextBox telCasa,TextBox telMovil, TextBox  telTrabajo,                                                     
                                            TextBox  servicioM, TextBox  telContacto, TextBox  grupoS,Panel discapacidades, Panel enferemedades, 
                                            Panel alergias, Panel tratamiento, TableLayoutPanel infoMedica, ComboBox tipoIngresoCB)
        {
            regresarMenu.Visible = true;
            editarInfo.Visible = true;
            cancelar.Visible = false;
            terminar.Visible = false;
            añadirFoto.Visible = false;

            //Encabezado
            nombreAl.Enabled = false; apellidoP.Enabled = false; apellidoM.Enabled = false; edad.Visible = true; edadL.Visible = true;
            
            //Seccion 1
            ciudadNac.Enabled = false; fechaNac.Enabled = false; curp.Enabled = false; telefonoP.Enabled = false;
            calleAl.Enabled = false; numCasaAl.Enabled = false; coloniaAl.Enabled = false;

            //Seccion 2
            ingreso.Visible = true; ciclo.Enabled = false; escuela.Enabled = false; canalizado.Enabled = false;

            //Seccion 3
            nomTutor.Enabled = false; apePTutor.Enabled = false; apePTutor.Enabled = false;
            calleTu.Enabled = false; numCasaTu.Enabled = false; colTu.Enabled = false; ocupacion.Enabled = false;
            telCasa.Enabled = false; telMovil.Enabled = false; telTrabajo.Enabled = false;

            //Seccion 4
            servicioM.Enabled = false; telContacto.Enabled = false; grupoS.Enabled = false;
            discapacidades.Enabled = true; enferemedades.Enabled = true; alergias.Enabled = true; tratamiento.Enabled = true;
            discapacidades.Visible = true; enferemedades.Visible = true; alergias.Visible = true; tratamiento.Visible = true;

            infoMedica.Enabled = false;
            infoMedica.Visible = false;

            tipoIngresoCB.Visible = false;
        }
    }
}
