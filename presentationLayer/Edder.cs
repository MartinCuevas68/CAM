using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    class Edder
    {
        public static void botonBuscar(Button buscarButton)
        {
            buscarButton.Location = new Point(800, 110);
            buscarButton.Size = new Size(85, 30);
            buscarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);

        }

        public static void botonImprimir(Button imprimirButton)
        {
            imprimirButton.Location = new Point(1192, 58);
            imprimirButton.Size = new Size(75, 23);

        }
        public static void botonEliminar(Button eliminarButton)
        {
            eliminarButton.Location = new Point(1168, 110);
            eliminarButton.Size = new Size(120, 30);
         eliminarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }
        public static void botonModificar(Button modificarButton)
        {
            modificarButton.Location = new Point(1030, 110);
            modificarButton.Size = new Size(120, 30);
            modificarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);

        }
        public static void consultaDataView(DataGridView consultaDataGridView)
        {
            consultaDataGridView.Location = new Point(40, 105);
            consultaDataGridView.Size = new Size(1315, 405);
        }
        public static void etiquetaConsulta(Label consultaLabel)
        {

            consultaLabel.Location = new Point(45, 60); //cambio
            consultaLabel.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
            consultaLabel.Size = new Size(50, 50);
        }

        public static void filtro(Label filtroLabel)
        {
            filtroLabel.Location = new Point(40, 523);
            filtroLabel.Font = new Font("Leelawadee UI", 12);
            filtroLabel.Size = new Size(50, 50);
        }

        public static void filtroCombo(ComboBox filtradoComboBox)
        {
            filtradoComboBox.Location = new Point(170, 523);
        }
        public static void Nombretxt(TextBox nombreTextBox)
        {
            nombreTextBox.Location = new Point(125, 50);

        }

        public static void panelNavBar(Panel navBarPanel)
        {
            navBarPanel.Location = new Point(-1, 0);
            navBarPanel.Size = new Size(1371, 44);
        }

        public static void agregarBttn(Button agregarButton)
        {
            agregarButton.Location = new Point(1094, 58);
            agregarButton.Size = new Size(75, 23);
        }

        public static void alumnosbttn(Button alumnosButton)
        {
            alumnosButton.Location = new Point(1184, 12);
            alumnosButton.Size = new Size(75, 23);

        }

        public static void docentesbttn(Button docentesButton)
        {
            docentesButton.Location = new Point(1266, 12);
            docentesButton.Size = new Size(75, 23);
        }


        public static void Nombrelbl(Label nombreLabel)
        {
            nombreLabel.Location = new Point(20, 50);
            nombreLabel.Font = new Font("Leelawadee UI", 12);
        }

        public static void ApellidopaternoTxt(TextBox apellidoPaternoTextBox)
        {
            apellidoPaternoTextBox.Location = new Point(475, 50);
        }

        public static void ApellidomaternoTxt(TextBox apellidoMaternoTextBox)
        {
            apellidoMaternoTextBox.Location = new Point(830, 50);
        }

        public static void Apellidopaterno(Label apellidoPaternoLabel)
        {
            apellidoPaternoLabel.Location = new Point(300, 50);
            apellidoPaternoLabel.Font = new Font("Leelawadee UI", 12);
        }

        public static void Apellidomaterno(Label apellidoMaternoLabel)
        {
            apellidoMaternoLabel.Location = new Point(650, 50);
            apellidoMaternoLabel.Font = new Font("Leelawadee UI", 12);
        }

        public static void Vaciarbttn(Button vaciarButton)
        {

            vaciarButton.Location = new Point(900, 110);
            vaciarButton.Size = new Size(85, 30);
            vaciarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }

        public static void groupboxinferior(GroupBox busquedaGroupBox)
        {
                busquedaGroupBox.Location = new Point(37, 570);
          busquedaGroupBox.Size = new Size(1303, 154);
        }
    }

}
