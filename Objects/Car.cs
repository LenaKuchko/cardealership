namespace VehicleVariables.Objects
{
  public class Car
  {
    private string _makeModel;
    private string _color;
    private int _miles;
    private int _price;

    public Car(string makeModel, string color, int miles, int price)
    {
      _makeModel = makeModel;
      _color = color;
      _miles = miles;
      _price = price;
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
  }
}
