using Kescha.Classes;

namespace Kescha.App;
public class Kescha
{
    public static void Main(string[] args)
    {
        // Simple Authentication
        string? password;
        do
        {
            Console.Write("Enter your password: ");
            password = Console.ReadLine();
        } while (password != "elbek2001");

        // User informations
        Console.Write("Enter your name: ");
        string? nameOfUser = Console.ReadLine();
        Console.Write($"Hey {nameOfUser}! Enter your age: ");
        int? ageOfUser = Convert.ToInt32(Console.ReadLine());

        Animal kescha = new(nameOfUser, ageOfUser, ageOfAnimal: 3);
        kescha.InformationsOfAge();
        kescha.FriendsOfKescha();
    }
}