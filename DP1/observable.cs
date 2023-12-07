using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ISubject 
  {
    void registerObserver(IObserver o);
    void unregisterObserver(IObserver o);
    void notifyLessegner () { }
  }

public interface IObserver {

    void update( double humidity, double temperature , double pressure);
}

public class DataWetherd : ISubject
{
    private List<IObserver> listeners = new List<IObserver>();

    private double humidity;
    private double temperature;
    private double pressure;

    public void registerObserver(IObserver o)
    {
        listeners.Add(o);
    }

    public void unregisterObserver(IObserver o)
    {
        listeners.Remove(o);
    }
    public void notifyLesseners ()
    {
        foreach(IObserver o in listeners)
        {
            o.update(humidity, temperature, pressure);
        }
    }

    public void getMeasurment(double temperature, double pressure,double humidity)
    {
        this.temperature = temperature;
        this.pressure = pressure;
        this.humidity = humidity;
        notifyLesseners();
    }
}

public class firistObservable : IObserver
{
    double humidity, temperature, pressure;
    DataWetherd DataWetherd;
    public firistObservable(DataWetherd dataWetherd) 
    {
     this.DataWetherd = dataWetherd;
     dataWetherd.registerObserver(this);
    }
    public void update(double humidity, double temperature, double pressure)
    {
        this.humidity = humidity;
        this.temperature = temperature;
        this.pressure = pressure;
    }
    public void display()
    {
        Console.WriteLine(humidity + temperature + pressure);
    }
}