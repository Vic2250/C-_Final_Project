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

    public partial class Form4 : Form
    {
        public string[] food = new string[20];
        public Form4(string[] ticket)
        {
            InitializeComponent();
            for (int i = 0; i <= 7; i++)
            {
                food[i] = ticket[i];
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (food[3] == "信用卡")
            {
                groupBox2.Text = "金額結算";
                label2.Text = "總金額為:";
                label3.Text = food[7];
                label4.Text = "元";
            }
            else
            {
                groupBox2.Text = "點數結算";
                label2.Text = "總點數為:";
                label3.Text = food[7];
                label4.Text = "點";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("爆米花          75元/5點");
            listBox1.Items.Add("熱狗堡          80元/7點");
            listBox1.Items.Add("吉拿棒          75元/6點");
            listBox1.Items.Add("可麗餅          80元/7點");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("可樂              25元/2點");
            listBox1.Items.Add("雪碧              25元/2點");
            listBox1.Items.Add("檸檬紅茶          25元/2點");
            listBox1.Items.Add("每朝健康          30元/3點");
        }
        int count = 0;
        int j;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= int.Parse(textBox1.Text); i++)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                food[i + 7] = listBox1.SelectedItem.ToString();
                if (food[3] == "信用卡")
                {
                    if (food[i + 7] == "爆米花          75元/5點")
                    {
                        count += 75;
                    }
                    if (food[i + 7] == "熱狗堡          80元/7點")
                    {
                        count += 80;
                    }
                    if (food[i + 7] == "吉拿棒          75元/6點")
                    {
                        count += 75;
                    }
                    if (food[i + 7] == "可麗餅          80元/7點")
                    {
                        count += 80;
                    }
                    if (food[i + 7] == "可樂              25元/2點")
                    {
                        count += 25;
                    }
                    if (food[i + 7] == "雪碧              25元/2點")
                    {
                        count += 25;
                    }
                    if (food[i + 7] == "檸檬紅茶          25元/2點")
                    {
                        count += 25;
                    }
                    if (food[i + 7] == "每朝健康          30元/3點")
                    {
                        count += 30;
                    }
                }
                else
                {
                    if (food[i + 7] == "爆米花          75元/5點")
                    {
                        count += 5;
                    }
                    if (food[i + 7] == "熱狗堡          80元/7點")
                    {
                        count += 7;
                    }
                    if (food[i + 7] == "吉拿棒          75元/6點")
                    {
                        count += 6;
                    }
                    if (food[i + 7] == "可麗餅          80元/7點")
                    {
                        count += 7;
                    }
                    if (food[i + 7] == "可樂              25元/2點")
                    {
                        count += 2;
                    }
                    if (food[i + 7] == "雪碧              25元/2點")
                    {
                        count += 2;
                    }
                    if (food[i + 7] == "檸檬紅茶          25元/2點")
                    {
                        count += 2;
                    }
                    if (food[i + 7] == "每朝健康          30元/3點")
                    {
                        count += 3;
                    }
                }                
            }
            j = int.Parse(food[7]);
            j += count;
            label3.Text = j.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            label3.Text = food[7];
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3(food);
            f3.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            food[7] = label3.ToString();
            Form f5 = new Form5(food);
            f5.Show();
            this.Close();
        }
    }
}
