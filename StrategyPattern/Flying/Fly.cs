using System;

namespace StrategyPattern.Flying
{
   public class Fly : IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            Console.WriteLine("Fly!");
        }
    }
}
