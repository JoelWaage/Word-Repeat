using Nancy;
using System.Collections.Generic;
using WordRepeat;

namespace WordRepeat
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/result"] = _ => {
        Repeat newRepeat = new Repeat(Request.Query["input-word"], Request.Query["input-sentence"]);

        return View["result.cshtml", newRepeat];
      };
    }
  }
}
