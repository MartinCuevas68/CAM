using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public partial class Formatosprueba : Form
    {

        private static readonly Encoding LocalEncoding = Encoding.UTF8;
        public Formatosprueba()
        {
            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                string FileName = string.Format("{0}Resources\\Formatos\\FCI1.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
                PDF.src = FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI2.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI3.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI4.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI5.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI6.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI7.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI8.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Formatos\\FCI9.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            PDF.src = FileName;
        }
    }
}
