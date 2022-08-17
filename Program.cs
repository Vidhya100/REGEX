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
        }
    }
}