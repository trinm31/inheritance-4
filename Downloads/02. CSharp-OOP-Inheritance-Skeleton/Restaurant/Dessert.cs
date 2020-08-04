using System;
namespace Restaurant {
	public class Dessert : Food {
		public double Calories;

		public Dessert (string name, decimal price, double grams, double calories) : base (name, price, grams)
		{
			this.Calories = calories;
		}
	}
}
