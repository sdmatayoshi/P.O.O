﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpaceShooterII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooterII
{
    internal class Enemy
    {
        GraphicsDevice Screen;
        public Texture2D entexture;
        public int px = 200;
        public int py = 200;
        public int tw = 23;
        public int th = 13;
        public int spdx = 2;
        public int spdy = 1;
        public int spdz = 1;
        public Enemy(Texture2D entexture, int px, int py, int tw, int th, int spdx, int spdy, int spdz)
        {
            this.entexture = entexture;
            this.px = px;
            this.py = py;
            this.tw = tw;
            this.th = th;
            this.spdx = spdx;
            this.spdy = spdy;
            this.spdz = spdz;
        }

        public void Mov1()
        {
            if (px >= (Screen.Viewport.Width / 2) + 50)
            {
                px += spdx; tw += spdz; th += spdz;
            }
            if (px < (Screen.Viewport.Width / 2) - 50)
            {
                px -= spdx; th += spdz; th += spdz;
            }
            if (py >= Screen.Viewport.Height / 2)
            {
                py += spdy; tw += spdz; th += spdz;
            }
            if (py < Screen.Viewport.Height / 2)
            {
                py -= spdy; tw += spdz; th += spdz;
            }
        }
    }
}
