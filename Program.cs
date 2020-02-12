using System;
using System.Collections.Generic;

namespace Deck_Shuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      //Welcome user to the game 
      Console.WriteLine("Welcome to the game!");

      //Identify variables
      var fullDeck = new List<string>();
      var deckSuit = new List<string>() { "Hearts", "Diamonds", "Spades", "Clubs" };
      var deckFace = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
      var card = "";
      //Creating deck
      for (var i = 0; i < deckSuit.Count; i++)
      {

        for (var j = 0; j < deckFace.Count; j++)
        {
          card = ($"{deckFace[j]} of {deckSuit[i]}");
          fullDeck.Add(card);
        }
      }
      //Shuffling the deck 

      Random rnd = new Random();

      //for i from n - 1 down to 1 do:
      for (int i = 52 - 1; i >= 1; i--)
      {
        //j = random integer (where 0 <= j <= i)
        int j = rnd.Next(i);
        //swap fullDeck[i] with fullDeck[j]
        var temp = fullDeck[j];
        fullDeck[j] = fullDeck[i];
        fullDeck[i] = temp;

      }

      Console.WriteLine(fullDeck[0]);



      var k = 1;

      while (true)
      {



        Console.WriteLine("Would you like to pull another card?");
        var input = Console.ReadLine();
        if (input == "yes")
        {
          Console.WriteLine(fullDeck[k]);
          k++;
        }
        else
        {
          break;
        }
      }













    }
  }
}



