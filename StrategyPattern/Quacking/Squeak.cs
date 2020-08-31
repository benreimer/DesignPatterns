using System;

namespace StrategyPattern.Quacking
{
    public class Squeak : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("SQUEAK!");
        }
    }
}
