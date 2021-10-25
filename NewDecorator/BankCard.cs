
namespace Decorator
{
    class BankCard : CardDecorator
    {
        public int account { get; private set; }

        public BankCard(Card card, int account) : base(card.name + ", with bank card functions", card)
        {
            this.account = account;
        }
    }
}
