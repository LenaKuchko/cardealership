using System.Collections.Generic;

namespace VehicleVariables.Objects
{
  public class Car
  {

    private string _makeModel;
    private string _color;
    private int _miles;
    private int _price;
    private int _id;
    private static List<Car> _cars = new List<Car> {};

    public Car(string makeModel, string color, int miles, int price)
    {
      _makeModel = makeModel;
      _color = color;
      _miles = miles;
      _price = price;
      _cars.Add(this);
      _id = _cars.Count;
    }

    public static List<Car> GetAll()
    {
      return _cars;
    }
    public int GetId ()
    {
      return _id;
    }

    public void SetMakeModel (string makeModel)
    {
      _makeModel = makeModel;
    }
    public string GetMakeModel ()
    {
      return _makeModel;
    }
    public void SetColor (string color)
    {
      _color = color;
    }
    public string GetColor ()
    {
      return _color;
    }
    public void SetMiles (int miles)
    {
      _miles = miles;
    }
    public int GetMiles ()
    {
      return _miles;
    }
    public void SetPrice (int price)
    {
      _price = price;
    }
    public int GetPrice ()
    {
      return _price;
    }

    public bool IsPremier()
    {
      if(this._price>50000)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static Car Search(int carId)
    {
      return _cars[carId - 1];
    }
    public void Remove()
    {
      _cars.Remove(this);
    }
  }
}
