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
            Edder.botonImprimir(imprimirButton);
            Edder.botonEliminar(eliminarButton);
            Edder.botonRegresar(regresarButton);
            Edder.consultaDataView(panelConsulta_dataGridView);
            Edder.etiquetaConsulta(consultaLabel);
            Edder.filtro(filtroLabel);
            Edder.buscar(buscarLabel);
            Edder.filtroCombo(FiltradocomboBox1);
            Edder.buscartxt(buscartextBox);
            Edder.menuprincipal(menuStrip);

        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
