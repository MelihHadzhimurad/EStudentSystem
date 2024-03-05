namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginValidation validation = new LoginValidation();
            
            if (validation.ValidateUserInput())
            {
                UserData.TestUser.DisplayDatas();
                Console.WriteLine("Valid Role: " + LoginValidation.CurrentUserRole);
            }
            else {
                Console.WriteLine("Validation failed!");
            }
        }
    }
}