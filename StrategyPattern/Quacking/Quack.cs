using System;

namespace StrategyPattern.Quacking
{
   public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
