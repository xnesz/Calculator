using System;

namespace _4school
{
    class Program
    { 

        static void Main(string[] args)
        {
            bool runAgain = true;
            do
            {

                double numOne, numTwo, numThree;
                double sum = 0;
                string opOne, opTwo, input;
                bool isValid = true;


                Console.WriteLine("Simple calculator made by Vanessa\n\n");

                Console.WriteLine("Enter your first number: ");
                numOne = Double.Parse(Console.ReadLine());

                Console.WriteLine("Choose an operator (+, -, *, %, /)");
                opOne = Console.ReadLine();

                Console.WriteLine("Enter your second number: ");
                numTwo = Double.Parse(Console.ReadLine());

                Console.WriteLine("Choose an operator (+, -, *, %, /)");
                opTwo = Console.ReadLine();

                Console.WriteLine("Enter your third number: ");
                numThree = Double.Parse(Console.ReadLine());

                switch (opOne)
                {
                    case "+":
                        sum = numOne + numTwo;
                        break;
                    case "-":
                        sum = numOne - numTwo;
                        break;
                    case "*":
                        sum = numOne * numTwo;
                        break;
                    case "%":
                        sum = numOne % numTwo;
                        break;
                    case "/":
                        sum = numOne / numTwo;
                        break;
                    default:
                        isValid = false;
                        Console.WriteLine("First operator invalid");
                        break;
                }

                switch (opTwo) //sum + numThree = sum   sum = sum + numThree
                {
                    case "+":
                        sum = sum + numThree;
                        break;
                    case "-":
                        sum = sum - numThree; 
                        break;
                    case "*":
                        sum = sum * numThree;
                        break;
                    case "%":
                        sum = sum % numThree;
                        break;
                    case "/":
                        sum = sum / numThree;
                        break;
                    default:
                        isValid = false;
                        Console.WriteLine("Second operator invalid");
                        break;
                }



                if (isValid)
                {
                    Console.WriteLine("Resultat: " + numOne + opOne + numTwo + opTwo + numThree + " = " + sum);

                }

                Console.WriteLine("Do you want to calculate some more? y/n \n");
                input = Console.ReadLine();
                if (String.Equals(input, "y"))
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }

            } while (runAgain);
        }
          
    }
}
