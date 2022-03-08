
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.consultaLabel = new System.Windows.Forms.Label();
            this.altaDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtboxBuscar = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonModificaciones = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.buttonCerrar = new presentationLayer.buttonSystem();
            this.buttonImprimir = new presentationLayer.buttonSystem();
            this.buttonFicha = new presentationLayer.buttonSystem();
            ((System.ComponentModel.ISupportInitialize)(this.altaDataGridView)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaLabel
            // 
            this.consultaLabel.AutoSize = true;
            this.consultaLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaLabel.Location = new System.Drawing.Point(597, 32);
            this.consultaLabel.Name = "consultaLabel";
            this.consultaLabel.Size = new System.Drawing.Size(144, 40);
            this.consultaLabel.TabIndex = 15;
            this.consultaLabel.Text = "Alumnos";
            // 
            // altaDataGridView
            // 
            this.altaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.altaDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.altaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.altaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.altaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.altaDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.altaDataGridView.Location = new System.Drawing.Point(11, 184);
            this.altaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.altaDataGridView.Name = "altaDataGridView";
            this.altaDataGridView.RowHeadersWidth = 51;
            this.altaDataGridView.Size = new System.Drawing.Size(1249, 486);
            this.altaDataGridView.TabIndex = 10;
            this.altaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.altaDataGridView_CellContentClick);
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
            // panelBusqueda
            // 
            this.panelBusqueda.BackgroundImage = global::presentationLayer.Properties.Resources.searchBox;
            this.panelBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBusqueda.Controls.Add(this.txtboxBuscar);
            this.panelBusqueda.Controls.Add(this.buscarButton);
            this.panelBusqueda.Location = new System.Drawing.Point(562, 89);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(233, 35);
            this.panelBusqueda.TabIndex = 144;
            // 
            // txtboxBuscar
            // 
            this.txtboxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxBuscar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBuscar.Location = new System.Drawing.Point(52, 11);
            this.txtboxBuscar.Name = "txtboxBuscar";
            this.txtboxBuscar.Size = new System.Drawing.Size(169, 18);
            this.txtboxBuscar.TabIndex = 12;
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.Transparent;
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buscarButton.FlatAppearance.BorderSize = 0;
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Location = new System.Drawing.Point(11, 5);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(2);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(27, 24);
            this.buscarButton.TabIndex = 11;
            this.buscarButton.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Image = global::presentationLayer.Properties.Resources.logocam;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1, -18);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(214, 197);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 143;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonModificaciones
            // 
            this.buttonModificaciones.BackgroundImage = global::presentationLayer.Properties.Resources.editar1;
            this.buttonModificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModificaciones.FlatAppearance.BorderSize = 0;
            this.buttonModificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificaciones.Location = new System.Drawing.Point(1281, 272);
            this.buttonModificaciones.Name = "buttonModificaciones";
            this.buttonModificaciones.Size = new System.Drawing.Size(43, 32);
            this.buttonModificaciones.TabIndex = 142;
            this.buttonModificaciones.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::presentationLayer.Properties.Resources.quitar_usuario__1_;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Location = new System.Drawing.Point(1281, 324);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(43, 32);
            this.buttonEliminar.TabIndex = 141;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonAlta
            // 
            this.buttonAlta.BackgroundImage = global::presentationLayer.Properties.Resources.agregar_usuario__1_;
            this.buttonAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAlta.FlatAppearance.BorderSize = 0;
            this.buttonAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlta.Location = new System.Drawing.Point(1281, 209);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(43, 32);
            this.buttonAlta.TabIndex = 140;
            this.buttonAlta.UseVisualStyleBackColor = true;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.White;
            this.buttonCerrar.BackgroundColor = System.Drawing.Color.White;
            this.buttonCerrar.BorderRadius = 20;
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.buttonCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonCerrar.Location = new System.Drawing.Point(38, 690);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Padding = new System.Windows.Forms.Padding(6);
            this.buttonCerrar.Size = new System.Drawing.Size(164, 45);
            this.buttonCerrar.TabIndex = 147;
            this.buttonCerrar.Text = "Cerrar sesión";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonImprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonImprimir.BorderRadius = 20;
            this.buttonImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.buttonImprimir.ForeColor = System.Drawing.Color.White;
            this.buttonImprimir.Location = new System.Drawing.Point(727, 690);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Padding = new System.Windows.Forms.Padding(6);
            this.buttonImprimir.Size = new System.Drawing.Size(202, 45);
            this.buttonImprimir.TabIndex = 146;
            this.buttonImprimir.Text = "Imprimir formatos";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            // 
            // buttonFicha
            // 
            this.buttonFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonFicha.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.buttonFicha.BorderRadius = 20;
            this.buttonFicha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.buttonFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFicha.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.buttonFicha.ForeColor = System.Drawing.Color.White;
            this.buttonFicha.Location = new System.Drawing.Point(1036, 690);
            this.buttonFicha.Name = "buttonFicha";
            this.buttonFicha.Padding = new System.Windows.Forms.Padding(6);
            this.buttonFicha.Size = new System.Drawing.Size(164, 45);
            this.buttonFicha.TabIndex = 145;
            this.buttonFicha.Text = "Ficha técnica";
            this.buttonFicha.UseVisualStyleBackColor = false;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonFicha);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonModificaciones);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consultaLabel);
            this.Controls.Add(this.altaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas";
            this.Text = "CONSULTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.altaDataGridView)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label consultaLabel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridView altaDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificaciones;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox txtboxBuscar;
        private buttonSystem buttonFicha;
        private buttonSystem buttonImprimir;
        private buttonSystem buttonCerrar;
    }
}