using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Car(string _brand, float acceleration)

    {
        private float position = 0;
        private float _speed = 0;
        public void Brake()
        {
            if (_speed > 5)
            {
                _speed -= 5 + acceleration;
            }
            else
            {
                _speed = 0;
            }
        }

        public void TimeStep()
        {
            _speed += acceleration;
            position += _speed;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{_brand} is driving {_speed} m/s, " +
                              $"and has driven {position} meters");
        }

        public float getDistance()
        {
            return position;
        }

        static string distanceDriven(float distance)
        {
            distance = distance % 120;
            string distanceString = "";
            for (int i = 0; i < distance; i++)
            {
                distanceString += " ";
            }

            return distanceString;
        }

        public string render()
        {
            return "\n\n\n" + $" {distanceDriven(getDistance())}  ______\n{distanceDriven(getDistance())}  /|_||_\\`.__\n{distanceDriven(getDistance())} (   _    _ _\\\n{distanceDriven(getDistance())} =`-(_)--(_)-'";
        }

        
    }

}
