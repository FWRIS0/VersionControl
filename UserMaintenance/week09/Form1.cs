using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week09.Entities;
using System.IO;

namespace week09
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        public Form1()
        {
            InitializeComponent();

            Population = PersonRead(@"C:\Temp\nép.csv");
            BirthProbabilities = BirthProbabilityRead(@"C:\Temp\születés.csv");
            DeathProbabilities = DeathProbabilityRead(@"C:\Temp\halál.csv");
        }

        public List<Person> PersonRead(string Path)
        {
            List<Person> pop = new List<Person>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    pop.Add(new Person()
                    {
                        BirthYear = int.Parse(sor[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), sor[1]),
                        NumberOFChildren = byte.Parse(sor[2])
                    });
                }
            }
            return pop;
        }
        public List<BirthProbability> BirthProbabilityRead(string Path)
        {
            List<BirthProbability> birthprob = new List<BirthProbability>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    birthprob.Add(new BirthProbability()
                    {
                        Age = int.Parse(sor[0]),
                        NumberOfChildren = byte.Parse(sor[1]),
                        Probability = double.Parse(sor[2])
                    });
                }
            }
            return birthprob;
        }
        public List<DeathProbability> DeathProbabilityRead(string Path)
        {
            List<DeathProbability> deathprob = new List<DeathProbability>();
            using (StreamReader sr = new StreamReader(Path))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    deathprob.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), sor[0]),
                        Age = byte.Parse(sor[1]),
                        Probability = double.Parse(sor[2])
                    });
                }
            }
            return deathprob;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
