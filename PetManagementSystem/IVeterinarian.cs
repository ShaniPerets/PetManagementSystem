using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManagementSystem
{
    /*The Veterinarian interface defines the contract for all veterinarian types.
    Any veterinarian class that implements this interface must provide implementations for the methods of this interface.*/

    public interface IVeterinarian
    {
        // Returns the veterinarian's name.
        string GetName();


        // Performs an examination of the given pet.
        // Each implementing class can define its own examination logic.
        string ExaminePet(Pet pet);
    }
}
