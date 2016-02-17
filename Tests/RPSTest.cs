using Xunit;
using System;
// using System.Linq;
using System.Collections.Generic;
namespace  RockPaperScissors
{
  public class RPSTest
  {
    [Fact]
    public void TestRockPaperScissorReturnWinner()
    {
      Game newGame = new Game("Rock","Scissors");
      Assert.Equal("Player 1", newGame.ReturnWinner());
    }
    [Fact]
    public void ReturnWinner_RockVsPaper_true()
    {
      Game newGame = new Game("Rock","Paper");
      Assert.Equal("Player 2", newGame.ReturnWinner());
    }
    [Fact]
    public void ReturnWinner_RockVsRock_true()
    {
      Game newGame = new Game("Rock","Rock");
      Assert.Equal("Draw", newGame.ReturnWinner());
    }
    [Fact]
    public void ReturnWinner_ScissorsVsPaper_true()
    {
      Game newGame = new Game("Scissors","Paper");
      Assert.Equal("Player 1", newGame.ReturnWinner());
    }
    [Fact]
    public void ReturnWinner_ScissorsVsRock_true()
    {
      Game newGame = new Game("Scissors","Rock");
      Assert.Equal("Player 2", newGame.ReturnWinner());
    }
    [Fact]
    public void ReturnWinner_ScissorsVsScissors_true()
    {
      Game newGame = new Game("Scissors","Scissors");
      Assert.Equal("Draw", newGame.ReturnWinner());
    }
    [Fact]
    public void ReturnWinner_PaperVsScissors_true()
    {
      Game newGame = new Game("Paper","Scissors");
      Assert.Equal("Player 2", newGame.ReturnWinner());
    }
    [Fact]
    public void ReturnWinner_PaperVsRock_true()
    {
      Game newGame = new Game("Paper","Rock");
      Assert.Equal("Player 1", newGame.ReturnWinner());
    }
    [Fact]
    public void ReturnWinner_PaperVsPaper_true()
    {
      Game newGame = new Game("Paper","Paper");
      Assert.Equal("Draw", newGame.ReturnWinner());
    }

    // [Fact]
    // public void TestGetChange()
    // {
    //   Coin newCoins = new Coin(1.80);
    //   Dictionary<string,int> testResults = new Dictionary<string,int>();
    //   testResults.Add("Quarters", 7);
    //   testResults.Add("Dimes", 0);
    //   testResults.Add("Nickels", 1);
    //   testResults.Add("Pennies", 0);
    //   Assert.Equal(testResults, newCoins.GetChange());
    // }

  }
}
