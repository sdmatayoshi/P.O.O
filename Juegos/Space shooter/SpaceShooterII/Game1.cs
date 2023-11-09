using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace SpaceShooterII
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        List<Enemy> enemies;
        List<Rectangle> enemiesrectangles;
        private Texture2D enemyTexture;
        private Vector2 enemyPosition;
        DateTime timew;
        DateTime tiempoactual;
        TimeSpan tiempo;

        //playes beta
        private Texture2D pointerTexture;
        private Vector2 pointerPosition;

        //debug keys
        private Texture2D keyboardTexture;
        private Vector2 keyboardPosition;
        private Texture2D akeyTexture;
        private Vector2 akeyPosition;
        private Texture2D skeyTexture;
        private Vector2 skeyPosition;
        private Texture2D dkeyTexture;
        private Vector2 dkeyPosition;
        private Texture2D wkeyTexture;
        private Vector2 wkeyPosition;
        private Texture2D keyboardspcTexture;
        private Vector2 keyboardspcPosition;
        private Texture2D spacekeyTexture;
        private Vector2 spacekeyPosition;

        //menu
        private Texture2D resumebtnTexture;
        private Vector2 resumebtnPosition;
        private Texture2D menubtnTexture;
        private Vector2 menubtnPosition;
        private Texture2D exitbtnTexture;
        private Vector2 exitbtnPosition;
        private Texture2D playbtnTexture;
        private Vector2 playbtnPosition;

        //debug font
        private SpriteFont debug_font;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            //_graphics.IsFullScreen = true;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            base.Initialize();
        }
        bool space = false; bool a = false; bool s = false; bool d = false; bool w = false; bool bossanim = false; bool pause = false; bool menu = true; bool debug = false; int debugdelay = 0; int del = 0;

        Random rnd1 = new Random();
        Random rnd2 = new Random();
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _spriteBatch = new SpriteBatch(GraphicsDevice);
            enemies = new List<Enemy>();
            enemyTexture = Content.Load<Texture2D>("resources/img/enemy11");



            pointerTexture = Content.Load<Texture2D>("resources/img/cross-pointer");
            pointerPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - pointerTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - pointerTexture.Height / 2);


            keyboardTexture = Content.Load<Texture2D>("resources/img/wasd");
            akeyTexture = Content.Load<Texture2D>("resources/img/a");
            skeyTexture = Content.Load<Texture2D>("resources/img/s");
            dkeyTexture = Content.Load<Texture2D>("resources/img/d");
            wkeyTexture = Content.Load<Texture2D>("resources/img/w");
            keyboardspcTexture = Content.Load<Texture2D>("resources/img/space");
            spacekeyTexture = Content.Load<Texture2D>("resources/img/spacepress");
            keyboardPosition = new Vector2(GraphicsDevice.Viewport.Width - keyboardTexture.Width, GraphicsDevice.Viewport.Height - keyboardTexture.Height);



            resumebtnTexture = Content.Load<Texture2D>("resources/img/resume");
            resumebtnPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - resumebtnTexture.Width / 2, GraphicsDevice.Viewport.Height - 200);
            menubtnTexture = Content.Load<Texture2D>("resources/img/menu");
            menubtnPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - menubtnTexture.Width / 2, GraphicsDevice.Viewport.Height - 150);
            playbtnTexture = Content.Load<Texture2D>("resources/img/play");
            playbtnPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - playbtnTexture.Width / 2, GraphicsDevice.Viewport.Height - 100);
            exitbtnTexture = Content.Load<Texture2D>("resources/img/menu");
            exitbtnPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - exitbtnTexture.Width / 2, GraphicsDevice.Viewport.Height - 50);


            debug_font = Content.Load<SpriteFont>("resources/debug");
        }

        protected override void Update(GameTime gameTime)
        {
            Rectangle resumebtnRectangle = new Rectangle((int)resumebtnPosition.X, (int)resumebtnPosition.Y, resumebtnTexture.Width, resumebtnTexture.Height);
            Rectangle menubtnRectangle = new Rectangle((int)menubtnPosition.X, (int)menubtnPosition.Y, menubtnTexture.Width, menubtnTexture.Height);
            Rectangle playbtnRectangle = new Rectangle((int)playbtnPosition.X, (int)playbtnPosition.Y, playbtnTexture.Width, playbtnTexture.Height);
            Rectangle exitbtnRectangle = new Rectangle((int)exitbtnPosition.X, (int)exitbtnPosition.Y, exitbtnTexture.Width, exitbtnTexture.Height);
            Rectangle pointerRectangle = new Rectangle((int)pointerPosition.X + 20, (int)pointerPosition.Y + 20, pointerTexture.Width - 40, pointerTexture.Height - 40);
            if (Keyboard.GetState().IsKeyDown(Keys.W) && pointerPosition.Y > 0) { pointerPosition.Y -= 10; }
            if (Keyboard.GetState().IsKeyDown(Keys.S) && pointerPosition.Y < GraphicsDevice.Viewport.Height - 48) { pointerPosition.Y += 10; }
            if (Keyboard.GetState().IsKeyDown(Keys.A) && pointerPosition.X > 0) { pointerPosition.X -= 10; }
            if (Keyboard.GetState().IsKeyDown(Keys.D) && pointerPosition.X < GraphicsDevice.Viewport.Width - 48) { pointerPosition.X += 10; }

            if (pointerRectangle.Intersects(playbtnRectangle) && menu) { playbtnTexture = Content.Load<Texture2D>("resources/img/playb"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { menu = false; pause = false; } } else { playbtnTexture = Content.Load<Texture2D>("resources/img/play"); }
            if (pointerRectangle.Intersects(exitbtnRectangle) && menu) { exitbtnTexture = Content.Load<Texture2D>("resources/img/exitb"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { Exit(); } } else { exitbtnTexture = Content.Load<Texture2D>("resources/img/exit"); }

            if (Keyboard.GetState().IsKeyDown(Keys.Escape) && !pause) { pause = true; }
            if (pointerRectangle.Intersects(resumebtnRectangle) && pause) { resumebtnTexture = Content.Load<Texture2D>("resources/img/resumeb"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { pause = false;} } else { resumebtnTexture = Content.Load<Texture2D>("resources/img/resume"); }
            if (pointerRectangle.Intersects(menubtnRectangle) && pause) { menubtnTexture = Content.Load<Texture2D>("resources/img/menub"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) {menu=true;del=0;pause=false;} } else { menubtnTexture = Content.Load<Texture2D>("resources/img/menu"); }

            if (a) { akeyTexture = Content.Load<Texture2D>("resources/img/a"); }
            else { akeyTexture = Content.Load<Texture2D>("resources/img/void"); }
            if (s) { skeyTexture = Content.Load<Texture2D>("resources/img/s"); }
            else { skeyTexture = Content.Load<Texture2D>("resources/img/void"); }
            if (d) { dkeyTexture = Content.Load<Texture2D>("resources/img/d"); }
            else { dkeyTexture = Content.Load<Texture2D>("resources/img/void"); }
            if (w) { wkeyTexture = Content.Load<Texture2D>("resources/img/w"); }
            else { wkeyTexture = Content.Load<Texture2D>("resources/img/void"); }
            if (space) { spacekeyTexture = Content.Load<Texture2D>("resources/img/spacepress"); }
            else { spacekeyTexture = Content.Load<Texture2D>("resources/img/void"); }
            if (Keyboard.GetState().IsKeyDown(Keys.F3) && !debug && debugdelay > 7) { debug = true; debugdelay = 0; } else if (Keyboard.GetState().IsKeyDown(Keys.F3) && debug && debugdelay > 7) { debug = false; debugdelay = 0; }
            if (Keyboard.GetState().IsKeyDown(Keys.Space)) { space = true; } else { space = false; }
            if (Keyboard.GetState().IsKeyDown(Keys.A)) { a = true; } else { a = false; }
            if (Keyboard.GetState().IsKeyDown(Keys.S)) { s = true; } else { s = false; }
            if (Keyboard.GetState().IsKeyDown(Keys.D)) { d = true; } else { d = false; }
            if (Keyboard.GetState().IsKeyDown(Keys.W)) { w = true; } else { w = false; }



            
            if (!pause && !menu)
            {
                tiempoactual = DateTime.Now;
                tiempo = tiempoactual - timew;

                if (tiempo.Seconds >= 2)
                {
                    int originx = rnd1.Next(250, 500);
                    int originy = rnd1.Next(200, 400);
                    enemies.Add(new Enemy(enemyTexture, originx,originy, 23, 13, 2, 1, 1, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height));
                    timew = DateTime.Now;
                }

                for (int i = 0; i < enemies.Count; i++)
                {
                    if (enemies[i].tw > 200)
                    {
                        enemies.RemoveAt(i);
                    }
                }
            }

            del++;
            debugdelay++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            if (!pause && !menu)
            {
                foreach (Enemy e in enemies)
                {
                    _spriteBatch.Draw(e.entexture, new Rectangle(e.px,e.py,e.tw,e.th) , Color.White);
                    
                }
            }
            foreach (Enemy e in enemies)
            {
                e.Mov1();

            }

            if (debug)
            {
                _spriteBatch.DrawString(debug_font, "Player: ", new Vector2(10, 30), Color.White);
                _spriteBatch.DrawString(debug_font, "X: " + pointerPosition.X, new Vector2(10, 50), Color.White);
                _spriteBatch.DrawString(debug_font, "Y: " + pointerPosition.Y, new Vector2(10, 70), Color.White);

                _spriteBatch.Draw(keyboardTexture, keyboardPosition, Color.White);
                _spriteBatch.Draw(akeyTexture, akeyPosition, Color.White);
                _spriteBatch.Draw(skeyTexture, skeyPosition, Color.White);
                _spriteBatch.Draw(dkeyTexture, dkeyPosition, Color.White);
                _spriteBatch.Draw(wkeyTexture, wkeyPosition, Color.White);
                _spriteBatch.Draw(keyboardspcTexture, keyboardspcPosition, Color.White);
                _spriteBatch.Draw(spacekeyTexture, spacekeyPosition, Color.White);
            }
            if (pause){ 
                _spriteBatch.Draw(resumebtnTexture, resumebtnPosition, Color.White); 
                _spriteBatch.Draw(menubtnTexture, menubtnPosition, Color.White); 
            }
            else if (menu){
                _spriteBatch.Draw(playbtnTexture, playbtnPosition, Color.White); 
                _spriteBatch.Draw(exitbtnTexture, exitbtnPosition, Color.White);
            }
            _spriteBatch.Draw(pointerTexture, pointerPosition, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}