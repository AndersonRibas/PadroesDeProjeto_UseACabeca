using System;
using System.Collections.Generic;
using System.Text;
using PadroesDeProjeto_UseACabeca.Duck;

namespace TesterDuck.DuckTest
{
    class MuteDsimulator
    {
        Duck muteDuck = new PatoMudo();

        public void Run()
        {
            muteDuck.PerformanceFly();
            muteDuck.PerformanceQuack();
            muteDuck.Display();
        }
    }
}
