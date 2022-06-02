using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo.Models
{
    public class Player : BindableBase
    {
        private string _name;
        private List<int> _moves;
        private List<Tile> _board;
        private int _score;
        private int _hits;
        private List<Ship> _ships;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public List<int> Moves
        {
            get { return _moves; }
            set { SetProperty(ref _moves, value); }
        }

        public List<Tile> Boards 
        { 
            get { return _board; }
            set { SetProperty(ref _board, value); }
        }

        public int Score
        {
            get { return _score; }
            set { SetProperty(ref _score, value); }
        }

        public int Hits
        {
            get { return _hits; }
            set { SetProperty(ref _hits, value); }
        }

        public List<Ship> Ships
        {
            get { return _ships; }
            set { SetProperty(ref _ships, value); }
        }

        public bool AddMove(int move)
        {
            if(move < 0 || move > 100)
            {
                return false;
            }

            _moves.Add(move);
            return true;
        }
    }
}
