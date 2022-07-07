//
// COP 4365 – Spring 2022
//
// Homework #4: Traffic Study
//
// Description: Redoing the last hw to calculate: How many cars came from each direction?
// 2.The maximum size of the line of cars that had to wait to get through the light.
// 3. How long each car had to wait to make it through the stoplight.
// 4. The average amount of time that cars wait based on which direction they are coming from (four values) 
//
// File name:
//
// By: Madeline Leyva U94412186
//
// string[] name = File.ReadAllLines(./file);

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

        // Method Name: reader
        // Description: Reads through the .txt file and takes all the lines and converts them into car objects
        public void reader()
        {
            // blah
            string[] cars = System.IO.File.ReadAllLines("./HW #4 Data.txt");


        }


        // Method Name: allRed
        // Description: Turns all traffic lights red
        public void allRed()
        {
            light1a.BackColor = Color.Red;
            light2a.BackColor = Color.Red;
            light3a.BackColor = Color.Red;
            light4a.BackColor = Color.Red;


            //timer1.Interval = 0;
        }

        // declaring a counter that can be used throughout the code
        //private int num;

        // Method Name: timerStart
        // Description: Meant to act as a component to replace the previous method of the timer1_Tick
        //              so instead each method can separately trigger the next one.
        private void timerStart()
        {
            // setting the interval to 1 second at a time
            timer1.Interval = 1000;

            num = 0;
            //timer1.Tick += new EventHandler(timer1_Tick);

            // starting the timer off the rip
            timer1.Enabled = true;
           
            // attaching this specific event handler
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

        }

        // Method Name: outputMsg
        // Description: Outputting the last message box to indicate the end of the light switches
        //              This is mwant to take further things out of my "main" timer1_Tick method.

        public void outputMsg()
        {
            if (counter == 60)
            {
                //timer1.Stop();

                // output everything in a text box
                string greenOut = northGreenLight();
                string NSGreen = northSouthGreen();
                string YGRRout = YGRR();
                string RGRRout = RGRR();
                string RYRRout = RYRR();
                string RRGRout = RRGR();
                string RRGGout = RRGG();
                string RRYGout = RRYG();
                string RRRGout = RRRG();
                string RRRYout = RRRY();
                string ambulance = emergency();
                string RRGR2out = RRGR2();
                string RRGG2out = RRGG2();
                string RRYG2out = RRYG2();
                string RRRG2out = RRRG2();

                MessageBox.Show("Time    North Light   South Light   East Light   West Light\n" +
                                "-------   ---------------  --------------    --------------   ---------------\n" +
                                $"{greenOut}{NSGreen}{YGRRout}{RGRRout}{RYRRout}{RRGRout}{RRGGout}{RRYGout}{RRRGout}{RRRYout}" +
                                "An emergency vehicle has been detected coming from the East\n" +
                                $"{ambulance}" +
                                "The emergency vehicle has left the area.\n" +
                                $"{RRGR2out}{RRGG2out}{RRYG2out}{RRRG2out}");
            }

        }

        private static Timer aTimer;

        // Method Name: northGreenLight
        // Description: The north light turns green and lasts for 9 seconds. 
        public string northGreenLight()
        {
            // setting the light colors to green
            light1a.BackColor = Color.Gray;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Green;
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            light3a.BackColor = Color.Red;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            light4a.BackColor = Color.Red;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;

            // end output formatting
            string greenOut = "0\tGreen\t     Red\t\tRed\tRed\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch greenLightWatch = new Stopwatch();
            greenLightWatch.Start();
            TimeSpan ts = greenLightWatch.Elapsed;
            if (ts.Seconds == 9)
            {
                greenLightWatch.Stop();
            }


            // returning the string
            return greenOut;
        }

        //
        // Method Name: northSouthGreen
        // Description: The north and south lights turn green and lasts for 9 seconds. 
        public string northSouthGreen()
        {
            light1a.BackColor = Color.Gray;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Green;
            light2a.BackColor = Color.Gray;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Green;
            light3a.BackColor = Color.Red;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            light4a.BackColor = Color.Red;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;

            // end output formatting
            string greenNS = "6\tGreen\t   Green\t\tRed\tRed\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch greenLightWatch = new Stopwatch();
            greenLightWatch.Start();
            TimeSpan ts = greenLightWatch.Elapsed;
            if (ts.Seconds == 9)
            {
                greenLightWatch.Stop();
            }


            // returning the string
            return greenNS;
        }

        //
        // Method Name: YGRR
        // Description: The north light turns yellow and south light turn green and lasts for 3 seconds. 
        public string YGRR()
        {
            light1a.BackColor = Color.Gray;
            light1c.BackColor = Color.Yellow;
            light1b.BackColor = Color.Gray;
            light2a.BackColor = Color.Gray;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Green;
            light3a.BackColor = Color.Red;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            light4a.BackColor = Color.Red;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;

            // end output formatting
            string output = "9\tYellow\t   Green\t\tRed\tRed\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 3)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RGRR
        // Description: Triggers North and South light changes; lasts  for 3 seconds. 
        public string RGRR()
        {
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            light2a.BackColor = Color.Gray;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Green;
            light3a.BackColor = Color.Red;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            light4a.BackColor = Color.Red;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;

            // end output formatting
            string output = "12\tRed\t   Green\t\tRed\tRed\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 3)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RYRR
        // Description: Triggers South light change; lasts  for 3 seconds. 
        public string RYRR()
        {
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Gray;
            light2c.BackColor = Color.Yellow;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Red;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            // west
            light4a.BackColor = Color.Red;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;

            // end output formatting
            string output = "15\tRed\t  Yellow\t\tRed\tRed\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 3)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RRGR
        // Description: Triggers South and East light changes; lasts  for 9 seconds. 
        public string RRGR()
        {
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Gray;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Green;
            // west
            light4a.BackColor = Color.Red;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;

            // end output formatting
            string output = "18\tRed\t     Red\t\tGreen\tRed\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 9)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RRGG
        // Description: Triggers South and West light changes; lasts  for 9 seconds. 
        public string RRGG()
        {
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Gray;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Green;
            // west
            light4a.BackColor = Color.Gray;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Green;

            // end output formatting
            string output = "24\tRed\t     Red\t\tGreen\tGreen\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 9)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RRYG
        // Description: Triggers West and East light changes; lasts for 3 seconds. 
        public string RRYG()
        {
            // setting the light colors to green
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Gray;
            light3c.BackColor = Color.Yellow;
            light3b.BackColor = Color.Gray;
            // west
            light4a.BackColor = Color.Gray;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Green;

            // end output formatting
            string output = "27\tRed\t     Red\t\tYellow\tGreen\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 3)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RRRG
        // Description: Triggers West and East light changes; lasts for 9 seconds. 
        public string RRRG()
        {
            // setting the light colors to green
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Red;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            // west
            light4a.BackColor = Color.Gray;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Green;

            // end output formatting
            string output = "30\tRed\t     Red\t\tRed\tGreen\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 9)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RRYG
        // Description: Triggers West light changes; lasts for 3 seconds. 
        public string RRRY()
        {
            // setting the light colors to green
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Red;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            // west
            light4a.BackColor = Color.Gray;
            light4c.BackColor = Color.Yellow;
            light4b.BackColor = Color.Gray;

            // end output formatting
            string output = "33\tRed\t     Red\t\tRed\tYellow\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 3)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: emergency
        // Description: Triggers emergency vehicle approaching for 10 seconds
        public string emergency()
        {
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Gray;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Green;
            // west
            light4a.BackColor = Color.Red;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;

            // end output formatting
            string output = "35\tRed\t     Red\t\tGreen\tRed\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 10)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }
        //
        // Method Name: RRGR2
        // Description: Triggers South and East light changes; lasts  for 9 seconds. 
        public string RRGR2()
        {
            // setting the light colors to green
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Gray;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Green;
            // west
            light4a.BackColor = Color.Red;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;

            // end output formatting
            string output = "45\tRed\t     Red\t\tGreen\tRed\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 9)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RRGG2
        // Description: Triggers South and West light changes; lasts  for 9 seconds. 
        public string RRGG2()
        {
            // setting the light colors to green
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Gray;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Green;
            // west
            light4a.BackColor = Color.Gray;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Green;

            // end output formatting
            string output = "51\tRed\t     Red\t\tGreen\tGreen\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 9)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RRYG2
        // Description: Triggers West and East light changes; lasts for 3 seconds. 
        public string RRYG2()
        {
            // setting the light colors to green
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Gray;
            light3c.BackColor = Color.Yellow;
            light3b.BackColor = Color.Gray;
            // west
            light4a.BackColor = Color.Gray;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Green;

            // end output formatting
            string output = "54\tRed\t     Red\t\tYellow\tGreen\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 3)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
        }

        //
        // Method Name: RRRG
        // Description: Triggers West and East light changes; lasts for 9 seconds. 
        public string RRRG2()
        {
            // setting the light colors to green
            // north
            light1a.BackColor = Color.Red;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Gray;
            // south
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            // east
            light3a.BackColor = Color.Red;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            // west
            light4a.BackColor = Color.Gray;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Green;

            // end output formatting
            string output = "57\tRed\t     Red\t\tRed\tGreen\n";

            // setting up a stopwatch for this prticular green light
            Stopwatch lightWatch = new Stopwatch();
            lightWatch.Start();
            TimeSpan ts = lightWatch.Elapsed;
            if (ts.Seconds == 9)
            {
                lightWatch.Stop();
            }

            // returning the string
            return output;
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

            // initializing stopwatch
            Stopwatch stopWatch = new Stopwatch();
            

            // light 1 = north 
            // light 2 = south
            // light 3 = east
            // light 4 = west 
            // a = red, c = yellow, b = green
            // green = 9 sec, yellow = 3 sec, red = rest
            // first config; North green, all others red
            light1a.BackColor = Color.Gray;
            light1c.BackColor = Color.Gray;
            light1b.BackColor = Color.Green;
            light2a.BackColor = Color.Red;
            light2c.BackColor = Color.Gray;
            light2b.BackColor = Color.Gray;
            light3a.BackColor = Color.Red;
            light3c.BackColor = Color.Gray;
            light3b.BackColor = Color.Gray;
            light4a.BackColor = Color.Red;
            light4c.BackColor = Color.Gray;
            light4b.BackColor = Color.Gray;

            // starting the stopwatch and timer
            stopWatch.Start();
            timer1.Start();

            // Geting the elapsed time as a TimeSpan value & initial output
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Elapsed time = ", ts.Seconds);
            timeOutput.Text = $"Time Elapsed: {ts.Seconds}";

         


            if (ts.Seconds == 60)
            {
                stopWatch.Stop();
                //this.Refresh();
                //timeOutput.Text = $"Time Elapsed: {ts.Seconds}";
            }

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
            light4c.BackColor = Color.Gray;

            timeOutput.Text = $"Time Elapsed: 0";
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
        // Description: for every iteration of the timer, a light changes. At the end, it outputs all changes.

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            timeOutput.Text = $"Time Elapsed: {counter}";
            reader();


            // for each iteration of the timer, a different method is called
            if (counter == 6)
            {
                northSouthGreen();                
            }
            else if (counter == 9)
            {
                YGRR();
            }
            else if (counter == 12)
            {
                RGRR();
            }
            else if (counter == 15)
            {
                RYRR();
            }
            else if (counter == 18)
            {
                RRGR();
            }
            else if (counter == 24)
            {
                RRGG();
            }
            else if (counter == 27)
            {
                RRYG();
            }
            else if (counter == 30)
            {
                RRRG();
            }
            else if (counter == 33)
            {
                RRRY();
            }
            else if (counter == 35)
            {
                emergency();
            }
            else if (counter == 45)
            {
                RRGR2();
            }
            else if (counter == 51)
            {
                RRGG2();
            }
            else if (counter == 54)
            {
                RRYG2();
            }
            if (counter == 57)
            {
                RRRG2();
            }
            if (counter == 60)
            {
                outputMsg();
            }
        }

        private void playByPlay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
