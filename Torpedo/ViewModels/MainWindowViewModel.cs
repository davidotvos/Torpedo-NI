using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torpedo.Models;
using System.Diagnostics;

namespace Torpedo.ViewModels
{
    public class MainWindowViewModel : BindableBase 
    {
        private List<Tile> _tiles;


        public List<Tile> Tiles
        {
            get { return _tiles; }
            set { SetProperty(ref _tiles, value); }
        }

       
    }
}
