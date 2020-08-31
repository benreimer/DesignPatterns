using System;
using Intro.Flying;
using Intro.Quacking;

namespace Intro.Ducks
{
   public abstract class Duck
   {
       private IFlyBehavior flyBehavior;
       private IQuackBehavior quackBehavior;

       //private IFlyBehavior flyBehavior = new Fly();
       //private IQuackBehavior quackBehavior = new Quack();

       protected Duck()
       {

       }

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
