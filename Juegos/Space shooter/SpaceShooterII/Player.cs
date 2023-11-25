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
        public int spd = 10;
        public int width;
        public int height;
        public int hp = 7;
        public int ammo = 7;
        public bool shoot = true;
        public Player() { }
    }
}
