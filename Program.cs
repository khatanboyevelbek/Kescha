using Kescha.Classes;

namespace Kescha.App;
public class Kescha
{
    public static void Main(string[] args)
    {
        try
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

            Bird kescha = new(nameOfAnimal: "kescha", ageOfAnimal: 3, nameOfUser, ageOfUser);
            Console.WriteLine(kescha.CreatedTime);
            kescha.GreetingWithUser();
            kescha.InformationsOfAge();
            kescha.FriendsOfAnimal();
            Bird dove = new(nameOfAnimal: "dove", ageOfAnimal: 1, nameOfUser, ageOfUser);
            Console.WriteLine(kescha.CreatedTime);
            Console.WriteLine(dove.Type);
            dove.GreetingWithUser();
            dove.InformationsOfAge();
            dove.FriendsOfAnimal();
            Pet kasee = new(nameOfAnimal: "kasee", ageOfAnimal: 2, nameOfUser, ageOfUser);
            Console.WriteLine(kescha.CreatedTime);
            Console.WriteLine(kasee.Type);
            kasee.GreetingWithUser();
            kasee.InformationsOfAge();
            kasee.FriendsOfAnimal();
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
}