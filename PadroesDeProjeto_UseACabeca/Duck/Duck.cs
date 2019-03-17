using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto_UseACabeca.Duck

{
    public abstract class Duck
    {
        public QuackBehavior QuackBehavior { get; set; }
        public FlyBehavior FlyBehavior { get; set; }

        public Duck()
        {

        }

       

        public abstract void Display();

        public void PerformanceFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformanceQuack()
        {
            QuackBehavior.MQuack();
        }

        public void Swin()
        {
            Console.WriteLine("all ducks float, even decoys");
        }
    }
}
