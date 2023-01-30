namespace CsharpAssignment1;
class Program
{
    static void Main(string[] args)
    {
        /* 1. In this exercise, you must construct an if statement 
         that checks if the number guess is equal to 500.
         If that is the case, use Console.WriteLine to display "Success!".*/

        
                Console.WriteLine("Guess the number.\nInput a number 1 - 1000: ");
                int g = Convert.ToInt32(Console.ReadLine());

                if( g == 500)
                {
                    Console.WriteLine("Success!\n");
                }
                else
                {
                    Console.WriteLine("Incorrect Guess try again.\n");
                }

                // 2. Define an array called fruits that holds the
                // following strings: "apple", "banana", and "orange".

                string[] fruits = { "apple", "banana", "orange" };

                //3. Print the value of variable X to the screen N number of times


                Console.WriteLine("Input the number of times you would like to print x: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine("\n");


                // 4.Create a program to display certain values of the function y = x2 - 2x + 1
                // (using integer numbers for x, ranging from -10 to +10)

                int x, y;

                Console.WriteLine("y = x^2 - 2x + 1\n");

                for ( x = -10; x <= 10; x++)
                {

                    y = (x * x) - (2 * x) + 1;
                    Console.WriteLine("{0} = {1}^2 - (2 * {1}) + 1", y,x);
                    Console.WriteLine();
                }

                // 5.Write a C# program to get three numbers from
                // the user and display the greatest one.

                int num1, num2, num3;

                Console.WriteLine("Please input 3 numbers.");
                Console.WriteLine("Number 1:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number 2:");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number 3:");
                num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("The greatest number is " + num1);
                    }
                    else
                    {
                        Console.WriteLine("The greatest number is " + num3);
                    }
                }
                else if (num2 > num3)
                {
                    Console.WriteLine("The greatest number is " + num2);
                }
                else
                {
                    Console.WriteLine("The greatest number is " + num3);
                }

                //6.Create a C# program to ask the user for 10 real numbers
                //and display the average of the positive ones
                //and the average of the negative ones.

                int[] numbers = new int[10];
                float totalPositive = 0.0f;
                float totalNegative = 0.0f;
                int countPos = 0;
                int countNeg = 0;

                Console.WriteLine("Enter 10 numbers.");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Number {0}= ", i + 1);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < 10; i++)
                {
                    //Negative
                    if (numbers[i] < 0)
                    {
                        totalNegative += numbers[i];
                        countNeg++;                
                    }
                    //Positive
                    else if (numbers[i] > 0)
                    {
                        totalPositive += numbers[i];
                        countPos++;
                    }

                }
                Console.WriteLine("The average of negative numbers  = {0}", totalNegative / countNeg);
                Console.WriteLine("The average of positive numbers  = {0}", totalPositive / countPos);
                Console.WriteLine("");



                //7. Create a program that uses recursion to calculate a
                //   number in the Fibonacci series (in which the first two items are 1,
                //   and for the other elements, each one is the sum of the preceding two).

                // function below

                Console.WriteLine("Please enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The fibonacci of {n} is {Fibonacci(n)}");
       
        //8. Create a program which draws a parallelogram, with the width,
        //   height and character specified as parameters:
        //   10,4,'*' : would display

        int h = 4, w = 10;
        string star = "* ";

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                Console.Write(star);
            }
            Console.WriteLine(" ");

            for (int k = 0; k <= i; k++)
            {
                Console.Write("_");
            }

        }
 

    }


    // Funtion for number 7
    public static long Fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

}

