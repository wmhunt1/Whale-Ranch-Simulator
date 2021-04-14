using System;

namespace WhaleModels
{
    public class Whale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int PersonalityId { get; set; }
        Personality Personality { get; set; }
        public int SpeciesId { get; set; }
        Species Species { get; set; }
        public int Age { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Sex { get; set; }
        public CalculateHappiness()
        {

        }
        public CalculateHealth()
        {

        }
        public CalculateHunger()
        {

        }

        public CalculateSizeAndWeight()
        {
            if (Age < Species.AdultAge)
            {
                //May need to modify
                Weight = Age * Species.SizeModifier + Weight;
                Length = Age * Species.SizeModifier + Length;
            }
        }

    }
}
