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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
            Edder.botonBuscar(buscarButton);
            Edder.botonEliminar(eliminarButton);
            Edder.botonModificar(modificarButton);
            Edder.consultaDataView(altaDataGridView);
            Edder.etiquetaConsulta(consultaLabel);
            Edder.filtro(filtroLabel);
            Edder.filtroCombo(filtradoComboBox);
            Edder.Nombretxt(nombreTextBox);
            Edder.panelNavBar(navBarPanel);
            Edder.agregarBttn(agregarButton);
            Edder.alumnosbttn(alumnosButton);
            Edder.docentesbttn(docentesButton);
            Edder.Nombrelbl(nombreLabel);
            Edder.ApellidopaternoTxt(apellidoPaternoTextBox);
            Edder.ApellidomaternoTxt(apellidoMaternoTextBox);
            Edder.Apellidopaterno(apellidoPaternoLabel);
            Edder.Apellidomaterno(apellidoMaternoLabel);
            Edder.Vaciarbttn(vaciarButton);
            Edder.groupboxinferior(busquedaGroupBox);
            Edder.botonImprimir(imprimirButton);
        }


        private void Consultas_Load(object sender, EventArgs e)
        {
            //altaDataGridView.DataSource = businessLayer.Gabriel.alumnosGet();
            
        }

        private void agregarButton_Click_1(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.Close();
            altaAlumno altas = new altaAlumno();
            altas.Show();
            
        }

        private void modificarButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            modificacionesAlumno formModificacion = new modificacionesAlumno();
            formModificacion.Show();
        }

        private void altaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
