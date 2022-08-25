namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Name ");
            string firstname = Console.ReadLine();


            UserRegi user = new UserRegi();
            bool val = user.FirstName(firstname);

            if (val)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched");
            }

            Console.WriteLine("======================================");

            Console.WriteLine("Please enter the Last Name ");
            string lastname = Console.ReadLine();
            bool val1 = user.LastName(lastname);
            if (val1)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched");
            }
            Console.WriteLine("======================================");

            Console.WriteLine("Please enter email address:  ");
            string email = Console.ReadLine();

            bool val2 = user.Email(email);
            if (val2)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched");
            }
            Console.WriteLine("======================================");

            Console.WriteLine("Please enter mobile number:  ");
            string mobile = Console.ReadLine();

            bool val3 = user.MobileNumber(mobile);
            if (val3)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched");
            }
            Console.WriteLine("======================================");

            Console.WriteLine("Please enter password:  ");
            string pwd = Console.ReadLine();

            bool val4 = user.Password(pwd);
            if (val4)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched, there must be 8 characters and at least 1 uppercase, 1 digit and 1 special character.");
            }
            Console.WriteLine("======================================");

        }
    }
}