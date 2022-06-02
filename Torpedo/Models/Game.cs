using Newtonsoft.Json;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo.Models
{
    public class Game : BindableBase
    {
        private List<Player> _players;
        private int _rounds = 0;

        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        public int Rounds
        {
            get { return _rounds; }
            set { _rounds = value; }
        }


        public static void saveGame(object obj, string filename)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented);

            Trace.WriteLine(jsonString);
        }

        public static string Fire(Player Current, Player Enemy, int idx)
        {
            
        }

        public static bool checkIfShipsCollide(Ship one, Ship two)
        {
            foreach (Tile t in one.Tiles)
            {
                foreach (Tile k in two.Tiles)
                {
                    if (Tile.getIndex(t).Equals(Tile.getIndex(k)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkIfTileIsShip(Ship s, Tile t)
        {
            foreach(Tile temp in s.Tiles)
            {
                if (Tile.getIndex(t).Equals(Tile.getIndex(temp)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
