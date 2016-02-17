// using Nancy;
// using System.Collections.Generic;
// using System;
// using System.Linq;
// 
// namespace RockPaperScissors
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//       Get["/"] = _ => View ["index.cshtml"];
//
//       Post["/"] = _ => {
//       Coin newCoin = new Coin(Request.Form["input"]);
//       Dictionary<string,int> returnList = newCoin.GetChange();
//       return View["index.cshtml", returnList];
//       };
//     }
//   }
// }
