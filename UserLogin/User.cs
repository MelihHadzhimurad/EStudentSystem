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
        public int UserRole { get; set; }
        public DateTime Created { get; set; }
        public DateTime ExpiresIn { get; set; }

        public User(string userName, string password, string facultyNumber, int userRole, DateTime created, DateTime expiresIn)
        {
            UserName = userName;
            Password = password;
            FacultyNumber = facultyNumber;
            UserRole = userRole;
            Created = created;
            ExpiresIn = expiresIn;
        }

        public void DisplayDatas() {
            String FormattedDatas = $"Username: {UserName}\nFaculty Number: {FacultyNumber}\nUser Role: Admin\nCreated in {Created}";

            Console.WriteLine(FormattedDatas);
        }
    }
}
