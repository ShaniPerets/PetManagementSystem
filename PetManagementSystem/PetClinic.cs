using System;
using System.Collections.Generic;


namespace PetManagementSystem
{
    public class PetClinic
    {
        static void Main(string[] args)
        {
            //Pets list - can be dog or cat
            List<Pet> pets = new List<Pet>()
            {
                new Dog("Buddy", 3, "Labrador"),
                new Dog("Rocky", 1, "German Shepherd"),
                new Cat("Misty", 2, "White"),
                new Cat("Snow", 4, "Black"),
                new Dog(),
                new Cat()
            };

            // veterinarians list - can be general or specialist
            List<IVeterinarian> veterinarians = new List<IVeterinarian>()
            {
            new GeneralVeterinarian("Mark"),
            new GeneralVeterinarian("David"),
            new SpecialistVeterinarian("Jhon", "Dermatology"),
            new SpecialistVeterinarian("Nate", "Nutrition")
            };

            // It shows each pet’s details and the actions
            foreach (Pet pet in pets)
            {
                Console.WriteLine($"Pet: {pet.GetName()}, Age: {pet.GetAge()}, Species: {pet.GetSpecies()}");
                if (pet is Dog dog)
                {
                    Console.WriteLine($"Breed: {dog.GetBreed()}");
                }
                else if (pet is Cat cat)
                {
                    Console.WriteLine($"Color: {cat.GetColor()}");
                }
                Console.WriteLine($"Sound: {pet.MakeSound()}");
                Console.WriteLine($"Eats: {pet.Eat()}");
                Console.WriteLine("----------------------------------------");
                // checks each pet by the two types of veterinarians
                foreach (IVeterinarian vet in veterinarians)
                {
                    Console.WriteLine(vet.ExaminePet(pet));
                }
            }

            // counts how much dogs and cats we have
            int dogCount = pets.Count(p => p.GetSpecies() == "Dog");
            int catCount = pets.Count(p => p.GetSpecies() == "Cat");
            Console.WriteLine($"\nTotal Dogs: {dogCount}, Total Cats: {catCount}");

        }
    }


}
