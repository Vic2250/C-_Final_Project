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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            button2.Visible = false;
        }
        int sum = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "aaa" && textBox2.Text == "123")
            {
                MessageBox.Show("登入成功");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
                label7.Visible = true;
                button2.Visible = true;
            }
            else
            {
                sum--;
                MessageBox.Show("登入失敗\r\n剩餘次數" + sum, "驗證帳號密碼", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Clear();
                textBox2.Clear();
                if(sum == 0)
                {
                    this.Close();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBox1.Text == "aaa" && textBox2.Text == "123")
                {
                    MessageBox.Show("登入成功");
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    button1.Enabled = false;
                    label7.Visible = true;
                    button2.Visible = true;
                }
                else
                {
                    sum--;
                    MessageBox.Show("登入失敗\r\n剩餘次數" + sum, "驗證帳號密碼", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Clear();
                    textBox2.Clear();
                    if (sum == 0)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }
    }
}
