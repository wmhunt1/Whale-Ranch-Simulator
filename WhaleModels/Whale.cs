using System;

namespace WhaleModels
{
    public class Whale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PersonalityId { get; set; }
        Personality Personality { get; set; }
        public int SpeciesId { get; set; }
        Species Species { get; set; }
        
        public int Age { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Sex { get; set; }

        //methods to get length and weight from species etc

    }
}
