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
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Get["/add_car"] = _ => {
        return View["add_car.cshtml"];
      };
      Post["/"] = _ => {
        Car newCar = new Car (Request.Form["make-model"], Request.Form["color"], Request.Form["miles"], Request.Form["price"]);
        Vehicle.SaveToDict(newCar);
        // Vehicle.Store(newCar);
        return View["add_car.cshtml"];
      };
      Get["/car_values"] = _ => {
        Dictionary<string, object> carDictionary = Vehicle.GetDictionary();
        return View[ "view_car_types.cshtml", carDictionary];
      };
      Get["/car_search"] = _ => {
        Car carResult = Car.Search(Request.Query["search-id"]);
        return View[ "car_search_results.cshtml", carResult];
      };
      Get["/cars/{id}"] = parameters => {
        Car car = Car.Search(parameters.id);
        return View["/car.cshtml", car];
      };
      Post["/cars/{id}"] = parameters => {
        Car car = Car.Search(parameters.id);
        car.Remove();
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
    }
  }
}
