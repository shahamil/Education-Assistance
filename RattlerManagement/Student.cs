/*
 * Name: Shayan, Ramie, Moeen, Mellisa, Amil
 * Date: Dec 29, 2011
 * Purpose: This class is used to store information relating to the students. It has variables
 *          which hold student information such as name, courses and student numbers. This class
 *          also contains the getters and setters to set student information in the forms. 
 *          
 * @authors:
 *          Shayan
 *          Moeen
 *          Ramie
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RattlerManagement
{
    class Student
    {

        //Login Information for student
        private int studNumber;                 //The ID of the studnet           
        private string studPassword;            //The password of the student

        //Student's Information stored in variables
        private string studFirstName;           //First Name of teh student
        private string studLastName;            //Last name of teh studnet
        private string studDOB;                 //Student's Date of Birth
        private int studGrade;                  //Stduent's Grade
        private string studEmail;               //Student's Email

        //Student's Parent's Infromation stored in variables
        private string studParentName;          //Student's Parent's first name
        private string studParentPhone;         //Student's parents home phone
        private string studHomeAddress;         //Stduent's Parenst home address

        //An array that stores the courses teh stuent is taking durings school
        private string[,] studCourses =
            new string[Config.MAX_STUDENT_YEARS, Config.MAX_STUDENT_COURSES];

        //An array that stores teh comments about the studnt for each course that tehy are taking
        private string[,] studComments =
            new string[Config.MAX_STUDENT_YEARS, Config.MAX_STUDENT_COMMENTS];

        //================================================================================//

        /// <summary>
        /// This method loads the student information from the database as soon as the student logs in
        /// </summary>
        /// <param name="studentID">Takes in student ID number</param>
        public Student(int studentID)
        {
            
            //DatabaseConnection.loadStudent(studentID.ToString());
        }

        //================================================================================//

        /// <summary>
        /// This method gets the array of the student information and loads it to the student object
        /// </summary>
        /// <param name="sInfo">Array of Student's Info</param>
        /// <param name="s">Student's Object</param>
        public void getStudentArray(string[] sInfo, Student s)
        {
            /*
             * Transfers the following data from the Array of information to the Studnet Object
             * Student Numbers
             * pasword
             * Stduent's First Name
             * Student's Last Name
             * STudent's Date of Birth
             * Student's Grade
             * Student's Email
             * Stduent's Parent's Name
             * Student's Parent Phone Number
             * Student's Home Address
            */

            s.studNumber = Convert.ToInt32(sInfo[0]);
            s.studPassword = sInfo[1];
            s.studFirstName = sInfo[2];
            s.studLastName = sInfo[3];
            s.studDOB = sInfo[4];
            s.studGrade = Convert.ToInt32(sInfo[5]);
            s.studEmail = sInfo[6];
            s.studParentName = sInfo[7];
            s.studParentPhone = sInfo[8];
            s.studHomeAddress = sInfo[9];
        }

        //================================================================================//

        /// <summary>
        /// This method gets the Student's Number
        /// </summary>
        /// <param name="s">Student's Information</param>
        /// <returns>Student Number</returns>
        public int getStudNumber(Student s)
        {
            return s.studNumber;
        }

        //================================================================================//

        /// <summary>
        /// This method gets the Studnet's password
        /// </summary>
        /// <param name="s">Student's Information</param>
        /// <returns>Student's Password</returns>
        public string getStudPassword(Student s)
        {
            return s.studPassword;
        }

        //================================================================================//

        /// <summary>
        /// This method gets the student's First Name
        /// </summary>
        /// <param name="s">Student's Information</param>
        /// <returns>Stduent's First Name</returns>
        public string getStudFirstName(Student s)
        {
            return s.studFirstName;
        }

        //================================================================================//

        /// <summary>
        /// This method gets the studnet's last name
        /// </summary>
        /// <param name="s">Student's Information</param>
        /// <returns>Studnet's Last name</returns>
        public string getStudLastName(Student s)
        {
            return s.studLastName;
        }

        //================================================================================//

        /// <summary>
        /// This method gets the students birth date
        /// </summary>
        /// <param name="s">Studnet's Information</param>
        /// <returns>Stduent's Date of Birth</returns>
        public string getDOB(Student s)
        {
            return s.studDOB;
        }

        //================================================================================//

        /// <summary>
        /// This method gets the studnets grade
        /// </summary>
        /// <param name="s"> Studnet's Information</param>
        /// <returns>Stduent's Grade</returns>
        public int getstudGrade(Student s)
        {
            return s.studGrade;
        }

        //================================================================================//

        /// <summary>
        /// This method gets the Student's email
        /// </summary>
        /// <param name="s">Stduent's Information</param>
        /// <returns>Stduent's Email</returns>
        public string getStudEmail(Student s)
        {
            return s.studEmail;
        }

        //================================================================================//

        /// <summary>
        /// This method gets the Students Parents name
        /// </summary>
        /// <param name="s">Student's Information</param>
        /// <returns>Parent's Name</returns>
        public string getStudParentName(Student s)
        {
            return s.studParentName;
        }

        //================================================================================//

        /// <summary>
        /// This method gets the students parents phone number
        /// </summary>
        /// <param name="s">Student's Information</param>
        /// <returns>parent's phone number</returns>
        public string getStudParentPhone(Student s)
        {
            return s.studParentPhone;
        }

        //================================================================================//

        /// <summary>
        /// This method gets the students home address
        /// </summary>
        /// <param name="s"> Student's Information</param>
        /// <returns>Stduents Home Address</returns>
        public string getStudHomeAddress(Student s)
        {
            return s.studHomeAddress;
        }

        //================================================================================//

        /// <summary>
        /// This method gets teh Student's Time Table
        /// </summary>
        /// <param name="x">year</param>
        /// <param name="y">course id</param>
        /// <param name="s">Student's Object</param>
        /// <returns>Student's Courses</returns>
        public string getStudentCourses(int x, int y, Student s)
        {
            return s.studCourses[x, y];
        }

        //================================================================================//

        /// <summary>
        /// This method gets teh Studnet's comments
        /// </summary>
        /// <param name="x">year</param>
        /// <param name="y">course id</param>
        /// <param name="s">Student's Object</param>
        /// <returns>Stduent's COmments</returns>
        public string getStudentComments(int x, int y, Student s)
        {
            return s.studComments[x, y];
        }

        //================================================================================//

        /// <summary>
        /// Sets the Students Number
        /// </summary>
        /// <param name="studNumberGiven">Student Number</param>
        public void setStudNumber(int studNumberGiven)
        {
            studNumber = studNumberGiven;
        }

        //================================================================================//

        /// <summary>
        /// Sets teh Student's Password
        /// </summary>
        /// <param name="studPasswordGiven">STudent's Password</param>
        public void setStudPassword(string studPasswordGiven)
        {
            studPassword = studPasswordGiven;
        }

        //================================================================================//

        /// <summary>
        /// Sets the Student's First Name
        /// </summary>
        /// <param name="studFirstNameGiven">Student's First Name</param>
        public void setStudFirstName(string studFirstNameGiven)
        {
            studFirstName = studFirstNameGiven;
        }

        //================================================================================//

        /// <summary>
        /// Sets the Student's last Name
        /// </summary>
        /// <param name="studLastNameGiven">Student's Last Name</param>
        public void setStudLastName(string studLastNameGiven)
        {
            studLastName = studLastNameGiven;
        }

        //================================================================================//

        /// <summary>
        /// Sets teh Student's Daet of Birth
        /// </summary>
        /// <param name="studDOBGiven">Studnet's Date of Birth</param>
        public void setStudDOB(string studDOBGiven)
        {
            studDOB = studDOBGiven;
        }

        //================================================================================//

        /// <summary>
        /// Sets teh students grade
        /// </summary>
        /// <param name="studGradeGiven">Students grade</param>
        public void setStudGrade(int studGradeGiven)
        {
            studGrade = studGradeGiven;
        }

        //================================================================================//

        /// <summary>
        /// Sets the students email
        /// </summary>
        /// <param name="studEmailGiven">Student's Email</param>
        public void setStudEmail(string studEmailGiven)
        {
            studEmail = studEmailGiven;
        }

        //================================================================================// 

        /// <summary>
        /// Sets the Student's Parents Name
        /// </summary>
        /// <param name="studParentNameGiven">Student's Parents Name</param>
        public void setStudParentName(string studParentNameGiven)
        {
            studParentName = studParentNameGiven;
        }

        //================================================================================// 

        /// <summary>
        /// Sets teh Student's Parent Home Phone
        /// </summary>
        /// <param name="studParentPhoneGiven">Parent's home phone</param>

        public void setStudParentPhone(string studParentPhoneGiven)
        {
            studParentPhone = studParentPhoneGiven;
        }

        //================================================================================// 

        /// <summary>
        /// Sets the Student's home address
        /// </summary>
        /// <param name="studHomeAddressGiven">Parent's Home Address</param>
        public void setStudHomeAddress(string studHomeAddressGiven)
        {
            studHomeAddress = studHomeAddressGiven;
        }

        //================================================================================// 

        /// <summary>
        /// Transfers 2D array from database to object
        /// </summary>
        /// <param name="studCoursesGiven">Student's Courses</param>
        /// <param name="s">Student's Information</param>
        public void setStudCourses(string[,] studCoursesGiven, Student s)
        {
            for (int i = 0; i < Config.MAX_STUDENT_YEARS; i++)
            // Runs when counter is less than number of years student is in school 
            {
                for (int z = 0; z < Config.MAX_STUDENT_COURSES; z++)
                //Runs until all Courses are put into teh array
                {
                    s.studCourses[i, z] = studCoursesGiven[i, z];
                }
            }
        }

        //================================================================================// 

        /// <summary>
        /// Transfers 2D array of teh student's comments from database to object 
        /// </summary>
        /// <param name="studCommentsGiven">Student's Courses</param>
        /// <param name="s">Student's Information</param>
        public void setStudComments(string[,] studCommentsGiven, Student s)
        {
            for (int i = 0; i < Config.MAX_STUDENT_YEARS; i++)
            // Runs when counter is less than number of years student is in school 
            {
                for (int z = 0; z < Config.MAX_STUDENT_COMMENTS; z++)
                //Runs until all comments are put into the array
                {
                    s.studComments[i, z] = studCommentsGiven[i, z];
                }
            }
        }

        //================================================================================// 

        //================================================================================// 

        /// <summary>
        /// This method is used enroll students into courses
        /// </summary>
        /// <param name="year">Year of student</param>
        /// <param name="s">Student object</param>
        /// <param name="cID">Course ID</param>
        /// <returns></returns>
        public Boolean enrolStudent(int year, Student s, int cID)
        {
            // for loop which goes through the student courses
            for (int i = 0; i < this.studCourses.GetUpperBound(0); i++)
            {
                // if there is a value for "none" in the student courses
                if (studCourses[year - 1, i] == "none")
                {
                    // Makes that value the course ID
                    studCourses[year - 1, i] = cID.ToString();

                    // true is returned
                    return true;
                }
            }
            // false is returned
            return false;
        }

        //================================================================================// 

        /// <summary>
        /// This method is used to deroll students from students
        /// </summary>
        /// <param name="s">Student object</param>
        /// <param name="cID">Course ID</param>
        /// <returns></returns>
        public Boolean derolStudent(Student s, int cID)
        {
            // for loop which goes through the student courses array
            for (int i = 0; i < this.studCourses.GetUpperBound(0); i++)
            {
                // for loop which goes through the student courses array 
                for (int z = 0; z < this.studCourses.GetUpperBound(1); z++)
                {
                    // if the value in the index does not equal "none"
                    if (studCourses[i, z] != "none")
                    {
                        // if the index equals a course ID
                        if (studCourses[i, z] == cID.ToString())
                        {
                            // makes index value equal  "none"
                            studCourses[i, z] = "none";

                            // true is returned
                            return true;
                        }
                    }
                }
            }
            // false is returned
            return false;
        }

        //================================================================================// 

    }
}

