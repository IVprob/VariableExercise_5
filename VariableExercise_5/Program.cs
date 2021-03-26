using System;

namespace VariableExercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Doug";
            int dogAge = 4;
            char startWith = 'D';
            bool haveDog = true;
            double dogYears = 28.5;
            decimal dogWeight = 53.24m;

            Console.WriteLine($"My dog's name is {dogName} and he is {dogAge} in human years, but is {dogYears} in dog years. " +
                $"He is a hefty boy weighing in at {dogWeight}lbs! His name starts with the letter: {startWith} and it is {haveDog} " +
                $"he poops in the house.");
        }
    }
}
