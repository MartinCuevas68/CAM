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

        public DataGridViewCheckBoxColumn checkboxDgv = new DataGridViewCheckBoxColumn();


        public Consultas()
        {
            InitializeComponent();
            Edder.botonBuscar(buscarButton);
            Edder.botonEliminar(eliminarButton);
            Edder.botonModificar(modificarButton);
            Edder.consultaDataView(altaDataGridView);
            Edder.etiquetaConsulta(consultaLabel);
            Edder.filtro(filtroLabel);
            Edder.filtroCombo(filtradoComboBox);
            Edder.Nombretxt(nombreTextBox);
            Edder.panelNavBar(navBarPanel);
            Edder.agregarButton(agregarButton);
            Edder.alumnosbttn(alumnosButton);
            //Edder.docentesbttn(docentesButton);
            Edder.Nombrelbl(nombreLabel);
            Edder.ApellidopaternoTxt(apellidoPaternoTextBox);
            Edder.ApellidomaternoTxt(apellidoMaternoTextBox);
            Edder.Apellidopaterno(apellidoPaternoLabel);
            Edder.Apellidomaterno(apellidoMaternoLabel);
            Edder.Vaciarbttn(vaciarButton);
          
            Edder.groupboxinferior(busquedaGroupBox);
            busquedaGroupBox.Hide();
            Edder.botonImprimir(imprimirButton);

            vaciarButton.Hide();
            buscarButton.Hide();
            imprimirButton.Hide();
            filtradoComboBox.Hide();
            filtroLabel.Hide();
            
        }


        private void Consultas_Load(object sender, EventArgs e)
        {
            altaDataGridView.DataSource = businessLayer.Gabriel.alumnosGet();

            altaDataGridView.AllowUserToOrderColumns = true;
            altaDataGridView.AllowUserToResizeColumns = true;

            altaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            altaDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


            checkboxDgv.HeaderText = "Seleccion";
            checkboxDgv.Name = "chbSeleccion";
            checkboxDgv.FlatStyle = FlatStyle.Standard;
            altaDataGridView.Columns.Add(checkboxDgv);

        }

        private void agregarButton_Click_1(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.Close();
            this.Hide();
            altaAlumno altas = new altaAlumno();
            altas.Show();
            



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

                Consultas consultas = new Consultas();
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

                    businessLayer.Martin.EliminarColaborador(id);

                    altaDataGridView.DataSource = businessLayer.Gabriel.alumnosGet();

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
    }
}
