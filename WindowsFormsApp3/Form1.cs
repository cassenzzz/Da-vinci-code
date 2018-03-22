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
        int ss = 0;
        int max = 0;
        int min = 0;
        int ans = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "") { MessageBox.Show("請輸入範圍"); return; }


            min = int.Parse(textBox1.Text);
            max = int.Parse(textBox2.Text);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
            textBox3.Enabled = true;
            button2.Enabled = true;


            label7.Text = textBox1.Text;
            label3.Text = textBox2.Text;

            Random random = new Random();
            ss = random.Next(min,max);
            label5.Text = ss.ToString();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                ans = int.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            
            if(ans == ss)
            {
                MessageBox.Show("爆囉");
            }else if(ans < max && ans > ss){
                label3.Text = ans.ToString();
                max = ans;
            }else if (ans > min && ans<ss)
            {
                label7.Text = ans.ToString();
                min = ans;
            }
            else
            {
                MessageBox.Show("不再範圍內");
            }


        }
    }
}
