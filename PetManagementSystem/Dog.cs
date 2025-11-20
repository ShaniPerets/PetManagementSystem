using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PetManagementSystem
{
     public class Dog : Pet
    {
        private string breed;  //Private field - encapsulated


        //Parameterized Constructor
        public Dog(string name, int age, string breed)
            : base(name, age,"Dog")
        {
            this.breed = breed;
        }

        //Empty Constructor - Overloading
        public Dog() : base("Unknown", 0, "Dog")
        {
            this.breed = "Unknown";
        }

        //Read-only properties that safely provide access to the dog's breed
        public string GetBreed()
        {
            return this.breed;
        }

        // Implementation of the abstract sound behavior for dogs
        public override string MakeSound()
        {
            return "Dogs bark";
        }

        // Implementation of the abstract eating behavior for dogs
        public override string Eat()
        {
            return "Dogs eat dog food";
        }
    }
}
