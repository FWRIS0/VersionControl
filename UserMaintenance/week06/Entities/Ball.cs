using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week06.Abstractions;

namespace week06
{
    public class Ball : Toy
    {
        public SolidBrush BallColor { get; private set; }

        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
        }
        protected override void DrawImage(Graphics graphics)
        {
            graphics.FillEllipse(BallColor, 0, 0, Width, Height);
        }
    }
}
