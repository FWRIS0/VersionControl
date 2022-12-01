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
        Random rng = new Random(1234);
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        public Form1()
        {
            InitializeComponent();

            Population = PersonRead(@"C:\Temp\nép-teszt.csv");
            BirthProbabilities = BirthProbabilityRead(@"C:\Temp\születés.csv");
            DeathProbabilities = DeathProbabilityRead(@"C:\Temp\halál.csv");

            for (int year = 2005; year <= 2024; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    SimStep(year, Population[i]);
                }
                int nbrOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();
                Console.WriteLine(
                    string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales));
            }
        }

        public void SimStep(int Year, Person person)
        {
            if (!person.IsAlive) return;

            int Age = Year - person.BirthYear;

            double DeathProb = (from d in DeathProbabilities
                                where d.Age == Age && d.Gender == person.Gender
                                select d.Probability).FirstOrDefault();

            if (rng.NextDouble()<=DeathProb) person.IsAlive = false;

            if (!person.IsAlive && person.Gender == Gender.Male) return;

            double BirthProb = (from b in BirthProbabilities
                                where b.Age == Age && b.NumberOfChildren == person.NumberOFChildren
                                select b.Probability).FirstOrDefault();

            if (rng.NextDouble()<=BirthProb)
            {
                Population.Add(new Person()
                {
                    BirthYear = Year,
                    Gender = (Gender)Enum.Parse(typeof(Gender), rng.Next(1, 3).ToString()),
                    NumberOFChildren = 0
                });
            }
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
