using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week06.Abstractions;
using week06.Entities;

namespace week06
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        
        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value;
                DisplayNext();
            }
        }

        Toy _nextToy;


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
            Toy t = Factory.CreateNew();
            t.Left = -t.Width;
            _toys.Add(t);
            mainpanel.Controls.Add(t);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            int max = 0;
            foreach (var t in _toys)
            {
                t.MoveToy();
                if (max<t.Left)
                {
                    max = t.Left;
                }
            }
            if (max>=1000)
            {
                mainpanel.Controls.Remove(_toys[0]);
                _toys.Remove(_toys[0]);
            }
        }

        public void DisplayNext()
        {
            if (_nextToy != null)
            {
                this.Controls.Remove(_nextToy);
            }
            _nextToy = Factory.CreateNew();
            _nextToy.Left = label1.Left + label1.Width;
            _nextToy.Top = label1.Top/4;
            this.Controls.Add(_nextToy);
        }

        private void btncar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void btnball_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory 
            { 
                BallColor = btncolor.BackColor
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ColorDialog color = new ColorDialog();
            color.Color = button.BackColor;
            if (color.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            button.BackColor = color.Color;
        }

        private void btnpresent_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory
            {
                Ribbon = btnpresentribbon.BackColor,
                Box = btnpresentbox.BackColor
            };
        }
    }
}
