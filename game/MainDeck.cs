using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class MainDeck: AbstractCardDeck
    {
        public void LoadDeck(string jsonFilePath)
        {
            ReadFromJson(jsonFilePath);
        }

    }
}
