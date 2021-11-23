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
            Edder.consultaDataView(DataGridView);
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

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            modificacionesAlumno formModificacion = new modificacionesAlumno();
            formModificacion.Show();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            altaAlumno formAlta = new altaAlumno();
            formAlta.Show();
        }
    }
}
