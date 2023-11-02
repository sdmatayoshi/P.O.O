using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullet_Theater.objects
{
    public class E1Bullet : Sprite
    {
        //private float timer;
        public float speed =4f;
        public E1Bullet(Texture2D texture)
            :base(texture)
        {
        }
        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            //timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            //if (timer > LifeSpan)
            //{
            //    isRemoved = true;

            //    position += direction * linearVelocity;
            //}

            if (position.Y < 700)
            {
                position.Y += speed;
            }
            if (position.Y >= 700)
            {
                isRemoved = true;
            }
        }
    }
}
