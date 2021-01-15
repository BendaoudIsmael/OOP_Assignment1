﻿using Domain;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
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

        public string CheckStudent(int studentID, string name, string surname, string email, int groupID)
        {
            if (dl.CheckStudentID(studentID) == null)
            {
                dl.AddStudentID(studentID, name, surname, email, groupID);
                return " Student Added";
            }
            else
            {
                return "Student already exists. ";
            }
        }

        public string checkgroupID(int groupID)
        {
            if (dl.GroupStudentID(groupID) != null)
            {
                return "";
            }
            else
            {
                return "Group ID does not exsist";
            }
        }


        public string checkSID(int studentID)
        {
            if (dl.CheckStudentID(studentID) != null)
            {
                return "";
            }
            else
            {
                return "Student ID does not exsist";
            }
        }

        public string EditStudentName(int id, string newName, string newSurname, string newEmail)
        {
            if (dl.ExisitingStudentID(id) != null)
            {
                dl.EditStudentName(id, newName, newSurname, newEmail);
                return "Student Added";
            }
            else
            {
                return "ID does not exist!";
            }
        }

        /*
        public string CheckAttandance(int attendanceID, int lessonID, bool presence, int studentID)
        {
            if (dl.CheckStudentAttendance(attendanceID) == null)
            {
                dl.AddAttandace(attendanceID, lessonID, presence, studentID);
                return "Attendance Added";
            }
            else
            {
                return "Attendance already exists";
            }    
        } 
        */
    }
}

