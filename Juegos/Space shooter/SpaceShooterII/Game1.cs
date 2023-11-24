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
        List<Enemy> enemies2;
        List<Enemy> enemies3;
        List<Enemy> enemies4;
        List<Rectangle> enemiesrectangles;
        List<Rectangle> enemies2rectangles;
        List<Rectangle> enemies3rectangles;
        List<Rectangle> enemies4rectangles;
        private Texture2D enemyTexture;
        private Texture2D enemy2Texture;
        private Texture2D enemy3Texture;
        private Texture2D enemy4Texture;
        
        DateTime tiempoactual;
        DateTime timew;
        DateTime timew2;
        DateTime timew3;
        DateTime timew4;
        TimeSpan tiempo;
        TimeSpan tiempo2;
        TimeSpan tiempo3;
        TimeSpan tiempo4;

        //player
        Player cursor;
        Rectangle cursorR;

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
        bool level1  =true;
        bool level2 = true;
        bool level3 = true;
        bool level4 = false;
        int en1movdel; int en2movdel; int en3movdel; int en4movdel; int enbmovdel;

        Random rnd1 = new Random();
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _spriteBatch = new SpriteBatch(GraphicsDevice);

            enemies = new List<Enemy>();
            enemies2 = new List<Enemy>();
            enemies3 = new List<Enemy>();
            enemies4 = new List<Enemy>();
            
            enemiesrectangles = new List<Rectangle>();
            enemies2rectangles = new List<Rectangle>();
            enemies3rectangles = new List<Rectangle>();
            enemies4rectangles = new List<Rectangle>();

            enemyTexture = Content.Load<Texture2D>("resources/img/enemy11");
            enemy2Texture = Content.Load<Texture2D>("resources/img/enemy21");
            enemy3Texture = Content.Load<Texture2D>("resources/img/enemy31");
            enemy4Texture = Content.Load<Texture2D>("resources/img/enemy41");

            cursor = new Player();
            cursor.texture = Content.Load<Texture2D>("resources/img/cross-pointer");

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
            if (cursorR.Intersects(playbtnRectangle) && menu) { playbtnTexture = Content.Load<Texture2D>("resources/img/playb"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { menu = false; pause = false; enemies.Clear(); } } else { playbtnTexture = Content.Load<Texture2D>("resources/img/play"); }
            if (cursorR.Intersects(exitbtnRectangle) && menu) { exitbtnTexture = Content.Load<Texture2D>("resources/img/exitb"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { Exit(); } } else { exitbtnTexture = Content.Load<Texture2D>("resources/img/exit"); }
            if (Keyboard.GetState().IsKeyDown(Keys.Escape) && !pause) { pause = true; }
            if (cursorR.Intersects(resumebtnRectangle) && pause) { resumebtnTexture = Content.Load<Texture2D>("resources/img/resumeb"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { pause = false; } } else { resumebtnTexture = Content.Load<Texture2D>("resources/img/resume"); }
            if (cursorR.Intersects(menubtnRectangle) && pause) { menubtnTexture = Content.Load<Texture2D>("resources/img/menub"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { menu = true; del = 0; pause = false; } } else { menubtnTexture = Content.Load<Texture2D>("resources/img/menu"); }
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


            if (Keyboard.GetState().IsKeyDown(Keys.A)){if(cursor.x>=0){cursor.x-=cursor.spd;}}
            if (Keyboard.GetState().IsKeyDown(Keys.D)){if(cursor.x<Window.ClientBounds.Width-cursor.texture.Width){cursor.x += cursor.spd;}}
            if(Keyboard.GetState().IsKeyDown(Keys.W)){if (cursor.y >= 0){cursor.y -= cursor.spd;}}
            if(Keyboard.GetState().IsKeyDown(Keys.S)){if(cursor.y<Window.ClientBounds.Height-cursor.texture.Height){cursor.y += cursor.spd;}}
            cursorR = new Rectangle(cursor.x + 10, cursor.y + 10, cursor.w - 20, cursor.h - 20);

            if (!pause && !menu)
            {
                tiempoactual = DateTime.Now;
                tiempo = tiempoactual - timew;
                tiempo2 = tiempoactual - timew2;

                if (level1){if(tiempo.Seconds>=2){int originx = rnd1.Next(250, 500); int originy = rnd1.Next(200, 400); enemies.Add(new Enemy(enemyTexture, originx, originy, 23, 13, 2, 1, 1, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height)); timew = DateTime.Now; }for (int i = 0; i < enemies.Count; i++) { if (enemies[i].tw > 250) { enemies.RemoveAt(i); } }foreach (Enemy e in enemies) { if (en1movdel > 5000) { e.Mov1(); enemiesrectangles.Add(new Rectangle(e.px, e.py, e.tw, e.th)); en1movdel = 0; } en1movdel++; if (new Rectangle(e.px, e.py, e.tw, e.th).Intersects(cursorR) && Keyboard.GetState().IsKeyDown(Keys.Space)) { enemies.Remove(e); break; } }
                if(level2){if(tiempo2.Seconds>=3){int originx=rnd1.Next(250,500);int originy=rnd1.Next(200,400);enemies2.Add(new Enemy(enemy2Texture,originx,originy,23,13,2,1,1,GraphicsDevice.Viewport.Width,GraphicsDevice.Viewport.Height));timew2=DateTime.Now;}for(int i=0;i<enemies2.Count;i++){if(enemies2[i].tw>250){enemies2.RemoveAt(i);}}foreach(Enemy e2 in enemies2){if(en2movdel>4750){e2.Mov1();enemies2rectangles.Add(new Rectangle(e2.px,e2.py,e2.tw,e2.th));en2movdel=0;}en2movdel++;if (cursorR.Intersects(new Rectangle(e2.px,e2.py,e2.tw,e2.th))&&Keyboard.GetState().IsKeyDown(Keys.Space)){enemies2.Remove(e2);break;}}}
                if(level3){if(tiempo3.Seconds>=4){int originx=rnd1.Next(250,500);int originy=rnd1.Next(200,400);enemies3.Add(new Enemy(enemy3Texture,originx,originy,23,13,2,1,1,GraphicsDevice.Viewport.Width,GraphicsDevice.Viewport.Height));timew3=DateTime.Now;}for(int i=0;i<enemies3.Count;i++){if(enemies3[i].tw>250){enemies3.RemoveAt(i);}}foreach(Enemy e3 in enemies3){if(en3movdel>4750){e3.Mov1();enemies3rectangles.Add(new Rectangle(e3.px,e3.py,e3.tw,e3.th));en3movdel=0;}en3movdel++;if (cursorR.Intersects(new Rectangle(e3.px,e3.py,e3.tw,e3.th))&&Keyboard.GetState().IsKeyDown(Keys.Space)){enemies3.Remove(e3);break;}}}

                }
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            if (!pause && !menu)
            {
                foreach (Enemy e in enemies)
                {_spriteBatch.Draw(e.entexture, new Rectangle(e.px,e.py,e.tw,e.th) , Color.White);e.Mov1();}

                foreach (Enemy e2 in enemies2)
                {_spriteBatch.Draw(e2.entexture, new Rectangle(e2.px, e2.py, e2.tw, e2.th), Color.White);e2.Mov2();}

                foreach (Enemy e3 in enemies3)
                { _spriteBatch.Draw(e3.entexture, new Rectangle(e3.px, e3.py, e3.tw, e3.th), Color.White); e3.Mov2(); }
            }
            
            if (debug)
            {
                _spriteBatch.DrawString(debug_font, "Player: ", new Vector2(10, 30), Color.White);
                _spriteBatch.DrawString(debug_font, "X: " + cursor.x, new Vector2(10, 50), Color.White);
                _spriteBatch.DrawString(debug_font, "Y: " + cursor.y, new Vector2(10, 70), Color.White);

                _spriteBatch.Draw(keyboardTexture, keyboardPosition, Color.White);
                _spriteBatch.Draw(akeyTexture, keyboardPosition, Color.White);
                _spriteBatch.Draw(skeyTexture, keyboardPosition, Color.White);
                _spriteBatch.Draw(dkeyTexture, keyboardPosition, Color.White);
                _spriteBatch.Draw(wkeyTexture, keyboardPosition, Color.White);
                _spriteBatch.Draw(keyboardspcTexture, keyboardspcPosition, Color.White);
                _spriteBatch.Draw(spacekeyTexture, keyboardspcPosition, Color.White);
            }
            if (pause){ 
                _spriteBatch.Draw(resumebtnTexture, resumebtnPosition, Color.White); 
                _spriteBatch.Draw(menubtnTexture, menubtnPosition, Color.White); 
            }
            else if (menu){
                _spriteBatch.Draw(playbtnTexture, playbtnPosition, Color.White); 
                _spriteBatch.Draw(exitbtnTexture, exitbtnPosition, Color.White);
            }
            //_spriteBatch.Draw(pointerTexture, pointerPosition, Color.White);
            _spriteBatch.Draw(cursor.texture, new Rectangle(cursor.x, cursor.y, cursor.w, cursor.h), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}