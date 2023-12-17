using System;

namespace pro1
{
    public class Pro1
    {
        public static void Main(string[] args)
        {
            Pizza pizza=
            simpleFavcory.createpizza("2");
            pizza.prepare();
            pizza.done();
            pizza.cut();



        }
    }

    public interface Pizza {

        void prepare();

        void done();

        void cut();

    }

    public class simpleFavcory
    {
       static Pizza Pizza;
        public static Pizza createpizza(string inpi) {
            if (inpi == "2")
            {
                Pizza = new piz2();
            }
            else
            {
                Pizza = new piz3();

            }
            return Pizza;
        }
    }
    public class piz2 : Pizza
    {
        public void cut()
        {
            Console.WriteLine("p2 cut");
        }

        public void done()
        {
            Console.WriteLine("p2 done");
        }

        public void prepare()
        {
            Console.WriteLine("p2 prepare");
        }
    }
    public class piz3 : Pizza
    {
        public void cut()
        {
            Console.WriteLine("p3 cut");
        }

        public void done()
        {
            Console.WriteLine("p3 done");
        }

        public void prepare()
        {
            Console.WriteLine("p3 prepare");
        }
    }


}
