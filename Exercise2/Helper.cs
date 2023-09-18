using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Helper
    {
        public static int CalculatePrice(int age)
        {
            if (age < 20)
            {
                return 80;
            }

            else if (age > 64)
            {
                return 90;
            }

            else
            {
                return 120;
            }
        }

        public static int TicketType(string goBack)
        {
            Console.WriteLine("Ange din ålder");
            string input = Console.ReadLine();
            int age;
            if (int.TryParse(input, out age))
            {
                int price = Helper.CalculatePrice(age);
                Console.WriteLine($"Pris: {price}kr");

            }
            else
            {
                Console.WriteLine("Ogiltig input. Ange heltal");
            }

            Console.WriteLine(goBack);
            Console.ReadKey(true);
            return age;
        }

        public static void RepeatRandomText()
        {
            Console.WriteLine("Ange en random text");
            string randomTextInput = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(randomTextInput);
            }
        }

        public static void ExtractThirdWord()
        {
            Console.WriteLine("Skriv en mening på minst tre ord");
            var userInput = Console.ReadLine(); //Takes in the user input in a var
            string[] sentence = userInput.Split(' '); //This splits the word in to an array
            var thirdWord = sentence[2]; //And This retrieves the third word at index 2, since index starts at 0

            {
                Console.Write($"\nTredje ordet i din mening:{thirdWord}");
            }
        }

    }
}
