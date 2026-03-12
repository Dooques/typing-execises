namespace Tasks
{
    public class Task01Class
    {
        public static void Run()
        {
            float floatValue = 3.80f;
            string stringValue = "h";
            double doubleValue = 2.50;

            //floatValue = 3.80;
            //stringValue = 'h';
            //doubleValue = "apple";
        }
    }

    public class Task02
    {
        public static void Run()
        {
            int two = 2;
            Console.WriteLine("Variable two is " + two.GetType());
            Console.WriteLine($"Variable two is {two}");
            Console.WriteLine("two is now " + ((Decimal)two).GetType());

            decimal decimalVaue = 1.1m;
            Console.WriteLine("Variable decimal is " + decimalVaue.GetType());
            Console.WriteLine("Variable decimal is now" + (Double)decimalVaue);
            Console.WriteLine("decimal is now " + ((Double)decimalVaue).GetType());

            float twoPointNine = 2.9f;
            int floatAsInt = (int)twoPointNine;
            Console.WriteLine(floatAsInt);
        }
    }
}
