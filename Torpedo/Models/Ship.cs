using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo.Models
{
    public class Ship : BindableBase
    {
        private string _name = "";
        private int _length;
        private List<Tile> _tiles = new List<Tile>();


        public List<Tile> Tiles
        {
            get { return _tiles; }
            set { SetProperty(ref _tiles, value); }
        }

        public int Length
        { 
            get { return _length; } 
            set { SetProperty(ref _length, value); }
        }

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        
    }
}
