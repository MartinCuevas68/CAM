
namespace presentationLayer
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.FiltradocomboBox1 = new System.Windows.Forms.ComboBox();
            this.consultaLabel = new System.Windows.Forms.Label();
            this.filtroLabel = new System.Windows.Forms.Label();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.buscarButton1 = new System.Windows.Forms.Button();
            this.consultaDataGridView = new System.Windows.Forms.DataGridView();
            this.NavBarPanel = new System.Windows.Forms.Panel();
            this.DocentesButton = new System.Windows.Forms.Button();
            this.AlumnosButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.VaciarButton = new System.Windows.Forms.Button();
            this.ApellidoMaternoTextBox2 = new System.Windows.Forms.TextBox();
            this.ApellidoMaternoLabel = new System.Windows.Forms.Label();
            this.ApellidoPaternoTextBox1 = new System.Windows.Forms.TextBox();
            this.ApellidoPaternoLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.BusquedaGroupBox = new System.Windows.Forms.GroupBox();
            this.eliminarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataGridView)).BeginInit();
            this.NavBarPanel.SuspendLayout();
            this.BusquedaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltradocomboBox1
            // 
            this.FiltradocomboBox1.FormattingEnabled = true;
            this.FiltradocomboBox1.Items.AddRange(new object[] {
            "General",
            "Nombre",
            "Taller"});
            this.FiltradocomboBox1.Location = new System.Drawing.Point(215, 457);
            this.FiltradocomboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FiltradocomboBox1.Name = "FiltradocomboBox1";
            this.FiltradocomboBox1.Size = new System.Drawing.Size(160, 24);
            this.FiltradocomboBox1.TabIndex = 18;
            this.FiltradocomboBox1.SelectedIndexChanged += new System.EventHandler(this.FiltradocomboBox1_SelectedIndexChanged);
            // 
            // consultaLabel
            // 
            this.consultaLabel.AutoSize = true;
            this.consultaLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaLabel.Location = new System.Drawing.Point(32, 43);
            this.consultaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.consultaLabel.Name = "consultaLabel";
            this.consultaLabel.Size = new System.Drawing.Size(111, 28);
            this.consultaLabel.TabIndex = 15;
            this.consultaLabel.Text = "ALUMNOS";
            // 
            // filtroLabel
            // 
            this.filtroLabel.AutoSize = true;
            this.filtroLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filtroLabel.Location = new System.Drawing.Point(33, 457);
            this.filtroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtroLabel.Name = "filtroLabel";
            this.filtroLabel.Size = new System.Drawing.Size(159, 28);
            this.filtroLabel.TabIndex = 13;
            this.filtroLabel.Text = "ORDENAR POR:";
            // 
            // ModificarButton
            // 
            this.ModificarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModificarButton.Location = new System.Drawing.Point(1361, 142);
            this.ModificarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(160, 41);
            this.ModificarButton.TabIndex = 12;
            this.ModificarButton.Text = "MODIFICAR";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // buscarButton1
            // 
            this.buscarButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarButton1.Location = new System.Drawing.Point(1037, 144);
            this.buscarButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buscarButton1.Name = "buscarButton1";
            this.buscarButton1.Size = new System.Drawing.Size(111, 41);
            this.buscarButton1.TabIndex = 11;
            this.buscarButton1.Text = "BUSCAR";
            this.buscarButton1.UseVisualStyleBackColor = true;
            // 
            // consultaDataGridView
            // 
            this.consultaDataGridView.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.consultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaDataGridView.Location = new System.Drawing.Point(37, 91);
            this.consultaDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consultaDataGridView.Name = "consultaDataGridView";
            this.consultaDataGridView.RowHeadersWidth = 51;
            this.consultaDataGridView.Size = new System.Drawing.Size(1749, 351);
            this.consultaDataGridView.TabIndex = 10;
            // 
            // NavBarPanel
            // 
            this.NavBarPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.NavBarPanel.Controls.Add(this.DocentesButton);
            this.NavBarPanel.Controls.Add(this.AlumnosButton);
            this.NavBarPanel.Location = new System.Drawing.Point(-25, 0);
            this.NavBarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NavBarPanel.Name = "NavBarPanel";
            this.NavBarPanel.Size = new System.Drawing.Size(1856, 39);
            this.NavBarPanel.TabIndex = 20;
            // 
            // DocentesButton
            // 
            this.DocentesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocentesButton.Location = new System.Drawing.Point(1736, 4);
            this.DocentesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DocentesButton.Name = "DocentesButton";
            this.DocentesButton.Size = new System.Drawing.Size(100, 28);
            this.DocentesButton.TabIndex = 22;
            this.DocentesButton.Text = "DOCENTES";
            this.DocentesButton.UseVisualStyleBackColor = true;
            // 
            // AlumnosButton
            // 
            this.AlumnosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlumnosButton.Location = new System.Drawing.Point(1627, 4);
            this.AlumnosButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AlumnosButton.Name = "AlumnosButton";
            this.AlumnosButton.Size = new System.Drawing.Size(100, 28);
            this.AlumnosButton.TabIndex = 21;
            this.AlumnosButton.Text = "ALUMNOS";
            this.AlumnosButton.UseVisualStyleBackColor = true;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Location = new System.Drawing.Point(1508, 55);
            this.AgregarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(100, 28);
            this.AgregarButton.TabIndex = 21;
            this.AgregarButton.Text = "AGREGAR";
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // VaciarButton
            // 
            this.VaciarButton.Location = new System.Drawing.Point(1171, 144);
            this.VaciarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VaciarButton.Name = "VaciarButton";
            this.VaciarButton.Size = new System.Drawing.Size(107, 41);
            this.VaciarButton.TabIndex = 24;
            this.VaciarButton.Text = "VACIAR";
            this.VaciarButton.UseVisualStyleBackColor = true;
            // 
            // ApellidoMaternoTextBox2
            // 
            this.ApellidoMaternoTextBox2.Location = new System.Drawing.Point(1228, 91);
            this.ApellidoMaternoTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApellidoMaternoTextBox2.Multiline = true;
            this.ApellidoMaternoTextBox2.Name = "ApellidoMaternoTextBox2";
            this.ApellidoMaternoTextBox2.Size = new System.Drawing.Size(219, 24);
            this.ApellidoMaternoTextBox2.TabIndex = 23;
            // 
            // ApellidoMaternoLabel
            // 
            this.ApellidoMaternoLabel.AutoSize = true;
            this.ApellidoMaternoLabel.Location = new System.Drawing.Point(991, 94);
            this.ApellidoMaternoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApellidoMaternoLabel.Name = "ApellidoMaternoLabel";
            this.ApellidoMaternoLabel.Size = new System.Drawing.Size(215, 28);
            this.ApellidoMaternoLabel.TabIndex = 22;
            this.ApellidoMaternoLabel.Text = "APELLIDO MATERNO:";
            // 
            // ApellidoPaternoTextBox1
            // 
            this.ApellidoPaternoTextBox1.Location = new System.Drawing.Point(681, 95);
            this.ApellidoPaternoTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApellidoPaternoTextBox1.Multiline = true;
            this.ApellidoPaternoTextBox1.Name = "ApellidoPaternoTextBox1";
            this.ApellidoPaternoTextBox1.Size = new System.Drawing.Size(219, 24);
            this.ApellidoPaternoTextBox1.TabIndex = 21;
            // 
            // ApellidoPaternoLabel
            // 
            this.ApellidoPaternoLabel.AutoSize = true;
            this.ApellidoPaternoLabel.Location = new System.Drawing.Point(451, 94);
            this.ApellidoPaternoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApellidoPaternoLabel.Name = "ApellidoPaternoLabel";
            this.ApellidoPaternoLabel.Size = new System.Drawing.Size(208, 28);
            this.ApellidoPaternoLabel.TabIndex = 20;
            this.ApellidoPaternoLabel.Text = "APELLIDO PATERNO:";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(8, 95);
            this.NombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(124, 28);
            this.NombreLabel.TabIndex = 19;
            this.NombreLabel.Text = "NOMBRE/S:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(148, 95);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NombreTextBox.Multiline = true;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(219, 24);
            this.NombreTextBox.TabIndex = 18;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirButton.Location = new System.Drawing.Point(1616, 55);
            this.ImprimirButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(100, 28);
            this.ImprimirButton.TabIndex = 25;
            this.ImprimirButton.Text = "IMPRIMIR";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // BusquedaGroupBox
            // 
            this.BusquedaGroupBox.Controls.Add(this.NombreLabel);
            this.BusquedaGroupBox.Controls.Add(this.eliminarButton);
            this.BusquedaGroupBox.Controls.Add(this.NombreTextBox);
            this.BusquedaGroupBox.Controls.Add(this.buscarButton1);
            this.BusquedaGroupBox.Controls.Add(this.VaciarButton);
            this.BusquedaGroupBox.Controls.Add(this.ModificarButton);
            this.BusquedaGroupBox.Controls.Add(this.ApellidoMaternoTextBox2);
            this.BusquedaGroupBox.Controls.Add(this.ApellidoPaternoLabel);
            this.BusquedaGroupBox.Controls.Add(this.ApellidoPaternoTextBox1);
            this.BusquedaGroupBox.Controls.Add(this.ApellidoMaternoLabel);
            this.BusquedaGroupBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaGroupBox.Location = new System.Drawing.Point(49, 565);
            this.BusquedaGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BusquedaGroupBox.Name = "BusquedaGroupBox";
            this.BusquedaGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BusquedaGroupBox.Size = new System.Drawing.Size(1737, 190);
            this.BusquedaGroupBox.TabIndex = 26;
            this.BusquedaGroupBox.TabStop = false;
            this.BusquedaGroupBox.Text = "BUSQUEDA";
            this.BusquedaGroupBox.Enter += new System.EventHandler(this.BusquedaGroupBox_Enter);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminarButton.Location = new System.Drawing.Point(1547, 142);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(183, 41);
            this.eliminarButton.TabIndex = 17;
            this.eliminarButton.Text = "ELIMINAR ALUMNO";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.BusquedaGroupBox);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.NavBarPanel);
            this.Controls.Add(this.FiltradocomboBox1);
            this.Controls.Add(this.consultaLabel);
            this.Controls.Add(this.filtroLabel);
            this.Controls.Add(this.consultaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataGridView)).EndInit();
            this.NavBarPanel.ResumeLayout(false);
            this.BusquedaGroupBox.ResumeLayout(false);
            this.BusquedaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox FiltradocomboBox1;
        private System.Windows.Forms.Label consultaLabel;
        private System.Windows.Forms.Label filtroLabel;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button buscarButton1;
        private System.Windows.Forms.DataGridView consultaDataGridView;
        private System.Windows.Forms.Panel NavBarPanel;
        private System.Windows.Forms.Button DocentesButton;
        private System.Windows.Forms.Button AlumnosButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button VaciarButton;
        private System.Windows.Forms.TextBox ApellidoMaternoTextBox2;
        private System.Windows.Forms.Label ApellidoMaternoLabel;
        private System.Windows.Forms.TextBox ApellidoPaternoTextBox1;
        private System.Windows.Forms.Label ApellidoPaternoLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.GroupBox BusquedaGroupBox;
        private System.Windows.Forms.Button eliminarButton;
    }
}