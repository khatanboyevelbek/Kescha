namespace Kescha.Classes;
public class Animal
{
    public string? NameOfUser {get; set;}
    public int? AgeOfUser {get; set;}
    public int? AgeDifference {get; set;}
    public Animal()
    {
        AgeOfUser = 0;
        AgeDifference = 0;
        NameOfUser = "Unknown";
    }
    public Animal(string? nameOfUser, int? ageOfUser,  int? ageOfAnimal)
    {
        NameOfUser = nameOfUser;
        AgeOfUser = ageOfUser;
        AgeDifference = ageOfUser - ageOfAnimal;
    }
    public void InformationsOfAge()
    {
        string compareAge = this.AgeDifference > 0
            ? "You are older than kescha"
            : this.AgeDifference == 0
            ? "You are equal to kescha"
            : "You are younger than kescha";
        Console.WriteLine($"Comparision: {compareAge}");
        Console.WriteLine($"The difference between {this.NameOfUser}'s and kescha's age is {this.AgeDifference}");
    }
    public void FriendsOfKescha()
    {
        string?[] friends = new string?[3] {"Kasya", "Kobo", this.NameOfUser};
        int?[] friendsAge = {2,3, this.AgeOfUser};
        Console.WriteLine("Kescha's friends: ");
        for(int i = 0; i < friends.Length; i++)
        {
            Console.WriteLine($"{friends[i]} is {friendsAge[i]} years old");
        }
    }
}