internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        Horse horse = new Horse();
        Bus bus = new Bus();


        List<Vehicle> vehicleList = new List<Vehicle>();
      //  vehicleList.Add(horse);
        vehicleList.Add(car);
        vehicleList.Add(bus);

        for (int i = 0; i < vehicleList.Count; i++)
        {
            vehicleList[i].Move();
        }

    }
}

public interface IMovable
{
   void Move();
}


public abstract class Vehicle : IMovable
{
    public abstract void Move();
}

public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

public class Bus : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bus is moving");
    }
}

public class Horse : IMovable
{
    public void Move()
    {
        Console.WriteLine("Horse is moving");
    }
}

public class Aiecraft : IMovable
{
    public void Move()
    {
        Console.WriteLine("AirCraft is moving");
    }
}
