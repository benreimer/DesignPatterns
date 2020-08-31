using System;
using StrategyPattern.Flying;
using StrategyPattern.Quacking;

namespace StrategyPattern.Ducks
{
   public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard Duck");
        }

        public override void Execute()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new Quack());
            Display();
            PerformFly();
            PerformQuack();
        }
    }
}
