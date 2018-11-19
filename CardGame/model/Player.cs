using System;
using System.Collections.Generic;

namespace CardGame.model
{
    public class Player
    {
        public string name;
        public List<Card> hand;

        public string SetPlayerName(string playerName)
        {
          return name = playerName;
        }
    }
}