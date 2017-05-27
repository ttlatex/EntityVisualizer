using EntityVisualizer;
using EntityVisualizerTest.Entity;
using Microsoft.VisualStudio.DebuggerVisualizers;
using NUnit.Framework;
using System.Collections.Generic;

namespace EntityVisualizerTest
{
    [TestFixture]
    public class ListEntityVisualizerTest
    {
        [Test]
        public void TestShowVisualizer()
        {
            var entity = new List<IceCream> {
                new IceCream { ID="1", Flavor = "Vanilla", Price = 6,Type = 0 },
                new IceCream { ID="2", Flavor = "Choco", Price = 10,Type = 0 },
                new IceCream { ID="3", Flavor = "Lemon", Price = 10,Type = 0 },
                new IceCream { ID="4", Flavor = "Cookie", Price = 10,Type = 0 },
                new IceCream { ID="5", Flavor = "Strawberry", Price = 10,Type = 0 },
                new IceCream { ID="6", Flavor = "GreenTea", Price = 10,Type = 0 },
                new IceCream { ID="7", Flavor = "Banana", Price = 10,Type = 0 },
                new IceCream { ID="8", Flavor = "Melon", Price = 10,Type = 0 },
            };

            new VisualizerDevelopmentHost(entity, typeof(ListEntityVisualizer), typeof(ListEntityVisualizerObjectSource))
                .ShowVisualizer();
        }
    }
}
