
namespace Decorator
{
    class PassportCard : CardDecorator
    {
        public int data { get; private set; }
        public PassportCard(Card card, int data) : base(card.name + ", with passport data", card)
        {
            this.data = data;
        }
    }
}
