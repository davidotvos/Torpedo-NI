using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torpedo.Models;

namespace Torpedo.ViewModels
{
    public class MainWindowViewModel : BindableBase 
    {
        private List<Tile> _tiles = new List<Tile>();

        public MainWindowViewModel()
        {
            InitialiseGameTiles();
        }

        public List<Tile> Tiles
        {
            get { return _tiles; }
            set { SetProperty(ref _tiles, value); }
        }

        private void InitialiseGameTiles()
        {
            var tiles = new List<Tile>();
            var index = 0;

            for (var r = 0; r < 10; r++)
            {
                for (var c = 0; c < 10; c++)
                {
                    var tile = new Tile
                    {
                        Index = index,
                        Row = r,
                        Col = c
                    };
                    tiles.Add(tile);
                    index += 1;
                }
            }
            Tiles = tiles;
        }

    }
}
