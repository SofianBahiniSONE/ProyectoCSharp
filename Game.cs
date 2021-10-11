using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string keyPressed,out int x,out int y)
    {
    x = 0;
    y = 0;
    switch (keyPressed)
    {
    case "LeftArrow":
    x--;
    break;
    case "RightArrow":
    x++;
    break;
    case "UpArrow":
    y--;
    break;
    case "DownArrow":
    y++;
    break;
    
    default:
    Console.WriteLine("wrong key pressed");
    break;
    }
   }
    
    public new static char UpdateCursor (string keyPressed)
    {
    switch (keyPressed)
    {
    case "LeftArrow":
    return '<';
    
    case "RightArrow":
    return '>';
    
    case "UpArrow":
    return '^';
  
    case "DownArrow":
    return 'v';
    
    default:
    return 'X';
    }
    }
    
    public new static int KeepInBounds(int coordinate, int maxValue)
    {
    
    if (coordinate > maxValue)
    {
    return 0;
    }
    else if (coordinate < 0)
    {
    return maxValue;
    }
    else
    {
    return coordinate;
    }
    
    }
    
    public new static bool DidScore(int x, int y, int fx, int fy)
    {
    if ((x == fx) && (y ==fy))
    {
    return true;
    }
    else
    return false;
    
    }
    
  }
}