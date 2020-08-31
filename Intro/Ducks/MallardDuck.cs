using System;
using Intro.Flying;
using Intro.Quacking;

namespace Intro.Ducks
{
   public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            IQuackBehavior quackBehavior = new Quack();
            IFlyBehavior flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard Duck");
            
           // PerformQuack();
           // PerformFly();
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
