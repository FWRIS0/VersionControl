using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week07.Entities;

namespace week07
{
    public partial class Form1 : Form
    {
        List<Tick> ticks;
        PortfolioEntities context = new PortfolioEntities();
        List<PortfolioItem> portfolioItems = new List<PortfolioItem>();
        public Form1()
        {
            InitializeComponent();
            ticks = context.Ticks.ToList();
            dataGridView1.DataSource = ticks;
            CreatePortfolio();
        }
        public void CreatePortfolio()
        {
            portfolioItems.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            portfolioItems.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });
            portfolioItems.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            dataGridView2.DataSource = portfolioItems;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
