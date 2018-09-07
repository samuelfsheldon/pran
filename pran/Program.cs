using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static string PlayerChoiceFoodWall;
        static string ShelterChoice;
        static string FightFlight;
        static string WaitFight;
       // static string RandLoot;

        static void Main(string[] args)
        {
            Start();
        }
        private static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You awaken to a throbbing headache and the smell of smoke. You look around to see the orange horizon of a sunset and a burning spacecraft.");
            Thread.Sleep(10);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What is your name?");
            Console.ForegroundColor = ConsoleColor.Blue;
            string PlayerName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello " + PlayerName + ", I am your personal reference analyzing network, or PRAN for short.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("It seems that our ship has crashed on an inhospitable planet. I suggest you take action in order to protect yourself. Are you going to ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("find an item");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" or");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" build a wall");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("?");
            Console.ForegroundColor = ConsoleColor.Blue;
            PlayerChoiceFoodWall = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            FirstChoice();
            FirstMonster();
        }
        private static void FirstChoice()
        {
            var isDone = false;
            while (!isDone)
            {
                if (PlayerChoiceFoodWall == "find an item")
                {
                    isDone = true;
                    Console.Write("Good choice, you found");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(FirstLoot());
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(". I advise you");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" find a cave");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" or");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" return to the ship");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" before nightfall.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    ShelterChoice = Console.ReadLine();
                }
                else if (PlayerChoiceFoodWall == "build a wall")
                {
                    isDone = true;
                    Console.WriteLine("Good choice, your defenses can now withstand one attack.");
                }
                else
                {
                    Console.WriteLine("I don't understand, please try again.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    PlayerChoiceFoodWall = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }
        }
        public static string FirstLoot()
        {
            List<string> firstNames = new List<string>();
            firstNames.Add(" a sharp stick");
            firstNames.Add(" a large rock");
          
            Random randNum = new Random();
            int RandLootNum = randNum.Next(firstNames.Count - 1);

            //RandLoot = firstNames[RandLootNum];
            return firstNames[RandLootNum];
        }
        private static void FirstMonster()
        {
            if (ShelterChoice == "find a cave")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You survey the landscape in search of shelter.");
                Thread.Sleep(10);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("I detect a hostile lifeform approaching from the east. To ensure survival I suggest you");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" run");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" or");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" fight");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(".");
                Console.ForegroundColor = ConsoleColor.Blue;
                FightFlight = Console.ReadLine();
            }
            else if (ShelterChoice == "return to the ship")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You return to the ship just as the sun sets over the golden horizon.");
                Thread.Sleep(10);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("I detect a hostile lifeform approaching from the northeast. To ensure survival I suggest you");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" fight");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" or");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" wait it out");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(".");
                Console.ForegroundColor = ConsoleColor.Blue;
                WaitFight = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I don't understand, please try again.");
                Console.ForegroundColor = ConsoleColor.Blue;
                WaitFight = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
    }
}
