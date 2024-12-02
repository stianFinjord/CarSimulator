using System.Xml.Serialization;
using ConsoleApp7;


namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CarSimulator.Run();
            //Run();

        }

        static void Run()
        {
            StiansMethods.ShowText();
            Car stian = new Car("Mercedes Benz", 4);
            stian.PrintInfo();
            stian.TimeStep();
            stian.PrintInfo();
            stian.TimeStep();
            stian.PrintInfo();
            stian.TimeStep();
            stian.PrintInfo();
            stian.Brake();
            stian.TimeStep();
            stian.PrintInfo();
            stian.Brake();
            stian.TimeStep();
            stian.PrintInfo();
        }
    }
}
