using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsManager
{
    class CustomerStatements
    {

        public static void DataAndTime()
        {


            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var hour = DateTime.Now.ToShortTimeString(); // ma sens

            Console.WriteLine("DATE: {0} TIME: {1} ", date, hour);

        }

        public static void Header(string title, string subtitle = "", ConsoleColor color = ConsoleColor.White)
        {
            int windowWidth = 90 - 2;
            string titleContent = String.Format("║{0," + ((windowWidth / 2) + (title.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (title.Length / 2) + 1) + "}", title, "║");
            string subtitleContent = String.Format("║{0," + ((windowWidth / 2) + (subtitle.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (subtitle.Length / 2) + 1) + "}", subtitle, "║");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(titleContent);
            if (!string.IsNullOrEmpty(subtitle))
            {
                Console.WriteLine(subtitleContent);
            }
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void CallToAction (string textToCustomer)
            {
            Console.WriteLine(textToCustomer);
            }

    }
}
