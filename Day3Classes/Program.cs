using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ScottsCar = new Car(); 
            ScottsCar.HasSpinners = true;
            ScottsCar.Make = "Buick";
            ScottsCar.Model = "Skylark";
            ScottsCar.MSRP = 10000.53m;
            ScottsCar.EngineSize = "V8";
            Console.WriteLine(ScottsCar.DisplaySpeed());

            ScottsCar.Stop();
            Console.WriteLine(ScottsCar.DisplaySpeed());
            ScottsCar.SetSpeed(20);
            Console.WriteLine(ScottsCar.DisplaySpeed());


            Car DavidsCar = new Car();
            DavidsCar.HasSpinners = false;
            DavidsCar.Make = "Toyota";
            DavidsCar.Model = "Sequoia";
            DavidsCar.MSRP = 18000.53m;
            DavidsCar.EngineSize = "V4";

            Car[] studentCars = new Car[] { ScottsCar, DavidsCar };

            foreach(Car currentCar in studentCars)
            {
                Console.WriteLine(currentCar.DisplaySpeed());
                //  Console.WriteLine("Make: {0}, Model {1}, MSRP: {2:C}", c.Make, c.Model, c.MSRP);
                currentCar.TurnSteeringWheel("Right", 45);
            }

            Console.ReadLine();
        }


    }

    public class Car
    {
        //CONSTRUCTOR
        public Car()
        {
            Speed = 60; 
        }

        public int Speed; //mph we are going
        public string EngineSize;
        public int Weight;
        public string Model;
        public string Make;
        public decimal MSRP;
        public bool HasSpinners;

        public string DisplaySpeed()
        {
            return string.Format("The {0} {1} is currently going {2} mph", Make, Model, Speed);
        }
        public void TurnSteeringWheel(string direction, int degrees)
        {
            if (Make == "Buick")
            {
                Console.WriteLine("This car is broken and can't turn");
                return;
            }

            if (direction == "Left")
            {
                Console.WriteLine("{1} {2} just turned left {0} degrees", degrees, Make, Model);
            }
            else if (direction == "Right")
            {
                Console.WriteLine("{1} {2} just turned left {0} degrees", degrees, Make, Model);
            }
        }

        public void Stop()
        {
            Speed = 0;
        }

        public void SetSpeed(int newSpeed)
        {
            Speed = newSpeed;
        }
    }
}
