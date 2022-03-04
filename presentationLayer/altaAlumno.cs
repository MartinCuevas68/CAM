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
        int progreso = 1;

        public altaAlumno()
        {
            int distanciaLabel = 70;
            int distanciaTextBox = 66;

            InitializeComponent();
            loaddata();

            //Martin.panelNavBar(altaAlumnoPanel);


           // Martin.etiquetafuncionLabel(altaalumnoLabel);

            Evelyn.informacionMedicaGroupBox(informacionMedicaAlumnoGroupBox);
            Claudia.altasGroupBox(infoAl);
            Claudia.altasGroupBox2(informacionEscolarGroupBox);
            Claudia.altasInformacionTutorGroupBox(informacionTutorGroupBox);

            informacionMedicaAlumnoGroupBox.Visible = false;
            regresarButton.Visible = false;
            informacionTutorGroupBox.Visible = false;
            realizarAltaButton.Visible = false;

            distanciaLabel = Claudia.altasNombre(nombreAlLabel, apellidoPLabel, apellidoMLabel, nombreAl, apellidoP, apellidoM, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            distanciaLabel = Claudia.altasLabel(fechaNaLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasDateTimePicker(fechaNa, distanciaTextBox);

            //Lugar nacimiento Alumno
            distanciaLabel = Claudia.altasLugarNacimiento(lugarNaLabel, ciudadLabel, estadoLabel, ciudad, estado, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            //Direccion Alumno
            distanciaLabel = Claudia.altasDireccion(direccionLabel, calleLabel, numeroCasaLabel, coloniaLabel, calle, numeroCasa, colonia, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            distanciaLabel = Claudia.altasLabel(telPersonalLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(telPersonal, distanciaTextBox);

            distanciaLabel = Claudia.altasLabel(escuelaPLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(escuelaP, distanciaTextBox);

            distanciaLabel = Claudia.altasLabel(canalizadoLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(canalizado, distanciaTextBox);


            Evelyn.altasInformacionMedicaAlumno(servMedicoLabel, discapacidadLabel, enfermedaresLabel, alergiasLabel,
                    telefonoLabel, grupoSanguineoLabel,  servMedico, selecDiscapacidad, selecEnfermedad, selecAlergia, telefono, grupoSanguineo, discapacidad,
                    enfermedades, alergias);

            Claudia.altasInformacionEscolar(cicloEscLabel, curpLabel, añosCumLabel, cicloEsc, curp, añosCum, tipoIngreso, nuevoIngreso, reingreso);
            
            Evelyn.altasBotonesParaNavegar(siguienteButton, regresarButton, realizarAltaButton);
            //Evelyn.altasBotonesPanel(alumnosButton);

            int distanciaInfTutor = 10;
            Claudia.altasInformacionTutorGroupBox(informacionTutorGroupBox);
            //distanciaInfTutor = Claudia.altasTutorOtroAlumno(otroAlumnoTutorGroupBox, seleccionarNombreLabel, seleccionarNombreComboBox, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasNombreTutor(nombreTLabel, nombreT, apellidoPTLabel, apellidoPT, apellidoMTLabel, apellidoMT, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasDireccionTutor(domicilioTLabel, calleTLabel, calleT, numeroCasaTLabel, numeroCasaT, coloniaTLabel, coloniaT, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasOcupacionTutor(ocupacionLabel, ocupacion, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasTelefonosTutor(telTLabel, telCasaTLabel, telCasaT, telMovilTLabel, telMovilT, telTrabajoTLabel, telTrabajoT, distanciaInfTutor);


            Evelyn.eliminarBotones(eliminarEnfermedadButton, eliminarDiscapacidadesButton, eliminarAlergiasButton);
            Claudia.limpiarFormatosBotones(limpiarFormato1Button, limpiarFormato2Button, limpiarFormato3Button);
          
      
        }

        private void altaAlumno_Load(object sender, EventArgs e)
        {
            limpiarFormato1Button.Hide();
            limpiarFormato2Button.Hide();
            limpiarFormato3Button.Hide();
        
           // otroAlumnoTutorGroupBox.Hide();

           // seleccionarNombreLabel.Hide();
           // seleccionarNombreComboBox.Hide();
           // documentacionGB.Hide();
           // documentacionAlumnoLabel.Hide();
        }

        private void siguienteButton_Click_1(object sender, EventArgs e)
        {
            if (progreso == 0)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                infoAl.Visible = true;
                informacionEscolarGroupBox.Visible = true;
                informacionTutorGroupBox.Visible = false;
                regresarButton.Visible = true;
                siguienteButton.Visible = true;
                realizarAltaButton.Visible = false;
                progreso = 1;
            }
            if (progreso == 1)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                infoAl.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = true;
                regresarButton.Visible = true;
                siguienteButton.Visible = true;
                realizarAltaButton.Visible = false;
                progreso = 2;
            }
            if (progreso == 2)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                infoAl.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = true;
                regresarButton.Visible = true;
                siguienteButton.Visible = true;
                realizarAltaButton.Visible = false;
                progreso = 3;
            }else{
                informacionMedicaAlumnoGroupBox.Visible = true;
                infoAl.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = false;
                regresarButton.Visible = true;
                siguienteButton.Visible = false;
                realizarAltaButton.Visible = true;
                progreso = 4;
            }

        }

        private void regresarButton_Click(object sender, EventArgs e)
        {
            if (progreso == 3)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                infoAl.Visible = true;
                informacionEscolarGroupBox.Visible = true;
                informacionTutorGroupBox.Visible = false;
                regresarButton.Visible = false;
                realizarAltaButton.Visible = false;
                siguienteButton.Visible = true;
                progreso = 2;
            }

            if (progreso == 4)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                infoAl.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = true;
                realizarAltaButton.Visible = false;
                siguienteButton.Visible = true;
                progreso = 3;
            }
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

        private void alumnosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas formConsulta = new Consultas();
            formConsulta.Show();
        }

        //AGREGAR ENFERMEDADES AL RICHTXTBOX
        private void agregarEnfermedadesButton_Click(object sender, EventArgs e)
        {
            string informacion = this.selecEnfermedad.GetItemText(this.selecEnfermedad.SelectedItem);
            enfermedades.Text = enfermedades.Text+ informacion + "\n";

        }

        //AGREGAR DISCAPACIDADES AL RICHTXTBOX
        private void agregarDiscapacidadButton_Click(object sender, EventArgs e)
        {
            string informacion = this.selecDiscapacidad.GetItemText(this.selecDiscapacidad.SelectedItem);
            discapacidad.Text = discapacidad.Text + informacion + "\n";

        }

        //AGREGAR ALERGIAS AL RICHTXTBOX
        private void agregarAlergiasButton_Click(object sender, EventArgs e)
        {

            string informacion = this.selecAlergia.GetItemText(this.selecAlergia.SelectedItem);
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
            //siOtroAlumnoMadreRadioButton.Checked = false;
            //noOtroAlumnoMadreRadioButton.Checked = false;
            //seleccionarNombreComboBox.ResetText();
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
                selecAlergia.Items.Add(item.alergia);
            }
            foreach (var item2 in businessLayer.Martin.enfermedadesGet())
            {
                selecEnfermedad.Items.Add(item2.enfermedad);
            }
            foreach (var item3 in businessLayer.Martin.discapacidadesGet())
            {
                selecDiscapacidad.Items.Add(item3.discapacidades);
            }

        }

        private void informacionGeneralAlumnoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void alergiasCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apellidoMaternoAlumnoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
