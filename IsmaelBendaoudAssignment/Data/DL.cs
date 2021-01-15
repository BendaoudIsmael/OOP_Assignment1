using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /* The data layer is responsible to access the database and to query the database and manipulating 
     * data by adding, editing and deleting records --> LINQ will be used for these tasks.
     */
    public class DL
    {

        AttendanceSystemEntities db = new AttendanceSystemEntities(); //connection to the database

        public void AddInitialData() //to be called once only
        {

            /*
            Teacher teach1 = new Teacher(0293600, "Ismael Bendaoud","ismael","Ismael", "Bendaoud", "ism@gmail.com");

            //adding new objects / records to the teahcers DBSet which
            db.Teachers.Add(teach1);
            db.SaveChanges();
            */

            /*
            Group g1 = new Group(1,"Software","Maths");
            Group g2 = new Group(2, "Networks", "Hardware");

            db.Groups.Add(g1); db.Groups.Add(g2);
            db.SaveChanges();
            */

            /*
            Student s1 = new Student(1000, "Samuel", "Psaila", "sam@gmail.com", 1);
            Student s2 = new Student(2000, "Jhon", "West", "jw@gmail.com", 2);

            db.Students.Add(s1); db.Students.Add(s2);
            db.SaveChanges();
            */


            /*
            Lesson l1 = new Lesson(1, 2, DateTime.Now, 293600);
            db.Lessons.Add(l1);
            db.SaveChanges();
            */


            /*
            StudentAttendance sa1 = new StudentAttendance(1,1,false,2000);

            db.StudentAttendances.Add(sa1);
            db.SaveChanges();        
            */
        }

        public Teacher TeacherIDs(int teacherID)
        {
            var teacherIDs = (from Teacher in db.Teachers where Teacher.TeacherID == teacherID select Teacher);
            return teacherIDs.SingleOrDefault();
        }

        public Group GroupIDs(int groupID)
        {
            var groupIDs = (from Group in db.Groups where Group.GroupID == groupID select Group);
            return groupIDs.SingleOrDefault();
        }

        public Student StudentIDs(int studentID)
        {
            var studentIDs = (from Student in db.Students where Student.StudentID == studentID select Student);
            return studentIDs.SingleOrDefault();
        }

        public Student StudentGroupIDs(int groupID)
        {
            var StudentGroupIDs = (from Student in db.Students where Student.GroupID == groupID select Student);
            return StudentGroupIDs.SingleOrDefault();
        }

        public Teacher TeacherUsername(string username)
        {
            var teacherUsername = (from Teacher in db.Teachers where Teacher.Username == username select Teacher);
            return teacherUsername.SingleOrDefault();
        }

        public void AddLesson(int lessonID, int groupID, DateTime dateTime, int teacherID)
        {
            Lesson lesson = new Lesson(lessonID, groupID, dateTime, teacherID);
            db.Lessons.Add(lesson);
            db.SaveChanges();
        }

        public void AddGroup(int groupID, string Group, string course)
        {
            Group groupadd = new Group(groupID, Group, course);
            db.Groups.Add(groupadd);
            db.SaveChanges();
        }

        public Group CheckGroupID(int groupID)
        {
            var checkgroupID = (from Group in db.Groups where Group.GroupID == groupID select Group);
            return checkgroupID.SingleOrDefault();
        }

        public void AddTeacherID(int teacherID, string username, string password, string name, string surname, string email)
        {
            Teacher addteacherID = new Teacher(teacherID, username, password, name, surname, email);
            db.Teachers.Add(addteacherID);
            db.SaveChanges();
        }

        public Teacher CheckTeacherID(int teacherID)
        {
            var checkteacherID = (from Teacher in db.Teachers where Teacher.TeacherID == teacherID select Teacher);
            return checkteacherID.SingleOrDefault();
        }

        public void AddStudent(int studentID, string name, string surname, string email, int groupID)
        {
            var addstudentID = new Student(studentID, name, surname, email, groupID);
            db.Students.Add(addstudentID);
            db.SaveChanges();
        }

        public Student CheckStudentID(int studentID)
        {
            var checkstudentID = (from Student in db.Students where Student.StudentID == studentID select Student);
            return checkstudentID.SingleOrDefault();
        }
    }
}
