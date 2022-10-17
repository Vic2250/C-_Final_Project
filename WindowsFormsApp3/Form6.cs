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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void 字體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult responce;
            responce = colorDialog1.ShowDialog();
            if(responce == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user = 0;
            int ans = 0;
            Random r = new Random();
            user = r.Next(1, 50);
            ans = r.Next(1, 50);

            if(user == ans)
            {
                MessageBox.Show("抽中大獎啦");
                this.Close();
            }
            else
            {
                MessageBox.Show("下次再來~");
                this.Close();
            }
        }
    }
}
