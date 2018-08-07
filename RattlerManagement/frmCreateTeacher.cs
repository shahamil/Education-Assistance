/*
 * Name: Create Teacher Form 
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 22, 2012
 * Purpose: To create a new teacher in order to teach particular registered courses and manage students. 
 * 
 * Author:  Shayan
 *          Amil
 *          Ramie
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
    public partial class frmCreateTeacher : Form
    {
        public frmCreateTeacher()
        {
            InitializeComponent();  
            // form is initialized
        }

        // course array is created to hold the courses
        private Course[] courses = new Course[Config.MAX_SCHOOL_CLASSES];

        // string array is created to hold teachers for a course
        private string[] tCourses = new string[Config.MAX_COURSES_PER_TEACHER];

        private void txt_tNumber_TextChanged(object sender, EventArgs e)
        {
            // limits the character length
            txt_tNumber.MaxLength = 9;
        }

        private void txt_tLastName_TextChanged(object sender, EventArgs e)
        {
            // limits the character length
            txt_tLastName.MaxLength = 32;
        }

        private void txt_tFirstName_TextChanged(object sender, EventArgs e)
        {
            // limits the character length
            txt_tFirstName.MaxLength = 32;
        }

        private void txt_tPass_TextChanged(object sender, EventArgs e)
        {
            // limits the character length
            txt_tPass.MaxLength = 255;
        }

        private void txt_tEmail_TextChanged(object sender, EventArgs e)
        {
            // limits the character length
            txt_tEmail.MaxLength = 255;
        }

        private void bttn_NewTeacher_Click(object sender, EventArgs e)
        {

            // if the email contains the character '@'
            if (txt_tEmail.Text.Contains('@') && (Config.TryToParse(txt_tNumber.Text)))
            {
                // for loop which goes through the courses per teacher
                for (int i = 0; i < Config.MAX_COURSES_PER_TEACHER; i++)
                {
                    // assigns the value "0" to each index
                    tCourses[i] = "0";
                }

                // variable created to return for try parse
                int retComp;

                // if the try parse is successful
                if (Int32.TryParse(txt_tNumber.Text, out retComp))
                {
                    // adds teacher information to the database
                    DatabaseConnection.insertTeacher(retComp, txt_tFirstName.Text,
                                        txt_tLastName.Text, txt_tPass.Text, txt_tEmail.Text, tCourses);


                    txt_tNumber.Text = "";
                    txt_tLastName.Text = "";
                    txt_tFirstName.Text = "";
                    txt_tEmail.Text = "";
                    txt_tPass.Text = "";
                    
                    MessageBox.Show("Teacher saved successfully!");

                }
            }
            else
            {
                MessageBox.Show("INVALID TEXT ENTERED");
            }
        }

        private void frmCreateTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Collect disposed form info
            System.GC.Collect();

            //Close the form event
            this.Hide();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create a new teacher by filling out the required information of the new teacher and clicking the create new teacher button");
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
