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

        // Implementation of the abstract sound behavior for cats
        public override string MakeSound()
        {
           return "Cats Meow";
        }

        // Implementation of the abstract eating behavior for dogs
        public override string Eat()
        {
            return "Cats eat cat food";
        }
    }
}
