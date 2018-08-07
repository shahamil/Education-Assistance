/*
 * Name: Contact Information Form
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 21, 2012
 * Purpose: To allow teachers, students and IT deparment to contact each other.  
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
using System.Web;
using System.Net.Mail;
namespace RattlerManagement
{
    public partial class frmContactIT : Form
    {

        //An array of the school teachers
        Teacher[] schoolTeachers;

        //A random number generator
        static Random rng = new Random();

        //The captcha answer
        int answer = 0;

        //Captcha variables x and y
        int x, y;

        //The student (If someone is logged in)
        Student pS;

        //The teacher (If someone is logged in)
        Teacher pT;

        /// <summary>
        /// This form allows the user to contact the IT department of the institution
        /// </summary>
        public frmContactIT()
        {
            InitializeComponent();

            //If a student is logged in
            if (Config.getStudent() != null)
            {
                //This student object is the student logged in
                this.pS = Config.getStudent();
            }

            //If a teacher is logged in
            if (Config.getTTeacher() != null)
            {
                //Load the logged in teacher
                this.pT = Config.getTTeacher();
            }
        }

        /// <summary>
        /// This function is used to load the contacts at the beginning of the program
        /// </summary>
        public void LoadContacts()
        {
            //The legitimate teacher count
            int legitTeacherCount = 0;

            //The teachers are the student teachers that are stored in a temporary array
            Teacher[] studentTeachers = new Teacher[Config.MAX_SCHOOL_TEACHERS];


            //Load all the teachers and store them in studentteacher array
            for (int i = 0; i < Config.MAX_SCHOOL_TEACHERS; i++)
            {
                //If the database loads a valid teacher
                if (DatabaseConnection.getTeacher(i) != null)
                {
                    //Get theteacher
                    studentTeachers[i] = DatabaseConnection.getTeacher(i);

                    //Increase the legitTeachercount
                    legitTeacherCount++;
                }
            }

            //initialize the schoolteacher array with the legitimate teacher count
            schoolTeachers = new Teacher[legitTeacherCount];

            //A counter to keep track of the other teacher array
            int sTCount = 0;

            //Go through the student teacher array
                for (int i = 0; i < studentTeachers.Length; i++)
                {
                    //If there is a teacher that exists 
                    if (studentTeachers[i] != null)
                    {
                        //School teacher is going to be the student teacher of that index
                        schoolTeachers[sTCount] = studentTeachers[i];

                        //stCount is added
                        sTCount++;
                    }

                }
        
            
        }

        /// <summary>
        /// Display the list of teachers on the listbox
        /// </summary>
        private void displayTeacherList()
        {
            //Clear the listbox first!
            lsbContactList.Items.Clear();

            //Keep the schoolteachers looping
            for (int i = 0; i < schoolTeachers.Length; i++)
            {
                //If a schoolteacher exists
                if (schoolTeachers[i] != null)
                {
                    //Add the schoolteacher name to listbox
                    lsbContactList.Items.Add(schoolTeachers[i].getTeacherName());
                }
            }


        }


        private void frmContactIT_Load(object sender, EventArgs e)
        {
            //Load contacts, captcha and display teacher list
            //LoadContacts();
            loadCaptcha();
            displayTeacherList();
        }
               
        /// <summary>
        ///  Load "Captcha" <-- Really isn't captcha though :p
        /// </summary>
        private void loadCaptcha()
        {
            //Generate a random number
           this.x = rng.Next(1, 10);
           this.y = rng.Next(1, 10);

            //Set the answer
            this.answer = x + y;

            //Ask the question
            lblCaptcha.Text = "What is " + y + " + " + x + "?";
        }

        private void btnSortTeacher_Click(object sender, EventArgs e)
        {
            //Sort the teacher names

            //create a new string of all the teacher names
            string[] tNames = new string[schoolTeachers.Length];

            //If teacher is checked
            if (rdb_Teacher.Checked)
            {
               /*
                * We will be performing bubble sort
                * on the first character of the teachers
                */ 
                //Go through the schoolteacher array
                for (int y = 0; y < schoolTeachers.Length; y++)
                {
                    //Bubble sort algorithm
                    for (int j = y + 1; j < schoolTeachers.Length; j++)
                    {
                        //BUBBLE SORT MAGIC :)

                        /*
                         * If the first char of the current teacher name(y) is 
                         * less than the after teacher (j), then swap it
                         * 
                         */ 
                        if (schoolTeachers[y].getTeacherName().ToLower().ToCharArray()[0] >
                            schoolTeachers[j].getTeacherName().ToLower().ToCharArray()[0])
                        {

                            //Set temporary teacher
                            Teacher t = schoolTeachers[y];

                            //Swap
                            schoolTeachers[y] = schoolTeachers[j];

                            //Reload
                            schoolTeachers[j] = t;

                        }
                    }

                }
                //Clear contact list
                lsbContactList.Items.Clear();

                //Loop through school teacher array
                for (int i = 0; i < schoolTeachers.Length; i++)
                {
                    //Loop through teacher and add their name
                    lsbContactList.Items.Add(schoolTeachers[i].getTeacherName());
                }
            }

       }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Get the answer
            answer = Convert.ToInt32(this.txtboxCaptcha.Text);

            //If they pass the answer check
            if (answer == x + y)
            {
                //Variable for the sender name
                string sWho = "";

                //variable for sender email
                string sEmail = "";

                //If its the IT department
                if (rdb_ITDepartment.Checked)
                {

                    //Get the IT Department information
                    sWho = Config.SCHOOL_NAME + " IT Department";
                    sEmail = "admin@edusist.ca";
                }

                //If the principal radiobutton is selected
                if (rdb_Principal.Checked)
                {   
                    //Get the appropriate information
                    sWho = Config.SCHOOL_NAME + " Principal";
                    sEmail = "principal@edusist.ca";
                }

                if (rdb_Teacher.Checked)
                {

                    //Find the teacher name
                    for(int i=0; i<schoolTeachers.Length; i++)
                    {
                        //If the teacher name matches
                        if (schoolTeachers[i].getTeacherName().ToLower() ==
                                lsbContactList.Text.ToLower())
                        {
                            //Set the sender variables appropriately
                            sWho = Config.SCHOOL_NAME + ": " + schoolTeachers[i].getTeacherName() +" REQUEST";
                            sEmail = schoolTeachers[i].getTeacherEmail();
                        }
                    }
                }

                //Try to use SMTP mail function
                try
                {
                    /*
                     * Mr Hsiung,
                     * This function works on the server we tested on 
                     * but does not work at our homes. I think this is because
                     * the port is firewalled or something like that. We apologize, and
                     * we tried :(
                     */ 

                    //New instance of microsoft SMTP mail message
                    MailMessage message = new MailMessage();

                    //Add the email to the sender info
                    message.To.Add(sEmail);

                    //Get the message for who to send it to
                    message.Subject = sWho + " " + this.txtboxSubject.Text;

                    //Add the from address as the edusist info
                    message.From = new MailAddress("windows@edusist.ca", "EDUSIST");

                    //Get the body of the message
                    message.Body = rchboxMessage.Text;

                    //SMTP Configuration
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(message);
                }
                    //Catch the exception
                catch (Exception s)
                {
                    //Print exception
                    Console.WriteLine(s);
                }
                
            }
            else
            {
                //Show verification failed
                MessageBox.Show("FAILED VERIFICATION");
            }
        }

        private void frmContactIT_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact a selected student, teacher or the IT department and send them a message."); 
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
            MessageBox.Show("Program created by Amil S, Ramie R, Moeen M, Melissa M, Shayan G");MessageBox.Show("Program created by Amil S, Ramie R, Moeen M, Melissa M, Shayan G");
        }

        private void grpBoxPerson_Enter(object sender, EventArgs e)
        {

        }
    }
}
