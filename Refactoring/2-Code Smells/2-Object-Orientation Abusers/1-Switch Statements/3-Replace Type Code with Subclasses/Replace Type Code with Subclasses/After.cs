using System;
using System.Collections.Generic;

namespace Replace_Type_Code_with_Subclasses
{
    public class After 
    {
        public void UseMethod()
        {
            List<Vehicle> vehicles = new()
            {
                new Car { Model = "پراید" },
                new Truck { Model = "کامیون ولوو" },
                new Motorcycle { Model = "هوندا" }
            };

            foreach (var v in vehicles)
            {
                Console.WriteLine($"{v.Model}: عوارض {v.GetTollPrice()} تومان, حداکثر سرعت {v.GetMaxSpeed()}");
            }

            // خروجی:
            // پراید: عوارض 5000 تومان, حداکثر سرعت 180
            // کامیون ولوو: عوارض 15000 تومان, حداکثر سرعت 100
            // هوندا: عوارض 2000 تومان, حداکثر سرعت 220
        }
    }
    public abstract class Vehicle
    {
        public string Model { get; set; }

        public abstract decimal GetTollPrice();
        public abstract int GetMaxSpeed();
    }

    public class Car : Vehicle
    {
        public override decimal GetTollPrice()
        {
            return 5000;
        }
        public override int GetMaxSpeed()
        {
            return 180;
        }
    }

    public class Truck : Vehicle
    {
        public override decimal GetTollPrice()
        {
            return 15000;
        }
        public override int GetMaxSpeed()
        {
            return 100;
        }
    }

    public class Motorcycle : Vehicle
    {
        public override decimal GetTollPrice()
        {
            return 2000;
        }
        public override int GetMaxSpeed()
        {
            return 220;
        }
    }

    
}
