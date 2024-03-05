using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static User _testUser;

        public static User TestUser {
            get { 
                ResetTestUserData();
                return _testUser;
            }
            
            set { }
        }

        static private void ResetTestUserData() {
            if (_testUser == null) {
                _testUser = new User("Admin", "admin2003", "501221065", 0);
            }
        }
    }
}
