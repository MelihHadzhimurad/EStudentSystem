using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class LoginValidation
    {
        private String _username;
        private String _password;
        private String _errorMessage;
        private ActionOnError _onError;
        public delegate void ActionOnError(string errorMsg);
        public String ErrorMessage { get; private set; }
        public static UserRoles CurrentUserRole { get; private set; }

        public LoginValidation(string username, string password, ActionOnError onError)
        {
            _username = username;
            _password = password;
            _onError = onError;
        }

        //ActionOnError printError = Console.WriteLine;

        public bool ValidateUserInput(ref User paramUser) {
            if (this._username.Length < 5 || this._password.Length < 5)
            {
                this.ErrorMessage = "Incorrect datas - Username and Password must be longer than 5 characters!";
                CurrentUserRole = (UserRoles)0;
                return false;
            }

            paramUser = UserData.IsUserPassCorrect(this._username, this._password);

            if (paramUser == null) {
                this.ErrorMessage = "User with given credentials not found! ";

                CurrentUserRole = (UserRoles)0;
                return false;
            }

            CurrentUserRole = (UserRoles)paramUser.UserRole;
            return true;
        }
    }
}
