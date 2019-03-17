using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto_UseACabeca.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
