using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.Domain.IRepositories
{
    public interface IPetRepository
    {
        IEnumerable<Pet> ReadPets();
        IEnumerable<Pet> FilterPetsByType(string idPetType);
        void CreatePet(Pet petToBeCreated);
        Pet DeletePet(int idPet);
        Pet FindPetById(int idForEdit);
        Pet UpdatePet(Pet pet);
        List<Pet> SortByPrice(string sortOrder);
        IEnumerable<Pet> GetCheapestPets();
    }
}