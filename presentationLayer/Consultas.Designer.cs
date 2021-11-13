
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
            this.eliminarButton = new System.Windows.Forms.Button();
            this.consultaLabel = new System.Windows.Forms.Label();
            this.filtroLabel = new System.Windows.Forms.Label();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.buscarButton1 = new System.Windows.Forms.Button();
            this.panelConsulta_dataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.panelConsulta_dataGridView)).BeginInit();
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
            this.FiltradocomboBox1.Location = new System.Drawing.Point(161, 371);
            this.FiltradocomboBox1.Name = "FiltradocomboBox1";
            this.FiltradocomboBox1.Size = new System.Drawing.Size(121, 21);
            this.FiltradocomboBox1.TabIndex = 18;
            this.FiltradocomboBox1.SelectedIndexChanged += new System.EventHandler(this.FiltradocomboBox1_SelectedIndexChanged);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminarButton.Location = new System.Drawing.Point(1160, 115);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(137, 33);
            this.eliminarButton.TabIndex = 17;
            this.eliminarButton.Text = "ELIMINAR ALUMNO";
            this.eliminarButton.UseVisualStyleBackColor = true;
            // 
            // consultaLabel
            // 
            this.consultaLabel.AutoSize = true;
            this.consultaLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaLabel.Location = new System.Drawing.Point(24, 35);
            this.consultaLabel.Name = "consultaLabel";
            this.consultaLabel.Size = new System.Drawing.Size(90, 21);
            this.consultaLabel.TabIndex = 15;
            this.consultaLabel.Text = "ALUMNOS";
            // 
            // filtroLabel
            // 
            this.filtroLabel.AutoSize = true;
            this.filtroLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filtroLabel.Location = new System.Drawing.Point(25, 371);
            this.filtroLabel.Name = "filtroLabel";
            this.filtroLabel.Size = new System.Drawing.Size(127, 21);
            this.filtroLabel.TabIndex = 13;
            this.filtroLabel.Text = "ORDENAR POR:";
            // 
            // ModificarButton
            // 
            this.ModificarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModificarButton.Location = new System.Drawing.Point(1021, 115);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(120, 33);
            this.ModificarButton.TabIndex = 12;
            this.ModificarButton.Text = "MODIFICAR";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // buscarButton1
            // 
            this.buscarButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarButton1.Location = new System.Drawing.Point(778, 117);
            this.buscarButton1.Name = "buscarButton1";
            this.buscarButton1.Size = new System.Drawing.Size(83, 33);
            this.buscarButton1.TabIndex = 11;
            this.buscarButton1.Text = "BUSCAR";
            this.buscarButton1.UseVisualStyleBackColor = true;
            // 
            // panelConsulta_dataGridView
            // 
            this.panelConsulta_dataGridView.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.panelConsulta_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelConsulta_dataGridView.Location = new System.Drawing.Point(28, 74);
            this.panelConsulta_dataGridView.Name = "panelConsulta_dataGridView";
            this.panelConsulta_dataGridView.Size = new System.Drawing.Size(1312, 285);
            this.panelConsulta_dataGridView.TabIndex = 10;
            // 
            // NavBarPanel
            // 
            this.NavBarPanel.BackColor = System.Drawing.Color.MediumOrchid;
            this.NavBarPanel.Controls.Add(this.DocentesButton);
            this.NavBarPanel.Controls.Add(this.AlumnosButton);
            this.NavBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBarPanel.Location = new System.Drawing.Point(0, 0);
            this.NavBarPanel.Name = "NavBarPanel";
            this.NavBarPanel.Size = new System.Drawing.Size(1370, 32);
            this.NavBarPanel.TabIndex = 20;
            // 
            // DocentesButton
            // 
            this.DocentesButton.AutoSize = true;
            this.DocentesButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DocentesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocentesButton.Location = new System.Drawing.Point(1219, 0);
            this.DocentesButton.Name = "DocentesButton";
            this.DocentesButton.Size = new System.Drawing.Size(76, 32);
            this.DocentesButton.TabIndex = 22;
            this.DocentesButton.Text = "DOCENTES";
            this.DocentesButton.UseVisualStyleBackColor = true;
            // 
            // AlumnosButton
            // 
            this.AlumnosButton.AutoSize = true;
            this.AlumnosButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AlumnosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlumnosButton.Location = new System.Drawing.Point(1295, 0);
            this.AlumnosButton.Name = "AlumnosButton";
            this.AlumnosButton.Size = new System.Drawing.Size(75, 32);
            this.AlumnosButton.TabIndex = 21;
            this.AlumnosButton.Text = "ALUMNOS";
            this.AlumnosButton.UseVisualStyleBackColor = true;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Location = new System.Drawing.Point(1131, 45);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 21;
            this.AgregarButton.Text = "AGREGAR";
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // VaciarButton
            // 
            this.VaciarButton.Location = new System.Drawing.Point(878, 117);
            this.VaciarButton.Name = "VaciarButton";
            this.VaciarButton.Size = new System.Drawing.Size(80, 33);
            this.VaciarButton.TabIndex = 24;
            this.VaciarButton.Text = "VACIAR";
            this.VaciarButton.UseVisualStyleBackColor = true;
            // 
            // ApellidoMaternoTextBox2
            // 
            this.ApellidoMaternoTextBox2.Location = new System.Drawing.Point(921, 74);
            this.ApellidoMaternoTextBox2.Multiline = true;
            this.ApellidoMaternoTextBox2.Name = "ApellidoMaternoTextBox2";
            this.ApellidoMaternoTextBox2.Size = new System.Drawing.Size(165, 20);
            this.ApellidoMaternoTextBox2.TabIndex = 23;
            // 
            // ApellidoMaternoLabel
            // 
            this.ApellidoMaternoLabel.AutoSize = true;
            this.ApellidoMaternoLabel.Location = new System.Drawing.Point(743, 76);
            this.ApellidoMaternoLabel.Name = "ApellidoMaternoLabel";
            this.ApellidoMaternoLabel.Size = new System.Drawing.Size(172, 21);
            this.ApellidoMaternoLabel.TabIndex = 22;
            this.ApellidoMaternoLabel.Text = "APELLIDO MATERNO:";
            // 
            // ApellidoPaternoTextBox1
            // 
            this.ApellidoPaternoTextBox1.Location = new System.Drawing.Point(511, 77);
            this.ApellidoPaternoTextBox1.Multiline = true;
            this.ApellidoPaternoTextBox1.Name = "ApellidoPaternoTextBox1";
            this.ApellidoPaternoTextBox1.Size = new System.Drawing.Size(165, 20);
            this.ApellidoPaternoTextBox1.TabIndex = 21;
            // 
            // ApellidoPaternoLabel
            // 
            this.ApellidoPaternoLabel.AutoSize = true;
            this.ApellidoPaternoLabel.Location = new System.Drawing.Point(338, 76);
            this.ApellidoPaternoLabel.Name = "ApellidoPaternoLabel";
            this.ApellidoPaternoLabel.Size = new System.Drawing.Size(167, 21);
            this.ApellidoPaternoLabel.TabIndex = 20;
            this.ApellidoPaternoLabel.Text = "APELLIDO PATERNO:";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(6, 77);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(99, 21);
            this.NombreLabel.TabIndex = 19;
            this.NombreLabel.Text = "NOMBRE/S:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(111, 77);
            this.NombreTextBox.Multiline = true;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(165, 20);
            this.NombreTextBox.TabIndex = 18;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirButton.Location = new System.Drawing.Point(1212, 45);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 23);
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
            this.BusquedaGroupBox.Location = new System.Drawing.Point(37, 459);
            this.BusquedaGroupBox.Name = "BusquedaGroupBox";
            this.BusquedaGroupBox.Size = new System.Drawing.Size(1303, 154);
            this.BusquedaGroupBox.TabIndex = 26;
            this.BusquedaGroupBox.TabStop = false;
            this.BusquedaGroupBox.Text = "BUSQUEDA";
            this.BusquedaGroupBox.Enter += new System.EventHandler(this.BusquedaGroupBox_Enter);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BusquedaGroupBox);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.NavBarPanel);
            this.Controls.Add(this.FiltradocomboBox1);
            this.Controls.Add(this.consultaLabel);
            this.Controls.Add(this.filtroLabel);
            this.Controls.Add(this.panelConsulta_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelConsulta_dataGridView)).EndInit();
            this.NavBarPanel.ResumeLayout(false);
            this.NavBarPanel.PerformLayout();
            this.BusquedaGroupBox.ResumeLayout(false);
            this.BusquedaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox FiltradocomboBox1;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Label consultaLabel;
        private System.Windows.Forms.Label filtroLabel;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button buscarButton1;
        private System.Windows.Forms.DataGridView panelConsulta_dataGridView;
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
    }
}