using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo.Models
{
    public class PVPGameState
    {
        private string _player1 { get; set; }
        private string _player2 { get; set; }

        private int[] _player1moves { get; set; }
        private int[] _player2moves { get; set; }

        private List<Tile> _player1board { get; set; }
        private List<Tile> _player2board { get; set; }

        private string _winner { get; set; }
        private int _round { get; set; }

        private int _player1hits { get; set; }
        private int _player2hits { get; set; }

        private List<Ship> _player1ships { get; set; }
        private List<Ship> _player2ships { get; set; }

        public void AddMove(int move)
        {

        }




    }
}
