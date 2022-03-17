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
    public partial class fichaTecnica : Form
    {
       
        public fichaTecnica()
        {
            InitializeComponent();
            FichaTec.posicionLabel(logoPictureBox , fichaLabel, infogenLabel,nombreLabel,nombrequeryLabel, edadLabel, edadqueryLabel, fechanacLabel, fechaqueryLabel,
                                    lugarnacLabel, lugarqueryLabel, curpLabel, curpqueryLabel, direccionLabel, direccionqueryLabel,
                                telefonoLabel, telefonoqueryLabel, escuelaLabel, escuelaproqueryLabel, canalizadoLabel, canalizadoqueryLabel, cicloLabel, cicloqueryLabel, tipoingresoLabel ,tipoingresoqueryLabel);

            FichaTec.posicionFotoButtons(fotoalumnoPictureBox, informaciontutorButton, informacionmedicaButton);
        }

        

        private void informacionmedicaButton_Click(object sender, EventArgs e)
        {

        }

        private void informaciontutorButton_Click(object sender, EventArgs e)
        {

        }

    }
}
