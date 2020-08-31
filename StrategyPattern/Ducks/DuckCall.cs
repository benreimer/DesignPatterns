using System;
using StrategyPattern.Flying;
using StrategyPattern.Quacking;

namespace StrategyPattern.Ducks
{
   public class DuckCall : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Duck Call");
        }

        public override void Execute()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Quack());
            Display();
            PerformFly();
            PerformQuack();
        }
    }
}
