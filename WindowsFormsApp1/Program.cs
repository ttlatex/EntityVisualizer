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
                new IceCream { Flavor = "Vanilla", Price = 6 },
                new IceCream { Flavor = "Choco", Price = 10 },
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EntityDialog(entity));
        }
    }
}
