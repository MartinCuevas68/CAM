
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSystem1 = new presentationLayer.buttonSystem();
            this.buttonSystem2 = new presentationLayer.buttonSystem();
            this.buttonSystem3 = new presentationLayer.buttonSystem();
            ((System.ComponentModel.ISupportInitialize)(this.altaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::presentationLayer.Properties.Resources.searchBox;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.buscarButton);
            this.panel1.Location = new System.Drawing.Point(562, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 35);
            this.panel1.TabIndex = 144;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::presentationLayer.Properties.Resources.logocam;
            this.pictureBox1.Location = new System.Drawing.Point(1, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::presentationLayer.Properties.Resources.editar1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1281, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 32);
            this.button4.TabIndex = 142;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::presentationLayer.Properties.Resources.quitar_usuario__1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1281, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 32);
            this.button3.TabIndex = 141;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::presentationLayer.Properties.Resources.agregar_usuario__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1281, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 32);
            this.button2.TabIndex = 140;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buscarButton
            // 
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscarButton.Location = new System.Drawing.Point(589, 341);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(35, 28);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(52, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 18);
            this.textBox1.TabIndex = 12;
            // 
            // buttonSystem1
            // 
            this.buttonSystem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonSystem1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonSystem1.BorderRadius = 20;
            this.buttonSystem1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.buttonSystem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSystem1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSystem1.ForeColor = System.Drawing.Color.White;
            this.buttonSystem1.Location = new System.Drawing.Point(1036, 690);
            this.buttonSystem1.Name = "buttonSystem1";
            this.buttonSystem1.Padding = new System.Windows.Forms.Padding(6);
            this.buttonSystem1.Size = new System.Drawing.Size(164, 45);
            this.buttonSystem1.TabIndex = 145;
            this.buttonSystem1.Text = "Ficha técnica";
            this.buttonSystem1.UseVisualStyleBackColor = false;
            // 
            // buttonSystem2
            // 
            this.buttonSystem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonSystem2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonSystem2.BorderRadius = 20;
            this.buttonSystem2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.buttonSystem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSystem2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSystem2.ForeColor = System.Drawing.Color.White;
            this.buttonSystem2.Location = new System.Drawing.Point(727, 690);
            this.buttonSystem2.Name = "buttonSystem2";
            this.buttonSystem2.Padding = new System.Windows.Forms.Padding(6);
            this.buttonSystem2.Size = new System.Drawing.Size(202, 45);
            this.buttonSystem2.TabIndex = 146;
            this.buttonSystem2.Text = "Imprimir formatos";
            this.buttonSystem2.UseVisualStyleBackColor = false;
            // 
            // buttonSystem3
            // 
            this.buttonSystem3.BackColor = System.Drawing.Color.White;
            this.buttonSystem3.BackgroundColor = System.Drawing.Color.White;
            this.buttonSystem3.BorderRadius = 20;
            this.buttonSystem3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.buttonSystem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSystem3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSystem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonSystem3.Location = new System.Drawing.Point(38, 690);
            this.buttonSystem3.Name = "buttonSystem3";
            this.buttonSystem3.Padding = new System.Windows.Forms.Padding(6);
            this.buttonSystem3.Size = new System.Drawing.Size(164, 45);
            this.buttonSystem3.TabIndex = 147;
            this.buttonSystem3.Text = "Cerrar sesión";
            this.buttonSystem3.UseVisualStyleBackColor = false;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonSystem3);
            this.Controls.Add(this.buttonSystem2);
            this.Controls.Add(this.buttonSystem1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private buttonSystem buttonSystem1;
        private buttonSystem buttonSystem2;
        private buttonSystem buttonSystem3;
    }
}