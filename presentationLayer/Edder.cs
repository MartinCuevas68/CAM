using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    class Edder
    {
        public static void botonBuscar(Button buscarButton1)
        {
            buscarButton1.Location = new Point(655, 400);
            buscarButton1.Size = new Size(60, 40);

        }

        public static void botonImprimir(Button imprimirButton)
        {
            imprimirButton.Location = new Point(730, 400);
            imprimirButton.Size = new Size(60, 40);

        }
        public static void botonEliminar(Button EliminarButton)
        {
            EliminarButton.Location = new Point(655, 450);
            EliminarButton.Size = new Size(60, 40);
        }
        public static void botonRegresar(Button regresarButton)
        {
            regresarButton.Location = new Point(730, 450);
            regresarButton.Size = new Size(60, 40);
        }
        public static void consultaDataView(DataGridView panelConsulta_dataGridView)
        {
            panelConsulta_dataGridView.Location = new Point(40, 105);
            panelConsulta_dataGridView.Size = new Size(770, 280);
        }
        public static void etiquetaConsulta(Label consultaLabel)
        {

            consultaLabel.Location = new Point(35, 28); 
            consultaLabel.Font = new Font("Leelawadee UI", 12, FontStyle.Bold); 
            consultaLabel.Size = new Size(50, 50);
        }

        public static void filtro(Label filtroLabel)
        {
            filtroLabel.Location = new Point(40, 65);
            filtroLabel.Font = new Font("Leelawadee UI", 12);
            filtroLabel.Size = new Size(50, 50);
        }
        public static void buscar(Label buscarLabel)
        {
            buscarLabel.Location = new Point(300, 65);
            buscarLabel.Font = new Font("Leelawadee UI", 12);
            buscarLabel.Size = new Size(50, 50);
        }
        public static void filtroCombo(ComboBox filtradocomboBox1)
        {
            filtradocomboBox1.Location = new Point(116, 65);
        }
        public static void buscartxt(TextBox buscartextBox)
        {
            buscartextBox.Location = new Point(360, 65);

        }

        public static void menuprincipal(MenuStrip menuprincipal)
        {
          
        }
    }
}
