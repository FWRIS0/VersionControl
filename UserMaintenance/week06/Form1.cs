using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week06.Entities;

namespace week06
{
    public partial class Form1 : Form
    {
        List<Ball> _balls = new List<Ball>();
        
        private BallFactory _factory;
        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }


        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            Ball b = Factory.CreateNew();
            b.Left = -b.Width;
            _balls.Add(b);
            mainpanel.Controls.Add(b);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            int max = 0;
            foreach (var b in _balls)
            {
                b.MoveBall();
                if (max<b.Left)
                {
                    max = b.Left;
                }
            }
            if (max>=1000)
            {
                mainpanel.Controls.Remove(_balls[0]);
                _balls.Remove(_balls[0]);
            }
        }
    }
}
