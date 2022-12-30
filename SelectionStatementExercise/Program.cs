namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            Console.WriteLine("Enter a number between 1 and 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("I'm sorry, thats too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("I'm sorry, too high!");
            }
            else 
            {
                Console.WriteLine("Congratulations, you guessed correct!!");
            }            
            
        }
    }
}
