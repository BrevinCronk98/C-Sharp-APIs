using Microsoft.AspNetCore.Mvc;

namespace TravelApi.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}