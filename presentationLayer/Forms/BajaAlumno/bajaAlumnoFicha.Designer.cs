
namespace presentationLayer.Forms.BajaAlumno
{
    partial class bajaAlumnoFicha
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
            this.preguntaFT = new System.Windows.Forms.Label();
            this.matriculaFT = new System.Windows.Forms.TextBox();
            this.nombreAlFT = new System.Windows.Forms.TextBox();
            this.matriculaLabelFT = new System.Windows.Forms.Label();
            this.nombreAlLabelFT = new System.Windows.Forms.Label();
            this.tituloLabelFT = new System.Windows.Forms.Label();
            this.continuarBajaButtonFT = new presentationLayer.buttonSystem();
            this.cancelarBajaButtonFT = new presentationLayer.buttonSystem();
            this.SuspendLayout();
            // 
            // preguntaFT
            // 
            this.preguntaFT.AutoSize = true;
            this.preguntaFT.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.preguntaFT.Location = new System.Drawing.Point(53, 336);
            this.preguntaFT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preguntaFT.Name = "preguntaFT";
            this.preguntaFT.Size = new System.Drawing.Size(529, 28);
            this.preguntaFT.TabIndex = 262;
            this.preguntaFT.Text = "¿Se encuentra seguro de realizar esta acción?";
            // 
            // matriculaFT
            // 
            this.matriculaFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.matriculaFT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matriculaFT.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.matriculaFT.Location = new System.Drawing.Point(191, 203);
            this.matriculaFT.Margin = new System.Windows.Forms.Padding(4);
            this.matriculaFT.Name = "matriculaFT";
            this.matriculaFT.ReadOnly = true;
            this.matriculaFT.Size = new System.Drawing.Size(83, 32);
            this.matriculaFT.TabIndex = 256;
            // 
            // nombreAlFT
            // 
            this.nombreAlFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.nombreAlFT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreAlFT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreAlFT.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.nombreAlFT.Location = new System.Drawing.Point(148, 102);
            this.nombreAlFT.Margin = new System.Windows.Forms.Padding(4);
            this.nombreAlFT.MaxLength = 25;
            this.nombreAlFT.Name = "nombreAlFT";
            this.nombreAlFT.ReadOnly = true;
            this.nombreAlFT.Size = new System.Drawing.Size(515, 32);
            this.nombreAlFT.TabIndex = 255;
            // 
            // matriculaLabelFT
            // 
            this.matriculaLabelFT.AutoSize = true;
            this.matriculaLabelFT.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.matriculaLabelFT.Location = new System.Drawing.Point(36, 209);
            this.matriculaLabelFT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matriculaLabelFT.Name = "matriculaLabelFT";
            this.matriculaLabelFT.Size = new System.Drawing.Size(128, 28);
            this.matriculaLabelFT.TabIndex = 254;
            this.matriculaLabelFT.Text = "Matricula:";
            // 
            // nombreAlLabelFT
            // 
            this.nombreAlLabelFT.AutoSize = true;
            this.nombreAlLabelFT.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.nombreAlLabelFT.Location = new System.Drawing.Point(36, 102);
            this.nombreAlLabelFT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreAlLabelFT.Name = "nombreAlLabelFT";
            this.nombreAlLabelFT.Size = new System.Drawing.Size(113, 28);
            this.nombreAlLabelFT.TabIndex = 252;
            this.nombreAlLabelFT.Text = "Nombre:";
            // 
            // tituloLabelFT
            // 
            this.tituloLabelFT.AutoSize = true;
            this.tituloLabelFT.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold);
            this.tituloLabelFT.Location = new System.Drawing.Point(105, 25);
            this.tituloLabelFT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLabelFT.Name = "tituloLabelFT";
            this.tituloLabelFT.Size = new System.Drawing.Size(405, 43);
            this.tituloLabelFT.TabIndex = 250;
            this.tituloLabelFT.Text = "B a j a   D e   A l u m n o ";
            // 
            // continuarBajaButtonFT
            // 
            this.continuarBajaButtonFT.BackColor = System.Drawing.Color.White;
            this.continuarBajaButtonFT.BackgroundColor = System.Drawing.Color.White;
            this.continuarBajaButtonFT.BorderRadius = 20;
            this.continuarBajaButtonFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continuarBajaButtonFT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.continuarBajaButtonFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continuarBajaButtonFT.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.continuarBajaButtonFT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.continuarBajaButtonFT.Location = new System.Drawing.Point(291, 386);
            this.continuarBajaButtonFT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continuarBajaButtonFT.Name = "continuarBajaButtonFT";
            this.continuarBajaButtonFT.Padding = new System.Windows.Forms.Padding(1);
            this.continuarBajaButtonFT.Size = new System.Drawing.Size(312, 44);
            this.continuarBajaButtonFT.TabIndex = 264;
            this.continuarBajaButtonFT.Text = "Continuar con la baja";
            this.continuarBajaButtonFT.UseVisualStyleBackColor = false;
            this.continuarBajaButtonFT.Click += new System.EventHandler(this.continuarBajaButtonFT_Click);
            // 
            // cancelarBajaButtonFT
            // 
            this.cancelarBajaButtonFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.cancelarBajaButtonFT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(98)))), ((int)(((byte)(242)))));
            this.cancelarBajaButtonFT.BorderRadius = 20;
            this.cancelarBajaButtonFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarBajaButtonFT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarBajaButtonFT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.cancelarBajaButtonFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBajaButtonFT.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.cancelarBajaButtonFT.ForeColor = System.Drawing.Color.White;
            this.cancelarBajaButtonFT.Location = new System.Drawing.Point(41, 386);
            this.cancelarBajaButtonFT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelarBajaButtonFT.Name = "cancelarBajaButtonFT";
            this.cancelarBajaButtonFT.Padding = new System.Windows.Forms.Padding(1);
            this.cancelarBajaButtonFT.Size = new System.Drawing.Size(215, 44);
            this.cancelarBajaButtonFT.TabIndex = 263;
            this.cancelarBajaButtonFT.Text = "Cancelar baja";
            this.cancelarBajaButtonFT.UseVisualStyleBackColor = false;
            this.cancelarBajaButtonFT.Click += new System.EventHandler(this.cancelarBajaButton_Click);
            // 
            // bajaAlumnoFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(859, 460);
            this.ControlBox = false;
            this.Controls.Add(this.continuarBajaButtonFT);
            this.Controls.Add(this.cancelarBajaButtonFT);
            this.Controls.Add(this.preguntaFT);
            this.Controls.Add(this.matriculaFT);
            this.Controls.Add(this.nombreAlFT);
            this.Controls.Add(this.matriculaLabelFT);
            this.Controls.Add(this.nombreAlLabelFT);
            this.Controls.Add(this.tituloLabelFT);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bajaAlumnoFicha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.bajaAlumnoFicha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buttonSystem continuarBajaButtonFT;
        private buttonSystem cancelarBajaButtonFT;
        private System.Windows.Forms.Label preguntaFT;
        private System.Windows.Forms.TextBox matriculaFT;
        private System.Windows.Forms.TextBox nombreAlFT;
        private System.Windows.Forms.Label matriculaLabelFT;
        private System.Windows.Forms.Label nombreAlLabelFT;
        private System.Windows.Forms.Label tituloLabelFT;
    }
}