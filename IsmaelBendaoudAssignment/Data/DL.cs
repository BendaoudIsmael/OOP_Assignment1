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

            
            
            StudentAttendance sa1 = new StudentAttendance(1,1,false,2000);

            db.StudentAttendances.Add(sa1);
            db.SaveChanges();            
            

        }    

    }
}
