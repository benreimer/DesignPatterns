using System;
using StrategyPattern.Flying;
using StrategyPattern.Quacking;

namespace StrategyPattern.Ducks
{
    public class ModelDuck : Duck
    {

        public override void Display()
        {
            Console.WriteLine("I'm a Model Duck!");
        }

        public override void Execute()
        {
            SetFlyBehavior(new FlyRocketPowered());
            SetQuackBehavior(new Quack());
            Display();
            PerformFly();
            PerformQuack();
        }
    }
}
