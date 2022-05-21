using presentationLayer.Forms.BajaAlumno;
using presentationLayer.Forms.ConsultaFormatos;
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

      
        DataTable data = new DataTable();
        string varfiltro;
        int bandera = 0;
        public ConsultaAlumno()
        {
            InitializeComponent();
            PLConsultaAlumno.consultaBotonesAlumnos(agregarButton,modificarButton,eliminarButton);
            PLConsultaAlumno.consultaFiltroAlumnos(filtrarPorLabel,filtrarPorCheckBox);
            PLConsultaAlumno.consultaBotonesParaNavegar(cerrarSesionButton,imprimirFormatosButton,fichaTecnicaButton);
            PLConsultaAlumno.consultaBusquedaAlumnos(busquedaPanel,busquedaTextBox, buscarButton);
            PLConsultaAlumno.tituloAlumnos(consultaLabel, logo, altaDataGridView);
             altaDataGridView.ReadOnly = true;
        }

        public void actualizartabla()
        {
            altaDataGridView.DataSource = businessLayer.BLConsultaAlumno.alumnosGet();
            altaDataGridView.Refresh();
            this.Refresh();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
            altaDataGridView.DataSource = businessLayer.BLConsultaAlumno.alumnosGet();
           
            altaDataGridView.AllowUserToOrderColumns = true;
            altaDataGridView.AllowUserToResizeColumns = true;
            buscarButton.Enabled = false;

            altaDataGridView.RowsDefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            altaDataGridView.RowsDefaultCellStyle.Font = new Font("Gadugi", 11);
            altaDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            altaDataGridView.AlternatingRowsDefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            altaDataGridView.AlternatingRowsDefaultCellStyle.Font = new Font("Gadugi", 11);
            altaDataGridView.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            altaDataGridView.AlternatingRowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            altaDataGridView.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            altaDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Gadugi", 11);
            altaDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            altaDataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            altaDataGridView.DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            altaDataGridView.DefaultCellStyle.Font = new Font("Gadugi", 11);
            altaDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            altaDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            altaDataGridView.RowHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            altaDataGridView.RowHeadersDefaultCellStyle.Font = new Font("Gadugi", 11);
            altaDataGridView.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            altaDataGridView.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            altaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            altaDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            altaDataGridView.AutoResizeColumns();
            altaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
             altaDataGridView.ReadOnly = true;

            /*altaDataGridView.Columns[0].HeaderCell.Value = "Matrícula";
            altaDataGridView.Columns[1].HeaderCell.Value = "Nombre";
            altaDataGridView.Columns[2].HeaderCell.Value = "Teléfono contacto de emergencia";
            altaDataGridView.Columns[3].HeaderCell.Value = "Alergias";
            altaDataGridView.Columns[4].HeaderCell.Value = "Discapacidades";
            */
            
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

                    //businessLayer.BLEliminacionAlumno.EliminarColaborador(id);

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

        private void modificarButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            id = int.Parse(altaDataGridView.CurrentRow.Cells[0].Value.ToString());
            ConsultaAlumno consultas = new ConsultaAlumno();
            consultas.Close();
            this.Hide();
            fichaTecnica ficha = new fichaTecnica(id,1);
            ficha.Show();
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
            int id = 0;
            id = int.Parse(altaDataGridView.CurrentRow.Cells[0].Value.ToString());
            bajaAlumno baja = new bajaAlumno(id,this);
            baja.ShowDialog();
        }

        private void imprimirFormatosButton_Click(object sender, EventArgs e)
        {
            ConsultaAlumno consultas = new ConsultaAlumno();
            consultas.Close();
            this.Hide();
            consultaFormatos consultaF = new consultaFormatos();
            consultaF.Show();
        }

        private void fichaTecnicaButton_Click(object sender, EventArgs e)
        {
            //Int32 selectedCellCount =  altaDataGridView.GetCellCount(DataGridViewElementStates.Selected);
            int id = 0;
            id = int.Parse(altaDataGridView.CurrentRow.Cells[0].Value.ToString());
            ConsultaAlumno consultas = new ConsultaAlumno();
            consultas.Close();
            this.Hide();
            fichaTecnica ficha = new fichaTecnica(id,0);
            ficha.Show();
        }

        private void busquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = busquedaTextBox.Text.Trim().ToUpper();
            try
            {
                var re = from row in data.AsEnumerable()
                         where row[1].ToString().ToUpper().Contains(searchValue)
                         select row;

                var re2 = from row in data.AsEnumerable()
                         where row[0].ToString().ToUpper().Contains(searchValue)
                         select row;

                if (re.Count() == 0 && re2.Count() == 0)
                {
                    if (bandera == 0)
                    {
                        bandera = 1;
                        MessageBox.Show("No se ha encontrado el alumno", "Dato no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        altaDataGridView.DataSource = "";
                    }
                }
                else
                {
                    if (re2.Count() == 0)
                    {
                        if (bandera == 1)
                        {
                            altaDataGridView.DataSource = businessLayer.BLConsultaAlumno.alumnosGet();
                            data = businessLayer.BLConsultaAlumno.ConvertToDatatable((List<_1dataLayer.alumnoenfermedadDTO>)altaDataGridView.DataSource);
                        }
                        bandera = 0;
                        altaDataGridView.DataSource = re.CopyToDataTable();
                    }
                    else
                    {
                        if (bandera == 1)
                        {
                            altaDataGridView.DataSource = businessLayer.BLConsultaAlumno.alumnosGet();
                            data = businessLayer.BLConsultaAlumno.ConvertToDatatable((List<_1dataLayer.alumnoenfermedadDTO>)altaDataGridView.DataSource);
                        }
                        bandera = 0;
                        altaDataGridView.DataSource = re2.CopyToDataTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        

        private void filtrarPorCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtrarPorCheckBox.SelectedItem.ToString().Equals("Todos"))
            {
                altaDataGridView.DataSource = businessLayer.BLConsultaAlumno.alumnosGet();
                data = businessLayer.BLConsultaAlumno.ConvertToDatatable((List<_1dataLayer.alumnoenfermedadDTO>)altaDataGridView.DataSource);
            }
            else
            {
                varfiltro = filtrarPorCheckBox.SelectedItem.ToString();
                altaDataGridView.DataSource = businessLayer.BLConsultaAlumno.alumnosfiltradosGet(filtrarPorCheckBox.SelectedItem.ToString());
                data = businessLayer.BLConsultaAlumno.ConvertToDatatable((List<_1dataLayer.alumnoenfermedadDTO>)altaDataGridView.DataSource);
            }
        }

        private void egresadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
