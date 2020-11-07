using System;
using System.Collections.Generic;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("BMW", "X5", 50000.99f, "Black", 2016);
            Car volvo = new Car("Volvo", "GG", 5000.99f, "Blue", 1999);
            Car mercedess = new Car("Mercedess", "C", 30000.99f, "Red", 2012);
            Car audi = new Car("Audi", "TT", 25000.99f, "Green", 2010);
            Car wolksvagen = new Car("Wolksvagen", "Golf10", 25000.98f, "Gray", 1999);


            List<Car> carList = new List<Car>();
            carList.Add(bmw);
            carList.Add(volvo);
            carList.Add(mercedess);
            carList.Add(audi);
            carList.Add(wolksvagen);

            Car expensiveCar = new Car();
            foreach (Car car in carList)
            {
                if (car.Price > expensiveCar.Price)
                {
                    expensiveCar = car;
                }
            }
            Console.WriteLine(expensiveCar.GetString());
        }
    }
}
