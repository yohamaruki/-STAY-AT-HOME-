using System;

namespace code
{
    class covid
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("==STAY IN YOUR HOUSE. A COVID-19 'BORED' GAME==\n");
                Console.WriteLine("Hello there! What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Okay, so your name is\n " + name);
                Console.WriteLine("What are you doing right now?");
                Console.WriteLine("1.) Staying at home");
                Console.WriteLine("2.) Outside, getting some groceries");
                Console.WriteLine("3.) Fuck the police.");
                Console.WriteLine("4.) Talking with my BF/GF/Joyfriend :D");
                int thisChoice = Int32.Parse(Console.ReadLine());

                switch (thisChoice)
                {
                    case 1:
                        if (thisChoice == 1)
                        {
                            Console.WriteLine("Well. Good for you!");

                        }
                        break;
                    case 2:
                        if (thisChoice == 2)
                        {
                            Console.WriteLine("Return home safely!");
                        }
                        break;

                    case 3:
                        if (thisChoice == 3)
                        {
                            Console.WriteLine("Hello?!??!! GO HOME!");
                        }
                        break;

                    case 4: 
                        if (thisChoice == 4) {
                            Console.WriteLine("Damn, I wish me too.");
                        }
                        break;

                    case 5: 
                        if (thisChoice > 4) {
                            Console.WriteLine("Wtf? Enter something. A Valid number.");
                            Console.Clear();
                        }
                        break;

                    case 6: 
                        if (thisChoice < 1) {
                            Console.WriteLine("Enter a valid number.");
                            Console.Clear();
                        }
                        break;

                    default:
                        Console.WriteLine("Enter something...");
                        break;
                }
                Console.WriteLine("Well, that's that anyways. Please stay safe during this time of crisis!");
                Console.WriteLine("Wanna go through it again? (Y|N)");
                string Choices = Console.ReadLine();
                if (Choices == "y" || Choices == "Y")
                {
                    Console.Clear();
                    continue;
                }
                else if (Choices == "n" || Choices == "N")
                {
                    Console.WriteLine("Stay safe! Wear masks! Wash your hands!");
                     System.Environment.Exit(1);
                }
            }
        }
    }
}
