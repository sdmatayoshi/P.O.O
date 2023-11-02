using Bullet_Theater.objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Bullet_Theater
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private SpriteFont debug_font;

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
            var enemyTexture = Content.Load<Texture2D>("img/characters/enemy1-template");
            var playerTexture = Content.Load<Texture2D>("img/characters/player-template");
            sprites = new List<Sprite>()
            {
                new Player(playerTexture)
                {
                    position = new Vector2(GraphicsDevice.Viewport.Width /2, GraphicsDevice.Viewport.Height-100),
                    Bullet = new Bullet(Content.Load<Texture2D>("img/bullets/bullet1")),
                },
                new Enemy1(enemyTexture)
                {
                    position = new Vector2(GraphicsDevice.Viewport.Width /2, 0),
                    E1Bullet = new E1Bullet(Content.Load<Texture2D>("img/bullets/bullet21")),
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
            foreach(var sprite in sprites)
                sprite.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
        
        
    }
}