using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for addition, 2 for substraction, 3 for multiplication, 4 for division");
            char c = Convert.ToChar(Console.ReadLine());
            Program obj = new Program();
            if(c =='1')
            {
             int result = obj.Sum(num1, num2);
                Console.WriteLine("Result is " + result);
            }
            else if (c=='2')
            {
             int result = obj.Sub(num1, num2);
                Console.WriteLine("Result is " + result);
            }
            else if (c=='3')
            {
            int result = obj.Mul(num1, num2);
                Console.WriteLine("Result is " + result);
            }
            else if (c == '4')
            {
                int result = obj.Div(num1, num2);
                Console.WriteLine("Result is " + result);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

        }
        public int Sum(int num1, int num2)
        {
            int c;
            c = num1 + num2;
            return c;
        }
        public int Sub(int num1, int num2)
        {
            int c;
            c = num1 - num2;
            return c;
        }
        public int Mul(int num1, int num2)
        {
            int c;
            c = num1 * num2;
            return c;
        }
        public int Div(int num1, int num2)
        {
            int c;
            c = num1 / num2;
            return c;
        }

    }
}
