using System;

namespace HomeworkWeek2Lesson8
{
    class Program
    {
        static void Main(string[] args)

        {
            //double a = 1;
            //double b = 8;
            //Console.WriteLine(a/b);


            //double div = 0;
            //for (double i = 1; i < 10; i++)
            //{
            //    div = 1 / i;
            //    Console.WriteLine(div);
            //}

            Console.WriteLine("Homework-Week2-Lesson8");
            //1.Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
            PrimeNumber();
            Console.ReadLine();

            //2.Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
            EvenNumbers();
            Console.ReadLine();

            //3.Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
            FibonnaciNumbers();
            Console.ReadLine();

            //4.Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
            Triangle();
            Console.ReadLine();

            //5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            Power();
            Console.ReadLine();

            //6.Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + ½ +1 / 3 + ¼ itd.
            Summary();
            Console.ReadLine();

            //7.Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
            Diamond();
            Console.ReadLine();

            //8.Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.Np.
            Reversal();
            Console.ReadLine();

            //9.Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            DecimalToBinary();
            Console.ReadLine();

            // 10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            CommonDivider();
            Console.ReadLine();

        }

        public static void PrimeNumber()

        
        // założenia:
        // 1. Liczba pierwsza to liczba podzielna przez 1 oraz przez siebie
        // 2. Liczba pierwsza > 1
        // 3. Najmniejsza liczba pierwsza to 2.

        {
            Console.WriteLine("Program odnajduje liczby Pierwsze w przedziale liczbowym 0-100");

            int counter = 0; // licznik liczb pierwszych

            bool isprime = true;

            for (int i = 2; i < 100; i++)
            {

                for (int j = 2; j < 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }


                }
                if (isprime)
                {
                    Console.WriteLine(i);
                    counter++;
                }
                isprime = true;
            }
            Console.WriteLine();
            Console.WriteLine("Ilość liczb pierwszych w przedziale 0-100 to :" + counter);


        }

        public static void EvenNumbers()
        {
            Console.WriteLine("Program wyświeltla wszystkie liczby parzyste z przedziału 0-1000");
            Console.WriteLine("Wciśnij enter");
            Console.ReadKey();
            int a = 0;
            int limit = 1000;
            do
            {
                Console.WriteLine(a);
                a = a + 2;

            } while (a <= limit);

        }

        public static void FibonnaciNumbers()
        {
            Console.WriteLine("program wyświetla liczby ciągu fibbonaciego");
            Console.WriteLine("Podaj ile liczb fibonnaciego chcesz  wyświetlić");

            int counter = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int firstNumber = 0;
            int secondNumber = 1;
            int fibnumberNumber = 0;

            Console.WriteLine(firstNumber);


            for (int i = 1; i < counter; i++)
            {

                fibnumberNumber = firstNumber + secondNumber;
                Console.WriteLine(fibnumberNumber);
                firstNumber = secondNumber;
                secondNumber = fibnumberNumber;
            }


        }

        public static void Triangle()
        {
            Console.WriteLine("Program tworzy trójkąt  z liczby zwiękdzających swoją wartość o 1");
            int number = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number);
                    number = number + 1;
                }
                Console.WriteLine();
            }


        }

        public static void Power()
        {
            Console.WriteLine("Program podnosi liczby do potegi 3");
            double power = 0;
            for (int i = 1; i <= 20; i++)
            {
                power = Math.Pow(i, 3);
                Console.WriteLine("{0} to power 3 is {1}", i, power);

            }


        }

        public static void Summary()
        {
            Console.WriteLine("Program oblicza sumę wg określonego wzoru ");
            double sum = 0;
            double add = 0;
            for (double i = 1; i < 20; i++)
            {
                add = 1 / i;
                
                sum = sum + add;
                Console.WriteLine("{0:F2}", 1/i);
            }

            Console.WriteLine("Suma wynosi {0:F2}:" , sum);
        }

        public static void Diamond()
        {
            // założenie diamnet składa się z dwóch trójkątów
            Console.WriteLine("Program wyświetla wzór- Diament");
            Console.WriteLine("Podaj długość przekątnej");

            int r = int.Parse(Console.ReadLine());
            int i, j;
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        

    }

        public static void Reversal()
        {
            Console.WriteLine("program odwracający ciąg znaków");
            Console.WriteLine("wprowadz ciąg znaków");
            string phrase = Console.ReadLine();
            int count = phrase.Length;
            Console.WriteLine("twoja fraza zawiera {0} znaków", count);

            string reversedPhrase = default;
            string symbol;

            for (int i = 1; i <= count; i++)
            {
                symbol = phrase.Substring(count - i, 1);
                reversedPhrase = reversedPhrase + symbol;

            }
            Console.WriteLine(reversedPhrase);
        }

        public static void DecimalToBinary()
        {
            Console.WriteLine("Program zamienia liczbę do postaci binarnej");
            Console.WriteLine("podaj decimal number");
            int number = int.Parse(Console.ReadLine());

            int reminder;
            string result = string.Empty;
            while (number > 0)
            {
                reminder = number % 2;
                number /= 2;
                result = reminder.ToString() + result;
            }
            Console.WriteLine("Binary :{0}", result);

        }

        public static void CommonDivider()
        {
            Console.WriteLine("Program liczy najmnijeszą wspólną wielokrotność");
            Console.WriteLine("podaj pierwszą liczbę");
            int numberFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbę");
            int numberSecond = int.Parse(Console.ReadLine());
            
            if (numberFirst> numberSecond)
            {
                if (numberFirst % numberSecond == 0)
                {
                    Console.WriteLine("Najmniejsza wspólna wilokrotność to {0}", numberFirst);
                }
                else

                    Console.WriteLine("Najmniejsza wspólna wilokrotność to {0}" , numberFirst*numberSecond); 

            }
            else if( numberSecond> numberFirst)
            {

                if (numberSecond % numberFirst == 0)
                {
                    Console.WriteLine("Najmniejsza wspólna wilokrotność to {0}" , numberSecond);
                }
                else

                    Console.WriteLine("Najmniejsza wspólna wilokrotność to {0}" , numberSecond * numberFirst);

            }
            else
            {
                Console.WriteLine("liczny są równe");
                Console.WriteLine("Najmniejsza wspólna wilokrotność to { 0} " , numberFirst);
            }

        }
    }
}
