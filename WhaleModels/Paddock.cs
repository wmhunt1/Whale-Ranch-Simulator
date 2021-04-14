using System;

namespace WhaleModels
{
    public class Paddock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Condition { get; set; }
        public int CurrentOccupancy { get; set; }
        public int MaxOccupancy { get; set; }
        public ICollection<Whale> Whales { get; set; }
    }
}
