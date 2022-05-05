using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer.Forms.ConsultaFormatos
{
    public partial class vistaPreviaFormato : Form
    {
        int format = 0;
        consultaFormatos formvar;
        public vistaPreviaFormato(int formato,Form consultaform)
        {
            InitializeComponent();
            PLConsultaFormatos.vistaPrevia(vistaPreviaPDF,tituloLabel,formatoLabel);
            string RunningPath = "";
            string FileName = "";
            format = formato;
            formvar = (consultaFormatos)consultaform;
            switch (formato)
            {
                case 1:
                    RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    FileName = string.Format("{0}Resources\\Formatos\\FCI1.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                    vistaPreviaPDF.src = FileName;
                    break;

                case 2:
                    RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    FileName = string.Format("{0}Resources\\Formatos\\FCI2.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                    vistaPreviaPDF.src = FileName;
                    break;

                case 3:
                    RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    FileName = string.Format("{0}Resources\\Formatos\\FCI3.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                    vistaPreviaPDF.src = FileName;
                    break;

                case 4:
                    RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    FileName = string.Format("{0}Resources\\Formatos\\FCI4.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                    vistaPreviaPDF.src = FileName;
                    break;

                case 5:
                    RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    FileName = string.Format("{0}Resources\\Formatos\\FCI5.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                    vistaPreviaPDF.src = FileName;
                    break;

                case 6:
                    RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    FileName = string.Format("{0}Resources\\Formatos\\FCI6.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                    vistaPreviaPDF.src = FileName;
                    break;

                case 7:
                    RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    FileName = string.Format("{0}Resources\\Formatos\\FCI7.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                    vistaPreviaPDF.src = FileName;
                    break;

                case 8:
                    RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    FileName = string.Format("{0}Resources\\Formatos\\FCI8.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                    vistaPreviaPDF.src = FileName;
                    break;

                case 9:
                    RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    FileName = string.Format("{0}Resources\\Formatos\\FCI9.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                    vistaPreviaPDF.src = FileName;
                    break;
            }
        }

        private void vistaPreviaFormato_FormClosed(object sender, FormClosedEventArgs e)
        {
            formvar.cambiarbandera(format);
        }
    }
}
