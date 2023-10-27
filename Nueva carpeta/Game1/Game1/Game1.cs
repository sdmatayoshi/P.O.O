using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Security;
using System.Text.RegularExpressions;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D pointerTexture;
        private Vector2 pointerPosition;

        private Texture2D health1Texture;
        private Vector2 health1Position;
        private Texture2D health2Texture;
        private Vector2 health2Position;
        private Texture2D health3Texture;
        private Vector2 health3Position;

        private Texture2D pointerhitboxTexture;
        private Vector2 pointerhitboxPosition;
        private Texture2D enemyTexture;
        private Vector2 enemyPosition;
        private Texture2D explosionTexture;
        private Vector2 explosionPosition;

        private SpriteFont debug_font;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }
        bool shoot = false; bool isalive1 = true; int en1px = 200; int en1py = 200; int en1tw = 23; int en1th = 13;bool hit = false;int life = 3; int hptw = 25; int hpth = 25;
        bool revive1 = false; int revive1time = 10; bool revive1reset = false;
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            pointerTexture = Content.Load<Texture2D>("resources/img/cross-pointer");
            pointerPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - pointerTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - pointerTexture.Height / 2);

            health1Texture = Content.Load<Texture2D>("resources/img/health");
            health1Position = new Vector2(0, 0);
            health2Texture = Content.Load<Texture2D>("resources/img/health");
            health2Position = new Vector2(50, 0);
            health3Texture = Content.Load<Texture2D>("resources/img/health");
            health3Position = new Vector2(100, 0);


            pointerhitboxTexture = Content.Load<Texture2D>("resources/img/point-hitbox");
            pointerhitboxPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - pointerTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - pointerTexture.Height / 2);
            enemyTexture = Content.Load<Texture2D>("resources/img/enemy1");
            enemyPosition = new Vector2(en1px, en1py);
            //GraphicsDevice.Viewport.Width / 2 - pointerTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - pointerTexture.Height / 2
            explosionTexture = Content.Load<Texture2D>("resources/img/explosion");
            explosionPosition = new Vector2(en1px, en1py);

            debug_font = Content.Load<SpriteFont>("resources/debug");
        }
        
        protected override void Update(GameTime gameTime)
        {
/*----------------------------------------------------------------------------------Hitboxes---------------------------------------------------------------------------------*/
            Rectangle pointerRectangle = new Rectangle((int)pointerPosition.X+20, (int)pointerPosition.Y+20, pointerTexture.Width-40, pointerTexture.Height-40);
            Rectangle enemyRectangle = new Rectangle((int)en1px, (int)en1py, en1tw, en1th);
/*--------------------------------------------------------------------------------Hitboxes-End-------------------------------------------------------------------------------*/
/*--------------------------------------------------------------------------------Player-Moves-------------------------------------------------------------------------------*/
            if (Keyboard.GetState().IsKeyDown(Keys.W)){pointerPosition.Y -= 10;}if (Keyboard.GetState().IsKeyDown(Keys.S)){pointerPosition.Y += 10;}
            if (Keyboard.GetState().IsKeyDown(Keys.A)){pointerPosition.X -= 10;}if (Keyboard.GetState().IsKeyDown(Keys.D)){pointerPosition.X += 10;}
/*------------------------------------------------------------------------------Player-Moves-End------------------------------------------------------------------------------*/
/*-------------------------------------------------------------------------------Player-Attack--------------------------------------------------------------------------------*/
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(enemyRectangle)){shoot = true;}else{shoot = false;}
/*------------------------------------------------------------------------------Player-Attack-End-----------------------------------------------------------------------------*/
/*--------------------------------------------------------------------------------Enemy-Moves---------------------------------------------------------------------------------*/
            if (en1px >= (GraphicsDevice.Viewport.Width / 2) && isalive1)
            {en1px += 2;en1tw += 1;en1th += 1;
            enemyRectangle.X += en1px;enemyRectangle.Width += en1tw;enemyRectangle.Height += en1th;
            explosionPosition = new Vector2(enemyPosition.X, enemyPosition.Y);}

            if (en1px < (GraphicsDevice.Viewport.Width / 2) && isalive1)
            {en1px -= 2;en1tw += 1;en1th += 1;
            enemyRectangle.X += en1px;enemyRectangle.Width += en1tw;enemyRectangle.Height += en1th;
            explosionPosition = new Vector2(enemyPosition.X, enemyPosition.Y);}
            if (en1py >= (GraphicsDevice.Viewport.Height / 2) && isalive1)
            {en1py += 2;en1tw += 1;en1th += 1;
            enemyRectangle.Y += en1py;enemyRectangle.Width += en1tw;enemyRectangle.Height += en1th;
            explosionPosition = new Vector2(enemyPosition.X, enemyPosition.Y);}
            if (en1py < (GraphicsDevice.Viewport.Height / 2) && isalive1)
            {en1py -= 2;en1tw += 1;en1th += 1;
            enemyRectangle.Y += en1py;enemyRectangle.Width += en1tw;enemyRectangle.Height += en1th;
            explosionPosition = new Vector2(enemyPosition.X, enemyPosition.Y);}
/*------------------------------------------------------------------------------Enemy-Moves-End-------------------------------------------------------------------------------*/
            if (shoot)
            {
                if (isalive1)
                {
                    explosionTexture = Content.Load<Texture2D>("resources/img/explosion");
                }
              
                enemyTexture = Content.Load<Texture2D>("resources/img/void");
                isalive1 = false;
                revive1time = 0;
            }
            else
            {
                explosionTexture = Content.Load<Texture2D>("resources/img/void");
            }



/*---------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            if (en1tw > 233 && en1tw > 223)
            {
                isalive1 = false;
                en1tw = 0;
                en1th = 0;
                life--;
                revive1time = 0;
            }
            if (revive1time==20)
            {
                revive1 = true;
            }
            if (revive1)
            {
                var rand = new Random();
                int posx = rand.Next(200, 500);
                int posy = rand.Next(100, 300);
                en1tw = 23;
                en1th = 13;
                en1px = posx;
                en1py = posy;
                enemyTexture = Content.Load<Texture2D>("resources/img/enemy1");
                isalive1 = true;
                revive1 = false;
            }
            

            revive1time++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
                GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            if (isalive1)
            {
                spriteBatch.Draw(enemyTexture, new Rectangle(en1px, en1py, en1tw, en1th), Color.White);
            }
            
            spriteBatch.Draw(explosionTexture, new Rectangle(en1px, en1py, en1tw, en1th), Color.White);
            if (life == 3)
            {
            spriteBatch.Draw(health3Texture, new Rectangle(65, 5, hptw, hpth), Color.White);
            spriteBatch.Draw(health2Texture, new Rectangle(35, 5, hptw, hpth), Color.White);
            spriteBatch.Draw(health1Texture, new Rectangle(5, 5, hptw, hpth), Color.White);
            }
            else if (life == 2)
            {
            spriteBatch.Draw(health2Texture, new Rectangle(35, 5, hptw, hpth), Color.White);
            spriteBatch.Draw(health1Texture, new Rectangle(5, 5, hptw, hpth), Color.White);
            }
            else if (life == 1)
            {
            spriteBatch.Draw(health1Texture, new Rectangle(5, 5, hptw, hpth), Color.White);
            }
            spriteBatch.DrawString(debug_font, "revive1time: " + revive1time, new Vector2(0, 10), Color.White);
            spriteBatch.DrawString(debug_font, "hp: " + life, new Vector2(0, 20), Color.White);
            spriteBatch.Draw(pointerTexture, pointerPosition, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}