namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you favorite subject?");
            
            var subject = Console.ReadLine();



            switch (subject)
            {
                case "algebra":
                    Console.WriteLine("I always did well in math!");
                    break;
                case "science":
                    Console.WriteLine("I always found science fascinating!");
                    break;
                case "music":
                    Console.WriteLine("Music can very relaxing.");
                    break;
                case "gym":
                    Console.WriteLine("It is always good to have physical exercise to get your blood flowing after sitting in class!");
                    break;
                case "literature":
                    Console.WriteLine("A good book is always enjoyable!");
                    break;
                default:
                    Console.WriteLine("I never took any classes in that subject, but it sounds interesting.");
                    break;


            }
        }
    }
}