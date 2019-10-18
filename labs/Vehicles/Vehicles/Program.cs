using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            // TODO:
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");

            Console.WriteLine();
            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine();
            Console.WriteLine("Journey by Boat");
            Boat myBoat = new Boat();
            myBoat.StartEngine("BoatBoatBoatBoatBoat");
            myBoat.setSail();
            myBoat.Drive();
            myBoat.anchor();
            myBoat.StopEngine("BoatPowerdown");

            Console.WriteLine("\nTesting polymorphism");//instance type polymorphism
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
            v = myBoat;
            v.Drive();




        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
