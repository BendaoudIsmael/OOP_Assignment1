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
        public Teacher(int v1, string v2)
        {
        }

        public Teacher(int teacherID, string username, string password, string name, string surname, string email)
        {
            teacherID = teacherID;
            username = username;
            password = password;
            name = name;
            surname = surname;
            email = email;
        }
    }

    public partial class StudentAttendance
    {
        public StudentAttendance(int attendanceID, int lessonID, bool presence, int studentID)
        {
            attendanceID = attendanceID;
            lessonID = lessonID;
            presence = presence;
            
            studentID = studentID;
        }
    }

    public partial class Student
    {
        public Student(int StudentID, string name, string surname, string email, int groupID)
        {
            StudentID = StudentID;
            name = name;
            surname = surname;
            email = email;
            groupID = groupID;
        }
    }

    public partial class Lesson
    {
        public Lesson(int LessonID, int groupID, DateTime dateTime, int teacherID)
        {
            LessonID = LessonID;
            groupID = groupID;
            dateTime = dateTime;
            teacherID = teacherID;
        }
    }

    public partial class Group
    {
        public Group(int groupID, string name, string course)
        {
            groupID = groupID;
            name = name;
            course = course;
        }
    }
}

