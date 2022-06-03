using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Torpedo.Models;

namespace Torpedo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Game g = createGame();
            Game.saveGame(g, "SaveGame");
            InitializeComponent();
        }

        private void OnEsc(object sender, RoutedEventArgs e)
        {

        }

        public Game createGame()
        {
            Game game = new Game();
            

            List<Tile> board = new List<Tile>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Tile t = new Tile();
                    t.Row = i;
                    t.Col = j;
                    t.Status = "Sea";
                    board.Add(t);
                }
            }

            List<Ship> ships = new List<Ship>();
            for(int i = 0; i < 10; i++)
            {
                Ship s = new Ship();
                s.Name = "Ship " + i;
                s.Length = i;
                ships.Add(s);
            }

            Player player1 = new Player();
            player1.Name = "David";
            player1.Moves = new List<int>() { 1, 2, 3, 4 };
            player1.Score = 5;
            player1.Hits = 6;
            player1.Board = board;
            player1.Ships = ships;
            
            Player player2 = new Player();
            player2.Name = "Rudo";
            player2.Moves = new List<int>() { 1, 2, 3, 4 };
            player2.Score = 2;
            player2.Hits = 9;
            player2.Board = board;
            player2.Ships = ships;

            game.Players = new List<Player>();
            game.Players.Add(player1);
            game.Players.Add(player2);
            game.Rounds = 10;

            return game;
        }
    }
}
