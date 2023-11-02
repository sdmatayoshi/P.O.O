using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullet_Theater.objects
{
    internal class Enemy1 : Sprite
    {
        public E1Bullet E1Bullet;
        private int ecooldown = 0;
        public int E1HP = 50;
        public Enemy1(Texture2D texture)
            : base(texture)
        {
        }
        public float speed = 3f;
        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            if (position.Y< 50)
                position.Y += speed;

            
            if (position.X > 0)
                position.X -= speed;
            if (ecooldown>30)
            {
                AddE1Bullet(sprites);
                ecooldown = 0;
            }
            if (E1HP<=0||position.X <= 0)
            {
                isRemoved = true;
            }
            ecooldown++;
        }
        private void AddE1Bullet(List<Sprite> sprites)
        {
            var e1bullet = E1Bullet.Clone() as E1Bullet;
            e1bullet.direction = this.direction;
            e1bullet.position.X = this.position.X + 0;
            e1bullet.position.Y = this.position.Y + 0;
            e1bullet.linearVelocity = this.linearVelocity * 2;
            e1bullet.LifeSpan = 2f;
            e1bullet.Parent = this;

            sprites.Add(e1bullet);
        }
    }
}

