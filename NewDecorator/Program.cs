using System;

namespace Decorator
{
    class Client
    {
        static void Main(string[] args)
        {
            Card some_card = new VisaCard();
            some_card = new PassportCard(some_card, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Name: {some_card.name}\nPassport data: {((PassportCard)some_card).data}");

            Card card2 = new SuperCard();
            card2 = new BankCard(card2, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Name: {card2.name}\nYour account: {((BankCard)card2).account}");

            card2 = new PassportCard(card2, Convert.ToInt32(Console.ReadLine()));
            Card visa = card2 as Card;
            Console.WriteLine($"Name: {visa.name}\nYour passport data: {((PassportCard)visa).data}");

            Console.ReadKey();
        }
    }
}
