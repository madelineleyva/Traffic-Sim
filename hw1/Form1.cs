//
// COP4365 – Spring Semester, 2022
//
// Homework #1: The Four Way Stoplight Problem
//
// Madeline Leyva
//
// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace hw1
{
    public partial class Form1 : Form
    {
        int counter;
        public class stoplight
        {
            //blah
            // Method Name: allRed
            // Description: Turns all traffic lights red
            public void allRed()
            {
                //this.light1a.BackColor = Color.Red;
                //light2a.BackColor = Color.Red;
                //light3a.BackColor = Color.Red;
                //light4a.BackColor = Color.Red;
            }
            
        }
        // Method Name: allRed
        // Description: Turns all traffic lights red
        public void allRed()
        {
            light1a.BackColor = Color.Red;
            light2a.BackColor = Color.Red;
            light3a.BackColor = Color.Red;
            light4a.BackColor = Color.Red;

            //northList.Items.Add("Red");
            //southList.Items.Add("Red");
            //eastList.Items.Add("Red");
            //westList.Items.Add("Red");

            //timer1.Interval = 0;
        }

        // Method Name: northGreen
        // Description: Turns the north light green
        public void northGreen()
        {
            light1a.BackColor = Color.Green;
            light2a.BackColor = Color.Red;
            light3a.BackColor = Color.Red;
            light4a.BackColor = Color.Red;

            //northList.Items.Add("Green");
            //southList.Items.Add("Red");
            //eastList.Items.Add("Red");
            //westList.Items.Add("Red");

        }

        // Method Name: southGreen
        // Description: Turns the south light green
        public void southGreen()
        {
            light1a.BackColor = Color.Green;
            light2a.BackColor = Color.Green;
            light3a.BackColor = Color.Red;
            light4a.BackColor = Color.Red;

            //northList.Items.Add("Green");
            //southList.Items.Add("Green");
            //eastList.Items.Add("Red");
            //westList.Items.Add("Red");

        }

        // Method Name: northSouthRed
        // Description: Turns the north and south lights red
        public void northSouthRed()
        {
            light1a.BackColor = Color.Red;
            light2a.BackColor = Color.Red;
            light3a.BackColor = Color.Red;
            light4a.BackColor = Color.Red;

            //northList.Items.Add("Red");
            //southList.Items.Add("Red");
            //eastList.Items.Add("Red");
            //westList.Items.Add("Red");

        }

        // Method Name: eastGreen
        // Description: Turns the east light green
        public void eastGreen()
        {
            light1a.BackColor = Color.Red;
            light2a.BackColor = Color.Red;
            light3a.BackColor = Color.Green;
            light4a.BackColor = Color.Red;

            //northList.Items.Add("Red");
            //southList.Items.Add("Red");
            //eastList.Items.Add("Green");
            //westList.Items.Add("Red");

        }


        // Method Name: westGreen
        // Description: Turns the west light green
        public void westGreen()
        {
            light1a.BackColor = Color.Red;
            light2a.BackColor = Color.Red;
            light3a.BackColor = Color.Green;
            light4a.BackColor = Color.Green;

            //northList.Items.Add("Red");
            //southList.Items.Add("Red");
            //eastList.Items.Add("Green");
            //westList.Items.Add("Green");

        }

        // Method Name: eastWestRed
        // Description: Turns the east and west lights red
        public void eastWestRed()
        {
            light1a.BackColor = Color.Red;
            light2a.BackColor = Color.Red;
            light3a.BackColor = Color.Red;
            light4a.BackColor = Color.Red;

            //northList.Items.Add("Red");
            //southList.Items.Add("Red");
            //eastList.Items.Add("Red");
            //westList.Items.Add("Red");
        }

        public Form1()
        {
            InitializeComponent();
        }

        // Method Name: runBtn_Click
        // Description: When the button is clicked, it sets up the default state of the lights and starts the timer.
        public void runBtn_Click(object sender, EventArgs e)
        {
            var sl = new stoplight();
            sl.allRed();

            // required code added
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Elapsed time = ", ts.Seconds);

            // light 1 = north 
            // light 2 = south
            // light 3 = east
            // light 4 = west 
            // first config; North and south red, east and west green
            light1a.BackColor = Color.Red;
            light1b.BackColor = Color.Gray;
            light2a.BackColor = Color.Red;
            light2b.BackColor = Color.Gray;
            light3a.BackColor = Color.Green;
            light3b.BackColor = Color.Gray;
            light4a.BackColor = Color.Green;
            light4b.BackColor = Color.Gray;

            // setting up lists
            //northList.Items.Add("North");
            //southList.Items.Add("South");
            //eastList.Items.Add("East");
            //westList.Items.Add("West");


            // printing to lists
            //northList.Items.Add("Red");
            //southList.Items.Add("Red");
            //eastList.Items.Add("Green");
            //westList.Items.Add("Green");

            timer1.Start();

        }

        // Method Name: resetBtn_Click
        // Description: resets the lights and lists as well as clears the timer
        private void resetBtn_Click(object sender, EventArgs e)
        {
            // stop the timer
            timer1.Stop();

            // set all stoplights back to gray
            light1a.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            light1c.BackColor = Color.Gray;
            light2a.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            light2c.BackColor = Color.Gray;
            light3a.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            light3c.BackColor = Color.Gray;
            light4a.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;
            button1.BackColor = Color.Gray;


            // clear list items
            //northList.Items.Clear();
            //southList.Items.Clear();
            //eastList.Items.Clear();
            //westList.Items.Clear();
        }

        private void light1a_Click(object sender, EventArgs e)
        {
            //light1a.BackColor = Color.Red;
        }

        private void northList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void southList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eastList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void westList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Method Name: timer1_Tick
        // Description: for every iteration of the timer, a light changes.
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            // for each iteration of the timer, a different method is called
            if (counter == 1)
            {
                allRed();
                //timer1.Interval = 1000;
            }
            else if (counter == 2)
            {
                northGreen();
            }
            else if (counter == 3)
            {
                southGreen();
            }
            else if (counter == 4)
            {
                northSouthRed();
            }
            else if (counter == 5)
            {
                eastGreen();
            }
            else if (counter == 6)
            {
                westGreen();
            }
            else if (counter == 7)
            {
                eastWestRed();
            }
            if (counter == 8)
            {
                timer1.Stop();
            }
        }
    }
}
