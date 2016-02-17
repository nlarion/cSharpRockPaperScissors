using System;
// using System.Linq;
using System.Collections.Generic;

namespace RockPaperScissors

{

//   //variables//
//
  public class Game
  {
    private string _player1;
    private string _player2;


//construtor//
    public Game (string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;

    }
    public string GetPlayer1()
    {
      return _player1;
    }
    public string GetPlayer2()
    {
      return _player2;
    }

    public string ReturnWinner()
    {
      if (this.GetPlayer1() == this.GetPlayer2())
      {
        return "Draw";
      }
      else if (this.GetPlayer1() == "Rock")
      {
        if (this.GetPlayer2() == "Paper")
        {
          return "Player 2";
        }
        else
        {
          return "Player 1";
        }
      }
      else if (this.GetPlayer1() == "Paper")
      {
        if (this.GetPlayer2() == "Scissors")
        {
          return "Player 2";
        }
        else
        {
          return "Player 1";
        }
      }
      else
      {
        if (this.GetPlayer2() == "Rock")
        {
          return "Player 2";
        }
        else 
        {
          return "Player 1";
        }
      }
    }
  }
}
