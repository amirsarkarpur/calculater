
using System.IO;

namespace claculator
{
    public partial class Form1 : Form
    {

        string path = Environment.CurrentDirectory + "\\New Text Document.txt";


        double numberr1 = 0;
        double numberr2 = 0;
        string opt = "";
        bool isfirstnumber = true;
        bool isnegetiv = true;
        double sum = 0;
        int windowsum = 0;
        int cheksum = 0;
        int chek1sum = 0;
        int optsum = 0;
        bool aval = false;
        int koptsum = 0;
        bool kaval = false;
        int Hlabelsum = 0;
        bool check = true;


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

        public Form1()
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
            label2.Hide();
            
            historylabel.Hide();
            Delete.Hide();
            


            label3.Hide();
            domainUpDown1.Hide();
            domainUpDown2.Hide();
            domainUpDown3.Hide();

            historylabel.Text = File.ReadAllText(path);


            this.ActiveControl = label1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
            numberr1 = 0;
            numberr2 = 0;
            opt = "";
            optsum = 0;
            sum = 0;
            isfirstnumber = true;
            aval = false;

            this.ActiveControl = label1;
        }
        private void button16_Click(object sender, EventArgs e)
        {

            isnegetiv = false;
            label1.Text += button16.Tag;
            label2.Text += button16.Tag;
            this.ActiveControl = label1;
        }

        private void clik(object sender, EventArgs e)
        {
            check = true;

            Button number = (Button)sender;
            if (label1.Text == sum + "" && sum != 0)
            {
                label1.Text = "";
            }
            label1.Text += number.Text;
            label2.Text += number.Text;

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

            this.ActiveControl = label1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string vasettext = label1.Text;
            if (vasettext.Length >= 1)
            {
                vasettext = vasettext.Remove(vasettext.Length - 1);
                label1.Text = vasettext;

            }

            string vasettext2 = label2.Text;
            if (vasettext.Length >= 1)
            {
                vasettext2 = vasettext2.Remove(vasettext2.Length - 1);
                label2.Text = vasettext2;

            }

            if (isfirstnumber && label1.Text != "")
            {
                numberr1 = Convert.ToDouble(label1.Text);

            }
            else if (label1.Text != "")
            {
                numberr2 = Convert.ToDouble(label1.Text);
            }


            this.ActiveControl = label1;
        }

        private void handelopt(object sender, EventArgs e)
        {

            isfirstnumber = false;

            if (optsum == 0)
            {
                if (aval)
                {
                    label2.Text = sum + "";
                }

                Button optbutton = (Button)sender;
                opt = optbutton.Tag + "";
                label2.Text += optbutton.Text + "";
                label2.Show();
                label1.Text = "";
                check = false;

            }

            else
            {
                if (check)
                {


                    switch (opt)
                    {
                        case "plus":
                            sum = numberr1 + numberr2;
                            opt = "+";
                            break;

                        case "menha":
                            sum = numberr1 - numberr2;
                            opt = "-";
                            break;

                        case "zarb":
                            sum = numberr1 * numberr2;
                            opt = "x";
                            break;

                        case "tagh":
                            sum = numberr1 / numberr2;
                            opt = "/";
                            break;

                        case "dars":
                            sum = (numberr1 * numberr2) / 100;
                            opt = "%";
                            break;

                        case "Tavan":
                            sum = Math.Pow(numberr1, numberr2);
                            opt = "x2";
                            break;



                        case "baghi":

                            sum = numberr1 % numberr2;
                            opt = "%%";
                            break;

                        case "AND":

                            int x1 = (int)numberr1;
                            int x2 = (int)numberr2;

                            sum = x1 & x2;

                            break;

                    }

                    historylabel.Text += numberr1 + "" + opt + numberr2 + "=" + sum + "\n";



                    numberr1 = sum;




                    label1.Text = numberr1 + "";

                    label2.Text += sum + "";

                    string content = historylabel.Text;
                    File.WriteAllText(path, content);

                }


                Button optbutton = (Button)sender;
                opt = optbutton.Tag + "";



                label2.Text = numberr1 + "";
                label2.Text += optbutton.Text + "";

                check = false;

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
                    opt = "+";
                    break;

                case "menha":
                    sum = numberr1 - numberr2;
                    opt = "-";
                    break;

                case "zarb":
                    sum = numberr1 * numberr2;
                    opt = "x";
                    break;

                case "tagh":
                    sum = numberr1 / numberr2;
                    opt = "/";
                    break;

                case "dars":
                    sum = (numberr1 * numberr2) / 100;
                    opt = "%";
                    break;

                case "Tavan":
                    sum = Math.Pow(numberr1, numberr2);
                    opt = "x2";
                    break;

                case "fac":

                    sum = tavan(numberr1);
                    opt = "!";
                    break;

                case "baghi":

                    sum = numberr1 % numberr2;
                    opt = "%%";
                    break;

                case "AND":

                    int x1 = (int)numberr1;
                    int x2 = (int)numberr2;

                    sum = x1 & x2;



                    break;

            }



            label1.Text = sum + "";

            label2.Text += "=" + sum + "";

            historylabel.Text += numberr1 + "" + opt + numberr2 + "=" + sum + "\n";

            string content = historylabel.Text;
            File.WriteAllText(path, content);

            numberr1 = sum;



            optsum = 0;

            aval = true;

            this.ActiveControl = label1;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            if (windowsum % 2 == 0)
            {
                
                timer1.Enabled = true;

            }

            else
            {
                
                timer2.Enabled = true;

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
                Delete.ForeColor = Color.DimGray;


            }
            else
            {
                this.BackColor = Color.DimGray;
                backspace.BackColor = Color.DimGray;
                window.BackColor = Color.White;
                Delete.ForeColor = Color.Transparent;
            }
            cheksum++;

            this.ActiveControl = label1;
        }



