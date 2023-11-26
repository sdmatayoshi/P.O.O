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

        GraphicsDevice Screen;
        public Texture2D texture;
        public int x = 200;
        public int y = 200;
        public int w = 500;
        public int h = 500;
        public int spdx = 1;
        public int spdy = 1;
        public int spdz = 1;
        public int width;
        public int height;
        public Pbullet(Texture2D texture, int px, int py, int tw, int th, int spdx, int spdy, int spdz, int width, int height)
        {
            this.texture = texture;
            this.x = px;
            this.y = py;
            this.w = tw;
            this.h = th;
            this.spdx = spdx;
            this.spdy = spdy;
            this.spdz = spdz;
            this.width = width;
            this.height = height;
        }
        public void Mov(Player cursor)
        {
            if (x > cursor.x) { x += spdx; w -= spdz; h -= spdz; }
            if (y > cursor.y) { y += spdy; w -= spdz; h -= spdz; }
            if (y < cursor.y) { y -= spdy; w -= spdz; h -= spdz; }
            if (x < cursor.x) { x -= spdx; w -= spdz; h -= spdz; }
            if (x == cursor.x) { w -= spdz; h -= spdz; }
            if (y == cursor.y) { w -= spdz; h -= spdz; }
        }







        

        
    }
}
