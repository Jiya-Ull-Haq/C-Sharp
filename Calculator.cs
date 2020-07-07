using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for action");

            Console.WriteLine(" 1 for + ");

            Console.WriteLine(" 2 for - ");

            Console.WriteLine(" 3 for x ");

            Console.WriteLine(" 4 for / \n");
            int action = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong!");
                    break;
            }

            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();

        }
        
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
    }
}
