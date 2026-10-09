using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pilot
{
    class engine
    {
        private float gravity;
        public void relocate_ship(ref Lander lander)
        {
            float[] temp_place = lander.get_place();
            float[] tmep_speed = lander.get_speed();
            temp_place[(int)Coords.x] += lander.get_speed()[(int)Coords.x];
            temp_place[(int)Coords.y] += lander.get_speed()[(int)Coords.y];
        }
        public void set_lander_speed(Lander lander)
        {
            if(lander.get_rocket_power() > 0 && lander.decrease_fuel() == true) {
                float[] temp_speed = new float[2];
                temp_speed[0]= (float)(lander.get_rocket_power() * Math.Cos(Math.Abs(lander.get_angle())));
                temp_speed[1] = (float)(lander.get_rocket_power() * Math.Sin(Math.Abs(lander.get_angle())));
                if (temp_speed[0]!= 0 || temp_speed[1] != 0)
                {
                    if (lander.get_angle() < 0)
                        temp_speed[0] = -temp_speed[0];
                    temp_speed[0] += lander.get_speed()[0];
                    temp_speed[1] += lander.get_speed()[1];
                    lander.set_speed(temp_speed);
                }
            }
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
            if (wej == Key_codes.Up) lander.increment_rocket_power();
            set_lander_speed(lander);
        }

    }
}
