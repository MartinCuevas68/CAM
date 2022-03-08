using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public partial class altaAlumno : Form
    {
        int progreso = 0;

        public altaAlumno()
        {
 
            InitializeComponent();
            loaddata();
            
           
            //CODIGO NUEVO
            centrarLabel(altaalumnoLabel,infoTutorLabel, informacionMedLabel,logo, infGeneralAlLabel,informacionGeneralAlumno,
                informacionGeneralAlumno2,informacionTutor,informacionMedicaAlumnoGroupBox);

            infoGen(nombreAlLabel, nombreAl, apellidoPLabel, apellidoP, apellidoMLabel, apellidoM, fechaNaLabel, fechaNa, añosCumLabel, 
                añosCum, curpLabel,curp, direccionAlumnoLabel,calleLabel, calle, numeroCasaLabel, numeroCasa, coloniaLabel,colonia,lugarNaLabel,
                ciudadLabel,ciudad,estadoLabel,estado);

            infoGen2(telPersonalLabel, telPersonal, escuelaPLabel, escuelaP, canalizadoLabel, canalizado, cicloEscLabel, cicloEsc,tipoIngLabel,
                tipoIngresoGroupBox);

            infoTutor(nombreTLabel, nombreT, apellidoPTLabel, apellidoPT, apellidoMTLabel, apellidoMT, direccionTLabel, calleTLabel, calleT, numeroCasaTLabel,
                numeroCasaT, coloniaTLabel, coloniaT, infContactoLabel,telCasaTLabel,telCasaT,telMovilTLabel,telMovilT,telTrabajoTLabel,telTrabajoT,ocupacionLabel,ocupacion);

            infoMedica(servMedicoLabel, servMedico, grupoSanguineoLabel, grupoSanguineo, telefonoLabel, telefono,discapacidadLabel,discapacidad,enfermedadesLabel, enfermedades,
                alergiasLabel, alergias,tratamientoLabel,tratamiento,discapacidadesCombobox,enfermedadesCombobox,alergiasCombobox,eliminarDiscapacidadesButton,
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
            int x = this.ClientSize.Width,y = this.ClientSize.Height;
            logo.Location = new Point(50, 20);

            //TITULO PRINCIPAL
            nomLabel.Location = new Point(x/2-nomLabel.Width/2, logo.Height/2 - 20);
           
            //SUBTITULOS
            infGenLabel.Location = new Point(x / 2 - infGenLabel.Width / 2, logo.Height / 2 + 50);
            infoTutorLabel.Location = new Point(x / 2 - infoTutorLabel.Width / 2, logo.Height / 2 + 50);
            infoMedLabel.Location = new Point(x / 2 - infGenLabel.Width / 2, logo.Height / 2 + 50);

            //GROUPBOXS
            infoGeneral.Size = new Size(x - 100, y - 100);
            infoGeneral.Location = new Point(x/2- infoGeneral.Width/2, y / 2 - infoGeneral.Height / 2 + 120);

            infoGeneral2.Size = new Size(x - 100, y - 100);
            infoGeneral2.Location = new Point(x / 2 - infoGeneral2.Width / 2, y / 2 - infoGeneral2.Height / 2 + 120);

            infoTutor.Size = new Size(x - 100, y - 100);
            infoTutor.Location = new Point(x / 2 - infoTutor.Width / 2, y / 2 - infoTutor.Height / 2 + 120);

            infoMedica.Size = new Size(x - 100, y - 100);
            infoMedica.Location = new Point(x / 2 - infoMedica.Width / 2, y / 2 - infoMedica.Height / 2 + 120);
        }

        //INFORMACION GENERAL ALUMNO
        private void infoGen(Label nombreL, TextBox nombre, Label apellidoPL, TextBox apellidoP, Label apellidoML, TextBox apellidoM, 
            Label fechaNaL, DateTimePicker fechaNa, Label añosCumL, TextBox añosCum, Label curpL, TextBox curp, Label direccion, Label calleL,
            TextBox calle, Label numL, TextBox num, Label coloniaL, TextBox colonia, Label lugarNa, Label ciudadL, TextBox ciudad, Label estadoL, TextBox estado)
        {
            progreso = 1;

            nombreL.Location = new Point(50, 50);
            nombre.Location = new Point(200, 50);

            apellidoPL.Location = new Point(50,100);
            apellidoP.Location = new Point(200,100);

            apellidoML.Location = new Point(50,150);
            apellidoM.Location = new Point(200,150);

            fechaNaL.Location = new Point(50,200);
            fechaNa.Location = new Point(200,200);

            añosCumL.Location = new Point(50,250);
            añosCum.Location = new Point(200,250);

            curpL.Location = new Point(50,300);
            curp.Location = new Point(200,300);

            //DIRECCION
            direccion.Location = new Point(500, 50);

            calleL.Location = new Point(500,100);
            calle.Location = new Point(750,100);

            numL.Location = new Point(500,150);
            num.Location = new Point(750,150);

            coloniaL.Location = new Point(500,200);
            colonia.Location = new Point(750,200);

            //LUGAR NACIMIENTO
            lugarNa.Location = new Point(500, 250);

            ciudadL.Location = new Point(500, 300);
            ciudad.Location = new Point(750, 300);

            estadoL.Location = new Point(500, 350);
            estado.Location = new Point(750, 350);
        }


        //INFORMACION GENERAL ALUMNO 2
        private void infoGen2(Label telL, TextBox tel, Label escuelaPL, TextBox escuelaP, Label canalizadoL, TextBox canalizado, Label cicloL,
            TextBox ciclo, Label tipoIng,GroupBox ingresos)
        {
            progreso = 2;
            telL.Location = new Point(50, 50);
            tel.Location = new Point(200, 50);

            escuelaPL.Location = new Point(50,100);
            escuelaP.Location = new Point(200,100);

            canalizadoL.Location = new Point(50,150);
            canalizado.Location = new Point(200,150);

            cicloL.Location = new Point(50,200);
            ciclo.Location = new Point(200,200);

            tipoIng.Location = new Point(50,250);

            ingresos.Location = new Point(50, 300);
        }

        //INFORMACION TUTOR
        private void infoTutor(Label nombreL, TextBox nombre, Label apellidoPL, TextBox apellidoP, Label apellidoML, TextBox apellidoM,
            Label direccion, Label calleL, TextBox calle, Label numL, TextBox num, Label coloniaL, TextBox colonia, Label infoCon, Label telCasaL,
            TextBox telCasa, Label telMovilL, TextBox telMovil, Label telTrabajoL, TextBox telTrabajo, Label ocupacionL, TextBox ocupacion)
        {
            progreso = 3;

            nombreL.Location = new Point(50,50);
            nombre.Location = new Point(200,50);

            apellidoPL.Location = new Point(50,100);
            apellidoP.Location = new Point(200,100);

            apellidoML.Location = new Point(50,150);
            apellidoM.Location = new Point(200,150);

            direccion.Location = new Point(50,200);

            calleL.Location = new Point(50,250);
            calle.Location = new Point(200,250);

            numL.Location = new Point(50,300);
            num.Location = new Point(200,300);

            coloniaL.Location = new Point(50,350);
            colonia.Location = new Point(200,350);

            infoCon.Location = new Point(50,400);

            telCasaL.Location = new Point(50,450 );
            telCasa.Location = new Point(200, 450);

            telMovilL.Location = new Point(50, 500);
            telMovil.Location = new Point(200, 500);

            telTrabajoL.Location = new Point(50, 550);
            telTrabajo.Location = new Point(200, 550);

            ocupacionL.Location = new Point(50, 600);
            ocupacion.Location = new Point(200, 600);
        }

        //INFORMACION MEDICA
        private void infoMedica(Label servMedicoL, TextBox servMed, Label grupoSanL, TextBox grupoSan, Label telL, TextBox tel,Label discapacidadL, RichTextBox discapacidad,
            Label enfermedadL, RichTextBox enfermedad, Label alergiaL, RichTextBox alergia, Label tratamientoL, RichTextBox tratamiento,
            ComboBox discapacidadCB, ComboBox enfermedadCB, ComboBox alergiaCB,Button eliDisc, Button eliEnf, Button eliAle)
        {
            servMedicoL.Location = new Point(50, 50);
            servMedico.Location = new Point(200,50);

            grupoSanL.Location = new Point(400, 50);
            grupoSan.Location = new Point(600, 50);

            telL.Location = new Point(750, 50);
            tel.Location = new Point(950, 50);

            discapacidadL.Location = new Point(50, 150);
            eliDisc.Location = new Point(200, 150);
            discapacidad.Location = new Point(50, 180);
            discapacidadCB.Location = new Point(50, 230);

            enfermedadL.Location = new Point(300, 150);
            eliEnf.Location = new Point(450, 150);
            enfermedad.Location = new Point(300, 180);
            enfermedadCB.Location = new Point(300, 230);

            alergiaL.Location = new Point(550, 150);
            eliAle.Location = new Point(650, 150);
            alergia.Location = new Point(550, 180);
            alergiaCB.Location = new Point(550, 230);

            tratamientoL.Location = new Point(800, 150);
            tratamiento.Location = new Point(800, 180);
        }

        private void altaAlumno_Load(object sender, EventArgs e)
        {
            limpiarFormato1Button.Hide();
            limpiarFormato2Button.Hide();
            limpiarFormato3Button.Hide();
        }


        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (!nombreAl.Text.Equals("") && !apellidoP.Text.Equals("") && !apellidoM.Text.Equals(""))
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

                this.Hide();
                Consultas consultas = new Consultas();
                consultas.Show();
                
            }
            else
            {
                MessageBox.Show("NO PUEDES CREAR UN REGISTRO SIN NOMBRE COMPLETO DEL ALUMNO!");
            }
        }

        public void altasBotonesParaNavegar(Button siguiente1, Button siguiente2, Button siguiente3, Button regresar, Button guardar, Button regresarMenu)
        {
            int x = this.ClientSize.Width, y = this.ClientSize.Height;

            siguiente1.Location = new Point((int)(x * 0.9), (int)(y * 0.54));
            siguiente2.Location = new Point((int)(x * 0.9), (int)(y * 0.54));
            siguiente3.Location = new Point((int)(x * 0.9), (int)(y * 0.54));
            regresar.Location = new Point((int)(x * 0.35), (int)(y * 0.54));
            regresarMenu.Location = new Point((int)(x * 0.35), (int)(y * 0.54));
            guardar.Location = new Point((int)(x * 0.9), (int)(y * 0.54));

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
            Consultas formConsulta = new Consultas();
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

            foreach (var item in businessLayer.Martin.alergiasGet())
            {
                alergiasCombobox.Items.Add(item.alergia);
            }
            foreach (var item2 in businessLayer.Martin.enfermedadesGet())
            {
                enfermedadesCombobox.Items.Add(item2.enfermedad);
            }
            foreach (var item3 in businessLayer.Martin.discapacidadesGet())
            {
                discapacidadesCombobox.Items.Add(item3.discapacidades);
            }

        }

        private void siguienteButton1_Click(object sender, EventArgs e)
        {
            informacionGeneralAlumno.Visible = false;
            informacionGeneralAlumno2.Visible = true;

            regresarMenuButton.Visible = false;
            regresarButton.Visible = true;
            siguiente1Button.Visible = false;
            siguiente2Button.Visible = true;
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
        }

        private void regresarMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas formConsulta = new Consultas();
            formConsulta.Show();
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
    }
}
