using System;
using StrategyPattern.Flying;
using StrategyPattern.Quacking;

namespace StrategyPattern.Ducks
{
   public class BrokenDuck : Duck
    {
        

        public override void Display()
        {
            Console.WriteLine("I'm a Broken Duck Call");
        }

        public override void Execute()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new MuteQuack());
            Display();
            PerformFly();
            PerformQuack();
        }
    }
}
