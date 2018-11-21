using System.Collections.Generic;
using CardGame.model;

public interface IPlayer
{
  string name { get; set; }
  List<Card> hand { get; set; }
}