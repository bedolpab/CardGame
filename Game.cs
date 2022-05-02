using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
  public class Game
  {
    public static  List<Card> Deck = new List<Card>();
    public static string[] Suits = { "Spades", "Clubs", "Hearts", "Diamonds" };
    public static int DeckSize = 52;

    public static void Start()
    {
      CreateDecks();
      ShowCards();
    }

    public static void CreateDecks()
    {
      for (int i = 1; i <= DeckSize / Suits.Length; i++)
      {
        for (int j = 0; j < Suits.Length; j++)
        {
          Deck.Add(new Card()
          {
            Value = i,
            Suit = Suits[j]
          }
        );
        }
      }
    }

    public static void ShowCards()
    {
      foreach (var card in Deck)
      {
        if (card.Value == 1 || card.Value >= 11 && card.Value <= 13)
        {
          Console.WriteLine("FACE Card: {0}, Deck: {1}", card.Value, card.Suit);
        }
        Console.WriteLine("Card: {0}, Deck: {1}", card.Value, card.Suit);
      }
    }

    public static void DrawRandomCard()
    {
      Random random = new Random();
      Console.WriteLine("Drawing a card . . .");
      int card = random.Next(Deck.Count);
      Console.WriteLine("Card: {0}, Deck: {1}", Deck[card].Value, Deck[card].Suit);
    }

    public static void RemoveCard()
    {
      Console.WriteLine("------REMOVING CARD------");
      Console.Write("Enter the card number (1-13): ");
      int card = Convert.ToInt32(Console.ReadLine());
      Deck.RemoveAt(card);
    }

  }
}


