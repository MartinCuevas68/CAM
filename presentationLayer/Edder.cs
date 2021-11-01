using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    class Edder
    {
        public static void botonBuscar(Button buscarButton1)
        {
            buscarButton1.Location = new Point(655, 370);
            buscarButton1.Size = new Size(60, 40);

        }

        public static void botonImprimir(Button imprimirButton)
        {
            imprimirButton.Location = new Point(730, 370);
            imprimirButton.Size = new Size(60, 40);

        }
        public static void botonEliminar(Button EliminarButton)
        {
            EliminarButton.Location = new Point(655, 420);
            EliminarButton.Size = new Size(60, 40);
        }
        public static void botonRegresar(Button regresarButton)
        {
            regresarButton.Location = new Point(730, 420);
            regresarButton.Size = new Size(60, 40);
        }
        public static void consultaDataView(DataGridView panelConsulta_dataGridView)
        {
            panelConsulta_dataGridView.Location = new Point(40, 60);
            panelConsulta_dataGridView.Size = new Size(770, 280);
        }
        public static void etiquetaConsulta(Label consultaLabel)
        {

            consultaLabel.Location = new Point(35, 20);
            consultaLabel.Size = new Size(50, 50);
        }

        public static void filtro(Label filtroLabel)
        {
            filtroLabel.Location = new Point(40, 370);
            filtroLabel.Size = new Size(50, 50);
        }
        public static void buscar(Label buscarLabel)
        {
            buscarLabel.Location = new Point(40, 420);
            buscarLabel.Size = new Size(50, 50);
        }
        public static void filtroCombo(ComboBox filtradocomboBox1)
        {
            filtradocomboBox1.Location = new Point(112, 369);
        }
        public static void buscartxt(TextBox buscartextBox)
        {
            buscartextBox.Location = new Point(103, 418);

        }

    }
}
