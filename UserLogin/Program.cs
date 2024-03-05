using System.Runtime.CompilerServices;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            string requestUsername = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string requestPassword = Console.ReadLine();

            LoginValidation.ActionOnError actionOnError = Console.WriteLine;
            LoginValidation.ActionOnError errorAction = new LoginValidation.ActionOnError(actionOnError);

            LoginValidation validation = new LoginValidation(requestUsername, requestPassword, errorAction);

            User paramUser = null;
            
            if (validation.ValidateUserInput(ref paramUser))
            {
                paramUser.DisplayDatas();
            }
            else {
                errorAction(validation.ErrorMessage);
            }

            switch (LoginValidation.CurrentUserRole)
            {
                case UserRoles.ADMIN:
                    Console.WriteLine("You have administrator rights! ");
                    break;

                case UserRoles.INSPECTOR:
                    Console.WriteLine("You have Inspector rights! ");
                    break;

                case UserRoles.PROFESSOR:
                    Console.WriteLine("You have Professor rights! ");
                    break;

                case UserRoles.STUDENT:
                    Console.WriteLine("You have Student rights! ");
                    break;

                case UserRoles.ANONYMOUS:
                    Console.WriteLine("There is no any rights for you! ");
                    break;
                default:
                    Console.WriteLine("You don't have permission to access the system! ");
                    break;
            }
        }
    }
}