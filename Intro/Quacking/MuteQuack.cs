using System;

namespace Intro.Quacking
{
   public class MuteQuack :IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("<< SILENCE >>");
        }
    }
}
