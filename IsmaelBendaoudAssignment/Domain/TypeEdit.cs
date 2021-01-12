using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class TypeEdit
    {
    }
    public partial class Teacher
    {
     
        public Teacher(int teacherID, string username, string password, string name, string surname, string email)
        {
            TeacherID = teacherID;
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
            Email = email;
        }
    }

    public partial class StudentAttendance
    {
        public StudentAttendance(int attendanceID, int lessonID, bool presence, int studentID)
        {
            AttendanceID = attendanceID;
            LessonID = lessonID;
            Presence = presence;
            StudentID = studentID;
        }
    }

    public partial class Student
    {
        public Student(int studentID, string name, string surname, string email, int groupID)
        {
            StudentID = studentID;
            Name = name;
            Surname = surname;
            Email = email;
            GroupID = groupID;
        }
    }

    public partial class Lesson
    {
        public Lesson(int lessonID, int groupID, DateTime dateTime, int teacherID)
        {
            LessonID = lessonID;
            GroupID = groupID;
            Datetime = dateTime;
            TeacherID = teacherID;
        }
    }

    public partial class Group
    {
        public Group(int groupID, string Groupn, string course)
        {
            GroupID = groupID;
            name = Groupn;
            Course = course;
        }
    }
}

