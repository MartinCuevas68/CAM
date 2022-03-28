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
    public partial class ConsultaAlumno : Form
    {

        public DataGridViewCheckBoxColumn checkboxDgv = new DataGridViewCheckBoxColumn();
        DataTable data = new DataTable();


        public ConsultaAlumno()
        {
            InitializeComponent();
            PLConsultaAlumno.consultaBotonesAlumnos(agregarButton,modificarButton,eliminarButton);
            consultaBotonesParaNavegar(cerrarSesionButton,imprimirFormatosButton,fichaTecnicaButton);
            consultaBusquedaAlumnos(busquedaPanel,busquedaTextBox, buscarButton);
            tituloAlumnos(consultaLabel);
        }


        private void Consultas_Load(object sender, EventArgs e)
        {
            altaDataGridView.DataSource = businessLayer.BLConsultaAlumno.alumnosGet();

            altaDataGridView.AllowUserToOrderColumns = true;
            altaDataGridView.AllowUserToResizeColumns = true;
            
            altaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            altaDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //altaDataGridView.Columns[1].Visible = true;
            //altaDataGridView.Columns[2].Visible = false;
            //altaDataGridView.Columns[7].Visible = false;
            //altaDataGridView.Columns[3].Visible = false;
            altaDataGridView.Columns[0].HeaderCell.Value = "Matrícula";
            altaDataGridView.Columns[1].HeaderCell.Value = "Nombre";
            altaDataGridView.Columns[2].HeaderCell.Value = "Teléfono contacto de emergencia";
            altaDataGridView.Columns[3].HeaderCell.Value = "Alergias";
            altaDataGridView.Columns[4].HeaderCell.Value = "Discapacidades";
            /*altaDataGridView.Columns[3].HeaderCell.Value = "Nombre";
            altaDataGridView.Columns[4].HeaderCell.Value = "Apellido paterno";
            altaDataGridView.Columns[5].HeaderCell.Value = "Apellido materno";
            altaDataGridView.Columns[6].HeaderCell.Value = "Fecha de nacimiento";
            altaDataGridView.Columns[7].HeaderCell.Value = "Edad";
            altaDataGridView.Columns[8].HeaderCell.Value = "Curp";
            altaDataGridView.Columns[9].HeaderCell.Value = "Estado";
            altaDataGridView.Columns[10].HeaderCell.Value = "Ciudad";
            altaDataGridView.Columns[11].HeaderCell.Value = "Colonia";
            altaDataGridView.Columns[12].HeaderCell.Value = "Calle";
            altaDataGridView.Columns[13].HeaderCell.Value = "Numero";
            altaDataGridView.Columns[14].HeaderCell.Value = "Telefono";
            altaDataGridView.Columns[15].HeaderCell.Value = "Escuela";
            altaDataGridView.Columns[16].HeaderCell.Value = "Atendido";*/
            checkboxDgv.HeaderText = "Selección";
            checkboxDgv.Name = "chbSeleccion";
            checkboxDgv.FlatStyle = FlatStyle.Standard;
            altaDataGridView.Columns.Add(checkboxDgv);

            altaDataGridView.Location = new Point(230,220);
            altaDataGridView.Size = new Size(1070, 420);

            //Sentencia que manda a llamar el método para cerrar Consultas usando la X
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
            data = businessLayer.BLConsultaAlumno.ConvertToDatatable((List<_1dataLayer.alumnoenfermedadDTO>)altaDataGridView.DataSource);
        }

        //Metodo para cerrar Consultas usando la X ya que antes se cerraba pero se seguía ejecutando.
        private void cerrarForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modificarButton_Click_1(object sender, EventArgs e)
        {
            int id = 0;


            foreach (DataGridViewRow row in this.altaDataGridView.Rows)
            {

                if (Convert.ToBoolean(row.Cells[17].Value) == true)
                {

                    id = Convert.ToInt32(row.Cells[0].Value);
                }

            }


            if (id != 0)
            {
                Contenedor.id = id;

                ConsultaAlumno consultas = new ConsultaAlumno();
                consultas.Close();

                modificacionesAlumno modificacionesAlumno = new modificacionesAlumno();
                modificacionesAlumno.Show();             
        
            }
            else
            {

                MessageBox.Show("No se ha seleccionado un campo");

            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int flag = 0;

            foreach (DataGridViewRow row in this.altaDataGridView.Rows)
            {

                if (Convert.ToBoolean(row.Cells[17].Value) == true)
                {
                    flag = 1;

                    id = Convert.ToInt32(row.Cells[0].Value);
                }

            }

            if (flag == 1)
            {

                var confirm = MessageBox.Show("¿Estas Seguro de borrar esta fila ?", "¡Confirmar Borrado!", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {

                    businessLayer.BLEliminacionAlumno.EliminarColaborador(id);

                    altaDataGridView.DataSource = businessLayer.BLConsultaAlumno.alumnosGet();

                    MessageBox.Show("Eliminado correctamente");

                }
                else
                {

                    MessageBox.Show("Operacion Cancelada");


                }

            }
            else
            {

                MessageBox.Show("No se ha seleccionado una fila");
            }

        }

      
        public void tituloAlumnos(Label titulo)
        {
            //tamaño pantalla
            logo.Location = new Point(50, 20);

            //TITULO PRINCIPAL
            titulo.Location = new Point(620, 50);
        }

        public void consultaBusquedaAlumnos(Panel panelB, TextBox txBusqueda, Button buscar)
        {
            panelB.Location = new Point(540,120);
            
            panelB.Size = new Size(400, 50);
            buscar.Size = new Size(30, 30);
            txBusqueda.Size = new Size(335, 45);
            txBusqueda.Font = new Font("Gadugi", 14);
        }

        public void consultaBotonesParaNavegar(Button cerrarSesion, Button imprimir, Button fichaTecnica)
        {
            int x = this.ClientSize.Width, y = this.ClientSize.Height;


            cerrarSesion.Location = new Point(230, 660);
            imprimir.Location = new Point(900, 660);
            fichaTecnica.Location = new Point(1120, 660);

            cerrarSesion.Size = new Size(180, 75);
            imprimir.Size = new Size(200, 75);
            fichaTecnica.Size = new Size(180, 75);
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            ConsultaAlumno consultas = new ConsultaAlumno();
            consultas.Close();
            this.Hide();
            altaAlumno altas = new altaAlumno();
            altas.Show();
        }

        private void eliminarButton_Click_1(object sender, EventArgs e)
        {

        }

        private void imprimirFormatosButton_Click(object sender, EventArgs e)
        {

        }

        private void fichaTecnicaButton_Click(object sender, EventArgs e)
        {
            String id;
            int id2 = 0;
            foreach (DataGridViewRow row in this.altaDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[5].Value) == true)
                {
                    id = Convert.ToString(row.Cells[0].Value);
                    id2 = int.Parse(id);
                    MessageBox.Show(id);
                }
            }
            ConsultaAlumno consultas = new ConsultaAlumno();
            consultas.Close();
            this.Hide();
            fichaTecnica ficha = new fichaTecnica(id2);
            ficha.Show();
        }


        private void busquedaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void busquedaTextBox_TextChanged_1(object sender, EventArgs e)
        {
            //AQUI ESTA EL PROBLEMA, CHECAR EL METODO
            string searchValue = busquedaTextBox.Text.Trim().ToUpper();
            try
            {
                var re = from row in data.AsEnumerable()
                         where row[1].ToString().ToUpper().Contains(searchValue)
                         select row;
                if (re.Count() == 0)
                {
                    //MessageBox.Show("No row");
                }
                else
                {
                    altaDataGridView.DataSource = re.CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
