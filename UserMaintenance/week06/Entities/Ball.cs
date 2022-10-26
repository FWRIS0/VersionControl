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
        bool lefele;

        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
        }

        protected override void DrawImage(Graphics graphics)
        {
            graphics.FillEllipse(BallColor, 0, 0, Width, Height);
        }

        protected override void Interaction(object sender, EventArgs e)
        {
            Random rnd = new Random();
            BallColor = new SolidBrush(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            Invalidate();
            MessageBox.Show("Labda");
        }

        protected override void SpecialMove()
        {
            if (lefele && Top <= 50)
            {
                Top += 1;
            }
            else if (lefele == false && Top >= 0)
            {
                Top -= 1;
            }
            else
            {
                lefele = !lefele;
            }
        }
    }
}
