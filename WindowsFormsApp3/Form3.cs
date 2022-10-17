using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public string[] ticket = new string[8];
        public Form3(string[] date)
        {
            for(int i=0 ; i<= 2 ; i++)
            {
                ticket[i] = date[i];
            }
            InitializeComponent();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            button8.Enabled = false;
        }
        int num = 0, num1 = 0, num2 = 0, num3 = 0, sum =0;
        int price1 = 200, price2 = 230, price3 = 270, price4 = 10, price5 = 15, price6 = 18;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                ticket[3] = "信用卡";
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                label1.Text = "學生票     "+ price1.ToString() +"元";
                label2.Text = "教職員票   "+ price2.ToString() +"元";
                label3.Text = "一般票     "+ price3.ToString() +"元";
                label6.Text = "0";
                label7.Text = "元";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ticket[3] = "學生紅利點數";
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                label1.Text = "學生票     "+ price4.ToString() +"點";
                label2.Text = "教職員票   "+ price5.ToString() +"點";
                label3.Text = "一般票     "+ price6.ToString() +"點";
                label6.Text = "0";
                label7.Text = "點";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1--;
            textBox1.Text = num1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num2--;
            textBox2.Text = num2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num3--;
            textBox3.Text = num3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1++;
            textBox1.Text = num1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num2++;
            textBox2.Text = num2.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num3++;
            textBox3.Text = num3.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sum = num1 + num2 + num3;
            if (sum >= 5)
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                num1 = 5 - num2 - num3;
                textBox1.Text = num1.ToString();
                ticket[4] = num1.ToString();
            }
            else if (sum > 0 && sum < 5)
            {
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                if (num1 <= 0)
                {
                    num1 = 0;
                    textBox1.Text = num1.ToString();
                    ticket[4] = num1.ToString();
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                if (num2 <= 0)
                {
                    num2 = 0;
                    textBox2.Text = num2.ToString();
                    ticket[5] = num2.ToString();
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (num3 <= 0)
                {
                    num3 = 0;
                    textBox3.Text = num3.ToString();
                    ticket[6] = num3.ToString();
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true;
                }
            }
            else if (sum <= 0)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                num1 = 0;
                textBox1.Text = num1.ToString();
                ticket[4] = num1.ToString();
            }
            if (ticket[3] == "信用卡")
            {
                num = num1 * price1 + num2 * price2 + num3 * price3;
                label6.Text = num.ToString();
                ticket[7] = num.ToString();
            }
            else
            {
                num = num1 * price4 + num2 * price5 + num3 * price6;
                label6.Text = num.ToString();
                ticket[7] = num.ToString();
            }
            if (num != 0)
            {
                button8.Enabled = true;
            }
            else
            {
                button8.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sum = num1 + num2 + num3;
            if (sum >= 5)
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                num2 = 5 - num1 - num3;
                textBox2.Text = num2.ToString();
                ticket[5] = num2.ToString();
            }
            else if (sum > 0 && sum < 5)
            {
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                if (num2 <= 0)
                {
                    num2 = 0;
                    textBox2.Text = num2.ToString();
                    ticket[5] = num2.ToString();
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (num1 <= 0)
                {
                    num1 = 0;
                    textBox1.Text = num1.ToString();
                    ticket[3] = num1.ToString();
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                if (num3 <= 0)
                {
                    num3 = 0;
                    textBox3.Text = num3.ToString();
                    ticket[6] = num3.ToString();
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true;
                }
            }
            else if (sum <= 0)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                num2 = 0;
                textBox2.Text = num2.ToString();
                ticket[5] = num2.ToString();
            }
            if (ticket[3] == "信用卡")
            {
                num = num1 * price1 + num2 * price2 + num3 * price3;
                label6.Text = num.ToString();
                ticket[7] = num.ToString();
            }
            else
            {
                num = num1 * price4 + num2 * price5 + num3 * price6;
                label6.Text = num.ToString();
                ticket[7] = num.ToString();
            }
            if (num != 0)
            {
                button8.Enabled = true;
            }
            else
            {
                button8.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sum = num1 + num2 + num3;
            if (sum >= 5)
            {
                button2.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                num1 = 5 - num2 - num3;
                textBox3.Text = num3.ToString();
                ticket[6] = num3.ToString();
            }
            else if (sum > 0 && sum < 5)
            {
                button2.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                if (num3 <= 0)
                {
                    num3 = 0;
                    textBox3.Text = num3.ToString();
                    ticket[6] = num3.ToString();
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true;
                }
                if (num1 <= 0)
                {
                    num1 = 0;
                    textBox1.Text = num1.ToString();
                    ticket[4] = num1.ToString();
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
                if (num2 <= 0)
                {
                    num2 = 0;
                    textBox2.Text = num2.ToString();
                    ticket[5] = num2.ToString();
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
            }
            else if (sum <= 0)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                num3 = 0;
                textBox3.Text = num3.ToString();
                ticket[6] = num3.ToString();
            }
            if (ticket[3] == "信用卡")
            {
                num = num1 * price1 + num2 * price2 + num3 * price3;
                label6.Text = num.ToString();
                ticket[7] = num.ToString();
            }
            else
            {
                num = num1 * price4 + num2 * price5 + num3 * price6;
                label6.Text = num.ToString();
                ticket[7] = num.ToString();
            }
            if (num != 0)
            {
                button8.Enabled = true;
            }
            else
            {
                button8.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ticket[4] = textBox1.Text;
            ticket[5] = textBox2.Text;
            ticket[6] = textBox3.Text;
            ticket[7] = label6.Text;
            Form f4 = new Form4(ticket);
            f4.Show();
            this.Close();
        }
    }   
}
