using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    class Edder
    {
        public static void botonBuscar(Button buscarButton1)
        {
            buscarButton1.Location = new Point(800, 110);
            buscarButton1.Size = new Size(85, 30);
            buscarButton1.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);

        }

        public static void botonImprimir(Button ImprimirButton)
        {
            ImprimirButton.Location = new Point(1192, 58);
            ImprimirButton.Size = new Size(75, 23);

        }
        public static void botonEliminar(Button EliminarButton)
        {
            EliminarButton.Location = new Point(1168, 110);
            EliminarButton.Size = new Size(120, 30);
         EliminarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }
        public static void botonModificar(Button ModificarButton)
        {
            ModificarButton.Location = new Point(1030, 110);
            ModificarButton.Size = new Size(120, 30);
            ModificarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);

        }
        public static void consultaDataView(DataGridView panelConsulta_dataGridView)
        {
            panelConsulta_dataGridView.Location = new Point(40, 105);
            panelConsulta_dataGridView.Size = new Size(1315, 405);
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
            filtroLabel.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
            filtroLabel.Size = new Size(50, 50);
        }

        public static void filtroCombo(ComboBox filtradocomboBox1)
        {
            filtradocomboBox1.Location = new Point(170, 523);
        }
        public static void Nombretxt(TextBox NombreTextBox)
        {
            NombreTextBox.Location = new Point(125, 50);

        }

        public static void panelNavBar(Panel NavBarPanel)
        {
            NavBarPanel.Location = new Point(-1, 0);
            NavBarPanel.Size = new Size(1371, 44);
        }

        public static void agregarBttn(Button AgregarButton)
        {
            AgregarButton.Location = new Point(1094, 58);
            AgregarButton.Size = new Size(75, 23);
        }

        public static void alumnosbttn(Button AlumnosButton)
        {
            AlumnosButton.Location = new Point(1184, 12);
            AlumnosButton.Size = new Size(75, 23);

        }

        public static void docentesbttn(Button DocentesButton)
        {
            DocentesButton.Location = new Point(1266, 12);
            DocentesButton.Size = new Size(75, 23);
        }


        public static void Nombrelbl(Label NombreLabel)
        {
            NombreLabel.Location = new Point(20, 50);
            NombreLabel.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }

        public static void ApellidopaternoTxt(TextBox ApellidoPaternoTextBox)
        {
            ApellidoPaternoTextBox.Location = new Point(475, 50);
        }

        public static void ApellidomaternoTxt(TextBox ApellidoMaternoTextBox)
        {
            ApellidoMaternoTextBox.Location = new Point(830, 50);
        }

        public static void Apellidopaterno(Label ApellidoPaternoLabel1)
        {
            ApellidoPaternoLabel1.Location = new Point(300, 50);
            ApellidoPaternoLabel1.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }

        public static void Apellidomaterno(Label ApellidoMaternoLabel2)
        {
            ApellidoMaternoLabel2.Location = new Point(650, 50);
            ApellidoMaternoLabel2.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }

        public static void Vaciarbttn(Button VaciarButton)
        {

            VaciarButton.Location = new Point(900, 110);
            VaciarButton.Size = new Size(85, 30);
            VaciarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }

        public static void groupboxinferior(GroupBox BusquedaGroupBox)
        {
            BusquedaGroupBox.Location = new Point(37, 570);
          BusquedaGroupBox.Size = new Size(1303, 154);
        }
    }

}
