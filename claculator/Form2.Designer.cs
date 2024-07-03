namespace claculator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backspace = new Button();
            label1 = new Label();
            clear = new Button();
            button16 = new Button();
            button15 = new Button();
            button5 = new Button();
            Tavan = new Button();
            button13 = new Button();
            baghi = new Button();
            button12 = new Button();
            factor = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            number7 = new Button();
            number8 = new Button();
            number9 = new Button();
            number4 = new Button();
            number5 = new Button();
            number6 = new Button();
            number3 = new Button();
            number2 = new Button();
            number1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            BIN = new CheckBox();
            OCT = new CheckBox();
            DEC = new CheckBox();
            HEX = new CheckBox();
            BINlable = new Label();
            OCTlable = new Label();
            DEClable = new Label();
            label5 = new Label();
            BINlablle = new Label();
            OCTlablle = new Label();
            DEClablle = new Label();
            HEXlablle = new Label();
            button14 = new Button();
            OR = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            window = new Label();
            button18 = new Button();
            label2 = new Label();
            label3 = new Label();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            SuspendLayout();
            // 
            // backspace
            // 
            backspace.BackColor = Color.DimGray;
            backspace.FlatAppearance.BorderColor = Color.DimGray;
            backspace.FlatAppearance.BorderSize = 0;
            backspace.FlatStyle = FlatStyle.Flat;
            backspace.ForeColor = Color.DimGray;
            backspace.Location = new Point(303, 2);
            backspace.Name = "backspace";
            backspace.Size = new Size(298, 46);
            backspace.TabIndex = 49;
            backspace.UseVisualStyleBackColor = false;
            backspace.Click += button1_Click;
            // 
            // label1
            // 
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(303, 122);
            label1.Name = "label1";
            label1.Size = new Size(298, 47);
            label1.TabIndex = 48;
            label1.TextAlign = ContentAlignment.TopRight;
            label1.PreviewKeyDown += label1_PreviewKeyDown;
            // 
            // clear
            // 
            clear.BackColor = Color.DarkSeaGreen;
            clear.Cursor = Cursors.Hand;
            clear.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            clear.FlatAppearance.BorderSize = 0;
            clear.FlatStyle = FlatStyle.Flat;
            clear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = Color.White;
            clear.Location = new Point(424, 172);
            clear.Name = "clear";
            clear.Size = new Size(177, 53);
            clear.TabIndex = 47;
            clear.Text = "AC";
            clear.UseVisualStyleBackColor = false;
            clear.Click += button17_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.DarkSeaGreen;
            button16.Cursor = Cursors.Hand;
            button16.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button16.ForeColor = Color.White;
            button16.Location = new Point(303, 172);
            button16.Name = "button16";
            button16.Size = new Size(57, 53);
            button16.TabIndex = 46;
            button16.Tag = "-";
            button16.Text = "+/-";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.DarkSeaGreen;
            button15.Cursor = Cursors.Hand;
            button15.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.ForeColor = Color.White;
            button15.Location = new Point(363, 172);
            button15.Name = "button15";
            button15.Size = new Size(58, 53);
            button15.TabIndex = 45;
            button15.Tag = "dars";
            button15.Text = "%";
            button15.UseVisualStyleBackColor = false;
            button15.Click += handelopt;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(544, 396);
            button5.Name = "button5";
            button5.Size = new Size(57, 52);
            button5.TabIndex = 44;
            button5.Text = "=";
            button5.UseVisualStyleBackColor = false;
            button5.Click += mosavi;
            // 
            // Tavan
            // 
            Tavan.BackColor = Color.FromArgb(255, 128, 0);
            Tavan.Cursor = Cursors.Hand;
            Tavan.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Tavan.FlatAppearance.BorderSize = 0;
            Tavan.FlatStyle = FlatStyle.Flat;
            Tavan.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tavan.ForeColor = Color.White;
            Tavan.Location = new Point(484, 397);
            Tavan.Name = "Tavan";
            Tavan.Size = new Size(57, 52);
            Tavan.TabIndex = 43;
            Tavan.Tag = "Tavan";
            Tavan.Text = "x²";
            Tavan.UseVisualStyleBackColor = false;
            Tavan.Click += handelopt;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(255, 128, 0);
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.Location = new Point(544, 341);
            button13.Name = "button13";
            button13.Size = new Size(57, 52);
            button13.TabIndex = 41;
            button13.Tag = "plus";
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += handelopt;
            // 
            // baghi
            // 
            baghi.BackColor = Color.FromArgb(255, 128, 0);
            baghi.Cursor = Cursors.Hand;
            baghi.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            baghi.FlatAppearance.BorderSize = 0;
            baghi.FlatStyle = FlatStyle.Flat;
            baghi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            baghi.ForeColor = Color.White;
            baghi.Location = new Point(544, 229);
            baghi.Name = "baghi";
            baghi.Size = new Size(57, 52);
            baghi.TabIndex = 38;
            baghi.Tag = "baghi";
            baghi.Text = "%%";
            baghi.UseVisualStyleBackColor = false;
            baghi.Click += handelopt;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(255, 128, 0);
            button12.Cursor = Cursors.Hand;
            button12.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.White;
            button12.Location = new Point(484, 341);
            button12.Name = "button12";
            button12.Size = new Size(57, 52);
            button12.TabIndex = 40;
            button12.Tag = "menha";
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += handelopt;
            // 
            // factor
            // 
            factor.BackColor = Color.FromArgb(255, 128, 0);
            factor.Cursor = Cursors.Hand;
            factor.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            factor.FlatAppearance.BorderSize = 0;
            factor.FlatStyle = FlatStyle.Flat;
            factor.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            factor.ForeColor = Color.White;
            factor.Location = new Point(484, 229);
            factor.Name = "factor";
            factor.Size = new Size(57, 52);
            factor.TabIndex = 36;
            factor.Tag = "fac";
            factor.Text = "!";
            factor.UseVisualStyleBackColor = false;
            factor.Click += handelopt;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 128, 0);
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Location = new Point(544, 285);
            button11.Name = "button11";
            button11.Size = new Size(57, 52);
            button11.TabIndex = 37;
            button11.Tag = "zarb";
            button11.Text = "×";
            button11.UseVisualStyleBackColor = false;
            button11.Click += handelopt;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(255, 128, 0);
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(484, 285);
            button10.Name = "button10";
            button10.Size = new Size(57, 52);
            button10.TabIndex = 35;
            button10.Tag = "tagh";
            button10.Text = "÷";
            button10.UseVisualStyleBackColor = false;
            button10.Click += handelopt;
            // 
            // button9
            // 
            button9.BackColor = Color.RosyBrown;
            button9.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(424, 397);
            button9.Name = "button9";
            button9.Size = new Size(57, 52);
            button9.TabIndex = 34;
            button9.Text = "/";
            button9.UseVisualStyleBackColor = false;
            button9.Click += clik;
            // 
            // button8
            // 
            button8.BackColor = Color.RosyBrown;
            button8.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(303, 397);
            button8.Name = "button8";
            button8.Size = new Size(118, 52);
            button8.TabIndex = 33;
            button8.Text = "0";
            button8.UseVisualStyleBackColor = false;
            button8.Click += clik;
            // 
            // number7
            // 
            number7.BackColor = Color.RosyBrown;
            number7.BackgroundImageLayout = ImageLayout.None;
            number7.Cursor = Cursors.Hand;
            number7.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            number7.FlatAppearance.BorderSize = 0;
            number7.FlatStyle = FlatStyle.Flat;
            number7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            number7.ForeColor = Color.White;
            number7.Location = new Point(303, 229);
            number7.Name = "number7";
            number7.Size = new Size(57, 53);
            number7.TabIndex = 32;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = false;
            number7.Click += clik;
            // 
            // number8
            // 
            number8.BackColor = Color.RosyBrown;
            number8.BackgroundImageLayout = ImageLayout.None;
            number8.Cursor = Cursors.Hand;
            number8.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            number8.FlatAppearance.BorderSize = 0;
            number8.FlatStyle = FlatStyle.Flat;
            number8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            number8.ForeColor = Color.White;
            number8.Location = new Point(363, 229);
            number8.Name = "number8";
            number8.Size = new Size(57, 53);
            number8.TabIndex = 31;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = false;
            number8.Click += clik;
            // 
            // number9
            // 
            number9.BackColor = Color.RosyBrown;
            number9.BackgroundImageLayout = ImageLayout.None;
            number9.Cursor = Cursors.Hand;
            number9.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            number9.FlatAppearance.BorderSize = 0;
            number9.FlatStyle = FlatStyle.Flat;
            number9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number9.ForeColor = Color.White;
            number9.Location = new Point(423, 229);
            number9.Name = "number9";
            number9.Size = new Size(58, 53);
            number9.TabIndex = 30;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = false;
            number9.Click += clik;
            // 
            // number4
            // 
            number4.BackColor = Color.RosyBrown;
            number4.BackgroundImageLayout = ImageLayout.None;
            number4.Cursor = Cursors.Hand;
            number4.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            number4.FlatAppearance.BorderSize = 0;
            number4.FlatStyle = FlatStyle.Flat;
            number4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            number4.ForeColor = Color.White;
            number4.Location = new Point(303, 286);
            number4.Name = "number4";
            number4.Size = new Size(57, 52);
            number4.TabIndex = 29;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = false;
            number4.Click += clik;
            // 
            // number5
            // 
            number5.BackColor = Color.RosyBrown;
            number5.BackgroundImageLayout = ImageLayout.None;
            number5.Cursor = Cursors.Hand;
            number5.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            number5.FlatAppearance.BorderSize = 0;
            number5.FlatStyle = FlatStyle.Flat;
            number5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            number5.ForeColor = Color.White;
            number5.Location = new Point(363, 286);
            number5.Name = "number5";
            number5.Size = new Size(57, 52);
            number5.TabIndex = 28;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = false;
            number5.Click += clik;
            // 
            // number6
            // 
            number6.BackColor = Color.RosyBrown;
            number6.BackgroundImageLayout = ImageLayout.None;
            number6.Cursor = Cursors.Hand;
            number6.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            number6.FlatAppearance.BorderSize = 0;
            number6.FlatStyle = FlatStyle.Flat;
            number6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            number6.ForeColor = Color.White;
            number6.Location = new Point(423, 286);
            number6.Name = "number6";
            number6.Size = new Size(57, 52);
            number6.TabIndex = 27;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = false;
            number6.Click += clik;
            // 
            // number3
            // 
            number3.BackColor = Color.RosyBrown;
            number3.BackgroundImageLayout = ImageLayout.None;
            number3.Cursor = Cursors.Hand;
            number3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            number3.FlatAppearance.BorderSize = 0;
            number3.FlatStyle = FlatStyle.Flat;
            number3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            number3.ForeColor = Color.White;
            number3.Location = new Point(423, 341);
            number3.Name = "number3";
            number3.Size = new Size(57, 52);
            number3.TabIndex = 26;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = false;
            number3.Click += clik;
            // 
            // number2
            // 
            number2.BackColor = Color.RosyBrown;
            number2.BackgroundImageLayout = ImageLayout.None;
            number2.Cursor = Cursors.Hand;
            number2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            number2.FlatAppearance.BorderSize = 0;
            number2.FlatStyle = FlatStyle.Flat;
            number2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            number2.ForeColor = Color.White;
            number2.Location = new Point(363, 342);
            number2.Name = "number2";
            number2.Size = new Size(57, 52);
            number2.TabIndex = 25;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = false;
            number2.Click += clik;
            // 
            // number1
            // 
            number1.BackColor = Color.RosyBrown;
            number1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            number1.FlatAppearance.BorderSize = 0;
            number1.FlatStyle = FlatStyle.Flat;
            number1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            number1.ForeColor = Color.White;
            number1.Location = new Point(303, 342);
            number1.Name = "number1";
            number1.Size = new Size(57, 52);
            number1.TabIndex = 24;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = false;
            number1.Click += clik;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(183, 229);
            button1.Name = "button1";
            button1.Size = new Size(57, 70);
            button1.TabIndex = 24;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = false;
            button1.Click += clik;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(183, 381);
            button2.Name = "button2";
            button2.Size = new Size(57, 68);
            button2.TabIndex = 25;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = false;
            button2.Click += clik;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(243, 381);
            button3.Name = "button3";
            button3.Size = new Size(57, 68);
            button3.TabIndex = 26;
            button3.Text = "A";
            button3.UseVisualStyleBackColor = false;
            button3.Click += clik;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumTurquoise;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(243, 303);
            button4.Name = "button4";
            button4.Size = new Size(57, 75);
            button4.TabIndex = 27;
            button4.Text = "D";
            button4.UseVisualStyleBackColor = false;
            button4.Click += clik;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumTurquoise;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(183, 303);
            button6.Name = "button6";
            button6.Size = new Size(57, 75);
            button6.TabIndex = 28;
            button6.Text = "E";
            button6.UseVisualStyleBackColor = false;
            button6.Click += clik;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumTurquoise;
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(243, 229);
            button7.Name = "button7";
            button7.Size = new Size(57, 70);
            button7.TabIndex = 29;
            button7.Text = "F";
            button7.UseVisualStyleBackColor = false;
            button7.Click += clik;
            // 
            // BIN
            // 
            BIN.AutoSize = true;
            BIN.Location = new Point(25, 424);
            BIN.Name = "BIN";
            BIN.Size = new Size(55, 24);
            BIN.TabIndex = 50;
            BIN.Text = "BIN";
            BIN.UseVisualStyleBackColor = true;
            BIN.CheckedChanged += Bin;
            // 
            // OCT
            // 
            OCT.AutoSize = true;
            OCT.Location = new Point(25, 398);
            OCT.Name = "OCT";
            OCT.Size = new Size(59, 24);
            OCT.TabIndex = 51;
            OCT.Text = "OCT";
            OCT.UseVisualStyleBackColor = true;
            OCT.CheckedChanged += Oct;
            // 
            // DEC
            // 
            DEC.AutoSize = true;
            DEC.Location = new Point(25, 370);
            DEC.Name = "DEC";
            DEC.Size = new Size(59, 24);
            DEC.TabIndex = 52;
            DEC.Text = "DEC";
            DEC.UseVisualStyleBackColor = true;
            DEC.CheckedChanged += Dec;
            // 
            // HEX
            // 
            HEX.AutoSize = true;
            HEX.Location = new Point(25, 341);
            HEX.Name = "HEX";
            HEX.Size = new Size(59, 24);
            HEX.TabIndex = 53;
            HEX.Text = "HEX";
            HEX.UseVisualStyleBackColor = true;
            HEX.CheckedChanged += Hex;
            // 
            // BINlable
            // 
            BINlable.Location = new Point(25, 148);
            BINlable.Name = "BINlable";
            BINlable.Size = new Size(47, 25);
            BINlable.TabIndex = 54;
            BINlable.Text = "BIN  :";
            // 
            // OCTlable
            // 
            OCTlable.Location = new Point(25, 121);
            OCTlable.Name = "OCTlable";
            OCTlable.Size = new Size(47, 25);
            OCTlable.TabIndex = 54;
            OCTlable.Text = "OCT :";
            // 
            // DEClable
            // 
            DEClable.Location = new Point(25, 96);
            DEClable.Name = "DEClable";
            DEClable.Size = new Size(47, 25);
            DEClable.TabIndex = 54;
            DEClable.Text = "DEC :";
            // 
            // label5
            // 
            label5.Location = new Point(25, 71);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 54;
            label5.Text = "HEX :";
            // 
            // BINlablle
            // 
            BINlablle.BackColor = Color.DimGray;
            BINlablle.ForeColor = Color.White;
            BINlablle.Location = new Point(78, 146);
            BINlablle.Name = "BINlablle";
            BINlablle.Size = new Size(177, 23);
            BINlablle.TabIndex = 55;
            BINlablle.Text = " ";
            // 
            // OCTlablle
            // 
            OCTlablle.BackColor = Color.DimGray;
            OCTlablle.ForeColor = Color.White;
            OCTlablle.Location = new Point(78, 121);
            OCTlablle.Name = "OCTlablle";
            OCTlablle.Size = new Size(177, 23);
            OCTlablle.TabIndex = 55;
            OCTlablle.Text = " ";
            // 
            // DEClablle
            // 
            DEClablle.BackColor = Color.DimGray;
            DEClablle.ForeColor = Color.White;
            DEClablle.Location = new Point(78, 94);
            DEClablle.Name = "DEClablle";
            DEClablle.Size = new Size(177, 25);
            DEClablle.TabIndex = 55;
            DEClablle.Text = " ";
            // 
            // HEXlablle
            // 
            HEXlablle.BackColor = Color.DimGray;
            HEXlablle.ForeColor = Color.White;
            HEXlablle.Location = new Point(78, 67);
            HEXlablle.Name = "HEXlablle";
            HEXlablle.Size = new Size(177, 25);
            HEXlablle.TabIndex = 55;
            HEXlablle.Text = " ";
            // 
            // button14
            // 
            button14.BackColor = Color.DarkSeaGreen;
            button14.Cursor = Cursors.Hand;
            button14.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.White;
            button14.Location = new Point(243, 172);
            button14.Name = "button14";
            button14.Size = new Size(57, 53);
            button14.TabIndex = 45;
            button14.Tag = "AND";
            button14.Text = "&&";
            button14.UseVisualStyleBackColor = false;
            button14.Click += handelopt;
            // 
            // OR
            // 
            OR.BackColor = Color.DarkSeaGreen;
            OR.Cursor = Cursors.Hand;
            OR.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            OR.FlatAppearance.BorderSize = 0;
            OR.FlatStyle = FlatStyle.Flat;
            OR.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OR.ForeColor = Color.White;
            OR.Location = new Point(183, 172);
            OR.Name = "OR";
            OR.Size = new Size(57, 53);
            OR.TabIndex = 45;
            OR.Tag = "dars";
            OR.Text = "|";
            OR.UseVisualStyleBackColor = false;
            OR.Click += handelopt;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Black;
            checkBox2.FlatAppearance.BorderSize = 0;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.ForeColor = SystemColors.ButtonHighlight;
            checkBox2.Location = new Point(40, 87);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 24);
            checkBox2.TabIndex = 58;
            checkBox2.Text = "Standard";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Black;
            checkBox1.FlatAppearance.BorderSize = 0;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(40, 57);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 24);
            checkBox1.TabIndex = 59;
            checkBox1.Text = "darkmood";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // window
            // 
            window.BackColor = Color.WhiteSmoke;
            window.ForeColor = SystemColors.ActiveCaptionText;
            window.Location = new Point(25, 37);
            window.Name = "window";
            window.Size = new Size(192, 267);
            window.TabIndex = 57;
            // 
            // button18
            // 
            button18.BackColor = Color.Transparent;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.ForeColor = Color.Transparent;
            button18.Location = new Point(-1, 8);
            button18.Name = "button18";
            button18.Size = new Size(28, 29);
            button18.TabIndex = 56;
            button18.Text = "=";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(5, 2);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 60;
            // 
            // label3
            // 
            label3.Cursor = Cursors.IBeam;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(303, 59);
            label3.Name = "label3";
            label3.Size = new Size(298, 47);
            label3.TabIndex = 48;
            label3.TextAlign = ContentAlignment.TopRight;
            label3.PreviewKeyDown += label1_PreviewKeyDown;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = Color.Black;
            checkBox6.FlatAppearance.BorderSize = 0;
            checkBox6.FlatStyle = FlatStyle.Flat;
            checkBox6.ForeColor = SystemColors.ButtonHighlight;
            checkBox6.Location = new Point(40, 180);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(54, 24);
            checkBox6.TabIndex = 66;
            checkBox6.Text = "tool";
            checkBox6.UseVisualStyleBackColor = false;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Black;
            checkBox5.FlatAppearance.BorderSize = 0;
            checkBox5.FlatStyle = FlatStyle.Flat;
            checkBox5.ForeColor = SystemColors.ButtonHighlight;
            checkBox5.Location = new Point(40, 152);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(82, 24);
            checkBox5.TabIndex = 67;
            checkBox5.Text = "currency";
            checkBox5.UseVisualStyleBackColor = false;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Black;
            checkBox4.FlatAppearance.BorderSize = 0;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.ForeColor = SystemColors.ButtonHighlight;
            checkBox4.Location = new Point(40, 119);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 24);
            checkBox4.TabIndex = 68;
            checkBox4.Text = "weight";
            checkBox4.UseVisualStyleBackColor = false;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DimGray;
            ClientSize = new Size(600, 443);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(window);
            Controls.Add(button18);
            Controls.Add(HEXlablle);
            Controls.Add(DEClablle);
            Controls.Add(OCTlablle);
            Controls.Add(BINlablle);
            Controls.Add(label5);
            Controls.Add(DEClable);
            Controls.Add(OCTlable);
            Controls.Add(BINlable);
            Controls.Add(HEX);
            Controls.Add(DEC);
            Controls.Add(OCT);
            Controls.Add(BIN);
            Controls.Add(backspace);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(clear);
            Controls.Add(button16);
            Controls.Add(OR);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button5);
            Controls.Add(Tavan);
            Controls.Add(button13);
            Controls.Add(baghi);
            Controls.Add(button12);
            Controls.Add(factor);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(number7);
            Controls.Add(number8);
            Controls.Add(number9);
            Controls.Add(button7);
            Controls.Add(number4);
            Controls.Add(button6);
            Controls.Add(number5);
            Controls.Add(button4);
            Controls.Add(number6);
            Controls.Add(button3);
            Controls.Add(number3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backspace;
        private Label label1;
        private Button clear;
        private Button button16;
        private Button button15;
        private Button button5;
        private Button Tavan;
        private Button button13;
        private Button baghi;
        private Button button12;
        private Button factor;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button number7;
        private Button number8;
        private Button number9;
        private Button number4;
        private Button number5;
        private Button number6;
        private Button number3;
        private Button number2;
        private Button number1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private CheckBox BIN;
        private CheckBox OCT;
        private CheckBox DEC;
        private CheckBox HEX;
        private Label BINlable;
        private Label OCTlable;
        private Label DEClable;
        private Label label5;
        private Label BINlablle;
        private Label OCTlablle;
        private Label DEClablle;
        private Label HEXlablle;
        private Button button14;
        private Button OR;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label window;
        private Button button18;
        private Label label2;
        private Label label3;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
    }
}