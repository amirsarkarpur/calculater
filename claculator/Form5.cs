using System;
using System.Net.Http;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace claculator
{
    public partial class Form5 : Form
    {

        Button numberr;
        int firstsum = 0;
        int secondsum = 0;
        double vahed;
        string dolar;
        string euro;


        public Form5()
        {
            InitializeComponent();
        }

        double tabdil(string label1, string secondn, string firstn)
        {

            double label11 = Convert.ToDouble(label1);
            double dollar = Convert.ToDouble(dolar);
            double eurro = Convert.ToDouble(euro);


            if (firstn == "dollar" && secondn == "euro")
            {
                dollar *= label11;
                vahed = dollar / eurro;

            }

            else if (firstn == "euro" && secondn == "dollar")
            {
                eurro *= label11;

                vahed = eurro / dollar;

            }

            else if (firstn == "reall" && secondn == "dollar")
            {

                vahed = label11 / dollar;

            }

            else if (firstn == "reall" && secondn == "euro")
            {

                vahed = label11 / eurro;

            }

            else if (firstn == "euro" && secondn == "reall")
            {

                ;
                vahed = label11 * eurro;

            }

            else if (firstn == "dollar" && secondn == "reall")
            {

                vahed = label11 * dollar;

            }

            


            return vahed;
        }

        private void Click(object sender, EventArgs e)
        {
            numberr = (Button)sender;

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += numberr.Text;

            label2.Text = tabdil(label1.Text, secondn.Text, firstn.Text) + "";


        }

        private void Clear(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";


        }

        private void Backspace(object sender, EventArgs e)
        {
            string vasettext = label1.Text;
            vasettext = vasettext.Remove(vasettext.Length - 1);
            label1.Text = vasettext;

            label2.Text = tabdil(label1.Text, secondn.Text, firstn.Text) + "";
        }

        private void first(object sender, EventArgs e)
        {
            if (firstsum % 2 == 0)
            {

                firstlable.Show();
                dollar1.Show();
                euro1.Show();
                reall1.Show();

            }

            else
            {

                firstlable.Hide();
                dollar1.Hide();
                euro1.Hide();
                reall1.Hide();

            }

            firstsum++;
        }



        private void second(object sender, EventArgs e)
        {
            if (secondsum % 2 == 0)
            {

                secondlabel.Show();
                dollar2.Show();
                euro2.Show();
                reall2.Show();

            }

            else
            {

                secondlabel.Hide();
                dollar2.Hide();
                euro2.Hide();
                reall2.Hide();

            }

            secondsum++;
        }

        private void clickvahed(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            firstsum = 0;
            firstlable.Hide();
            dollar1.Hide();
            euro1.Hide();
            reall1.Hide();

            firstn.Text = number.Text;

            label2.Text = tabdil(label1.Text, secondn.Text, firstn.Text) + "";

        }

        private void clickvahed2(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            secondsum = 0;
            secondlabel.Hide();
            dollar2.Hide();
            euro2.Hide();
            reall2.Hide();

            secondn.Text = number.Text;

            label2.Text = tabdil(label1.Text, secondn.Text, firstn.Text) + "";

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            firstlable.Hide();
            secondlabel.Hide();
            dollar1.Hide();
            dollar2.Hide();
            euro1.Hide();
            euro2.Hide();
            reall1.Hide();
            reall2.Hide();


            string apiUrl = "http://api.navasan.tech/latest/?api_key=free88AXqQgj6y8rqhBIOFcdETngy8Dm";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                    decimal doolerValue = data.usd_sell.value;
                    decimal euroValue = data.eur.value;



                    dolar = $" {doolerValue} ";
                    
                    euro = $" {euroValue} ";
                }

            }

            label3.Hide();

        }
    }
}
