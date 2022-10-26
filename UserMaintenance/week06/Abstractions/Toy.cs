using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace week06.Abstractions
{
    public abstract class Toy : Label
    {
        public Toy()
        {
            AutoSize = false;
            Width = 50;
            Height = 50;
            Paint += Toy_Paint;
            Click += Interaction;
        }

        protected abstract void Interaction(object sender, EventArgs e);

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        protected abstract void DrawImage(Graphics graphics);
        protected abstract void SpecialMove();
        public virtual void MoveToy()
        {
            Left += 1;
            SpecialMove();
        }
    }
}
