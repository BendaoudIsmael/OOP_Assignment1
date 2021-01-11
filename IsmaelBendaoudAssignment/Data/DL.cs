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
            Teacher teach1 = new Teacher(0293600, "Ismael Bendaoud");

            //adding new objects / records to the teahcers DBSet which
            db.Teachers.Add(teach1);
            db.SaveChanges();
        }    
    }
}
