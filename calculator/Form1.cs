using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{



    public partial class Form1 : Form
    {
        My my = new My();
        string[] str = new string[2];
        double chuslo1 = 0;
        double chuslo2 = 0;
        int i = 0;
        int z = 0;
        int s = 0;
        int s1 = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = str[i];
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if ((str[0] == "") || (str[1] == "")) { }
            else if (str[1] == "0")
            {
                i = 0;
                str[i] = "Inf";
                textBox1.Text = str[i];
                str[1] = "";
            }
            else 
                try
                {
                    if (radioButton1.Checked == true) s1 = 1;
                    if (radioButton2.Checked == true) s1 = 2;
                    if (radioButton3.Checked == true) s1 = 3;
                    if (radioButton4.Checked == true) s1 = 4;
                    if (s == 1) { chuslo1 = my._16_10_(str[0]); }
                    if (s == 2) { chuslo1 = Convert.ToDouble(str[0]); }
                    if (s == 3) { chuslo1 = my._8_10_(str[0]); }
                    if (s == 4) { chuslo1 = my._2_10_(str[0]); }
                    if (s1 == 1) { chuslo2 = my._16_10_(str[1]); }
                    if (s1 == 2) { chuslo2 = Convert.ToDouble(str[1]); }
                    if (s1 == 3) { chuslo2 = my._8_10_(str[1]); }
                    if (s1 == 4) { chuslo2 = my._2_10_(str[1]); }
                    i = 0;
                    if (z == 1) { str[i] = Convert.ToString(chuslo1 + chuslo2); }
                    if (z == 2) { str[i] = Convert.ToString(chuslo1 - chuslo2); }
                    if (z == 3) { str[i] = Convert.ToString(chuslo1 * chuslo2); }
                    if (z == 4) { str[i] = Convert.ToString(chuslo1 / chuslo2); }
                    if (radioButton1.Checked == true) str[i] = Convert.ToString(my._10_16_(str[i]));
                    if (radioButton3.Checked == true) str[i] = Convert.ToString(my._10_8_(str[i]));
                    if (radioButton4.Checked == true) str[i] = Convert.ToString(my._10_2_(str[i]));
                    textBox1.Text = str[i];
                    str[1] = "";
                }
                catch { }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str[i] = str[i] + 1;
            textBox1.Text = str[i];
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) { } else
            {
                str[i] = str[i] + 2;
                textBox1.Text = str[i];
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) { }
            else
            {
                str[i] = str[i] + 3;
                textBox1.Text = str[i];
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) { }
            else
            {
                str[i] = str[i] + 4;
                textBox1.Text = str[i];
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) { }
            else
            {
                str[i] = str[i] + 5;
                textBox1.Text = str[i];
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) { }
            else
            {
                str[i] = str[i] + 6;
                textBox1.Text = str[i];
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) { }
            else
            {
                str[i] = str[i] + 7;
                textBox1.Text = str[i];
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true)||(radioButton3.Checked == true)) { }
            else
            {
                str[i] = str[i] + 8;
                textBox1.Text = str[i];
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true) || (radioButton3.Checked == true)) { }
            else
            {
                str[i] = str[i] + 9;
                textBox1.Text = str[i];
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true) || (radioButton3.Checked == true) || (radioButton2.Checked == true)) { }
            else
            {
                str[i] = str[i] + 'A';
                textBox1.Text = str[i];
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true) || (radioButton3.Checked == true) || (radioButton2.Checked == true)) { }
            else
            {
                str[i] = str[i] + 'B';
                textBox1.Text = str[i];
            }
            
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true) || (radioButton3.Checked == true) || (radioButton2.Checked == true)) { }
            else
            {
                str[i] = str[i] + 'C';
                textBox1.Text = str[i];
            }
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true) || (radioButton3.Checked == true) || (radioButton2.Checked == true)) { }
            else
            {
                str[i] = str[i] + 'D';
                textBox1.Text = str[i];
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true) || (radioButton3.Checked == true) || (radioButton2.Checked == true)) { }
            else
            {
                str[i] = str[i] + 'E';
                textBox1.Text = str[i];
            }
            
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if ((radioButton4.Checked == true) || (radioButton3.Checked == true) || (radioButton2.Checked == true)) { }
            else
            {
                str[i] = str[i] + 'F';
                textBox1.Text = str[i];
            }
            
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            str[i] = str[i] + 0;
            textBox1.Text = str[i];
            
        }


        private void button17_Click(object sender, EventArgs e)
        {
            str[0] = "";
            str[1] = "";
            textBox1.Text = str[i];
            i = 0;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int j = 0; j < str[i].Length-1; j++)
            {
                s = s + str[i][j];
            }
            str[i] = s;
            textBox1.Text = str[i];
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            i = 1;
            z = 1;
            if (radioButton1.Checked == true) s = 1;
            if (radioButton2.Checked == true) s = 2;
            if (radioButton3.Checked == true) s = 3;
            if (radioButton4.Checked == true) s = 4;
            str[i] = "";
            textBox1.Text = str[i];
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            i = 1;
            z = 2;
            if (radioButton1.Checked == true) s = 1;
            if (radioButton2.Checked == true) s = 2;
            if (radioButton3.Checked == true) s = 3;
            if (radioButton4.Checked == true) s = 4;
            str[i] = "";
            textBox1.Text = str[i];
            
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            i = 1;
            z = 3;
            if (radioButton1.Checked == true) s = 1;
            if (radioButton2.Checked == true) s = 2;
            if (radioButton3.Checked == true) s = 3;
            if (radioButton4.Checked == true) s = 4;
            str[i] = "";
            textBox1.Text = str[i];
           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            i = 1;
            z = 4;
            if (radioButton1.Checked == true) s = 1;
            if (radioButton2.Checked == true) s = 2;
            if (radioButton3.Checked == true) s = 3;
            if (radioButton4.Checked == true) s = 4;
            str[i] = "";
            textBox1.Text = str[i];
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < str[i].Length; j++)
            {
                if (str[i][j] == ',') return;
            }
            if (str[i] != "")
            {
                str[i] = str[i] + ',';
                textBox1.Text = str[i];
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true) str[i] = Convert.ToString(my._10_16_(str[i]));
                if (radioButton3.Checked == true) str[i] = Convert.ToString(my._10_8_(str[i]));
                if (radioButton4.Checked == true) str[i] = Convert.ToString(my._10_2_(str[i]));
                textBox1.Text = str[i];
            }
            catch { }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton2.Checked == true) str[i] = Convert.ToString(my._16_10_(str[i]));
                if (radioButton3.Checked == true) { str[i] = Convert.ToString(my._16_10_(str[i])); str[i] = Convert.ToString(my._10_8_(str[i])); }
                if (radioButton4.Checked == true) { str[i] = Convert.ToString(my._16_10_(str[i])); str[i] = Convert.ToString(my._10_2_(str[i])); }
                textBox1.Text = str[i];
            }
            catch { }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true) { str[i] = Convert.ToString(my._8_10_(str[i])); str[i] = Convert.ToString(my._10_16_(str[i])); }
                if (radioButton2.Checked == true) { str[i] = Convert.ToString(my._8_10_(str[i])); }
                if (radioButton4.Checked == true) { str[i] = Convert.ToString(my._8_10_(str[i])); str[i] = Convert.ToString(my._10_2_(str[i])); }
                textBox1.Text = str[i];
            }
            catch { }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true) { str[i] = Convert.ToString(my._2_10_(str[i])); str[i] = Convert.ToString(my._10_16_(str[i])); }
                if (radioButton2.Checked == true) { str[i] = Convert.ToString(my._2_10_(str[i])); }
                if (radioButton3.Checked == true) { str[i] = Convert.ToString(my._2_10_(str[i])); str[i] = Convert.ToString(my._10_8_(str[i])); }
                textBox1.Text = str[i];
            }
            catch { }
        }
    }
    public class My
    {
        

        public double _16_10_(string a)       
        {
            if (a == "0") return 0;
            string a1 = ""; string a2 = "";
            double b1 = 0;
            double b2 = 0;
            double b = 0;
            double l = 0;
            int k = 0;
            for (k = 0; k < a.Length; k++)
            {
                if (a[k] == ',')
                {
                    break;
                }
                else
                    a1 = a1 + a[k];
            }
            for (int k1 = k + 1; k1 < a.Length; k1++)
            {
                a2 = a2 + a[k1];
            }
            for (k = a1.Length - 1; k >= 0; k--)
            {
                if (a1[a1.Length - k - 1].ToString() == "A") l = 10; else 
                if (a1[a1.Length - k - 1].ToString() == "B") l = 11; else 
                if (a1[a1.Length - k - 1].ToString() == "C") l = 12; else
                if (a1[a1.Length - k - 1].ToString() == "D") l = 13; else 
                if (a1[a1.Length - k - 1].ToString() == "E") l = 14; else
                if (a1[a1.Length - k - 1].ToString() == "F") l = 15; else
                l = Convert.ToDouble(a1[a1.Length - k - 1].ToString());
                b1 = b1 + l * Math.Pow(16, k);
            }
            for (k = 1; k <= a2.Length; k++)
            {
                if (a2[k - 1].ToString() == "A") l = 10;
                else
                    if (a2[k - 1].ToString() == "B") l = 11;
                    else
                        if (a2[k - 1].ToString() == "C") l = 12;
                        else
                            if (a2[k - 1].ToString() == "D") l = 13;
                            else
                                if (a2[k - 1].ToString() == "E") l = 14;
                                else
                                    if (a2[k - 1].ToString() == "F") l = 15;
                                    else
                l = Convert.ToDouble(a2[k - 1].ToString());
                b2 = b2 + l * Math.Pow(16, -k);
            }
            b = b1 + b2;
            return b;
        }
        public double _8_10_(string a)
        {
            if (a == "0") return 0;
            string a1 = ""; string a2 = "";
            double b1 = 0;
            double b2 = 0;
            double b = 0;
            double l = 0;
            int k = 0;
            for (k = 0; k < a.Length; k++)
            {
                if (a[k] == ',')
                {
                    break;
                }
                else
                    a1 = a1 + a[k];
            }
            for (int k1 = k + 1; k1 < a.Length; k1++)
            {
                a2 = a2 + a[k1];
            }
            for (k = a1.Length - 1; k >= 0; k--)
            {
                l = Convert.ToDouble(a1[a1.Length - k - 1].ToString());
                b1 = b1 + l * Math.Pow(8, k);
            }
            for (k = 1; k <= a2.Length; k++)
            {
                l = Convert.ToDouble(a2[k - 1].ToString());
                b2 = b2 + l * Math.Pow(8, -k);
            }
            b = b1 + b2;
            return b;
        }
        public double _2_10_(string a)
        {
            if (a == "0") return 0;
            string a1 = ""; string a2 = "";
            double b1 = 0;
            double b2 = 0;
            double b = 0;
            double l = 0;
            int k = 0;
            for (k = 0; k < a.Length; k++)
            {
                if (a[k] == ',')
                {
                    break;
                }
                else
                    a1 = a1 + a[k];
            }
            for (int k1 = k + 1; k1 < a.Length; k1++)
            {
                a2 = a2 + a[k1];
            }
            for (k = a1.Length - 1; k >= 0; k--)
            {
                l = Convert.ToDouble(a1[a1.Length - k - 1].ToString());
                b1 = b1 + l * Math.Pow(2, k);
            }
            for (k = 1; k <= a2.Length; k++)
            {
                l = Convert.ToDouble(a2[k - 1].ToString());
                b2 = b2 + l * Math.Pow(2, -k);
            }
            b = b1 + b2;
            return b;
        }
        public string _10_16_(string a)     
        {
            if (a == "0") return "0";
            string a1 = ""; string a2 = "";
            string s="";
            double b = 0;
            int b1 = 0;
            int p = 0;
            double b2 = 0;
            b = Convert.ToDouble(a);
            b2 = b % 1;
            Console.WriteLine(b2);
            b1 = (int)(b - b2);
            Console.WriteLine(b1);
            for (; ; )
            {
                if (b1 < 1) break;
                if (b1 % 16 < 10) s = Convert.ToString(b1 % 16);
                if (b1 % 16 == 10) s = "A";
                if (b1 % 16 == 11) s = "B";
                if (b1 % 16 == 12) s = "C";
                if (b1 % 16 == 13) s = "D";
                if (b1 % 16 == 14) s = "E";
                if (b1 % 16 == 15) s = "F";
                a1 = s + a1;
                b1 = (int)(b1 / 16);
            }
            Console.WriteLine(a1);
            if (b2 != 0)
            {
                for (; ; )
                {
                    if ((b2 == 1) || (p == 10)) break;
                    b2 = b2 - (int)(b2);
                    b2 = (b2 * 16);
                    if ((int)(b2) < 10) s = Convert.ToString((int)(b2));
                    if ((int)(b2) == 10) s = "A";
                    if ((int)(b2) == 11) s = "B";
                    if ((int)(b2) == 12) s = "C";
                    if ((int)(b2) == 13) s = "D";
                    if ((int)(b2) == 14) s = "E";
                    if ((int)(b2) == 15) s = "F";
                    a2 = a2 + s;
                    p++;
                }
                Console.WriteLine(a2);
            }
            if (a1 == "") a1 = "0";
            if (a2 == "") { a = a1; } else { a = a1 + ',' + a2; }
            //b = Convert.ToDouble(a);
            return a;

        }
        public double _10_8_(string a)     
        {
            if (a == "0") return 0;
            string a1 = ""; string a2 = "";
            double b = 0;
            int b1 = 0;
            int p = 0;
            double b2 = 0;
            b = Convert.ToDouble(a);
            b2 = b % 1;
            Console.WriteLine(b2);
            b1 = (int)(b - b2);
            Console.WriteLine(b1);
            for (; ; )
            {
                if (b1 < 1) break;
                a1 = Convert.ToString(b1 % 8) + a1;
                b1 = (int)(b1 / 8);
            }
            Console.WriteLine(a1);
            if (b2 != 0)                              
            {
                for (; ; )
                {
                    if ((b2 == 1)|| (p==10)) break;
                    b2 = b2 - (int)(b2);
                    b2 = (b2 * 8);
                    a2 = a2 + Convert.ToString((int)(b2));
                    p++;
                }
                Console.WriteLine(a2);
            }
            if (a2 == "") { a = a1; } else { a = a1 + ',' + a2; }
            b = Convert.ToDouble(a);
            return b;
        }
        public double _10_2_(string a)
        {
            if (a == "0") return 0;
            string a1 = ""; string a2 = "";
            double b = 0;
            int b1 = 0;
            double b2 = 0;
            b = Convert.ToDouble(a);
            b2 = b % 1;
            Console.WriteLine(b2);
            b1 = (int)(b - b2);
            Console.WriteLine(b1);
            for (; ; )
            {
                if (b1 < 1) break;
                a1 = Convert.ToString(b1 % 2) + a1;
                b1 = (int)(b1 / 2);
            }
            Console.WriteLine(a1);
            if (b2 != 0)
            {
                for (; ; )
                {
                    if (b2 == 1) break;
                    b2 = b2 - (int)(b2);
                    b2 = (b2 * 2);
                    a2 = a2 + Convert.ToString((int)(b2));
                }
                Console.WriteLine(a2);
            }
            if (b2 == 0) { a = a1; } else { a = a1 + ',' + a2; }
            b = Convert.ToDouble(a);
            return b;
        }

    }
}
