﻿namespace BitLauncher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(247, 75);
            label1.Name = "label1";
            label1.Size = new Size(357, 28);
            label1.TabIndex = 0;
            label1.Text = "FREE FORECASTS TO CRYPTO VALUTE!!!";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(291, 164);
            button1.Name = "button1";
            button1.Size = new Size(214, 68);
            button1.TabIndex = 1;
            button1.Text = "KNOW NOW!!!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 25);
            button2.Name = "button2";
            button2.Size = new Size(184, 23);
            button2.TabIndex = 3;
            button2.Text = "Forecasts Settings";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 75);
            button3.Name = "button3";
            button3.Size = new Size(184, 23);
            button3.TabIndex = 4;
            button3.Text = "About";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(12, 126);
            button4.Name = "button4";
            button4.Size = new Size(184, 23);
            button4.TabIndex = 5;
            button4.Text = "Diamond Tap Game";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(299, 311);
            button5.Name = "button5";
            button5.Size = new Size(184, 23);
            button5.TabIndex = 6;
            button5.Text = "Run Clear Version";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(-7, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(1648, 518);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(645, 336);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Use Russian Language";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BitLauncher Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private CheckBox checkBox1;
    }
}
