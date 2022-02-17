using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public partial class imprimirFormatos : Form
    {
        public imprimirFormatos()
        {
            InitializeComponent();
        }
        //El siguiente código está destinado a abrir los formatos en el navegador
        //predeterminado (se recomienda Google Chrome). Deben estar guardados como PDF y
        //alojados en el root del servidor preferente en una carpeta llamada "Formatos",

        //FCI1 Ficha de identificación
        private void imprimirFCI1Button_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "F:\\FC11.pdf");
            Process.Start(pdfPath);
        }
        //FCI2 Entrevista de Eq. de Apoyo
        private void imprimirFCI2Button_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "C:\\Formatos\\FCI2.pdf");
            Process.Start(pdfPath);
        }
        //FCI3 Entrevista Docente a Padre de Familia
        private void imprimirFCI3Button_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "C:\\Formatos\\FCI3.pdf");
            Process.Start(pdfPath);
        }
        //FCI4 Evaluación Inicial
        private void imprimirFCI4Button_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "C:\\Formatos\\FCI4.pdf");
            Process.Start(pdfPath);
        }
        //FCI5 Estilo de Aprendizaje
        private void imprimirFCI5Button_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "C:\\Formatos\\FCI5.pdf");
            Process.Start(pdfPath);
        }
        //FCI6 Evolución Individual
        private void imprimirFCI6Button_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "C:\\Formatos\\FCI6.pdf");
            Process.Start(pdfPath);
        }
        //FCI7 Evaluación Psicopedagógica
        private void imprimirFCI7Button_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "C:\\Formatos\\FCI7.pdf");
            Process.Start(pdfPath);
        }
        //FCI8 Propuesta Curricular Adaptada
        private void imprimirFCI8Button_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "C:\\Formatos\\FCI8.pdf");
            Process.Start(pdfPath);
        }
        //FCI9 Observación en el Recreo
        private void imprimirFCI9Button_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "C:\\Formatos\\FCI9.pdf");
            Process.Start(pdfPath);
        }
}
}
