using System;
using Intro.Flying;
using Intro.Quacking;

namespace Intro.Ducks
{
   public class BrokenDuck : Duck
    {
        public BrokenDuck()
        {
            IQuackBehavior quackBehavior = new MuteQuack();
            IFlyBehavior flyBehavior = new FlyNoWay();
        }

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
