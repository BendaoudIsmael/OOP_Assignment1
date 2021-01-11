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
        public Teacher()
        {
        }

        public Teacher(int v1)
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
}
