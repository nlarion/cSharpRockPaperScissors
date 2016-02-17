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
        string player2;
        if (Request.Form["player2"] == "Random")
        {
          player2 = Game.GetAI();
        }
        else
        {
          player2 = Request.Form["player2"];
        }
        Game newGame = new Game(player1, player2);
        return View["index.cshtml", newGame.ReturnWinner()];
      };
      Post["/player2"] = _ => {
        Game newGame = new Game(Request.Form["player1"], "");
        return View["player2.cshtml"];
      };

    }
  }
}
