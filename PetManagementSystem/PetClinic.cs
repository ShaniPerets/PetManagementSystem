using System;
using System.Collections.Generic;


namespace PetManagementSystem
{
    public class PetClinic
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>()
        {
                new Dog("Buddy", 3, "Labrador"),
                new Cat("Misty", 2, "White")
        };

            IVeterinarian generalVet = new GeneralVeterinarian("Dr. Green");
            IVeterinarian specialistVet = new SpecialistVeterinarian("Dr. Brown", "Dermatology");
            foreach (Pet pet in pets)
            {
                Console.WriteLine($"Pet: {pet.GetName()}, Age: {pet.GetAge()}, Species: {pet.GetSpecies()}");
                Console.WriteLine($"Sound: {pet.MakeSound()}");
                Console.WriteLine($"Eats: {pet.Eat()}");

                Console.WriteLine(generalVet.ExaminePet(pet));
                Console.WriteLine(specialistVet.ExaminePet(pet));

                Console.WriteLine("----------------------------------------");
            }
        }
    }
       
}
