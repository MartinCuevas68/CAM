using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace presentationLayer
{
    public class buttonSystem : Button
    {
        private int borderSize;
        private int borderRadius = 20;
        private Color borderColor = Color.Black;

        [Category("R] Opcional")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("R] Opcional")]
        public Color BackgroundColor
        {
            get => this.BackColor;
            set => this.BackColor = value;

        }

        public buttonSystem()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new Size(260, 75);
            this.BackColor = Color.FromArgb(162, 98, 242);
            this.ForeColor = Color.White;
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(187, 142, 244);
            this.Font = new Font("Gadugi", 14, FontStyle.Bold);
            this.Text = "Botón";
            this.Padding = new Padding(6, 6, 6, 6);
            this.borderRadius = 20;

        }

        private GraphicsPath GetFigurePath(RectangleF rectangulo, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangulo.X, rectangulo.Y, radius, radius, 180, 90);
            path.AddArc(rectangulo.Width - radius, rectangulo.Y, radius, radius, 270, 90);
            path.AddArc(rectangulo.Width - radius, rectangulo.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangulo.X, rectangulo.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2)
            {

                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}