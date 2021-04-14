using System;

namespace WhaleModels
{
    public class Personality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public int FavoriteToyId { get; set; }
        public Toy FavoriteToy { get; set; }

    }
}