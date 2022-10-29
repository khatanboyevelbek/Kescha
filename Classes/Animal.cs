namespace Kescha.Classes;

public interface IAnimal
{
    static string? NameOfAnimal {get; set;}
    static string? NameOfUser {get; set;}
    static int? AgeOfUser {get; set;}
    static int? AgeDifference {get; set;}
    DateTimeOffset CreatedTime {get; set;}
    void InformationsOfAge();
    void FriendsOfAnimal();
}
public abstract class Animal : IAnimal
{
    public static string? NameOfAnimal {get; set;}
    public static string? NameOfUser {get; set;}
    public static int? AgeOfUser {get; set;}
    public static int? AgeDifference {get; set;}
    public DateTimeOffset CreatedTime {get; set;}
    public Animal()
    {
        NameOfAnimal = "Unknown";
        NameOfUser = "Unknown";
        AgeOfUser = 0;
        AgeDifference = 0;
        CreatedTime = DateTimeOffset.Now;
    }
    public Animal(string nameOfAnimal,int? ageOfAnimal, string? nameOfUser, int? ageOfUser)
    {
        NameOfAnimal = nameOfAnimal;
        NameOfUser = nameOfUser;
        AgeOfUser = ageOfUser;
        AgeDifference = ageOfUser - ageOfAnimal;
        CreatedTime = DateTimeOffset.Now;
    }
    public virtual void GreetingWithUser()
    {
        Console.WriteLine($"Hello {NameOfUser}");
    }
    public void InformationsOfAge()
    {
        string compareAge = AgeDifference > 0
            ? $"You are older than {NameOfAnimal}"
            : AgeDifference == 0
            ? $"You are equal to {NameOfAnimal}"
            : $"You are younger than {NameOfAnimal}";
        Console.WriteLine($"Comparision: {compareAge}");
        Console.WriteLine($"The difference between {NameOfUser}'s and {NameOfAnimal}'s age is {AgeDifference}");
    }
    public void FriendsOfAnimal()
    {
        string?[] friends = new string?[3] {"Kasya", "Kobo", NameOfUser};
        int?[] friendsAge = {2,3, AgeOfUser};
        Console.WriteLine($"{NameOfAnimal}'s friends: ");
        for(int i = 0; i < friends.Length; i++)
        {
            Console.WriteLine($"{friends[i]} is {friendsAge[i]} years old");
        }
    }
}