using System;

namespace WhaleModels
{
    public class Ranch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RancherID { get; set; }
        public Rancher Owner { get; set; }
        public ICollection<Paddock> Paddocks { get; set; }
    }
}