using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooterII
{
    internal class Player
    {
        public Texture2D texture;
        public int x = 0;
        public int y = 0;
        public int w = 50;
        public int h = 50;
        public int width;
        public int height;
        public int hp = 3;
        public int ammo = 7;
        public bool shoot = true;
        public Player() { }
        public Player(Texture2D texture, int x, int y) 
        { 
            this.texture = texture;
            this.x = x;
            this.y = y;
        }

        public void MovA()
        {
            if (x > 0) { x -= 10; }
        }
        public void MovD()
        {
            if (x < width - w) { x += 10; }
        }
        public void MovW()
        {
            if (y > 0) { y -= 10; }
        }
        public void MovS()
        {
            if (y < height - h) { y += 10; }
        }
    }
}
