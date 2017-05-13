using EntityVisualizer;
using EntityVisualizerTest.Entity;
using Microsoft.VisualStudio.DebuggerVisualizers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVisualizerTest
{
    public class ListEntityVisualizerTest
    {
        [Test]
        public void TestShowVisualizer()
        {
            var entity = new List<IceCream> {
                new IceCream { Flavor = "Vanilla", Price = 6 },
                new IceCream { Flavor = "Choco", Price = 10 },
            };

            new VisualizerDevelopmentHost(entity, typeof(ListEntityVisualizer))
                .ShowVisualizer();
        }
    }
}
