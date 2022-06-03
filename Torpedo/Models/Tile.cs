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
        private int _row;
        private int _col;

        // Tile státusza pl: Sea, Ship, Hit, Sunk
        private string _status = "Sea";

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

        public static int CellWidth { get { return 33; } }

        public static int CellHeight { get { return 29; } }
>>>>>>> Rudidev


<<<<<<< HEAD
        public static int getIndex(Tile t)
        {
            return t.Row * 10 + t.Col;
        }
=======
>>>>>>> Rudidev
    }
}
