using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Intro;


namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Program p = new Program();
            p.Run();

            Intro.Class1 newClass = new Class1();
            Console.WriteLine(newClass.Print());

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
