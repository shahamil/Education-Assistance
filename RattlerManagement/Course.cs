
/*
 * Name:        Course Class
 * Date:        January 17th 2012
 * Purpose:     The purpose of this class is to create instances
 *              of courses which will be used throughout the program. 
 *              The course will have both a Teacher and an array of 
 *              students. The marks are stored in large strings in the database
 *              because they exceed the size of 255 characters.
 *              
 *              The constructor of this class has a ton of information that is needed
 *              in order to create the course. It is primarily loaded and saved
 *              by the database.
 *              
 *              The marks management also happens in this class, of all the students.
 *              
 * Author:      Ramie
 *              Mellissa
 *              Moeen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RattlerManagement
{
    class Course
    {
        private int courseID;              // Variable to hold the courseID
        private string courseCode;         // Variable to hold the course code
        private Student[] courseStudentList = new Student[Config.MAX_STUDENTS_IN_CLASS];     
        // Array that holds courses for students

        //private string[] courseStudentMarks = new string[Config.MAX_STUDENTS_IN_CLASS];

        private double courseKU;           // Variable which holds course knowledge mark
        private double courseTI;           // Variable which holds course thinking mark
        private double courseCM;           // Variable which holds course communication mark
        private double courseAP;           // Variable which holds course application mark
        private double courseCulm;         // Variable which holds course culminating mark
        private double courseExam;         // Variable which holds course exam mark
        private int courseTeacher;         // Variable which holds which teacher teaches a course

        // Array which holds the marks for the courses
        private string[,] courseMarksTable = new string[Config.CATEGORIES_PER_COURSE + 2,  
                                Config.MAX_STUDENTS_IN_CLASS];
        /*
        private string[] courseKUMarks = new string[Config.MAX_STUDENTS_IN_CLASS];
        private string[] courseTIMarks = new string[Config.MAX_STUDENTS_IN_CLASS];
        private string[] courseCMMarks = new string[Config.MAX_STUDENTS_IN_CLASS];
        private string[] courseAPMarks = new string[Config.MAX_STUDENTS_IN_CLASS];
        private string[] courseCulmMarks = new string[Config.MAX_STUDENTS_IN_CLASS];
        private string[] courseExamMarks = new string[Config.MAX_STUDENTS_IN_CLASS];
         */
        private string courseRoom;         // Variable which holds the course room

        //===============================================================================================

        /// <summary>
        /// This method takes in the all the information from each course and assigns it to the variables in the class
        /// </summary>
        /// <param name="cID">Takes in the course ID</param>
        /// <param name="cCode">Takes in the course code</param>
        /// <param name="ts">Takes in the course teacher</param>
        /// <param name="cStudents">Takes in the course students</param>
        /// <param name="cMarks">Takes in course marks</param>
        /// <param name="cKU">Takes in the course knowledge mark</param>
        /// <param name="cTI">Takes in the course thinking mark</param>
        /// <param name="cCM">Takes in the course communication mark</param>
        /// <param name="cAP">Takes in the course application</param>
        /// <param name="cCulm">Takes in the course culmininating mark</param>
        /// <param name="cExam">Takes in the course exam mark</param>
        /// <param name="cKUM">Takes in the current knowledge mark in an array</param>
        /// <param name="cTIM">Takes in the current thinking mark in an array</param>
        /// <param name="cCMM">Takes in the current communication mark in an array</param>
        /// <param name="cAPM">Takes in the current application mark in an array</param>
        /// <param name="cCulmM">Takes in the current culminating mark in an array</param>
        /// <param name="cEM">Takes in the current exam mark in an array</param>
        /// <param name="cRoom">Takes in the course room</param>
        public Course(
                        int cID, string cCode, int ts,
                        Student[] cStudents, string[] cMarks,
                        double cKU, double cTI, double cCM, double cAP,
                        double cCulm, double cExam,
                        string[] cKUM, string[] cTIM, string[] cCMM,
                        string[] cAPM, string[] cCulmM, string[] cEM,
                        string cRoom
                        )
        {
            // for loop which puts the students in an array
            for (int i = 0; i < cStudents.Length; i++)
            {
                courseStudentList[i] = cStudents[i];
            }

            // All the class variables are assigned a value
            courseID = cID;
            courseRoom = cRoom;
            courseCode = cCode;
            courseKU = cKU;
            courseTI = cTI;
            courseCM = cCM;
            courseAP = cAP;
            courseCulm = cCulm;
            courseExam = cExam;
            courseTeacher = ts;

            // for loop which assigns the marks to each student
            for (int i = 0; i < Config.MAX_STUDENTS_IN_CLASS; i++)
            {

                if (cStudents[i] != null) // if the student value does not equal null, marks are assigned to the students
                {
                    courseMarksTable[0, i] = cStudents[i].getStudNumber(cStudents[i]).ToString();
                }
                else // else the mark is given "na"
                {
                    courseMarksTable[0, i] = "na";

                }

                // Marks are set for each student
                courseMarksTable[1, i] = cKUM[i];
                courseMarksTable[2, i] = cTIM[i];
                courseMarksTable[3, i] = cCMM[i];
                courseMarksTable[4, i] = cAPM[i];
                courseMarksTable[5, i] = cCulmM[i];
                courseMarksTable[6, i] = cEM[i];
                courseMarksTable[7, i] = cMarks[i];
            }
        }

        //==============================      SETTERS       =====================================

        /// <summary>
        /// This method sets the course ID for the course
        /// </summary>
        /// <param name="cIDGiven">Takes in the course ID given</param>
        public void setCourseID(int cIDGiven)
        {
            courseID = cIDGiven;   // Sets the course ID taken in and assigns it to the class variable
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This method sets the course code
        /// </summary>
        /// <param name="cCodeGiven">Takes in the course code</param>
        public void setCourseCode(string cCodeGiven)
        {
            courseCode = cCodeGiven;   // Sets the course code taken in and assignes it to the class variable
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This method sets the course teacher
        /// </summary>
        /// <param name="tGiven">Takes in the course teacher</param>
        public void setCourseTeacher(Teacher tGiven)
        {
            courseTeacher = tGiven.getTeacherNumber();    // Takes the the course teacher taken in and assigns it to the class variable
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This method sets the course KU mark
        /// </summary>
        /// <param name="cKUGiven">Takes in the course knowledge mark</param>
        public void setCourseKU(double cKUGiven)
        {
            courseKU = cKUGiven;
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This method sets the course thinking mark
        /// </summary>
        /// <param name="cTIGiven">Takes in the course thinking mark</param>
        public void setCourseTI(double cTIGiven)
        {
            courseTI = cTIGiven;
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This course sets the course communication mark
        /// </summary>
        /// <param name="cCMGiven">Takes in the course communication mark</param>
        public void setCourseCM(double cCMGiven)
        {
            courseCM = cCMGiven;
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This method sets the course application mark
        /// </summary>
        /// <param name="cAPGiven">Takes in the course application mark</param>
        public void setCourseAP(double cAPGiven)
        {
            courseAP = cAPGiven;
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This method sets the course culminating mark
        /// </summary>
        /// <param name="cCulmGiven">Takes in the course culminating mark</param>
        public void setCourseCulm(double cCulmGiven)
        {
            courseCulm = cCulmGiven;
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This method sets the course exam mark
        /// </summary>
        /// <param name="cExamGiven">Takes in the course exam mark</param>
        public void setCourseExam(double cExamGiven)
        {
            courseExam = cExamGiven;
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This function is used to set the student mark of a student in a specific index of the 2D array
        /// which defines the category for which the mark is set to.
        /// </summary>
        /// <param name="x">The course category</param>
        /// <param name="s">The student to set the mark for</param>
        /// <param name="mark">The mark to set in the form of  "N/D"</param>
        public void setStudentMark(int x, Student s, string mark)
        {
                        
            //An integer to represent the row of the student in 2D array     
            int studRow;
            for (int i = 0; i < Config.MAX_STUDENTS_IN_CLASS; i++)
            {
                //If the course marks table that has the student values is equal to the student number
                if (courseMarksTable[0, i] == s.getStudNumber(s).ToString())
                {
                    //Mark the student row as i
                    studRow = i;

                    //Get the current mark and transform it into an array
                    string[] currMark = courseMarksTable[x, studRow].Split('/');

                    //Get input mark and put it into an array
                    string[] inputMark = mark.Split('/');

                    //Get the TOTAL numberator of them both
                    int numerator = Convert.ToInt32(currMark[0]) + Convert.ToInt32(inputMark[0]);

                    //Get the total denominator of them both
                    int denominator = Convert.ToInt32(currMark[1]) + Convert.ToInt32(inputMark[1]);

                    //If the denominator is not 0 and there is no value more than 100% then save the mark
                    if (denominator != 0 || (numerator > denominator))

                    {
                        //Save the mark
                        courseMarksTable[x, studRow] = numerator.ToString() + "/" + denominator.ToString();
                    }
                    else
                    {
                        //Break

                        break;
                    }

                    //break out of loop
                    break;
                }
            }
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This method sets the total student mark for each student in a class
        /// </summary>
        /// <param name="s">Takes in a student</param>
        public void setStudentTotalMark(Student s)
        {
            // for loop which goes through every student in the class
            for (int i = 0; i < Config.MAX_STUDENTS_IN_CLASS; i++)
            {

                //If the student id matches the id on the course marks table
                if (courseMarksTable[0, i] == s.getStudNumber(s).ToString())
                {
                    
                    //Get the category weighting per category
                    double kuWeight = this.courseKU;
                    double tiWeight = this.courseTI;
                    double comWeight = this.courseCM;
                    double apWeight = this.courseAP;
                    double culmWeight = this.courseCulm;
                    double examWeight = this.courseExam;

                    //Store the marks of each student
                    double[] marks = new double[Config.CATEGORIES_PER_COURSE];


                    //Loop through the counting category indexes of the array (1-6)
                    for (int j = 1; j < 7; j++)
                    {
                        //Get the temporary marks of the course table
                        string[] tempMark = courseMarksTable[j, i].Split('/');

                        //The numerator is the one above (The first tempmark)
                        double num = Convert.ToDouble(tempMark[0]);

                        //The out of mark
                        double div = Convert.ToDouble(tempMark[1]);


                        //If there is no mark entered
                        if (div == 0)
                        {

                            //If a divider of a certain category was 
                            if ((j - 1) == 5)
                            {
                                examWeight = 0;
                            }

                            if ((j - 1) == 4)
                            {
                                culmWeight = 0;
                            }

                            if ((j - 1) == 3)
                            {
                                apWeight = 0; ;
                            }

                            if ((j - 1) == 2)
                            {
                                comWeight = 0;
                            }

                            if ((j - 1) == 1)
                            {
                                tiWeight = 0;
                            }

                            if ((j - 1) == 0)
                            {
                                kuWeight = 0;
                            }

                            //Set that category value to (The mark value)
                            marks[j - 1] = 0;

                            //Continue and go to the next index
                            continue;
                        }

                        //Set the mark for the student
                        marks[j - 1] = (num / div);
                    }


                    //Calculate the total mark

                    double totalMark = ((marks[0] * (kuWeight / 100)) + (marks[1] * (tiWeight / 100)) +
                        (marks[2] * (comWeight / 100)) + (marks[3] * (apWeight / 100)) +
                        (marks[4] * (culmWeight / 100)) + (marks[5] * (examWeight / 100))) * 100;


                    //Convert the total mark to an integer
                    int rTotal = Convert.ToInt32(totalMark);

                    //Insert the integer to the course marks table
                    courseMarksTable[7, i] = rTotal.ToString();

                    //Break out of the loop when it finds the student
                    break;
                }
            }

        }

        //==============================      GETTERS       =====================================

        /// <summary>
        /// Get the student mark from the 2D array
        /// </summary>
        /// <param name="i">The mark index needed</param>
        /// <param name="s">Student ID</param>
        /// <returns></returns>
        public string getStudentMark(int i, Student s)
        {
            //Loop through the x values
            for (int z = 0; z < courseMarksTable.GetUpperBound(0); z++)
            {
                //Loop through the y values
                if (courseMarksTable[0, z] == s.getStudNumber(s).ToString())
                {
                    //Course marks table is what is returned if the value matches the student number
                    return courseMarksTable[i, z];
                }
            }

            //Return N/A if nothing is found
            return "N/A";
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course ID
        /// </summary>
        /// <returns>Returns the course ID</returns>
        public int getCourseID()
        {
            if (this != null)   // if the object does not equal null
            {
                return this.courseID; // Returns course ID
            }

            return 0;  // Otherwise returns zero
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course code
        /// </summary>
        /// <returns>Returns the course code</returns>
        public string getCourseCode()
        {
            return this.courseCode;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course teacher
        /// </summary>
        /// <returns>Returns course teacher</returns>
        public int getCourseTeacher()
        {
            return courseTeacher;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course knowledge mark
        /// </summary>
        /// <returns>Returns the course knowledge mark</returns>
        public double getCourseKU()
        {
            return this.courseKU;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course thinking mark
        /// </summary>
        /// <returns>Returns the course thinking mark</returns>
        public double getCourseTI()
        {
            return this.courseTI;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course communication mark
        /// </summary>
        /// <returns>Returns the course communication mark</returns>
        public double getCourseCM()
        {
            return this.courseCM;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course application mark
        /// </summary>
        /// <returns>Returns the course application mark</returns>
        public double getCourseAP()
        {
            return this.courseAP;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course culminating mark
        /// </summary>
        /// <returns>Returns the course culminating mark</returns>
        public double getCourseCulm()
        {
            return this.courseCulm;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course exam mark
        /// </summary>
        /// <returns>Returns the course exam mark</returns>
        public double getCourseExam()
        {
            return this.courseExam;
        }

        //--------------------------------------------------------------------------------

     
        /// <summary>
        /// Get the total marks of the students as 
        /// an integer array
        /// </summary>
        /// <returns>The integer array</returns>
        public int[] getCourseTotalMarks()
        {
            //The total mark for each student is listed by the array
            int[] cTotalMark = new int[Config.MAX_STUDENTS_IN_CLASS];

            //Loop through the max students in class 
            for (int i = 0; i < Config.MAX_STUDENTS_IN_CLASS; i++)
            {
                //Return variable for try parse
                int ret;

                //Check to see if it is an integer
                if (int.TryParse(this.courseMarksTable[7, i], out ret))
                {
                    //If it is an integer then set the value to that integer
                    cTotalMark[i] = ret;
                }
                else
                {
                    //If not, then set the total mark as 0
                    cTotalMark[i] = 0;
                }
            }

            //Return totalmark array
            return cTotalMark;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// Get all the data joined
        /// The marks of a certain student or any column of a 2d array
        /// is joined together and stored
        /// </summary>
        /// <param name="x">The index of the 2d array that is needed</param>
        /// <returns></returns>
        public string getJoinedData(int x)
        {
            //Return data is made by the max students in class
            string[] returnData = new string[Config.MAX_STUDENTS_IN_CLASS];

            //Loop through max possible students
            for (int i = 0; i < Config.MAX_STUDENTS_IN_CLASS; i++)
            {
                //Set the returndata to the index of they array that is wanted
                returnData[i] = this.courseMarksTable[x, i];
            }

            //Join the result array with ";"
            string result = string.Join(";", returnData);

            //Return the result array
            return result;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course room number
        /// </summary>
        /// <returns>Returns the course room number</returns>
        public string getCourseRoom()
        {
            return courseRoom;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// This method gets the course students in an array
        /// </summary>
        /// <returns>Returns the course student list</returns>
        public Student[] getCourseStudents()
        {
            return courseStudentList;
        }

        //--------------------------------------------------------------------------------

        /// <summary>
        /// Get the amount of students in a course
        /// </summary>
        /// <returns></returns>
        public int getAmountOfStudents()
        {
            //A counter variable for the amount of students
            int c = 0;
            
            //Go through the course list
            for (int i = 0; i < courseStudentList.Length; i++)
            {
                //If something exists
                if (courseStudentList[i] != null)
                {
                    //Add to the counter
                    c++;
                }
            }

            //return the amount
            return c;

        }

        //==========================================================================

        /// <summary>
        /// Remove the student, if removal was successful then return true
        /// </summary>
        /// <param name="s">The student that needs to be removed from the course</param>
        /// <returns></returns>
        public Boolean RemoveStudent(Student s)
        {

            //Go through the student list of the course
            for (int i = 0; i < courseStudentList.Length; i++)
            {
                //If there is a student existent in the selected index
                if (courseStudentList[i] != null)
                {
                    //If the student number matches the number on the array
                    if (courseStudentList[i].getStudNumber(courseStudentList[i]) ==
                                            s.getStudNumber(s))
                    {
                        //Now remove their data from the 2D array
                        for (int z = 0; z < courseMarksTable.GetUpperBound(0); z++)
                        {

                            //Set the values for it if they are equal to the student
                            if (s.getStudNumber(s).ToString() == courseMarksTable[0, z])
                            {
                                //Setting the values
                                courseMarksTable[0, z] = "na";
                                courseMarksTable[1, z] = "0/0";
                                courseMarksTable[2, z] = "0/0";
                                courseMarksTable[3, z] = "0/0";
                                courseMarksTable[4, z] = "0/0";
                                courseMarksTable[5, z] = "0/0";
                                courseMarksTable[6, z] = "0/0";
                                courseMarksTable[7, z] = "0";
                            }

                        }
                        
                        //Set the student list of the student to null of the index
                        courseStudentList[i] = null;
                        
                        //Return true
                        return true;

                    }
                }
            }

            //Return false
            return false;
        }

        //--------------------------------------------------------------------

        /// <summary>
        /// This function is used to add a student to the course
        /// </summary>
        /// <param name="s">The student they want to add</param>
        /// <returns>True/False</returns>
        public Boolean AddStudent(Student s)
        {
            //Go through the course student list
            for (int i = 0; i < courseStudentList.Length; i++)
            {

                //If the list array index is null 
                if (courseStudentList[i] == null)
                {

                    //Check the marks table
                    for (int z = 0; z < courseMarksTable.GetUpperBound(0); z++)
                    {

                        //If there is no student held up in the spot
                        if (courseMarksTable[0, z] == "na")
                        {
                            //Add the student ID to the marks table
                            courseMarksTable[0, z] = s.getStudNumber(s).ToString();

                            //Break out of loop
                            break;
                        }


                    }

                    //Course student list is going to have the student now
                    courseStudentList[i] = s;

                    //Return true
                    return true;
                }
            }

            //Return false
            return false;
        }

        //=======================================================================================
    }
}
