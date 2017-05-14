using EntityVisualizer;
using EntityVisualizerTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
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

            new EntityDialog(entity).ShowDialog();
        }
    }
}
