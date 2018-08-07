
/*
 * Name: Student Profile Form
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 23, 2012
 * Purpose: To display the student related information, for example: marks, courses and personal information.
 * 
 * Author:  Moeen
 *          Ramie
 *          Shayan
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RattlerManagement
{
    public partial class frmStudentProfile : Form
    {
        //new instance of a student is declared 
        private Student m;

        //new instance of a course is created 
        private Course[] studCourseList = new Course[Config.MAX_STUDENT_COURSES];

        //intializes the student profile form 
        public frmStudentProfile()
        {
            InitializeComponent();

            //progress bar value is set to zero 
            this.prgbrPasswordChanger.Value = 0;
        }

        private void frmStudentProfile_Load(object sender, EventArgs e)
        {

            m = Config.getStudent();
            //loads the courses
            loadCourses();

            //nothing set to the contact info
            lblContactInfo.Text = "";

            //noting set to the contact info
            lblMarkDisplay.Text = "";

            //label shows the students first and last name 
            lblSName.Text = m.getStudFirstName(m) + " " + m.getStudLastName(m);

            //label shows what grade he is in
            lblGrade.Text = "Grade: " + m.getstudGrade(m).ToString();
        }


        //method form loading the courses
        private void loadCourses()
        {
            //course counter set to zero
            int cCounter = 0;

            for (int i = 0; i < Config.MAX_STUDENT_YEARS; i++)
            {
                for (int z = 0; z < Config.MAX_STUDENT_COURSES; z++)
                {
                    if (m.getStudentCourses(i, z, m) != "none")
                    {
                        //students added to the list box 
                        lstboxCourses.Items.Add(m.getStudentCourses(i, z, m));

                        //the students are loaded from the database
                        studCourseList[cCounter] =
                            DatabaseConnection.getCourse(Convert.ToInt32(m.getStudentCourses(i, z, m)));
                        if (prgbrPasswordChanger.Maximum - prgbrPasswordChanger.Value > 0)
                        {
                            //progress bar value increase by one 
                            prgbrPasswordChanger.Value++;
                        }

                        //counter increased by one 
                        cCounter++;
                    }

                }

            }
            //Message box displayed showing regarding courses loaded
            MessageBox.Show("Loaded Courses", "Courses Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //progress bar value set to zero
            this.prgbrPasswordChanger.Value = 0;

        }




        private void lstboxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            //goes through the all students in a paticular course 
            for (int i = 0; i < studCourseList.Length; i++)
            {
                if (studCourseList[i].getCourseID().ToString() == lstboxCourses.Text)
                {
                    //label showing the students marks 
                    lblMarkDisplay.Text = studCourseList[i].getStudentMark(7, m) + "%";

                    //label showing te contact information
                    lblContactInfo.Text = DatabaseConnection.getTeacher(studCourseList[i].getCourseTeacher()).getTeacherEmail();

                    //breaks out of the if statment 
                    break;

                }
            }

        }

        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {

            //progressbar value set to zero
            this.prgbrPasswordChanger.Value = 2;
            if ((txtboxNewPassword.Text != "") ||
                (txtboxNewPassword.Text.ToLower() == m.getStudPassword(m).ToLower()))
            {
                //progress bar value is increased by one 
                this.prgbrPasswordChanger.Value += 2;

                m.setStudPassword(txtboxNewPassword.Text);

                //progress bar value increased
                this.prgbrPasswordChanger.Value += 2;

                //student saved into the database
                DatabaseConnection.saveStudent(m);

                //progress bar value is maximum 
                this.prgbrPasswordChanger.Value = this.prgbrPasswordChanger.Maximum;

                //message box regarding the changing password is displayed 
                MessageBox.Show("Password Successfully Changed", "Password Changed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.prgbrPasswordChanger.Value = 0;
            }
            else
            {

                //progress bar at its max value 
                this.prgbrPasswordChanger.Value = this.prgbrPasswordChanger.Maximum;

                //coulur of progress bar set to red 
                this.prgbrPasswordChanger.BackColor = Color.Red;

                //message box displayed regarding about an error with password 
                MessageBox.Show("Invalid Password Entry \na) You have not entered anything" +
                "\nb) You entered your current password" +
                "\nc) Password is not strong enough", "Password Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.prgbrPasswordChanger.Value = 0;
            }
        }

        private void frmStudentProfile_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Collect disposed form info
            System.GC.Collect();

            //Close the form event
            this.Hide();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the student's profile, you can view your courses, see your marks, contact your teacher and you can also change password.");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New instance for a login form
            frm_LoginPage tP = new frm_LoginPage();
            tP.Activate();
            tP.Show();
            this.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program created by Amil S, Ramie R, Moeen M, Melissa M, Shayan G");
        }




    }
}