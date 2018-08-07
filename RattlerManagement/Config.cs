/*
 * Name:        Configuration Class
 * Date:        December 24th 2012
 * Purpose:     This class holds all the configurations for the program
 *              most of which will remain static and constant throughout
 *              the program because they're final constant. 
 *              
 *              The information here is retreived throughout the whole 
 *              program from this class because a lot of arrays and objects depend
 *              on these configurations.
 *              
 * Author:      Made by the whole group
 *              
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace RattlerManagement
{
    class Config
    {
        /***********************DATABASE CLASS VARIABLES*********************************/

        /*
         * This is the mysql connection string used by database class
         * Make sure you maintain the syntax when configuring
         */
        //The connection string to pass onto the MySql Instance created Later
        public static string DATABASE_CONNECTION_STRING =
                                "Server=server2592.silentx.info;" +                 //Server Host
                                "Port=443;" +                                       //Server Port
                                "Database=edusist;" +                               //Server Database
                                "Uid=csharp;" +                                     //Server Username
                                "Password=ics4u;";                                  //Server Password



        public static int userRole = 0;                  // Role of the user (student, principal or teacher)

        public static int MAX_STUDENT_YEARS = 4;         // Maximum number for student years
        public static int MAX_STUDENT_COURSES = 8;       // Maximum number of courses for students
        public static int MAX_STUDENT_COMMENTS = 2;      // Maximum number of comments for students

        public static int MAX_TEACHER_YEARS = 4;         // Maximum number of 
        public static int MAX_TEACHER_COURSES = 8;
        public static int MAX_TEACHER_COMMENTS = 2;      // Maximum number of 

        public static int MAX_SCHOOL_DAYS = 5;           // Maximum school days
        public static int MAX_HOURS_PER_DAY = 24;        // Maximum hours per day

        public static int MAX_COURSES_PER_TEACHER = 8;   // Maximum number of courses teachers can have

        public static int MAX_EQUIPMENT = 10;            // Maximum number of equipment
        public Student[] sList = new Student[4000];      // The student array list is created, with 4000 students

        private static Student sS;                       // Temporary student created to share between the classes
        private static Equipment eE;                     // Temporary equipment object created to share between the classes

        public static int MAX_STUDENTS_IN_CLASS = 30;    // Max students in class
        public static string SCHOOL_NAME = "Richmond Green Secondary School";   // School name

        public static int CATEGORIES_PER_COURSE = 6;     // Maximum amount of categories in a course (ex. K/U, AP etc)
        public static int MAX_SCHOOL_CLASSES = 200;      // Max classes in the school

        public static int MAX_SCHOOL_TEACHERS = 101;     // Max teachers in the school

        private static Course tCourse;                   //   
        private static Teacher tTeacher;                 // 


        public static frmContactIT publicContactForm = new frmContactIT();

        //===============================================================================================================


        //----------------------------------------------------------------------

        /// <summary>
        /// This method sets the equipment
        /// </summary>
        /// <param name="e"></param>
        public static void setEquipment(Equipment e)
        {
            eE = e;
        }

        //----------------------------------------------------------------------

        /// <summary>
        /// get the equipment temporarily
        /// </summary>
        /// <returns></returns>
        public static Equipment getEquipment()
        {
            return eE;
        }

        //----------------------------------------------------------------------

        /// <summary>
        /// set temporary student
        /// </summary>
        /// <param name="n"></param>
        public static void setStudent(Student n)
        {
            sS = n;
        }

        //----------------------------------------------------------------------

        /// <summary>
        /// set temporary course
        /// </summary>
        /// <param name="cN"></param>
        public static void setTCourse(Course cN)
        {
            tCourse = cN;
        }

        //----------------------------------------------------------------------

        /// <summary>
        /// set temporary course
        /// </summary>
        /// <returns></returns>
        public static Course getTCourse()
        {
            return tCourse;
        }

        //----------------------------------------------------------------------

        /// <summary>
        /// set the temporary teacher
        /// </summary>
        /// <param name="cN"></param>
        public static void setTTeacher(Teacher cN)
        {
            tTeacher = cN;
        }

        //----------------------------------------------------------------------

        /// <summary>
        /// Get the temporary teacher
        /// </summary>
        /// <returns></returns>
        public static Teacher getTTeacher()
        {
            return tTeacher;
        }

        //----------------------------------------------------------------------

        /// <summary>
        /// This method returns the student as an object
        /// </summary>
        /// <returns></returns>
        public static Student getStudent()
        {
            return sS;
        }

        //----------------------------------------------------------------------

        /// <summary>
        /// This method is used to try parse throughout the program
        /// </summary>
        /// <param name="value">Takes in a string to try parse</param>
        /// <returns>Returns if the input is an int or not</returns>
        public static Boolean TryToParse(string value)
        {
            int number;
            bool result = Int32.TryParse(value, out number);
            if (result)
            {
                return true;    // Returns true if it is
            }
            else
            {
                return false;   // Returns false it isnt
            }
        }

        //----------------------------------------------------------------------
    }
}
