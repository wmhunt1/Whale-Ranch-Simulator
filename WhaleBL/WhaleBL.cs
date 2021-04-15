using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhaleModels;
using WhaleDL;

namespace WhaleBL
{
    public class WhaleBL : IWhaleBL
    {
        private IWhaleRepoDB _repo;
        public WhaleBL(IWhaleRepoDB repo)
        {
            _repo = repo;
        }
        public async Task<Facility> AddFacilityAsync(Facility newFacility)
        {
            //Todo: Add BL
            return await _repo.AddFacilityAsync(newFacility);
        }
        public async Task<Facility> DeleteFacilityAsync(Facility facility2BDeleted)
        {
            return await _repo.DeleteFacilityAsync(facility2BDeleted);
        }
        public async Task<Facility> GetFacilityByIdAsync(int Id)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetFacilityByIdAsync(id);
        }
        public async Task<Facility> GetFacilityByNameAsync(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetFacilityByNameAsync(name);
        }
        public async Task<List<Facility>> GetFacilitiesAsync()
        {
            //TODO add BL
            return await _repo.GetFacilitiesAsync();
        }
        public async Task<Facility> UpdateFacilityAsync(Facility facility2BUpdated)
        {
            return await _repo.UpdateFacilityAsync(facility2BUpdated);
        }
        public async Task<Food> AddFoodAsync(Food newFood)
        {
            //Todo: Add BL
            return await _repo.AddFoodAsync(newFood);
        }
        public async Task<Food> DeleteFoodAsync(Food food2BDeleted)
        {
            return await _repo.DeleteFoodAsync(food2BDeleted);
        }
        public async Task<Food> GetFoodByIdAsync(int Id)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetFoodByIdAsync(id);
        }
        public async Task<Food> GetFoodByNameAsync(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetFoodByNameAsync(name);
        }
        public async Task<List<Food>> GetFoodsAsync()
        {
            //TODO add BL
            return await _repo.GetFoodsAsync();
        }
        public async Task<Food> UpdateFoodAsync(Food food2BUpdated)
        {
            return await _repo.UpdateFoodAsync(food2BUpdated);
        }
        public async Task<Paddock> AddPaddockAsync(Paddock newPaddock)
        {
            //Todo: Add BL
            return await _repo.AddPaddockAsync(newPaddock);
        }
        public async Task<Paddock> DeletePaddockAsync(Paddock paddock2BDeleted)
        {
            return await _repo.DeletePaddockAsync(Paddock2BDeleted);
        }
        public async Task<Paddock> GetPaddockByIdAsync(int Id)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetPaddockByIdAsync(id);
        }
        public async Task<Paddock> GetPaddockByNameAsync(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetPaddockByNameAsync(name);
        }
        public async Task<List<Paddock>> GetPaddocksAsync()
        {
            //TODO add BL
            return await _repo.GetPaddocksAsync();
        }
        public async Task<Paddock> UpdatePaddockAsync(Paddock paddock2BUpdated)
        {
            return await _repo.UpdatePaddockAsync(paddock2BUpdated);
        }
        public async Task<Personality> AddPersonalityAsync(Personality newPersonality)
        {
            //Todo: Add BL
            return await _repo.AddPersonalityAsync(newPersonality);
        }
        public async Task<Personality> DeletePersonalityAsync(Personality personality2BDeleted)
        {
            return await _repo.DeletePersonalityAsync(personality2BDeleted);
        }
        public async Task<Personality> GetPersonalityByIdAsync(int Id)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetPersonalityByIdAsync(id);
        }
        public async Task<Personality> GetPersonalityByNameAsync(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetPersonalityByNameAsync(name);
        }
        public async Task<List<Personality>> GetPersonalitiesAsync()
        {
            //TODO add BL
            return await _repo.GetPersonalitiesAsync();
        }
        public async Task<Personality> UpdatePersonalityAsync(Personality personality2BUpdated)
        {
            return await _repo.UpdatePersonalityAsync(personality2BUpdated);
        }
        public async Task<Ranch> AddRanchAsync(Ranch newRanch)
        {
            //Todo: Add BL
            return await _repo.AddRanchAsync(newRanch);
        }
        public async Task<Ranch> DeleteRanchAsync(Ranch ranch2BDeleted)
        {
            return await _repo.DeleteRanchAsync(ranch2BDeleted);
        }
        public async Task<Ranch> GetRanchByIdAsync(int Id)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetRanchByIdAsync(id);
        }
        public async Task<Ranch> GetRanchByNameAsync(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetRanchByNameAsync(name);
        }
        public async Task<List<Ranch>> GetRanchesAsync()
        {
            //TODO add BL
            return await _repo.GetRanchesAsync();
        }
        public async Task<Ranch> UpdateRanchAsync(Ranch ranch2BUpdated)
        {
            return await _repo.UpdateRanchAsync(ranch2BUpdated);
        }
        public async Task<Rancher> AddRancherAsync(Rancher newRancher)
        {
            //Todo: Add BL
            return await _repo.AddRancherAsync(newRancher);
        }
        public async Task<Rancher> DeleteRancherAsync(Rancher rancher2BDeleted)
        {
            return await _repo.DeleteRancherAsync(rancher2BDeleted);
        }
        public async Task<Rancher> GetRancherByIdAsync(int Id)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetRancherByIdAsync(id);
        }
        public async Task<Rancher> GetRancherByNameAsync(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetRancherByNameAsync(name);
        }
        public async Task<List<Rancher>> GetRanchersAsync()
        {
            //TODO add BL
            return await _repo.GetRanchersAsync();
        }
        public async Task<Rancher> UpdateRancherAsync(Rancher rancher2BUpdated)
        {
            return await _repo.UpdateRancherAsync(rancher2BUpdated);
        }
        public async Task<Species> AddSpeciesAsync(Species newSpecies)
        {
            //Todo: Add BL
            return await _repo.AddSpeciesAsync(newSpecies);
        }
        public async Task<Species> DeleteSpeciesAsync(Species species2BDeleted)
        {
            return await _repo.DeleteSpeciesAsync(species2BDeleted);
        }
        public async Task<Species> GetSpeciesByIdAsync(int Id)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetSpeciesByIdAsync(id);
        }
        public async Task<Species> GetSpeciesByNameAsync(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetSpeciesByNameAsync(name);
        }
        public async Task<List<Species>> GetSpeciesAsync()
        {
            //TODO add BL
            return await _repo.GetSpeciesAsync();
        }
        public async Task<Species> UpdateSpeciesAsync(Species species2BUpdated)
        {
            return await _repo.UpdateSpeciesAsync(species2BUpdated);
        }
        public async Task<Toy> AddToyAsync(Toy newToy)
        {
            //Todo: Add BL
            return await _repo.AddToyAsync(newToy);
        }
        public async Task<Toy> DeleteToyAsync(Toy toy2BDeleted)
        {
            return await _repo.DeleteToyAsync(toy2BDeleted);
        }
        public async Task<Toy> GetToyByIdAsync(int Id)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetToyByIdAsync(id);
        }
        public async Task<Toy> GetToyByNameAsync(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetToyByNameAsync(name);
        }
        public async Task<List<Toy>> GetToysAsync()
        {
            //TODO add BL
            return await _repo.GetToysAsync();
        }
        public async Task<Toy> UpdateToyAsync(Toy toy2BUpdated)
        {
            return await _repo.UpdateToyAsync(toy2BUpdated);
        }
        public async Task<Whale> AddWhaleAsync(Whale newWhale)
        {
            //Todo: Add BL
            return await _repo.AddWhaleAsync(newWhale);
        }
        public async Task<Whale> DeleteWhaleAsync(Whale whale2BDeleted)
        {
            return await _repo.DeleteWhaleAsync(whale2BDeleted);
        }
        public async Task<Whale> GetWhaleByIdAsync(int Id)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetWhaleByIdAsync(id);
        }
        public async Task<Whale> GetWhaleByNameAsync(string name)
        {
            //Todo: check if the name given is not null or empty string 
            return await _repo.GetWhaleByNameAsync(name);
        }
        public async Task<List<Whale>> GetWhalesAsync()
        {
            //TODO add BL
            return await _repo.GetWhalesAsync();
        }
        public async Task<Whale> UpdateWhaleAsync(whale whale2BUpdated)
        {
            return await _repo.UpdateWhaleAsync(whale2BUpdated);
        }
    }
}