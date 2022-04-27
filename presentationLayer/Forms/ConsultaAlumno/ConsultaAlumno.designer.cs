
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.altaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.busquedaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultaLabel
            // 
            this.consultaLabel.AutoSize = true;
            this.consultaLabel.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold);
            this.consultaLabel.Location = new System.Drawing.Point(753, 14);
            this.consultaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.consultaLabel.Name = "consultaLabel";
            this.consultaLabel.Size = new System.Drawing.Size(314, 63);
            this.consultaLabel.TabIndex = 15;
            this.consultaLabel.Text = "A l u m n o s";
            // 
            // altaDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.altaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.altaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.altaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.altaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.altaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.altaDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.altaDataGridView.Location = new System.Drawing.Point(51, 226);
            this.altaDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.altaDataGridView.Name = "altaDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.altaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.altaDataGridView.RowHeadersWidth = 51;
            this.altaDataGridView.Size = new System.Drawing.Size(1629, 598);
            this.altaDataGridView.TabIndex = 10;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(2529, 46);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(27, 1225);
            this.vScrollBar1.TabIndex = 138;
            // 
            // logo
            // 
            this.logo.Image = global::presentationLayer.Properties.Resources.log_fondo_blanco;
            this.logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logo.Location = new System.Drawing.Point(51, 14);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 185);
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
            this.busquedaPanel.Location = new System.Drawing.Point(695, 146);
            this.busquedaPanel.Margin = new System.Windows.Forms.Padding(4);
            this.busquedaPanel.Name = "busquedaPanel";
            this.busquedaPanel.Size = new System.Drawing.Size(413, 60);
            this.busquedaPanel.TabIndex = 144;
            // 
            // busquedaTextBox
            // 
            this.busquedaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busquedaTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaTextBox.Location = new System.Drawing.Point(69, 14);
            this.busquedaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.busquedaTextBox.Name = "busquedaTextBox";
            this.busquedaTextBox.Size = new System.Drawing.Size(225, 22);
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
            this.buscarButton.Location = new System.Drawing.Point(15, 11);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(36, 30);
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
            this.modificarButton.Location = new System.Drawing.Point(1575, 167);
            this.modificarButton.Margin = new System.Windows.Forms.Padding(4);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(57, 53);
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
            this.eliminarButton.Location = new System.Drawing.Point(1625, 167);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(57, 50);
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
            this.agregarButton.Location = new System.Drawing.Point(1525, 167);
            this.agregarButton.Margin = new System.Windows.Forms.Padding(4);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(57, 53);
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
            this.cerrarSesionButton.Location = new System.Drawing.Point(51, 849);
            this.cerrarSesionButton.Margin = new System.Windows.Forms.Padding(4);
            this.cerrarSesionButton.Name = "cerrarSesionButton";
            this.cerrarSesionButton.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cerrarSesionButton.Size = new System.Drawing.Size(219, 55);
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
            this.imprimirFormatosButton.Location = new System.Drawing.Point(969, 849);
            this.imprimirFormatosButton.Margin = new System.Windows.Forms.Padding(4);
            this.imprimirFormatosButton.Name = "imprimirFormatosButton";
            this.imprimirFormatosButton.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.imprimirFormatosButton.Size = new System.Drawing.Size(269, 55);
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
            this.fichaTecnicaButton.Location = new System.Drawing.Point(1381, 849);
            this.fichaTecnicaButton.Margin = new System.Windows.Forms.Padding(4);
            this.fichaTecnicaButton.Name = "fichaTecnicaButton";
            this.fichaTecnicaButton.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fichaTecnicaButton.Size = new System.Drawing.Size(219, 55);
            this.fichaTecnicaButton.TabIndex = 145;
            this.fichaTecnicaButton.Text = "Ficha técnica";
            this.fichaTecnicaButton.UseVisualStyleBackColor = false;
            this.fichaTecnicaButton.Click += new System.EventHandler(this.fichaTecnicaButton_Click);
            // 
            // ConsultaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1695, 792);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}