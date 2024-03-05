using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class User
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public String FacultyNumber { get; set; }
        public int UserRole {  get; set; }

        public User(string userName, string password, string facultyNumber, int userRole)
        {
            UserName = userName;
            Password = password;
            FacultyNumber = facultyNumber;
            UserRole = userRole;
        }

        public void DisplayDatas() {
            String FormattedDatas = $"Username: {UserName}\nFaculty Number: {FacultyNumber}\nUser Role: Admin";

            Console.WriteLine(FormattedDatas);
        }
    }
}
