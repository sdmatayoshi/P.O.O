using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullet_Theater.objects
{
    public class Player : Sprite
    {
        public Bullet Bullet;
        private int cooldown;
        public Player(Texture2D texture)
            :base(texture)
        {

        }
        public float speed = 3f;
        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            previousKey = currentKey;
            currentKey = Keyboard.GetState();

            //if (currentKey.IsKeyDown(Keys.A))
            //    rotation -= MathHelper.ToRadians(rotationVelocity);
            //else if (currentKey.IsKeyDown(Keys.D))
            //    rotation += MathHelper.ToRadians(rotationVelocity);
            //direction = new Vector2((float)Math.Cos(rotation), (float)Math.Sin(rotation));

            //if(currentKey.IsKeyDown(Keys.W))
            //    position += direction*rotationVelocity;

            //if(currentKey.IsKeyDown(Keys.Space) && previousKey.IsKeyDown(Keys.Space))
            //{
            //    AddBullet(sprites);
            //}

            if (currentKey.IsKeyDown(Keys.A))
                position.X-=speed;
            else if (currentKey.IsKeyDown(Keys.D))
                position.X+= speed;
            if (currentKey.IsKeyDown(Keys.W))
                position.Y -= speed;
            else if (currentKey.IsKeyDown(Keys.S))
                position.Y += speed;

            if (currentKey.IsKeyDown(Keys.Space) && previousKey.IsKeyDown(Keys.Space) && cooldown>3)
            {
                AddBullet(sprites);
                cooldown = 0;
            }
            cooldown++;
        }

        private void AddBullet(List<Sprite> sprites)
        {
            var bullet = Bullet.Clone() as Bullet;
            bullet.direction = this.direction;
            bullet.position.X = this.position.X+0;
            bullet.position.Y = this.position.Y+0;
            bullet.linearVelocity = this.linearVelocity * 2;
            bullet.LifeSpan = 2f;
            bullet.Parent = this;

            sprites.Add(bullet);
        }
    }
}

