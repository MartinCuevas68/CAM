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
    public partial class bajaAlumnoFicha : Form
    {
        _1dataLayer.SP_FichaTecnicaAlumno_Result alumno = new _1dataLayer.SP_FichaTecnicaAlumno_Result();
        int id;
        fichaTecnica ficha;

        public bajaAlumnoFicha(int id_alumno, Form fichaT)
        {
                id = id_alumno;
                InitializeComponent();
                PLBajaAlumnoFicha.datosAlumnoFicha(nombreAlLabelFT, nombreAlFT, matriculaLabelFT, matriculaFT);
                PLBajaAlumnoFicha.plantillaBajas(tituloLabelFT, preguntaFT, cancelarBajaButtonFT, continuarBajaButtonFT);

                alumno = _1dataLayer.DLConsultaAlumno.FichaTenicaAlumno(id_alumno);
                //Ejemplo
                nombreAlFT.Text = alumno.nombre + " " + alumno.apellido_paterno + " " + alumno.apellido_materno;
                matriculaFT.Text = alumno.id_alumno.ToString();
              
                if (ficha == null)
                {

                }
                else
                {
                    ficha = (fichaTecnica)fichaT;
                }
         }

        private void cancelarBajaButton_Click(object sender, EventArgs e)
        {
            bajaAlumnoFicha bajaFT = new bajaAlumnoFicha(id, ficha);
            bajaFT.Close();
            this.Hide();
        }
    }
    }

