﻿using System;

namespace StrategyPattern.Flying
{
   public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings!");
        }
    }
}
