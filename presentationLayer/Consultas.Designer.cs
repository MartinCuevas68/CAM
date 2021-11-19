
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
            this.filtradoComboBox = new System.Windows.Forms.ComboBox();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.consultaLabel = new System.Windows.Forms.Label();
            this.filtroLabel = new System.Windows.Forms.Label();
            this.modificarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.navBarPanel = new System.Windows.Forms.Panel();
            this.docentesButton = new System.Windows.Forms.Button();
            this.alumnosButton = new System.Windows.Forms.Button();
            this.agregarButton = new System.Windows.Forms.Button();
            this.vaciarButton = new System.Windows.Forms.Button();
            this.apellidoMaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMaternoLabel = new System.Windows.Forms.Label();
            this.apellidoPaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoPaternoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.busquedaGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.navBarPanel.SuspendLayout();
            this.busquedaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtradoComboBox
            // 
            this.filtradoComboBox.FormattingEnabled = true;
            this.filtradoComboBox.Items.AddRange(new object[] {
            "General",
            "Nombre",
            "Taller"});
            this.filtradoComboBox.Location = new System.Drawing.Point(161, 371);
            this.filtradoComboBox.Name = "filtradoComboBox";
            this.filtradoComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtradoComboBox.TabIndex = 18;
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
            // modificarButton
            // 
            this.modificarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modificarButton.Location = new System.Drawing.Point(1021, 115);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(120, 33);
            this.modificarButton.TabIndex = 12;
            this.modificarButton.Text = "MODIFICAR";
            this.modificarButton.UseVisualStyleBackColor = true;
            // 
            // buscarButton
            // 
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarButton.Location = new System.Drawing.Point(778, 117);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(83, 33);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.Text = "BUSCAR";
            this.buscarButton.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(28, 74);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(1312, 285);
            this.DataGridView.TabIndex = 10;
            // 
            // navBarPanel
            // 
            this.navBarPanel.BackColor = System.Drawing.Color.Thistle;
            this.navBarPanel.Controls.Add(this.docentesButton);
            this.navBarPanel.Controls.Add(this.alumnosButton);
            this.navBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBarPanel.Location = new System.Drawing.Point(0, 0);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.Size = new System.Drawing.Size(1370, 32);
            this.navBarPanel.TabIndex = 20;
            // 
            // docentesButton
            // 
            this.docentesButton.AutoSize = true;
            this.docentesButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.docentesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docentesButton.Location = new System.Drawing.Point(1219, 0);
            this.docentesButton.Name = "docentesButton";
            this.docentesButton.Size = new System.Drawing.Size(76, 32);
            this.docentesButton.TabIndex = 22;
            this.docentesButton.Text = "DOCENTES";
            this.docentesButton.UseVisualStyleBackColor = true;
            // 
            // alumnosButton
            // 
            this.alumnosButton.AutoSize = true;
            this.alumnosButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.alumnosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alumnosButton.Location = new System.Drawing.Point(1295, 0);
            this.alumnosButton.Name = "alumnosButton";
            this.alumnosButton.Size = new System.Drawing.Size(75, 32);
            this.alumnosButton.TabIndex = 21;
            this.alumnosButton.Text = "ALUMNOS";
            this.alumnosButton.UseVisualStyleBackColor = true;
            // 
            // agregarButton
            // 
            this.agregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.Location = new System.Drawing.Point(1131, 45);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 21;
            this.agregarButton.Text = "AGREGAR";
            this.agregarButton.UseVisualStyleBackColor = true;
            // 
            // vaciarButton
            // 
            this.vaciarButton.Location = new System.Drawing.Point(878, 117);
            this.vaciarButton.Name = "vaciarButton";
            this.vaciarButton.Size = new System.Drawing.Size(80, 33);
            this.vaciarButton.TabIndex = 24;
            this.vaciarButton.Text = "VACIAR";
            this.vaciarButton.UseVisualStyleBackColor = true;
            // 
            // apellidoMaternoTextBox
            // 
            this.apellidoMaternoTextBox.Location = new System.Drawing.Point(921, 74);
            this.apellidoMaternoTextBox.Multiline = true;
            this.apellidoMaternoTextBox.Name = "apellidoMaternoTextBox";
            this.apellidoMaternoTextBox.Size = new System.Drawing.Size(165, 20);
            this.apellidoMaternoTextBox.TabIndex = 23;
            // 
            // apellidoMaternoLabel
            // 
            this.apellidoMaternoLabel.AutoSize = true;
            this.apellidoMaternoLabel.Location = new System.Drawing.Point(743, 76);
            this.apellidoMaternoLabel.Name = "apellidoMaternoLabel";
            this.apellidoMaternoLabel.Size = new System.Drawing.Size(172, 21);
            this.apellidoMaternoLabel.TabIndex = 22;
            this.apellidoMaternoLabel.Text = "APELLIDO MATERNO:";
            // 
            // apellidoPaternoTextBox
            // 
            this.apellidoPaternoTextBox.Location = new System.Drawing.Point(511, 77);
            this.apellidoPaternoTextBox.Multiline = true;
            this.apellidoPaternoTextBox.Name = "apellidoPaternoTextBox";
            this.apellidoPaternoTextBox.Size = new System.Drawing.Size(165, 20);
            this.apellidoPaternoTextBox.TabIndex = 21;
            // 
            // apellidoPaternoLabel
            // 
            this.apellidoPaternoLabel.AutoSize = true;
            this.apellidoPaternoLabel.Location = new System.Drawing.Point(338, 76);
            this.apellidoPaternoLabel.Name = "apellidoPaternoLabel";
            this.apellidoPaternoLabel.Size = new System.Drawing.Size(167, 21);
            this.apellidoPaternoLabel.TabIndex = 20;
            this.apellidoPaternoLabel.Text = "APELLIDO PATERNO:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(6, 77);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(99, 21);
            this.nombreLabel.TabIndex = 19;
            this.nombreLabel.Text = "NOMBRE/S:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(111, 77);
            this.nombreTextBox.Multiline = true;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(165, 20);
            this.nombreTextBox.TabIndex = 18;
            // 
            // imprimirButton
            // 
            this.imprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimirButton.Location = new System.Drawing.Point(1212, 45);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(75, 23);
            this.imprimirButton.TabIndex = 25;
            this.imprimirButton.Text = "IMPRIMIR";
            this.imprimirButton.UseVisualStyleBackColor = true;
            // 
            // busquedaGroupBox
            // 
            this.busquedaGroupBox.Controls.Add(this.nombreLabel);
            this.busquedaGroupBox.Controls.Add(this.eliminarButton);
            this.busquedaGroupBox.Controls.Add(this.nombreTextBox);
            this.busquedaGroupBox.Controls.Add(this.buscarButton);
            this.busquedaGroupBox.Controls.Add(this.vaciarButton);
            this.busquedaGroupBox.Controls.Add(this.modificarButton);
            this.busquedaGroupBox.Controls.Add(this.apellidoMaternoTextBox);
            this.busquedaGroupBox.Controls.Add(this.apellidoPaternoLabel);
            this.busquedaGroupBox.Controls.Add(this.apellidoPaternoTextBox);
            this.busquedaGroupBox.Controls.Add(this.apellidoMaternoLabel);
            this.busquedaGroupBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaGroupBox.Location = new System.Drawing.Point(37, 459);
            this.busquedaGroupBox.Name = "busquedaGroupBox";
            this.busquedaGroupBox.Size = new System.Drawing.Size(1303, 154);
            this.busquedaGroupBox.TabIndex = 26;
            this.busquedaGroupBox.TabStop = false;
            this.busquedaGroupBox.Text = "BUSQUEDA";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.busquedaGroupBox);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.navBarPanel);
            this.Controls.Add(this.filtradoComboBox);
            this.Controls.Add(this.consultaLabel);
            this.Controls.Add(this.filtroLabel);
            this.Controls.Add(this.DataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.navBarPanel.ResumeLayout(false);
            this.navBarPanel.PerformLayout();
            this.busquedaGroupBox.ResumeLayout(false);
            this.busquedaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox filtradoComboBox;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Label consultaLabel;
        private System.Windows.Forms.Label filtroLabel;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel navBarPanel;
        private System.Windows.Forms.Button docentesButton;
        private System.Windows.Forms.Button alumnosButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button vaciarButton;
        private System.Windows.Forms.TextBox apellidoMaternoTextBox;
        private System.Windows.Forms.Label apellidoMaternoLabel;
        private System.Windows.Forms.TextBox apellidoPaternoTextBox;
        private System.Windows.Forms.Label apellidoPaternoLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.GroupBox busquedaGroupBox;
    }
}