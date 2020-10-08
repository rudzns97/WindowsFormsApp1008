using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "200";
            progressBar1.Value = 100;
            timer1.Interval = 400;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 10)
            {
                progressBar1.Value = 0;
                timer1.Stop();
            }
            else
                progressBar1.Value -= 10;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //13은 아스키코드로 엔터
            {
                timer1.Stop();
                //정답체크
                //if(label4.Text == textBox1.Text)
                    //점수 올리기

                //else
                    //기회를 빼준다
                    //문제 다시 출제
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
