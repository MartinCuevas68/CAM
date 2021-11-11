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
            Edder.botonBuscar(buscarButton1);
            Edder.botonEliminar(eliminarButton);
            Edder.botonModificar(ModificarButton);
            Edder.consultaDataView(panelConsulta_dataGridView);
            Edder.etiquetaConsulta(consultaLabel);
            Edder.filtro(filtroLabel);
            Edder.filtroCombo(FiltradocomboBox1);
            Edder.Nombretxt(NombreTextBox);
            Edder.panelNavBar(NavBarPanel);
            Edder.agregarBttn(AgregarButton);
            Edder.alumnosbttn(AlumnosButton);
            Edder.docentesbttn(DocentesButton);
            Edder.Nombrelbl(NombreLabel);
            Edder.ApellidopaternoTxt(ApellidoPaternoTextBox1);
            Edder.ApellidomaternoTxt(ApellidoMaternoTextBox2);
            Edder.Apellidopaterno(ApellidoPaternoLabel);
            Edder.Apellidomaterno(ApellidoMaternoLabel);
            Edder.Vaciarbttn(VaciarButton);
            Edder.botonImprimir(ImprimirButton);
            Edder.groupboxinferior(BusquedaGroupBox);

        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FiltradocomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BusquedaGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
