using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Replacement.Models;
using System;

namespace Replacement.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/replacement")]
    public ActionResult Check()
    {
      FindNReplace inputValues = new FindNReplace(Request.Form["inputSentence"], Request.Form["wordToFind"], Request.Form["replaceWord"]);
      string newSentece = inputValues.ToReplace();
      Console.WriteLine(newSentece);
      return View("Result", newSentece);
    }

  }
}
