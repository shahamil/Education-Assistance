/*
 * Name: Create Student Form
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 26, 2012
 * Purpose: Creates a new student into the system which is applicable to enroll into particular courses/classes.
 * 
 * Author:  Mellissa
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
    public partial class frmCreateStudent : Form
    {
        public frmCreateStudent()
        {
            // initializes form
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // limit put on characters
            txt_sDateOfBirth.MaxLength = 9;
        }

        private void txt_sUsername_TextChanged(object sender, EventArgs e)
        {
            // limit put on characters
            txt_sNumber.MaxLength = 10;
        }

        private void txt_sLastName_TextChanged(object sender, EventArgs e)
        {
            // limit put on characters
            txt_sLastName.MaxLength = 32;
        }

        private void txt_sFirstName_TextChanged(object sender, EventArgs e)
        {
            // limit put on characters
            txt_sFirstName.MaxLength = 32;
        }

        private void txt_sPass_TextChanged(object sender, EventArgs e)
        {
            // limit put on characters
            txt_sPass.MaxLength = 255;
        }

        private void txt_sEmailAddress_TextChanged(object sender, EventArgs e)
        {
            // limit put on characters
            txt_sEmailAddress.MaxLength = 255;
        }

        private void txt_sAddressHome_TextChanged(object sender, EventArgs e)
        {
            // limit put on characters
            txt_sAddressHome.MaxLength = 32;
        }

        private void txt_sPNumber_TextChanged(object sender, EventArgs e)
        {
            // limit put on characters
            txt_sPNumber.MaxLength = 11;
        }

        private void txt_sParentName_TextChanged(object sender, EventArgs e)
        {
            // limit put on characters
            txt_sParentName.MaxLength = 32;
        }

        public int formGoodText()
        {
            // textbox array is created which holds all the text boxes to fill in on the form
            TextBox[] formText = {txt_sDateOfBirth,txt_sNumber,
                                     txt_sGrade,txt_sPNumber,txt_sAddressHome,txt_sEmailAddress,
                                     txt_sFirstName,txt_sLastName,
                                     txt_sParentName, txt_sPass,};

            // for loop which goes through the arrays and checks the text boxes
            for (int i = 0; i < formText.Length; i++)
            {
                // if the text box is empty
                if (formText[i].Text == "")
                {
                    // returns 1
                    return 1;
                }
            }

            // for loop which goes through the entries to see if the entries required to be integer are integer or not
            for (int i = 0; i < 3; i++)
            {
                // if it does not pass the try parse test
                if (!Config.TryToParse(formText[i].Text))
                {
                    // returns 2
                    return 2;
                }
            }

            // returns 0 if everything is fine
            return 0;
        }

        private void bttn_NewStudent_Click(object sender, EventArgs e)
        {
            switch (formGoodText())
            {
                // if case 1
                case 1:

                    // shows message box saying something was left blank
                    MessageBox.Show("You left a textbox blank",
                    "Invalid Information Supplied", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                    break;

                // if case 2
                case 2:

                    // shows message boxing saying a textbox was not entered with numbers
                    MessageBox.Show("A required text field was not entered in numbers",
                    "Invalid Information Supplied", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                    break;

                // if case 0
                case 0:

                    // creates array for courses for student
                    string[,] sCourses = new string[Config.MAX_STUDENT_YEARS, Config.MAX_STUDENT_COURSES];
                    // creates array for comments for student
                    string[,] sComments = new string[Config.MAX_STUDENT_YEARS, Config.MAX_STUDENT_COMMENTS];

                    // for loop which goes through the student years
                    for (int i = 0; i < Config.MAX_STUDENT_YEARS; i++)
                    {
                        // for loop which goes through the student courses
                        for (int z = 0; z < Config.MAX_STUDENT_COURSES; z++)
                        {
                            // sets value to none since there are no courses yet
                            sCourses[i, z] = "none";
                        }
                        // for loop which goes through the student comments
                        for (int z = 0; z < Config.MAX_STUDENT_COMMENTS; z++)
                        {
                            // sets comments to none since there are no comments yet
                            sComments[i, z] = "none";
                        }
                    }

                    // Adds information to database
                    DatabaseConnection.insertStudent(Convert.ToInt32(txt_sNumber.Text), txt_sPass.Text,
                        txt_sFirstName.Text, txt_sLastName.Text, txt_sDateOfBirth.Text, Convert.ToInt32(txt_sGrade.Text),
                        txt_sEmailAddress.Text, txt_sParentName.Text, txt_sPNumber.Text, txt_sAddressHome.Text, sCourses,
                        sComments);

                    // if none of the entries equal null
                    if (DatabaseConnection.loadStudent(txt_sNumber.Text) != null)
                    {
                        // message box showing successfully registered
                        MessageBox.Show("Student Successfully Registered");
                    }
                    else
                    {
                        // message box showing failure to register
                        MessageBox.Show("FAILURE To Register");
                    }

                    // principal panel is loaded
                    frmPrincipalPanel fPP = new frmPrincipalPanel();

                    // principal panel is activated
                    fPP.Activate();

                    // principal panel is shown
                    fPP.Show();

                    // principal panel is closed
                    this.Close();

                    break;
            }
        }

        private void frmCreateStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Create a new principal panel form
            frmPrincipalPanel pP = new frmPrincipalPanel();
            pP.Activate();
            pP.Show();

            //Collect disposed form info
            System.GC.Collect();

            //Close the form event
            this.Hide();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create a new student by filling out the required information and clicking the create new student button.");
        }

        private void frmCreateStudent_Load(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
