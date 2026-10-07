using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labor1.exercitii
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //textBox1.Top -= 10;
            ButtonRight.Text = "Modositva";
            ButtonRight.BackColor = Color.Red;
            textBox1.Location = new Point(10, 10);

            textBox1.ForeColor = Color.Red;
            textBox1.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            textBox1.Top += 10;
            ButtonUp.Text = "Hello";
            textBox1.Location = new Point(10, this.ClientSize.Height - textBox1.Height - 10);

            textBox1.ForeColor = Color.Blue;
            textBox1.Font = new Font("Times New Roman", 16, FontStyle.Italic);
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            textBox1.Left -= 10;
            ButtonLeft.Text = "Left";
            ButtonUp.Text = "Up";
            ButtonDown.Text = "Down";
            ButtonRight.Text = "Right";
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            textBox1.Left += 10;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, this.ClientSize.Width - textBox1.Width);
            int y = random.Next(0, this.ClientSize.Height - textBox1.Height);

            textBox1.Location = new Point(x, y);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();

            int x = random.Next(0, Screen.PrimaryScreen.WorkingArea.Width - this.Width);
            int y = random.Next(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            this.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonLeft.BackColor = Color.Blue;
            timer1.Stop();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ButtonUp.BackColor = Color.Green;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Pen pen = new Pen(Color.Black, 3);
            //   g.DrawRectangle(pen, 10, 10, 400, 300);

            Random random = new Random();

            int x = random.Next(0, this.ClientSize.Width - 50);
            int y = random.Next(0, this.ClientSize.Height - 50);

            int width = random.Next(20, 100);
            int height = random.Next(20, 100);

            Pen pen = new Pen(
                Color.FromArgb
                (random.Next(256), 
                random.Next(256), 
                random.Next(256)), 
                2);

            g.DrawRectangle(pen, x, y, width, height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
