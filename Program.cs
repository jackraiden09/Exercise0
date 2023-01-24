using System.Globalization;
using Cars.Models;

namespace Cars
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Number 8
            List<Vehicle> vehicles = new List<Vehicle>();


            //Number 9
            Console.Write("How many vehicles you like to add? ");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            //Number 10
            for (int i = 0; i < num; i++)
            {
                //Number 11
                Console.Write("Do you want to create a Car or Truck? ");
                string userChoice = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (userChoice == "car")
                {
                    Console.Write("Enter Car Brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter Car Model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter Car Color: ");
                    string color = Console.ReadLine();

                    Car inputCar = new Car(brand, model, color);
                    vehicles.Add(inputCar);
                    Console.WriteLine(); //new line for readability

                }
                else if (userChoice == "truck")
                {
                    Console.Write("Enter Truck Brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter Truck Model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter Truck Capacity: ");
                    string tempCapacity = Console.ReadLine();
                    float capacity = float.Parse(tempCapacity);

                    Console.Write("Enter Truck Color: ");
                    string color = Console.ReadLine();

                    Truck inputTruck = new Truck(brand, model, capacity, color);
                    vehicles.Add(inputTruck);
                    Console.WriteLine(); //new line for readability
                }

                
            }

            //Number 12 
            Console.WriteLine("HERE IS THE SUMMARY REPORT");
            Console.WriteLine(); //new line for readability
            foreach (Vehicle v in vehicles)
            {
                if (v.GetType() == typeof(Car))
                {
                    Car temp = (Car)v;
                    Console.WriteLine("Vehicle is a Car");
                    Console.WriteLine(temp.ShowVehicle());
                    Console.WriteLine("-------------------------------");
                }
                else if (v.GetType() == typeof(Truck))
                {
                    Truck temp = (Truck)v;
                    Console.WriteLine("Vehicle is a Truck!");
                    Console.WriteLine(temp.ShowVehicle());
                    Console.WriteLine("-------------------------------");
                }
            }
        }
    }
}