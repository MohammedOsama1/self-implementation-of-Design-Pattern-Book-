namespace zoik
{
    class Problem1
    {
        public static void Main(string[] args)
        {
            Duck duck = new FightedDucke();
            duck.perFormFly();
            duck.perFormQuacke();
        }
    }
}

/**************************************************/

public interface IFlyable {
    void Fly();
}
public interface IQuakeable {
    void Quake();

}

public class FlyRocket : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("FlyRocket Bw BW");
    }
}
public class FlyWings : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("FlyWings wnn");
    }
}
public class NotFling : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("fuck cant fly");
    }
}

public class RabberQuake : IQuakeable
{
    public void Quake()
    {
        Console.WriteLine(" RabberQuake ");
    }
}
public class Saykak : IQuakeable
{
    public void Quake()
    {
        Console.WriteLine(" Saykak ");

    }
}
public class NotQuake : IQuakeable
{
    public void Quake()
    {
        Console.WriteLine("Fuck cant Quake");
    }
}
public abstract class Duck
{
    public IQuakeable quake { get; set; }
    public IFlyable flyable { get; set; }

    public void perFormQuacke () {
        quake.Quake();
    }
    public void perFormFly() { 
        flyable.Fly();
    }

   
}
public class FightedDucke : Duck
{
    public  FightedDucke()
    {
        quake = new Saykak ();
        flyable = new FlyRocket ();
    }
}