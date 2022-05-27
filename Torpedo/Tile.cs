using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;


namespace Torpedo
{
    public class Tile : BindableBase
    {
        // Tábla koordináták
        private int _index;
        private int _row;
        private int _col;

        // Üres Cella
        private bool _isSea;

        // Hajók állapotához
        private bool _isHit;
        private bool _isSunk;


        public int Index
        {
            get { return _index; }
            set { SetProperty(ref _index, value); }
        }

        public int Row 
        {
            get { return _row; } 
            set { SetProperty(ref _row, value); } 
        }

        public int Col
        {
            get { return _col; }
            set { SetProperty(ref _col, value); }
        }

    }
}
