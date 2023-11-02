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
    public class Sprite : ICloneable
    {
        protected Texture2D texture;
        protected float rotation;
        protected KeyboardState currentKey;
        protected KeyboardState previousKey;

        public Vector2 position;
        public Vector2 origin;

        public Vector2 direction;
        public float rotationVelocity = 3f;
        public float linearVelocity = 4f;

        public Sprite Parent;

        public float LifeSpan = 0f;

        public bool isRemoved = false;

        public Sprite(Texture2D texture)
        {
            this.texture = texture;
            origin = new Vector2(texture.Width / 2, texture.Height / 2);
        }
        public virtual void Update(GameTime gameTime, List<Sprite> sprites)
        {

        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, null, Color.White, rotation, origin, 1, SpriteEffects.None, 0);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
