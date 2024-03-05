using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static User[] _testUser = new User[3];

        public static User[] TestUser {
            get { 
                ResetTestUserData();
                return _testUser;
            }
            
            set { }
        }

        static private void ResetTestUserData() {
                _testUser[0] = new User("Admin", "admin2003", "501221065", 1, DateTime.Now, DateTime.MaxValue);
                _testUser[1] = new User("Melih", "melih2003", "501221065", 4, DateTime.Now, DateTime.MaxValue);
                _testUser[2] = new User("Aleksandar", "aleks2003", "501221065", 4, DateTime.Now, DateTime.MaxValue);
        }

        public static User IsUserPassCorrect(string usernaName, string password) {
            /*for (int counter = 0; counter < TestUser.Length; counter++) {
                if (TestUser[counter].UserName.Equals(usernaName) && TestUser[counter].Password.Equals(password)) {
                    return TestUser[counter];
                }
            }*/

            foreach (User tempUser in TestUser) {
                if (tempUser.UserName.Equals(usernaName) && tempUser.Password.Equals(password)) {
                    return tempUser;
                }
            }

            return null;
        }
    }
}
