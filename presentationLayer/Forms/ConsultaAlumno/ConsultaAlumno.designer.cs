
namespace presentationLayer
{
    partial class ConsultaAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAlumno));
            this.consultaLabel = new System.Windows.Forms.Label();
            this.altaDataGridView = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.logo = new System.Windows.Forms.PictureBox();
            this.busquedaPanel = new System.Windows.Forms.Panel();
            this.busquedaTextBox = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.agregarButton = new System.Windows.Forms.Button();
            this.cerrarSesionButton = new presentationLayer.buttonSystem();
            this.imprimirFormatosButton = new presentationLayer.buttonSystem();
            this.fichaTecnicaButton = new presentationLayer.buttonSystem();
            this.egresadoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.altaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.busquedaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultaLabel
            // 
            this.consultaLabel.AutoSize = true;
            this.consultaLabel.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold);
            this.consultaLabel.Location = new System.Drawing.Point(565, 11);
            this.consultaLabel.Name = "consultaLabel";
            this.consultaLabel.Size = new System.Drawing.Size(251, 49);
            this.consultaLabel.TabIndex = 15;
            this.consultaLabel.Text = "A l u m n o s";
            // 
            // altaDataGridView
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.altaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.altaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.altaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.altaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.altaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.altaDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.altaDataGridView.Location = new System.Drawing.Point(38, 184);
            this.altaDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.altaDataGridView.Name = "altaDataGridView";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.altaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.altaDataGridView.RowHeadersWidth = 51;
            this.altaDataGridView.Size = new System.Drawing.Size(1222, 486);
            this.altaDataGridView.TabIndex = 10;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1897, 37);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(27, 995);
            this.vScrollBar1.TabIndex = 138;
            // 
            // logo
            // 
            this.logo.Image = global::presentationLayer.Properties.Resources.log_fondo_blanco;
            this.logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logo.Location = new System.Drawing.Point(38, 11);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 150);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 148;
            this.logo.TabStop = false;
            // 
            // busquedaPanel
            // 
            this.busquedaPanel.BackgroundImage = global::presentationLayer.Properties.Resources.searchBox;
            this.busquedaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.busquedaPanel.Controls.Add(this.busquedaTextBox);
            this.busquedaPanel.Controls.Add(this.buscarButton);
            this.busquedaPanel.Location = new System.Drawing.Point(521, 119);
            this.busquedaPanel.Name = "busquedaPanel";
            this.busquedaPanel.Size = new System.Drawing.Size(310, 49);
            this.busquedaPanel.TabIndex = 144;
            // 
            // busquedaTextBox
            // 
            this.busquedaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busquedaTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaTextBox.Location = new System.Drawing.Point(52, 11);
            this.busquedaTextBox.Name = "busquedaTextBox";
            this.busquedaTextBox.Size = new System.Drawing.Size(169, 18);
            this.busquedaTextBox.TabIndex = 12;
            this.busquedaTextBox.TextChanged += new System.EventHandler(this.busquedaTextBox_TextChanged);
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.Transparent;
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarButton.FlatAppearance.BorderSize = 0;
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Location = new System.Drawing.Point(11, 9);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(27, 24);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.UseVisualStyleBackColor = false;
            // 
            // modificarButton
            // 
            this.modificarButton.BackgroundImage = global::presentationLayer.Properties.Resources.editar;
            this.modificarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modificarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarButton.FlatAppearance.BorderSize = 0;
            this.modificarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarButton.Location = new System.Drawing.Point(1181, 136);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(43, 43);
            this.modificarButton.TabIndex = 142;
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackgroundImage = global::presentationLayer.Properties.Resources.quitar_usuario;
            this.eliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Location = new System.Drawing.Point(1219, 136);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(43, 41);
            this.eliminarButton.TabIndex = 141;
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click_1);
            // 
            // agregarButton
            // 
            this.agregarButton.BackgroundImage = global::presentationLayer.Properties.Resources.agregar_usuario;
            this.agregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarButton.FlatAppearance.BorderSize = 0;
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarButton.Location = new System.Drawing.Point(1144, 136);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(43, 43);
            this.agregarButton.TabIndex = 140;
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // cerrarSesionButton
            // 
            this.cerrarSesionButton.BackColor = System.Drawing.Color.White;
            this.cerrarSesionButton.BackgroundColor = System.Drawing.Color.White;
            this.cerrarSesionButton.BorderRadius = 20;
            this.cerrarSesionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarSesionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.cerrarSesionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.cerrarSesionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesionButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.cerrarSesionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.cerrarSesionButton.Location = new System.Drawing.Point(38, 690);
            this.cerrarSesionButton.Name = "cerrarSesionButton";
            this.cerrarSesionButton.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cerrarSesionButton.Size = new System.Drawing.Size(164, 45);
            this.cerrarSesionButton.TabIndex = 147;
            this.cerrarSesionButton.Text = "Cerrar sesión";
            this.cerrarSesionButton.UseVisualStyleBackColor = false;
            // 
            // imprimirFormatosButton
            // 
            this.imprimirFormatosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.imprimirFormatosButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.imprimirFormatosButton.BorderRadius = 20;
            this.imprimirFormatosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imprimirFormatosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.imprimirFormatosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimirFormatosButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.imprimirFormatosButton.ForeColor = System.Drawing.Color.White;
            this.imprimirFormatosButton.Location = new System.Drawing.Point(727, 690);
            this.imprimirFormatosButton.Name = "imprimirFormatosButton";
            this.imprimirFormatosButton.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imprimirFormatosButton.Size = new System.Drawing.Size(202, 45);
            this.imprimirFormatosButton.TabIndex = 146;
            this.imprimirFormatosButton.Text = "Imprimir formatos";
            this.imprimirFormatosButton.UseVisualStyleBackColor = false;
            this.imprimirFormatosButton.Click += new System.EventHandler(this.imprimirFormatosButton_Click);
            // 
            // fichaTecnicaButton
            // 
            this.fichaTecnicaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.fichaTecnicaButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.fichaTecnicaButton.BorderRadius = 20;
            this.fichaTecnicaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fichaTecnicaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.fichaTecnicaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fichaTecnicaButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.fichaTecnicaButton.ForeColor = System.Drawing.Color.White;
            this.fichaTecnicaButton.Location = new System.Drawing.Point(1036, 690);
            this.fichaTecnicaButton.Name = "fichaTecnicaButton";
            this.fichaTecnicaButton.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fichaTecnicaButton.Size = new System.Drawing.Size(164, 45);
            this.fichaTecnicaButton.TabIndex = 145;
            this.fichaTecnicaButton.Text = "Ficha técnica";
            this.fichaTecnicaButton.UseVisualStyleBackColor = false;
            this.fichaTecnicaButton.Click += new System.EventHandler(this.fichaTecnicaButton_Click);
            // 
            // egresadoCheckBox
            // 
            this.egresadoCheckBox.AutoSize = true;
            this.egresadoCheckBox.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egresadoCheckBox.Location = new System.Drawing.Point(38, 153);
            this.egresadoCheckBox.Name = "egresadoCheckBox";
            this.egresadoCheckBox.Size = new System.Drawing.Size(107, 26);
            this.egresadoCheckBox.TabIndex = 149;
            this.egresadoCheckBox.Text = "Egresado";
            this.egresadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConsultaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.egresadoCheckBox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.cerrarSesionButton);
            this.Controls.Add(this.imprimirFormatosButton);
            this.Controls.Add(this.fichaTecnicaButton);
            this.Controls.Add(this.busquedaPanel);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.consultaLabel);
            this.Controls.Add(this.altaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaAlumno";
            this.Text = "CONSULTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.altaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.busquedaPanel.ResumeLayout(false);
            this.busquedaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label consultaLabel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView altaDataGridView;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Panel busquedaPanel;
        private System.Windows.Forms.TextBox busquedaTextBox;
        private buttonSystem fichaTecnicaButton;
        private buttonSystem imprimirFormatosButton;
        private buttonSystem cerrarSesionButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox egresadoCheckBox;
    }
}