using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myHashSet = new HashSet<string>();
            myHashSet.Add("Hello");
            myHashSet.Add("World.");
            myHashSet.Add("How");
            myHashSet.Add("Hello");

            foreach (var item in myHashSet)
            {
                Console.WriteLine(item);
            }

            Car myCar = new Car()
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2005
            };         
                        
            Console.WriteLine(myCar);

            Console.ReadLine();
        }
    } 

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Year { get; set; } 



        public Car(string make, string model, double year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        } 



        public Car()
        {
            HashSet<Car> CarInstance = new HashSet<Car>();
        }
    }
}
