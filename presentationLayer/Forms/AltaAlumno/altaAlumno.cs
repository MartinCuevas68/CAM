using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace presentationLayer
{
    public partial class altaAlumno : Form
    {
        ComboBox enfermedadestempcmb = new ComboBox();

        ComboBox discapacidadestempcmb = new ComboBox();

        ComboBox alergiastempcmb = new ComboBox();

        List<string> listaEnfermedades = new List<string>();

        List<string> listaDiscapacidades = new List<string>();

        List<string> listaAlergias = new List<string>();

        List<int> idenfermermedadesListaAlta = new List<int>();

        List<int> iddiscapacidadesListaAlta = new List<int>();

        List<int> idalergiasListaAlta = new List<int>();

        public altaAlumno()
        {

            InitializeComponent();
            loaddata();

            grupoSanguineoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


            //CODIGO NUEVO
            PLAltaAlumno.centrarLabel(altaalumnoLabel, infoTutorLabel, informacionMedLabel, logo, infGeneralAlLabel, informacionGeneralAlumno,
                informacionGeneralAlumno2, informacionTutor, informacionMedicaAlumnoGroupBox, infoTutorLabel);

            PLAltaAlumno.infoGen(nombreAlLabel, nombreAl, nombreAlPanel, apellidoPLabel, apellidoP, apellidoPPanel, apellidoMLabel, apellidoM, apellidoMPanel, fechaNaLabel, fechaNa, añosCumLabel,
                añosCum, añosCumPanel, curpLabel, curp, curpPanel, direccionAlumnoLabel, calleLabel, calle, callePanel, numeroCasaLabel, numeroCasa, numeroCasaPanel, coloniaLabel, colonia, coloniaPanel, lugarNaLabel,
                ciudadLabel, ciudad, ciudadPanel, estadoLabel, estado, estadoPanel, fotoAl, fotoBtn);

            PLAltaAlumno.infoGen2(telPersonalLabel, telefonopersonalTextBox, telPersonalPanel, escuelaPLabel, escuelaP, escuelaPPanel, canalizadoLabel, canalizado, canalizadoPanel, cicloEscLabel, cicloEsc, cicloEscPanel, tipoIngLabel,
                tipoIngresoGroupBox);

            PLAltaAlumno.infoTutor(nombreTLabel, nombreT, nombreTPanel, apellidoPTLabel, apellidoPT, apellidoPTPanel, apellidoMTLabel, apellidoMT, apellidoMTPanel, direccionTLabel,
                calleTLabel, calleT, calleTPanel, numeroCasaTLabel, numeroCasaT, numeroCasaTPanel, coloniaTLabel, coloniaT, coloniaTPanel,
                calleDatoLabel, numeroDatoLabel, coloniaDatoLabel, infContactoLabel, telCasaTLabel, telefonocasatutorTextBox, telCasaTPanel, telMovilTLabel, telefonomoviltutorTextBox, telMovilTPanel,
                telTrabajoTLabel, telefonotrabajotutorTextBox, telTrabajoTPanel, ocupacionLabel, ocupacion, ocupacionTPanel, direccionCheckBox);

            PLAltaAlumno.infoMedica(servMedicoLabel, servMedico, servMedicoPanel, grupoSanguineoLabel, grupoSanguineoComboBox, telefonoLabel,
                telefono, telefonoPanel, discapacidadLabel, discapacidadesRichTextBox, discapacidadPanel, enfermedadesLabel, enfermedadesRichTextBox, enfermedadesPanel,
                alergiasLabel, alergiasRichTextBox, alergiasPanel, tratamientoLabel, tratamiento, tratamientoPanel, discapacidadesCombobox, enfermedadesCombobox, alergiasCombobox,
                eliminarEnfermedadesButton, eliminarDiscapacidadesButton, eliminarAlergiasButton, eliminarTratamientosButton,
                 agregarDiscapacidadesButton, agregarEnfermedadesButton, agregarAlergiasButton, eliminardiscapacidadButton1, eliminarenfButton, eliminarAlegiasButton1);


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

            DateTime fechaActualI = DateTime.Today;
            int anioI = fechaNa.Value.Year;
            int edadI = fechaActualI.Year - anioI;
            String edadConvertidaI = edadI.ToString();
            añosCum.Text = edadConvertidaI;
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


        //AGREGAR ENFERMEDADES AL RICHTXTBOX
        private void agregarEnfermedadesButton_Click(object sender, EventArgs e)
        {
            string informacion = this.enfermedadesCombobox.GetItemText(this.enfermedadesCombobox.SelectedItem);
            enfermedadesRichTextBox.Text = enfermedadesRichTextBox.Text + informacion + "\n";

        }

        //AGREGAR DISCAPACIDADES AL RICHTXTBOX
        private void agregarDiscapacidadButton_Click(object sender, EventArgs e)
        {
            string informacion = this.discapacidadesCombobox.GetItemText(this.discapacidadesCombobox.SelectedItem);
            discapacidadesRichTextBox.Text = discapacidadesRichTextBox.Text + informacion + "\n";

        }

        //AGREGAR ALERGIAS AL RICHTXTBOX
        private void agregarAlergiasButton_Click(object sender, EventArgs e)
        {

            string informacion = this.alergiasCombobox.GetItemText(this.alergiasCombobox.SelectedItem);
            alergiasRichTextBox.Text = alergiasRichTextBox.Text + informacion + "\n";

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
            telefonopersonalTextBox.Clear();
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
            telefonocasatutorTextBox.Clear();
            telefonomoviltutorTextBox.Clear();
            telefonotrabajotutorTextBox.Clear();
        }

        //LIMPIAR INFORMACIÓN MEDICA ALUMNO
        private void limpiarFormato3Button_Click(object sender, EventArgs e)
        {
            servMedico.Clear();

            telefono.Clear();
            //grupoSanguineoComboBox.Clear();
            //documentacionListBox.SetItemChecked = false; *CLAUDIA CAMBIARÁ ESTO POR UN CONJUNTO DE CHECKBUTTONS*
        }

        //LIMPIAR DISCAPACIDADES
        private void eliminarDiscapacidadesButton_Click(object sender, EventArgs e)
        {
            discapacidadesRichTextBox.Clear();
        }

        //LIMPIAR ENFERMEDADES
        private void eliminarEnfermedadButton_Click(object sender, EventArgs e)
        {
            enfermedadesRichTextBox.Clear();
        }

        //LIMPIAR ALERGIAS
        private void eliminarAlergiasButton_Click(object sender, EventArgs e)
        {
            alergiasRichTextBox.Clear();
        }

        //FILLCOMBOBOX METODO PARA ALERGIAS, ENFERMEDADES Y DISCAPACIDADES
        private void loaddata()
        {

            foreach (var item in _1dataLayer.DLAltaAlumno.catalogoalergias())
            {
                alergiasCombobox.Items.Add(item.alergia);
                alergiastempcmb.Items.Add(item.id_alergias);
            }
            foreach (var item2 in _1dataLayer.DLAltaAlumno.catalogoenfermedades())
            {

                enfermedadesCombobox.Items.Add(item2.enfermedades);
                enfermedadestempcmb.Items.Add(item2.id_enfermedades);

            }
           foreach (var item3 in _1dataLayer.DLAltaAlumno.catalogodiscapacidades())
            {
                discapacidadesCombobox.Items.Add(item3.discapacidades);
                discapacidadestempcmb.Items.Add(item3.id_discapacidades);
            }

        }

        private void regresarButton_Click_1(object sender, EventArgs e)
        {
            if (informacionGeneralAlumno2.Visible == true)
            {

                informacionGeneralAlumno.Visible = true;
                informacionGeneralAlumno2.Visible = false;

                regresarMenuButton.Visible = true;
                regresarButton.Visible = false;

                siguiente1Button.Visible = true;
                siguiente2Button.Visible = false;
            }
            if (informacionTutor.Visible == true)
            {

                informacionGeneralAlumno2.Visible = true;
                informacionTutor.Visible = false;

                infGeneralAlLabel.Visible = true;
                infoTutorLabel.Visible = false;

                siguiente2Button.Visible = true;
                siguiente3Button.Visible = false;
            }
            if (informacionMedicaAlumnoGroupBox.Visible == true)
            {

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
            int curple = curp.TextLength; //Variable int que guarda la longitud de caracteres del CURP

            if (nombreAl.Text.Equals("") || apellidoP.Text.Equals(""))
            {
                MessageBox.Show("¡No se ha ingresado el nombre completo del alumno!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (curp.Text.Equals(""))
                {
                    MessageBox.Show("¡No se ha ingresado la CURP del alumno!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (calle.Text.Equals(""))
                    {
                        MessageBox.Show("¡No se ha ingresado la calle del alumno!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (numeroCasa.Text.Equals(""))
                        {
                            MessageBox.Show("¡No se ha ingresado el numero de casa del alumno!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (colonia.Text.Equals(""))
                            {
                                MessageBox.Show("¡No se ha ingresado la colonia del alumno!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (ciudad.Text.Equals(""))
                                {
                                    MessageBox.Show("¡No se ha ingresado la ciudad del alumno!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (estado.Text.Equals(""))
                                    {
                                        MessageBox.Show("¡No se ha ingresado el estado del alumno!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        if (fotoAl.Image == null)
                                        {
                                            MessageBox.Show("¡No puedes dar de alta a este alumno sin una foto", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {
                                            if (curple < 18)
                                            {

                                                String curpl = Convert.ToString(18 - curp.TextLength);
                                                MessageBox.Show("¡El CURP del alumno está incompleto, falta " + curpl + " caracter(es)", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                            else
                                            {
                                                if (añosCum.Text == "")
                                                {
                                                    MessageBox.Show("¡No se ha seleccionado la fecha de nacimiento de este alumno", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                                else
                                                {
                                                    informacionGeneralAlumno.Visible = false;
                                                    informacionGeneralAlumno2.Visible = true;

                                                    regresarMenuButton.Visible = false;
                                                    regresarButton.Visible = true;

                                                    siguiente1Button.Visible = false;
                                                    siguiente2Button.Visible = true;
                                                }

                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        private void siguiente2Button_Click(object sender, EventArgs e)
        {
            if (telefonopersonalTextBox.Text == "") //POR PULIR
            {
                DialogResult dr = MessageBox.Show("¡El telefono personal del alumno está vacio! ¿Deseas registrarlo?", "Dato requerido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    if (canalizado.Text.Equals(""))
                    {
                        MessageBox.Show("¡No se ha respondido el campo \"Canalizado por\" ", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (cicloEsc.Text.Equals(""))
                        {
                            MessageBox.Show("¡No se ha ingresado el ciclo escolar", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            if (!nuevoIngreso.Checked && !reingreso.Checked)
                            {
                                MessageBox.Show("¡No se ha seleccionado si el alumno es nuevo Ingreso o reingreso", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
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

                }
                if (dr == DialogResult.Yes)
                {
                    return;
                }
            }
            else if (telefonopersonalTextBox.TextLength < 10) //Validación si se da siguiente y el telefono está incompleto
            {
                String telPersonalAl = Convert.ToString(10 - telefonopersonalTextBox.TextLength);
                MessageBox.Show("¡El telefono personal del alumno está incompleto, falta " + telPersonalAl + " numero(s)", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (telefonopersonalTextBox.TextLength == 10)
            {
                if (canalizado.Text.Equals(""))
                {
                    MessageBox.Show("¡No se ha respondido el campo \"Canalizado por\" ", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (cicloEsc.Text.Equals(""))
                    {
                        MessageBox.Show("¡No se ha ingresado el ciclo escolar", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (!nuevoIngreso.Checked && !reingreso.Checked)
                        {
                            MessageBox.Show("¡No se ha seleccionado si el alumno es nuevo Ingreso o reingreso", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
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
            }
        }

        private void siguiente3Button_Click(object sender, EventArgs e)
        {
            if (nombreT.Text.Equals("") || apellidoPT.Text.Equals(""))
            {
                MessageBox.Show("¡No se ha ingresado el nombre completo del tutor!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (calleT.Text.Equals(""))
                {
                    MessageBox.Show("¡No se ha ingresado la calle del tutor!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (numeroCasaT.Text.Equals(""))
                    {
                        MessageBox.Show("¡No se ha ingresado el numero de casa del tutor!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (coloniaT.Text.Equals(""))
                        {
                            MessageBox.Show("¡No se ha ingresado la colonia del tutor!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (telefonocasatutorTextBox.Text.Equals("") && telefonomoviltutorTextBox.Text.Equals("") && telefonotrabajotutorTextBox.Text.Equals(""))
                            {
                                MessageBox.Show("¡Ingresar al menos un telefono de contacto!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (!telefonocasatutorTextBox.Text.Equals("") && telefonocasatutorTextBox.TextLength < 10)
                                {
                                    MessageBox.Show("¡El telefono de casa está incompleto, debe contener 10 digitos ", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (!telefonomoviltutorTextBox.Text.Equals("") && telefonomoviltutorTextBox.TextLength < 10)
                                    {
                                        MessageBox.Show("¡El telefono móvil está incompleto, debe contener 10 digitos ", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        if (!telefonotrabajotutorTextBox.Text.Equals("") && telefonotrabajotutorTextBox.TextLength < 10)
                                        {
                                            MessageBox.Show("¡El telefono del trabajo está incompleto, debe contener 10 digitos ", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {
                                            informacionTutor.Visible = false;
                                            informacionMedicaAlumnoGroupBox.Visible = true;

                                            infoTutorLabel.Visible = false;
                                            informacionMedLabel.Visible = true;

                                            siguiente3Button.Visible = false;
                                            realizarAltaButton.Visible = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
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
            string colonia_trabajo_tutor = "", calle_trabajo_tutor = "";

            string peso = "", color_textura_piel = "", estatura = "";

            //Aquí se puede ingresar el método para realizar la alta de alumno...
            if (servMedico.Text.Equals(""))
            {
                MessageBox.Show("¡Ingresar el servicio medico del alumno!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (grupoSanguineoComboBox.Text.Equals(""))
                {
                    MessageBox.Show("¡Ingresar el grupo sanguineo del alumno!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (telefono.Text.Equals(""))
                    {
                        MessageBox.Show("¡Ingresar el telefono!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //La validacion de Discapacidad, Enfermedad, Alergias y Tratamiento para que no se pueda hacer el alta sin dichos datos queda pendiente
                        //Para poder hacer pruebas, ya que esos datos aun no funcionan
                        string value = "";

                        if (nuevoIngreso.Checked)
                        {
                            value = "Nuevo Ingreso";
                            MessageBox.Show(value);
                        }
                        else
                        {
                            if (reingreso.Checked)
                            {
                                value = "Reingreso";
                                MessageBox.Show(value);
                            }
                        }
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
                                                             telefonopersonalTextBox.Text,
                                                             escuelaP.Text,
                                                             canalizado.Text,
                                                             value
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
                                                             telefonotrabajotutorTextBox.Text
                                                             );

                        businessLayer.BLAltaAlumno.SetInfoMedAlumno2(servMedico.Text,
                                                                     grupoSanguineoComboBox.Text,
                                                                     telefono.Text,
                                                                     peso,
                                                                     color_textura_piel,
                                                                     estatura);

                        businessLayer.BLAltaAlumno.SetAlergias(idalergiasListaAlta);

                        businessLayer.BLAltaAlumno.SetEnfermedades(idenfermermedadesListaAlta);

                        businessLayer.BLAltaAlumno.SetDiscapacidades(iddiscapacidadesListaAlta);

                        businessLayer.BLAltaAlumno.SetTratamiento(tratamiento.Text);

                        businessLayer.BLAltaAlumno.SetTelefonos(telefonocasatutorTextBox.Text,telefonomoviltutorTextBox.Text, telefonotrabajotutorTextBox.Text);


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
                                businessLayer.BLAltaAlumno.SetFotoAlumno(oImage);

                                //db.SaveChanges();
                            }
                            catch (DbEntityValidationException ex)
                            {
                                MessageBox.Show("Error: no se pudo guardar la foto del alumno", "CAM - Alta Alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        this.Hide();
                        ConsultaAlumno formConsulta = new ConsultaAlumno();
                        formConsulta.Show();
                    }
                }
            }
            //Condición para permitirle al usuario si desea realizar otra alta o no
            //Si elige SI, se cierra la ventana de alta y se abre una nueva con los campos limpios
            //Si elige NO, se cierra la ventana de alta y se abre la ventana de consultas

            /*DialogResult dr = MessageBox.Show("Alta realizada con exito! Deseas realizar otra alta?", "CAM - Alta ALumno", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
            }*/
        }

        private void eliminarTratamientoButton_Click(object sender, EventArgs e)
        {

        }

        //Método que autocompleta la edad poniendo la fecha de nacimiento
        private void fechaNa_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = fechaNa.Value;
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - fechaNacimiento;
            double dias = diferencia.TotalDays;
            double anios = Math.Floor(dias / 365);
            añosCum.Text = anios.ToString();
        }

        //De aqui para abajo son eventos keypress
        //Para validar que ciertos textbox admitan solo letros o numeros
        //o tambien numeros y letras
        //o también numeros y guiones
        private void añosCum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void apellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void apellidoMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void apellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void apellidoPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void calle_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void calleT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void canalizado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void cicloEsc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void colonia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void coloniaT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void curp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void escuelaP_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void grupoSanguineo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            if (e.KeyChar == '+')
            {
                e.Handled = false;
            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void nombreAl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void nombreT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void numeroCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void numeroCasaT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void ocupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void servMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void telCasaT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void telMovilT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void telPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void telTrabajoT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        //Metodo para validar misma dirección de alumno y tutor
        private void direccionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            numeroCasaT.Visible = false;
            coloniaT.Visible = false;
            calleT.Visible = false;
            calleDatoLabel.Visible = true;
            numeroDatoLabel.Visible = true;
            coloniaDatoLabel.Visible = true;

            calleDatoLabel.Text = calle.Text;
            numeroDatoLabel.Text = numeroCasa.Text;
            coloniaDatoLabel.Text = colonia.Text;

            calleT.Text = calle.Text;
            numeroCasaT.Text = numeroCasa.Text;
            coloniaT.Text = colonia.Text;

            if (direccionCheckBox.Checked == false)
            {
                calleT.Text = "";
                calleT.Enabled = true;
                numeroCasaT.Text = "";
                numeroCasaT.Enabled = true;
                coloniaT.Text = "";
                coloniaT.Enabled = true;

                numeroCasaT.Visible = true;
                coloniaT.Visible = true;
                calleT.Visible = true;
                calleDatoLabel.Visible = false;
                numeroDatoLabel.Visible = false;
                coloniaDatoLabel.Visible = false;
            }
        }

        //Metodo para dar de alta enfermedades
        private void agregarEnfermedadesButton_Click_1(object sender, EventArgs e)
        {
            enfermedadesRichTextBox.Clear();
            int posicioncomboboxTemporal = 0;

            try
            {
                if (enfermedadesCombobox.SelectedItem == null)
                {

                    MessageBox.Show("Seleccione una enfermedad!");

                }
                else
                {

                    if (listaEnfermedades.Contains(enfermedadesCombobox.SelectedItem.ToString())) 
                    {

                        MessageBox.Show("No se admiten registros duplicados");

                    }
                    else
                    {

                        listaEnfermedades.Add(enfermedadesCombobox.SelectedItem.ToString());


                        posicioncomboboxTemporal = enfermedadesCombobox.SelectedIndex;


                        enfermedadestempcmb.SelectedIndex = posicioncomboboxTemporal;

                    
                        idenfermermedadesListaAlta.Add(int.Parse(enfermedadestempcmb.SelectedItem.ToString()));

                    }

                    foreach (var item in listaEnfermedades)
                    {

                        enfermedadesRichTextBox.AppendText(item.ToString()+ "\n");

                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al agregar una enfermedad!");

            }
        }

        //Metodo para dar de alta discapacidades
        private void agregarDiscapacidadesButton_Click(object sender, EventArgs e)
        {
            discapacidadesRichTextBox.Clear();
            int posicioncomboboxTemporal = 0;

            try
            {
                if (discapacidadesCombobox.SelectedItem == null)
                {

                    MessageBox.Show("Seleccione una discapacidad!");

                }
                else
                {

                    if (listaDiscapacidades.Contains(discapacidadesCombobox.SelectedItem.ToString()))
                    {

                        MessageBox.Show("No se admiten registros duplicados");

                    }
                    else
                    {

                        listaDiscapacidades.Add(discapacidadesCombobox.SelectedItem.ToString());


                        posicioncomboboxTemporal = discapacidadesCombobox.SelectedIndex;

                        discapacidadestempcmb.SelectedIndex = posicioncomboboxTemporal;


                        iddiscapacidadesListaAlta.Add(int.Parse(discapacidadestempcmb.SelectedItem.ToString()));


                    }

                    foreach (var item in listaDiscapacidades)
                    {

                        discapacidadesRichTextBox.AppendText(item.ToString() + "\n");


                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al agregar una discapacidad");

            }
        }


        private void agregarAlergiasButton_Click_1(object sender, EventArgs e)
        {
            alergiasRichTextBox.Clear();
            int posicioncomboboxTemporal = 0;

            try
            {
                if (alergiasCombobox.SelectedItem == null)
                {

                    MessageBox.Show("Seleccione una alergia!");

                }
                else
                {

                    if (listaAlergias.Contains(alergiasCombobox.SelectedItem.ToString()))
                    {

                        MessageBox.Show("No se admiten registros duplicados");

                    }
                    else
                    {

                        listaAlergias.Add(alergiasCombobox.SelectedItem.ToString());


                        posicioncomboboxTemporal = alergiasCombobox.SelectedIndex;


                        alergiastempcmb.SelectedIndex = posicioncomboboxTemporal;


                        idalergiasListaAlta.Add(int.Parse(alergiastempcmb.SelectedItem.ToString()));


                    }

                    foreach (var item in listaAlergias)
                    {

                        alergiasRichTextBox.AppendText(item.ToString() + "\n");

                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al agregar la alaergia");

            }
        }




        private void eliminarAlergiasButton_Click_1(object sender, EventArgs e)
        {
            alergiasRichTextBox.Clear();
        }

        private void eliminarDiscapacidadesButton_Click_1(object sender, EventArgs e)
        {
            discapacidadesRichTextBox.Clear();
        }

        private void eliminarEnfermedadesButton_Click(object sender, EventArgs e)
        {
            enfermedadesRichTextBox.Clear();
        }

        private void eliminarTratamientosButton_Click(object sender, EventArgs e)
        {
            tratamiento.Clear();
        }

    }
}

