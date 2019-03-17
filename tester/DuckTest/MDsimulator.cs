using PadroesDeProjeto_UseACabeca.Duck;


namespace TesterDuck.DuckTest
{
    public class MDsimulator
    {
        Duck mallard = new MallardDuck();

        public void Run()
        {
            mallard.PerformanceFly();
            mallard.PerformanceQuack();
            mallard.Display();
        }
    }
}
