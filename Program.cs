using System;

namespace FirstNumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            info();   
            int max;//maxn
            int min;//minn
            int rnd;
            Console.ResetColor();
            Console.WriteLine("Made by Dustin for fun! \nmade only using 95 lines of code!\n\n");//credits
            Console.WriteLine("What would you like the minimum randomly generated number to be?");
            min =Convert.ToInt32( Console.ReadLine());//convert the user givin number from a string into a integer
            Console.WriteLine("What would you like the maximum randomly generated number to be?");
            max = Convert.ToInt32(Console.ReadLine());//convert the user givin number from a string into a integer
            rnd = generateRandomNumber(min, max);//calling my method to call a random number and using user defined paramters
            Console.WriteLine("The random number is: " + rnd);
            Console.Clear();
            info();//info
            int guess;//guessed number, thihs is changed later
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Keep in mind if you write a decimal the program will break, i can fix this but im too lazy to.");
            Console.ResetColor();
            Console.WriteLine($"Guess a number that is in between {min} and {max}, you can type 001 at anytime to exit the applacation.");
            while (guess!=rnd)
            {
            
            Console.Write("My guess is ");
                Console.ForegroundColor = ConsoleColor.Red;
             guess = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                if (guess == 001)//the exit code
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing my game, i appreciate it. ");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);//exit applacation
                }
                if (guess > rnd)//if the guess number is greater than random number 
                {
                    
                    Console.WriteLine("Nice try, the number you guessed is too high, try again");
                }
                if (guess < rnd)//if the guessed number is less than random number
                {
                   
                    Console.WriteLine("Nice try, the number you guessed is too low, try again");
                }
                
                

            }
            Console.Clear();
            Console.WriteLine("Good job you guess the number!!!");
            Console.ReadKey();
        }
        /*
         * 1 -> greater than
         * 2 -> equal to
         * 3 -> less than
         * 0 -> ERROR
         */

    
       public static void info()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"NOTE: Pseudo-random numbers are chosen with equal probability from a finite set of numbers. The chosen numbers are not completely random because a mathematical algorithm is used to select them, but they are sufficiently random for practical purposes. The current implementation of the Random class is based on a modified version of Donald E. Knuth's subtractive random number generator algorithm. For more information, see D. E. Knuth. The Art of Computer Programming, Volume 2: Seminumerical Algorithms. Addison-Wesley, Reading, MA, third edition, 1997.");
            Console.WriteLine("\n so basicly im not gonna write like 600 lines of code just to generate the random number when i can use a premade API AND write it in about 20\n\n\n");
            System.Threading.Thread.Sleep(2000);
            Console.ResetColor();//reset color
        }
        static int generateRandomNumber(int min, int max)
        {
            int maxnum = max;//define a int and set it equal to the maximum user defined integer.
            int minnum = min;//define a int and setr it equal to the minimum user defined integer.
            Random rnd = new Random();//create a new varable named rnd that will generate a random int
            if (maxnum>minnum)//If the max num is greater than the small num than continue if not than restart
            {
                return rnd.Next(minnum, maxnum);//generate a random number with the user defined paramters and return it.
            }
            else
            {
                Console.WriteLine("Unable to return");
                System.Diagnostics.Process.Start(System.Diagnostics.Process.GetCurrentProcess().ToString());//restart the applacation.
                Environment.Exit(0);//exit the current applacation
                return 0;
            }
           
        }//this function is done.
    }
}
