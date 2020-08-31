using System;

namespace StrategyPattern.Quacking
{
   public class MuteQuack :IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("<< SILENCE >>");
        }
    }
}
