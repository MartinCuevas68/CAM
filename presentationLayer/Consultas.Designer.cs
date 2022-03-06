
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
            this.consultaLabel = new System.Windows.Forms.Label();
            this.filtroLabel = new System.Windows.Forms.Label();
            this.altaDataGridView = new System.Windows.Forms.DataGridView();
            this.apellidoMaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMaternoLabel = new System.Windows.Forms.Label();
            this.apellidoPaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoPaternoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.busquedaGroupBox = new System.Windows.Forms.GroupBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.vaciarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.altaDataGridView)).BeginInit();
            this.busquedaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtradoComboBox
            // 
            this.filtradoComboBox.FormattingEnabled = true;
            this.filtradoComboBox.Items.AddRange(new object[] {
            "GENERAL",
            "NOMBRE",
            "TALLER"});
            this.filtradoComboBox.Location = new System.Drawing.Point(121, 301);
            this.filtradoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.filtradoComboBox.Name = "filtradoComboBox";
            this.filtradoComboBox.Size = new System.Drawing.Size(92, 21);
            this.filtradoComboBox.TabIndex = 18;
            // 
            // consultaLabel
            // 
            this.consultaLabel.AutoSize = true;
            this.consultaLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaLabel.Location = new System.Drawing.Point(24, 35);
            this.consultaLabel.Name = "consultaLabel";
            this.consultaLabel.Size = new System.Drawing.Size(149, 21);
            this.consultaLabel.TabIndex = 15;
            this.consultaLabel.Text = "Consulta Alumnos";
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
            // altaDataGridView
            // 
            this.altaDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.altaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.altaDataGridView.Location = new System.Drawing.Point(21, 60);
            this.altaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.altaDataGridView.Name = "altaDataGridView";
            this.altaDataGridView.RowHeadersWidth = 51;
            this.altaDataGridView.Size = new System.Drawing.Size(984, 232);
            this.altaDataGridView.TabIndex = 10;
            // 
            // apellidoMaternoTextBox
            // 
            this.apellidoMaternoTextBox.Location = new System.Drawing.Point(691, 60);
            this.apellidoMaternoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.apellidoMaternoTextBox.Multiline = true;
            this.apellidoMaternoTextBox.Name = "apellidoMaternoTextBox";
            this.apellidoMaternoTextBox.Size = new System.Drawing.Size(125, 21);
            this.apellidoMaternoTextBox.TabIndex = 23;
            // 
            // apellidoMaternoLabel
            // 
            this.apellidoMaternoLabel.AutoSize = true;
            this.apellidoMaternoLabel.Location = new System.Drawing.Point(557, 62);
            this.apellidoMaternoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellidoMaternoLabel.Name = "apellidoMaternoLabel";
            this.apellidoMaternoLabel.Size = new System.Drawing.Size(172, 21);
            this.apellidoMaternoLabel.TabIndex = 22;
            this.apellidoMaternoLabel.Text = "APELLIDO MATERNO:";
            // 
            // apellidoPaternoTextBox
            // 
            this.apellidoPaternoTextBox.Location = new System.Drawing.Point(425, 60);
            this.apellidoPaternoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.apellidoPaternoTextBox.Multiline = true;
            this.apellidoPaternoTextBox.Name = "apellidoPaternoTextBox";
            this.apellidoPaternoTextBox.Size = new System.Drawing.Size(125, 21);
            this.apellidoPaternoTextBox.TabIndex = 21;
            // 
            // apellidoPaternoLabel
            // 
            this.apellidoPaternoLabel.AutoSize = true;
            this.apellidoPaternoLabel.Location = new System.Drawing.Point(254, 62);
            this.apellidoPaternoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellidoPaternoLabel.Name = "apellidoPaternoLabel";
            this.apellidoPaternoLabel.Size = new System.Drawing.Size(167, 21);
            this.apellidoPaternoLabel.TabIndex = 20;
            this.apellidoPaternoLabel.Text = "APELLIDO PATERNO:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(4, 63);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(99, 21);
            this.nombreLabel.TabIndex = 19;
            this.nombreLabel.Text = "NOMBRE/S:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(112, 112);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTextBox.Multiline = true;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(125, 21);
            this.nombreTextBox.TabIndex = 18;
            // 
            // busquedaGroupBox
            // 
            this.busquedaGroupBox.Controls.Add(this.nombreLabel);
            this.busquedaGroupBox.Controls.Add(this.nombreTextBox);
            this.busquedaGroupBox.Controls.Add(this.apellidoMaternoTextBox);
            this.busquedaGroupBox.Controls.Add(this.apellidoPaternoLabel);
            this.busquedaGroupBox.Controls.Add(this.apellidoPaternoTextBox);
            this.busquedaGroupBox.Controls.Add(this.apellidoMaternoLabel);
            this.busquedaGroupBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaGroupBox.Location = new System.Drawing.Point(28, 373);
            this.busquedaGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.busquedaGroupBox.Name = "busquedaGroupBox";
            this.busquedaGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.busquedaGroupBox.Size = new System.Drawing.Size(977, 205);
            this.busquedaGroupBox.TabIndex = 26;
            this.busquedaGroupBox.TabStop = false;
            this.busquedaGroupBox.Text = "BUSQUEDA";
            this.busquedaGroupBox.Enter += new System.EventHandler(this.busquedaGroupBox_Enter);
            // 
            // agregarButton
            // 
            this.agregarButton.BackgroundImage = global::presentationLayer.Properties.Resources.agregar_usuario;
            this.agregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.agregarButton.Location = new System.Drawing.Point(475, 341);
            this.agregarButton.Margin = new System.Windows.Forms.Padding(2);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(56, 36);
            this.agregarButton.TabIndex = 21;
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 781);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1897, 37);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(27, 995);
            this.vScrollBar1.TabIndex = 138;
            // 
            // imprimirButton
            // 
            this.imprimirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imprimirButton.Location = new System.Drawing.Point(259, 324);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(137, 33);
            this.imprimirButton.TabIndex = 139;
            this.imprimirButton.Text = "Formatos";
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackgroundImage = global::presentationLayer.Properties.Resources.quitar_usuario;
            this.eliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eliminarButton.Location = new System.Drawing.Point(475, 297);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(137, 33);
            this.eliminarButton.TabIndex = 17;
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscarButton.Location = new System.Drawing.Point(589, 341);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(35, 28);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // vaciarButton
            // 
            this.vaciarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vaciarButton.BackgroundImage")));
            this.vaciarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vaciarButton.Location = new System.Drawing.Point(655, 327);
            this.vaciarButton.Margin = new System.Windows.Forms.Padding(2);
            this.vaciarButton.Name = "vaciarButton";
            this.vaciarButton.Size = new System.Drawing.Size(60, 27);
            this.vaciarButton.TabIndex = 24;
            this.vaciarButton.UseVisualStyleBackColor = true;
            // 
            // modificarButton
            // 
            this.modificarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modificarButton.BackgroundImage")));
            this.modificarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modificarButton.Location = new System.Drawing.Point(776, 327);
            this.modificarButton.Margin = new System.Windows.Forms.Padding(2);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(90, 27);
            this.modificarButton.TabIndex = 12;
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click_1);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.busquedaGroupBox);
            this.Controls.Add(this.vaciarButton);
            this.Controls.Add(this.filtradoComboBox);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.consultaLabel);
            this.Controls.Add(this.filtroLabel);
            this.Controls.Add(this.altaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas";
            this.Text = "CONSULTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.altaDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView altaDataGridView;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button vaciarButton;
        private System.Windows.Forms.TextBox apellidoMaternoTextBox;
        private System.Windows.Forms.Label apellidoMaternoLabel;
        private System.Windows.Forms.TextBox apellidoPaternoTextBox;
        private System.Windows.Forms.Label apellidoPaternoLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.GroupBox busquedaGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button imprimirButton;
    }
}