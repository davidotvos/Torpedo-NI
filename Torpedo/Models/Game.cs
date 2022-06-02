using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo.Models
{
    public class Game
    {
        private List<Player> _players { get; set; }
        private int _rounds { get; set; }


        public static void saveGame(object obj, string filename)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented);

            File.WriteAllText(filename, jsonString);
        }
    }
}
