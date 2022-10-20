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

namespace week05
{
    public partial class Form1 : Form
    {
        MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
        public Form1()
        {
            Arfolyamleker();
            InitializeComponent();
        }
        public void Arfolyamleker()
        {
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();
            request.currencyNames = "EUR";
            request.startDate = "2020-01-01";
            request.endDate = "2020-06-30";
            var response = mnbService.GetExchangeRates(request);
            string result = response.GetExchangeRatesResult;
            using (StreamWriter sw = new StreamWriter("result.xml"))
            {
                sw.Write(result);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
