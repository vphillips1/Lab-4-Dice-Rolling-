using System;

namespace Lab_4_Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {


            do

            {
                Console.WriteLine("Welcome to Grand Circus Casino! Roll the die? (y/n)");
                string input = Console.ReadLine();
                bool cont = true;

                input = input.ToLower();
                if (input.Equals("y"))
                {
                    Console.WriteLine("How many sides should each die have ? ");
                    string numSides = Console.ReadLine();

                    int sides;
                    bool realInteger = int.TryParse(numSides, out sides);

                    bool keepPlaying = true;

                    int rollCount = 1;
                    do
                    {


                        Console.WriteLine($"Roll {rollCount}: ");

                        Console.WriteLine(RandomNUmber(2 * sides));

                        Console.WriteLine(RandomNum(2 * sides));



                        rollCount++;

                    } while (keepPlaying = ContinueGame());

                    cont = true;
                    break;
                }

                else if (input.Equals("n"))
                {
                    Console.WriteLine("Have a great day!");
                    cont = false;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Input try again.");
                    continue;
                }


            } while (true);
            


        }

        static int RandomNUmber(int x)

        {

            Random random = new Random();

            int randomNUmber = random.Next(2, x);

            return randomNUmber;
        }
        

        static int RandomNum (int y)

        {
            Random ran = new Random();
            int randomNum = ran.Next(2, y);
            return randomNum;

        }

        static bool ContinueGame()

        {

            bool continueGame = true;
            do
            {

                Console.WriteLine(" Do you want to continue? (Y/N)");

                string userInput = Console.ReadLine();

                userInput = userInput.ToLower();
                if (userInput.Equals("y"))
                {
                    continueGame = true;
                    break;
                }

                else if (userInput.Equals("n"))
                {
                    Console.WriteLine("Have a great day!");
                    continueGame = false;
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Input try again.");
                    continue;
                }

              
            } while (true);
            return continueGame;

        }
    }
}
