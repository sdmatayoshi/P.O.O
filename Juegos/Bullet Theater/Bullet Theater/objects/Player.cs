//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//using Microsoft.Xna.Framework.Input;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bullet_Theater
//{
//    public class Player
//    {
//        private Texture2D playerTexture;
//        public Vector2 playerPosition;

//        public float speed = 2f;
//        public Player(Texture2D playerTexture)
//        {
//            this.playerTexture = playerTexture;
//        }
//        public void Update()
//        {
//            if (Keyboard.GetState().IsKeyDown(Keys.A))
//            {
//                playerPosition.X -= speed;
//            }
//            if (Keyboard.GetState().IsKeyDown(Keys.D))
//            {
//                playerPosition.X += speed;
//            }
//            if (Keyboard.GetState().IsKeyDown(Keys.W))
//            {
//                playerPosition.Y -= speed;
//            }
//            if (Keyboard.GetState().IsKeyDown(Keys.S))
//            {
//                playerPosition.Y += speed;
//            }
//        }
//        public void Draw(SpriteBatch spriteBatch)
//        {
//            spriteBatch.Draw(playerTexture, playerPosition, Color.White);
//        }

//    }
//}


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
        public Player(Texture2D texture)
            :base(texture)
        {

        }
        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            previousKey = currentKey;
            currentKey = Keyboard.GetState();

            if (currentKey.IsKeyDown(Keys.A))
                rotation -= MathHelper.ToRadians(rotationVelocity);
            else if (currentKey.IsKeyDown(Keys.D))
                rotation += MathHelper.ToRadians(rotationVelocity);
            direction = new Vector2((float)Math.Cos(rotation), (float)Math.Sin(rotation));

            if(currentKey.IsKeyDown(Keys.W))
                position += direction*rotationVelocity;

            if(currentKey.IsKeyDown(Keys.Space) && previousKey.IsKeyDown(Keys.Space))
            {
                AddBullet(sprites);
            }
        }

        private void AddBullet(List<Sprite> sprites)
        {
            var bullet = Bullet.Clone() as Bullet;
            bullet.direction = this.direction;
            bullet.position = this.position;
            
            if (!isRemoved)
            {
                bullet.position = new Vector2(bullet.position.X, bullet.position.Y+10);
            }
            bullet.LifeSpan = 2f;
            bullet.Parent = this;
            sprites.Add(bullet);
        }
    }
}

