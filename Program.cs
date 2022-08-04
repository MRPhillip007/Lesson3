namespace Lesson3Homework
{ 
    class Homework
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            bool input1 = int.TryParse(Console.ReadLine(), out int number1);

            Console.WriteLine("Enter second number: ");
            bool input2 = int.TryParse(Console.ReadLine(), out int number2);

            if (input1 && input2)
            {
                Console.WriteLine($"\n\t Your answer is: {Solution(num1: number1, num2: number2)}");
            }
            else
            {
                Console.WriteLine("Number parsing error! Only numbers allowed.");
            }
        }


        static int Solution(int num1, int num2)
        {
            //Create a program that will start with declaration of two constants (X and Y) and will count the sum of all numbers between these constants. If they are equal then sum should be one of them

            //Example:

            //X = 10
            //Y = 12
            //Sum = 10 + 11 + 12 = 33

            //X = 5
            //Y = 2
            //Sum = 2 + 3 + 4 + 5 = 14

            //X = 10
            //Y = 10
            //Sum = 10

            //Extra:

            //Read values of X and Y from the console. If output is invalid - write to console Invalid input and exit the program.
            var sum = 0;
            if (num1 == num2)
            {
                Console.WriteLine("The same numbers ");
                return num1;
            }
            else
            {
                for(int i = Math.Min(num1, num2); i <= Math.Max(num1, num2); i++)
                {
                    sum += i;   
                }
                return sum;
            }
        }
    }
}
