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
        private int _index;
        private int _row;
        private int _col;
        private bool _isSea;
        private bool _isHit;
        private bool _isSunk;


    }
}
