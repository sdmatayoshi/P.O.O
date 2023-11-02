//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//using Microsoft.Xna.Framework.Input;

//namespace Bullet_Theater
//{
//    public class Game1 : Game
//    {
//        private GraphicsDeviceManager graphics;
//        private SpriteBatch spriteBatch;



//        private Player player;
//        public Game1()
//        {
//            graphics = new GraphicsDeviceManager(this);
//            Content.RootDirectory = "Content";
//            IsMouseVisible = true;
//        }

//        protected override void Initialize()
//        {

//            base.Initialize();
//        }

//        protected override void LoadContent()
//        {
//            spriteBatch = new SpriteBatch(GraphicsDevice);
//            var playerTexture = Content.Load<Texture2D>("img/characters/player-template");
//            player = new Player(playerTexture);
//            player.playerPosition = new Vector2(100, 100);
//        }

//        protected override void Update(GameTime gameTime)
//        {
//            player.Update();
//            base.Update(gameTime);
//        }

//        protected override void Draw(GameTime gameTime)
//        {
//            GraphicsDevice.Clear(Color.CornflowerBlue);

//            spriteBatch.Begin();

//            player.Draw(spriteBatch);

//            spriteBatch.End();


//            base.Draw(gameTime);
//        }
//    }
//}

using Bullet_Theater.objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Bullet_Theater
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private List<Sprite> sprites;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            var playerTexture = Content.Load<Texture2D>("img/characters/player-template");
            sprites = new List<Sprite>()
            {
                new Player(playerTexture)
                {
                    position = new Vector2(100, 100),
                    Bullet = new Bullet(Content.Load<Texture2D>("img/bullets/bullet1")),
                }
            };
        }
        protected override void Update(GameTime gameTime)
        {
            foreach (var sprite in sprites.ToArray())
                sprite.Update(gameTime, sprites);

            PostUpdate();

            base.Update(gameTime);
        }

        private void PostUpdate()
        {
            for (int i = 0; i < sprites.Count; i++)
            {
                if (sprites[i].isRemoved)
                {
                    sprites.RemoveAt(i);
                    i--;
                }
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            foreach (var sprite in sprites)
                sprite.Draw(spriteBatch);

            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}