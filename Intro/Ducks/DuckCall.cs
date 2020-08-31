using System;
using Intro.Flying;
using Intro.Quacking;

namespace Intro.Ducks
{
   public class DuckCall : Duck
    {
        public DuckCall()
        {
            IQuackBehavior quackBehavior = new Quack();
            IFlyBehavior flyBehavior = new FlyNoWay();
        }

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
