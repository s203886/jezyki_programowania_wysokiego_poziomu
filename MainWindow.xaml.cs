using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pilot
{
    public partial class MainWindow : Window
    {
        Lander player_ship = new Lander();
        engine main_engine = new engine();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Key_codes key = Key_codes.Other;
            switch (e.Key)
            {
                case Key.Up:
                    key = Key_codes.Up;
                    break;
                case Key.Down:
                    key = Key_codes.Down;
                    break;
                case Key.Left:
                    key = Key_codes.Left;
                    break;
                case Key.Right:
                    key = Key_codes.Right;
                    break;
            }
            main_engine.set_lander_controls(key, player_ship);
            TEST.Content = player_ship.get_angle().ToString() + ":" + player_ship.get_rocket_power() + ":" + player_ship.get_speed()[0] + ":" + player_ship.get_speed()[1] + ":" + player_ship.get_fuel();
            
        }

        private void Main_window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up) player_ship.reset_rocket_power();
            TEST.Content = player_ship.get_angle().ToString() + ":" + player_ship.get_rocket_power() +  ":" + player_ship.get_speed()[0] + ":" + player_ship.get_speed()[1]+ ":" + player_ship.get_fuel();
        }
    }
}