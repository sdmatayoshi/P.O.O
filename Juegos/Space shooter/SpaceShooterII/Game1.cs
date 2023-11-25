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
        private Texture2D titleTexture;
        private Vector2 titlePosition;
        private Texture2D goTexture;
        private Vector2 goPosition;
        private Texture2D pTexture;
        private Vector2 pPosition;
        List<Enemy> enemies;
        List<Enemy> enemies2;
        List<Enemy> enemies3;
        List<Enemy> enemies4;
        List<Enemy> ebullets;
        List<Rectangle> enemiesrectangles;
        List<Rectangle> enemies2rectangles;
        List<Rectangle> enemies3rectangles;
        List<Rectangle> enemies4rectangles;
        List<Rectangle> ebulletrectangles;
        private Texture2D enemyTexture;
        private Texture2D enemy2Texture;
        private Texture2D enemy3Texture;
        private Texture2D enemy4Texture;
        private Texture2D ebulletTexture;
        DateTime tiempoactual;
        DateTime timew;
        DateTime timew2;
        DateTime timew3;
        DateTime timew4;
        DateTime timeweb;
        TimeSpan tiempo;
        TimeSpan tiempo2;
        TimeSpan tiempo3;
        TimeSpan tiempo4;
        TimeSpan tiempoeb;
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
            _graphics.IsFullScreen = true;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            base.Initialize();
        }
        bool space = false; bool a = false; bool s = false; bool d = false; bool w = false; bool bossanim = false; bool pause = false; bool menu = true; bool debug = false; int debugdelay = 0; int del = 0;
        bool level1 = true;
        bool level2 = false;
        bool level3 = false;
        bool level4 = false;
        bool gameover = false;
        int en1movdel; int en2movdel; int en3movdel; int en4movdel; int ebmovdel; int enbmovdel;
        int score = 0;
        int shoot = 0;

        Random rnd1 = new Random();
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            titleTexture = Content.Load<Texture2D>("resources/img/title");
            titlePosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - titleTexture.Width / 2,200);
            goTexture = Content.Load<Texture2D>("resources/img/gameover");
            goPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - titleTexture.Width / 2,200);
            pTexture = Content.Load<Texture2D>("resources/img/pause");
            pPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - titleTexture.Width / 2,200);
            ;
            enemies = new List<Enemy>();
            enemies2 = new List<Enemy>();
            enemies3 = new List<Enemy>();
            enemies4 = new List<Enemy>();
            ebullets = new List<Enemy>();

            enemiesrectangles = new List<Rectangle>();
            enemies2rectangles = new List<Rectangle>();
            enemies3rectangles = new List<Rectangle>();
            enemies4rectangles = new List<Rectangle>();
            ebulletrectangles = new List<Rectangle>();

            enemyTexture = Content.Load<Texture2D>("resources/img/enemy11");
            enemy2Texture = Content.Load<Texture2D>("resources/img/enemy21");
            enemy3Texture = Content.Load<Texture2D>("resources/img/enemy31");
            enemy4Texture = Content.Load<Texture2D>("resources/img/enemy41");
            ebulletTexture = Content.Load<Texture2D>("resources/img/pbullet");

            cursor = new Player();
            cursor.texture = Content.Load<Texture2D>("resources/img/cross-pointer");

            keyboardTexture = Content.Load<Texture2D>("resources/img/wasd");
            akeyTexture = Content.Load<Texture2D>("resources/img/a");
            skeyTexture = Content.Load<Texture2D>("resources/img/s");
            dkeyTexture = Content.Load<Texture2D>("resources/img/d");
            wkeyTexture = Content.Load<Texture2D>("resources/img/w");
            keyboardspcTexture = Content.Load<Texture2D>("resources/img/space");
            spacekeyTexture = Content.Load<Texture2D>("resources/img/spacepress");
            keyboardPosition = new Vector2(GraphicsDevice.Viewport.Width-keyboardTexture.Width,GraphicsDevice.Viewport.Height-keyboardTexture.Height-50);
            keyboardspcPosition = new Vector2(GraphicsDevice.Viewport.Width - keyboardTexture.Width, GraphicsDevice.Viewport.Height - keyboardTexture.Height);

            
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
            if (cursorR.Intersects(playbtnRectangle) && menu && (gameover || !gameover)) { playbtnTexture = Content.Load<Texture2D>("resources/img/playb"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { menu = false; pause = false; gameover = false; cursor.hp = 7;  enemies.Clear(); } } else { playbtnTexture = Content.Load<Texture2D>("resources/img/play"); }
            if (cursorR.Intersects(exitbtnRectangle) && menu) { exitbtnTexture = Content.Load<Texture2D>("resources/img/exitb"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { Exit(); } } else { exitbtnTexture = Content.Load<Texture2D>("resources/img/exit"); }
            if (Keyboard.GetState().IsKeyDown(Keys.Escape) && !pause) { pause = true; }
            if (cursorR.Intersects(resumebtnRectangle) && pause) { resumebtnTexture = Content.Load<Texture2D>("resources/img/resumeb"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { pause = false; } } else { resumebtnTexture = Content.Load<Texture2D>("resources/img/resume"); }if (cursorR.Intersects(menubtnRectangle) && pause) { menubtnTexture = Content.Load<Texture2D>("resources/img/menub"); if (Keyboard.GetState().IsKeyDown(Keys.Space)) { menu = true; del = 0; pause = false; } } else { menubtnTexture = Content.Load<Texture2D>("resources/img/menu"); }
            if (a) { akeyTexture = Content.Load<Texture2D>("resources/img/a"); }else { akeyTexture = Content.Load<Texture2D>("resources/img/void"); }if (s) { skeyTexture = Content.Load<Texture2D>("resources/img/s"); }else { skeyTexture = Content.Load<Texture2D>("resources/img/void"); }if (d) { dkeyTexture = Content.Load<Texture2D>("resources/img/d"); }else { dkeyTexture = Content.Load<Texture2D>("resources/img/void"); }if (w) { wkeyTexture = Content.Load<Texture2D>("resources/img/w"); }else { wkeyTexture = Content.Load<Texture2D>("resources/img/void"); }if (space) { spacekeyTexture = Content.Load<Texture2D>("resources/img/spacepress"); }else { spacekeyTexture = Content.Load<Texture2D>("resources/img/void"); }
            if (Keyboard.GetState().IsKeyDown(Keys.F3) && !debug && debugdelay > 7) { debug = true; debugdelay = 0; } else if (Keyboard.GetState().IsKeyDown(Keys.F3) && debug && debugdelay > 7) { debug = false; debugdelay = 0; }
            if (Keyboard.GetState().IsKeyDown(Keys.Space)) { space = true; } else { space = false; }if (Keyboard.GetState().IsKeyDown(Keys.A)) { a = true; } else { a = false; }if (Keyboard.GetState().IsKeyDown(Keys.S)) { s = true; } else { s = false; }if (Keyboard.GetState().IsKeyDown(Keys.D)) { d = true; } else { d = false; }if (Keyboard.GetState().IsKeyDown(Keys.W)) { w = true; } else { w = false; }


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
                tiempo3 = tiempoactual - timew3;
                tiempo4 = tiempoactual - timew4;
                tiempoeb = tiempoactual - timeweb;

                if (level1) 
                { 
                    if (tiempo.Seconds >= 2) 
                    { 
                        int originx = rnd1.Next(250, 500); int originy = rnd1.Next(200, 400); enemies.Add(new Enemy(enemyTexture, originx, originy, 23, 13, 2, 1, 1, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, 1)); timew = DateTime.Now; 
                    } 
                    for (int i = 0; i < enemies.Count; i++) 
                    { 
                        if (enemies[i].tw > 250) 
                        { 
                            enemies.RemoveAt(i);
                            cursor.hp -= 1;
                        } 
                    } 
                    foreach (Enemy e in enemies) 
                    { 
                        if (en1movdel > 5000) 
                        {
                            e.Mov1(); enemiesrectangles.Add(new Rectangle(e.px + 10, e.py + 10, e.tw - 20, e.th - 20)); en1movdel = 0; 
                        } 
                        en1movdel++; 
                        if (new Rectangle(e.px + 10, e.py + 10, e.tw - 20, e.th - 20).Intersects(cursorR) && Keyboard.GetState().IsKeyDown(Keys.Space)) 
                        { e.hp -= 1; if (e.hp <= 0) 
                            { 
                                enemies.Remove(e); score += 1; break; 
                            } 
                        } 
                    } 
                }
                if (level2)
                {
                    if (tiempo2.Seconds >= 3)
                    {
                        int originx = rnd1.Next(250, 500);
                        int originy = rnd1.Next(200, 400);
                        enemies2.Add(new Enemy(enemy2Texture, originx, originy, 23, 13, 2, 1, 1, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, 1));
                        timew2 = DateTime.Now;
                    }
                    for (int i = 0; i < enemies2.Count; i++)
                    {
                        if (enemies2[i].tw > 250)
                        {
                            enemies2.RemoveAt(i);
                            cursor.hp -= 1;
                        }
                    }
                    foreach (Enemy e2 in enemies2)
                    {
                        if (en2movdel > 4750)
                        {
                            e2.Mov1(); enemies2rectangles.Add(new Rectangle(e2.px + 10, e2.py + 10, e2.tw - 20, e2.th - 20)); en2movdel = 0;
                        }
                        en2movdel++;
                        if (cursorR.Intersects(new Rectangle(e2.px + 10, e2.py + 10, e2.tw - 20, e2.th - 20)) && Keyboard.GetState().IsKeyDown(Keys.Space))
                        {
                            e2.hp -= 1;
                            if (e2.hp <= 0)
                            {
                                enemies2.Remove(e2);
                                score += 1;
                                break;
                            }
                        }
                    }
                }
                if (level3)
                {
                    if (tiempo3.Seconds >= 4)
                    {
                        int originx = rnd1.Next(250, 500);
                        int originy = rnd1.Next(200, 400);
                        enemies3.Add(new Enemy(enemy3Texture, originx, originy, 23, 13, 2, 1, 1, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, 3));
                        timew3 = DateTime.Now;
                    }
                    for (int i = 0; i < enemies3.Count; i++)
                    {
                        if (enemies3[i].tw > 250)
                        {
                            enemies3.RemoveAt(i);
                            cursor.hp -= 1;
                        }
                    }
                    foreach (Enemy e3 in enemies3)
                    {
                        if (en3movdel > 10000)
                        {
                            e3.Mov3(); enemies3rectangles.Add(new Rectangle(e3.px + 10, e3.py + 10, e3.tw - 20, e3.th - 20)); en3movdel = 0;
                        }
                        en3movdel++;
                        if (cursorR.Intersects(new Rectangle(e3.px + 10, e3.py + 10, e3.tw - 20, e3.th - 20)) && Keyboard.GetState().IsKeyDown(Keys.Space))
                        {
                            e3.hp -= 1;
                            if (e3.hp <= 0)
                            {
                                enemies3.Remove(e3); score += 2; break;
                            }
                        }
                    }
                }
                if (level4)
                {
                    if (tiempo4.Seconds >= 5)
                    {
                        int originx = rnd1.Next(250, 500);
                        int originy = rnd1.Next(200, 400);
                        enemies4.Add(new Enemy(enemy4Texture, originx, originy, 46, 30, 2, 1, 1, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, 1));
                        timew4 = DateTime.Now;
                    }
                    for (int i = 0; i < enemies4.Count; i++)
                    {
                        if (enemies4[i].tw > 250)
                        {
                            enemies4.RemoveAt(i);
                            cursor.hp -= 1;
                        }
                    }
                    foreach (Enemy e4 in enemies4)
                    {
                        if (en4movdel > 6000)
                        {
                            e4.Mov3(); enemies4rectangles.Add(new Rectangle(e4.px + 10, e4.py + 10, e4.tw - 20, e4.th - 20)); en4movdel = 0;
                        }
                        en4movdel++;
                        if (cursorR.Intersects(new Rectangle(e4.px + 10, e4.py + 10, e4.tw - 20, e4.th - 20)) && Keyboard.GetState().IsKeyDown(Keys.Space))
                        {
                            e4.hp -= 1;
                        }
                        if (e4.hp <= 0)
                        {
                            enemies4.Remove(e4); score += 3; break;
                        }
                    }

                    if (tiempoeb.Seconds >= 5)
                    {
                        foreach (Enemy e4 in enemies4)
                        {
                            ebullets.Add(new Enemy(ebulletTexture, e4.px, e4.py, 5, 5, 2, 1, 1, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, 1));
                            timeweb = DateTime.Now;
                        }
                    }
                        for (int i = 0; i < ebullets.Count; i++)
                        {
                            if (ebullets[i].tw > 250)
                            {
                                ebullets.RemoveAt(i);
                                cursor.hp -= 1;
                            }
                        }
                        foreach (Enemy eb in ebullets)
                        {
                            if (ebmovdel > 6000)
                            {
                                eb.Mov1(); ebulletrectangles.Add(new Rectangle(eb.px + 10, eb.py + 10, eb.tw - 20, eb.th - 20)); ebmovdel = 0;
                            }
                            ebmovdel++;
                            if (cursorR.Intersects(new Rectangle(eb.px + 10, eb.py + 10, eb.tw - 20, eb.th - 20)) && Keyboard.GetState().IsKeyDown(Keys.Space))
                            {
                                eb.hp -= 1;
                            }
                            if (eb.hp <= 0)
                            {
                                ebullets.Remove(eb); break;
                            }
                        }
                    }
                }
            if (score == 10)level2 = true;
            if (score == 30) level3 = true;
            if (score == 50) level4 = true;

            if (cursor.hp<=0)
            {
                menu = true;
                gameover = true;
            }
            en1movdel++;
            en2movdel++;
            en3movdel++;
            en4movdel++;
            ebmovdel++;
            debugdelay++;
            del++;
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            if (!menu) { _spriteBatch.DrawString(debug_font, "Score: " + score, new Vector2(20, 50), Color.White); _spriteBatch.DrawString(debug_font, "Hp: " + cursor.hp, new Vector2(20, 10), Color.White); }
            if (!pause && !menu)
            {
                if (level1&&!level2&&!level3&&!level4) _spriteBatch.DrawString(debug_font, "Level " + 1, new Vector2(GraphicsDevice.Viewport.Width-100, 10), Color.White);
                else if (level1 && level2 && !level3 && !level4) _spriteBatch.DrawString(debug_font, "Level " + 2, new Vector2(GraphicsDevice.Viewport.Width - 100, 10), Color.White);
                else if (level1 && level2 && level3 && !level4) _spriteBatch.DrawString(debug_font, "Level " + 3, new Vector2(GraphicsDevice.Viewport.Width - 100, 10), Color.White);
                else if (level1 && level2 && level3 && level4) _spriteBatch.DrawString(debug_font, "Level " + 4, new Vector2(GraphicsDevice.Viewport.Width - 100, 10), Color.White);
                foreach (Enemy e in enemies)
                {_spriteBatch.Draw(e.entexture, new Rectangle(e.px,e.py,e.tw,e.th) , Color.White);e.Mov1();}

                foreach (Enemy e2 in enemies2)
                {_spriteBatch.Draw(e2.entexture, new Rectangle(e2.px, e2.py, e2.tw, e2.th), Color.White);e2.Mov2();}

                foreach (Enemy e3 in enemies3)
                { _spriteBatch.Draw(e3.entexture, new Rectangle(e3.px, e3.py, e3.tw, e3.th), Color.White); e3.Mov3(); }

                foreach (Enemy e4 in enemies4)
                { _spriteBatch.Draw(e4.entexture, new Rectangle(e4.px, e4.py, e4.tw, e4.th), Color.White); e4.Mov4(); }
                foreach (Enemy eb in ebullets)
                { _spriteBatch.Draw(eb.entexture, new Rectangle(eb.px, eb.py, eb.tw, eb.th), Color.White); eb.Mov1(); }
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
            if (pause)
            {
                if(gameover)
                {
                    _spriteBatch.Draw(goTexture, goPosition, Color.White);
                }
                else
                {
                    _spriteBatch.Draw(pTexture, pPosition, Color.White);
                }
                _spriteBatch.Draw(resumebtnTexture, resumebtnPosition, Color.White); 
                _spriteBatch.Draw(menubtnTexture, menubtnPosition, Color.White); 
            }
            else if (menu){
                _spriteBatch.Draw(playbtnTexture, playbtnPosition, Color.White); 
                _spriteBatch.Draw(exitbtnTexture, exitbtnPosition, Color.White);
                _spriteBatch.Draw(titleTexture, titlePosition, Color.White);
            }
            _spriteBatch.Draw(cursor.texture, new Rectangle(cursor.x, cursor.y, cursor.w, cursor.h), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}