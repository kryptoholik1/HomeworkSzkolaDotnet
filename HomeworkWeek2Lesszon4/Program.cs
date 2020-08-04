using System;

namespace HomeworkWeek2Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            // Dane testowe: a : 5 b : 5 Rezultat w terminalu : 5 i 5 są równe
            ExerciseOne();
            Console.ReadLine();

            //2.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta. 
            // Dane testowe : 15 Rezultat w terminalu : 15 jest liczbą nieparzystą
            ExerciseTwo();
            Console.ReadLine();

            //3.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna. 
            //Dane testowe : 14 Rezultat w terminalu : 14 jest liczbą dodatnią
            ExerciseThree();
            Console.ReadLine();

            //4.Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym. 
            //Dane testowe : 2016 Rezultat w terminalu : 2016 jest rokiem przestępnym
            ExerciseFour();
            Console.ReadLine();

            //5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta. 
            //Dane testowe : 21 Rezultat w terminalu : Możesz zostać posłem.
            ExerciseFive();
            Console.ReadLine();

            //Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
            //Dane testowe : 140 Rezultat w terminalu: Jesteś krasnoludem
            ExerciseSix();
            Console.ReadLine();

            //Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa 
            //Dane testowe: 25 63 79 Rezultat w terminalu : 79 jest największa z podanych
            ExerciseSeven();
            Console.ReadLine();

            //8.Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg.Następujących kryteriów:
            //Wynik z Matury z matematyki powyżej 70 Wynik z fizyki powyżej 55 Wynik z chemii powyżej 45 Łączny wynik z 3 przedmiotów powyżej 180 Albo

            ExerciseEight();
            Console.ReadLine();

            //Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach

            ExerciseNine();
            Console.ReadLine();

            //Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt 
            //Dane testowe: 40 55 65 Rezultat w terminalu: Można zbudować trójkąt

            ExerciseTen();
            Console.ReadLine();

            //11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
            ExerciseEleven();
            Console.ReadLine();

            //12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę Dane testowe: 4

            ExcerciseTwelve();
            Console.ReadLine();

            //13.Napisz program, który będzie posiadał proste menu(wg.Wzoru poniżej) I będzie prostym kalkulatorem
            Thirteen();
            Console.ReadLine();
        }

        public static void ExerciseOne()
        {

            Console.WriteLine("program sprawdza równośc podanych cyfr");
            //Console.WriteLine("Podaj Pierwszą zmienną int");
            int a = 5;

            //Console.WriteLine("Podaj Drugą zmienną int");
            int b = 5;

            if (a == b)
            {
                Console.WriteLine("{0} i {1} są równe", a, b);
            }
            else
            {
                Console.WriteLine("{0} i {1} są różne", a, b);
            }

        }
        public static void ExerciseTwo()
        {
            Console.WriteLine("Program sprawdza czy podana liczba jest parzysta");
            Console.WriteLine("Podaj zmienną typu int, którą chcesz sprawdzić");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 != 0)
            {
                Console.WriteLine("{0} jest liczbą nieparzystą", a);
            }
            else
            {
                Console.WriteLine("{0} jest liczbą parzystą", a);
            }

        }


        public static void ExerciseThree()
        {
            Console.WriteLine("Program sprawdza czy podana liczba jest dodatnia czy ujemna");
            Console.WriteLine("Podaj zmienną typu int, którą chcesz sprawdzić");
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("{0} jest liczbą dodatnia", a);
            }
            else if (a < 0)
            {
                Console.WriteLine("{0} jest liczbą ujemną", a);
            }
            else
            {

                Console.WriteLine("{0} jest ZEREM", a);
            }

        }
        public static void ExerciseFour()
        {

            Console.WriteLine("Program sprawdzający czy  rok 2016 jest przestępny");
            // Do zadania  formułę zgodną z kalendarzem Gregoriańskim wprowadzonym w 1582 roku przez papieża Grzegorza XIII,
            //w którym rok przestępny spełnia jeden z następujących warunków:
            //jest podzielny przez 4, ale nie jest podzielny przez 100, jest podzielny przez 400


            int year = 2016;

            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("{0} jest przestępny ", year);
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("{0} jest przestępny ", year);
            }
            else
            {

                Console.WriteLine("{0} jest rokiem nieprzestępnym", year);
            }

        }
        public static void ExerciseFive()
        {
            Console.WriteLine("Program sprawdza możesz ubiegać się o następujące stanowiska urzędowe typu: poseł, premier, senator, prezydent");
            Console.WriteLine("Podaj swój wiek");
            // 35 prezydent, poseł 21 , senator 30, 
            int a = int.Parse(Console.ReadLine());

            if (a >= 21 && a < 30)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else if (a >= 30 && a < 35)
            {
                Console.WriteLine("Możesz zostać posłem , premierem, senatorem");
            }
            else if (a >= 35)
            {

                Console.WriteLine("Możesz zostać posłem , premierem, senatorem lub prezydentem");
            }
            else
            {
                Console.WriteLine("Jesteś zbyt młody na jakiekolwiek stanowisko państwowe");

            }

        }

        public static void ExerciseSix()
        {
            Console.WriteLine("Program który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.");
            Console.WriteLine("Podaj swój wzrost");

            int a = int.Parse(Console.ReadLine());

            if (a >= 50 && a <= 110)
            {
                Console.WriteLine("Jesteś maluchem");
            }
            else if (a > 110 && a <= 145)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (a > 145 && a <= 165)
            {

                Console.WriteLine("Jesteś niski");
            }
            else if (a > 165 && a <= 178)
            {
                Console.WriteLine("Jesteś śeredniego wzrostu");

            }
            else if (a > 178 && a <= 190)
            {
                Console.WriteLine("Jesteś wysoki");

            }
            else if (a > 190 && a <= 210)
            {
                Console.WriteLine("Jesteś bardzo wysoki");

            }
            else if (a > 210)
            {
                Console.WriteLine("GIGANT");

            }
            else
            {
                // niższy niż 50
                Console.WriteLine("niemowlak");
            }

        }

        public static void ExerciseSeven()
        {
            Console.WriteLine("Program sprawdza która liczba jest największa");

            Console.WriteLine("Podaj pierwszą liczbę typu int, którą chcesz porównać");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę typu int, którą chcesz porównać");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecią liczbę typu int, którą chcesz porównać");
            int c = int.Parse(Console.ReadLine());



            if (a > b && a > c)
            {
                Console.WriteLine("{0} jest liczbą największą", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("{0} jest liczbą największą", b);
            }
            else if (c > a && c > b)
            {

                Console.WriteLine("{0} jest liczbą największą", c);
            }
            else
            {
                Console.WriteLine("nie ma jednej największej liczby");

            }

        }

        public static void ExerciseEight()
        {
            Console.WriteLine("Program sprawdza czy kandydat dostanie się na studia");

            Console.WriteLine("Podaj swój wynik z matematyki");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj swój wynik z fizyki");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj swój wynik z chemii");
            int c = int.Parse(Console.ReadLine());

            int total = a + b + c;

            if ((a > 55 && b > 55 && c > 45 && total>180))
            {
               
               Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
         
            
            if ((a + b > 150) || (a + c > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {

                Console.WriteLine("nie dopuszczony");
            }

        }

        public static void ExerciseNine()
        {
            Console.WriteLine("Program zwraca nazwe w zależności od temperatury");

            Console.WriteLine("Podaj aktualną temperaturę");
            int temp = int.Parse(Console.ReadLine());


            if (temp > 0 && temp <= 10)
            {
                Console.WriteLine("{0} :  Temp 0 – 10 – zimno", temp);
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("{0} : Temp 10 – 20 – chłodno", temp);
            }
            else if (temp > 20 && temp <= 30)
            {

                Console.WriteLine("{0} : Temp 20 – 30 – w sam raz", temp);
            }

            else if (temp > 30 && temp < 40)
            {
                Console.WriteLine("{0} :Temp 30 – 40 – zaczyna być słabo, bo gorąco", temp);
            }
            else if (temp >= 40)
            {
                Console.WriteLine("{0} : Temp >= 40 – a weź wyprowadzam się na Alaskę", temp);
            }

            else
            {
                Console.WriteLine("Temp < 0 – cholernie piździ");

            }

        }

        public static void ExerciseTen()
        {
            Console.WriteLine("Program sprawdza czy da sie zbudować trójkąt z podanych długości");
            Console.WriteLine("Podaj długość pierszego boku");
            double lineA = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość drugiego boku");
            double lineB = double.Parse(Console.ReadLine());


            Console.WriteLine("Podaj długość trzeciego boku");
            double lineC = double.Parse(Console.ReadLine());



            double combinationOne = lineA + lineB;
            double combinationTwo = lineA + lineC;
            double combinationThree = lineB + lineC;

            if ((combinationOne > lineC) && (lineA<lineC && lineB<lineC))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if ((combinationTwo > lineB) && (lineA < lineB && lineC < lineB))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if ((combinationThree > lineA) && (lineB < lineA && lineC< lineA))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else

            {

                Console.WriteLine("Nie można zbudować trójkąta");
            }

        }

        public static void ExerciseEleven()
        {
            Console.WriteLine("Program zminenia ocenę ucznia na słowo");
            Console.WriteLine("Podaj jaką otrzymałeś ocenę");
            int ocena = int.Parse(Console.ReadLine());

            switch (ocena)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");

                    break;

                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;

                case 3:
                    Console.WriteLine("Dostateczny");
                    break;

                case 4:
                    Console.WriteLine("Dobry");
                    break;

                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;

                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine(" nie potrafisz nawet wpisać poprawnie cyfry do konsoli");
                    break;
            }

        }


        public static void ExcerciseTwelve()
        {
            Console.WriteLine("Program zwraaca dzień tydognia w zależności od podanej cyfry");
            Console.WriteLine("Podaj numer dnia tygodnia");
            int day = int.Parse(Console.ReadLine());


            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");

                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine(" Taki dzień tygodnia nie istnieje");
                    break;
            }

        }

        public static void Thirteen()
        {
            Console.WriteLine("Program to prosty kalkulator");
            Console.WriteLine("Podaj pierwszą cyfrę");
            double digitA = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą cyfrę");
            double digitB = double.Parse(Console.ReadLine());

            Console.WriteLine("Jaką operacje chcesz wykonać - wybierz odpowiednią cyfrę:");
            Console.WriteLine("1. dodawanie");
            Console.WriteLine("2. odejmowanie");
            Console.WriteLine("3. dzielenie");
            Console.WriteLine("4. mnożenie");

            int choice = int.Parse(Console.ReadLine());
            double sum;  // przyszły wynik dodawania
            double diff; // przyszły wynik odejmowania
            double div;  // przyszły wynik dzielenia
            double mult; // przyszły wynik mnożenia

            switch (choice)
            {
                case 1:
                    sum = digitA + digitB;
                    Console.WriteLine(sum);

                    break;

                case 2:
                    diff = digitA - digitB;
                    Console.WriteLine(diff);
                    break;

                case 3:
                    div = digitA / digitB;
                    Console.WriteLine(div);
                    break;

                case 4:
                    mult = digitA * digitB;
                    Console.WriteLine(mult);
                    break;

                

                default:
                    Console.WriteLine(" Cos poszło nie tak");
                    break;
            }

        }
    }
}
