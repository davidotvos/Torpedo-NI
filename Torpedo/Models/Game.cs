using Newtonsoft.Json;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Torpedo.Models
{
    public class Game : BindableBase
    {
        private List<Player> _players = new List<Player>();
        private int _rounds { get; set; }

        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }


        
    }
}
