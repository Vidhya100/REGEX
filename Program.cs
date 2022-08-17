namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Name ");
            string pattern = Console.ReadLine();

            UserRegi user = new UserRegi();
            bool val = user.FirstName(pattern);

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