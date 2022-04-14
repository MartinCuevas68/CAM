using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer.Forms.BajaAlumno
{
    public partial class bajaAlumno : Form
    {
        public bajaAlumno()
        {
            InitializeComponent();
            PLBajaAlumno.datosAlumno(foto, nombreAlLabel, nombreAl, matriculaLabel, matricula, tipoIngresoLabel,
                                    tipoIngreso, edadLabel, edad, curpLabel, curp);
            PLBajaAlumno.plantillaBajas(tituloLabel, pregunta, cancelarBajaButton, continuarBajaButton);

            //Ejemplo
            nombreAl.Text = "MARCOS DANIEL ZAVALA MARTINEZ";
            matricula.Text = "1002";
            tipoIngreso.Text = "NUEVO INGRESO";
            edad.Text = "23";
            curp.Text = "ZAMM990220MBCMZV2F";

        }

        private void cancelarBajaButton_Click(object sender, EventArgs e)
        {
            bajaAlumno baja = new bajaAlumno();
            baja.Close();
            this.Hide();
        }
    }
}
