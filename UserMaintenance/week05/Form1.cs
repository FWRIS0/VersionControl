using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week05.MnbServiceReference;
using System.IO;
using week05.Entities;
using System.Xml;

namespace week05
{
    public partial class Form1 : Form
    {
        MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
        BindingList<RateData> Rates = new BindingList<RateData>();
        XmlDocument xml = new XmlDocument();
        public Form1()
        {
            Arfolyamleker();
            InitializeComponent();
            dataGridView1.DataSource = Rates;
        }
        public void Arfolyamleker()
        {
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();
            request.currencyNames = "EUR";
            request.startDate = "2020-01-01";
            request.endDate = "2020-06-30";
            var response = mnbService.GetExchangeRates(request);
            string result = response.GetExchangeRatesResult;
            XMLFeldolg(result);
            using (StreamWriter sw = new StreamWriter("result.xml"))
            {
                sw.Write(result);
            }
        }
        public void XMLFeldolg(string result)
        {
            xml.LoadXml(result);
            foreach (XmlElement x in xml.DocumentElement)
            {
                var child =  (XmlElement)x.ChildNodes[0];
                RateData rd = new RateData()
                {
                    Date = Convert.ToDateTime(x.GetAttribute("date")),
                    Currency = child.GetAttribute("curr")
                };
                if (int.Parse(child.GetAttribute("unit")) != 0)
                {
                    rd.Value = decimal.Parse(child.InnerText) / int.Parse(child.GetAttribute("unit"));
                }
                Rates.Add(rd);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
