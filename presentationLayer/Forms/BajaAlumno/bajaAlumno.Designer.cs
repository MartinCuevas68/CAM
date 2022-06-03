
namespace presentationLayer.Forms.BajaAlumno
{
    partial class bajaAlumno
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.matricula = new System.Windows.Forms.TextBox();
            this.nombreAl = new System.Windows.Forms.TextBox();
            this.matriculaLabel = new System.Windows.Forms.Label();
            this.edadLabel = new System.Windows.Forms.Label();
            this.nombreAlLabel = new System.Windows.Forms.Label();
            this.tipoIngreso = new System.Windows.Forms.TextBox();
            this.tipoIngresoLabel = new System.Windows.Forms.Label();
            this.curp = new System.Windows.Forms.TextBox();
            this.curpLabel = new System.Windows.Forms.Label();
            this.pregunta = new System.Windows.Forms.Label();
            this.continuarBajaButton = new presentationLayer.buttonSystem();
            this.cancelarBajaButton = new presentationLayer.buttonSystem();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold);
            this.tituloLabel.Location = new System.Drawing.Point(283, 30);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(405, 43);
            this.tituloLabel.TabIndex = 16;
            this.tituloLabel.Text = "B a j a   D e   A l u m n o ";
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto.Location = new System.Drawing.Point(52, 87);
            this.foto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(155, 196);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 203;
            this.foto.TabStop = false;
            // 
            // edad
            // 
            this.edad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.edad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edad.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.edad.Location = new System.Drawing.Point(292, 244);
            this.edad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Size = new System.Drawing.Size(61, 32);
            this.edad.TabIndex = 240;
            // 
            // matricula
            // 
            this.matricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.matricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matricula.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.matricula.Location = new System.Drawing.Point(344, 178);
            this.matricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Size = new System.Drawing.Size(83, 32);
            this.matricula.TabIndex = 239;
            // 
            // nombreAl
            // 
            this.nombreAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.nombreAl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreAl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreAl.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.nombreAl.Location = new System.Drawing.Point(325, 107);
            this.nombreAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreAl.MaxLength = 25;
            this.nombreAl.Name = "nombreAl";
            this.nombreAl.ReadOnly = true;
            this.nombreAl.Size = new System.Drawing.Size(515, 32);
            this.nombreAl.TabIndex = 238;
            // 
            // matriculaLabel
            // 
            this.matriculaLabel.AutoSize = true;
            this.matriculaLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.matriculaLabel.Location = new System.Drawing.Point(213, 178);
            this.matriculaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matriculaLabel.Name = "matriculaLabel";
            this.matriculaLabel.Size = new System.Drawing.Size(128, 28);
            this.matriculaLabel.TabIndex = 237;
            this.matriculaLabel.Text = "Matricula:";
            // 
            // edadLabel
            // 
            this.edadLabel.AutoSize = true;
            this.edadLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.edadLabel.Location = new System.Drawing.Point(213, 244);
            this.edadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edadLabel.Name = "edadLabel";
            this.edadLabel.Size = new System.Drawing.Size(75, 28);
            this.edadLabel.TabIndex = 236;
            this.edadLabel.Text = "Edad:";
            // 
            // nombreAlLabel
            // 
            this.nombreAlLabel.AutoSize = true;
            this.nombreAlLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.nombreAlLabel.Location = new System.Drawing.Point(213, 107);
            this.nombreAlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreAlLabel.Name = "nombreAlLabel";
            this.nombreAlLabel.Size = new System.Drawing.Size(113, 28);
            this.nombreAlLabel.TabIndex = 235;
            this.nombreAlLabel.Text = "Nombre:";
            // 
            // tipoIngreso
            // 
            this.tipoIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tipoIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipoIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tipoIngreso.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.tipoIngreso.Location = new System.Drawing.Point(637, 178);
            this.tipoIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipoIngreso.Name = "tipoIngreso";
            this.tipoIngreso.ReadOnly = true;
            this.tipoIngreso.Size = new System.Drawing.Size(204, 32);
            this.tipoIngreso.TabIndex = 246;
            // 
            // tipoIngresoLabel
            // 
            this.tipoIngresoLabel.AutoSize = true;
            this.tipoIngresoLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoIngresoLabel.Location = new System.Drawing.Point(439, 178);
            this.tipoIngresoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoIngresoLabel.Name = "tipoIngresoLabel";
            this.tipoIngresoLabel.Size = new System.Drawing.Size(198, 28);
            this.tipoIngresoLabel.TabIndex = 244;
            this.tipoIngresoLabel.Text = "Tipo de ingreso:";
            // 
            // curp
            // 
            this.curp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.curp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.curp.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.curp.Location = new System.Drawing.Point(521, 244);
            this.curp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.curp.MaxLength = 18;
            this.curp.Name = "curp";
            this.curp.ReadOnly = true;
            this.curp.Size = new System.Drawing.Size(273, 32);
            this.curp.TabIndex = 245;
            // 
            // curpLabel
            // 
            this.curpLabel.AutoSize = true;
            this.curpLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curpLabel.Location = new System.Drawing.Point(439, 244);
            this.curpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curpLabel.Name = "curpLabel";
            this.curpLabel.Size = new System.Drawing.Size(82, 28);
            this.curpLabel.TabIndex = 243;
            this.curpLabel.Text = "CURP:";
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.pregunta.Location = new System.Drawing.Point(231, 341);
            this.pregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(529, 28);
            this.pregunta.TabIndex = 247;
            this.pregunta.Text = "¿Se encuentra seguro de realizar esta acción?";
            // 
            // continuarBajaButton
            // 
            this.continuarBajaButton.BackColor = System.Drawing.Color.White;
            this.continuarBajaButton.BackgroundColor = System.Drawing.Color.White;
            this.continuarBajaButton.BorderRadius = 20;
            this.continuarBajaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continuarBajaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.continuarBajaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continuarBajaButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.continuarBajaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.continuarBajaButton.Location = new System.Drawing.Point(468, 391);
            this.continuarBajaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continuarBajaButton.Name = "continuarBajaButton";
            this.continuarBajaButton.Padding = new System.Windows.Forms.Padding(1);
            this.continuarBajaButton.Size = new System.Drawing.Size(312, 44);
            this.continuarBajaButton.TabIndex = 249;
            this.continuarBajaButton.Text = "Continuar con la baja";
            this.continuarBajaButton.UseVisualStyleBackColor = false;
            this.continuarBajaButton.Click += new System.EventHandler(this.continuarBajaButton_Click);
            // 
            // cancelarBajaButton
            // 
            this.cancelarBajaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.cancelarBajaButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.cancelarBajaButton.BorderRadius = 20;
            this.cancelarBajaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarBajaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.cancelarBajaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBajaButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.cancelarBajaButton.ForeColor = System.Drawing.Color.White;
            this.cancelarBajaButton.Location = new System.Drawing.Point(219, 391);
            this.cancelarBajaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelarBajaButton.Name = "cancelarBajaButton";
            this.cancelarBajaButton.Padding = new System.Windows.Forms.Padding(1);
            this.cancelarBajaButton.Size = new System.Drawing.Size(215, 44);
            this.cancelarBajaButton.TabIndex = 248;
            this.cancelarBajaButton.Text = "Cancelar baja";
            this.cancelarBajaButton.UseVisualStyleBackColor = false;
            this.cancelarBajaButton.Click += new System.EventHandler(this.cancelarBajaButton_Click);
            // 
            // bajaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(996, 466);
            this.ControlBox = false;
            this.Controls.Add(this.continuarBajaButton);
            this.Controls.Add(this.cancelarBajaButton);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.tipoIngreso);
            this.Controls.Add(this.tipoIngresoLabel);
            this.Controls.Add(this.curp);
            this.Controls.Add(this.curpLabel);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.nombreAl);
            this.Controls.Add(this.matriculaLabel);
            this.Controls.Add(this.edadLabel);
            this.Controls.Add(this.nombreAlLabel);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.tituloLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bajaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.bajaAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.TextBox nombreAl;
        private System.Windows.Forms.Label matriculaLabel;
        private System.Windows.Forms.Label edadLabel;
        private System.Windows.Forms.Label nombreAlLabel;
        private System.Windows.Forms.TextBox tipoIngreso;
        private System.Windows.Forms.Label tipoIngresoLabel;
        private System.Windows.Forms.TextBox curp;
        private System.Windows.Forms.Label curpLabel;
        private System.Windows.Forms.Label pregunta;
        private buttonSystem cancelarBajaButton;
        private buttonSystem continuarBajaButton;
    }
}