using Nancy;
using System.Collections.Generic;
using VehicleVariables.Objects;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Car> allCars = Vehicle.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Get["/add_car"] = _ => {
        return View["add_car.cshtml"];
      };
      Post["/"] = _ => {
        Car newCar = new Car (Request.Form["make-model"], Request.Form["color"], Request.Form["miles"], Request.Form["price"]);
        Vehicle.Store(newCar);
        return View["add_car.cshtml"];
      };
    }
  }
}
