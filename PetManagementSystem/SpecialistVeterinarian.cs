using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetManagementSystem
{
    internal class SpecialistVeterinarian : IVeterinarian
    {
        private string name; //Private field - encapsulated
        private string specialty; //Private field - encapsulated

        //Parameterized Constructor
        public SpecialistVeterinarian(string name, string specialty)
        {
            this.name = name;
            this.specialty = specialty;
        }

        // Read-only properties that safely provide access to the veterinarian’s name and specialty
        public string GetName()
        {
            return name;
        }

        public string GetSpecialty()
        {
            return specialty;
        }

        //Returns a string describing the specialized examination of the pet
        public string ExaminePet(Pet pet)
        {
            return $"Specialist exam by {name} ({specialty}): Checking {pet.GetName()} for {specialty} related issues.";
        }
    }
}
