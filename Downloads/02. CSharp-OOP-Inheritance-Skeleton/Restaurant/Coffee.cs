using System;
namespace Restaurant {
	public class Coffee : HotBeverage {
		public double CoffeeMilliliters;
		public decimal CoffeePrice;
		public double Caffeine;
		public Coffee (string name, decimal price, double milliliters, double caffeine) : base (name, price, milliliters)
		{
			this.CoffeeMilliliters = 50;
			this.CoffeePrice = 3.50m;
			this.Caffeine = caffeine;
		}
	}
}
