using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GilesLab4
{
    public class Robot
    {
        public Robot() //constructor
        {
            
        }

        //set arrow to appropriate direction
        public string FaceNorth()
        {
            char north = (char)233;
            string lblRobot = north.ToString();
            return lblRobot;
        }

        public string FaceSouth()
        {
            char south = (char)234;
            string lblRobot = south.ToString();
            return lblRobot;
        }

        public string FaceEast()
        {
            char east = (char)232;
            string lblRobot = east.ToString();
            return lblRobot;
        }
        public string FaceWest()
        {
            char west = (char)231;
            string lblRobot = west.ToString();
            return lblRobot;
        }

        public string GetDirection(string wingding) //provides robot's current direction
        {
            if (wingding == "é")
            {
                return "north";
            }
            if (wingding == "ê")
            {
                return "south";
            }
            if (wingding == "è")
            {
                return "east";
            }
            if (wingding == "ç")
            {
                return "west";
            }
            return "oops it's broke";
        }

        //method that causes robot to move appropriate direction/distance on either move button click
        public void Move(string direction, int distance, Label lblRobot) 
        {
            //prevents robot from going out of bounds
            if ((lblRobot.Left + distance) > 243 && direction == "east")
            {
                HandleRangeExceeded();
            }
            else if ((lblRobot.Left - distance) < 41 && direction == "west")
            {
                HandleRangeExceeded();
            }
            else if ((lblRobot.Top + distance) > 243 && direction == "south")
            {
                HandleRangeExceeded();
            }
            else if ((lblRobot.Top - distance) < 41 && direction == "north")
            {
                HandleRangeExceeded();
            }
            
            else //move after ensuring robot is not going out of bounds
            {
                if (direction == "east")
                {
                    lblRobot.Left += distance;
                }
                if (direction == "west")
                {
                    lblRobot.Left -= distance;
                }
                if (direction == "north")
                {
                    lblRobot.Top -= distance;
                }
                if (direction == "south")
                {
                    lblRobot.Top += distance;
                }
            }           
        }

        //update coordinates displayed in label at top of form
        public void setCoord(Label lblCoord, Label lblRobot)
        {
            int x = lblRobot.Left - 142;
            int y = lblRobot.Top - 142;
            lblCoord.Text = "{ " + x + " , " + y + " }";
        }

        public void HandleRangeExceeded()
        {
            //react to range limit exceeded event
            MessageBox.Show("The robot can't go more than 100 units from center.");
        }
    }
}
