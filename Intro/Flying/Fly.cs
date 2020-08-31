using System;

namespace Intro.Flying
{
   public class Fly : IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            Console.WriteLine("Fly!");
        }
    }
}
