
namespace presentationLayer.Forms.ConsultaFormatos
{
    partial class vistaPreviaFormato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaPreviaFormato));
            this.formatoLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.vistaPreviaPDF = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPreviaPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // formatoLabel
            // 
            this.formatoLabel.AutoSize = true;
            this.formatoLabel.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold);
            this.formatoLabel.Location = new System.Drawing.Point(177, 19);
            this.formatoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formatoLabel.Name = "formatoLabel";
            this.formatoLabel.Size = new System.Drawing.Size(266, 52);
            this.formatoLabel.TabIndex = 243;
            this.formatoLabel.Text = "F o r m a t o";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tituloLabel.Location = new System.Drawing.Point(270, 83);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(75, 29);
            this.tituloLabel.TabIndex = 242;
            this.tituloLabel.Text = "Titulo";
            // 
            // vistaPreviaPDF
            // 
            this.vistaPreviaPDF.Enabled = true;
            this.vistaPreviaPDF.Location = new System.Drawing.Point(169, 299);
            this.vistaPreviaPDF.Name = "vistaPreviaPDF";
            this.vistaPreviaPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vistaPreviaPDF.OcxState")));
            this.vistaPreviaPDF.Size = new System.Drawing.Size(417, 524);
            this.vistaPreviaPDF.TabIndex = 245;
            // 
            // vistaPreviaFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 1055);
            this.Controls.Add(this.vistaPreviaPDF);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.formatoLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vistaPreviaFormato";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Previa";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.vistaPreviaFormato_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.vistaPreviaPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label formatoLabel;
        private System.Windows.Forms.Label tituloLabel;
        private AxAcroPDFLib.AxAcroPDF vistaPreviaPDF;
    }
}