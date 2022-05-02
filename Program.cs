using System;

namespace CardGame
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cards = { "Card 1", "Card 2", "Card 3", "Card 4", "Card 5", "Card 6", "Card 7", "Card 8", "Card 9", "Card 10", "Card 11", "Card 12", "Card 13" };
      Random random = new Random();

      ShowCard();
      Shuffle();
      ShowCard();


     void ShowCard()
      {
        for (int i = 0; i < cards.Length; i++)
        {
          Console.WriteLine(cards[i]);
        }
        Console.WriteLine("---------");
      }


      void Shuffle()
      {
        for (int i = 0; i < cards.Length; i++)
        {
          int index1 = random.Next(cards.Length); // 2

          if (cards[i] != cards[index1])
          {
            string temp = cards[i];
            cards[i] = cards[index1];
            cards[index1] = temp;
          }

        }
      }
    }
  }
}
