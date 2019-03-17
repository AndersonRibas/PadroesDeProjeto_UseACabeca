using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto_UseACabeca.Duck
{
    public class PatoMudo : Duck
    {
        public PatoMudo()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Não falo nada....");
        }
    }
}
