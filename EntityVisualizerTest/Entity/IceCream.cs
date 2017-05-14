using System;

namespace EntityVisualizerTest.Entity
{
    [Serializable]
    public class IceCream
    {
        public string ID { get; set; }
        public string Flavor { get; set; }
        public int Price { get; set; }
        public int Type { get; set; }
    }
}
