using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pilot
{
    class engine
    {
        private float gravity;
        public void relocate_ship(ref Lander lander) {
            float[] temp_place = lander.get_place();
            float[] tmep_speed = lander.get_speed();
            temp_place[(int)Coords.x] += lander.get_speed()[(int)Coords.x];
            temp_place[(int)Coords.y] += lander.get_speed()[(int)Coords.y];
        }
        public void set_lander_controls(Key_codes wej, Lander lander)
        {
            if (lander.get_angle() < 90 && wej == Key_codes.Right)
            {
                lander.set_angle(lander.get_angle() + 2);
            }
            else if (lander.get_angle() > -90 && wej == Key_codes.Left)
            {
                lander.set_angle(lander.get_angle() - 2);
            }
            if (wej == Key_codes.Up) lander.increment_rocket_power(); else lander.reset_rocket_power();
        }
    }
}
