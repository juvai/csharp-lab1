using System;
using System.Collections.Concurrent;
using System.Threading.Channels;

namespace JUVAI_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindProblem(); // Task 1
            //ArrayAverage(); // Task 2
            //FirstFiveNumbers(); // Task 3
            //FigureArea(); // Task 4
            //CheckSymbol(); // Task 5
            //FindProblemSecond(); // Task 6
            //MathematicalFunction(); // Task 7
            //PrintAllLowercaseLetters(); // Task 8
            //NumberPrimeChecker(); // Task 9
            //GuessANumber(); // Task 10

            //GreatestCommonDivisor(); // Task 12
            DigitCounterInString(); // Task 13
            //GuessAYear(); // Task 14
        }

        public static void FindProblem() // Task 1
        {
            int n;
            double f = 1;
            Console.Write("Enter a positive number n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }

            Console.WriteLine("{0}!={1} ", n, f);
        }

        public static void ArrayAverage() // Task 2
        {
            var sum = 0;
            var number = 0;

            Console.Write("Enter a array size: ");
            var arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter {0} arrays numbers: ", arraySize);
            for (int i = 0; i < arraySize; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;
            }

            var average = sum / arraySize;
            Console.WriteLine("Average is: {0}", average);
        }

        public static void FirstFiveNumbers() // Task 3
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}", Math.Pow(i, 2));
                }
            }
        }

        public static void FigureArea() // Task 4
        {
            Console.Write("Choose one: \n1.Rectangle \n2.Triangle \n3.Trapezoid \nYour input: ");
            var userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.Write("Choose rectangle length: ");
                    double rectangleLength = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nChoose rectangle width: ");
                    double rectangleWidth = Convert.ToInt32(Console.ReadLine());
                    double rectangleArea = rectangleLength * rectangleWidth;
                    Console.Write("\nArea size is: {0}", rectangleArea);

                    break;
                case 2:
                    Console.Write("Choose triangle AB length: ");
                    double triangleALength = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose triangle BC length: ");
                    double triangleBLength = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose triangle AC length: ");
                    double triangleCLength = Convert.ToInt32(Console.ReadLine());
                    double halfPerimeter = (triangleALength + triangleBLength + triangleCLength) / 2;
                    var triangleArea = Math.Sqrt(halfPerimeter * ((halfPerimeter - triangleALength) *
                                                                  (halfPerimeter - triangleBLength) *
                                                                  (halfPerimeter - triangleCLength)));
                    Console.Write("\nArea size is: {0}", triangleArea);

                    break;
                case 3:
                    Console.Write("Choose trapezoid bottom length: ");
                    double trapezoidBottom = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose trapezoid top length: ");
                    double trapezoidTop = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose trapezoid altitude length: ");
                    double trapezoidAltitude = Convert.ToInt32(Console.ReadLine());

                    var trapezoidArea = ((trapezoidTop + trapezoidBottom) / 2) * trapezoidAltitude;

                    Console.Write("\nArea size is: {0}", trapezoidArea);

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public static void CheckSymbol() // Task 5
        {
            Console.Write("Enter a character: ");
            var ch = Console.ReadLine()[0];
            int charValue = Convert.ToInt32(ch);

            if (charValue > 47 && charValue < 58) Console.Write("Number");
            else if (charValue > 96 && charValue < 123) Console.Write("Lowercase letter");
            else if (charValue > 64 && charValue < 91) Console.Write("Uppercase letter");
            else if ((charValue < 65 || charValue > 90) || (charValue < 97 || charValue > 122))
                Console.Write("Not a letter");
        }

        public static void FindProblemSecond() // Task 6
        {
            var i = 1;
            var j = 0;
            var k = 0;
            while (i < 10)
            {
                j = i * i - 1;
                k = 2 * j - 1;
                i++;
                Console.WriteLine("{0}, {1}, {2}", i, j, k);
            }
        }

        public static void MathematicalFunction() // Task 7
        {
            for (double x = -2; x <= 2; x = x + 0.5)
            {
                var y = -2.4 * Math.Pow(x, 2) + 5 * x - 3;
                Console.WriteLine("{0}", y);
            }
        }

        public static void PrintAllLowercaseLetters() // Task 8
        {
            var firstLetter = 'a';
            var lastLetter = 'z';
            int firstcharValue = Convert.ToInt32(firstLetter);
            int lastcharValue = Convert.ToInt32(lastLetter);

            for (int i = firstcharValue; i <= lastcharValue; i++)
            {
                Console.WriteLine("{0} {1}", i, Convert.ToChar(i));
            }
        }
        public static void NumberPrimeChecker() // Task 9
        {
            var a = 0;
            Console.Write("Input your number: ");
            var userNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= userNumber; i++)
            {
                if (userNumber % i == 0) a++;
            }

            if (a == 2) Console.WriteLine("{0} is a Prime Number", userNumber);
            else Console.WriteLine("Not a Prime Number");
        }

        public static void GuessANumber() // Task 10
        {
            Random rnd = new Random();
            int generatedNumber = rnd.Next(1, 10);
            //Console.WriteLine(generatedNumber);
            var guessCounter = 5;

            while (guessCounter != 0)
            {
                Console.Write("Guess a number: ");
                var userNumber = Convert.ToInt32(Console.ReadLine());
                if (generatedNumber == userNumber)
                {
                    Console.WriteLine("Congrats!");
                    break;
                }

                Console.WriteLine("Wrong");
                guessCounter--;
                if (guessCounter == 0) Console.WriteLine("You lost...");
            }

        }

        public static void GreatestCommonDivisor() // Task 12
        {
            var gcd = 0;
            Console.Write("Enter two numbers: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            gcd = a | b;
            Console.WriteLine("GCD is {0}", gcd);
        }

        public static void DigitCounterInString() // Task 13
        {
            var counter = 0;
            string userInput = Console.ReadLine();
            foreach (var eachChar in userInput)
            {
                var charValue = Convert.ToInt32(eachChar);
                if (charValue > 47 && charValue < 58) counter++;
            }
            Console.WriteLine("Digits are in line: {0}", counter);
        }

        public static void GuessAYear() // Task 14
        {
            var correctAnswer = 1323;
            var guessCounter = 3;

            while (guessCounter != 0)
            {
                Console.Write("Guess a year: ");
                var userNumber = Convert.ToInt32(Console.ReadLine());
                if (correctAnswer == userNumber)
                {
                    Console.WriteLine("Congrats!");
                    break;
                }

                Console.WriteLine("Wrong");
                guessCounter--;
                if (guessCounter == 0) Console.WriteLine("Neatspejote, 1323");
            }

        }
    }
}