using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public partial class altaAlumno : Form
    {
        public altaAlumno()
        {
 
            InitializeComponent();
            loaddata();
            
           
            //CODIGO NUEVO
            centrarLabel(altaalumnoLabel,infoTutorLabel, informacionMedLabel,logo, infGeneralAlLabel,informacionGeneralAlumno,
                informacionGeneralAlumno2,informacionTutor,informacionMedicaAlumnoGroupBox);

            infoGen(nombreAlLabel, nombreAl, nombreAlPanel, apellidoPLabel, apellidoP, apellidoPPanel, apellidoMLabel, apellidoM, apellidoMPanel, fechaNaLabel, fechaNa, añosCumLabel, 
                añosCum,añosCumPanel, curpLabel,curp,curpPanel, direccionAlumnoLabel,calleLabel, calle,callePanel, numeroCasaLabel, numeroCasa,numeroCasaPanel, coloniaLabel,colonia,coloniaPanel,lugarNaLabel,
                ciudadLabel,ciudad,ciudadPanel,estadoLabel,estado,estadoPanel,fotoAl,fotoBtn);

            infoGen2(telPersonalLabel, telPersonal,telPersonalPanel, escuelaPLabel, escuelaP,escuelaPPanel, canalizadoLabel, canalizado,canalizadoPanel, cicloEscLabel, cicloEsc,cicloEscPanel,tipoIngLabel,
                tipoIngresoGroupBox);

<<<<<<< HEAD
            infoTutor(nombreTLabel, nombreT, nombreTPanel, apellidoPTLabel, apellidoPT, apellidoPTPanel, apellidoMTLabel, apellidoMT, apellidoMTPanel, direccionTLabel,
                calleTLabel, calleT, calleTPanel, numeroCasaTLabel,
                numeroCasaT, numeroCasaTPanel, coloniaTLabel, coloniaT, coloniaTPanel, infContactoLabel, telCasaTLabel, telCasaT, telCasaTPanel, telMovilTLabel, telMovilT, telMovilTPanel,
                telTrabajoTLabel, telTrabajoT, telTrabajoTPanel, ocupacionLabel, ocupacion, ocupacionTPanel);

            infoMedica(servMedicoLabel, servMedico, servMedicoPanel, grupoSanguineoLabel, grupoSanguineo, grupoSanguineoPanel, telefonoLabel,
                telefono, telefonoPanel, discapacidadLabel, discapacidad, discapacidadPanel, enfermedadesLabel, enfermedades, enfermedadesPanel,
                alergiasLabel, alergias, alergiasPanel, tratamientoLabel, tratamiento, tratamientoPanel, eliminarTratamientoButton, discapacidadesCombobox, enfermedadesCombobox, alergiasCombobox,
=======
            infoTutor(nombreTLabel, nombreT,nombreTPanel, apellidoPTLabel, apellidoPT,apellidoPTPanel, apellidoMTLabel, apellidoMT,apellidoMTPanel, direccionTLabel, 
                calleTLabel, calleT,calleTPanel, numeroCasaTLabel,
                numeroCasaT,numeroCasaTPanel, coloniaTLabel, coloniaT,coloniaTPanel, infContactoLabel,telCasaTLabel,telCasaT,telCasaTPanel,telMovilTLabel,telMovilT,telMovilTPanel,
                telTrabajoTLabel,telTrabajoT,telTrabajoTPanel,ocupacionLabel,ocupacion,ocupacionTPanel, direccionCheckBox);

            infoMedica(servMedicoLabel, servMedico,servMedicoPanel, grupoSanguineoLabel, grupoSanguineo,grupoSanguineoPanel, grupoSanguineoComboBox, telefonoLabel,
                telefono,telefonoPanel,discapacidadLabel,discapacidad,discapacidadPanel,enfermedadesLabel, enfermedades,enfermedadesPanel,
                alergiasLabel, alergias,alergiasPanel,tratamientoLabel,tratamiento,tratamientoPanel, eliminarTratamientoButton,discapacidadesCombobox,enfermedadesCombobox,alergiasCombobox,
>>>>>>> Claudia-20-03-22
                eliminarDiscapacidadesButton,
                eliminarEnfermedadButton,eliminarAlergiasButton);

            informacionGeneralAlumno.Visible = true;
            informacionGeneralAlumno2.Visible = false;
            informacionTutor.Visible = false;
            informacionMedicaAlumnoGroupBox.Visible = false;

            altaalumnoLabel.Visible = true;
            infGeneralAlLabel.Visible = true;
            infoTutorLabel.Visible = false;
            informacionMedLabel.Visible = false;

            regresarMenuButton.Visible = true;
            regresarButton.Visible = false;
            siguiente1Button.Visible = true;
            siguiente2Button.Visible = false;
            siguiente3Button.Visible = false;
            realizarAltaButton.Visible = false;


            altasBotonesParaNavegar(siguiente1Button, siguiente2Button, siguiente3Button, regresarButton, realizarAltaButton, regresarMenuButton);
            
        }

        //CENTRAR TITULO
        private void centrarLabel(Label nomLabel, Label infoTutorL, Label infoMedLabel, PictureBox logo, Label infGenLabel, GroupBox infoGeneral, 
            GroupBox infoGeneral2, GroupBox infoTutor, GroupBox infoMedica)
        {
            //tamaño pantalla
            
            logo.Location = new Point(50, 20);

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
        private void infoGen(Label nombreL, TextBox nombre, Panel nombreP, Label apellidoPL, TextBox apellidoP, Panel apellidoPP, Label apellidoML, 
            TextBox apellidoM, Panel apellidoMP,
            Label fechaNaL, DateTimePicker fechaNa, Label añosCumL, TextBox añosCum, Panel añosCumP, Label curpL, TextBox curp, Panel curpP,
            Label direccion, Label calleL,
            TextBox calle, Panel calleP, Label numL, TextBox num, Panel numP, Label coloniaL, TextBox colonia, Panel coloniaP, Label lugarNa,
            Label ciudadL, TextBox ciudad, Panel ciudadP, Label estadoL, TextBox estado, Panel estadoP, PictureBox foto, Button fotoB)
        {

            foto.Location = new Point(1000,50);
            foto.Size = new Size(200, 220);
            fotoB.Location = new Point(1000, 285);
            fotoB.Size = new Size(200, 45);
            fotoB.Font = new Font("Gadugi", 14);

            nombreL.Location = new Point(50, 50);
            nombreP.Location = new Point(260, 50);
            nombreP.Size = new Size(300,45);
            //nombreP.Padding = new Padding(2,2,2,2);

            apellidoPL.Location = new Point(50,110);
            apellidoPP.Location = new Point(260,110);
            apellidoPP.Size = new Size(300, 45);

            apellidoML.Location = new Point(50,170);
            apellidoMP.Location = new Point(260,170);
            apellidoMP.Size = new Size(300, 45);

            fechaNaL.Location = new Point(50,230);
            fechaNa.Location = new Point(260,230);

            añosCumL.Location = new Point(50,290);
            añosCumP.Location = new Point(260,290);
            añosCumP.Size = new Size(150, 45);

            curpL.Location = new Point(50,350);
            curpP.Location = new Point(260,350);
            curpP.Size = new Size(300, 45);

            //DIRECCION
            direccion.Location = new Point(650, 50);

            calleL.Location = new Point(650,110);
            calleP.Location = new Point(740,110);
            calleP.Size = new Size(240, 45);

            numL.Location = new Point(650,170);
            numP.Location = new Point(740,170);
            numP.Size = new Size(150, 45);

            coloniaL.Location = new Point(650,230);
            coloniaP.Location = new Point(740,230);
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
        private void infoGen2(Label telL, TextBox tel, Panel telP, Label escuelaPL, TextBox escuelaP, Panel escuelaPP, Label canalizadoL, TextBox canalizado, Panel canalizadoP, Label cicloL,
            TextBox ciclo, Panel cicloP, Label tipoIng,GroupBox ingresos)
        {
            telL.Location = new Point(50, 50);
            telP.Location = new Point(280, 50);
            telP.Size = new Size(150, 45);

            escuelaPL.Location = new Point(50,110);
            escuelaPP.Location = new Point(280,110);
            escuelaPP.Size = new Size(250, 45);

            canalizadoL.Location = new Point(50,170);
            canalizadoP.Location = new Point(280,170);
            canalizadoP.Size = new Size(250, 45);

            cicloL.Location = new Point(50,230);
            cicloP.Location = new Point(280,230);
            cicloP.Size = new Size(150, 45);

            tipoIng.Location = new Point(50,290);

            ingresos.Location = new Point(50, 330);
        }

        //INFORMACION TUTOR
        private void infoTutor(Label nombreL, TextBox nombre, Panel nombreP, Label apellidoPL, TextBox apellidoP, Panel apellidoPP,
            Label apellidoML, TextBox apellidoM,Panel apellidoMP,
            Label direccion, Label calleL, TextBox calle, Panel calleP, Label numL, TextBox num, Panel numP, Label coloniaL, TextBox colonia, Panel coloniaP, 
            Label infoCon, Label telCasaL,
<<<<<<< HEAD
            TextBox telCasa, Panel telCasaP, Label telMovilL, TextBox telMovil, Panel telMovilP, Label telTrabajoL, TextBox telTrabajo, Panel telTrabajoP,
            Label ocupacionL, TextBox ocupacion, Panel ocupacionP)
=======
            TextBox telCasa, Panel telCasaP, Label telMovilL, TextBox telMovil, Panel telMovilP, Label telTrabajoL, TextBox telTrabajo, Panel telTrabajoP, 
            Label ocupacionL, TextBox ocupacion, Panel ocupacionP, CheckBox mismaDireccion)
>>>>>>> Claudia-20-03-22
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

<<<<<<< HEAD
            calleL.Location = new Point(650, 90);
=======
            mismaDireccion.Location = new Point(770, 45);
            mismaDireccion.Checked = false;

           calleL.Location = new Point(650, 90);
>>>>>>> Claudia-20-03-22
            calleP.Location = new Point(740, 90);
            calleP.Size = new Size(300, 50);

            numL.Location = new Point(650, 150);
            numP.Location = new Point(740, 150);
            numP.Size = new Size(150, 50);

            coloniaL.Location = new Point(650, 210);
            coloniaP.Location = new Point(740, 210);
            coloniaP.Size = new Size(300, 50);

            infoCon.Location = new Point(50,250);

            telCasaL.Location = new Point(50,290 );
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

        //INFORMACION MEDICA
        private void infoMedica(Label servMedicoL, TextBox servMed, Panel servMedP, Label grupoSanL, TextBox grupoSan, Panel grupoSanP,
            Label telL, TextBox tel, Panel telP, Label discapacidadL, RichTextBox discapacidad, Panel discapacidadP,
            Label enfermedadL, RichTextBox enfermedad, Panel enfermedadP, Label alergiaL, RichTextBox alergia, Panel alergiaP,
            Label tratamientoL, RichTextBox tratamiento, Panel tratamientoP,Button eliTra,
            ComboBox discapacidadCB, ComboBox enfermedadCB, ComboBox alergiaCB,Button eliDisc, Button eliEnf, Button eliAle)
        {
            servMedicoL.Location = new Point(50, 50);
            servMedP.Location = new Point(210,50);
            servMedP.Size = new Size(300, 50);

            grupoSanL.Location = new Point(530, 50);
            grupoSanP.Location = new Point(700, 50);
            grupoSanP.Size = new Size(110, 50);

            telL.Location = new Point(830, 50);
            telP.Location = new Point(1030, 50);
            telP.Size = new Size(150, 45);

            discapacidadL.Location = new Point(50, 150);
            eliDisc.Location = new Point(290,150);
            discapacidad.Location = new Point(50, 170);
            discapacidadCB.Location = new Point(50, 340);
            discapacidadP.Location = new Point(50, 180);
            discapacidadP.Size = new Size(270, 150);
            discapacidadCB.Size = new Size(270, 60);

            enfermedadL.Location = new Point(340, 150);
            eliEnf.Location = new Point(580,150);
            enfermedad.Location = new Point(340, 210);
            enfermedadCB.Location = new Point(340, 340);
            enfermedadP.Location = new Point(340, 180);
            enfermedadP.Size = new Size(270, 150);
            enfermedadCB.Size = new Size(270, 60);

            alergiaL.Location = new Point(630, 150);
            eliAle.Location = new Point(870,150);
            alergia.Location = new Point(630, 210);
            alergiaCB.Location = new Point(630, 340);
            alergiaP.Location = new Point(630, 180);
            alergiaP.Size = new Size(270, 150);
            alergiaCB.Size = new Size(270, 60);

            tratamientoL.Location = new Point(920, 150);
            eliTra.Location = new Point(1160,150);
            tratamientoP.Location = new Point(920, 180);
            tratamientoP.Size = new Size(270, 150);
        }

        private void altaAlumno_Load(object sender, EventArgs e)
        {
            limpiarFormato1Button.Hide();
            limpiarFormato2Button.Hide();
            limpiarFormato3Button.Hide();

            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        private void cerrarForm(object sender, EventArgs e)
        {
            ConsultaAlumno formConsultas = new ConsultaAlumno();
            this.Hide();
            formConsultas.Show();
        }


        private void guardarButton_Click(object sender, EventArgs e)
        {
            /*if (!nombreAl.Text.Equals("") && !apellidoP.Text.Equals("") && !apellidoM.Text.Equals(""))
            {
                MessageBox.Show("REGISTRO EXITOSO!");
                businessLayer.Hueso.SetAlumno(cicloEsc.Text,
                                              nombreAl.Text,
                                              apellidoP.Text,
                                              apellidoM.Text,
                                              fechaNa.Value,
                                              añosCum.Text,
                                              curp.Text,
                                              estado.Text,
                                              ciudad.Text,
                                              colonia.Text,
                                              calle.Text,
                                              numeroCasa.Text,
                                              telPersonal.Text,
                                              escuelaP.Text,
                                              canalizado.Text
                                              );

                //businessLayer.Hueso.SetTutor(nombreT.Text,apellidoPT.Text,apellidoMT.Text,coloniaT.Text,calleT.Text,numeroCasaT.Text,ocupacion.Text);
                //businessLayer.Hueso.SetinfoMedAlumno(servMedico.Text,grupoSanguineo.Text,telefono.Text);

                this.Hide();
                Consultas consultas = new Consultas();
                consultas.Show();
                
            }
            else
            {
                MessageBox.Show("NO PUEDES CREAR UN REGISTRO SIN NOMBRE COMPLETO DEL ALUMNO!");
            }*/
        }

        public void altasBotonesParaNavegar(Button siguiente1, Button siguiente2, Button siguiente3, Button regresar, Button guardar, Button regresarMenu)
        {
            siguiente1.Location = new Point(1215, 700);
            siguiente2.Location = new Point(1215, 700);
            siguiente3.Location = new Point(1215, 700);
            regresar.Location = new Point(180, 700);
            regresarMenu.Location = new Point(180, 700);
            guardar.Location = new Point(1215, 700);

            siguiente1.Size = new Size(180, 75);
            siguiente2.Size = new Size(180, 75);
            siguiente3.Size = new Size(180, 75);
            regresar.Size = new Size(180, 75);
            regresarMenu.Size = new Size(180, 75);
            guardar.Size = new Size(180, 75);

            siguiente1.Font = new Font("Gadugi", 14);
            siguiente2.Font = new Font("Gadugi", 14);
            siguiente3.Font = new Font("Gadugi", 14);
            regresarMenu.Font = new Font("Gadugi", 14);
            regresar.Font = new Font("Gadugi", 14);
            guardar.Font = new Font("Gadugi", 14);
        }


        private void alumnosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaAlumno formConsulta = new ConsultaAlumno();
            formConsulta.Show();
        }

        //AGREGAR ENFERMEDADES AL RICHTXTBOX
        private void agregarEnfermedadesButton_Click(object sender, EventArgs e)
        {
            string informacion = this.enfermedadesCombobox.GetItemText(this.enfermedadesCombobox.SelectedItem);
            enfermedades.Text = enfermedades.Text+ informacion + "\n";

        }

        //AGREGAR DISCAPACIDADES AL RICHTXTBOX
        private void agregarDiscapacidadButton_Click(object sender, EventArgs e)
        {
            string informacion = this.discapacidadesCombobox.GetItemText(this.discapacidadesCombobox.SelectedItem);
            discapacidad.Text = discapacidad.Text + informacion + "\n";

        }

        //AGREGAR ALERGIAS AL RICHTXTBOX
        private void agregarAlergiasButton_Click(object sender, EventArgs e)
        {

            string informacion = this.alergiasCombobox.GetItemText(this.alergiasCombobox.SelectedItem);
            alergias.Text = alergias.Text + informacion + "\n";

        }

        //LIMPIAR INFORMACIÓN GENERAL ALUMNO
        private void limpiarFormato1Button_Click(object sender, EventArgs e)
        {
            nombreAl.Clear();
            apellidoP.Clear();
            apellidoM.Clear();
            fechaNa.ResetText();
            ciudad.Clear();
            estado.Clear();
            calle.Clear();
            numeroCasa.Clear();
            colonia.Clear();
            telPersonal.Clear();
            escuelaP.Clear();
            canalizado.Clear();
            cicloEsc.Clear();
            curp.Clear();
            añosCum.Clear();
            nuevoIngreso.Checked = false;
            reingreso.Checked = false;

        }

        //LIMPIAR INFORMACIÓN TUTORA/RA
        private void limpiarFormato2Button_Click(object sender, EventArgs e)
        {
            nombreT.Clear();
            apellidoPT.Clear();
            apellidoMT.Clear();
            calleT.Clear();
            numeroCasaT.Clear();
            coloniaT.Clear();
            ocupacion.Clear();
            telCasaT.Clear();
            telMovilT.Clear();
            telTrabajoT.Clear();
        }

        //LIMPIAR INFORMACIÓN MEDICA ALUMNO
        private void limpiarFormato3Button_Click(object sender, EventArgs e)
        {
            servMedico.Clear();
        
            telefono.Clear();
            grupoSanguineo.Clear();
            //documentacionListBox.SetItemChecked = false; *CLAUDIA CAMBIARÁ ESTO POR UN CONJUNTO DE CHECKBUTTONS*
        }

        //LIMPIAR DISCAPACIDADES
        private void eliminarDiscapacidadesButton_Click(object sender, EventArgs e)
        {
            discapacidad.Clear();
        }

        //LIMPIAR ENFERMEDADES
        private void eliminarEnfermedadButton_Click(object sender, EventArgs e)
        {
            enfermedades.Clear();
        }

        //LIMPIAR ALERGIAS
        private void eliminarAlergiasButton_Click(object sender, EventArgs e)
        {
            alergias.Clear();
        }

        //FILLCOMBOBOX METODO PARA ALERGIAS, ENFERMEDADES Y DISCAPACIDADES
        private void loaddata()
        {

            foreach (var item in businessLayer.BLEliminacionAlumno.alergiasGet())
            {
                alergiasCombobox.Items.Add(item.alergia);
            }
            foreach (var item2 in businessLayer.BLEliminacionAlumno.enfermedadesGet())
            {
                enfermedadesCombobox.Items.Add(item2.enfermedad);
            }
            foreach (var item3 in businessLayer.BLEliminacionAlumno.discapacidadesGet())
            {
                discapacidadesCombobox.Items.Add(item3.discapacidades);
            }

        }

        private void regresarButton_Click_1(object sender, EventArgs e)
        {
            if (informacionGeneralAlumno2.Visible == true) {

                informacionGeneralAlumno.Visible = true;
                informacionGeneralAlumno2.Visible = false;

                regresarMenuButton.Visible = true;
                regresarButton.Visible = false;

                siguiente1Button.Visible = true;
                siguiente2Button.Visible = false;
            }
            if (informacionTutor.Visible == true){

                informacionGeneralAlumno2.Visible = true;
                informacionTutor.Visible = false;

                infGeneralAlLabel.Visible = true;
                infoTutorLabel.Visible = false;

                siguiente2Button.Visible = true;
                siguiente3Button.Visible = false;
            }
            if (informacionMedicaAlumnoGroupBox.Visible == true) {

                informacionTutor.Visible = true;
                informacionMedicaAlumnoGroupBox.Visible = false;

                infoTutorLabel.Visible = true;
                informacionMedLabel.Visible = false;

                siguiente3Button.Visible = true;
                realizarAltaButton.Visible = false;
            }
        }

        private void regresarMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaAlumno formConsulta = new ConsultaAlumno();
            formConsulta.Show();
        }

        private void siguiente1Button_Click(object sender, EventArgs e)
        {
            informacionGeneralAlumno.Visible = false;
            informacionGeneralAlumno2.Visible = true;

            regresarMenuButton.Visible = false;
            regresarButton.Visible = true;

            siguiente1Button.Visible = false;
            siguiente2Button.Visible = true;
        }


        private void siguiente2Button_Click(object sender, EventArgs e)
        {
            informacionGeneralAlumno2.Visible = false;
            informacionTutor.Visible = true;

            infGeneralAlLabel.Visible = false;
            infoTutorLabel.Visible = true;

            siguiente2Button.Visible = false;
            siguiente3Button.Visible = true;
        }

        private void siguiente3Button_Click(object sender, EventArgs e)
        {
            informacionTutor.Visible = false;
            informacionMedicaAlumnoGroupBox.Visible = true;

            infoTutorLabel.Visible = false;
            informacionMedLabel.Visible = true;

            siguiente3Button.Visible = false;
            realizarAltaButton.Visible = true;
        }

        //Cargar y Mostrar Foto Alumno ALTA ALUMNO
        private void fotoBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagenes|*.jpg; *.png";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Title = "Seleccionar Imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoAl.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void realizarAltaButton_Click_1(object sender, EventArgs e)
        {
            string colonia_trabajo_tutor = "", calle_trabajo_tutor = "", numero_trabajo_tutor = "";
            string peso = "", color_textura_piel = "", estatura = "", discapacidad = "", enfermedades = "", alergias = "";

            if (!nombreAl.Text.Equals("") && !apellidoP.Text.Equals("") && !apellidoM.Text.Equals(""))
            {
                //MessageBox.Show("REGISTRO EXITOSO!");
                businessLayer.BLAltaAlumno.SetAlumno2(cicloEsc.Text,
                                              nombreAl.Text,
                                              apellidoP.Text,
                                              apellidoM.Text,
                                              fechaNa.Value,
                                              añosCum.Text,
                                              curp.Text,
                                              estado.Text,
                                              ciudad.Text,
                                              colonia.Text,
                                              calle.Text,
                                              numeroCasa.Text,
                                              telPersonal.Text,
                                              escuelaP.Text,
                                              canalizado.Text
                                              );

                businessLayer.BLAltaAlumno.SetTutor2(nombreT.Text,
                                             apellidoPT.Text,
                                             apellidoMT.Text,
                                             coloniaT.Text,
                                             calleT.Text,
                                             numeroCasaT.Text,
                                             ocupacion.Text,
                                             colonia_trabajo_tutor,
                                             calle_trabajo_tutor,
                                             numero_trabajo_tutor);

                businessLayer.BLAltaAlumno.SetInfoMedAlumno2(servMedico.Text,
                                                     grupoSanguineo.Text,
                                                     telefono.Text,
                                                     peso,
                                                     color_textura_piel,
                                                     estatura);

                //businessLayer.Hueso.SetDiscapacidades(discapacidad);

                //businessLayer.Hueso.SetEnfermedades(enfermedades);

                //businessLayer.Hueso.SetAlergias(alergias);

                //businessLayer.Hueso.setTratamiento(tratamiento);

                //this.Hide();
                //Consultas consultas = new Consultas();
                //consultas.Show();

                //Condición de que si no ingresa nombre de alumno y foto de alumno no le deja hacer la alta
            if (fotoAl.Image == null)
            {
                MessageBox.Show("¡No puedes dar de alta a este alumno sin su NOMBRE COMPLETO!", "CAM - Alta Alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //Condición guardar foto alumno
            if (fotoAl.Image == null)
            {
                DialogResult result = MessageBox.Show("¡Falta subir la foto del alumno! ¿Deseas realizar la alta de todos modos?", "CAM - Alta Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Aquí se puede ingresar el método para realizar la alta de alumno...

                    //Guardar Foto alumno   **NO BORRAR LO QUE ESTÁ COMENTADO!!!!!**
                    byte[] archivo = null;
                    try
                    {
                        Stream myStream = openFileDialog1.OpenFile();

                        using (MemoryStream ms = new MemoryStream())
                        {
                            myStream.CopyTo(ms);
                            archivo = ms.ToArray();
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("Error: no se pudo guardar la foto del alumno", "CAM - Alta Alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (_1dataLayer.BDCAMEntities db = new _1dataLayer.BDCAMEntities())
                    {
                        _1dataLayer.imagenalumnoDTO oImage = new _1dataLayer.imagenalumnoDTO();

                        //db.foto_alumno.Add(oImage);
                        try
                        {
                            oImage.id_alumno = 6;
                            oImage.imagen = archivo;
                            oImage.nombre = openFileDialog1.FileName;
                            _1dataLayer.DLAltaAlumno.AltaImagenAlumno(oImage);
                            
                            //db.SaveChanges();
                        }
                        catch (DbEntityValidationException ex)
                        {
                            MessageBox.Show("Error: no se pudo guardar la foto del alumno", "CAM - Alta Alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                if (result == DialogResult.No)
                {
                    return;
                }
            }
        
            //Condición para permitirle al usuario si desea realizar otra alta o no
            //Si elige SI, se cierra la ventana de alta y se abre una nueva con los campos limpios
            //Si elige NO, se cierra la ventana de alta y se abre la ventana de consultas
            DialogResult dr = MessageBox.Show("Alta realizada con exito! Deseas realizar otra alta?", "CAM - Alta ALumno", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                altaAlumno formaltaAlumno = new altaAlumno();
                formaltaAlumno.Show();
            } else if (dr == DialogResult.No)
            {
                this.Hide();
                ConsultaAlumno formConsulta = new ConsultaAlumno();
                formConsulta.Show();
            }
                
            }
            else
            {
                MessageBox.Show("NO PUEDES CREAR UN REGISTRO SIN NOMBRE COMPLETO DEL ALUMNO!");
            }
        }

        private void eliminarTratamientoButton_Click(object sender, EventArgs e)
        {

        }
    }
}

