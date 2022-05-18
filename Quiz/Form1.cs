using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Random randomizer = new Random();

        public int andend1, andend2, timeLeft, minus1, minus2, multi1, multi2, div1, div2;

        public Form1()
        {
            InitializeComponent();
        }
        private void startButton_Click_1(object sender, EventArgs e)
        {
            andend1 = randomizer.Next(51);
            andend2 = randomizer.Next(51);

            plusLeftLabel.Text = andend1.ToString();
            plusRightLabel.Text = andend2.ToString();

            sum.Value = 0;

            minus1 = randomizer.Next(1, 101);
            minus2 = randomizer.Next(1, minus1);

            minusLeftLabel.Text = minus1.ToString();
            minusRightLabel.Text = minus2.ToString();

            difference.Value = 0;


            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckAnswer() == true)
            {
                timer1.Stop();
                MessageBox.Show("Congrats!");

            } else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time is up";
                MessageBox.Show("You didn't finish in time...");
                sum.Value = andend1 + andend2;
            }
        }

        private bool CheckAnswer()
        {
            if ((andend1 + andend2 == sum.Value) && (minus1 - minus2 == difference.Value))
            {
                return true;
            }
            else
            {
                return false;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
