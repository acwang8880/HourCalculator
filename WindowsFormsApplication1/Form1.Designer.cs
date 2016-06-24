namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.timeIn = new System.Windows.Forms.TextBox();
            this.lunchOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lunchIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getLunchIn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lunchDuration = new System.Windows.Forms.TextBox();
            this.timeUnit = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.getHrsWorked = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time In";
            // 
            // timeIn
            // 
            this.timeIn.AcceptsReturn = true;
            this.timeIn.Location = new System.Drawing.Point(13, 30);
            this.timeIn.Name = "timeIn";
            this.timeIn.Size = new System.Drawing.Size(71, 20);
            this.timeIn.TabIndex = 1;
            // 
            // lunchOut
            // 
            this.lunchOut.Location = new System.Drawing.Point(13, 70);
            this.lunchOut.Name = "lunchOut";
            this.lunchOut.Size = new System.Drawing.Size(71, 20);
            this.lunchOut.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lunch Out";
            // 
            // lunchIn
            // 
            this.lunchIn.Location = new System.Drawing.Point(13, 111);
            this.lunchIn.Name = "lunchIn";
            this.lunchIn.Size = new System.Drawing.Size(71, 20);
            this.lunchIn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lunch In";
            // 
            // timeOut
            // 
            this.timeOut.Location = new System.Drawing.Point(12, 150);
            this.timeOut.Name = "timeOut";
            this.timeOut.Size = new System.Drawing.Size(71, 20);
            this.timeOut.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time Out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "When should I leave ...?";
            // 
            // getLunchIn
            // 
            this.getLunchIn.Location = new System.Drawing.Point(400, 112);
            this.getLunchIn.Name = "getLunchIn";
            this.getLunchIn.Size = new System.Drawing.Size(97, 23);
            this.getLunchIn.TabIndex = 9;
            this.getLunchIn.Text = "Lunch";
            this.getLunchIn.UseVisualStyleBackColor = true;
            this.getLunchIn.Click += new System.EventHandler(this.getLunchIn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Work";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lunch Duration";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 20);
            this.button3.TabIndex = 13;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 20);
            this.button4.TabIndex = 14;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(91, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 20);
            this.button5.TabIndex = 15;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(91, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 20);
            this.button6.TabIndex = 16;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "When should I go to?";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(285, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Work";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(285, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Lunch";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // lunchDuration
            // 
            this.lunchDuration.AllowDrop = true;
            this.lunchDuration.Location = new System.Drawing.Point(135, 71);
            this.lunchDuration.Name = "lunchDuration";
            this.lunchDuration.Size = new System.Drawing.Size(22, 20);
            this.lunchDuration.TabIndex = 20;
            this.lunchDuration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timeUnit
            // 
            this.timeUnit.FormattingEnabled = true;
            this.timeUnit.Items.AddRange(new object[] {
            "min",
            "hr"});
            this.timeUnit.Location = new System.Drawing.Point(163, 71);
            this.timeUnit.Name = "timeUnit";
            this.timeUnit.Size = new System.Drawing.Size(49, 21);
            this.timeUnit.TabIndex = 21;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(163, 98);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 49);
            this.button9.TabIndex = 22;
            this.button9.Text = "Get Lunch Out";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // getHrsWorked
            // 
            this.getHrsWorked.Location = new System.Drawing.Point(400, 181);
            this.getHrsWorked.Name = "getHrsWorked";
            this.getHrsWorked.Size = new System.Drawing.Size(75, 23);
            this.getHrsWorked.TabIndex = 23;
            this.getHrsWorked.Text = "Hrs Worked";
            this.getHrsWorked.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Hours Worked";
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(135, 30);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(77, 20);
            this.hours.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 20);
            this.button1.TabIndex = 26;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 215);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.getHrsWorked);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.timeUnit);
            this.Controls.Add(this.lunchDuration);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.getLunchIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lunchIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lunchOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeIn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeIn;
        private System.Windows.Forms.TextBox lunchOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lunchIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getLunchIn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox lunchDuration;
        private System.Windows.Forms.ComboBox timeUnit;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button getHrsWorked;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.Button button1;
    }
}

