/*
 * Name:        Database Class
 * Date:        January 20th 2012
 * 
 * Purpose:     This is the most important class of the whole program.
 *              It saves,loads and manages the information of the school
 *              system. It saves and loads courses, students, teachers and 
 *              returns all types of data from its method. It is crucial
 *              because all the communication between the server and the
 *              client program happens on here.
 *              
 * Author:      Ramie Raufdeen
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace RattlerManagement
{
    class DatabaseConnection
    {
        /// <summary>
        /// These variables are the temporary variables that the database class uses to store and
        /// get data.
        /// </summary>
        private static Student sTemp;
        private static Teacher tTemp;
        private static Course cTemp;
        private static Equipment eTemp;

        /// <summary>
        /// This function is used to set the temporary student set in the class
        /// </summary>
        /// <param name="so">Set the temporary student to the student given</param>
        private static void setStudent(Student so)
        {
            //Setting the temporary student
            sTemp = so;
        }

        /// <summary>
        /// This function is used to set the temporary teacher set in the class
        /// </summary>
        /// <param name="to">Set the temporary teacher to the teacher given</param>
        private static void setTeacher(Teacher to)
        {
            //Transferring the data
            tTemp = to;
        }

        /// <summary>
        /// This function is used to set the temporary course in the class
        /// </summary>
        /// <param name="co">The temporary course to set it to</param>
        private static void setCourse(Course co)
        {
            //Transferring data
            cTemp = co;
        }

        /// <summary>
        /// This function is used to set the temporary equipment in the class 
        /// </summary>
        /// <param name="eo">The equipment variable</param>
        private static void setEquipment(Equipment eo)
        {
            //Transferring parameters to set data
            eTemp = eo;
        }

        /// <summary>
        /// This is a getter to get the temporary course and returns it as a course variable
        /// </summary>
        /// <returns></returns>
        private static Course getTempCourse()
        {
            return cTemp;
        }


        private static Equipment getTempEquipment()
        {
            return eTemp;
        }


        private static Teacher getTempTeacher()
        {
            return tTemp;
        }


        private static Student getTempStudent()
        {
            return sTemp;
        }

        /// <summary>
        /// This function gets the teacher as a Teacher Variable and returns it to the class
        /// </summary>
        /// <param name="tNumber">The teacher number to search and find and return</param>
        /// <returns></returns>
        public static Teacher getTeacher(int tNumber)
        {
            //Set the teacher to null in the temporary data, just incase theres already a value there
            setTeacher(null);

            //Try to run the query
            try
            {


                //New MySQL connection variable
                MySqlConnection edusistConnection = new MySqlConnection(Config.DATABASE_CONNECTION_STRING);

                //Create a new command in the ticTacToe connection instance
                MySqlCommand edusistCommand = edusistConnection.CreateCommand();

                try
                {
                    //Try to open the mySQL connection
                    edusistConnection.Open();
                }

                    //If it can't connect to the Mysql Server for any reason
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //Print the message on the console
                }

                //Setting the query that is going to be run
                edusistCommand.CommandText = "SELECT * FROM `teacher` WHERE tNumber ='" + tNumber + "'";

                //Execute the query
                MySqlDataReader fetch = edusistCommand.ExecuteReader();


                //While the query is being read 
                while (fetch.Read())
                {

                    //Initialize the courses array to load
                    Course[] tCourses = new Course[Config.MAX_TEACHER_COURSES];

                    //Load the courses for the current teacher
                    for(int td =0; td<Config.MAX_TEACHER_COURSES; td++){

                        //Load from the tCurrCourse column in the array, if the value is not 0 (Which is default value)
                        if (fetch["tCurrCourse" + (td + 1)].ToString() != "0")
                        {
                            //Get the courses from the database if there is a value other than 1
                            tCourses[td] = getCourse(Convert.ToInt32(fetch["tCurrCourse" + (td + 1)].ToString()));
                        }

                    }


                    //Create a new teacher instance with the data
                    Teacher tTeacher = new Teacher(Convert.ToInt32(fetch["tNumber"].ToString()),
                                            //The teacher number

                                            fetch["tFirstName"].ToString(),
                                            //Teacher first Name

                                            fetch["tLastName"].ToString(),
                                            //Teacher last name
                                            
                                            fetch["tPassword"].ToString(),
                                            //Teacher Password

                                            fetch["tEmail"].ToString(),
                                            //Teacher email

                                            tCourses);
                                            //Submit the teacher courses
                 
                    //Set the teacher to the current teacher that we have created
                    setTeacher(tTeacher);


                }


                //Close the reader
                fetch.Close();

                //Close the sql connection
                edusistConnection.Close();


                //Return the temporary teacher that we hav
                if (getTempTeacher() != null)
                {
                    //Return the teacher
                    return getTempTeacher();
                }

            }
            
                //Catch the exception if you cant
            catch (Exception e)
            {

                //Print the reason
                Console.WriteLine(e);


            }

            //Return null
            return null;
            
        }


        /// <summary>
        /// This fucntion is used to get the teacher for the courses privately
        /// (Only used in this class)
        /// </summary>
        /// <param name="tNumber">The teacher number to load</param>
        /// <returns>Returns the teacher variable</returns>
        private static Teacher getTeacherForCourse(int tNumber)
        {
            //Set the teacher to null temporarily just incase someone else was there
            setTeacher(null);

            //Try to execute the code
            try
            {


                //New MySQL connection variable
                MySqlConnection edusistConnectionN = new MySqlConnection(Config.DATABASE_CONNECTION_STRING);

                //Create a new command in the ticTacToe connection instance
                MySqlCommand edusistCommand = edusistConnectionN.CreateCommand();

                try
                {
                    //Try to open the mySQL connection
                    edusistConnectionN.Open();
                }

                    //If it can't connect to the Mysql Server for any reason
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //Print the message on the consoleg
                }

                //Setting the query that is going to be run
                edusistCommand.CommandText = "SELECT * FROM `teacher` WHERE tNumber ='" + tNumber + "'";

                //Execute the query
                MySqlDataReader fetch = edusistCommand.ExecuteReader();


                //While the query is being read 
                while (fetch.Read())
                {
                    //Initialize the courses array to load
                    Course[] tCourses = new Course[Config.MAX_TEACHER_COURSES];

                    //Load the courses for the current teacher
                    for (int td = 0; td < Config.MAX_TEACHER_COURSES; td++)
                    {

                        //Load from the tCurrCourse column in the array, if the value is not 0 (Which is default value)
                        if (fetch["tCurrCourse" + (td + 1)].ToString() != "0")
                        {
                            //Get the courses from the database if there is a value other than 1
                            tCourses[td] = getCourse(Convert.ToInt32(fetch["tCurrCourse" + (td + 1)].ToString()));
                        }

                    }


                    //Create a new teacher instance with the data
                    Teacher tTeacher = new Teacher(Convert.ToInt32(fetch["tNumber"].ToString()),

                        //The teacher number

                                            fetch["tFirstName"].ToString(),
                        //Teacher first Name

                                            fetch["tLastName"].ToString(),
                        //Teacher last name

                                            fetch["tPassword"].ToString(),
                        //Teacher Password

                                            fetch["tEmail"].ToString(),
                        //Teacher email

                                            tCourses);
                    //Submit the teacher courses

                    //Set the teacher to the current teacher that we have created
                    setTeacher(tTeacher);



                }


                //Close reader
                fetch.Close();

                //Close connection
                edusistConnectionN.Close();


                //Return tempteacher if it is exist
                if (getTempTeacher() != null)
                {
                    //Returning the variables
                    return getTempTeacher();
                }


            }
            catch (Exception e)
            {

                //Print the reason
                Console.WriteLine(e);


            }

            return null;

        }

        /// <summary>
        /// Save the teacher in the database
        /// </summary>
        /// <param name="t">The teacher as an object to save</param>
        public static void saveTeacher(Teacher t)
        {
            //Try to execute the query
            try{

                //This array holds the teacher name
            string[] teacherName = t.getTeacherName().Split(' ');

                //This string will hold the courses of the teachers (The course IDs)
            string[] courseValues = new string[Config.MAX_TEACHER_COURSES];

                //This function is used to get the courses from the teachers
            for (int i = 0; i < courseValues.Length; i++)
            {
                //If the course value of the teacher course array is not null
                if (t.getTeacherCourse(i) != null)
                {

                    //Set the course ID as a string
                    courseValues[i] = t.getTeacherCourse(i).getCourseID().ToString();
                }
                else
                {
                    //If there is no value, make the coursevalue 0
                    courseValues[i] = "0";
                }
            }

            //Call the execute query function to make sure that the teacher information is saved
            executeQuery("UPDATE teacher SET `tNumber` = '" + t.getTeacherNumber() +

                        //The first name of the teacher
                            "', `tFirstName` = '" + teacherName[0] +

                        //The last name of the teacher
                            "', `tLastName` = '" + teacherName[1] +

                        //The password of the teacher
                            "', `tPassword` = '" + t.GetTeachPassword() +

                        //The email of the teacher
                            "', `tEmail` = '" + t.getTeacherEmail() +

                        //The courses of the teacher
                            "', `tCurrCourse1` = '" + courseValues[0] +

                            "', `tCurrCourse2` = '" + courseValues[1] +

                            "', `tCurrCourse3` = '" + courseValues[2] +

                            "', `tCurrCourse4` = '" + courseValues[3] +

                            "', `tCurrCourse5` = '" + courseValues[4] +

                            "', `tCurrCourse6` = '" + courseValues[5] +

                            "', `tCurrCourse7` = '" + courseValues[6] +

                            "', `tCurrCourse8` = '" + courseValues[7] +
                        
                        //Index the row by the following number given of the teacher
                            "' WHERE `tNumber` = '" + t.getTeacherNumber() + "'");

            }
                //Catch statement for exception
            catch (Exception e)
            {
                //Print the exception
                Console.WriteLine(e);
            }
        }


        /// <summary>
        /// This function saves the course in the database
        /// </summary>
        /// <param name="course">The Course variable</param>
        public static void saveCourse(Course course)
        {
            try
            {
                //Call the execute query function to make sure that the pets information is saved
                executeQuery("UPDATE course SET `cID` = '" + course.getCourseID() +

                                //The course code
                                "', `cCode` = '" + course.getCourseCode() +

                                //The course teacher (Save as an integer)
                                "', `cTeacher` = '" + course.getCourseTeacher() +

                                //The course student list
                                "', `cStudentList` = '" + course.getJoinedData(0) +

                                //The course student marks
                                "', `cStudentMarks` = '" + course.getJoinedData(7) +

                                //The course Knowledge and Understanding
                                "', `cKU` = '" + course.getCourseKU() +

                                //The course T/I Mark
                                "', `cTI` = '" + course.getCourseTI() +

                                //The course communication mark
                                "', `cCM` = '" + course.getCourseCM() +

                                //The course Application mark
                                "', `cAP` = '" + course.getCourseAP() +

                                //The course culminating mark
                                "', `cCulm` = '" + course.getCourseCulm() +

                                //The course Exam mark
                                "', `cExam` = '" + course.getCourseExam() +
                                "', `cKUMarks` = '" + course.getJoinedData(1) +
                                "', `cTIMarks` = '" + course.getJoinedData(2) +
                                "', `cCMMarks` = '" + course.getJoinedData(3) +
                                "', `cAPMarks` = '" + course.getJoinedData(4) +
                                "', `cCulmMarks` = '" + course.getJoinedData(5) +
                                "', `cExamMarks` = '" + course.getJoinedData(6) +

                                //Get the room of the course
                                "', `cRoom` = '" + course.getCourseRoom() +

                                //Put it to lowercase so the pet can be loaded later without any issues
                                "' WHERE cID = '" + course.getCourseID() + "'");


            }

                //Catch exception error
            catch (Exception e)
            {
                //Print the error
                Console.WriteLine(e);
            }
 
        }


        /// <summary>
        /// This function is used to get the course from the database
        /// </summary>
        /// <param name="cID">The course ID is given to get from the database</param>
        /// <returns>Return the course as a Course object</returns>
        public static Course getCourse(int cID)
        {
            

            try
            {
               

                //New MySQL connection variable
                MySqlConnection edusistConnection = new MySqlConnection(Config.DATABASE_CONNECTION_STRING);

                //Create a new command in the ticTacToe connection instance
                MySqlCommand edusistCommand = edusistConnection.CreateCommand();

                try
                {
                    //Try to open the mySQL connection
                    edusistConnection.Open();
                }

                    //If it can't connect to the Mysql Server for any reason
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //Print the message on the console
                }

                //Setting the query that is going to be run
                edusistCommand.CommandText = "SELECT * FROM `course` WHERE cID ='" + cID + "' LIMIT 1";

                //Execute the query
                MySqlDataReader fetch = edusistCommand.ExecuteReader();


                //While the query is being read 
                while (fetch.Read())
                {
                    //Create a temporary array for studentlist
                     Student[] sList = new Student[Config.MAX_STUDENTS_IN_CLASS];

                    //Split the studentlist string by the ; that seperate it
                    string[] studentNameList = fetch["cStudentList"].ToString().Split(';');

                    //Go through the string of lists and load students for those names
                    for(int i =0; i<studentNameList.Length;i++){

                        //If the value is not null
                        if (loadStudent(studentNameList[i]) != null)
                        {
                            //Load the student
                            sList[i] = loadStudent(studentNameList[i]);
                        }
                    }
                    
                 
                    //Load the other marks and split them by ; and place them in string arrays
                    string[] cMarks = fetch["cStudentMarks"].ToString().Split(';');
                    string[] cKUMarks = fetch["cKUMarks"].ToString().Split(';');
                    string[] cTIMarks = fetch["cTIMarks"].ToString().Split(';');
                    string[] cCMMarks = fetch["cCMMarks"].ToString().Split(';');
                    string[] cAPMarks = fetch["cAPMarks"].ToString().Split(';');
                    string[] cCulmMarks = fetch["cCulmMarks"].ToString().Split(';');
                    string[] cExamMarks = fetch["cExamMarks"].ToString().Split(';');

                    //Get the id of the teacher and put as int
                    int t =  Convert.ToInt32(fetch["cTeacher"].ToString());

                    //Create a new instance of the course
                    Course rCourse = new Course(cID,                                    //The course id
                                            fetch["cCode"].ToString(),                  //The course code
                                            t,                                          //The teacher id as an integer
                                            sList,                                      //The student list
                                            cMarks,                                     //The course marks
                                            
                                            Convert.ToDouble(fetch["cKU"].ToString()),  //The Mark weights for categories
                                            Convert.ToDouble(fetch["cTI"].ToString()),
                                            Convert.ToDouble(fetch["cCM"].ToString()),
                                            Convert.ToDouble(fetch["cAP"].ToString()),
                                            Convert.ToDouble(fetch["cCulm"].ToString()),
                                            Convert.ToDouble(fetch["cExam"].ToString()),

                                            //The marks as a string array
                                            cKUMarks, cTIMarks, cCMMarks, cAPMarks, cCulmMarks, cExamMarks,

                                            //The room of the course
                                            fetch["cRoom"].ToString());


                    //Set the course as rCourse
                    setCourse(rCourse);
                   
                }

                
                //Close the reader
                fetch.Close();

                //Close the edusist connection
                edusistConnection.Close();


                //Get the temporary course, and if it is not null
                if (getTempCourse() != null)
                {
                    //Return the temporary course in this class
                    return getTempCourse();
                }
            }

                //Catch the exception error
            catch (Exception e)
            {

                //Print the reason
                Console.WriteLine(e);


            }

            //If no data is loaded, then return null
            return null;
        }

        
        /// <summary>
        /// This function saves the equipment that is being rented
        /// </summary>
        /// <param name="eq">The equipment for which to save</param>
        public static void SaveEquipment(Equipment eq)
        {
            try
            {
                //Make a string called daysstrings for max school days
                string[] dayStrings = new string[Config.MAX_SCHOOL_DAYS];

                //If the equipment is disabled or not
                int dis;

                //Disabled
                if (eq.GetoDisabled())
                {
                    dis = 1;
                }
                    //Not Disabled
                else
                {
                    dis = 0;
                }

                //Call the execute query function to make sure that the pets information is saved
                executeQuery("UPDATE objects SET `oID` = '" + eq.GetoID().ToString() +

                                //The object name
                                "', `oName` = '" + eq.GetoName() +

                                //The object disabled?
                                "', `oDisabled` = '" + dis +

                                //Put it to lowercase so the pet can be loaded later without any issues
                                "' WHERE oId = '" + eq.GetoID().ToString() + "'");

                //Update the status of the day of the object
                for (int y = 0; y < Config.MAX_SCHOOL_DAYS; y++)
                {
                    //Updating the stuff
                    executeQuery("UPDATE objects SET `oDay"+(y+1)+"` = '" + eq.getRentalDay(y) +

                        //Put it to lowercase so the pet can be loaded later without any issues
                    "' WHERE oId = '" + eq.GetoID().ToString() + "'");
                }
 

            }
            //If it cant execute the query
            catch (Exception e)
            {
                //Print out the exception
                Console.WriteLine(e);

            }
        }



        /// <summary>
        /// This function is used to load an equipment piece
        /// </summary>
        /// <param name="i">Use a certain ID to load the equipment</param>
        /// <returns>Returns the loaded equipment as an Equipment data type</returns>
        public static Equipment loadEquipment(int i)
        {

            //Set the equipment initially as null
            setEquipment(null);

            try
            {

                //New MySQL connection variable
                MySqlConnection edusistConnection = new MySqlConnection(Config.DATABASE_CONNECTION_STRING);

                //Create a new command in the ticTacToe connection instance
                MySqlCommand edusistCommand = edusistConnection.CreateCommand();

                try
                {
                    //Try to open the mySQL connection
                    edusistConnection.Open();
                }

                    //If it can't connect to the Mysql Server for any reason
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //Print the message on the console
                }

                //Setting the query that is going to be run
                edusistCommand.CommandText = "SELECT * FROM `objects` WHERE oID='" + i.ToString() + "'";

                //Execute the query
                MySqlDataReader fetch = edusistCommand.ExecuteReader();

                //While the query is being read 
                while (fetch.Read())
                {
                    //Make a new instance of the equipment which will be used to return the value
                    Equipment returnEquipment = new Equipment(Convert.ToInt32(fetch["oID"].ToString()),
                                                    fetch["oName"].ToString(),
                                                    Convert.ToInt32(fetch["oDisabled"].ToString()));

                    //The object schedule as a 2d array (Get it from Config class :Dimensions)
                    string[,] oSchedule = new string[Config.MAX_SCHOOL_DAYS, 
                        Config.MAX_HOURS_PER_DAY];

                    //Loop through the values of the days
                    for(int k = 0; k<Config.MAX_HOURS_PER_DAY; k++){

                        //Get the schedule for each day
                        string[] tSchedule = fetch["oDay" + (i + 1) + ""].ToString().Split(';');

                        //Set the schedule day and hours 
                        for (int z = 0; z < tSchedule.Length; z++)
                        {
                            //Object schedule being set
                            oSchedule[i, z] = tSchedule[z];
                        }
                    }

                    //Set the rental schedule
                    returnEquipment.setRentalSchedule(oSchedule);

                    //Set the equipment to return
                    setEquipment(returnEquipment);

                }

                
             
                //Close the reader
                fetch.Close();


                //Close the connection
                edusistConnection.Close();

                //Get the temporary equipment 
                if (getTempEquipment() != null)
                {
                    return getTempEquipment();
                    //Return it
                }
            }
            catch (Exception e)
            {

                //Print the reason
                Console.WriteLine(e);


            }
            
            //If database connection failed, then return null
            return null;

        }

        /// <summary>
        /// Boolean to check if the user has entered the correct information on login
        /// </summary>
        /// <param name="username">Entered Username (Lower Cased)</param>
        /// <param name="password">Entered Password (Lower Cased)</param>
        /// <returns>True/False (Correct Login/Incorrect Login)</returns>
        public static Student loadStudent(string username)
        {
            try
            
            {
                if(Config.TryToParse(username)){
                Student temp = new Student(Convert.ToInt32(username));
    
                //New MySQL connection variable
                MySqlConnection edusistConnection = new MySqlConnection(Config.DATABASE_CONNECTION_STRING);

                //Create a new command in the ticTacToe connection instance
                MySqlCommand edusistCommand = edusistConnection.CreateCommand();

                try
                {
                    //Try to open the mySQL connection
                    edusistConnection.Open();
                }

                    //If it can't connect to the Mysql Server for any reason
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //Print the message on the console
                }

                //Setting the query that is going to be run
                edusistCommand.CommandText = "SELECT * FROM student WHERE sNumber='" + Convert.ToInt32(username) + "'";

                //Execute the query
                MySqlDataReader fetch = edusistCommand.ExecuteReader();
                
                //While the query is being read 
                while (fetch.Read())
                {
                    
                    //Make a new string array for the student information
                    string[] studentInformation = new string[10];

                    /////LOADING THE ACTUAL INFORMATION OF THE STUDENT/////
                    studentInformation[0] = (fetch["sNumber"].ToString());
                    studentInformation[1] = (fetch["sPassword"].ToString());
                    studentInformation[2] = (fetch["sFirstName"].ToString());
                    studentInformation[3] = (fetch["sLastName"].ToString());
                    studentInformation[4] = (fetch["sDOB"].ToString());
                    studentInformation[5] = (fetch["sGrade"].ToString());
                    studentInformation[6] = (fetch["sEmail"].ToString());
                    studentInformation[7] = (fetch["sParentName"].ToString());
                    studentInformation[8] = (fetch["sParentPhone"].ToString());
                    studentInformation[9] = (fetch["sHomeAddress"].ToString());
       

                    //Load the comments in a 2D array
                    string[,] studComments = new string[Config.MAX_STUDENT_YEARS,
                        Config.MAX_STUDENT_COMMENTS];

                    //Load the student comments in a 2D array
                    string[,] studCourses = new string[Config.MAX_STUDENT_YEARS,
                        Config.MAX_TEACHER_COURSES];


                    //Loop through for the years of the students
                    for (int i = 0; i < Config.MAX_STUDENT_YEARS; i++)
                    {

                        //Loop through max comments
                        for (int z = 0; z < Config.MAX_STUDENT_COMMENTS; z++)
                        {
                            //Load comments for the years of the iterator if it isnt "none"
                            if (fetch["sComments" + (i + 1) + "-" + (z + 1)].ToString() != "none")
                            {
                                //Store comments in the 2D Array
                                studComments[i, z] = (fetch["sComments" + (i + 1) + "-" + (z + 1)].ToString());
                            }
                        }
               
                        //Loop through the courses
                        for (int z = 0; z < Config.MAX_STUDENT_COURSES; z++)
                        {
                            //Load the courses
                            studCourses[i, z] = (fetch["sC" + (z+1) + "Y" + (i+1)].ToString());

                        }
                    }
                    
                    //Set the information of the students
                    temp.setStudComments(studComments, temp);

                    //Set the courses 
                    temp.setStudCourses(studCourses, temp);

                    //Pass the information to the student object
                    temp.getStudentArray(studentInformation, temp);

                    //Set the student object
                    setStudent(temp);
                }

                //Close the reader
                fetch.Close();

                //Close the mysql connection, we got everything we need
                edusistConnection.Close();

                    //If the temporary student is not null
                if (getTempStudent() != null)
                {

                    //Return the temporary student and get it from this class
                    return getTempStudent();
                }
                //Try to connect (If it cant connect)
                }
            }
            
                //Catch the exception and print it
            catch (Exception e)
            {

                //Print the reason
                Console.WriteLine(e);

             
            }

            return null;
        }


        /// <summary>
        /// This function is used to save the student
        /// </summary>
        /// <param name="s">Student s is what is used to save the data</param>
        public static void saveStudent(Student s)
        {
            try
            {

                //Call the execute query function to make sure that the STUDENT information is saved
                executeQuery("UPDATE student SET `sNumber` = '" + s.getStudNumber(s) +
                                "', `sPassword` = '" + s.getStudPassword(s) +
                                "', `sFirstName` = '" + s.getStudFirstName(s) +
                                "', `sLastName` = '" + s.getStudLastName(s) +
                                "', `sDOB` = '" + s.getDOB(s) +
                                "', `sGrade` = '" + s.getstudGrade(s) +
                                "', `sEmail` = '" + s.getStudEmail(s) +
                                "', `sParentName` = '" + s.getStudParentName(s) +
                                "', `sParentPhone` = '" + s.getStudParentPhone(s) +
                                "', `sHomeAddress` = '" + s.getStudHomeAddress(s) +

                                //Put it to lowercase so the pet can be loaded later without any issues
                                "' WHERE sNumber = '" + s.getStudNumber(s) + "'");
                 
                //Loop through the student years
                for (int i = 0; i < Config.MAX_STUDENT_YEARS; i++)
                {

                    //Loop through the comments
                    for (int z = 0; z < Config.MAX_STUDENT_COMMENTS; z++)
                    {
                        //Concatenate the columns of the table to load them
                        string commentString = "sComments"+(i+1)+"-"+(z+1)+"";

                        //Update the rows that are given by the concatenated string above
                        executeQuery("UPDATE student SET `"+commentString+"` = '" + s.getStudentComments(i,z,s) +
                               "' WHERE sNumber = '" + s.getStudNumber(s) + "'");

                    }

                    //Loop through the courses of the students
                    for (int y = 0; y < Config.MAX_STUDENT_COURSES; y++)
                    {
                        //Prepare the content comment string to be read by the mysql reader
                        string commentString = "sC" + (y + 1) + "Y" + (i + 1) + "";

                        //If the course is not null
                        if (s.getStudentCourses(i, y, s) != null)
                        {
                            //Update the value in the mysql table
                            executeQuery("UPDATE student SET `" + commentString + "` = '" +
                                s.getStudentCourses(i, y, s) +
                                "' WHERE sNumber = '" + s.getStudNumber(s) + "'");
                        }
                    }
                }

            }
            //If it cant execute the query
            catch (Exception e)
            {
                //Print out the exception
                Console.WriteLine(e);

            }
        }

        /// <summary>
        /// This function fires a teacher (Removes them from database)
        /// </summary>
        /// <param name="t">Gets the teacher as a Teacher variable</param>
        /// <returns>True/False</returns>
        public static Boolean fireTeacher(Teacher t)
        {
            //A loop procedure to check if the teacher has any course
            for(int i=0; i<t.getTeacherCourses().Length; i++){

                //If the teacher has any course
                if (t.getTeacherCourse(i) != null)
                {
                    //Return false
                    return false;
                }
            }
            

            try
            {
                //Execute the query to remove the pet from the pets table
                executeQuery("DELETE FROM teacher WHERE tNumber = '" + t.getTeacherNumber() + "'");
                return true;

            }
            //If it cant execute the query
            catch (Exception e)
            {
                //Print out the exception
                Console.WriteLine(e);

                //Return false
                return false;
            }

        }

       
        /// <summary>
        /// This boolean checks to see if the user has entered the correct login
        /// </summary>
        /// <param name="username">Saves the username</param>
        /// <param name="password">Saves the password</param>
        /// <param name="i">The role of the user (teacher, student, principal)</param>
        /// <returns>Returns the boolean as true/false (If user info is 
        /// correct as the one in database or not)</returns>
        public static bool checkUser(string username, string password, int i)
        {
            try
            {
                //Search tables depending on the roles
                string[] searchTables = { "student", "teacher", "principal" };

                string[] preFixes = { "s", "t", "p" };

                //Give default value for realPass (To be loaded from mySQL)
                string realPass = "";

                //New MySQL connection variable
                MySqlConnection edusistConnection = new MySqlConnection(Config.DATABASE_CONNECTION_STRING);

                //Create a new command in the ticTacToe connection instance
                MySqlCommand edusistCommand = edusistConnection.CreateCommand();

                try
                {
                    //Try to open the mySQL connection
                    edusistConnection.Open();
                }

                    //If it can't connect to the Mysql Server for any reason
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //Print the message on the console
                }

                //Increase the progress bar of the config file

                //Setting the query that is going to be run
                edusistCommand.CommandText = "SELECT * FROM "+searchTables[i]+" WHERE "+
                                    preFixes[i]+"Number='" + Convert.ToInt32(username) + "'";

                //Execute the query
                MySqlDataReader fetch = edusistCommand.ExecuteReader();

                //While the query is being read 
                while (fetch.Read())
                {
                    //Get the real password of the user
                    realPass = (fetch[""+preFixes[i]+"Password"].ToString());

                }

                //Close the reader
                fetch.Close();

                //Close the mysql connection, we got everything we need
                edusistConnection.Close();

                //Now decide if the user has entered the correct information or not
                if (realPass.ToLower() == password.ToLower())
                //If the entered encrypted password is equal to the real password
                {

                    //PASS
                    return true;
                }
                else
                {
                    //FAIL
                    return false;
                }

                //Try to connect (If it cant connect)
            }
            catch (Exception e)
            {

                //Print the reason
                Console.WriteLine(e);

                //Return true to continue, if mysql doesnt work
                return true;
            }
        }

     



        /// <summary>
        /// This function will take in ANY MySQL syntaxed query and run it 
        /// </summary>
        /// <param name="query">The query that the user would like to run</param>
        public static Boolean executeQuery(string query)
        {
            try
            {
                //Try to create a new Mysqlconnection Variable called vpetConnection using the connection string
                MySqlConnection vpetConnection = new MySqlConnection(Config.DATABASE_CONNECTION_STRING);

                try
                {
                    //Try to open the dATABASE connection (Connect to Mysql Database)
                    vpetConnection.Open();
                }
                //If it cant connect
                catch (Exception e)
                {

                    //Catch the exception and print it on console
                    Console.WriteLine(e.Message);
                    return false;
                }



                MySqlCommand registration = new MySqlCommand(query, vpetConnection);
                //Make a new instance of MySql command called registration
                //Use the query and the Connection as parameters
                try
                {
                    //TRY TO Execute the MySql Code
                    registration.ExecuteNonQuery();
                    vpetConnection.Close();
                    return true;
                }

                    //Print out error if it cant execute
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    vpetConnection.Close();
                    return false;
                }
                //Close ticTacToe connection (Mysql Connection Close)


                //If it can't connect for any reason, then catch error and print
            }
            catch (Exception e)
            {
                //Print the exception
                Console.WriteLine(e);

                //Return false
                return false;

            }

        }


        // <summary>
        /// This method inserts teacher into database
        /// </summary>
        /// <param name="tID">teacher number</param>
        /// <param name="tFirstName">teacher firstname</param>
        /// <param name="tLastName">teacher lastname</param>
        /// <param name="tPassword">teacher password</param>
        /// <param name="tEmail">teacher email</param>
        /// <param name="tCourses">teacher courses</param>
        public static void insertTeacher(int tID, string tFirstName, string tLastName, string tPassword, string tEmail,
                        string[] tCourses)
        {
            //Query being executed in the class to save in the SQL database 
            executeQuery("INSERT INTO teacher (tNumber, tFirstName, tLastName, tPassword, tEmail, tCurrCourse1, tCurrCourse2, tCurrcourse3, tCurrCourse4, tCurrCourse5, tCurrcourse6," +
                        " tCurrCourse7, tCurrCourse8) values" +
                                  "('" + tID + "','" + tFirstName + "','" + tLastName + "','" + tPassword + "','" +
                                  tEmail + "','" + tCourses[0] + "','" + tCourses[1] + "','" + tCourses[2] + "','" + tCourses[3] + "'" +
                                  ",'" + tCourses[4] + "','" + tCourses[5] + "','" + tCourses[6] + "','" + tCourses[7] + "')");

        }


        /// <summary>
        /// This method inserts course into database
        /// </summary>
        /// <param name="cID">course id</param>
        /// <param name="cCode">course code</param>
        /// <param name="cTeacher">course teacher</param>
        /// <param name="sList">student list</param>
        /// <param name="sMarks">students marks</param>
        /// <param name="cKU">course knowlegde and understanding</param>
        /// <param name="cTI">course thinking and inquiry</param>
        /// <param name="cCM">course communication</param>
        /// <param name="cAP">course application</param>
        /// <param name="cCulm">course culiminating </param>
        /// <param name="cExam">course exam</param>
        /// <param name="cKUMarks">course knowlegde and understanding marks</param>
        /// <param name="cTIMarks">course thinking and inquiry marks</param>
        /// <param name="cCMMarks">course communication marks</param>
        /// <param name="cAPMarks">course application marks</param>
        /// <param name="cCulmMarks">course culiminating marks</param>
        /// <param name="cExamMarks">course exam marks</param>
        /// <param name="cRoom">course room</param>
        /// <returns></returns>
        public static Boolean insertCourse(int cID, string cCode, string cTeacher, string[] sList, string[] sMarks,
                        double cKU, double cTI, double cCM, double cAP, double cCulm, double cExam,
                        string[] cKUMarks, string[] cTIMarks, string[] cCMMarks, string[] cAPMarks,
                        string[] cCulmMarks, string[] cExamMarks, string cRoom)
        {

            //The string arrays that have been given in are joined together to submit to the database
            string studentList = string.Join(";", sList);

            string studentMarks = string.Join(";", sMarks);

            string studentKU = string.Join(";", cKUMarks);

            string studentTI = string.Join(";", cTIMarks);

            string studentCM = string.Join(";", cCMMarks);

            string studentAP = string.Join(";", cAPMarks);

            string studentCulm = string.Join(";", cCulmMarks);

            string studentExam = string.Join(";", cExamMarks);

            //Query being executed in the class to save in the SQL database 
            executeQuery("INSERT INTO course (cID, cCode, cTeacher, cStudentList, cStudentMarks," +
                " cKU, cTI, cCM, cAP, cCulm, cExam, cKUMarks, cTIMarks, cCMMarks, cAPMarks, cCulmMarks, cExamMarks," +
                        " cRoom) values" +

                                    //Submitting the information 
                                  "('" + cID + "','" + cCode + "','" + cTeacher + "','" + studentList + "','" +
                                  studentMarks + "','" + cKU + "','" + cTI + "','" + cCM + "','" + cAP + "','" +

                                  cCulm + "','" + cExam + "','" + studentKU + "','" + studentTI + "','" + studentCM + "'" +
                                  ",'" + studentAP + "','" + studentCulm + "','" + studentExam + "','" + cRoom + "')");

            //Course teacher is got by getting the course teacher by the course object
            Teacher cTeacherN = getTeacher(Convert.ToInt32(cTeacher));


            //If there was a teacher available and the courses were set
            if (cTeacherN.setTeacherCourses(getCourse(cID)))
            {
                //Save the teacher
                DatabaseConnection.saveTeacher(cTeacherN);

                //Return true
                return true;
            }
            else
            {
                //Delete the course
                executeQuery("DELETE FROM course WHERE cID = '" + cID + "'");

                //Return false
                return false;
            }


        }



        /// <summary>
        /// Insert the principal into the database
        /// </summary>
        /// <param name="userName">String username of the principal</param>
        /// <param name="password">String password of the principal</param>
        public static void insertPrincipal(string userName, string password)
        {
            //Execute the query to insert the information
            executeQuery("INSERT INTO principal (pNumber, pPassword) values" +
                                  "('" + userName + "','" + password + "')");
        }

        /// <summary>
        /// This function is used to insert the rental object into the data
        /// </summary>
        /// <param name="oID">oID is the object ID</param>
        /// <param name="oName">The object Name</param>
        /// <param name="oDIsabled">Whether the object is disabled or not</param>
        public static void insertObject(int oID, string oName, int oDIsabled)
        {
            string[] junkData = new string[24];
            //24 bit string for the hours of the day

            //Seperate the information by f
            for (int i = 0; i < junkData.Length; i++)
            {
                junkData[i] = "f";

            }
            
            //Join the junkdata and slots
            string result = string.Join(";", junkData);

            //Execute query and save information
            executeQuery("INSERT INTO objects (`oId`, `oName`, `oDisabled`, `oDay1`, `oDay2`, `oDay3`, `oDay4`, `oDay5`) values" +
                                  "('" + oID.ToString() + "','" + oName + "','" + oDIsabled + "','"
                                  + result + "','" + result + "','" + result + "','"
                                  + result + "','" + result + "')");
        }

        /// <summary>
        /// This function is used to insert a student for the first time
        /// </summary>
        /// <param name="sID">Student ID</param>
        /// <param name="sPassword">Student Password</param>
        /// <param name="sFirstName">Student First Name</param>
        /// <param name="sLastName">Student Last Name</param>
        /// <param name="sDOB">Student Date of Birth</param>
        /// <param name="sGrade">Student Grade</param>
        /// <param name="sEmail">Student E-Mail</param>
        /// <param name="sParentName">Student Parent Name</param>
        /// <param name="sParentPhone">Student Parent Phone</param>
        /// <param name="sHomeAddress">Student Home Address</param>
        /// <param name="courses">Student Courses</param>
        /// <param name="comments">Student Comments</param>
        public static void insertStudent(int sID, string sPassword, string sFirstName,
                        string sLastName, string sDOB, int sGrade,
                        string sEmail, string sParentName, string sParentPhone,
                        string sHomeAddress, string[,] courses, string[,] comments)
        {

            //The query is executed to insert the first set of data
            executeQuery("INSERT INTO student (sNumber, sPassword, sFirstName, sLastName, sDOB, "+
                " sGrade, sEmail, sParentName, sParentPhone, sHomeAddress) values" +
                      "('" + sID + "','" + sPassword + "','" + sFirstName + "','" + sLastName + "',"+
                      "'" + sDOB + "','" + sGrade + "','" + sEmail + "','" + sParentName + "'," +
                      "'" + sParentPhone + "','" + sHomeAddress + "')");


            //Throughout the years of the students
            for (int i = 0; i < Config.MAX_STUDENT_YEARS; i++)
            {
                //Loop through the max amount of comments per year
                for (int z = 0; z < Config.MAX_STUDENT_COMMENTS; z++)
                {
                    //Concatinate a string for the rows by using the 2d array index and year
                    string commentString = "sComments" + (i + 1) + "-" + (z + 1) + "";

                    //Execute the query to update the student data
                    executeQuery("UPDATE student SET `" + commentString + "` = '" + comments[i,z] +
                           "' WHERE sNumber = '" + sID + "'");

                }
                //Loop through the courses of a student
                for (int y = 0; y < Config.MAX_STUDENT_COURSES; y++)
                {
                    //Get the comment string concatenated and ready for the mysql update
                    string commentString = "sC" + (y + 1) + "Y" + (i + 1) + "";

                    //Execute the query to update it
                    executeQuery("UPDATE student SET `" + commentString + "` = '" +
                        courses[i,y] +
                        "' WHERE sNumber = '" + sID + "'");
                }
            }


        }





    }
}
