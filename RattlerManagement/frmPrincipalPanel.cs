/*
 * Name: Principle Panel Form 
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 25, 2012
 * Purpose: Allow the principle to have options to performing specific actions and tasks by directing to specific forms.
 * 
 * Author:  Amil
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
    public partial class frmPrincipalPanel : Form
    {
        //instance of essential forms are created 
        private frmCreateTeacher frm_Teacher = new frmCreateTeacher();      //new instance of the teacher panel form is created
        private frmCreateStudent frm_Student = new frmCreateStudent();      //new instance of the student panel form is created
        private frmCreateObject frm_Object = new frmCreateObject();         //new instance of the object panel form is created
        private frmCreateCourse frm_Course = new frmCreateCourse();         //new instance of the course panel form is created

        public frmPrincipalPanel()
        {
            InitializeComponent();
        }



        private void bttn_Go_Click(object sender, EventArgs e)
        {
            if (rdb_CreateTeacher.Checked == true)
            {
                frm_Teacher.Activate();     //teacher form is activated 
                frm_Teacher.Show();         //teacher form is displayed
                this.Hide();                //current form is hidden 
            }

            else if (rdb_CreateStudent.Checked == true)
            {
                frm_Student.Activate();     //student form is created 
                frm_Student.Show();         //student form is displayed
                this.Hide();                //current form is hidden 
            }

            else if (rdb_NewObject.Checked == true)
            {
                frm_Object.Activate();      //object form activated 
                frm_Object.Show();          //object form is shown 
                this.Hide();                //current form is dis played
            }

            else if (rdb_NewCourse.Checked == true)
            {
                frm_Course.Activate();      //course for is activated 
                frm_Course.Show();          //course form is shown 
                this.Hide();                //current form is hidden 
            }
            else if (rdb_FireTeacher.Checked == true)
            {

                frmManageTeacher frm_Manage = new frmManageTeacher();       //new instance of the manage marks form is created
                frm_Manage.Activate();                                      //manange form is displayed 
                frm_Manage.Show();                                          //manage form is displayed 
                this.Hide();                                                //current form is hidden 
            }
            else
            {
                MessageBox.Show("Please enter one the options");            //Message box displayed regarding about the options
            }

        }

        private void returnToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LoginPage fLP = new frm_LoginPage(); //new instance of a login form is created 
            fLP.Activate();     //login form is activated 
            fLP.Show();         //login form is displayed
            this.Dispose();     //current form is disposed 
        }

        private void frmPrincipalPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Create a new login form
            frm_LoginPage pP = new frm_LoginPage();
            pP.Activate();
            pP.Show();

            //Collect disposed form info
            System.GC.Collect();

            //Close the form event
            this.Hide();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("As the principal, you can create a new teacher, student, object, course or fire a teacher. Select the option you want and click GO");
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

        private void frmPrincipalPanel_Load(object sender, EventArgs e)
        {

        }

  

    }
}