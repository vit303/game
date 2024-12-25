using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Card
    {
        private string cardName; // race
        private int cardDamage;
        private int cardID;
        private string description;
        private string imageLink;

        public Card() { }

        public Card(string cardName, int cardDamage, int cardID, string description, string imageLink)
        {
            this.cardName = cardName;
            this.cardDamage = cardDamage;
            this.cardID = cardID;
            this.description = description;
            this.imageLink = imageLink;
        }

        public string GetCardName() { 
            return cardName;
        }
        public int GetCardDamage() {  return cardDamage; }
        public int GetCardID() {  return cardID; }
        public string GetCardDescription() { 
            return description;
        }
        public string GetImageLink() {  return imageLink;}
    }
}
