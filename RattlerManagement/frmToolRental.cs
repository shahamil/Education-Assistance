
/*********************IMPORTANT PLEASE READ MR HSIUNG***************************/
/*
 *  PLEASE DO NOT MARK THIS.
 *  WE LEFT THIS IN HERE TO SHOW YOU WE ATLEAST TRIED TO DO THIS.
 */ 
/*
 * Name: Tool Rental Form
 * Group Name: Shayan, Ramie, Amil and Moeen
 * Purpose: Allows the teachers to rent specific equipment/items the school owns at a particular time slot.
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
    public partial class frmToolRental : Form
    {
        private Teacher tea;
        public frmToolRental()
        {
            InitializeComponent();
            loadEquipment();
            tea = Config.getTTeacher();
            
        }


        private Equipment[] schoolEquipment = new Equipment[Config.MAX_EQUIPMENT];

        private void loadEquipment()
        {
            for (int i = 0; i < Config.MAX_EQUIPMENT; i++)
            {
                schoolEquipment[i] = DatabaseConnection.loadEquipment(i);
            }
        }

        private void displayEquipment()
        {
            for (int i = 0; i < schoolEquipment.Length; i++)
            {
                if (schoolEquipment[i] != null)
                {
                    lsb_ItemInventory.Items.Add(schoolEquipment[i].GetoName());
                }
            }
        }
        private void frmToolRental_Load(object sender, EventArgs e)
        {
            displayEquipment();
        }

        private void lsb_ItemInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Config.MAX_SCHOOL_DAYS; i++)
            {
                lsb_Day.Items.Add("Day " + (i+1));
            }
        }

        private void lsb_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curIn = 0; 
            for (int z = 0; z < schoolEquipment.Length; z++)
            {
                if (schoolEquipment[z] != null)
                {
                    if (lsb_ItemInventory.Text == schoolEquipment[z].GetoName())
                    {
                        curIn = z;
                        break;
                    }
                }
            }

            for (int i = 0; i < Config.MAX_HOURS_PER_DAY; i++)
            {
                if (schoolEquipment[curIn] != null)
                {

                    lsb_Time.Items.Add(schoolEquipment[curIn].getRentalSchedule((lsb_Day.SelectedIndex-1), i).ToString() + " "+(i+1)+"H");
                }
            }
        }

        private void btn_RentItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < schoolEquipment.Length; i++)
            {
                if (schoolEquipment[i] != null)
                {
                    if (schoolEquipment[i].GetoName() == lsb_ItemInventory.Text)
                    {
                        schoolEquipment[i].bookEquipment((lsb_Day.SelectedIndex-1),
                            (lsb_Time.SelectedIndex-1), tea);
                        DatabaseConnection.SaveEquipment(schoolEquipment[i]);
                        break;
                    }
                }
            }
        }

        private void frmToolRental_FormClosing(object sender, FormClosingEventArgs e)
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program created by Amil S, Ramie R, Moeen M, Melissa M, Shayan G");
        }

        private void edusistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the item, the day and time in order to rent item.");
        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
    }
}
