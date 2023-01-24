namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string catsName = "Rosie";
            string catsOtherName = "Rosie Posey";
            int catsAge = 3;
            char catsInitals = 'R';
            bool cuteCat = true;
            Double catsWeight = 10.5;
            decimal catNaps = 10.5m;

            Console.WriteLine($"My cats name is {catsName}, we sometime call her {catsOtherName}. " +
                $"She is {catsAge} years old!");
        }
    }
}
