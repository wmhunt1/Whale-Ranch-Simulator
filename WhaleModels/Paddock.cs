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
        public ICollection<Food> Trough { get; set; }
        public ICollection<Whale> Whales { get; set; }
        public int RanchId { get; set; }
        public Ranch Ranch { get; set; }
        public int ToyId { get; set; }
        public Toy Enrichment { get; set; }
    }
}
