namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the First Name ");
            //string firstname = Console.ReadLine();


            UserRegi user = new UserRegi();
            //bool val = user.FirstName(firstname);

            //if (val)
            //{
            //    Console.WriteLine("Pattern Matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern Not Matched");
            //}

            //Console.WriteLine("Please enter the Last Name ");
            //string lastname = Console.ReadLine();
            //bool val1 = user.LastName(lastname);
            //if (val1)
            //{
            //    Console.WriteLine("Pattern Matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern Not Matched");
            //}

            //Console.WriteLine("Please enter email address:  ");
            //string email = Console.ReadLine();

            //bool val = user.Email(email);
            //if (val)
            //{
            //    Console.WriteLine("Pattern Matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern Not Matched");
            //}

            //Console.WriteLine("Please enter mobile number:  ");
            //string mobile = Console.ReadLine();

            //bool val = user.MobileNumber(mobile);
            //if (val)
            //{
            //    Console.WriteLine("Pattern Matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern Not Matched");
            //}

            Console.WriteLine("Please enter password:  ");
            string pwd = Console.ReadLine();

            bool val = user.Password(pwd);
            if (val)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched, there must be 8 characters.");
            }

        }
    }
}