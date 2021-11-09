using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    class Edder
    {
        public static void botonBuscar(Button buscarButton1)
        {
            buscarButton1.Location = new Point(868, 132);
            buscarButton1.Size = new Size(63, 23);

        }

     
        public static void botonEliminar(Button EliminarButton)
        {
            EliminarButton.Location = new Point(1146, 132);
            EliminarButton.Size = new Size(117, 23);
        }
        public static void botonModificar(Button ModificarButton)
        {
            ModificarButton.Location = new Point(1059, 132);
            ModificarButton.Size = new Size(81, 23);

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
        public static void buscar(Label buscarLabel)
        {
            buscarLabel.Location = new Point(60, 555);
            buscarLabel.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
            buscarLabel.Size = new Size(50, 50);
        }
        public static void filtroCombo(ComboBox filtradocomboBox1)
        {
            filtradocomboBox1.Location = new Point(170, 523);
        }
        public static void Nombretxt(TextBox NombreTextBox)
        {
            NombreTextBox.Location = new Point(135, 87);

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

        public static void inferiorpnl(Panel InferiorPanel)
        {
            InferiorPanel.Size = new Size(1294, 173);
        }

        public static void Nombrelbl(Label NombreLabel)
        {
            NombreLabel.Location = new Point(35, 87);
            NombreLabel.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }

        public static void ApellidopaternoTxt(TextBox ApellidoPaternoTextBox)
        {
            ApellidoPaternoTextBox.Location = new Point(490, 87);
        }

        public static void ApellidomaternoTxt(TextBox ApellidoMaternoTextBox)
        {
            ApellidoMaternoTextBox.Location = new Point(850, 87);
        }

        public static void Apellidopaterno(Label ApellidoPaternoLabel1)
        {
            ApellidoPaternoLabel1.Location = new Point(320, 87);
            ApellidoPaternoLabel1.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }

        public static void Apellidomaterno(Label ApellidoMaternoLabel2)
        {
            ApellidoMaternoLabel2.Location = new Point(675, 87);
            ApellidoMaternoLabel2.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
        }

        public static void Vaciarbttn(Button VaciarButton)
        {
            VaciarButton.Location = new Point(937, 132);
            VaciarButton.Size = new Size(63, 23);
        }

        public static void botonImprimir(Button ImprimirButton)
        {
            ImprimirButton.Location = new Point(1192, 58);
            ImprimirButton.Size = new Size(75, 23);
        }
    }
}
