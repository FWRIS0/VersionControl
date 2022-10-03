﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace week04
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> flats;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            flats = context.Flats.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
