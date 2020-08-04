using System;
namespace NeedForSpeed
{
    public class Vehicle
    {
        public int HorsePower;
        public double Fuel;
        public double DefaultFuelConsumption;
        public double FuelConsumption;

        public Vehicle(int horsePower, double fuel )
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.DefaultFuelConsumption = 1.25;
        }
       
        public double LitPerHour()
        {
            return (Fuel * HorsePower) / DefaultFuelConsumption;
        }
        public virtual string Drive(double kilometers)
        {
            return $" Fuel consumption of type: {this.GetType().Name} is: {(double)kilometers/LitPerHour()}";
        }
    }
}
