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
    public partial class modificacionesAlumno : Form
    {
        int progreso = 1;
        public modificacionesAlumno()
        {
            int distanciaLabel = 70;
            int distanciaTextBox = 66;

            InitializeComponent();
            loaddata();

            /*Martin.panelNavBar(modificacionAlumnoPanel);


            Martin.etiquetafuncionLabel(tituloLabel);

            Evelyn.informacionMedicaGroupBox(informacionMedicaAlumnoGroupBox);
            Claudia.altasGroupBox(informacionGeneralAlumnoGroupBox);
            Claudia.altasGroupBox2(informacionEscolarGroupBox);
            Claudia.altasInformacionTutorGroupBox(informacionTutorGroupBox);

            informacionMedicaAlumnoGroupBox.Visible = false;
            regresarButton.Visible = false;
            informacionTutorGroupBox.Visible = false;
            finalizarModificacionButton.Visible = false;

            distanciaLabel = Claudia.altasNombre(nombreAlumnoLabel, apellidoPaternoAlumnoLabel, apellidoMaternoAlumnoLabel, nombreAlumnoTextBox, apellidoPaternoAlumnoTextBox, apellidoMaternoAlumnoTextBox, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            distanciaLabel = Claudia.altasLabel(fechaNacimientoLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasDateTimePicker(fechaNacimientoDateTimePicker, distanciaTextBox);

            //Lugar nacimiento Alumno
            distanciaLabel = Claudia.altasLugarNacimiento(lugarNacimientoLabel, ciudadNacimientoAlumnoLabel, estadoNacimientoAlumnoLabel, ciudadNacimientoAlumnoTextBox, estadoNacimientoAlumnoTextBox, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            //Direccion Alumno
            distanciaLabel = Claudia.altasDireccion(direccionAlumnoLabel, calleDireccionAlumnoLabel, numeroDireccionAlumnoLabel, coloniaDireccionAlumnoLabel, calleDireccionAlumnoTextBox, numeroDireccionAlumnoTextBox, coloniaDireccionAlumnoTextBox, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            distanciaLabel = Claudia.altasLabel(telefonoAlumnoLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(telefonoAlumnoTextBox, distanciaTextBox);

            distanciaLabel = Claudia.altasLabel(escuelaProcedenciaLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(escuelaProcedenciaTextBox, distanciaTextBox);

            distanciaLabel = Claudia.altasLabel(canalizadoPorLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(canalizadoPorTextBox, distanciaTextBox);


            Evelyn.altasInformacionMedicaAlumno(servicioMedicoAlumnoLabel, discapacidadLabel, enfermedaresAlumnoLabel, alergiasAlumnoLabel,
                    telefonoContactoMedicoAlumnoLabel, grupoSanguineoAlumnoLabel, documentacionAlumnoLabel, mostrarDiscapacidadLabel,
                    mostrarEnfermedadesLabel, mostrarAlergiasLabel, servicioMedicoTextBox, discapacidadesCombobox, enfermedadesCombobox, alergiasCombobox, telefonoContactoMedicoAlumnoTextBox, grupoSanguineoTextBox, documentacionGB, mostrarDiscapacidadRichTextBox,
                    mostrarEnfermedadesRichTextBox, mostrarAlergiasRichTextBox, agregarAlergiasButton, agregarEnfermedadesButton, agregarDiscapacidadButton);

            Claudia.altasInformacionEscolar(cicloEscolarLabel, curpLabel, añosCumplidosLabel, cicloEscolarTextBox, curpTextBox, añosCumplidosTextBox, tipoIngresoGroupBox, nuevoIngresoRadioButton, reingresoRadioButton);

            //Evelyn.altasBotonesParaNavegar(siguienteButton, regresarButton, finalizarModificacionButton);
            Evelyn.altasBotonesPanel(alumnosButton);

            int distanciaInfTutor = 10;
            Claudia.altasInformacionTutorGroupBox(informacionTutorGroupBox);
            distanciaInfTutor = Claudia.altasTutorOtroAlumno(otroAlumnoTutorGroupBox, seleccionarNombreLabel, seleccionarNombreComboBox, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasNombreTutor(nombreTutorLabel, nombreTutorTextBox, apellidoPaternoTutorLabel, apellidoPaternoTutorTextBox, apellidoMaternoTutorLabel, apellidoMaternoTutorTextBox, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasDireccionTutor(domicilioTutorLabel, calleDireccionTutorLabel, calleDireccionTutorTextBox, numeroDireccionTutorLabel, numeroDireccionTutorTextBox, coloniaDireccionTutorLabel, coloniaDireccionTutorTextBox, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasOcupacionTutor(ocupacionTutorLabel, ocupacionTutorTextBox, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasTelefonosTutor(telefonosTutorLabel, telefonoCasaTutorLabel, telefonoCasaTutorTextBox, telefonoCelularTutorLabel, telefonoCelularTutorTextBox, telefonoTrabajoTutorLabel, telefonoTrabajoTutorTextBox, distanciaInfTutor);


            Evelyn.eliminarBotones(eliminarEnfermedadButton, eliminarDiscapacidadesButton, eliminarAlergiasButton);
            Claudia.limpiarFormatosBotones(limpiarFormato1Button, limpiarFormato2Button, limpiarFormato3Button);

            Martin.nodificacion(idLabel, nombreLabel);*/

        }


        private void modificacionesAlumno_Load(object sender, EventArgs e)
        {
            limpiarFormato1Button.Hide();
            limpiarFormato2Button.Hide();
            limpiarFormato3Button.Hide();

            otroAlumnoTutorGroupBox.Hide();

            seleccionarNombreLabel.Hide();
            seleccionarNombreComboBox.Hide();
            documentacionGB.Hide();
            documentacionAlumnoLabel.Hide();

            idLabel.Text = Contenedor.id.ToString();
            


            //foreach (var item in businessLayer.BLEliminacionAlumno.nombreGetid(Contenedor.id))
            //{
            //    nombreLabel.Text = item.nombre;
            //}

          
        }
        

        private void siguienteButton_Click(object sender, EventArgs e)
        {
            if (progreso == 0)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = true;
                informacionEscolarGroupBox.Visible = true;
                informacionTutorGroupBox.Visible = false;
                regresarButton.Visible = true;
                siguienteButton.Visible = true;
                finalizarModificacionButton.Visible = false;
                progreso = 1;
            }
            if (progreso == 1)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = true;
                regresarButton.Visible = true;
                siguienteButton.Visible = true;
                finalizarModificacionButton.Visible = false;
                progreso = 2;
            }
            if (progreso == 2)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = true;
                regresarButton.Visible = true;
                siguienteButton.Visible = true;
                finalizarModificacionButton.Visible = false;
                progreso = 3;
            }
            else
            {
                informacionMedicaAlumnoGroupBox.Visible = true;
                informacionGeneralAlumnoGroupBox.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = false;
                regresarButton.Visible = true;
                siguienteButton.Visible = false;
                finalizarModificacionButton.Visible = true;
                progreso = 4;
            }
        }

        private void regresarButton_Click(object sender, EventArgs e)
        {
            if (progreso == 3)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = true;
                informacionEscolarGroupBox.Visible = true;
                informacionTutorGroupBox.Visible = false;
                regresarButton.Visible = false;
                finalizarModificacionButton.Visible = false;
                siguienteButton.Visible = true;
                progreso = 2;
            }

            if (progreso == 4)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = true;
                finalizarModificacionButton.Visible = false;
                siguienteButton.Visible = true;
                progreso = 3;
            }
        }

        private void finalizarModificacionButton_Click(object sender, EventArgs e)
        {
            if (!nombreAlumnoTextBox.Text.Equals("") && !apellidoPaternoAlumnoTextBox.Text.Equals("") && !apellidoMaternoAlumnoTextBox.Text.Equals(""))
            {
                //MessageBox.Show("MODIFICACION EXITOSA!");
                //businessLayer.BLEliminacionAlumno.ModAlumno(cicloEscolarTextBox.Text,
                //                              nombreAlumnoTextBox.Text,
                //                              apellidoPaternoAlumnoTextBox.Text,
                //                              apellidoMaternoAlumnoTextBox.Text,
                //                              fechaNacimientoDateTimePicker.Value,
                //                              añosCumplidosTextBox.Text,
                //                              curpTextBox.Text,
                //                              estadoNacimientoAlumnoTextBox.Text,
                //                              ciudadNacimientoAlumnoTextBox.Text,
                //                              coloniaDireccionAlumnoTextBox.Text,
                //                              calleDireccionAlumnoTextBox.Text,
                //                              numeroDireccionAlumnoTextBox.Text,
                //                              telefonoAlumnoTextBox.Text,
                //                              escuelaProcedenciaTextBox.Text,
                //                              canalizadoPorTextBox.Text,
                //                              Contenedor.id);

                this.Hide();
                ConsultaAlumno consultas = new ConsultaAlumno();
                consultas.Show();

            }
            else
            {
                MessageBox.Show("NO SE PUEDE MODIFICAR UN REGISTRO SIN NOMBRE COMPLETO DEL ALUMNO!");
            }
        }



        private void alumnosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaAlumno formConsulta = new ConsultaAlumno();
            formConsulta.Show();
        }

        private void loaddata()
        {
            //foreach (var item in businessLayer.BLEliminacionAlumno.alergiasGet())
            //{
            //    alergiasCombobox.Items.Add(item.alergia);
            //}
            //foreach (var item in businessLayer.BLEliminacionAlumno.alergiasGet())
            //{
            //    enfermedadesCombobox.Items.Add(item.alergia);
            //}
            //foreach (var item in businessLayer.BLEliminacionAlumno.alergiasGet())
            //{
            //    discapacidadesCombobox.Items.Add(item.alergia);
            //}
        }

        private void agregarEnfermedadesButton_Click(object sender, EventArgs e)
        {
            string informacion = this.enfermedadesCombobox.GetItemText(this.enfermedadesCombobox.SelectedItem);
            mostrarEnfermedadesRichTextBox.Text = mostrarEnfermedadesRichTextBox.Text + informacion + "\n";
        }

        private void agregarDiscapacidadButton_Click(object sender, EventArgs e)
        {
            string informacion = this.discapacidadesCombobox.GetItemText(this.discapacidadesCombobox.SelectedItem);
            mostrarDiscapacidadRichTextBox.Text = mostrarDiscapacidadRichTextBox.Text + informacion + "\n";
        }
   

        private void agregarAlergiasButton_Click(object sender, EventArgs e)
        {
            string informacion = this.alergiasCombobox.GetItemText(this.alergiasCombobox.SelectedItem);
            mostrarAlergiasRichTextBox.Text = mostrarAlergiasRichTextBox.Text + informacion + "\n";
        }

    }
}
