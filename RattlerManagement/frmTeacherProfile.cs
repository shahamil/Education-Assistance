/*
 * Name: Teacher Profile Form 
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 22, 2012
 * Purpose: To display information about the teacher reagarding about their courses. 
 * 
 * Author:  Moeen
 *          Ramie
 *          Mellissa
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RattlerManagement
{
    public partial class frmTeacherProfile : Form
    {
        private Teacher t;
        //New instance of teacher
        //Gathers teacher information

        public frmTeacherProfile()
        {
            //Gets the teacher's information
            t = Config.getTTeacher();

            //Initialize the form
            InitializeComponent();
        }




        private void frmTeacherProfile_Load(object sender, EventArgs e)
        {

            //Goes through all courses and adds onto the list box
            for (int i = 0; i < t.getTeacherCourses().Length; i++)
            {
                //If the course exist
                if (t.getTeacherCourse(i) != null)
                {
                    //Add the course to the listbox
                    lsb_Courses.Items.Add(t.getTeacherCourse(i).getCourseID().ToString());//A course is added to the list box 
                }
            }

            //Teacher related information 

            lbl_tID.Text = "Teacher ID: " + t.getTeacherNumber().ToString(); 
            //Displays the teacher's number

            lbl_tName.Text = "Teacher Name: " + t.getTeacherName();
            //Displays the teacher's name 

        }

        private void btnManageCourse_Click(object sender, EventArgs e)
        {


            //This for loop will scan through the courses and find a course to manage the marks of
            for (int i = 0; i < t.getTeacherCourses().Length; i++)
            {

                //If a course exists in the teacher course array
                if (t.getTeacherCourse(i) != null)
                {

                    //manage the courses if name is same as the one in listbox
                    if (t.getTeacherCourse(i).getCourseID().ToString() == lsb_Courses.Text)
                    {

                        frmManageMarks mC = new frmManageMarks();
                        //create new instance of the manage marks form

                        mC.Activate(); 
                        //activates the particular form

                        Config.setTCourse(t.getTeacherCourse(i));

                        mC.Show(); 
                        //the manage marks for is displayed

                        break;
                        //breaks out of the for loop
                    }
                }
            }
        }

        private void btn_EmailTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Service to be added soon"); 
            //Button Click on email took sends messagebox
        }

        private void btn_EquipRental_Click(object sender, EventArgs e)
        {
            /*
             * IMPORTANT ---- READ MR HSIUNG .
             * 
             * There was some stupid damn error with this and me and moeen spent
             * around 2 hours and we couldnt even find the problem. We gave up on it, 
             * and melissa even tried. So instead of this we decided to make contact IT 
             * department form instead.
             */
            MessageBox.Show("We have not decided to add this feature to our program");

            /*************************
            frmToolRental fTR = new frmToolRental(); 
            //new intance of the tool rental form is created

            Config.setTTeacher(t);
            //current teacher is set

            fTR.Activate();
            //tool rental form is activated

            fTR.Show();
            //tool rental form is shown/displayed
             * **************/

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //message box appears which shows what the program is about
            MessageBox.Show("Created by students for teachers!", "About Us"); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The application closes
            Application.Exit(); 
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asdfasd", ""); 
            //Message box is displayed
        }

        private void frmTeacherProfile_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Collect disposed form info
            System.GC.Collect();

            //Close the form event
            this.Hide();
        }

        private void howToUseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("On the teacher's profile, you can go to equipment rental, check your email and go to your courses");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New instance for a login form
            frm_LoginPage tP = new frm_LoginPage();
            tP.Activate();
            tP.Show();
            this.Dispose();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Program created by Amil S, Ramie R, Moeen M, Melissa M, Shayan G");
        }

    }
}