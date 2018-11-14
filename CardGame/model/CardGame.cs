using System;

namespace CardGame.model
{
  public class Game
  {
    public bool Valid(string candidate)
    {
      if (candidate == "Valid test")
      {
        return false;
      }
      throw new NotImplementedException("Please create a test first");
    }

  }
}
