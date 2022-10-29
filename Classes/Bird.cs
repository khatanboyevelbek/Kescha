using Kescha.Enums;

namespace Kescha.Classes;

public class Bird : Animal
{
    public PetType Type {get; set;}
    public Bird(string nameOfAnimal,  int? ageOfAnimal, string? nameOfUser, int? ageOfUser) 
        : base(nameOfAnimal, ageOfAnimal, nameOfUser, ageOfUser)
    {
        Type = PetType.Bird;
    }
    public override void GreetingWithUser()
    {
        Console.WriteLine($"Chii {NameOfUser}");
    }
}