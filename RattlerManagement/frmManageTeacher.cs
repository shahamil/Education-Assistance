/*
 * Name: Manage Teacher Form 
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 20, 2012 
 * Purpose: To give principle access to the teachers registered in the system.  
 * 
 * Author:  Ramie
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace RattlerManagement
{
    public partial class frmManageTeacher : Form
    {
        // new teacher array is created for teacher list
        private Teacher[] teacherList = new Teacher[Config.MAX_SCHOOL_TEACHERS];

        public frmManageTeacher()
        {
            InitializeComponent();  // form is initialized

            prgbarTeacherLoad.Maximum = 10000;  // progress bar maximum value is set
            prgbarTeacherLoad.Minimum = 0;      // progress bar minimum value is set
        }

        private void frmManageTeacher_Load(object sender, EventArgs e)
        {
            // when form is opened, teacher array is loaded so that managing of teachers can be done
            loadTeacherArray();

            // for loop which goes through the teacher list 
            for (int i = 0; i < teacherList.Length; i++)
            {
                // Teacher name is added to list box
                lstboxTeachers.Items.Add(teacherList[i].getTeacherName());
            }

        }

        private void btnFireTeacher_Click(object sender, EventArgs e)
        {
            
            
            // for loop which goes through teacher list 
            for (int i = 0; i < teacherList.Length; i++)
            {
                // if teacher name selected is the same as the teacher box in the array index
                if (teacherList[i].getTeacherName() == lstboxTeachers.Text)
                {
                    // Fires teacher 
                    DatabaseConnection.fireTeacher(teacherList[i]);

                    //Show that the teacher is fired
                    MessageBox.Show("Teacher Fired");

                    //Clear the list box
                    lstboxTeachers.Items.Clear();


                    // for loop which goes through the teacher list 
                    for (int z = 0; z < teacherList.Length; i++)
                    {
                        // Teacher name is added to list box
                        lstboxTeachers.Items.Add(teacherList[i].getTeacherName());
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// This method will load the teacher arrays
        /// </summary>
        private void loadTeacherArray()
        {
            // variable for ammount of teachers
            int arCounter = 0;

            // for loop which goes from 1-100
            for (int i = 0; i < Config.MAX_SCHOOL_TEACHERS; i++)
            {
                //If the teacher is not a nulled object (Teacher exists)
                if (DatabaseConnection.getTeacher(i) != null)
                {
                    // Get the database teacher and add it to array counter index of the teacher array
                    teacherList[arCounter] = DatabaseConnection.getTeacher(i);


                    //Add array counter
                    arCounter++;
                }

                // Add value to the teacherbox progressbar
                prgbarTeacherLoad.Value += 1;
            }

        }

        private void frmManageTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
 

            //Collect disposed form info
            System.GC.Collect();

            //Close the form event
            this.Hide();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
