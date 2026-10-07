using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Labor2.cerinte
{
    public partial class Form1 : Form
    {
        private MyThread myThread;
        public Form1()
        {
            InitializeComponent();

            Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));

            Trace.AutoFlush = true;

            myThread = new MyThread(DrawText);

        }
        public void DrawText()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    DrawText();
                });

                return;
            }

            HelloLabel.Left += 10;

            if (HelloLabel.Right > this.ClientSize.Width)
            {
                HelloLabel.Left = 0;
            }

            if (logSwitch.Enabled)
            {
                Trace.WriteLine(
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
                );
            }
        }

        private BooleanSwitch logSwitch = new BooleanSwitch("LogSwitch", "Logging Switch");
        private void StartButton_Click(object sender, EventArgs e)
        {
           myThread.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            myThread.Stop();
        }

        
        private void HelloLabel_Click(object sender, EventArgs e)
        {

        }

        private void textclr_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                HelloLabel.ForeColor = colorDialog.Color;
            }
        }

        private void backgrndclr_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }

        }
    }
}
