using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class CardType
    {
        public Card card;
        private string cardType; // damage or heal or update 

        public CardType()
        {
            card = new Card();
        }

        public CardType(string cardType, string cardName, int cardDamage, int cardID, string description, string imageLink)
        {
            this.cardType = cardType;
            card = new Card(cardName, cardDamage, cardID, description, imageLink);
        }

        // Свойства для удобства доступа
        public string CardTypeName => cardType;
        public Card Card => card;

        // Десериализация JSON в объект
        [JsonConstructor]
        public CardType(string cardType, Card card)
        {
            this.cardType = cardType;
            this.card = card;
        }

        public string GetType() { 
            return this.cardType;
        }
    }

}
