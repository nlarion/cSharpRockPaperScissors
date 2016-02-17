using Nancy;
using System.Collections.Generic;
using System;
using System.Linq;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];
      Post["/"] = _ => {
        Game newGame = new Game(HttpContext.Current.Session["Player1Status"], Request.Form["player2"]);
        return View["index.cshtml", newGame.ReturnWinner()];
      };
      Post["/player2"] = _ => {
      HttpContext.Current.Session["Player1Status"] = Request.Form["player1"];
      return View["player2.cshtml"];
      };
    }
  }
}
