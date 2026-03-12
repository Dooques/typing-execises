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

    public class Task03
    {
        public static void Run()
        {

            double num1 = 2.2;
            decimal num2 = 4.9m;

            Console.WriteLine(MultiplyInt((int)num1, (int)num2));
        }

        private static int MultiplyInt(int a, int b)
        {
            return a * b;
        }
    }

    public class Task04
    {
        public static void Run()
        {
            string stringValue = "580";
            int num = 42;
            int parsedString;
            Console.WriteLine(Int32.TryParse(stringValue, out parsedString));
            Console.WriteLine($"parsed String {parsedString} is {parsedString.GetType()}");

            Console.WriteLine(Convert.ToInt32(stringValue).GetType());
            Console.WriteLine(Convert.ToDecimal(stringValue).GetType());
        }


    }

    public class Task05
    {
        public static void Run()
        {
            Console.WriteLine("Enter a int then a decimal");
            string inputs = Console.ReadLine();

            string[] parts = inputs.Split(' ');

            int intVariable; 

            Int32.TryParse(parts[0], out intVariable);

            decimal decVariable = 0;
            decimal.TryParse(parts[1], out decVariable);

            Console.WriteLine($"Int variable is {intVariable} and decimal variable is {decVariable}");

            double result = (double)(intVariable / decVariable);
            Console.WriteLine(result);
        }
    }
    public class Task06
    {
        public static void Run()
        {
            Car car1 = new Car(4, "Mazda");

            Console.WriteLine(car1.StartDriving());

            car1.GetHashCode();
            Car car2 = new Car(2, "Toyota");

            Car car3 = car1;

            Console.WriteLine($"car1 = {car1.GetHashCode()}, car2 = {car2.GetHashCode()}, car3 = {car3.GetHashCode()}");
        }

        class Car
        {
            public bool Seatbelt { get; set; }
            public int Doors { get; set; }
            public string Brand { get; set; }

            public string StartDriving()
            {
                return "Driving";
            }

            public void UseSeatbelt()
            {
                Seatbelt = true;
            }

            public Car(int doors, string brand)
            {
                Seatbelt = false;
                Doors = doors;
                Brand = brand;
            }
        }
    }
     public class Task07
    {
        public static void Run()
        {
            Console.WriteLine("Would you like to see your input returned as a char array");
            string booleanResponse = Console.ReadLine();
            if (booleanResponse == "yes")
            {
                Console.WriteLine(booleanResponse.ToCharArray());
            }
            else
            {
                Console.WriteLine("Ok, Goodbye");
            }
        }
    }
}
