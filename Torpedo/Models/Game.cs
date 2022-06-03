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
            set { SetProperty(ref _players, value); }
        }

        public int Rounds
        {
            get { return _rounds; }
            set { SetProperty(ref _rounds, value); }
        }
        
        public static void saveGame(object obj, string filename)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented);

            Trace.WriteLine(jsonString);
        }


        // Ki nyerte a játékot
        public static Player WhoWon(Game g)
        {
            if(!IsGameOver(g))
            {
                return null;
            }

            if (DidPlayerLost(g.Players[0]))
            {
                return g.Players[1];
            }
            else
            {
                return g.Players[0];
            }
        }


        // Vége-e a játéknak
        public static bool IsGameOver(Game g)
        {
            var p1 = g.Players[0];
            var p2 = g.Players[1];

            if(DidPlayerLost(p1) == true || DidPlayerLost(p2) == true)
            {
                return true;
            }

            return false;
        }


        public static string Fire(Player Current, Player Enemy, int idx)
        {
            string result = "Miss";
            // Loop a ship listán
            foreach (Ship s in Enemy.Ships)
            {
                // Loop az enemy ship tilejain
                foreach (Tile t in s.Tiles)
                {
                    // Ha talált a lövés
                    if (Tile.getIndex(t).Equals(idx))
                    {
                        t.Status = "Hit";
                        result = "Hit";
                        Current.Score += 10;
                        Current.Hits += 1;

                        // Ha talált-süllyedt
                        if (DidShipSink(s))
                        {
                            SinkShip(s);
                            result = "Sunk";
                            Current.Score += 30;
                        }
                    }

                    // Visszatér Hit-el vagy Sunk-al
                    return result;
                }
            }

            // Ellenkező esetben Miss-el
            return result;
        }


        // Megnézi hogy egy hajó összes Tile-ja talált-e
        private static bool DidShipSink(Ship s)
        {
            foreach(Tile t in s.Tiles)
            {
                if(t.Status != "Hit")
                {
                    return false;
                }
            }
            return true;
        }


        // Elsüllyeszti a hajót
        public static void SinkShip(Ship s)
        {
            foreach(Tile t in s.Tiles)
            {
                t.Status = "Sunk";
            }
        }


        public static bool CheckIfShipsCollide(Ship one, Ship two)
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


        public static bool CheckIfTileIsShip(Ship s, Tile t)
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


        // Ha elsüllyedt az összes hajója egy játékosnak veszített
        public static bool DidPlayerLost(Player p)
        {
            var ships = p.Ships;

            foreach (Ship s in ships)
            {
                if (!DidShipSink(s))
                {
                    return false;
                }
            }

            return true;
        }
        
    }
}
