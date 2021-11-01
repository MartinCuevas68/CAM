
namespace presentationLayer
{
    partial class Form1
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
            this.siguienteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // siguienteButton
            // 
            this.siguienteButton.Location = new System.Drawing.Point(169, 83);
            this.siguienteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siguienteButton.Name = "siguienteButton";
            this.siguienteButton.Size = new System.Drawing.Size(56, 19);
            this.siguienteButton.TabIndex = 0;
            this.siguienteButton.Text = "Siguiente";
            this.siguienteButton.UseVisualStyleBackColor = true;
            this.siguienteButton.Click += new System.EventHandler(this.siguienteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.siguienteButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button siguienteButton;
    }
}

