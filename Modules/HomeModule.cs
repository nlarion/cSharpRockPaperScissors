using Nancy;
using System.Collections.Generic;
using System;
using System.Web;
using System.Linq;

namespace RockPaperScissors
{


  public class HomeModule : NancyModule
  {
    public HomeModule()
    {


      Get["/"] = _ => View ["index.cshtml"];
      Post["/"] = _ => {
        string player1 = Game.GetPlayer1();
        Game newGame = new Game(player1, Request.Form["player2"]);
        return View["index.cshtml", newGame.ReturnWinner()];
      };
      Post["/player2"] = _ => {
        Game newGame = new Game(Request.Form["player1"], "");
        return View["player2.cshtml"];
      };
    }
  }
}
