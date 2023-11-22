using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooterII
{
    internal class Pbullet
    {
        public Texture2D texture;
        public int x = 0;
        public int y = 0;
        public int tw = 500;
        public int th = 500;
        public bool visible = false;
        int spd = 5;

        public Pbullet() { }
        public Pbullet(Texture2D texture) 
        { 
            this.texture = texture;
        }
        public void Mov(Player player)
        {
            if (visible == true)
            {
                if (x > player.x)
                {
                    x -= spd-3; tw -= spd; th -= spd;
                }
                if (x < player.x)
                {
                    x += spd-3; tw -= spd; th -= spd;
                }
                if (y > player.x)
                {
                    y -= spd-3; tw -= spd; th -= spd;
                }
                if (y < player.x)
                {
                    y += spd-3; tw -= spd; th -= spd;
                }
            }
            else
            {
                x = player.x;
                y = player.y;
            }
        }
    }
}
