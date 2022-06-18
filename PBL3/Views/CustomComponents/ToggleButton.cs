using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace PBL3.Views.CustomComponents
{
    public class ToggleButton : CheckBox
    {
        //Fields 
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;

        //Constructor
        public ToggleButton()
        {
            this.MinimumSize = new Size(20, 12);
            this.Size = new Size(45, 22);
        }

        public Color OnBackColor { get => onBackColor; set {
                onBackColor = value;
                this.Invalidate();
            } 
        }
        public Color OnToggleColor { get => onToggleColor; set { 
                onToggleColor = value;
                this.Invalidate();
                    } 
        }
        public Color OffBackColor { get => offBackColor; set { offBackColor = value; this.Invalidate(); } }
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate(); } }

        //Methods
        public GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) //ON
            {
                //Drawing control surface
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                //Drawing the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), this.Width - this.Height + 1, 2, toggleSize, toggleSize);
            }
            else //OFF
            {
                //Drawing control surface
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                //Drawing the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), 2, 2, toggleSize, toggleSize);
            }
        }
    }
}
