using System;

using ConsoleNet;

namespace ConsoleNetTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application app = new Application("ConsoleNetTest");

            app.AddCommand(new FrameworkCommand("hello", SayHello)
                { 
                    Description = "Prints hello!",
                    Help = "Option: --name <Name>"
                });

            app.Run(args);
        }

        static void SayHello(Application app)
        {
            string name;
            app.TryGetParam("name", out name);

            Console.WriteLine(string.Format("Hello, {0}!", name ?? app.Label));
        }
    }
}
