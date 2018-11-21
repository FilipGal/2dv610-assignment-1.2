public interface ICard<CardValue, CardRank>
{
  CardValue value { get; set; }
  CardRank rank { get; set; }
}