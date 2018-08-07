/*
 * Name: Equipment Class
 * Group Name: Shayan, Ramie, Amil and Moeen 
 * Date: January 16, 2012
 * Purpose: To create new instances of an equipment object with the declaration of its corresponding object id number 
 *          Implements a sechedule which organizes days of the weeks and total number of hours in a day where an particular 
 *          equipment tool can be rented
 *          
 * Author:  Amil Shah
 *          Ramie Raufdeen
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RattlerManagement
{
    class Equipment
    {
        // string array which holds the equipment scheduel
        private string[,] equipmentSchedule = new string[Config.MAX_SCHOOL_DAYS,
            Config.MAX_HOURS_PER_DAY];

        // string which holds equipment name
        private string oName;

        // bool variable which says if equipment is available or not
        private bool oDisabled;

        // int variable which holds equipment ID number
        private int oID;

        /// <summary>
        /// This method takes in the information for equipment and sets it
        /// </summary>
        /// <param name="oNum">Item number of equipment</param>
        /// <param name="oItemName">Item name</param>
        /// <param name="oDis">Object disabled or not</param>
        public Equipment(int oNum, string oItemName, int oDis)
        {
            // sets the values of the variables  
            oID = oNum;
            oName = oItemName;

            // if the object disables is true
            if (oDis == 1)
            {
                // makes bool value for object disabled true
                oDisabled = true;
            }
            else
            {
                // makes bool value for object disabled false
                oDisabled = false;
            }
        }

        /// <summary>
        /// This method gets the name of the equipment
        /// </summary>
        /// <returns>Name of equipment</returns>
        public string GetoName()
        {
            return this.oName;
        }

        /// <summary>
        /// This method returns the equipment ID
        /// </summary>
        /// <returns>Equiment ID</returns>
        public int GetoID()
        {
            return this.oID;
        }

        /// <summary>
        /// This method checks if the equipment is disabled or not
        /// </summary>
        /// <returns>Bool value for equipment being disbaled or not</returns>
        public bool GetoDisabled()
        {
            return oDisabled;
        }

        /// <summary>
        /// This method gets the rental schedule
        /// </summary>
        /// <param name="x">Day</param>
        /// <param name="y">Hour</param>
        /// <returns>Day and hour of rental</returns>
        public string getRentalSchedule(int x, int y)
        {
            return equipmentSchedule[x, y];
        }

        /// <summary>
        /// This method gets the rental day for the equipment
        /// </summary>
        /// <param name="d">Day number</param>
        /// <returns>Day and time of rental confirmed</returns>
        public string getRentalDay(int d)
        {
            // Array for teachers day at work
            string[] tDay = new string[Config.MAX_HOURS_PER_DAY];

            // for loop which goes through the max hours in the day
            for (int i = 0; i < Config.MAX_HOURS_PER_DAY; i++)
            {
                // sets the equipment rented for the teacher
                this.equipmentSchedule[d, i] = tDay[i];

            }

            // joins the array value into a string
            string result = string.Join(";", tDay);

            // returns string value
            return result;

        }

        /// <summary>
        /// This method sets the rental schedule
        /// </summary>
        /// <param name="rInfo">Rental info from the database</param>
        public void setRentalSchedule(string[,] rInfo)
        {
            // for loop which goes through the school days
            for (int i = 0; i < Config.MAX_SCHOOL_DAYS; i++)
            {
                // for loop which goes through the hours in the day
                for (int z = 0; z < Config.MAX_HOURS_PER_DAY; z++)
                {
                    // sets the equipment rental
                    this.equipmentSchedule[i, z] = rInfo[i, z];
                }
            }
        }

        /// <summary>
        /// This method sets the equipment name
        /// </summary>
        /// <param name="equipName">Equipment name</param>
        public void setEquipmentName(string equipName)
        {
            // sets the equipment name
            this.oName = equipName;

        }

        /// <summary>
        /// This method books the equipment for rental
        /// </summary>
        /// <param name="d">Day</param>
        /// <param name="h">Hour</param>
        /// <param name="t">Teacher object</param>
        public void bookEquipment(int d, int h, Teacher t)
        {
            // sets the the teacher name for the equipment rented at the time and day
            this.equipmentSchedule[d, h] = t.getTeacherName();
        }

        /// <summary>
        /// This method disables the object making it available for rental
        /// </summary>
        public void disableObject()
        {
            this.oDisabled = true;
        }
    }
}
