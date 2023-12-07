using System;

namespace DP1
{
    public class dd
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.cost());
        }
    }

    public abstract class Beverage
    {
        public string description = "Nothing";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public abstract string getDescription();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.5;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend coffee";
        }

        public override double cost()
        {
            return 0.5645;
        }
    }

    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beveraged)
        {
            this.beverage = beveraged;
        }

        public override double cost()
        {
            return beverage.cost() + 1.01; // Assuming you meant to add 1.01 instead of 101
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
    }
}
