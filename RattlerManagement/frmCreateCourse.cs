/*
 * Name: Create Course Form 
 * Group Name: Shayan, Ramie, Amil, and Moeen
 * Date: January 26, 2012
 * Purpose: Allows new courses to be created in which students can enroll in. 
 * 
 * Author:  Ramie
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
    public partial class frmCreateCourse : Form
    {
        public frmCreateCourse()
        {
            InitializeComponent();  // component is initialized
        }

        private void txt_cCode_TextChanged(object sender, EventArgs e)
        {
            // limit is set on input
            txt_cCode.MaxLength = 6;
        }

        private void txt_cID_TextChanged(object sender, EventArgs e)
        {
            // limit is set on input
            txt_cID.MaxLength = 8;
        }

        private void txt_cTeacher_TextChanged(object sender, EventArgs e)
        {
            // limit is set on input
            txt_cTeacher.MaxLength = 32;
        }

        /// <summary>
        /// This method checks to see if correct information is entered
        /// </summary>
        /// <returns></returns>
        private Boolean infoIsCorrect()
        {
            // text box is created which goes through all the textboxes on the form
            TextBox[] formTxtBoxes = {txt_cAp,txt_cComm,txt_cCulm,txt_cExam,
                                   txt_cID,txt_cKU,txt_cTeacher, txt_cTI,
                                    txt_CourseRoom, txt_cCode};

            // for loop which goes through the textboxes
            for (int i = 0; i < formTxtBoxes.Length; i++)
            {
                // if the textboxes are empty or have a null value
                if (formTxtBoxes[i].Text == null || formTxtBoxes[i].Text == "")
                {
                    // false is returned
                    return false;
                }
            }

            // for loop which goes through the the textboxes 
            for (int i = 0; i < formTxtBoxes.Length - 1; i++)
            {
                // if textboxes parsed are not integers
                if (!Config.TryToParse(formTxtBoxes[i].Text))
                {
                    // false is returned
                    return false;
                }
            }

            // true is returned
            return true;
        }

        private void bttn_CreateNewCourse_Click(object sender, EventArgs e)
        {
            // if info is correct
            if (infoIsCorrect())
            {
                prgCourseSaver.Value += 2;
                // string array is created for dummy values
                string[] dummyValues = new string[Config.MAX_STUDENTS_IN_CLASS];
                // string array is created for student list
                string[] cStudentList = new string[Config.MAX_STUDENTS_IN_CLASS];
                // string array is created for student marks
                string[] cStudentMarks = new string[Config.MAX_STUDENTS_IN_CLASS];
                prgCourseSaver.Value += 2;
                // for loop which goes through students in class
                for (int i = 0; i < Config.MAX_STUDENTS_IN_CLASS; i++)
                {
                    // assigns null values to dummy values, student list and student marks since no entries yet
                    dummyValues[i] = "0/0";
                    cStudentList[i] = "na";
                    cStudentMarks[i] = "0";
                }
                prgCourseSaver.Value += 2;

                // This takes the information entered and sets it in the database
                DatabaseConnection.insertCourse(Convert.ToInt32(txt_cID.Text), txt_cCode.Text, txt_cTeacher.Text,
                                                cStudentList, cStudentMarks,
                                                Convert.ToDouble(txt_cKU.Text), Convert.ToDouble(txt_cTI.Text),
                                                Convert.ToDouble(txt_cComm.Text), Convert.ToDouble(txt_cAp.Text),
                                                Convert.ToDouble(txt_cCulm.Text), Convert.ToDouble(txt_cExam.Text),
                                                dummyValues, dummyValues, dummyValues,
                                                dummyValues, dummyValues, dummyValues, txt_CourseRoom.Text);

                prgCourseSaver.Value += 2;
                // if the course ID is not null
                if (DatabaseConnection.getCourse(Convert.ToInt32(txt_cID.Text)) != null)
                {
                    prgCourseSaver.Value += 2;
                    // message box showing successfully saved
                    MessageBox.Show("SUCCESSFULLY SAVED");
                }
                else
                {
                    prgCourseSaver.Value += 2;
                    // message box shown not successfuly saved
                    MessageBox.Show("SUCCESSFULLY NOT SAVED");


                }
                prgCourseSaver.Value = 0;

            }

            else
            {
                // message box shows that not everything is not entered correctly
                MessageBox.Show("Some of the fields are incorrectly entered");

                prgCourseSaver.Value = 0;
            }
        }

        private void btnCourseEdit_Click(object sender, EventArgs e)
        {
            // form for manage course enrollment is created
            frmManageCourseEnrollment fMCE = new frmManageCourseEnrollment();
            // the form is activated
            fMCE.Activate();
            // the form is shown
            fMCE.Show();

        }

        private void frmCreateCourse_Load(object sender, EventArgs e)
        {
            prgCourseSaver.Minimum = 0;
            prgCourseSaver.Maximum = 10;
            prgCourseSaver.Value = 0;
        }

        private void frmCreateCourse_FormClosing(object sender, FormClosingEventArgs e)
        {            
            


            //Collect disposed form info
            System.GC.Collect();

            //Close the form event
            this.Hide();


        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create a new course by entering the required information and clicking the create new course button. You can also go to the course enrollment management");
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
    }
}
