using System;

namespace Intro.Quacking
{
   public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
