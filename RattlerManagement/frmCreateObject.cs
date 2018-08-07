/*
 * Name: Create Object Form 
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Date: January 22, 2012
 * Purpose: Used by principal to create new objects, and be rented by teachers.
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
    public partial class frmCreateObject : Form
    {
        public frmCreateObject()
        {
            InitializeComponent();
        }

        private void txt_oID_TextChanged(object sender, EventArgs e)
        {
            //character length set to 15 for the oID textbox 
            txt_oID.MaxLength = 15; 
        }

        private void bttn_NewObj_Click(object sender, EventArgs e)
        {
            //If the textboxes are left
            if (txt_oID.Text != "" && txt_oName.Text != "")
            {
                //disabled value set to 0
                int disabled = 0; 
                
                if (radioButton1.Checked)
                {
                    //disabled value set to 1
                    disabled = 1;
                }
                else
                {
                    //disabled value set to 0
                    disabled = 0;
                }

                //inserts the object name and id into the database
                DatabaseConnection.insertObject(Convert.ToInt32(txt_oID.Text), txt_oName.Text, disabled); 
                
            }
            else
            {
                //Message box displayed regarding the falure of inserting object
                MessageBox.Show("Failed to Insert object", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }

        private void frmCreateObject_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Create a new principal panel form
            frmPrincipalPanel pP = new frmPrincipalPanel();
            pP.Activate();
            pP.Show();

            //Collect disposed form info
            System.GC.Collect();

            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program created by Amil S, Ramie R, Moeen M, Melissa M, Shayan G");
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create a new object by filling out the required information and selecting to either enable or disable the object's status. Then click the create new object button.");
        }



        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
    }
}