using Kescha.Enums;

namespace Kescha.Classes;

public class Pet : Animal
{
    public PetType Type {get; set;}
    public Pet(string nameOfAnimal,  int? ageOfAnimal, string? nameOfUser, int? ageOfUser)
        : base(nameOfAnimal, ageOfAnimal, nameOfUser, ageOfUser)
    {
        Type = PetType.Cat;
    }
    public override void GreetingWithUser()
    {
        Console.WriteLine($"Meoo {NameOfUser}");
    }
}