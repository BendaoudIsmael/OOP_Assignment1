using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DL
    {
        AttendanceSystemEntities db = new AttendanceSystemEntities(); //connection to the database

        public void AddInitialData() //to be called once only
        {
            Teacher teach1 = new Teacher(233999, "Ismael Bendaoud");
            Teacher teach2 = new Teacher(43389, "Deandra Xuereb");

            db.Teachers.Add(teach1); db.Teachers.Add(teach2);

        }
    }
}
