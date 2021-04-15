using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhaleModels;
using WhaleDL;

namespace WhaleBL
{
    public interface IWhaleBL
    {
        Task<Facility> AddFacilityAsync(Facility newFacility);
        Task<Facility> DeleteFacilityAsync(Facility facility2BDeleted);
        Task<Facility> GetFacilityByIdAsync(int id);
        Task<Facility> GetFacilityByNameAsync(string name);
        Task<List<Facility>> GetFacilitiesAsync();
        Task<Facility> UpdateFacilityAsync(Facility facility2BUpdated);
        Task<Food> AddFoodAsync(Food newFood);
        Task<Food> DeleteFoodAsync(Food food2BDeleted);
        Task<Food> GetFoodByIdAsync(int id);
        Task<Food> GetFoodByNameAsync(string name);
        Task<List<Food>> GetFoodsAsync();
        Task<Paddock> UpdatePaddockAsync(Paddock paddock2BUpdated);
        Task<Paddock> AddPaddockAsync(Paddock newPaddock);
        Task<Paddock> DeletePaddockAsync(Paddock paddock2BDeleted);
        Task<Paddock> GetPaddockByIdAsync(int id);
        Task<Paddock> GetPaddockByNameAsync(string name);
        Task<List<Paddock>> GetPaddocksAsync();
        Task<Paddock> UpdatePaddockAsync(Paddock paddock2BUpdated);
        Task<Personality> AddPersonalityAsync(Personality newPersonality);
        Task<Personality> DeletePersonalityAsync(Personality personality2BDeleted);
        Task<Personality> GetPersonalityByIdAsync(int id);
        Task<Personality> GetPersonalityByNameAsync(string name);
        Task<List<Personality>> GetPersonalitiesAsync();
        Task<Personality> UpdatePersonalityAsync(Personality personality2BUpdated);
        Task<Ranch> AddRanchAsync(Ranch newRanch);
        Task<Ranch> DeleteRanchAsync(Ranch ranch2BDeleted);
        Task<Ranch> GetRanchByIdAsync(int id);
        Task<Ranch> GetRanchByNameAsync(string name);
        Task<List<Ranch>> GetRanchesAsync();
        Task<Ranch> UpdateRanchAsync(Ranch ranch2BUpdated);
        Task<Rancher> AddRancherAsync(Rancher newRancher);
        Task<Rancher> DeleteRancherAsync(Rancher rancher2BDeleted);
        Task<Rancher> GetRancherByIdAsync(int id);
        Task<Rancher> GetRancherByNameAsync(string name);
        Task<List<Rancher>> GetRanchersAsync();
        Task<Rancher> UpdateRancherAsync(Rancher rancher2BUpdated);
        Task<Species> AddSpeciesAsync(Species newSpecies);
        Task<Species> DeleteSpeciesAsync(Species species2BDeleted);
        Task<Species> GetSpeciesByIdAsync(int id);
        Task<Species> GetSpeciesByNameAsync(string name);
        Task<List<Species>> GetSpeciesAsync();
        Task<Species> UpdateSpeciesAsync(Species species2BUpdated);
        Task<Toy> AddToyAsync(Toy newToy);
        Task<Toy> DeleteToyAsync(Toy toy2BDeleted);
        Task<Toy> GetToyByIdAsync(int id);
        Task<Toy> GetToyByNameAsync(string name);
        Task<List<Toy>> GetToysAsync();
        Task<Toy> UpdateToyAsync(Toy toy2BUpdated);
        Task<Whale> AddWhaleAsync(Whale newWhale);
        Task<Whale> DeleteWhaleAsync(Whale whale2BDeleted);
        Task<Whale> GetWhaleByIdAsync(int id);
        Task<Whale> GetWhaleByNameAsync(string name);
        Task<List<Whale>> GetWhalesAsync();
        Task<Whale> UpdateWhaleAsync(Whale whale2BUpdated);
    }
}
