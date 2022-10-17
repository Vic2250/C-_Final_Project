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
    public partial class Form5 : Form
    {
        public string[] respie = new string[21];
        public Form5(string[] food)
        {
            InitializeComponent();
            for(int i = 0; i < food.Length; i++)
            {
                respie[i] = food[i];
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label3.Text = respie[0];
            label5.Text = respie[1];
            label7.Text = respie[2];
            label9.Text = respie[3];
            label11.Text = "學生票" + respie[4] + "   教職員票" + respie[5] + "     一般票" + respie[6];
            label13.Text = respie[7];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "XX電影院訂票收據紀錄";
            saveFileDialog1.DefaultExt = ".jpg";
            saveFileDialog1.Filter = "圖片檔 (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg|PDF(*.pdf)|*.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
