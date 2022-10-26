using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week06.Abstractions;

namespace week06.Entities
{
    public class Present : Toy
    {
        public SolidBrush Ribbon { get; private set; }
        public SolidBrush Box { get; private set; }
        public Present(Color color_r, Color color_b)
        {
            Ribbon = new SolidBrush(color_r);
            Box = new SolidBrush(color_b);
        }
        protected override void DrawImage(Graphics graphics)
        {
            graphics.FillRectangle(Box, 0, 0, Width, Height);
            graphics.FillRectangle(Ribbon, 2*Width / 5, 0, Width/5, Height);
            graphics.FillRectangle(Ribbon, 0, 2 * Height / 5, Width, Height/5);
        }
        protected override void Interaction(object sender, EventArgs e)
        {
            MessageBox.Show("Ajándék");
        }

        protected override void SpecialMove()
        {
            
        }
    }
}
