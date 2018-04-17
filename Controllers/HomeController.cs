using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;


namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [Route("/test")] //localhost:5000/test in browser
    public string Test() { return "Testing 1, 2, 3"; }

    [HttpGet("/car")]
    public ActionResult Index()
    {
        List<Car> allCars = Car.GetAll();
        return View(allCars);
    }

    [HttpGet("/car/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [HttpPost("/car")]
    public ActionResult Create()
    {
      Car newCar = new Car (Request.Form["brand"], Request.Form["model"], int.Parse(Request.Form["year"]), int.Parse(Request.Form["mileage"]));
      newCar.Save();
      List<Car> allCars = Car.GetAll();
      return View("Index", allCars);
    }

    [HttpPost("/car/delete")]
    public ActionResult DeleteAll()
    {
        Car.ClearAll();
        return View();
    }


  }
}
