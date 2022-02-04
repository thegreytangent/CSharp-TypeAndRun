using System;
using System.Drawing;
using System.Text;

class GuessTheNumber {


        public static void Main(string[] args) {
            int winingNum = GuessTheNumber.getRandomNumber(10);
            int guesses = 0;
            string valueEnter = "";
            int val = 0;
            string errMsg;

            bool cont = true;

            WriteStatistics(valueEnter, guesses, (string) "");

            while(cont == true) {
                Console.Write("\nEnter Guess: ");
                valueEnter = Console.ReadLine();

                try {
                    val = Convert.ToInt32(valueEnter);

                    guesses += 1;

                    if ( val < 0 || val > 10 ) {
                        //Bad value!
                        errMsg = "Number is out of range. Try again!";
                        WriteStatistics(valueEnter, guesses, errMsg);
                    } else {
                        if ( val < winingNum ) {
                            errMsg = "You guessed low .. Try again.";
                             WriteStatistics(valueEnter, guesses, errMsg);
                        } else {
                            if (val > winingNum ) {
                                errMsg = "You guessed high .. Try again.";
                                WriteStatistics(valueEnter, guesses, errMsg);
                            } else {
                                Console.WriteLine("\n\nCurrent Guess : {0}\n", val);
                                Console.WriteLine("\n\nNumber of Guesses : {0}\n", guesses);
                                Console.WriteLine("You gussed correctly");
                                cont = false;
                            }
                        }
                    }

                }catch(FormatException) {
                    errMsg = "Please enter a valid number";
                    WriteStatistics(valueEnter, guesses, errMsg);
                }


            }
        
            
        }

        private static int getRandomNumber(int randUntil) {
            if ( randUntil > 0 ) {
                Random rand = new Random();
                return (rand.Next(0, randUntil));
            } else {
                return 0;
            }
        }

        private static void WriteStatistics(string guess, int numOfGuesses, string errMsg ) {
           Console.WriteLine("\n ============================ ");
           Console.WriteLine("Current Guees: {0}", guess);
           Console.WriteLine("Number of Guesses {0}", numOfGuesses);
           if (errMsg != "") {
               Console.WriteLine(errMsg);
               Console.WriteLine("Just enter number from 1 to 10");
               Console.WriteLine("============================");
               return;
           }
        }


}