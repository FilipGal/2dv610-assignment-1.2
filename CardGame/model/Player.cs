using System;

namespace CardGame.model
{
    public class Player
    {
        public string name;

        public string SetPlayerName(string playerName)
        {
          return name = playerName;
        }
    }
}