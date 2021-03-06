﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//need to calc totalHrs
//need to create case for wanting Time to Leave for Lunch
//USE DATETIME . NOW

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private DateTime workClockIn;
        private DateTime workClockOut;
        private DateTime lunchClockIn;
        private DateTime lunchClockOut;

        private TimeSpan lunchLength = new TimeSpan(0, 30, 0);
        private int lunchInput = 0;

        private TimeSpan minWork = new TimeSpan(8, 0, 0);

        public Form1()
        {
            InitializeComponent();
            this.lunchDuration.Text = lunchLength.ToString();
            hours.Text = minWork.ToString();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String input = timeIn.Text;
                workClockIn = DateTime.Parse(input);    
            }
            catch (FormatException format)
            {
                //MessageBox.Show("Input format needs to be: \"hh:mm\" or \"hh:mm:ss\"");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            try
            {
                String input = lunchOut.Text;
                lunchClockOut = DateTime.Parse(input);

                //MessageBox.Show(lunchClockOut.ToString());
            }
            catch (FormatException format)
            {
                //MessageBox.Show("Input format needs to be: \"hh:mm\" or \"hh:mm:ss\"");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                String input = lunchIn.Text;
                lunchClockIn = DateTime.Parse(input);

                if (!lunchOut.Text.Equals(""))
                {
                    //make this equal to lunch duration
                    lunchLength = lunchClockIn.Subtract(lunchClockOut);
                    lunchDuration.Text = lunchLength.ToString();
                }
            }
            catch (FormatException format)
            {
                //MessageBox.Show("Input format needs to be: \"hh:mm\" or \"hh:mm:ss\"");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (timeIn.Text != null && lunchIn.Text != null && lunchOut.Text != null)
                {
                    workClockOut = lunchClockIn.Add(minWork).Subtract(lunchClockOut.Subtract(workClockIn));

                    //fix minutes
                    string alteredMinute = "0";
                    if (workClockOut.Minute < 10)
                    {
                        alteredMinute += workClockOut.Minute.ToString();
                    }
                    else
                    {
                        alteredMinute = workClockOut.Minute.ToString();
                    }

                    timeOut.Text = workClockOut.Hour + ":" + alteredMinute;
                }
                String input = timeOut.Text;
                workClockOut = DateTime.Parse(input);

            }
            catch (FormatException format)
            {
                //MessageBox.Show("Input format needs to be: \"hh:mm\" or \"hh:mm:ss\"");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {            
            try
            {
                lunchInput = Int32.Parse(this.lunchDuration.Text);
            }
            catch (Exception g)
            {
                String errorMessage = g.Message;
                //MessageBox.Show(errorMessage);
            }

            lunchLength = TimeSpan.Parse(lunchDuration.Text);

            // check time limitations
            if (this.lunchLength < new TimeSpan(0, 30, 0))
            {
                MessageBox.Show("Lunch must be at least 30 min long.");
            }
            else if (this.lunchLength > new TimeSpan(0, 60, 0))
            {
                MessageBox.Show("Lunch is longer than and hr. That's too long.");
            }

            // calc lunchin
            if (lunchClockOut == null)
            {
                MessageBox.Show("Please input Lunch Out Time");
            }

            lunchClockIn = lunchClockOut.Add(lunchLength);

            //fix minutes
            string alteredMinute = "0";
            if (lunchClockIn.Minute < 10)
            {
                alteredMinute += lunchClockIn.Minute.ToString();
            }
            else
            {
                alteredMinute = lunchClockIn.Minute.ToString();
            }
            lunchIn.Text = lunchClockIn.Hour.ToString() + ":" + alteredMinute;
            
            
        }

        private void getLunchIn_Click(object sender, EventArgs e)
        {
            try
            {
                lunchClockIn = workClockOut + (lunchClockOut - workClockIn) - minWork;
                lunchIn.Text = lunchClockIn.ToString();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minWork = TimeSpan.Parse(hours.Text);
            hours.Text = minWork.ToString();
            //warning if hours is above 8 hrs. No new overtime
            //MessageBox.Show(minWork.ToString());
        }

        private void timeIn_Leave(object sender, EventArgs e)
        {
            try
            {
                String input = timeIn.Text;
                workClockIn = DateTime.Parse(input);



                //MessageBox.Show(workClockIn.ToString());
            }
            catch (FormatException format)
            {
                //MessageBox.Show("Input format needs to be: \"hh:mm\" or \"hh:mm:ss\"");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void lunchOut_Leave(object sender, EventArgs e)
        {
            try
            {
                String input = lunchOut.Text;
                lunchClockOut = DateTime.Parse(input);

                //MessageBox.Show(lunchClockOut.ToString());
            }
            catch (FormatException format)
            {
                MessageBox.Show("Input format needs to be: \"hh:mm\" or \"hh:mm:ss\"");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void lunchIn_Leave(object sender, EventArgs e)
        {
            try
            {
                String input = lunchIn.Text;
                lunchClockIn = DateTime.Parse(input);

                if (!lunchOut.Text.Equals(""))
                {
                    //make this equal to lunch duration
                    lunchLength = lunchClockIn.Subtract(lunchClockOut);
                    lunchDuration.Text = lunchLength.ToString();
                }
            }
            catch (FormatException format)
            {
                MessageBox.Show("Input format needs to be: \"hh:mm\" or \"hh:mm:ss\"");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void timeOut_Leave(object sender, EventArgs e)
        {
            string alteredMinute = "0";
            try
            {
                if (timeOut.Text.Equals(""))
                {
                    if (timeIn.Text != null && lunchIn.Text != null && lunchOut.Text != null)
                    {
                        workClockOut = lunchClockIn.Add(minWork).Subtract(lunchClockOut.Subtract(workClockIn));

                        //fix minutes
                        if (Int32.Parse(workClockOut.Minute.ToString()) < 10)
                        {
                            alteredMinute += workClockOut.Minute.ToString();
                        }
                        else
                        {
                            alteredMinute = workClockOut.Minute.ToString();
                        }

                        timeOut.Text = workClockOut.Hour + ":" + alteredMinute;
                    }
                }
                String input = timeOut.Text;
                workClockOut = DateTime.Parse(input);
            }
            catch (FormatException format)
            {
                //MessageBox.Show("Input format needs to be: \"hh:mm\" or \"hh:mm:ss\"");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }
    }
}
