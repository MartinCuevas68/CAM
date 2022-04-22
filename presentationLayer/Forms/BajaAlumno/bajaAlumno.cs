using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer.Forms.BajaAlumno
{
    public partial class bajaAlumno : Form
    {
        _1dataLayer.SP_FichaTecnicaAlumno_Result alumno = new _1dataLayer.SP_FichaTecnicaAlumno_Result();
        _1dataLayer.foto_alumno fotol = new _1dataLayer.foto_alumno();
        int id;
        ConsultaAlumno cons;


        public bajaAlumno(int id_alumno,Form consultas)
        {
            id = id_alumno;
            InitializeComponent();
            PLBajaAlumno.datosAlumno(foto, nombreAlLabel, nombreAl, matriculaLabel, matricula, tipoIngresoLabel,
                                    tipoIngreso, edadLabel, edad, curpLabel, curp);

            PLBajaAlumno.plantillaBajas(tituloLabel, pregunta, cancelarBajaButton, continuarBajaButton);

            alumno = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);
            //Ejemplo
            nombreAl.Text = alumno.nombre +" "+ alumno.apellido_paterno + " "+alumno.apellido_materno;
            matricula.Text = alumno.id_alumno.ToString();
            tipoIngreso.Text = alumno.tipo_ingreso;
            edad.Text = alumno.edad_alumno;
            curp.Text = alumno.CURP_alumno;
            fotol = _1dataLayer.DLConsultaAlumno.ConsultaFoto(id_alumno);
            foto.Image = byteArrayToImage(fotol.imagen_alumno.ToArray());
            if (consultas == null)
            {

            }
            else
            {
                cons = (ConsultaAlumno)consultas;
            }
        }



        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        
        private void cancelarBajaButton_Click(object sender, EventArgs e)
        {
            bajaAlumno baja = new bajaAlumno(id,cons);
            baja.Close();
            this.Hide();
        }
        //Manda el metodo que se encuentra en el DataLayer para eliminar el alumno
        private void continuarBajaButton_Click(object sender, EventArgs e)
        {

            businessLayer.BLEliminacionAlumno.eliminaralumno(id);
            if (cons != null)
            {
                ConsultaAlumno a = cons;
                cons.actualizartabla();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
