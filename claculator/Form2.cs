using System.Globalization;

namespace claculator
{
    public partial class Form2 : Form
    {
        int hexsum = 0;
        int decsum = 0;
        int binsum = 0;
        int octsum = 0;
        int optsum = 0;
        double numberr1 = 0;
        double numberr2 = 0;
        string opt = "";
        bool isfirstnumber = true;
        bool isnegetiv = true;
        double sum = 0;
        int windowsum = 0;
        int cheksum = 0;
        bool aval = false;
        Button numberr;
        string program;
        bool DEc = false;
        bool HEx = false;
        bool OCt = false;
        bool BIn = false;

        void programer()
        {


            if (DEc)
            {
                int result = Convert.ToInt32(label1.Text);
                HEXlablle.Text = result.ToString("X");

                int resultt = Convert.ToInt32(label1.Text);
                string hii = Convert.ToString(resultt, 2);
                BINlablle.Text = hii + "";

                int resultttt = Convert.ToInt32(label1.Text);
                string hiii = Convert.ToString(resultttt, 8);
                OCTlablle.Text = hiii + "";

                DEClablle.Text = label1.Text;
            }

            else if (HEx)
            {

                string vasettt = label1.Text;
                int vaseterrr = Convert.ToInt32(vasettt, 16);
                DEClablle.Text = vaseterrr + "";


                string resultt = label1.Text;
                int hiii = Convert.ToInt32(resultt, 16);
                string hj = Convert.ToString(hiii, 8);
                OCTlablle.Text = hj + "";


                string resulttt = label1.Text;
                string hiiii = Convert.ToString(Convert.ToUInt32(resulttt, 16), 2);
                BINlablle.Text = hiiii + "";

                HEXlablle.Text = label1.Text;
            }

            else if (OCt)
            {


                string vasettt = label1.Text;
                int vaseterrr = Convert.ToInt32(vasettt, 8);
                DEClablle.Text = vaseterrr + "";



                string vasett = label1.Text;
                int vaseterr = Convert.ToInt32(vasett, 8);
                string Avasett = vaseterr.ToString("X");
                HEXlablle.Text = Avasett + "";


                string vaset = label1.Text;
                int vaseter = Convert.ToInt32(vaset, 8);
                string Avaset = Convert.ToString(vaseter, 2);
                BINlablle.Text = Avaset + "";



                OCTlablle.Text = label1.Text;
            }


            else if (BIn)
            {


                string vasettt = label1.Text;
                int vaseterrr = Convert.ToInt32(vasettt, 2);
                DEClablle.Text = vaseterrr + "";


                string vasett = label1.Text;
                int vaseterr = Convert.ToInt32(vasett, 2);
                string Avasett = vaseterr.ToString("X");
                HEXlablle.Text = Avasett + "";



                string vaset = label1.Text;
                int vaseter = Convert.ToInt32(vaset, 2);
                string Avaset = Convert.ToString(vaseter, 8);
                OCTlablle.Text = Avaset + "";

                BINlablle.Text = label1.Text;

            }

        }

        void number(string text)
        {
            if (isfirstnumber)
            {
                numberr1 = Convert.ToDouble(label1.Text);

                if (!isnegetiv)
                {
                    numberr1 = numberr1;
                    isnegetiv = true;

                }
            }
            else
            {
                numberr2 = Convert.ToDouble(label1.Text);
                if (!isnegetiv)
                {
                    numberr2 = numberr2;

                }
            }
        }

        public Form2()
        {
            InitializeComponent();

        }


        int tavan(double input)

        {
            int tavansum = 1;
            for (int i = 1; i <= input; i++)
            {
                tavansum *= i;
            }

            return tavansum;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            window.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox4.Hide();
            

            this.ActiveControl = label1;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            numberr2 = 0;
            sum = 0;

            HEXlablle.Text = " ";
            DEClablle.Text = " ";
            OCTlablle.Text = " ";
            BINlablle.Text = " ";

            isfirstnumber = true;

            this.ActiveControl = label1;
        }
        private void button16_Click(object sender, EventArgs e)
        {

            isnegetiv = false;
            label1.Text += button16.Tag;
            this.ActiveControl = label1;
        }

