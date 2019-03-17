using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto_UseACabeca.Duck
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Estou voando!!");
        }
    }
}
