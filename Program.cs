namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Name ");
            string firstName = Console.ReadLine();

            UserRegi user = new UserRegi();
            bool val = user.FirstName(firstName);

            if (val)
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