        private void clik(object sender, EventArgs e)
        {

            numberr = (Button)sender;

            if (label1.Text == sum + "")
            {
                label1.Text = "";
            }

            label1.Text += numberr.Text;
            label3.Text += numberr.Text;
            programer();

            if (numberr.Text == "A")
            {
                label2.Text += "10";
            }
            else if (numberr.Text == "B")
            {
                label2.Text += "11";
            }
            else if (numberr.Text == "C")
            {
                label2.Text += "12";
            }
            else if (numberr.Text == "D")
            {
                label2.Text += "13";
            }
            else if (numberr.Text == "E")
            {
                label2.Text += "14";
            }
            else if (numberr.Text == "F")
            {
                label2.Text += "15";
            }

            else
            {
                label2.Text += numberr.Text;
            }


            if (isfirstnumber)
            {

                if (HEx)
                {
                    numberr1 = Convert.ToDouble(label2.Text);
                }

                else
                {
                    numberr1 = Convert.ToDouble(label1.Text);
                }

                if (!isnegetiv)
                {
                    numberr1 = numberr1;
                    isnegetiv = true;

                }

            }


            else
            {

                if (HEx)
                {
                    numberr2 = Convert.ToDouble(label2.Text);
                }

                else
                {
                    numberr2 = Convert.ToDouble(label1.Text);
                }

                if (!isnegetiv)
                {
                    numberr2 = numberr2;

                }

            }

            this.ActiveControl = label1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string vasettext = label1.Text;
            vasettext = vasettext.Remove(vasettext.Length - 1);
            label1.Text = vasettext;

            string vasettextt = label2.Text;
            vasettextt = vasettextt.Remove(vasettextt.Length - 1);
            label2.Text = vasettextt;

            programer();

            this.ActiveControl = label1;
        }

        private void handelopt(object sender, EventArgs e)
        {
            isfirstnumber = false;

            if (optsum == 0)
            {
                if (aval)
                {
                    label3.Text = sum + "";
                }

                Button optbutton = (Button)sender;
                opt = optbutton.Tag + "";
                label3.Text += optbutton.Text + "";
                label1.Text = "";
                label2.Text = "";

            }

            else
            {
                switch (opt)
                {
                    case "plus":
                        sum = numberr1 + numberr2;
                        break;

                    case "menha":
                        sum = numberr1 - numberr2;
                        break;

                    case "zarb":
                        sum = numberr1 * numberr2;
                        break;

                    case "tagh":
                        sum = numberr1 / numberr2;
                        break;

                    case "dars":
                        sum = (numberr1 * numberr2) / 100;
                        break;

                    case "Tavan":
                        sum = Math.Pow(numberr1, numberr2);
                        break;

                    case "fac":

                        sum = tavan(numberr1);
                        break;

                    case "baghi":

                        sum = numberr1 % numberr2;
                        break;

                    case "AND":

                        int x1 = (int)numberr1;
                        int x2 = (int)numberr2;

                        sum = x1 & x2;

                        break;

                    case "OR":

                        int x11 = (int)numberr1;
                        int x22 = (int)numberr2;

                        sum = x11 | x22;

                        break;


                }

                numberr1 = sum;

                label2.Text = numberr1 + "";

                label3.Text += sum + "";




                Button optbutton = (Button)sender;
                opt = optbutton.Tag + "";
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label3.Text = sum + "";
                label1.Text = sum + "";
                label2.Text = sum + "";

                label3.Text += optbutton.Text + "";
            }

            this.ActiveControl = label1;

            optsum++;
        }

        private void mosavi(object sender, EventArgs e)
        {

            switch (opt)
            {
                case "plus":
                    sum = numberr1 + numberr2;
                    break;

                case "menha":
                    sum = numberr1 - numberr2;
                    break;

                case "zarb":
                    sum = numberr1 * numberr2;
                    break;

                case "tagh":
                    sum = numberr1 / numberr2;
                    break;

                case "dars":
                    sum = (numberr1 * numberr2) / 100;
                    break;

                case "Tavan":
                    sum = Math.Pow(numberr1, numberr2);
                    break;

                case "fac":

                    sum = tavan(numberr1);
                    break;

                case "baghi":

                    sum = numberr1 % numberr2;
                    break;

                case "AND":

                    int x1 = (int)numberr1;
                    int x2 = (int)numberr2;

                    sum = x1 & x2;

                    break;

                case "OR":

                    int x11 = (int)numberr1;
                    int x22 = (int)numberr2;

                    sum = x11 | x22;

                    break;

            }


            numberr1 = sum;



            label1.Text = sum + "";
            label2.Text = sum + "";
            label3.Text += "=" + sum + "";

            optsum = 0;
            aval = true;

            programer();

            this.ActiveControl = label1;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (windowsum % 2 == 0)
            {
                window.Show();
                checkBox1.Show();
                checkBox2.Show();

                checkBox4.Show();
                checkBox5.Show();
                checkBox6.Show();

            }
            else
            {
                window.Hide();
                checkBox1.Hide();
                checkBox2.Hide();

                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();

            }
            windowsum++;
            this.ActiveControl = label1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cheksum % 2 == 0)
            {
                this.BackColor = Color.WhiteSmoke;
                backspace.BackColor = Color.WhiteSmoke;
                window.BackColor = Color.DimGray;
                button1.ForeColor = Color.DimGray;


            }
            else
            {
                this.BackColor = Color.DimGray;
                backspace.BackColor = Color.DimGray;
                window.BackColor = Color.White;
                button1.ForeColor = Color.Transparent;
            }
            cheksum++;

