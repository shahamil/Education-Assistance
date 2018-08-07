/*
 * Name: Splash Screen Form
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 19, 2012
 * Purpose: To intiate the startup soundtrack of the program and show the objects that are being loaded.
 * 
 * Author:  Shayan
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
using System.Media;
using System.Threading;

namespace RattlerManagement
{
    public partial class frmSplashPage : Form
    {

        //New instance of login page
        public static frm_LoginPage p = new frm_LoginPage();


        public frmSplashPage()
        {
            InitializeComponent();
        }

        private void frmSplashPage_Load(object sender, EventArgs e)
        {

            Thread t = new Thread(loadContactForm);
            t.Start();

            prgBarChecker.Enabled = true;

            this.ControlBox = false;
            this.Text = string.Empty;
            //Sound player for into music
            SoundPlayer introMusic = new SoundPlayer("cache/airtel.wav");
           
            prgMain.Value += 1;
            //Activate the login form

            p.Activate();
            prgMain.Value += 1;
            //Play Intro Music
            introMusic.Play();

            prgMain.Value += 1;

            tmrPBar.Enabled = true;

        }

        private void tmrSplashLoader_Tick(object sender, EventArgs e)
        {

            //Show the login Uform and hide this form
            p.Show();
            this.Hide();

            //Disable the header
            prgBarChecker.Enabled = false;
            tmrPBar.Enabled = false;
            tmrSplashLoader.Enabled = false;
        }

        /// <summary>
        /// This loads up the contact form
        /// </summary>
        public void loadContactForm()
        {
            Console.WriteLine("THREAD STARTED");

            //Activate the form
            Config.publicContactForm.Activate();
            Config.publicContactForm.LoadContacts();


            Console.WriteLine("THREAD FINISHED");
        }


        private void tmrPBar_Tick(object sender, EventArgs e)
        {
            //Keep adding to the progress bar if it is less than the maximum
            if (prgMain.Value < prgMain.Maximum)
            {
                prgMain.Value++;
            }
        }

        private void prgBarChecker_Tick(object sender, EventArgs e)
        {
            //An array of information to show to the user on the splash page
            string[] textInfo = {"Starting up Program", "Loading the teachers", "Loading the students", "Initiating database Connection", 
                                    "Creating Login form Instance", "Activating Login Form", "Completing Database Query", "Checking for software Update",
                                    "Finalizing Settings", "Initiating Form"};

            //Progress bar text is gunna be the text info of that array index
            lblProgressBar.Text = textInfo[prgMain.Value-1];
        }
    }
}
