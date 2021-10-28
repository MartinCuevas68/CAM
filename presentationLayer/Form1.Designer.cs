
namespace presentationLayer
{
    partial class CAM
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
            this.alumnosDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosDGV
            // 
            this.alumnosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnosDGV.Location = new System.Drawing.Point(40, 43);
            this.alumnosDGV.Name = "alumnosDGV";
            this.alumnosDGV.RowHeadersWidth = 51;
            this.alumnosDGV.RowTemplate.Height = 24;
            this.alumnosDGV.Size = new System.Drawing.Size(686, 345);
            this.alumnosDGV.TabIndex = 0;
            // 
            // CAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alumnosDGV);
            this.Name = "CAM";
            this.Text = "CAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView alumnosDGV;
    }
}

