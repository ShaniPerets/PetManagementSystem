using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetManagementSystem
{

    /*Pet is an abstract class — can't be instantiated,
      Pet includes abstract methods that the derived classes implement.*/

    public abstract class Pet
    {
        private string name; //Private field - encapsulated
        private int age; //Private field - encapsulated
        protected string species; // Protected so derived classes may access.

        //Parameterized Constructor
        public Pet(string name, int age, string species)
        {
            this.name = name;
            this.age = age;
            this.species = species;
        }


        // Read-only properties that safely provide access to the pet’s name and age
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        { 
            return age; 
        }

        public string GetSpecies()
        {
            return species;
        }
        // Abstract methods implemented by derived classes
        public abstract string MakeSound();
        public abstract string Eat();
    }
}
