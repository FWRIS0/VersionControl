using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;
using System.IO;


namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            labelLastName.Text = Resource1.FullName;
            buttonAdd.Text = Resource1.Add;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User u = new User()
            {
                FullName = textBoxLastName.Text
            };
            users.Add(u);
            using (StreamWriter sw = new StreamWriter("felhasznalok.txt"))
            {
                for (int i = 0; i < users.Count; i++)
                {
                    sw.WriteLine(users[i].FullName);
                }
            }
        }
    }
}
