
/*
 * Name: Program Main Form
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 18, 2012
 * Purpose: Allow students, teachers or principle to login into the EDU-Assist system. 
 * This form is the main form of the program and links to all the others forms.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Threading;
using System.Media;
using System.Windows;

namespace RattlerManagement
{
    public partial class frm_LoginPage : Form
    {
        // Amount of tries tried to log in
        private int tries = 0;
        private frmContactIT cIT = new frmContactIT();
        //private frmSplash sP = new frmSplash();

        public frm_LoginPage()
        {
            InitializeComponent();  
            // Form is initialized
        }


        /// <summary>
        /// This function collects the garbage
        /// </summary>
        public void publicGarbageCollector()
        {
            //Collect the garbage
            System.GC.Collect();

        }

        /// <summary>
        /// This boolean is used to check if the computer
        /// has enough memory to run the program
        /// </summary>
        /// <returns>True/False</returns>
        private Boolean passMemoryCheck()
        {
            //If statement
            if (System.GC.GetTotalMemory(false) > 200000)
            {
                //Return true
                return true;
            }
            else
            {
                //Return false
                return false;
            }
        }

        /// <summary>
        /// This function loads other stuff in the program which might take a while to load
        /// </summary>
        public void loadOtherStuff()
        {
            Config.publicContactForm.Activate();

            //Activate form and load teacher list
            Config.publicContactForm.LoadContacts();

            
        }

        /// <summary>
        /// Loading the main program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProgramMain_Load(object sender, EventArgs e)
        {

            rdb_student.Checked = true;       // Default radio button student is checked
            prgbarLoadingLogin.Maximum = 10;  // Logging in progress bar maximum value
            prgbarLoadingLogin.Minimum = 0;   // Logging in progress bar minimum value
            prgbarLoadingLogin.Value = 0;     // Logging in progress bar value


            if (passMemoryCheck())
            {
                Console.WriteLine("It is not recommended you run this program on this machine");
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Role depending on teacher, principal or student
            int userRole = 0;

            // Adds one to try added to log on
            tries++;


            // try parses to check if input is integer
            if (Config.TryToParse(txt_Username.Text))
            {
                // if student radio button is checked
                if (rdb_student.Checked == true)
                {
                    // user role 1 is selected
                    userRole = 1;

                }

                // if teacher radio button is checked
                if (rdb_teacher.Checked == true)
                {
                    // user role 2 is selected for teacher
                    userRole = 2;
                }

                // if principal radio button is checked
                if (rdb_principal.Checked == true)
                {
                    // user role 3 is selected for principal
                    userRole = 3;
                }
            }
            else
            {
                // Message box is shown telling about incorrect login
                MessageBox.Show("Please enter your username in the correct format!",
                    "Invalid Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                // Resetting text box for user name
                txt_Username.Text = "";

                // Resetting text box for password 
                txt_Password.Text = "";
            }

            // Switch case for user role
            switch (userRole)
            {
                // if case 1
                case 1:
                    prgbarLoadingLogin.Value = 0;
                    prgbarLoadingLogin.Value += 2;  // progress bar increased by 1

                    // if user input is correct
                    if (DatabaseConnection.checkUser(txt_Username.Text, txt_Password.Text, 0))
                    {
                        // progress bar increased by 1
                        prgbarLoadingLogin.Value += 2;

                        // Student profile is loaded
                        frmStudentProfile sForm = new frmStudentProfile();
                        prgbarLoadingLogin.Value += 2;
                        // Activates student profile form
                        sForm.Activate();

                        // Progress bar increased by 1
                        prgbarLoadingLogin.Value += 2;

                        // Temporarily sets the config file as this student so it can be shared between the classes
                        Config.setStudent(DatabaseConnection.loadStudent(txt_Username.Text));

                        // Progress bar increased by 1
                        prgbarLoadingLogin.Value += 2;

                        // Message box showing successful logon
                        MessageBox.Show("Successfully Logged In");
                        // Student Profile form shown
                        sForm.Show();

                     

                        // Hides logon on form
                        this.Hide();

                        Config.userRole = 1; // user role is set to 1
                     
                    }
                    else
                    {
                        // Message box is shown login failed
                        MessageBox.Show("Login Failed");
                        // If login tries is above 3
                        if (tries > 3)
                        {
                            // Application is exited
                            Application.Exit();
                        }
                    }
                    // leaves case
                    break;

                // if case 2
                case 2:
                    prgbarLoadingLogin.Value = 0;
                    prgbarLoadingLogin.Value += 2;
                    // if user input is correct
                    if (DatabaseConnection.checkUser(txt_Username.Text, txt_Password.Text, 1))
                    {
                        // gets teacher information
                        Teacher getTeacher = DatabaseConnection.getTeacher(Convert.ToInt32(txt_Username.Text));
                        prgbarLoadingLogin.Value += 2;

                        // Sets teacher info
                        Config.setTTeacher(getTeacher);
                        prgbarLoadingLogin.Value += 2;

                        // teacher profile is loaded
                        frmTeacherProfile fTP = new frmTeacherProfile();

                        prgbarLoadingLogin.Value += 2;
                        // teacher profile is activated

                        fTP.Activate();
                        prgbarLoadingLogin.Value += 2;

                        // login screen is hidden
                        this.Hide();

                        // shows teacher profile
                        fTP.Show();

                        Config.userRole = 2;  // user role is set to 2
                    }
                    else
                    {
                        // if login fails shows message box showing so
                        MessageBox.Show("Login Failed");
                        // if tries to login exceeds 3
                        if (tries > 3)
                        {
                            // program is exitted
                            Application.Exit();
                        }
                    }

                    break;

                // if case 3
                case 3:
                    prgbarLoadingLogin.Value = 0;
                    prgbarLoadingLogin.Value += 4;
                    // checks to see if user input for principal is correct
                    if (DatabaseConnection.checkUser(txt_Username.Text, txt_Password.Text, 2))
                    {
                        // principal panel is loaded
                        prgbarLoadingLogin.Value += 2;
                        frmPrincipalPanel pP = new frmPrincipalPanel();

                        prgbarLoadingLogin.Value += 2;
                        // principal panel is activated
                        pP.Activate();

                        prgbarLoadingLogin.Value += 2;
                        // principal panel is shown
                        pP.Show();

                        // login screen is hidden
                        this.Hide();

                        Config.userRole = 3;  
                        // Eser role 3 is set
                    }
                    else
                    {
                        // if login fails shows message box saying so
                        MessageBox.Show("Login Failed");
                        // if tries to login exceeds 3
                        if (tries > 3)
                        {
                            // program is exitted
                            Application.Exit();
                        }
                    }

                    break;
            }
        }

        private void bttn_ForgotPassword_Click(object sender, EventArgs e)
        {
            // if radio button student is checked
            if (rdb_student.Checked)
            {
                // if user exists in the database
                if (DatabaseConnection.loadStudent(txt_Username.Text) != null)
                {

                    /*
                    * Mr Hsiung,
                    * This function works on the server we tested on 
                    * but does not work at our homes. I think this is because
                    * the port is firewalled or something like that. We apologize, and
                    * we tried :(
                    */ 
                    try
                    {
                        //New instance of Mailmessage from microsoft library
                        MailMessage message = new MailMessage();

                        //Add the student email as the information
                        message.To.Add(DatabaseConnection.loadStudent(txt_Username.Text).getStudEmail(DatabaseConnection.loadStudent(txt_Username.Text)).ToLower());

                        //A message with the concatenated user and password
                        message.Subject = "STUDENT PASSWORD REQUEST" + " for " +
                            DatabaseConnection.loadStudent(txt_Username.Text).getStudFirstName(DatabaseConnection.loadStudent(txt_Username.Text));

                        //The from address
                        message.From = new MailAddress("windows@edusist.ca");

                        //Message for the password
                        message.Body = "Your EDUSIST PASSWORD IS: \n" + DatabaseConnection.loadStudent(txt_Username.Text).getStudPassword(DatabaseConnection.loadStudent(txt_Username.Text));


                        //SMTP Server information
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        SmtpServer.Port = 465;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("rgssschoolwork@gmail.com", "68784214");
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Send(message);
                    }
                    catch (Exception t)
                    {
                        Console.WriteLine(t);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please ask the IT department regarding your login information");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exits the program
        }

      
        private void contactFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Config.publicContactForm.Show();
        }

        private void tmrGarbageCollector_Tick(object sender, EventArgs e)
        {
            //Collect garbage
            publicGarbageCollector();

            //Write to console
            Console.WriteLine("Garbage has been collected");
        }

        private void frm_LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Begin by checking off either the principal, student, or teacher button and logging in with your username and password.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program created by Amil S, Ramie R, Moeen M, Melissa M, Shayan G");
        }

 
    }
}