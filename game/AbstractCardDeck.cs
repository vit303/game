using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace game
{
    abstract class AbstractCardDeck
    {
        public List<CardType> cards = new List<CardType>();
        public void ReadFromJson(string link)
        {
            try
            {
                // Считываем содержимое JSON файла
                string jsonContent = File.ReadAllText(link);

                // Десериализуем JSON в список CardType
                cards = JsonConvert.DeserializeObject<List<CardType>>(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка чтения из файла: {ex.Message}");
            }
        }
    }
}
