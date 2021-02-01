using System;

namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            //context.setStrategy(new Strategy1());
            context.AppliquerStrategy();


            context.setStrategy(new Strategy2());
            context.AppliquerStrategy();


            context.setStrategy(new Strategy3());
            context.AppliquerStrategy();

            Console.ReadKey();
        }
    }

    public class Context
    {
        private IStrategy strategy = new Strategy1();
        public void AppliquerStrategy()
        {
            strategy.Appliquer();
        }

        public void setStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
    }

    public class Strategy1 : IStrategy
    {
        public void Appliquer()
        {
            Console.WriteLine("J'applique la strategy 1 ...");
        }
    }

    public class Strategy2 : IStrategy
    {
        public void Appliquer()
        {
            Console.WriteLine("J'applique la strategy 2 ... ");
        }
    }

    public class Strategy3 : IStrategy
    {
        public void Appliquer()
        {
            Console.WriteLine("J'applique la strategy 3 ... ");
        }
    }
}