        private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            label2.Show();

            if (e.KeyCode == Keys.NumPad1)
            {
                if (label1.Text == sum + "")
                {
                    label1.Text = "";


                }
                label2.Text += "1";
                label1.Text += "1";
                number(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad2)
            {
                if (label1.Text == sum + "")
                {

                    label1.Text = "";

                }
                label2.Text += "2";
                label1.Text += "2";

                number(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad0)
            {
                if (label1.Text == sum + "")
                {

                    label1.Text = "";

                }
                label2.Text += "0";
                label1.Text += "0";

                number(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad3)
            {
                if (label1.Text == sum + "")
                {

                    label1.Text = "";

                }
                label2.Text += "3";
                label1.Text += "3";

                number(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad4)
            {
                if (label1.Text == sum + "")
                {

                    label1.Text = "";

                }
                label1.Text += "4";
                label2.Text += "4";
                number(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad5)
            {
                if (label1.Text == sum + "")
                {

                    label1.Text = "";

                }
                label1.Text += "5";
                label2.Text += "5";
                number(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad6)
            {
                if (label1.Text == sum + "")
                {

                    label1.Text = "";

                }
                label1.Text += "6";
                label2.Text += "6";
                number(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad7)
            {
                if (label1.Text == sum + "")
                {

                    label1.Text = "";

                }
                label1.Text += "7";
                label2.Text += "7";
                number(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad8)
            {
                if (label1.Text == sum + "")
                {

                    label1.Text = "";

                }
                label2.Text += "8";
                label1.Text += "8";

                number(label1.Text);
            }

            else if (e.KeyCode == Keys.NumPad9)
            {
                if (label1.Text == sum + "")
                {

                    label1.Text = "";

                }
                label1.Text += "9";
                label2.Text += "9";
                number(label1.Text);
            }

            else if (e.KeyCode == Keys.Add)
            {



                if (koptsum == 0)
                {

                    if (kaval)
                    {
                        label2.Text = sum + "";
                    }

                    opt = "plus";

                    label2.Text += "+";
                    isfirstnumber = false;
                    label1.Text = "";


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


                    }

                    numberr1 = sum;

                    label1.Text = sum + "";
                    label2.Text = sum + "";

                    opt = "plus";
                    label2.Text += "+";
                    isfirstnumber = false;


                }

                koptsum++;

                this.ActiveControl = label1;
            }

            else if (e.KeyCode == Keys.Subtract)
            {


                if (optsum == 0)
                {

                    if (kaval)
                    {
                        label2.Text = sum + "";
                    }

                    opt = "menha";
                    label2.Text += "-";
                    isfirstnumber = false;
                    label1.Text = "";
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


                    }

                    numberr1 = sum;

                    label1.Text = sum + "";
                    label2.Text = sum + "";

                    opt = "menha";
                    label2.Text += "-";
                    isfirstnumber = false;



                }
                koptsum++;

                this.ActiveControl = label1;
            }

            else if (e.KeyCode == Keys.Multiply)
            {


                if (optsum == 0)
                {
                    if (kaval)
                    {
                        label2.Text = sum + "";
                    }

                    opt = "zarb";
                    label2.Text += "x";
                    isfirstnumber = false;
                    label1.Text = "";

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


                    }

                    numberr1 = sum;

                    label1.Text = sum + "";
                    label2.Text = sum + "";

                    opt = "zarb";
                    label2.Text += "x";
                    isfirstnumber = false;


                }
                koptsum++;

                this.ActiveControl = label1;
            }

            else if (e.KeyCode == Keys.Divide)
            {


                if (optsum == 0)
                {
                    if (kaval)
                    {
                        label2.Text = sum + "";
                    }

                    opt = "tagh";
                    label2.Text += "/";
                    isfirstnumber = false;
                    label1.Text = "";
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


                    }

                    numberr1 = sum;

                    label1.Text = sum + "";
                    label2.Text = sum + "";

                    opt = "tagh";
                    label2.Text += "/";
                    isfirstnumber = false;

                }

                koptsum++;

                this.ActiveControl = label1;

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


                }

                numberr1 = sum;

                label1.Text = sum + "";
                label2.Text += "=" + sum + "";

                isfirstnumber = false;

                koptsum = 0;

                kaval = true;

                this.ActiveControl = label1;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


            this.Hide();

            new Form2().ShowDialog();

            this.Close();


        }


        private void history_Click(object sender, EventArgs e)
        {
            if (Hlabelsum % 2 == 0)
            {
                historylabel.Show();
                Delete.Show();

            }
            else
            {
                historylabel.Hide();
                Delete.Hide();
            }
            Hlabelsum++;
            this.ActiveControl = label1;

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            historylabel.Text = "";

            string content = "";
            File.WriteAllText(path, content);

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (chek1sum % 2 == 0)
            {
                label3.Show();
                domainUpDown1.Show();
                domainUpDown2.Show();
                domainUpDown3.Show();


            }
            else
            {
                label3.Hide();
                domainUpDown1.Hide();
                domainUpDown2.Hide();
                domainUpDown3.Hide();
            }
            chek1sum++;

            this.ActiveControl = label1;

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.Text == "blue")
            {
                this.BackColor = Color.Blue;
            }

            else if (domainUpDown1.Text == "white")
            {
                this.BackColor = Color.White;
            }

            else if (domainUpDown1.Text == "black")
            {
                this.BackColor = Color.Black;
            }

            else if (domainUpDown1.Text == "green")
            {
                this.BackColor = Color.Green;
            }


        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

            if (domainUpDown2.Text == "Segoe UI Emoji")
            {
                label1.Font = new Font("Segoe UI Emoji", label1.Font.Size);
                label2.Font = new Font("Segoe UI Emoji", label2.Font.Size);
                number1.Font = new Font("Segoe UI Emoji", number1.Font.Size);
                number2.Font = new Font("Segoe UI Emoji", number2.Font.Size);
                number3.Font = new Font("Segoe UI Emoji", number3.Font.Size);
                number4.Font = new Font("Segoe UI Emoji", number4.Font.Size);
                number5.Font = new Font("Segoe UI Emoji", number5.Font.Size);
                number6.Font = new Font("Segoe UI Emoji", number6.Font.Size);
                number7.Font = new Font("Segoe UI Emoji", number7.Font.Size);
                number8.Font = new Font("Segoe UI Emoji", number8.Font.Size);
                number9.Font = new Font("Segoe UI Emoji", number9.Font.Size);




            }

            else if (domainUpDown2.Text == "Times New Roman")
            {
                label1.Font = new Font("Times New Roman", label1.Font.Size);
                label2.Font = new Font("STimes New Roman", label2.Font.Size);
                number1.Font = new Font("Times New Roman", number1.Font.Size);
                number2.Font = new Font("Times New Roman", number2.Font.Size);
                number3.Font = new Font("Times New Roman", number3.Font.Size);
                number4.Font = new Font("Times New Roman", number4.Font.Size);
                number5.Font = new Font("Times New Roman", number5.Font.Size);
                number6.Font = new Font("Times New Roman", number6.Font.Size);
                number7.Font = new Font("Times New Roman", number7.Font.Size);
                number8.Font = new Font("Times New Roman", number8.Font.Size);
                number9.Font = new Font("Times New Roman", number9.Font.Size);

            }

            else if (domainUpDown2.Text == "MV Boli")
            {
                label1.Font = new Font("MV Boli", label1.Font.Size);
                label2.Font = new Font("MV Boli", label2.Font.Size);
                number1.Font = new Font("MV Boli", number1.Font.Size);
                number2.Font = new Font("MV Boli", number2.Font.Size);
                number3.Font = new Font("MV Boli", number3.Font.Size);
                number4.Font = new Font("MV Boli", number4.Font.Size);
                number5.Font = new Font("MV Boli", number5.Font.Size);
                number6.Font = new Font("MV Boli", number6.Font.Size);
                number7.Font = new Font("MV Boli", number7.Font.Size);
                number8.Font = new Font("MV Boli", number8.Font.Size);
                number9.Font = new Font("MV Boli", number9.Font.Size);

            }

        }

        private void domainUpDown3_SelectedItemChanged(object sender, EventArgs e)
        {

            if (domainUpDown3.Text == "10")
            {

                label1.Font = new Font(number1.Font.FontFamily, 10);
                label2.Font = new Font(number1.Font.FontFamily, 10);
                number1.Font = new Font(number1.Font.FontFamily, 10);
                number2.Font = new Font(number1.Font.FontFamily, 10);
                number3.Font = new Font(number1.Font.FontFamily, 10);
                number4.Font = new Font(number1.Font.FontFamily, 10);
                number5.Font = new Font(number1.Font.FontFamily, 10);
                number6.Font = new Font(number1.Font.FontFamily, 10);
                number7.Font = new Font(number1.Font.FontFamily, 10);
                number8.Font = new Font(number1.Font.FontFamily, 10);
                number9.Font = new Font(number1.Font.FontFamily, 10);

            }

            else if (domainUpDown3.Text == "15")
            {
                label1.Font = new Font(number1.Font.FontFamily, 15);
                label2.Font = new Font(number1.Font.FontFamily, 15);
                number1.Font = new Font(number1.Font.FontFamily, 15);
                number2.Font = new Font(number1.Font.FontFamily, 15);
                number3.Font = new Font(number1.Font.FontFamily, 15);
                number4.Font = new Font(number1.Font.FontFamily, 15);
                number5.Font = new Font(number1.Font.FontFamily, 15);
                number6.Font = new Font(number1.Font.FontFamily, 15);
                number7.Font = new Font(number1.Font.FontFamily, 15);
                number8.Font = new Font(number1.Font.FontFamily, 15);
                number9.Font = new Font(number1.Font.FontFamily, 15);
            }

            else if (domainUpDown3.Text == "20")
            {
                label1.Font = new Font(number1.Font.FontFamily, 20);
                label2.Font = new Font(number1.Font.FontFamily, 20);
                number1.Font = new Font(number1.Font.FontFamily, 20);
                number2.Font = new Font(number1.Font.FontFamily, 20);
                number3.Font = new Font(number1.Font.FontFamily, 20);
                number4.Font = new Font(number1.Font.FontFamily, 20);
                number5.Font = new Font(number1.Font.FontFamily, 20);
                number6.Font = new Font(number1.Font.FontFamily, 20);
                number7.Font = new Font(number1.Font.FontFamily, 20);
                number8.Font = new Font(number1.Font.FontFamily, 20);
                number9.Font = new Font(number1.Font.FontFamily, 20);
            }

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

        private void facopt(object sender, EventArgs e)
        {
            sum = tavan(numberr1);
            label1.Text = sum + "";

            historylabel.Text += numberr1 + "" + "!" + "=" + sum + "\n";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            window.Location = new Point(window.Location.X + 4, window.Location.Y);
            checkBox1.Location = new Point(checkBox1.Location.X + 4, checkBox1.Location.Y);
            checkBox2.Location = new Point(checkBox2.Location.X + 4, checkBox2.Location.Y);
            checkBox3.Location = new Point(checkBox3.Location.X + 4, checkBox3.Location.Y);
            checkBox4.Location = new Point(checkBox4.Location.X + 4, checkBox4.Location.Y);
            checkBox5.Location = new Point(checkBox5.Location.X + 4, checkBox5.Location.Y);
            checkBox6.Location = new Point(checkBox6.Location.X + 4, checkBox6.Location.Y);

            if (window.Location.X >= -2)
            {
                timer1.Enabled = false;
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            window.Location = new Point(window.Location.X - 4, window.Location.Y);
            checkBox1.Location = new Point(checkBox1.Location.X - 4, checkBox1.Location.Y);
            checkBox2.Location = new Point(checkBox2.Location.X - 4, checkBox2.Location.Y);
            checkBox3.Location = new Point(checkBox3.Location.X - 4, checkBox3.Location.Y);
            checkBox4.Location = new Point(checkBox4.Location.X - 4, checkBox4.Location.Y);
            checkBox5.Location = new Point(checkBox5.Location.X - 4, checkBox5.Location.Y);
            checkBox6.Location = new Point(checkBox6.Location.X - 4, checkBox6.Location.Y);

            if (window.Location.X <= -199)
            {
                timer2.Enabled = false;
            }

        }
    }
}
