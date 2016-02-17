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
        newGame.SetPlayer2(Request.Form["player2"]);
        return View["index.cshtml", newGame.ReturnWinner()];
      };
      Post["/player2"] = _ => {
      Game newGame = new Game(Request.Form["player1"], "");
      return View["player2.cshtml", newGame];
      };
    }
  }
}
