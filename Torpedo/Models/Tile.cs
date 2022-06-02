using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;


namespace Torpedo.Models
{

    public class Tile : BindableBase
    {
        // Tile koordináták
        private int _index;
        private int _row;
        private int _col;

        // Tile státusza pl: Sea, Ship, Hit, Sunk
        private string _status = "Sea";

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

        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }
<<<<<<< HEAD
       
=======

        public bool IsHit
        {
            get { return _isHit; }
            set { SetProperty(ref _isHit, value); }
        }

        public bool IsSunk
        {
            get { return _isSunk; }
            set { SetProperty(ref _isSunk, value); }
        }

        public static int CellSize { get { return 20; } }

        

>>>>>>> c3a4b30e52e373870e39a39e0bf2eeaec2e7e308
    }
}
