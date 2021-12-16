using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    class Edder
    {

        public static void etiquetaConsulta(Label consultaLabel)
        {

            consultaLabel.Location = new Point(700, 150); 
            consultaLabel.Font = new Font("Leelawadee UI", 36, FontStyle.Bold);
   
        }


        public static void botonBuscar(Button buscarButton)
        {
            buscarButton.Location = new Point(1110, 43);
            buscarButton.Size = new Size(35, 28);
            buscarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
            var tt = new ToolTip();
            tt.SetToolTip(buscarButton, "REALIZAR CONSULTA");
        }

        public static void botonImprimir(Button imprimirButton)
        {
            imprimirButton.Location = new Point(1320, 58);
            imprimirButton.Size = new Size(35, 28);
            var tt = new ToolTip();
            tt.SetToolTip(imprimirButton, "REALIZAR IMPRESIÓN DEL DOCUMENTO");

        }

        public static void agregarButton(Button agregarButton)
        {
            agregarButton.Location = new Point(1600, 300);
            agregarButton.Size = new Size(75, 75);
            var tt = new ToolTip();
            tt.SetToolTip(agregarButton, "REALIZAR UNA ALTA DE ALUMNO");
        }

        public static void botonModificar(Button modificarButton)
        {
            modificarButton.Location = new Point(1500, 300);
            modificarButton.Size = new Size(75, 75);
            modificarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
            var tt = new ToolTip();
            tt.SetToolTip(modificarButton, "REALIZAR MODIFICACÍÓN DEL ALUMNO");

        }

        public static void botonEliminar(Button eliminarButton)
        {
            eliminarButton.Location = new Point(1400, 300);
            eliminarButton.Size = new Size(75, 75);
         eliminarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
            var tt = new ToolTip();
            tt.SetToolTip(eliminarButton, "REALIZAR ELIMINACIÓN DEL ALUMNO");
        }
       
        public static void consultaDataView(DataGridView altaDataGridView)
        {
            altaDataGridView.Location = new Point(200, 400);
            altaDataGridView.Size = new Size(1500, 400);
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
            filtradoComboBox.Font =new Font("Leelawadee UI", 10);
        }
        public static void Nombretxt(TextBox nombreTextBox)
        {
            nombreTextBox.Location = new Point(125, 50);
            nombreTextBox.Font = new Font("Leelawadee UI", 10);
          
        
        }

        public static void panelNavBar(Panel navBarPanel)
        {
            navBarPanel.Location = new Point(-1, 0);
            navBarPanel.Size = new Size(1371, 100);
        }

      
        public static void alumnosbttn(Button alumnosButton)
        {
            alumnosButton.Size = new Size(100, 75);
            var tt = new ToolTip();
            tt.SetToolTip(alumnosButton, "MENÚ DE ALUMNOS");
            alumnosButton.Font = new Font("Leelawadee UI", 12);

        }

        public static void docentesbttn(Button docentesButton)
        {
            docentesButton.Location = new Point(1266, 12);
            docentesButton.Size = new Size(75, 23);
            var tt = new ToolTip();
            tt.SetToolTip(docentesButton, "MENÚ DE DOCENTES");
        }


        public static void Nombrelbl(Label nombreLabel)
        {
            nombreLabel.Location = new Point(20, 50);
            nombreLabel.Font = new Font("Leelawadee UI", 12);
        }

        public static void ApellidopaternoTxt(TextBox apellidoPaternoTextBox)
        {
            apellidoPaternoTextBox.Location = new Point(475, 50);
            apellidoPaternoTextBox.Font = new Font("Leelawadee UI", 10);
      
        }

        public static void ApellidomaternoTxt(TextBox apellidoMaternoTextBox)
        {
            apellidoMaternoTextBox.Location = new Point(830, 50);
            apellidoMaternoTextBox.Font = new Font("Leelawadee UI", 10);
   
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

            vaciarButton.Location = new Point(1150, 43);
            vaciarButton.Size = new Size(35, 28);
            vaciarButton.Font = new Font("Leelawadee UI", 12, FontStyle.Bold);
            var tt = new ToolTip();
            tt.SetToolTip(vaciarButton, "VACIAR CAMPOS DE TEXTO");
        }

        public static void groupboxinferior(GroupBox busquedaGroupBox)
        {
                busquedaGroupBox.Location = new Point(37, 570);
          busquedaGroupBox.Size = new Size(1303, 154);
        }
    }

}
