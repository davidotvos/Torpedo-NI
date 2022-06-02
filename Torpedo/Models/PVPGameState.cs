using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo.Models
{
    public class PVPGameState : BindableBase
    {
        private Player _player1;
        private Player _player2;

        private int _rounds;

        public int Rounds
        {
            get { return _rounds; }
            set { SetProperty(ref _rounds, value); }
        }
        public Player Player1
        {
            get { return _player1; }
            set { SetProperty(ref _player1, value); }
        }

        public Player Player2
        {
            get { return _player2; }
            set { SetProperty(ref _player2, value); }
        }
    }
}
