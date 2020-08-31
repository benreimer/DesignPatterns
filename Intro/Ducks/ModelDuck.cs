using System;
using Intro.Flying;
using Intro.Quacking;

namespace Intro.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            IFlyBehavior flyBehavior = new FlyNoWay();
            IQuackBehavior quackBehavior = new Quack();
        }

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
