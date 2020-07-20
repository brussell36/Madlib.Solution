using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }
    
    [Route("/madlibs")]
    public ActionResult MadLibMaker(string person1, string person2, string animal, string exclamation, string verb, string noun) {
      MadlibMaker myMadlibMaker = new MadlibMaker();
      myMadlibMaker.Person1 = person1;
      myMadlibMaker.Person2 = person2;
      myMadlibMaker.Animal = animal;
      myMadlibMaker.Exclamation = exclamation;
      myMadlibMaker.Verb = verb;
      myMadlibMaker.Noun = noun;
      return View(myMadlibMaker);  
    }
  }
}