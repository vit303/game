using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "D:\\cs_projects\\game\\game\\cardsDatabase.json"; // Укажите путь к вашему JSON файлу
            MainDeck cardDeck = new MainDeck();
            cardDeck.LoadDeck(jsonFilePath);
            
            Console.WriteLine(cardDeck.cards[0].GetType());
        }
    }
}
