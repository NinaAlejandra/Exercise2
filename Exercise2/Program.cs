namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key; //This variable holds information about the key pressed by the user
            int option = 0; //This variable keeps track of current selected option. 
            bool isSelected = false; // This indicates whether the user has made a selection

            while (!isSelected) { //This is the main loop that displays the menu and processes user input until valid selection is made

                //Console UI, handles the consoles appearance and displays the menu options
                    Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Väkommen till Ninas program");
                Console.ResetColor();
                Console.WriteLine("\nDu kommer nu att få några val att välja bland");
                Console.WriteLine("\nVälj:\n\u001b[34m0\u001b[0m för att avsluta, \n\u001b[34m1\u001b[0m för biljettpriser, \n\u001b[34m2\u001b[0m för kostnad per grupp, \n\u001b[34m3\u001b[0m för att upprepa en text 10 ggr och \n\u001b[34m4\u001b[0m för att få ut tredje ordet i en mening");
                Console.WriteLine("\n\u001b[36mAnvänd upp och ner pilarna för att navigera och Enter för att välja\u001b[0m");

                string option0 = (option == 0 ? "\n\u001b[34mVal 0 - Avsluta programmet\u001b[0m" : "\nVal 0");
                string option1 = (option == 1 ? "\u001b[34mVal 1 - Biljettpriser\u001b[0m" : "Val 1");
                string option2 = (option == 2 ? "\u001b[34mVal 2 - Pris per antal besökare\u001b[0m" : "Val 2");
                string option3 = (option == 3 ? "\u001b[34mVal 3 - Upprepa text 10 ggr\u001b[0m" : "Val 3");
                string option4 = (option == 4 ? "\u001b[34mVal 4 - Få ut tredje ordet\u001b[0m" : "Val 4");

                Console.WriteLine(option0);
                Console.WriteLine(option1);
                Console.WriteLine(option2);
                Console.WriteLine(option3);
                Console.WriteLine(option4);


               key = Console.ReadKey(true); //Is responsible for reading a key input from the console and storing it in the variable key. If written before while loop it will wait for user input before displaying anything

                //This switch processes the arrow keys for navigation and the enter key for selection
                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 4 ? 0 : option + 1);
                            break;

                        case ConsoleKey.UpArrow:
                            option = (option == 0 ? 4 : option -1);
                            break;

                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;
                    }

            }
            Console.WriteLine($"Du valde nummer {option}");

            //This switch handles the options in the menu. Each case corresponds to a menu option and each case implements the logic for each option
            switch (option)
            {
                case 0:
                    isSelected = true;
                    break;

                case 1:
                      Console.WriteLine("Ange din ålder");
                      int age = int.Parse(Console.ReadLine());

                        if (age < 20)
                        {
                            Console.WriteLine("Ungdomspris: 80kr");
                        }

                        else if (age > 64)
                        {
                            Console.WriteLine("Pensionärspris: 90kr");
                        }

                        else
                        {
                            Console.WriteLine("Standardpris: 120kr");
                        }

   
                    break;

                case 2:
                    int totalCost = 0;
                    Console.WriteLine("Ange antal personer i sällskapet");
                    int numberOfPeople = int.Parse(Console.ReadLine());

                    for (int i = 0; i < numberOfPeople; i++)
                    {
                        Console.WriteLine($"Ange ålder för person {i + 1}:");
                        age = int.Parse(Console.ReadLine());

                        if (age < 20)
                        {
                            totalCost += 80;
                        }
                        else if (age > 64)
                        {
                            totalCost  += 90;
                        }
                        else
                        {
                            totalCost += 120;
                        }

                    }

                    Console.WriteLine($" Ni är {numberOfPeople} och totala kostnaden blir {totalCost}");
                    break;

                    case 3: Console.WriteLine("Ange en random text");
                    string randomTextInput = Console.ReadLine();
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(randomTextInput);
                    }
                    break;

                case 4: 
                    Console.WriteLine("Skriv en mening på minst tre ord");
                    var userInput = Console.ReadLine(); //Takes in the user input in a var
                    string[] sentence = userInput.Split(' '); //This splits the word in to an array
                    var thirdWord = sentence[2]; //And This retrieves the third word at index 2, since index starts at 0
                   
                    {
                        Console.Write($"\nTredje ordet i din mening:{thirdWord}");
                    }
                    break;

                    //Behövs default när input saknas? går ändå ur loop med enter.
                //default:
                //    Console.WriteLine("Ogiltig Input, försök igen.");
                //    break;
            }
            

        }
       
    }

}