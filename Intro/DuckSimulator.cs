using Intro.Ducks;
using Intro.Flying;
using Intro.Quacking;

namespace Intro
{
    public class DuckSimulator
    {
        public void Execute()
        {
            Print();

            CreateModelDuck();

            CreateMallardDuck();

            CreateMallardDuckWithRocketAndSqueak();

            CreateDuckCall();

            CreateBrokenDuckCall();
        }

        private void CreateMallardDuckWithRocketAndSqueak()
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.SetFlyBehavior(new FlyRocketPowered());
            mallardDuck.SetQuackBehavior(new Squeak());
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
        }


        private void CreateBrokenDuckCall()
        {
            Duck brokenDuckCall = new BrokenDuck();
            brokenDuckCall.Execute();
        }

        private void CreateDuckCall()
        {
            Duck duckCall = new DuckCall();
            duckCall.Execute();
        }

        private void CreateMallardDuck()
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.Execute();
        }

        private void CreateModelDuck()
        {
            Duck modelDuck = new ModelDuck();
            modelDuck.Execute();
        }

        public string Print()
        {
            return "This is the duck simulator....";
        }

    }
}
