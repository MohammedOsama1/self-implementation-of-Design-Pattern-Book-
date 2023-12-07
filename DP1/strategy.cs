namespace zoik
{
    class Problem1
    {
    
    }
}

/***********-***-***-***-***-***-***-***-***-***-***-***-***-***/

public interface IFlyable
{
    void PerformFly();
}

public interface IQuakeable
{
    void PerformQuake();
}

public class ICanFly : IFlyable
{
    public void PerformFly()
    {
        Console.WriteLine("Ican fly");
    }
}

public class ICanQuake : IQuakeable
{
    public void PerformQuake()
    {
        Console.WriteLine("Ican Quake");
    }

}
public abstract class Duck
{
    public IQuakeable quake;
    public IFlyable fly;

    public void doQuake ()
    {
        quake.PerformQuake();
    }
    public void doFly () {
        fly.PerformFly();
    }
}

public class fighDuck : Duck
{
    public fighDuck()
    {
        quake = new ICanQuake();
        fly = new ICanFly();
    }
}