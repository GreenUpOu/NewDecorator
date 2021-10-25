
namespace Decorator
{
    abstract class CardDecorator : Card
    {
        public Card card { get; private set; }
        public CardDecorator(string name, Card card) : base(name)
        {
            this.card = card;
        }
    }
}
