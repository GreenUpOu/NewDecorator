
namespace Decorator
{
    abstract class Card
    {
        public string name { get; protected set; }
        public Card(string name)
        {
            this.name = name;
        }
        
    }
}
