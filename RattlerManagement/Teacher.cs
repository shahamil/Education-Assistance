/*
 * Name:    Teacher Class
 * Date:    January 2nd 2012
 * Purpose: This class is used to store information relating to the teachers. It has variables
 *          which hold teacher information such as name, courses and teacher numbers. This class
 *          also contains the getters and setters to set teacher information in the forms. 
 *          
 * @authors:    Ramie
 *              Amil
 *              Melissa
 *              Shayan
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RattlerManagement
{
    class Teacher
    {
        // Store teacher's number as private int
        private int tNumber;
        // Store teacher's first name as private string
        private string tFirstName;
        // Store teacher's last name as private string
        private string tLastName;
        // Store teacher's password as private string
        private string tPassword;
        // Store teacher's email as private string
        private string tEmail;
        // Course array which holds the courses for the teachers
        private Course[] tCourses = new Course[Config.MAX_COURSES_PER_TEACHER];

        //============================================================================

        /// <summary>
        /// This method takes in all the information for the Teacher and sets it
        /// </summary>
        /// <param name="tN"></param>
        /// <param name="tF"></param>
        /// <param name="tL"></param>
        /// <param name="tP"></param>
        /// <param name="tE"></param>
        /// <param name="c"></param>
        public Teacher(int tN, string tF, string tL, string tP,
                        string tE, Course[] c)
        {
            // for loop which goes through the coures
            for (int i = 0; i < c.Length; i++)
            {
                // teacher courses is equal to the courses given
                tCourses[i] = c[i];
            }

            // setting all the values taken in
            tNumber = tN;
            tFirstName = tF;
            tLastName = tL;
            tPassword = tP;
            tEmail = tE;

        }

        //============================================================================

        /// <summary>
        /// This method gets the teacher number
        /// </summary>
        /// <returns>Teacher number</returns>
        public int getTeacherNumber()
        {
            return tNumber; //return teacher number
        }

        //============================================================================

        /// <summary>
        /// This method gets the teacher email
        /// </summary>
        /// <returns>Returns teacher email</returns>
        public string getTeacherEmail()
        {
            return tEmail;
        }

        //============================================================================

        /// <summary>
        /// This method gets the Teacher's Full name
        /// </summary>
        /// <param name="teachName">Teacher's Name</param>
        /// <returns>teacher's Full Name</returns>
        public string getTeacherName()
        {
            return this.tFirstName + " " + this.tLastName;
        }

        //============================================================================

        /// <summary>
        /// This method gets the teacher password
        /// </summary>
        /// <returns>Returns teacher password</returns>
        public string GetTeachPassword()
        {
            return tPassword;
        }

        //============================================================================

        /// <summary>
        /// This method gets the teacher courses
        /// </summary>
        /// <param name="i">Takes index of the course array</param>
        /// <returns>Returns teacher course array index</returns>
        public Course getTeacherCourse(int i)
        {
            return tCourses[i];
        }

        //============================================================================

        /// <summary>
        /// This method gets the teacher courses in an array
        /// </summary>
        /// <returns>Returns teacher course</returns>
        public Course[] getTeacherCourses()
        {
            return tCourses;
        }


        //=============================================================================

        /// <summary>
        /// This method sets teacher number
        /// </summary>
        /// <param name="teachNumberGiven">Teacher number</param>
        public void setTeacherNumber(int teachNumberGiven)
        {
            // sets teacher number
            tNumber = teachNumberGiven;
        }

        //=============================================================================

        /// <summary>
        /// This method sets the teacher name
        /// </summary>
        /// <param name="nI">What type of name it wants to set (first or last)</param>
        /// <param name="n">Name to set it to</param>
        public void setTeacherName(int nI, string n)
        {
            // if the name type is 0
            if (nI == 0)
            {
                // first name is set to the input
                this.tFirstName = n;
            }
            else
            {
                // last name is set to the input
                this.tLastName = n;
            }
        }

        //=============================================================================

        /// <summary>
        /// This method sets the teacher password
        /// </summary>
        /// <param name="teachPasswordGiven">Teacher passwored entered</param>
        public void setTeacherPassword(string teachPasswordGiven)
        {
            tPassword = teachPasswordGiven; // Sets teacher password
        }

        //=============================================================================

        /// <summary>
        /// This method sets the teacher courses
        /// </summary>
        /// <param name="c">The course object</param>
        /// <returns>Returns true or false, if the course is able to add or not</returns>
        public Boolean setTeacherCourses(Course c) //set teacher courses 
        {
            // for loop which goes through the courses
            for (int i = 0; i < tCourses.Length; i++)
            {
                // if the course value in index is null
                if (tCourses[i] == null)
                {
                    // index value equals to the course
                    tCourses[i] = c;

                    // true is returned
                    return true;
                }
                else
                {
                    // continues the program
                    continue;
                }
            }
            // false is returned
            return false;
        }

        //=============================================================================
    }
}

