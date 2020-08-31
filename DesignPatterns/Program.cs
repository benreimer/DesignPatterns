using System;
using Intro;


namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();

            DuckSimulator duckSimulator = new DuckSimulator();
            duckSimulator.Execute();

            p.Exit();
        }


        private void Run()
        {
            Console.WriteLine("program is running....");
        }

        private void Exit()
        {
            Console.WriteLine("Exiting.....press any key to exit");
            Console.ReadLine();
        }
    }
}
