using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GilesLab4
{
    public partial class frmDisplay : Form
    {
        Robot robot = new Robot();//instantiate Robot robot;

        //on form display, intialize, set to middle, and face north
        public frmDisplay()
        {
            InitializeComponent();
            lblRobot.Text = robot.FaceNorth();
            lblRobot.Location = new Point(142, 142);
        }

        //handle N/S/E/W button clicks by calling robot methods
        private void button1_Click(object sender, EventArgs e)
        {
            lblRobot.Text = robot.FaceNorth();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            lblRobot.Text = robot.FaceSouth();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            lblRobot.Text = robot.FaceEast();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            lblRobot.Text = robot.FaceWest();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //on movement button clicks, call robot bethods to get direction, move robot, and update coordinates
        public void btnOne_Click(object sender, EventArgs e)
        {
            string direction = robot.GetDirection(lblRobot.Text);
            robot.Move(direction, 1, lblRobot);
            robot.setCoord(lblCoord, lblRobot);
        }
        public void btnTen_Click(object sender, EventArgs e)
        {
            string direction = robot.GetDirection(lblRobot.Text);
            robot.Move(direction, 10, lblRobot);
            robot.setCoord(lblCoord, lblRobot);           
        }
    }
}
