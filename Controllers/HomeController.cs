using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System;

namespace Parcel.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
      {
        Console.WriteLine("Reaches Index");
        return View();
      }
      [Route("/form")]
      public ActionResult Form()
      {
        return View();
      }
      [Route("/output")]
      public ActionResult Output()
      {
        // string myHeightString = Request.Query["height"];
        // int myHeight = int.Parse(myHeightString);
        // string myWeightString = Request.Query["weight"];
        // int myWeight = int.Parse(myWeightString);
        // string myWidthString = Request.Query["width"];
        // int myWidth = int.Parse(myWidthString);
        // string myLengthString = Request.Query["length"];
        // int myLength = int.Parse(myLengthString);

        ParcelVariable newParcel = new ParcelVariable();
        newParcel.SetHeight(int.Parse(Request.Query["height"]));
        newParcel.SetWeight(int.Parse(Request.Query["weight"]));
        newParcel.SetWidth(int.Parse(Request.Query["width"]));
        newParcel.SetLength(int.Parse(Request.Query["length"]));
        // Console.WriteLine(newParcel.GetHeight());
        // Console.WriteLine(newParcel.GetWidth());
        // Console.WriteLine(newParcel.GetLength());
        // Console.WriteLine(newParcel.GetWeight());
        return View(newParcel);
      }
    }
}
