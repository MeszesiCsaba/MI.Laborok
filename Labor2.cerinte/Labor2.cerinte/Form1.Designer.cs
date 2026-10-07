namespace Labor2.cerinte
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.backgrndclr = new System.Windows.Forms.Button();
            this.textclr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(713, 415);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 0;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(713, 386);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(374, 29);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(39, 16);
            this.HelloLabel.TabIndex = 2;
            this.HelloLabel.Text = "Hello";
            this.HelloLabel.Click += new System.EventHandler(this.HelloLabel_Click);
            // 
            // backgrndclr
            // 
            this.backgrndclr.Location = new System.Drawing.Point(522, 415);
            this.backgrndclr.Name = "backgrndclr";
            this.backgrndclr.Size = new System.Drawing.Size(158, 23);
            this.backgrndclr.TabIndex = 3;
            this.backgrndclr.Text = "Background Color";
            this.backgrndclr.UseVisualStyleBackColor = true;
            this.backgrndclr.Click += new System.EventHandler(this.backgrndclr_Click);
            // 
            // textclr
            // 
            this.textclr.Location = new System.Drawing.Point(522, 386);
            this.textclr.Name = "textclr";
            this.textclr.Size = new System.Drawing.Size(158, 23);
            this.textclr.TabIndex = 4;
            this.textclr.Text = "Text Color";
            this.textclr.UseVisualStyleBackColor = true;
            this.textclr.Click += new System.EventHandler(this.textclr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 630);
            this.Controls.Add(this.textclr);
            this.Controls.Add(this.backgrndclr);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button backgrndclr;
        private System.Windows.Forms.Button textclr;
    }
}

