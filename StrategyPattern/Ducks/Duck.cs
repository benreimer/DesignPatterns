using System;
using StrategyPattern.Flying;
using StrategyPattern.Quacking;

namespace StrategyPattern.Ducks
{
   public abstract class Duck
   {
       private IFlyBehavior flyBehavior;
       private IQuackBehavior quackBehavior;

       public abstract void Display();

      public abstract void Execute();

      public void PerformFly()
       {
           flyBehavior.Fly();

       }

       public void PerformQuack()
       {
           quackBehavior.Quack();
       }

       public void Swim()
       {
           Console.WriteLine("All ducks can swim, even decoys!");
       }

       public void SetFlyBehavior(IFlyBehavior fb)
       {
           flyBehavior = fb;
       }

       public void SetQuackBehavior(IQuackBehavior qb)
       {
           quackBehavior = qb;
       }
    }
}
