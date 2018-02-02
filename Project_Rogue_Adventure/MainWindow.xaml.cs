using System;
using System.Collections.Generic;
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

namespace Project_Rogue_Adventure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GameLoop game = new GameLoop();
            game.GameStart();
            
        }
    }

    public class GameLoop
    {

        Character Player = new Character();

        public void GameStart()
        {
            string Menu_Option = String.Empty;
            Console.WriteLine("Test Game Intro Message!!!!");
            Console.WriteLine("Do You Have A Character To Load? Yes or No");
            Menu_Option = Console.ReadLine();

            if (Menu_Option == "Yes" || Menu_Option == "yes")
            {
                Player.CharacterLoad();
            }
            else if (Menu_Option == "No" || Menu_Option == "no")
            {
                Player.CharacterCreation();
                Console.WriteLine("Welcome " + Player.name);
            }
        }

    }
}
