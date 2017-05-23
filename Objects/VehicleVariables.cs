using System.Collections.Generic;


namespace VehicleVariables.Objects
{
  public class Vehicle
  {
    private static Dictionary<string, object> carValues = new Dictionary<string, object>();

    public static Dictionary<string, object> GetDictionary()
    {
      return carValues;
    }
    public static void SaveToDict(Car newCar)
    {
      if(newCar.GetPrice()>50000)
      {
        carValues.Add("Premier", newCar);
      }
      else
      {
        carValues.Add("Normal", newCar);
      }
    }
  }
}
