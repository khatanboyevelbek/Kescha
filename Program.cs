namespace Kescha.Classes
{
    public class Kescha
    {
        public static void Main(string[] args)
        {
            int keschaAge = 3;
            Console.Write("Type your name: ");
            string? firstName = Console.ReadLine();
            Console.Write($"Hey {firstName}! Type your age: ");
            int? age = Convert.ToInt32(Console.ReadLine());
            int? ageDifference = age - keschaAge;
            Console.WriteLine($"The difference between {firstName}'s and kescha's age is {ageDifference}");
        }
    }
}