using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
      [Route("/test")] //localhost:5000/test in browser
      public string Test() { return "Testing 1, 2, 3"; }

  }
}
