using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo.Models
{
    public class Player
    {
        private string _name { get; set; }
        private int[] _moves { get; set; }
        private List<Tile> _board { get; set; }
        private int _score { get; set; }
        private int _hits { get; set; }
        private List<Ship> _ships { get; set; }
    }
}
