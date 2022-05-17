/*
TODO:
[]    find some way to implement tires
[]    comment!!!
[]    add a system to put things in a car's storage
[]    add passengers
[]    differentiate between a passenger and a driver
[]    maintanance system (i.e. take in a car to get fixed)

*/
using System;

namespace CarClass
{
    class CarTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------First Car---------------");
            Car car = new Car();
            getCarType(car);
            getPaintJob(car, "blue");
            getStorage(car, getCarType(car));
            Console.WriteLine(car.color);
            Console.WriteLine("---------------Second Car---------------");
            Car car2 = new Car();
            setCarType(car2, "truck");
            getPaintJob(car2, "green");
            getStorage(car2, getCarType(car2));

        }
    }
    public class Car
    {
        //default color is red
        string color = "red";
        //to be implemented
        string tires = "well worn";
        //default car is a sedan
        string carType = "sedan";
        //sedans have 3 storage spots
        string[] storage = new string[3] {"nothing","nothing","nothing"};

        

        static void getPaintJob(Car car, string color)
        {
            Console.WriteLine(String.Format("Getting a paint job and changing the paint from {0} to {1}",car.color,color));
            car.color = color;
        }

        static void setCarType(Car car, string type)
        {
            if(type == "sedan")
            {
                Console.WriteLine("you have a sedan");
                Console.WriteLine("it has 5 seats");
                Console.WriteLine("it has a trunk");
                car.storage = new string[3];
                for(int i = 0; i < 3 ; i++)
                {
                    car.storage[i]="nothing";
                }
            }
            else if(type == "truck")
            {
                car.carType = "truck";
                Console.WriteLine("you have a truck");
                Console.WriteLine("it has 5 seats");
                Console.WriteLine("it has a truck bed");
                car.storage = new string[5];
                for(int i = 0; i < 5 ; i++)
                {
                    car.storage[i]="nothing";
                }

            }
        }

        static string getCarType(Car car)
        {
            Console.WriteLine(car.carType);
            return car.carType;
        }
        static void getStorage(Car car, string type)
        {
            if(type == "truck")
            {
                Console.WriteLine("this is a truck");
                Console.Write("in truck bed: ");
                for(int i = 0; i < 5 ; i++)
                {
                    if(i == 4)
                        Console.Write("{0} ",car.storage[i]);
                
                    else
                        Console.Write("{0}, ",car.storage[i]);
                }
                Console.WriteLine();
            }
            else if(type == "sedan")
            {
                Console.WriteLine("this is a truck");
                Console.Write("in car trunk: ");
                for(int i = 0; i < 3 ; i++)
                {
                    if(i == 2)
                        Console.Write("{0} ",car.storage[i]);
                
                    else
                        Console.Write("{0}, ",car.storage[i]);   
                }
                Console.WriteLine();
            }
        }
    }
}