using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Pilot
{
    internal class Lander
    {
        private string sprite_url = "";
        private uint fuel = 200000;
        private float angle = 0;
        private uint rocket_power = 0;
        private float[] speed = { 0, 0 };
        private float[] place = { 0, 0 };
        public void set_place(float[] place) { this.place = place; }
        public float[] get_place() { return place; }
        public float[] get_speed() { return speed; }
        public void set_speed(float[] speed) { this.speed = speed; }
       public void set_angle(float angle) { this.angle = angle; }
        public float get_angle() { return angle; }
        public uint get_rocket_power() { return rocket_power; }
        public void increment_rocket_power() { rocket_power = (rocket_power < 3) ? rocket_power + 1 : rocket_power;  }
        public void reset_rocket_power() { rocket_power = 0; }
        public uint get_fuel() { return fuel; }
        public bool decrease_fuel() { if (fuel > 0) { fuel -= 1; return true; } return false; }
    }
}
