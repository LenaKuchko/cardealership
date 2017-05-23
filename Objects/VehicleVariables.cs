using System.Collections.Generic;


namespace VehicleVariables.Objects
{
  public class Vehicle
  {
    private static List<Car> _cars = new List<Car> {};
    public static List<Car> GetAll()
    {
      return _cars;
    }
    public static void Store(Car newCar)
    {
      _cars.Add(newCar);
    }

  }
}
