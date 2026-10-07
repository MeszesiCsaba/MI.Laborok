using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labor1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        { 
            InitializeComponent();
        }
    


        private void UpButton_Click(object sender, EventArgs e)
        {
         //   label1.Text = (int.Parse(label1.Text) + 1).ToString();
         //   label1.Text = "kicsikutya";
           // label1.Refresh();

            label1.Text = UpButton.BackColor.Name;
            label1.Refresh();
            //textBox1.Text = "A cim megvaltozott";
            DialogResult result = MessageBox.Show(
                    "Biztosan felfelé szeretnéd mozgatni?",
                    "UP",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            textBox1.Text = result.ToString();
            if(result == DialogResult.Yes)
            {
                this.Top -= 10;
            }
            
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            label1.Text = DownButton.BackColor.Name;
            label1.Refresh();
            //textBox1.Text = "A cim megvaltozott";
            DialogResult result = MessageBox.Show(
                    "Biztosan lefelé szeretnéd mozgatni?",
                    "DOWN",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question);
            textBox1.Text = result.ToString();

            if (result == DialogResult.Retry)
            {
                this.Top += 10;
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            label1.Text = RightButton.BackColor.Name;
            label1.Refresh();
            //textBox1.Text = "A cim megvaltozott";
            DialogResult result = MessageBox.Show(
                    "Biztosan jobbra szeretnéd mozgatni?",
                    "RIGHT",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
            textBox1.Text = result.ToString();

            if (result == DialogResult.OK)
            {
                this.Left += 10;
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            label1.Text = LeftButton.BackColor.Name;
            label1.Refresh();
            //textBox1.Text = "A cim megvaltozott";
            DialogResult result = MessageBox.Show(
                    "Biztosan balra szeretnéd mozgatni?",
                    "LEFT",
                    MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Question);
            textBox1.Text = result.ToString();

            if (result == DialogResult.Retry)
            {
                this.Left -= 10;
            }   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(random.Next(256),random.Next(256),random.Next(256));
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int period) && period > 0)
            {
                timer1.Interval = period;
            }
        }
    }
}