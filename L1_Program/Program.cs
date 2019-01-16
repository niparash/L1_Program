using System;

namespace L1_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6

            //Write your code here
            /*try
            {
                int a = 4, b = 3, c = 5;
                double area = 0, s = 0;

                s = (a + b + c) / 2;
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("The area of given triangle is: " + area);
                Console.ReadKey(true);
            } //end of Exercise 1 - try */


            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.

            // Write your code here

            /*Console.WriteLine("Please enter a number");
            try
            {
                string number = Console.ReadLine();
                int num = Convert.ToInt32(number);
                num %= 2;
                if(num == 0)
                {
                    Console.WriteLine("Entered number is an Even number");
                }
                else
                {
                    Console.WriteLine("Entered number is an Odd number");
                }
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            } //end of Exercise 2 - try*/

            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.

            // Write your code here

            /*Console.WriteLine("This program computes greatest number of 3 numbers");
            Console.WriteLine("Please enter number 1: ");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);

            Console.WriteLine("Please enter number 2: ");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);

            Console.WriteLine("Please enter number 3: ");
            string input3 = Console.ReadLine();
            int num3 = Convert.ToInt32(input3);

            try
            {
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine(num1 + " is the greatest number from " + num1 + "," + num2 + "," + num3);
                    }
                    else
                    {
                        Console.WriteLine(num3 + " is the greatest number from " + num1 + "," + num2 + "," + num3);
                    }
                }
                else if (num2 > num3)
                {
                    Console.WriteLine(num2 + " is the greatest number from " + num1 + "," + num2 + "," + num3);
                }
                else
                {
                    Console.WriteLine(num3 + " is the greatest number from " + num1 + "," + num2 + "," + num3);
                }

                Console.ReadKey(true);

            } //end of Exercise 3 - try*/

            // Exercise 4
            // Input a value (n) from the user and calculate the sum of first n natural numbers.
            // Eg. n=5. sum = 1+2+3+4+5 = 15

            // Write your code here

            /*Console.WriteLine("Please enter a number");

            try
            {
                string number = Console.ReadLine();
                int num = Convert.ToInt32(number);
                int num1 = num;
                int sum = 0;
                while(num>0)
                {
                    sum = sum + num;
                    num--;
                }
                Console.WriteLine("The sum of first" + num1 + " natural numbers is: " + sum);
                Console.ReadKey(true);
            } //end of Exercise 4 - try*/

            // Exercise 5
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            // *
            // **
            // ***
            // ****
            // *****

            // Write your code here

            /*Console.WriteLine("Please enter a number");

            try
            {
                string number = Console.ReadLine();
                int num = Convert.ToInt32(number);
                
                for (int i = 1; i <= num; i++)
                {
                    string pattern = new String('*', i);
                    Console.WriteLine(pattern);
                }
                Console.ReadKey(true);
            } //end of Exercise 5 - try*/

            // Exercise 6
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            //     *
            //    **
            //   ***
            //  ****
            // *****

            // Write your code here

            /*Console.WriteLine("Please enter a number");

            try
            {
                string number = Console.ReadLine();
                int num = Convert.ToInt32(number);
                int num1 = num-1;
                for (int i = 1; i <= num; i++)
                {
                    string spaces = new String(' ', num1);
                    string pattern = new String('*', i);
                    Console.WriteLine(spaces + pattern);
                    num1--;
                }
                Console.ReadKey(true);
            }//end of Exercise 6 - try*/



            catch
            {
                Console.WriteLine("Something went wrong! Please enter a valid number next time.");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            } //end of catch
        }
    }
}
