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
    public partial class Form2 : Form
    {
        public string[] date = new string[3];
        public Form2()
        {
            InitializeComponent();
            label5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            button1.Enabled = false;
        }
        int sum1=0, sum2=0, sum3=0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sum1++;
            label5.Visible = true;
            label5.Text = comboBox1.SelectedItem.ToString();
            date[0] = comboBox1.SelectedItem.ToString();
            if (sum1 != 0 && sum2 != 0 && sum3 != 0)
            {
                button1.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            sum2++;
            label7.Visible = true;
            label7.Text = dateTimePicker1.Value.ToShortDateString();
            date[1] = dateTimePicker1.Value.ToShortDateString();
            if (sum1 != 0 && sum2 != 0 && sum3 != 0)
            {
                button1.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sum3++;
            label9.Visible = true;
            label9.Text = comboBox2.SelectedItem.ToString();
            date[2] = comboBox2.SelectedItem.ToString();
            if (sum1 != 0 && sum2 != 0 && sum3 != 0)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3(date);
            f3.Show();
            this.Close();
        }
    }
}
