/*
 * Name: Manage Marks Form
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 17, 2012
 * Purpose: Allows the teacher to manage the marks of their students in particular courses. 
 * 
 * Author:  Moeen
 *          Ramie
 *          Shayan
 *          Mellissa
 *          Amil
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Media;

namespace RattlerManagement
{
    public partial class frmManageMarks : Form
    {
        //new instance of a course created 
        private Course c;

        //new instance of a student is created 
        private Student[] students = new Student[Config.MAX_STUDENTS_IN_CLASS];

        //intializes manage marks form
        public frmManageMarks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the student array with the student info given from database
        /// </summary>
        /// <param name="s">The student array</param>
        private void setStudentArray(Student[] s)
        {
            //Loop through current student array
            for (int i = 0; i < s.Length; i++)
            {
                //If student is not null
                if (s[i] != null)
                {
                    //Transfer the student
                    students[i] = s[i];
                }
            }
        }

        /// <summary>
        /// This function is used to load the list box
        /// </summary>
        private void loadListBoxes()
        {
            //student name listbox is clear 
            lsbStudentName.Items.Clear();

            //student listbox is clear 
            lstboxStudents.Items.Clear();

            for (int i = 0; i < Config.MAX_STUDENTS_IN_CLASS; i++)
            {
                if (students[i] != null)
                {
                    //stucents added to the listbox
                    lstboxStudents.Items.Add(students[i].getStudNumber(students[i]).ToString());

                    //names of students added to listbox 
                    lsbStudentName.Items.Add(students[i].getStudFirstName(students[i]) + " " + students[i].getStudLastName(students[i]));
                }
            }
        }


        private void frmManageMarks_Load(object sender, EventArgs e)
        {
            //label displays text as the user prompt
            lblInformation.Text = "This is where you input the marks for your students \n" +
                "the format for the marks \nis (student mark)/(total mark) for each " +
                "summative that was given \nYou can leave it blank if there was no mark needed";


            c = Config.getTCourse();
            setStudentArray(c.getCourseStudents());

            //Loads listboxes
            loadListBoxes();

            //each textbox for each section of the overall mark is equal to 0/0 by default
            txt_TI.Text = "0/0";

            txt_KU.Text = "0/0";

            txt_Culm.Text = "0/0";

            txt_Comm.Text = "0/0";

            txt_Application.Text = "0/0";

            txt_Exams.Text = "0/0";



        }

 
        private void btnUpdateMark_Click(object sender, EventArgs e)
        {
            /*
             * This updates the students marks
             */
            //See if the student selected exists in the database
            if (DatabaseConnection.loadStudent(lstboxStudents.Text) != null)
            {
                //Go through teh students array
                for (int i = 0; i < students.Length; i++)
                {
                    //Initialize the studentmark information array
                    string[] studentMarkInfo = {txt_KU.Text, txt_TI.Text, txt_Comm.Text,
                                                            txt_Application.Text, txt_Culm.Text,
                                                            txt_Exams.Text};

                    //If the marks were entered in correct format
                    if (studentMarkInfo[i].Contains('/'))
                    {
                        if (students[i] != null)
                        {
                            //Get the student number and see if it matches with lstbox text
                            if (students[i].getStudNumber(students[i]).ToString() == lstboxStudents.Text)
                            {

                                //Loop through the values of the student 2d mark array
                                for (int iz = 1; iz < 7; iz++)
                                {
                                    //Set the student marks with the first 7 indexes from the student mark array
                                    //and the last 7 indexes from 2D array
                                    c.setStudentMark(iz, students[i], studentMarkInfo[iz - 1]);
                                }

                                //Set the student total mark for the current student
                                c.setStudentTotalMark(students[i]);

                                //break out of loop since student was found
                                break;

                            }
                        }
                    }
                    else
                    {
                        //Warn user mark entered in wrong format
                        MessageBox.Show("Mark was entered in wrong format");
                        break;
                    }


                }
            }
            else
            {

                //If student isnt selected
                MessageBox.Show("Please select a student for which to update the marks!");
            }

            //saves courses into the database
            DatabaseConnection.saveCourse(c);


        }

        private void lstboxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //refreshes the page
            refreshPage();
            lsbStudentName.SelectedIndex = lstboxStudents.SelectedIndex;  
        }

        /// <summary>
        /// This function is used to refresh the page (Refresh the contents of the listbox
        /// </summary>
        private void refreshPage()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    if (students[i].getStudNumber(students[i]).ToString() == lstboxStudents.Text)
                    {
                        //the mark for each section is displayed on a label 

                        lbl_KUShow.Text = "K/U MARK: " + c.getStudentMark(1, students[i]);
                        lblTIShow.Text = "T/I MARK: " + c.getStudentMark(2, students[i]);
                        lbl_CommShow.Text = "COM MARK: " + c.getStudentMark(3, students[i]);
                        lbl_AppShow.Text = "APP MARK: " + c.getStudentMark(4, students[i]);

                        lbl_CulmShow.Text = "CULM MARK: " + c.getStudentMark(5, students[i]);
                        lbl_ExamShow.Text = "EXAM MARK: " + c.getStudentMark(6, students[i]);

                        //students total mark is displayed on a label 
                        lblTotalMark.Text = "TOTAL MARK: " + c.getStudentMark(7, students[i]);


                        //information related to the student is displayed on the label 
                        lblSFirstName.Text = "F Name: " + students[i].getStudFirstName(students[i]);
                        lblsLastName.Text = "L Name: " + students[i].getStudLastName(students[i]);
                        lblSEmail.Text = "Email: " + students[i].getStudEmail(students[i]);
                        lblsDOB.Text = "DOB: " + students[i].getDOB(students[i]);
                        lblSGrade.Text = "Grade: " + students[i].getstudGrade(students[i]).ToString();
                        lblSParentName.Text = "Parent: " + students[i].getStudParentName(students[i]);
                        lblSPhoneNumber.Text = "Phone: " + students[i].getStudParentPhone(students[i]);
                        lblSHomeAddress.Text = "Address: " + students[i].getStudHomeAddress(students[i]);

                        try
                        {
                            //picturebox is enabled 
                            pctBoxStudent.Enabled = true;


                            pctBoxStudent.Image = resizeImage(Image.FromFile("students/" + students[i].getStudNumber(students[i]).ToString() + ".jpg"), new Size(150, 100));

                        }
                        catch (Exception e)
                        {
                            //exception error e is written 
                            Console.WriteLine(e);
                        }
                        break; //breaks out of the try and catch 

                    }
                }
            }
        }



        private void btnSortCourses_Click(object sender, EventArgs e)
        {
            //Go loop through the amount of sources
            for (int y = 0; y < c.getAmountOfStudents(); y++)
            {
                //We will use bubble sort in this case
                for (int j = y + 1; j < c.getAmountOfStudents(); j++)
                {
                    //If the next index is greater than the other one then shift
                    if (Convert.ToInt32(c.getStudentMark(7, students[y])) <
                        Convert.ToInt32(c.getStudentMark(7, students[j])))

                    {
                        //Set a student temporary variable
                        Student t = students[y];

                        //Swap the students
                        students[y] = students[j];

                        //Set the student
                        students[j] = t;

                    }
                }


            }

            //Reload listbox values
            loadListBoxes();
        }


        /***********************NOT MY CODE, GOT FROM STACK OVERFLOW*****************************/
        /// <summary>
        /// This function resizes the image
        /// </summary>
        /// <param name="imgToResize"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        private static Image resizeImage(Image imgToResize, Size size)
        {

            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        private void frmManageMarks_FormClosing(object sender, FormClosingEventArgs e)
        {


            //Collect disposed form info
            System.GC.Collect();

            //Close the form event
            this.Hide();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the student mark management, you are able to see students' marks, information and be able to submit a mark. You may also sort the marks.");
        }

        private void grpStudentInformation_Enter(object sender, EventArgs e)
        {

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

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        /*************************************************************************************/


    }
}