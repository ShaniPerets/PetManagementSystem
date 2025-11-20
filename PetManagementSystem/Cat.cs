using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManagementSystem
{
    public class Cat : Pet
    {
        private string color; //Private field - encapsulated

        //Parameterized Constructor
        public Cat(string name, int age, string color)
          : base(name, age, "Cat")
        {
            this.color = color;
        }

        //Empty Constructor - Overloading
        public Cat() : base("Unknown", 0, "Cat")
        {
            this.color = "Unknown";
        }

        //Read-only properties that safely provide access to the cat's color
        public string GetColor()
        {
            return this.color;
        }

        // Implementation of the abstract sound behavior for cats
        public override string MakeSound()
        {
           return "Cats Meow";
        }

        // Implementation of the abstract eating behavior for cats
        public override string Eat()
        {
            return "Cats eat cat food";
        }
    }
}
