using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class CarSimulator
    {
        public static void Run()
        {
            Car kim = new Car("Audi TT 2019", 0.5f);
            Car stian = new Car("BWM", 0.45f);
            Console.WriteLine("Bilen kjører");
            int frame = 0;
            while (true)
            {
                Thread.Sleep(300);
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n");
                
                kim.TimeStep();
                stian.TimeStep();
                Console.WriteLine(kim.render());
                Console.WriteLine(stian.render());
                
                frame++;
            }
        }

        
    }
}
