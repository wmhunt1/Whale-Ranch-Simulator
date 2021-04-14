using System;

namespace WhaleModels
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int FoodId { get; set; }
        public Food Diet { get; set; }

        // Make derives size etc, appearance
    }
}