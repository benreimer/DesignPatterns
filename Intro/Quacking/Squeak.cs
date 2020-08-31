using System;

namespace Intro.Quacking
{
    public class Squeak : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("SQUEAK!");
        }
    }
}
