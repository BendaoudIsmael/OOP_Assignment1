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

        public void AddStudentID(int studentID, string name, string surname, string email, int groupID)
        {
            Student addstudentID = new Student(studentID, name, surname, email, groupID);
            db.Students.Add(addstudentID);
            db.SaveChanges();
        }

        public Student CheckStudentID(int studentID)
        {
            var addstudentID = (from Student in db.Students where Student.StudentID == studentID select Student);
            return addstudentID.SingleOrDefault();
        }

        public Student GroupStudentID(int groupID)
        {
            var addgroupID = (from Student in db.Students where Student.GroupID == groupID select Student);
            return addgroupID.SingleOrDefault();
        }

        public Student ExisitingStudentID(int studentID)
        {
            var checkStudID = (from Student in db.Students where Student.StudentID == studentID select Student);
            return checkStudID.SingleOrDefault();
        }

        public void EditStudentName(int id, string nametoEdit, string surnametoEdit, string emailtoEdit)
        {
            Student stud = db.Students.SingleOrDefault(s => s.StudentID == id);
            stud.Name = nametoEdit;
            stud.Surname = surnametoEdit;
            stud.Email = emailtoEdit;

            db.SaveChanges();
        }
    
        /* Had no more time so finalize it sorry
        public void AddAttandace(int attendanceID, int lessonID, bool presence, int studentID)
        {
            StudentAttendance addattendance = new StudentAttendance(attendanceID, lessonID, presence, studentID);
            db.StudentAttendances.Add(addattendance);
            db.SaveChanges();
        }

        public StudentAttendance CheckStudentAttendance(int attendanceID)
        {
            var addattendaceID = (from StudentAttendance in db.StudentAttendances where StudentAttendance.AttendanceID == attendanceID select StudentAttendance);
            return addattendaceID.SingleOrDefault();
        }
        */
    }
}
