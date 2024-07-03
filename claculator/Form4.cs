using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claculator
{
    public partial class Form4 : Form
    {

        Button numberr;
        int firstsum = 0;
        int secondsum = 0;
        double vahed;

        public Form4()
        {
            InitializeComponent();
        }

        double tabdil(string label1, string secondn, string firstn)
        {

            double label11 = Convert.ToDouble(label1);

            if (firstn == "kilometers" && secondn == "meters")
            {

                vahed = label11 * 1000;

            }

            else if (firstn == "meters" && secondn == "kilometers")
            {

                vahed = label11 / 1000;

            }

            else if (firstn == "kilometers" && secondn == "centimetre")
            {

                vahed = label11 * 100000;

            }

            else if (firstn == "centimetre" && secondn == "kilometers")
            {

                vahed = label11 / 100000;

            }

            else if (firstn == "kilometers" && secondn == "millimeter")
            {

                vahed = label11 * 1000000;

            }

            else if (firstn == "millimeter" && secondn == "kilometers")
            {

                vahed = label11 / 1000000;

            }

            else if (firstn == "meters" && secondn == "centimetre")
            {

                vahed = label11 * 100;

            }

            else if (firstn == "centimetre" && secondn == "meters")
            {

                vahed = label11 / 1000000;

            }

            else if (firstn == "meters" && secondn == "millimeter")
            {

                vahed = label11 * 1000;

            }

            else if (firstn == "millimeter" && secondn == "meters")
            {

                vahed = label11 / 1000;

            }

            else if (firstn == "centimetre" && secondn == "millimeter")
            {

                vahed = label11 * 10;

            }

            else if (firstn == "millimeter" && secondn == "centimetre")
            {

                vahed = label11 / 10;

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
                kilometers1.Show();
                meters1.Show();
                centimetre1.Show();
                millimeter1.Show();

            }

            else
            {

                firstlable.Hide();
                kilometers1.Hide();
                meters1.Hide();
                centimetre1.Hide();
                millimeter1.Hide();

            }

            firstsum++;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            firstlable.Hide();
            kilometers1.Hide();
            meters1.Hide();
            centimetre1.Hide();
            millimeter1.Hide();
            secondlabel.Hide();
            kilometers2.Hide();
            meters2.Hide();
            centimetre2.Hide();
            millimeter2.Hide();
        }

        private void second(object sender, EventArgs e)
        {
            if (secondsum % 2 == 0)
            {

                secondlabel.Show();
                kilometers2.Show();
                meters2.Show();
                centimetre2.Show();
                millimeter2.Show();

            }

            else
            {

                secondlabel.Hide();
                kilometers2.Hide();
                meters2.Hide();
                centimetre2.Hide();
                millimeter2.Hide();

            }

            secondsum++;
        }

        private void clickvahed(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            firstsum = 0;
            firstlable.Hide();
            kilometers1.Hide();
            meters1.Hide();
            centimetre1.Hide();
            millimeter1.Hide();

            firstn.Text = number.Text;

            label2.Text = tabdil(label1.Text, secondn.Text, firstn.Text) + "";

        }

        private void clickvahed2(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            secondsum = 0;
            secondlabel.Hide();
            kilometers2.Hide();
            meters2.Hide();
            centimetre2.Hide();
            millimeter2.Hide();

            secondn.Text = number.Text;

            label2.Text = tabdil(label1.Text, secondn.Text, firstn.Text) + "";

        }
    }
}
