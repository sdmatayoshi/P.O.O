using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpaceShooterII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
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
        public int spdx = 1;
        public int spdy = 1;
        public int spdz = 1;
        public int delay = 0;
        public int width;
        public int height;
        public Rectangle rectangle;
        public Enemy(Texture2D entexture, int px, int py, int tw, int th, int spdx, int spdy, int spdz, int width, int height)
        {
            this.entexture = entexture;
            this.px = px;
            this.py = py;
            this.tw = tw;
            this.th = th;
            this.spdx = spdx;
            this.spdy = spdy;
            this.spdz = spdz;
            this.width = width;
            this.height = height;
        }

        public void Mov1()
        {
            if (px > (width/2-entexture.Width/2) - tw/2)
            {
                px += spdx; tw += spdz; th += spdz;
            }
            if (px < (width / 2 - entexture.Width / 2) - tw / 2)
            {
                px -= spdx; tw += spdz; th += spdz;
            }
            if (px == (width / 2 - entexture.Width / 2) - tw / 2)
            {
                tw += spdz; th += spdz;
            }
            if (py > height / 2 - entexture.Height / 2 - th / 2)
            {
                py += spdy; tw += spdz; th += spdz;
            }
            if (py < height / 2 - entexture.Height / 2 - th / 2)
            {
                py -= spdy; tw += spdz; th += spdz;
            }
            if (py == height / 2 - entexture.Height / 2 - th / 2)
            {
                tw += spdz; th += spdz;
            }
        }

        public void Mov2()
        {
            if (px > (width / 2 - entexture.Width / 2) - tw / 2)
            {
                px += spdx; tw += spdz; th += spdz;
                if (tw==75)
                {
                    spdz+=1;
                }
            }
            if (px < (width / 2 - entexture.Width / 2) - tw / 2)
            {
                px -= spdx; tw += spdz; th += spdz;
                if (tw == 75)
                {
                    spdz += 1;
                }
            }
            if (px == (width / 2 - entexture.Width / 2) - tw / 2)
            {
                tw += spdz; th += spdz;
                if (tw == 75)
                {
                    spdz += 1;
                }
            }
            if (py > height / 2 - entexture.Height / 2 - th / 2)
            {
                py += spdy; tw += spdz; th += spdz;
                if (tw == 75)
                {
                    spdz += 1;
                }
            }
            if (py < height / 2 - entexture.Height / 2 - th / 2)
            {
                py -= spdy; tw += spdz; th += spdz;
                if (tw == 75)
                {
                    spdz += 1;
                }
            }
            if (py == height / 2 - entexture.Height / 2 - th / 2)
            {
                tw += spdz; th += spdz;
                if (tw == 75)
                {
                    spdz += 1;
                }
            }
        }
    }
}
