
namespace w2_petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2(0, 1000);
            //ex3(20);
            //ex4(10);
            //ex4(37);
            //ex5();
            //ex6();
            //ex7(11);
            //ex8("abcdefg");
            //ex9(20);
            //ex9(777);
            //ex9(256);
            //ex9(255);
            ////ex10(12, 8);
        }

        private static void ex10(int a, int b)
        {
            //Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb. 
        }

        private static void ex9(int decimalNumber)
        {
            //Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            String binaryNumber = "";
            do 
            {
                binaryNumber += decimalNumber % 2; 
                decimalNumber /= 2;
                
            } while (decimalNumber != 0);
            ex8(binaryNumber);
            Console.WriteLine();
        }

        private static void ex8(string userString)
        {
            //Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.
            for (int i = userString.Length - 1; i >= 0; i--)
            {
                Console.Write(userString[i]);
            }
        }

        private static void ex7(int diagonal)
        {
            int numberOfSignsAtTheTop = diagonal % 2 == 0 ? 2 : 1;
            int height = 0;
            for (int i = diagonal; i > 0; i = i - 2)
            {
                height++;
            }
            int numberOfSingsInARow = numberOfSignsAtTheTop;
            for (int row = 0; row < height; row++)
            {
                int numberOfSpaces = (diagonal - numberOfSingsInARow) / 2;
                for (
                    int column = 0;
                    column < diagonal - numberOfSpaces;
                    column++
                )
                {
                    Console.Write(column < numberOfSpaces ? " " : '*');
                }
                numberOfSingsInARow += 2;
                Console.WriteLine();
            }
            numberOfSingsInARow -= 4;
            for (int row = height; row > 0; row--)
            {
                int numberOfSpaces = (diagonal - numberOfSingsInARow) / 2;
                for (
                    int column = 0;
                    column < diagonal - numberOfSpaces;
                    column++
                )
                {
                    Console.Write(column < numberOfSpaces ? " " : '*');
                }
                numberOfSingsInARow = numberOfSingsInARow - 2;
                Console.WriteLine();
            }
        }

        private static void ex6()
        {
            //Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ +1 / 3 + ¼ itd.
            double sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum += (double)1/i;
            }
            Console.WriteLine($"suma = {sum}");
        }

        private static void ex5()
        {
            //Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
            }
        }

        private static void ex4(int maxNumber)
        {
            //Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
            bool stopProgram = false;
            int startNumber = 1;
            int i = 1;
            do
            {
                for (int j = i; j < i + i; j++)
                {
                    Console.Write($"{startNumber++} ");
                    if (startNumber > maxNumber)
                    {
                        stopProgram = true;
                        break;
                    }
                }
                Console.WriteLine();
                i++;
            } while (!stopProgram);

        }
        private static void ex3(int fibonacciParts)
        {
            //Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie. 
            int[] fibonacciSeq = new int[fibonacciParts];

            for (int i = 0; i < fibonacciParts; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacciSeq[i] = i;
                }
                else
                {
                    fibonacciSeq[i] = fibonacciSeq[i - 2] + fibonacciSeq[i - 1];
                }
                Console.Write($"{fibonacciSeq[i]} ");
            }
        }

        private static void ex2(int min, int max)
        {
            // Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000
            int i = min;
            int noOfEvenNumbers = 0;
            Console.Write("Liczby parzyste: ");
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}, ");
                    noOfEvenNumbers++;
                }
                i++;
            } while (i <= max);
            Console.WriteLine($"W zakresie {min}-{max} znaleziono {noOfEvenNumbers} liczb parzystych.");
        }

        private static void ex1()
        {
            //Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100
            int noOfFirstNums = 0;
            for (int i = 2; i < 101; i++)
            {
                int noOfDividers = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        noOfDividers++;
                    }
                }
                if (noOfDividers < 3)
                {
                    noOfFirstNums++;
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine($"Ilość liczb pierwszych w zakresie 0-100 = {noOfFirstNums}");
        }
    }
}

