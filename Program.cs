namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Name ");
            string pattern = Console.ReadLine();

            //Pattern patterns = new Pattern();
            //bool val = patterns.validatePinCode(pattern);

            //Pattern patterns = new Pattern();
            //bool val = patterns.validatePhoneNumb(pattern);

            UserRegi user = new UserRegi();
            bool val = user.UserRegistration(pattern);

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