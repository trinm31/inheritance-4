using System;
namespace Restaurant {
	public class Beverage : Product {
		public double Milliliters;
		public Beverage (string name, decimal price, double milliliters) : base (name, price)
		{
			this.Milliliters = milliliters;
		}
	}
}
