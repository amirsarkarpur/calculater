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
    public partial class Form3 : Form
    {

        Button numberr;
        int firstsum = 0;
        int secondsum = 0;
        double vahed;

        public Form3()
        {
            InitializeComponent();
        }

        double tabdil(string label1 , string secondn , string firstn)
        {

           double label11 = Convert.ToDouble(label1);

            if (firstn == "kilogram" && secondn == "gram")
            {

                vahed = label11 * 1000;

            }

            else if (firstn == "gram" && secondn == "kilogram")
            {

                vahed = label11 / 1000;

            }

            else if (firstn == "gram" && secondn == "miligram")
            {

                vahed = label11 * 1000;

            }

            else if (firstn == "miligram" && secondn == "gram")
            {

                vahed = label11 / 1000;

            }

            else if (firstn == "miligram" && secondn == "kilogram")
            {

                vahed = label11 / 1000000;

            }

            else if (firstn == "kilogram" && secondn == "miligram")
            {

                vahed = label11 * 1000000;

            }

            else if (firstn == "Ton" && secondn == "gram")
            {

                vahed = label11 * 1000000;

            }

            else if (firstn == "gram" && secondn == "Ton")
            {

                vahed = label11 / 1000000;

            }

            else if (firstn == "Ton" && secondn == "kilogram")
            {

                vahed = label11 * 1000;

            }

            else if (firstn == "kilogram" && secondn == "Ton")
            {

                vahed = label11 / 1000;

            }

            else if (firstn == "Ton" && secondn == "miligram")
            {

                vahed = label11 * 1000000000;

            }

            else if (firstn == "miligram" && secondn == "Ton")
            {

                vahed = label11 / 1000000000;

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

            if (vasettext.Length > 1)
            {
                vasettext = vasettext.Remove(vasettext.Length - 1);
                label1.Text = vasettext;
                label2.Text = tabdil(label1.Text, secondn.Text, firstn.Text) + "";

            }

        }

        private void first(object sender, EventArgs e)
        {
            if (firstsum % 2 == 0)
            {

                firstlable.Show();
                kilogram1.Show();
                gram1.Show();
                miligram1.Show();
                Ton1.Show();

            }

            else
            {

                firstlable.Hide();
                kilogram1.Hide();
                gram1.Hide();
                miligram1.Hide();
                Ton1.Hide();

            }

            firstsum++;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            firstlable.Hide();
            kilogram1.Hide();
            gram1.Hide();
            miligram1.Hide();
            Ton1.Hide();
            secondlabel.Hide();
            kilogram2.Hide();
            gram2.Hide();
            miligram2.Hide();
            Ton2.Hide();
        }

        private void second(object sender, EventArgs e)
        {
            if (secondsum % 2 == 0)
            {

                secondlabel.Show();
                kilogram2.Show();
                gram2.Show();
                miligram2.Show();
                Ton2.Show();

            }

            else
            {

                secondlabel.Hide();
                kilogram2.Hide();
                gram2.Hide();
                miligram2.Hide();
                Ton2.Hide();

            }

            secondsum++;
        }

        private void clickvahed(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            firstsum = 0;
            firstlable.Hide();
            kilogram1.Hide();
            gram1.Hide();
            miligram1.Hide();
            Ton1.Hide();

            firstn.Text = number.Text;

            label2.Text = tabdil(label1.Text, secondn.Text, firstn.Text) + "";

        }

        private void clickvahed2(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            secondsum = 0;
            secondlabel.Hide();
            kilogram2.Hide();
            gram2.Hide();
            miligram2.Hide();
            Ton2.Hide();

            secondn.Text = number.Text;

            label2.Text = tabdil(label1.Text, secondn.Text, firstn.Text) + "";

        }
    }
}
