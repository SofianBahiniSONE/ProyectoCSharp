using System;

namespace ConsoleGame
{
  class Program
  {
	static void Main(string[] args)
    {
      Random rand = new Random();
      Console.CursorVisible = false;

      int rows = Console.BufferHeight;
      int cols = Console.BufferWidth;
      char cursor = '<';
      int characterRow = rows / 2;
      int characterCol = cols / 2;
      char fruit = '@';
      int fruitRow = rand.Next(1, rows);
      int fruitCol = rand.Next(1, cols);
      int score = 0;

 
      while (true)
      {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.Write($"Score: {score}");
        Console.SetCursorPosition(characterCol, characterRow);
        Console.Write(cursor);
        Console.SetCursorPosition(fruitCol, fruitRow);
        Console.Write(fruit);

     
        ConsoleKeyInfo cki = Console.ReadKey(false);
        
      
        if (cki.Key == ConsoleKey.Q)
        {
          Console.Clear();
          Console.SetCursorPosition(0, 0);
          Console.CursorVisible = true;
          break; 
        }

        string key = cki.Key.ToString();
        int colChange = 0;
        int rowChange = 0;
        Game.UpdatePosition(key, out colChange, out rowChange);
        characterCol += colChange;
        characterRow += rowChange;

        cursor = Game.UpdateCursor(key);

        characterCol = Game.KeepInBounds(characterCol, cols);
        characterRow = Game.KeepInBounds(characterRow, rows);
      
        if (Game.DidScore(characterCol, characterRow, fruitCol, fruitRow))
        {
          score++;
          fruitCol = rand.Next(cols);
          fruitRow = rand.Next(rows);
        }
      }
    }
  }
}