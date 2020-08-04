using System;
using System.Net.Security;

namespace HomeworkWeek2Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercise 1:");
            HomeworkExercise1();
            Console.ReadKey();

            Console.WriteLine("exercise 2:");
            HomeworkExercise2();
            Console.ReadKey();

            Console.WriteLine("exercise 3:");
            HomeworkExercise3();
            Console.ReadKey();

            Console.WriteLine("exercise 4:");
            HomeworkExercise4();
            Console.ReadKey();

            Console.WriteLine("exercise 5:");
            HomeworkExercise5();
            Console.ReadKey();

        }

        public static void HomeworkExercise1()
        {
            Console.WriteLine("Worker Data: ");

            string name = "Michal";
            string surname = "Szafron";
            int age = 37;
            char gender = 'm';
            long peselNumber = 83010815190;
            double idnumber = 25009324094;

            Console.WriteLine("{0},{1},{2},{3},{4},{5}", name, surname, age, gender, peselNumber, idnumber);

        }

        public static void HomeworkExercise2()
        {

            char letterOne = 'a';
            char letterTwo = 'b';
            char letterThree = 'c';

            Console.WriteLine($"{letterThree}, {letterTwo}, {letterOne}");


        }

        public static void HomeworkExercise3()
        {

            int length = 23;
            int width = 12;

            double power = Math.Pow(length, 2) + Math.Pow(width, 2);
            double diagonal = Math.Sqrt(power);
            Console.Write(diagonal);


        }

        public static void HomeworkExercise4()
        {
            int numberOne;
            string text;
            double numberTwo;

            numberOne = 10;
            text = "DotnetSchool";
            numberTwo = 12.5;

            Console.WriteLine($"{numberOne}\r\n{text}\r\n{numberTwo}");

        }

        public static void HomeworkExercise5()
        {
            Console.WriteLine("Welcome in this application");
            Console.WriteLine("please give me your name");
            string name = Console.ReadLine();


            Console.WriteLine("please give me your surnname");
            string surname = Console.ReadLine();

            Console.WriteLine("please give me your e-mail adress");
            string email = Console.ReadLine();

            Console.WriteLine("please give me your address");
            string address = Console.ReadLine();

            Console.WriteLine("please give me your age");
            string age = Console.ReadLine();
            int parsed = 0;
            int.TryParse(age, out parsed);


            Console.WriteLine("please give me your weight");
            string weight = Console.ReadLine();
            int parsed1 = 0;
            int.TryParse(weight, out parsed1);

            Console.WriteLine("please give me your height");
            string height = Console.ReadLine();
            int parsed2 = 0;
            int.TryParse(height, out parsed2);

            Console.WriteLine($"({name},{surname},{email},{parsed}, {parsed1},{parsed2})");

        }

    }
}
