namespace topic_5_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNumber;
            double numberGuess;
            secretNumber = 7;
            Console.Write("Guess a number: ");
            Double.TryParse(Console.ReadLine(), out numberGuess);
            if (numberGuess >= 11 || numberGuess <= 0)
            {
                Console.WriteLine("Out of range!");
                Console.WriteLine("The secret number is " + secretNumber + " and the range is between 1-10");
            }
            else if (numberGuess > secretNumber || numberGuess < secretNumber)
            {
                Console.WriteLine("Incorrect!");
                Console.WriteLine("The secret number was " + secretNumber + " and the range is between 1-10");
            }
            else
                Console.WriteLine("GG! You got it correctly");
                
            
        }
    }
}
