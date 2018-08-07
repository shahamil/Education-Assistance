/*
 * Name: Create Course Enrollment Form
 * Group Name: Shayan, Ramie, Amil and Moeen
  * Date: January 23, 2012
 * Purpose: Enrolls teachers and students to the registered courses in the database. 
 * 
 * Author:  Ramie
 *          Shayan
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
    public partial class frmManageCourseEnrollment : Form
    {
        // The course that is being managed for enrollment
        private Course c;
        // Array created for student names
        string[] studentNameList = new string[Config.MAX_STUDENTS_IN_CLASS];

        public frmManageCourseEnrollment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // course ID is converted to an integer
            int cID = Convert.ToInt32(txtCourseID.Text);

            // course that is being managed is assigned a value
            c = DatabaseConnection.getCourse(cID);

            // if course being managed does not equal null
            if (c != null)
            {
                // runs refreshListBox method
                refreshListBox();
            }
            else
            {
                // message box which shows invalid course entered
                MessageBox.Show("INVALID COURSE ID ENTERED");
            }
        }

        private void btnEnrolStudent_Click(object sender, EventArgs e)
        {
            // if student loaded does not equal null
            if (DatabaseConnection.loadStudent(txtStudentID.Text) != null)
            {
                // student is given a temporary variable to be held in
                Student t = DatabaseConnection.loadStudent(txtStudentID.Text);

                // if the course is able to add the student
                if (c.AddStudent(t))
                {
                    // course code is put into a variable
                    string cCode = c.getCourseCode();

                    // the year of the course is put in a variable
                    int year = Convert.ToInt32(cCode.Substring(3, 1));

                    // student is enrolled into course
                    t.enrolStudent(year, t, c.getCourseID());

                    // message box is shown saying student successfully added
                    MessageBox.Show("Student has been successfully added to the class!");
                }

                // makes text box for student ID empty
                txtStudentID.Text = "";
                // course is saved
                DatabaseConnection.saveCourse(c);
                // student is saved
                DatabaseConnection.saveStudent(t);
                // runs refreshListBox method 
                refreshListBox();
            }
            else
            {
                // message box shown that unable to find student in course
                MessageBox.Show("Unable to find student to add in the course");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if student student information is not null
            if (DatabaseConnection.loadStudent(lsboxStudentNames.Text) != null)
            {
                // students are loaded into listbox
                Student t = DatabaseConnection.loadStudent(lsboxStudentNames.Text);

                // if you are able to remove the student from the course
                if (c.RemoveStudent(t))
                {
                    // student is derolled from course
                    t.derolStudent(t, c.getCourseID());
                    // message box shown that student successfully removed
                    MessageBox.Show("Student has been successfully removed from the course.");
                }

                // student is saved
                DatabaseConnection.saveStudent(t);

                // course is saved
                DatabaseConnection.saveCourse(c);

                // runs refreshListBox method
                refreshListBox();
            }
            else
            {
                // message box shown that cannot find student in course to remove
                MessageBox.Show("Unable to find the student in the course to remove");
            }
        }

        /// <summary>
        /// This method refreshes the listbox
        /// </summary>
        private void refreshListBox()
        {
            // student array is created to list all the students in listbox
            Student[] studentList = c.getCourseStudents();

            // clears the names from list box
            lsboxStudentNames.Items.Clear();

            // for loop which goes through student list 
            for (int i = 0; i < studentList.Length; i++)
            {
                // if an index in the array does not equal null
                if (studentList[i] != null)
                {
                    // student number is found and converted to string
                    studentNameList[i] = studentList[i].getStudNumber(studentList[i]).ToString();

                    // new students are added to list
                    lsboxStudentNames.Items.Add(studentNameList[i]);
                }
            }
        }

        private void frmManageCourseEnrollment_Load(object sender, EventArgs e)
        {

            //Collect disposed form info
            System.GC.Collect();

            //Close the form event
            this.Hide();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In course management, you will be able to load courses to the school from the id, create and remove selected studentS.");
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
