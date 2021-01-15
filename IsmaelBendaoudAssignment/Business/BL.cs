using Domain;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /* Business Layer is responsible for the data validations and logical executions. There should be
     * no input and output and also no direct access to the database (and no queries)
     * The business ;ayer will be accessed by the presentation layer and the BL should be able to access
     * the data layer.
     */
    public class BL
    {
        static DL dl = new DL();

        int teacherID;
        /*
        public void AddInitialData()
        {
            dl.AddInitialData();
        }*/

        public string TeacherUsername(string username)
        {
            Teacher teacher = dl.TeacherUsername(username);
            if (teacher == null)
            {
                return "The entered ID does not exisit in our system";
            }
            else
            {
                teacherID = teacher.TeacherID;
                return "Welcome";
            }
        }

        public string AddPassword(string password, string username)
        {
            Teacher passteach = dl.TeacherUsername(username);
            if (passteach.Password == password)
            {
                return "Welcome";
            }
            else
            {
                return "Error";
            }

        }

        public void CreateNewLesson(int lessonID, int groupID, DateTime dateTime, int teacherID)
        {
            dl.AddLesson(lessonID, groupID, dateTime, teacherID);
        }

        public string CheckGroup(int groupID, string Group, string course)
        {
            if (dl.CheckGroupID(groupID) == null)
            {
                dl.AddGroup(groupID, Group, course);
                return "Group Added.";
            }
            else
            {
                return "ID Already exists.";
            }
        }

        public string CheckTeacher(int teacherID, string username, string password, string name, string surname, string email)
        {
            if (dl.CheckTeacherID(teacherID) == null)
            {
                dl.AddTeacherID(teacherID, username, password, name, surname, email);
                return "Teacher Added";
            }
            else
            {
                return "Teacher already exists. ";
            }
        }

        public string InsrtStudent(int studentID, string name, string surname, string email, int groupID)
        {
            if (dl.CheckStudentID(studentID) == null)
            {
                dl.AddStudent(studentID, name, surname, email, groupID);
                return "New Student Added";
            }
            else
            {
                return "Student already exists. ";
            }
        }
    }
}