            this.ActiveControl = label1;
        }



        private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {



            if (e.KeyCode == Keys.NumPad1)
            {
                label1.Text += "1";
                label2.Text += "1";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.NumPad2)
            {
                label1.Text += "2";
                label2.Text += "2";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.NumPad0)
            {
                label1.Text += "0";
                label2.Text += "0";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.NumPad3)
            {
                label1.Text += "3";
                label2.Text += "3";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.NumPad4)
            {
                label1.Text += "4";
                label2.Text += "4";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.NumPad5)
            {
                label1.Text += "5";
                label2.Text += "5";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.NumPad6)
            {
                label1.Text += "6";
                label2.Text += "6";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.NumPad7)
            {
                label1.Text += "7";
                label2.Text += "7";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.NumPad8)
            {
                label1.Text += "8";
                label2.Text += "8";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.NumPad9)
            {
                label1.Text += "9";
                label2.Text += "9";
                number(label2.Text);
            }

            else if (e.KeyCode == Keys.Add)
            {
                opt = "plus";
                isfirstnumber = false;
                label1.Text = "";
                label2.Text = "";
            }

            else if (e.KeyCode == Keys.Subtract)
            {
                opt = "menha";
                isfirstnumber = false;
                label1.Text = "";
                label2.Text = "";
            }

            else if (e.KeyCode == Keys.Multiply)
            {
                opt = "zarb";
                isfirstnumber = false;
                label1.Text = "";
                label2.Text = "";
            }

            else if (e.KeyCode == Keys.Divide)
            {
                opt = "tagh";
                isfirstnumber = false;
                label1.Text = "";
                label2.Text = "";
            }

            else if (e.KeyCode == Keys.Enter)
            {
                switch (opt)
                {
                    case "plus":
                        sum = numberr1 + numberr2;
                        break;

                    case "menha":
                        sum = numberr1 - numberr2;
                        break;

                    case "zarb":
                        sum = numberr1 * numberr2;
                        break;

                    case "tagh":
                        sum = numberr1 / numberr2;
                        break;

                    case "dars":
                        sum = (numberr1 * numberr2) / 100;
                        break;

                    case "Tavan":
                        sum = Math.Pow(numberr1, numberr2);
                        break;

                    case "fac":

                        sum = tavan(numberr1);
                        break;

                    case "baghi":

                        sum = numberr1 % numberr2;
                        break;
                }

                numberr1 = sum;

                label1.Text = sum + "";
                label2.Text = sum + "";

                this.ActiveControl = label1;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


            this.Hide();

            new Form1().ShowDialog();

            this.Close();


        }

        private void Dec(object sender, EventArgs e)
        {
            if (decsum % 2 == 0)
            {
                DEc = true;

                button9.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button14.Enabled = false;
                button7.Enabled = false;
                OR.Enabled = false;

                button14.Enabled = false;


            }
            else
            {
                DEc = false;

                button9.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                OR.Enabled = true;
                button14.Enabled = true;
            }

            decsum++;

        }

        private void Oct(object sender, EventArgs e)
        {
            if (octsum % 2 == 0)
            {
                OCt = true;

                button9.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                OR.Enabled = false;
                button14.Enabled = false;
                number8.Enabled = false;
                number9.Enabled = false;
            }
            else
            {
                OCt = false;

                button9.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                OR.Enabled = true;
                button14.Enabled = true;
                number8.Enabled = true;
                number9.Enabled = true;
            }

            octsum++;
        }

        private void Bin(object sender, EventArgs e)
        {
            if (binsum % 2 == 0)
            {
                BIn = true;

                button9.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                OR.Enabled = false;
                button14.Enabled = false;
                number9.Enabled = false;
                number8.Enabled = false;
                number7.Enabled = false;
                number6.Enabled = false;
                number5.Enabled = false;
                number4.Enabled = false;
                number3.Enabled = false;
                number2.Enabled = false;




            }
            else
            {
                BIn = false;

                button9.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                OR.Enabled = true;
                button14.Enabled = true;
                number9.Enabled = true;
                number8.Enabled = true;
                number7.Enabled = true;
                number6.Enabled = true;
                number5.Enabled = true;
                number4.Enabled = true;
                number3.Enabled = true;
                number2.Enabled = true;
            }

            binsum++;
        }

        private void Hex(object sender, EventArgs e)
        {
            if (hexsum % 2 == 0)
            {
                HEx = true;
            }
            else
            {
                HEx = false;
            }

            hexsum++;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();

            new Form3().ShowDialog();

            this.Close();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();

            new Form5().ShowDialog();

            this.Close();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();

            new Form4().ShowDialog();

            this.Close();
        }
    }
}