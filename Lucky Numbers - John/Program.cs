using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers___John
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input Variables
            int startingNumber;
            int usernumbers;
            int endingNumber;
            int numberofcorrectguesses;
            float jackpotamount = 1000000.00f;
            int match = 0;
            float winnings;
            string exitResponse = "yes";
            Console.WriteLine("Do you want to play?");
            Console.ReadLine().ToLower();

            while (exitResponse.Equals("yes"))
            {

                Console.WriteLine("Please enter a starting number.");
                startingNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter an ending number");
                endingNumber = int.Parse(Console.ReadLine());



                int[] userNumbers = new int[6]; //array
                for (int i = 0; i < userNumbers.Length; i++) //user ForLoop
                {
                    Console.WriteLine("Please enter a number");
                    userNumbers[i] = int.Parse(Console.ReadLine());
                    while (userNumbers[i] >= endingNumber || userNumbers[i] < startingNumber) //while loop
                    {
                        Console.WriteLine("Pick another number.");
                        userNumbers[i] = int.Parse(Console.ReadLine());

                    }


                }


                int[] randomNumber = new int[6]; //random number array
                Random r = new Random(); //random number generator
                for (int j = 0; j < randomNumber.Length; j++)
                {
                    randomNumber[j] = r.Next(startingNumber, endingNumber);




                    Console.WriteLine("Lucky Number:" + randomNumber[j]);

                }
                Console.WriteLine("Total Jackpot is $1,000,000.00");

                for (int i = 0; i < userNumbers.Length; i++) //nested ForLoop
                {
                    for (int j = 0; j < randomNumber.Length; j++)
                    {
                        if (userNumbers[i] == randomNumber[j]) //This is where I'm counting the correctly guessed numbers
                        {
                            match += 1;
                            break;

                        }

                    }
                }
                Console.WriteLine("You guessed " + match + " numbers correctly!!");

                winnings = jackpotamount / match; // I don't know how to get 2 decimal places
                Console.WriteLine("You won $" + winnings + "!");

















                Console.WriteLine("Do you want to play again?");
                exitResponse = Console.ReadLine();


            } //end of while loop
            Console.WriteLine("Thanks for playing!");

        }
    }
}
