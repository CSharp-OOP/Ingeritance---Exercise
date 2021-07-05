using System;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal DefaultCoffeePrice = 3.50m;
        private const double DefaultCoffeeMilliliters = 50;
        public double Caffeine { get; set; }
        public Coffee(string name, double caffeine)
            : base(name, DefaultCoffeePrice, DefaultCoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
    }
}
