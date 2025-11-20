using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManagementSystem
{
    internal class GeneralVeterinarian : IVeterinarian
    {
        private string name; //Private field - encapsulated

        //Parameterized Constructor
        public GeneralVeterinarian (string name)
        {
            this.name = name;
        }
        // Read-only properties that safely provide access to the veterinarian's name
        public string GetName()
        {
            return name;
        }

        //Returns a string describing the general examination of the pet
        public string ExaminePet(Pet pet)
        {
            return $"{pet.GetSpecies()} '{pet.GetName()}' was checked by Dr. {name}.";
        }
    }
}
