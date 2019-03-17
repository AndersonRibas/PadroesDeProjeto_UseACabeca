using System;
using TesterDuck.DuckTest;


namespace TesterDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            MDsimulator patinho = new MDsimulator();
            //MuteDsimulator patinho = new MuteDsimulator();
            patinho.Run();

        }
    }
}
