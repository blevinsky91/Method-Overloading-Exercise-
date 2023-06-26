namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine(Add(7, 2));
            Console.WriteLine(Add(.9m, .2m));
            Console.WriteLine(Add(5, 1, true));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal d1, decimal d2)
        {
            return d1 + d2;
        }

        public static string Add(int num1, int num2, bool b1)
        {
            var result = num1 + num2;

            if (b1 == true && result < 1)
            {
                return $"{result} dollars";
            }
            else if (b1 == true && result > 1)
            {
                return $"{result} dollars";
            }
            else if (b1 == true && result == 1)
            {
                return $"{result} dollar";
            }
            else
            {
                return $"{result}";
            }
        }
    }
}
