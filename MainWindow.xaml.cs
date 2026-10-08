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
            Key_codes key = new Key_codes();
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
            TEST.Content = player_ship.get_angle().ToString();
            
        }
    }
}