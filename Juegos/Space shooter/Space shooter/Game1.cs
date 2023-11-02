using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Security;
using System.Text.RegularExpressions;

namespace Space_shooter
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

        private Texture2D enemy2Texture;
        private Vector2 enemy2Position;
        private Texture2D explosion2Texture;
        private Vector2 explosion2Position;

        private Texture2D enemy3Texture;
        private Vector2 enemy3Position;
        private Texture2D explosion3Texture;
        private Vector2 explosion3Position;

        private Texture2D enemy4Texture;
        private Vector2 enemy4Position;
        private Texture2D explosion4Texture;
        private Vector2 explosion4Position;

        private Texture2D lootboxTexture;
        private Vector2 lootboxPosition;
        private Texture2D gunboxTexture;
        private Vector2 gunboxPosition;

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
        private Texture2D shootefTexture;
        private Vector2 shootefPosition;
        private Texture2D shootef2Texture;
        private Vector2 shootef2Position;



        private Texture2D boss1Texture;
        private Vector2 boss1Position;

        private SpriteFont debug_font;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //graphics.IsFullScreen = true;
        }

        protected override void Initialize()
        {
            base.Initialize();

        }
        bool space = false; bool a = false; bool s = false; bool d = false; bool w = false; bool bossanim = false;
        bool failed = false;bool shoot1 = false; bool shoot2 = false; bool shoot3 = false; bool shoot4 = false; bool shootboss = false; int life = 3; int cooldown1 = 0; bool debug = false; int debugdelay = 0;int score = 0;int difficulty = 1; bool upgraded = false; int upgradedtime = 5;
        bool level1 = true; bool level2 = false; bool level3 = false; bool level4 = false; bool level5 = false; bool loot = false; bool lootshow = false; int lootx; int looty; int lootw; int looth; int lootcont = 0;
        bool isalive1 = true; int en1px = 200; int en1py = 200; int en1tw = 23; int en1th = 13; bool revive1 = false; int revive1time = 10; int endelay1 = 0; string en1texture = "enemy11"; int en1spd = 1; int en1hp = 1;int hptext1x = 200; int hptext1y = 200;
        bool isalive2 = true; int en2px = 270; int en2py = 270; int en2tw = 23; int en2th = 13; bool revive2 = false; int revive2time = 10; int endelay2 = 0; int endelay22 = 0; string en2texture = "enemy21"; string altitude = "up"; int en2spd = 3; int en2hp = 1;
        bool isalive3 = true; int en3px = 320; int en3py = 340; int en3tw = 23; int en3th = 13; bool revive3 = false; int revive3time = 10; int endelay3 = 0; string en3texture = "enemy31"; int en3spd = 2; int en3hp = 2;
        bool isalive4 = true; int en4px = 320; int en4py = 340; int en4tw = 23; int en4th = 13; bool revive4 = false; int revive4time = 10; int endelay4 = 0; int endelay42 = 0; string en4texture = "enemy41";string side = "right"; int en4speed = 5; int en4spd = 1; int en4hp = 1;
        bool isaliveb1 = true; int enb1px = 320; int enb1py = 340; int enb1tw = 23; int enb1th = 13; int endelayb1 = 0; int endelayb12 = 0; string enb1texture = "void"; string b1side = "right"; int enb1speed = 1; int enb1spd = 1; int enb1hp = 30;  int b1animdel = 0;
        bool hit = false;  int hptw = 25; int hpth = 25;
        
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
            if (level1)
            {
                enemyTexture = Content.Load<Texture2D>("resources/img/"+en1texture);
                enemyPosition = new Vector2(en1px, en1py);
                explosionTexture = Content.Load<Texture2D>("resources/img/explosion");
                explosionPosition = new Vector2(0, 0);
            }

            if (level2)
            {
                enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture);
                enemy2Position = new Vector2(en2px, en2py);
                explosion2Texture = Content.Load<Texture2D>("resources/img/explosion");
                explosion2Position = new Vector2(0, 0);
            }
            if (level3)
            {
                enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture);
                enemy3Position = new Vector2(en3px, en3py);
                explosion3Texture = Content.Load<Texture2D>("resources/img/explosion");
                explosion3Position = new Vector2(0, 0);
            }
            if (level4)
            {
                enemy4Texture = Content.Load<Texture2D>("resources/img/" + en4texture);
                enemy4Position = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
                explosion4Texture = Content.Load<Texture2D>("resources/img/explosion");
                explosion4Position = new Vector2(0, 0);
            }
            lootboxTexture = Content.Load<Texture2D>("resources/img/life-box");
            lootboxPosition = new Vector2(0, 0);
            gunboxTexture = Content.Load<Texture2D>("resources/img/mega-box");
            gunboxPosition = new Vector2(0, 0);

            boss1Texture = Content.Load<Texture2D>("resources/img/void");
            boss1Position = new Vector2(GraphicsDevice.Viewport.Width/2, 0);

            debug_font = Content.Load<SpriteFont>("resources/debug");

            shootefTexture = Content.Load<Texture2D>("resources/img/shooteffect");
            shootefPosition = new Vector2(0, GraphicsDevice.Viewport.Height);
            shootef2Texture = Content.Load<Texture2D>("resources/img/shooteffect2");
            shootef2Position = new Vector2(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);

            keyboardTexture = Content.Load<Texture2D>("resources/img/wasd");
            
            akeyTexture = Content.Load<Texture2D>("resources/img/a");
           
            skeyTexture = Content.Load<Texture2D>("resources/img/s");
            
            dkeyTexture = Content.Load<Texture2D>("resources/img/d");
            
            wkeyTexture = Content.Load<Texture2D>("resources/img/w");
            
            keyboardspcTexture = Content.Load<Texture2D>("resources/img/space");
            
            spacekeyTexture = Content.Load<Texture2D>("resources/img/spacepress");
            
            if (!graphics.IsFullScreen == true)
            {
                keyboardPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 150);
                akeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 150);
                skeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 150);
                dkeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 150);
                wkeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 150);
                keyboardspcPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 100);
                spacekeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 100);
            }
            else
            {
                keyboardPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 50);
                akeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 50);
                skeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 50);
                dkeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 50);
                wkeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 50);
                keyboardspcPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 0);
                spacekeyPosition = new Vector2(GraphicsDevice.Viewport.Width - 150, GraphicsDevice.Viewport.Height - 0);
            }


        }

        protected override void Update(GameTime gameTime)
        {
            /*----------------------------------------------------------------------------------Hitboxes---------------------------------------------------------------------------------*/
            Rectangle pointerRectangle = new Rectangle((int)pointerPosition.X + 20, (int)pointerPosition.Y + 20, pointerTexture.Width - 40, pointerTexture.Height - 40);
            Rectangle enemyRectangle = new Rectangle((int)en1px, (int)en1py, en1tw, en1th);
            Rectangle enemy2Rectangle = new Rectangle((int)en2px, (int)en2py, en2tw, en2th);
            Rectangle enemy3Rectangle = new Rectangle((int)en3px, (int)en3py, en3tw, en3th);
            Rectangle enemy4Rectangle = new Rectangle((int)en4px, (int)en4py, en4tw, en4th);
            Rectangle boss1Rectangle = new Rectangle((int)en1px, (int)en1py, en1tw, en1th);
            Rectangle lootRectangle = new Rectangle((int)lootboxPosition.X, (int)lootboxPosition.Y, lootboxTexture.Width, lootboxTexture.Height);
            if (a)
            {
                akeyTexture = Content.Load<Texture2D>("resources/img/a");
            }
            else
            {
                akeyTexture = Content.Load<Texture2D>("resources/img/void");
            }
            if (s)
            {
                skeyTexture = Content.Load<Texture2D>("resources/img/s");
            }
            else
            {
                skeyTexture = Content.Load<Texture2D>("resources/img/void");
            }
            if (d)
            {
                dkeyTexture = Content.Load<Texture2D>("resources/img/d");
            }
            else
            {
                dkeyTexture = Content.Load<Texture2D>("resources/img/void");
            }
            if (w)
            {
                wkeyTexture = Content.Load<Texture2D>("resources/img/w");
            }
            else
            {
                wkeyTexture = Content.Load<Texture2D>("resources/img/void");
            }
            if (space)
            {
                spacekeyTexture = Content.Load<Texture2D>("resources/img/spacepress");
            }
            else
            {
                spacekeyTexture = Content.Load<Texture2D>("resources/img/void");
            }
            /*--------------------------------------------------------------------------------Hitboxes-End-------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------Player-Moves-------------------------------------------------------------------------------*/
            if (Keyboard.GetState().IsKeyDown(Keys.W)) { pointerPosition.Y -= 10; }
            if (Keyboard.GetState().IsKeyDown(Keys.S)) { pointerPosition.Y += 10; }
            if (Keyboard.GetState().IsKeyDown(Keys.A)) { pointerPosition.X -= 10; }
            if (Keyboard.GetState().IsKeyDown(Keys.D)) { pointerPosition.X += 10; }
            if (Keyboard.GetState().IsKeyDown(Keys.Escape)) { Exit(); }
            /*------------------------------------------------------------------------------Player-Moves-End------------------------------------------------------------------------------*/
            /*-------------------------------------------------------------------------------Player-Attack--------------------------------------------------------------------------------*/
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(enemyRectangle) && cooldown1 > 30 && isalive1 && en1texture != "void") { shoot1 = true; cooldown1 = 0; } else { shoot1 = false;}
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(enemy2Rectangle) && cooldown1 > 30 && isalive2 && level2) { shoot2 = true; cooldown1 = 0; } else { shoot2 = false;}
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(enemy3Rectangle) && cooldown1 > 30 && isalive3 && level3) { shoot3 = true; cooldown1 = 0; } else { shoot3 = false;}
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(enemy4Rectangle) && cooldown1 > 30 && isalive4 && level4) { shoot4 = true; cooldown1 = 0; } else { shoot4 = false;}
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && (!shoot1||shoot2||shoot3||shoot4) && cooldown1>30) {failed=true; cooldown1 = 0; } else { failed = false;}
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(lootRectangle) && cooldown1 > 30 && life < 3 && life > 0 && lootshow) { lootshow = false; cooldown1 = 0; life++; }
            if (upgraded)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(enemyRectangle) && isalive1) { shoot1 = true; cooldown1 = 0; upgradedtime--; } else { shoot1 = false; upgradedtime--; }
                if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(enemy2Rectangle) && isalive2) { shoot2 = true; cooldown1 = 0; upgradedtime--; } else { shoot2 = false; upgradedtime--; }
                if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(enemy3Rectangle) && isalive3) { shoot3 = true; cooldown1 = 0; upgradedtime--; } else { shoot3 = false; upgradedtime--; }
                if (Keyboard.GetState().IsKeyDown(Keys.Space) && pointerRectangle.Intersects(enemy4Rectangle) && isalive4) { shoot4 = true; cooldown1 = 0; upgradedtime--; } else { shoot4 = false; upgradedtime--; }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.F3) && !debug && debugdelay > 7) { debug = true; debugdelay = 0; } else if (Keyboard.GetState().IsKeyDown(Keys.F3) && debug && debugdelay > 7) { debug = false; debugdelay = 0; }
            if (Keyboard.GetState().IsKeyDown(Keys.Space)) { space = true; } else { space = false; }
            if (Keyboard.GetState().IsKeyDown(Keys.A)) { a = true; } else { a = false; }
            if (Keyboard.GetState().IsKeyDown(Keys.S)) { s = true; } else { s = false; }
            if (Keyboard.GetState().IsKeyDown(Keys.D)) { d = true; } else { d = false; }
            if (Keyboard.GetState().IsKeyDown(Keys.W)) { w = true; } else { w = false; }
            /*------------------------------------------------------------------------------Player-Attack-End-----------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------Enemy-Moves---------------------------------------------------------------------------------*/
            //Enemy1------------------------
            if (en1px >= (GraphicsDevice.Viewport.Width / 2) + 50 && isalive1 && endelay1 > 5 && isalive1 && level1 && !level5 && !shoot1)
            {
                en1px += 2; en1tw += 1; en1th += 1; hptext1x += 2;
                enemyRectangle.X += en1px; enemyRectangle.Width += en1tw; enemyRectangle.Height += en1th;
                explosionPosition = new Vector2(enemyPosition.X, enemyPosition.Y);
                endelay1 = 0;
                if (en1texture == "enemy11") { en1texture = "enemy12"; enemyTexture = Content.Load<Texture2D>("resources/img/" + en1texture); }
                else if (en1texture == "enemy12") { en1texture = "enemy11"; enemyTexture = Content.Load<Texture2D>("resources/img/" + en1texture); }
            }
            if (en1px < (GraphicsDevice.Viewport.Width / 2) - 50 && isalive1 && endelay1 > 5 && isalive1 && level1 && !level5 && !shoot1)
            {
                en1px -= 2; en1tw += en1spd; en1th += en1spd; hptext1x -= 2;
                enemyRectangle.X += en1px; enemyRectangle.Width += en1tw; enemyRectangle.Height += en1th;
                explosionPosition = new Vector2(enemyPosition.X, enemyPosition.Y);
                endelay1 = 0;
                if (en1texture == "enemy11") { en1texture = "enemy12"; enemyTexture = Content.Load<Texture2D>("resources/img/" + en1texture); }
                else if (en1texture == "enemy12") { en1texture = "enemy11"; enemyTexture = Content.Load<Texture2D>("resources/img/" + en1texture); }
            }
            if (en1py >= (GraphicsDevice.Viewport.Height / 2) && isalive1 && endelay1 > 5 && isalive1 && level1 && !level5 && !shoot1)
            {
                en1py += 1; en1tw += en1spd; en1th += en1spd; hptext1y += 2;
                enemyRectangle.Y += en1py; enemyRectangle.Width += en1tw; enemyRectangle.Height += en1th;
                explosionPosition = new Vector2(enemyPosition.X, enemyPosition.Y);
                endelay1 = 0;
                if (en1texture == "enemy11") { en1texture = "enemy12"; enemyTexture = Content.Load<Texture2D>("resources/img/" + en1texture); }
                else if (en1texture == "enemy12") { en1texture = "enemy11"; enemyTexture = Content.Load<Texture2D>("resources/img/" + en1texture); }
            }
            if (en1py < (GraphicsDevice.Viewport.Height / 2) && isalive1 && endelay1 > 5 && isalive1 && level1 && !level5 && !shoot1)
            {
                en1py -= 1; en1tw += en1spd; en1th += en1spd; hptext1y -= 2;
                enemyRectangle.Y += en1py; enemyRectangle.Width += en1tw; enemyRectangle.Height += en1th;
                explosionPosition = new Vector2(enemyPosition.X, enemyPosition.Y);
                endelay1 = 0;
                if (en1texture == "enemy11") { en1texture = "enemy12"; enemyTexture = Content.Load<Texture2D>("resources/img/" + en1texture); }
                else if (en1texture == "enemy12") { en1texture = "enemy11"; enemyTexture = Content.Load<Texture2D>("resources/img/" + en1texture); }
            }



            //Enemy2---------------------------
            if (en2py >= (GraphicsDevice.Viewport.Height / 2) + 200 && en2px <= (GraphicsDevice.Viewport.Height / 2) + 400) { altitude = "up"; }
            if (en2py <= (GraphicsDevice.Viewport.Height / 2) - 100 && en2px <= (GraphicsDevice.Viewport.Height / 2) - 300) { altitude = "down"; }

            if (en2px >= (GraphicsDevice.Viewport.Width / 2) && isalive2 && endelay2 > 10 && isalive2 && level2 && !level5 && !shoot2)
            {
                en2px += 2; en2tw += en2spd; en2th += en2spd;
                enemy2Rectangle.X += en2px; enemy2Rectangle.Width += en2tw; enemy2Rectangle.Height += en2th;
                explosion2Position = new Vector2(enemy2Position.X, enemy2Position.Y);
                endelay2 = 0;
                if (en2texture == "enemy21") { en2texture = "enemy22"; enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture); }
                else if (en2texture == "enemy22") { en2texture = "enemy21"; enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture); }
            }
            if (en2px <= (GraphicsDevice.Viewport.Width / 2) && isalive2 && endelay2 > 10 && isalive2 && level2 && !level5 && !shoot2)
            {
                en2px -= 2; en2tw += en2spd; en2th += en2spd;
                enemy2Rectangle.X += en2px; enemy2Rectangle.Width += en2tw; enemy2Rectangle.Height += en2th;
                explosion2Position = new Vector2(enemy2Position.X, enemy2Position.Y);
                endelay2 = 0;
                if (en2texture == "enemy21") { en2texture = "enemy22"; enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture); }
                else if (en2texture == "enemy22") { en2texture = "enemy21"; enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture); }
            }
            if (altitude == "down" && isalive2 && endelay2 > 10 && isalive2 && level2 && !level5 && !shoot2)
            {
                en1py += 10; en1tw += en2spd; en1th += en2spd;
                enemy2Rectangle.Y += en2py; enemy2Rectangle.Width += en2tw; enemy2Rectangle.Height += en2th;
                explosion2Position = new Vector2(enemy2Position.X, enemy2Position.Y);
                endelay2 = 0;
                if (en2texture == "enemy21") { en2texture = "enemy22"; enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture); }
                else if (en2texture == "enemy22") { en2texture = "enemy21"; enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture); }
            }
            if (altitude == "up" && isalive2 && endelay2 > 10 && isalive2 && level2 && !level5 && !shoot2)
            {
                en2py -= 10; en2tw += en2spd; en2th += en2spd;
                enemy2Rectangle.Y += en2py; enemy2Rectangle.Width += en2tw; enemy2Rectangle.Height += en2th;
                explosion2Position = new Vector2(enemy2Position.X, enemy2Position.Y);
                endelay2 = 0;
                if (en2texture == "enemy21") { en2texture = "enemy22"; enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture); }
                else if (en2texture == "enemy22") { en2texture = "enemy21"; enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture); }
            }





            //Enemy3-------------------------
            if (en3px >= (GraphicsDevice.Viewport.Width / 2) + 50 && isalive3 && endelay3 > 30 && isalive3 && level3 && !level5 && !shoot3)
            {
                en3px += 2; en3tw += en3spd; en3th += en3spd;
                enemy3Rectangle.X += en3px; enemy3Rectangle.Width += en3tw; enemy3Rectangle.Height += en3th;
                explosion3Position = new Vector2(enemy3Position.X, enemy3Position.Y);
                endelay3 = 0;
                if (en3texture == "enemy31") { en3texture = "enemy32"; enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture); }
                else if (en3texture == "enemy32") { en3texture = "enemy31"; enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture); }
            }
            if (en3px < (GraphicsDevice.Viewport.Width / 2) - 50 && isalive3 && endelay3 > 30 && isalive3 && level3 && !level5 && !shoot3)
            {
                en3px -= 2; en3tw += en3spd; en3th += en3spd;
                enemy3Rectangle.X += en3px; enemy3Rectangle.Width += en3tw; enemy3Rectangle.Height += en3th;
                explosion3Position = new Vector2(enemy3Position.X, enemy3Position.Y);
                endelay3 = 0;
                if (en3texture == "enemy31") { en3texture = "enemy32"; enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture); }
                else if (en3texture == "enemy32") { en3texture = "enemy31"; enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture); }
            }
            if (en3py >= (GraphicsDevice.Viewport.Height / 2) && isalive3 && endelay3 > 30 && isalive3 && level3 && !level5 && !shoot3)
            {
                en3py += 1; en3tw += en3spd; en3th += en3spd;
                enemy3Rectangle.X += en3px; enemy3Rectangle.Width += en3tw; enemy3Rectangle.Height += en3th;
                explosion3Position = new Vector2(enemy3Position.X, enemy3Position.Y);
                endelay3 = 0;
                if (en3texture == "enemy31") { en3texture = "enemy32"; enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture); }
                else if (en3texture == "enemy32") { en3texture = "enemy31"; enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture); }
            }
            if (en3py < (GraphicsDevice.Viewport.Height / 2) && isalive3 && endelay3 > 30 && isalive3 && level3 && !level5 && !shoot3)
            {
                en3py -= 1; en3tw += en3spd; en3th += en3spd;
                enemy3Rectangle.X += en3px; enemy3Rectangle.Width += en3tw; enemy3Rectangle.Height += en3th;
                explosion3Position = new Vector2(enemy3Position.X, enemy3Position.Y);
                endelay3 = 0;
                if (en3texture == "enemy31") { en3texture = "enemy32"; enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture); }
                else if (en3texture == "enemy32") { en3texture = "enemy31"; enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture); }
            }


            //Enemy4-------------------------
            if (en4px > (GraphicsDevice.Viewport.Width / 2) + 200 && en4px <= (GraphicsDevice.Viewport.Width / 2) + 400) { side = "left"; }
            if (en4px < (GraphicsDevice.Viewport.Width / 2) - 100 && en4px <= (GraphicsDevice.Viewport.Width / 2) - 300) { side = "right"; }
            if (side == "right" && isalive4 && endelay4 > 1 && isalive4 && level4 && !level5 && !shoot4)
            {
                en4px += en4speed;
                enemy4Rectangle.X += en4px; enemy4Rectangle.Width += en4tw; enemy4Rectangle.Height += en4th;
                explosion4Position = new Vector2(enemy4Position.X, enemy4Position.Y);
                endelay4 = 0;
                if (en4texture == "enemy41") { en4texture = "enemy42"; enemy4Texture = Content.Load<Texture2D>("resources/img/" + en4texture); }
                else if (en4texture == "enemy42") { en4texture = "enemy41"; enemy4Texture = Content.Load<Texture2D>("resources/img/" + en4texture); }
                if (endelay42 >= 7)
                {
                    en4tw += en4spd; en4th += en4spd;
                    enemy4Rectangle.X += en4px; enemy4Rectangle.Width += en4tw; enemy4Rectangle.Height += en4th;
                    endelay42 = 0;
                    if (en4speed < 20)
                        en4speed++;
                }
            }
            if (side == "left" && isalive4 && endelay4 > 1 && isalive4 && level4 && !level5 && !shoot4)
            {
                en4px -= en4speed;
                enemy4Rectangle.X += en4px; enemy4Rectangle.Width += en4tw; enemy4Rectangle.Height += en4th;
                explosion4Position = new Vector2(enemy4Position.X, enemy4Position.Y);
                endelay4 = 0;
                if (en4texture == "enemy41") { en4texture = "enemy42"; enemy4Texture = Content.Load<Texture2D>("resources/img/" + en4texture); }
                else if (en4texture == "enemy42") { en4texture = "enemy41"; enemy4Texture = Content.Load<Texture2D>("resources/img/" + en4texture); }
                if (endelay42 >= 7)
                {
                    en4tw += 1; en4th += 1;
                    enemy4Rectangle.X += en4px; enemy4Rectangle.Width += en4tw; enemy4Rectangle.Height += en4th;
                    endelay42 = 0;
                    if (en4speed < 20)
                        en4speed++;
                }
            }

            /*------------------------------------------------------------------------------Enemy-Moves-End-------------------------------------------------------------------------------*/
            if (shoot1 && isalive1)
            {
                if (isalive1)
                {
                    en1hp -= 1;
                    explosionTexture = Content.Load<Texture2D>("resources/img/explosion");
                }

                enemyTexture = Content.Load<Texture2D>("resources/img/void");
                isalive1 = false;
                revive1time = 0;
                score++;
            }
            else
            {
                explosionTexture = Content.Load<Texture2D>("resources/img/void");
            }

            if (shoot2 && isalive2)
            {
                if (isalive2)
                {
                    en2hp -= 1;
                    explosion2Texture = Content.Load<Texture2D>("resources/img/explosion");
                }

                enemy2Texture = Content.Load<Texture2D>("resources/img/void");
                isalive2 = false;
                revive2time = 0;
                score += 2;

            }
            else
            {
                explosion2Texture = Content.Load<Texture2D>("resources/img/void");
            }




            if (shoot3 && isalive3)
            {
                if (isalive3)
                {
                    en3hp -= 1;
                    explosion3Texture = Content.Load<Texture2D>("resources/img/explosion");
                }
                if (en3hp <= 0)
                {
                    enemy3Texture = Content.Load<Texture2D>("resources/img/void");
                    isalive3 = false;
                    revive3time = 0;
                    score += 3;
                }

            }
            else
            {
                explosion3Texture = Content.Load<Texture2D>("resources/img/void");
            }





            if (shoot4 && isalive4)
            {
                if (isalive4)
                {
                    en4hp -= 1;
                    explosion4Texture = Content.Load<Texture2D>("resources/img/explosion");
                }

                enemy4Texture = Content.Load<Texture2D>("resources/img/void");
                isalive4 = false;
                revive4time = 0;
                score += 5;

                var rand = new Random();
                int lootrnd = rand.Next(1, 4);
                if (lootrnd == 3)
                {

                    //lootshow = true;
                }
            }
            else
            {
                explosion4Texture = Content.Load<Texture2D>("resources/img/void");
            }

            //if (lootshow)
            //{

            //    lootboxTexture = Content.Load<Texture2D>("resources/img/life-box");
            //}
            //else
            //{
            //    lootboxTexture = Content.Load<Texture2D>("resources/img/void");
            //}




            if (level5)
            {
                bossanim = true;
            }
            if (bossanim)
            {
                isaliveb1 = true;
                boss1Texture = Content.Load<Texture2D>("resources/img/" + enb1texture);
            }
            if (isaliveb1)
            {
                if (enb1texture == "boss1" && b1animdel > 20)
                {
                    enb1texture = "boss1b";
                    b1animdel = 0;
                }
                else if (enb1texture == "boss1b" && b1animdel > 20)
                {
                    enb1texture = "boss1";
                    b1animdel = 0;
                }
            }
            /*---------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            if (en1tw > 200 && en1tw > 190)
            {
                isalive1 = false;
                en1tw = 0;
                en1th = 0;
                life--;
                revive1time = 0;
            }
            if (revive1time == 20)
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
                enemyTexture = Content.Load<Texture2D>("resources/img/" + en1texture);
                isalive1 = true;
                revive1 = false;
            }



            if (en2tw > 200 && en2tw > 190)
            {
                isalive2 = false;
                en2tw = 0;
                en2th = 0;
                life--;
                revive2time = 0;
            }
            if (revive2time == 20)
            {
                revive2 = true;
            }
            if (revive2)
            {
                var rand = new Random();
                int posx = rand.Next(200, 500);
                int posy = rand.Next(100, 300);
                en2tw = 23;
                en2th = 13;
                en2px = posx;
                en2py = posy;
                enemy2Texture = Content.Load<Texture2D>("resources/img/" + en2texture);
                isalive2 = true;
                revive2 = false;
            }


            if (en3tw > 200 && en3tw > 190)
            {
                isalive3 = false;
                en3tw = 0;
                en3th = 0;
                life -= 2;
                revive3time = 0;
            }
            if (revive3time == 20)
            {
                revive3 = true;
            }
            if (revive3)
            {
                var rand = new Random();
                int posx = rand.Next(200, 500);
                int posy = rand.Next(100, 300);
                en3tw = 23;
                en3th = 13;
                en3px = posx;
                en3py = posy;
                en3hp = 2;
                enemy3Texture = Content.Load<Texture2D>("resources/img/" + en3texture);
                isalive3 = true;
                revive3 = false;
            }



            if (en4tw > 200 && en4tw > 190)
            {
                isalive4 = false;
                en4tw = 0;
                en4th = 0;
                life -= 0;
                revive4time = 0;
            }
            if (revive4time == 20)
            {
                revive4 = true;
            }
            if (revive4)
            {
                var rand = new Random();
                int posx = rand.Next(200, 500);
                int posy = rand.Next(100, 300);
                en4tw = 23;
                en4th = 13;
                en4px = GraphicsDevice.Viewport.Width / 2;
                en4py = GraphicsDevice.Viewport.Height / 2;
                enemy4Texture = Content.Load<Texture2D>("resources/img/" + en4texture);
                isalive4 = true;
                revive4 = false;
                en4speed = 0;
            }

            if (level5)
            {
                isalive1 = false;
                isalive2 = false;
                isalive3 = false;
                isalive4 = false;
            }
            if (score>10)
            {
                level2 = true;
                difficulty = 2;
                en1spd = 2;
            }
            if (score > 30)
            {
                level3 = true;
                difficulty = 3;
                en1spd = 3;
                en2spd = 3;
            }
            if (score > 50)
            {
                level4 = true;
                difficulty = 4;
            }
            if (score > 100)
            {
                level5 = true;
                difficulty = 5;
                isalive1 = false;
                isalive2 = false;
                isalive3 = false;
                isalive4 = false;
            }
            if (upgraded)
            {
                pointerTexture = Content.Load<Texture2D>("resources/img/upgrade-cross");
            }
            if (upgradedtime <= 0){
                upgraded = false;
                upgradedtime = 5;
            }


            revive1time++;endelay1++;
            revive2time++; endelay2++;
            revive3time++; endelay3++;
            revive4time++; endelay4++; endelay42++;
            cooldown1++;
            b1animdel++;
            debugdelay++;
            //lootcont++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            
            spriteBatch.Begin();
            
            if (isalive1 && level1 && !level5)
            {
                spriteBatch.Draw(enemyTexture, new Rectangle(en1px, en1py, en1tw, en1th), Color.White);
            }

            if (isalive2 && level2 && !level5)
            {
                spriteBatch.Draw(enemy2Texture, new Rectangle(en2px, en2py, en2tw, en2th), Color.White);
            }

            if (isalive3 && level3 && !level5)
            {
                spriteBatch.Draw(enemy3Texture, new Rectangle(en3px, en3py, en3tw, en3th), Color.White);
            }

            if (isalive4 && level4 && !level5)
            {
                spriteBatch.Draw(Content.Load<Texture2D>("resources/img/" + en4texture), new Rectangle(en4px, en4py, en4tw, en4th), Color.White);
            }

            if (lootshow)
            {
                spriteBatch.Draw(lootboxTexture, new Rectangle(GraphicsDevice.Viewport.Width/2, GraphicsDevice.Viewport.Height/2, lootboxTexture.Width, lootboxTexture.Height), Color.White);
            }
            spriteBatch.Draw(explosionTexture, new Rectangle(en1px, en1py, en1tw, en1th), Color.White);
            spriteBatch.Draw(explosion2Texture, new Rectangle(en2px, en2py, en2tw, en2th), Color.White);
            spriteBatch.Draw(explosion3Texture, new Rectangle(en3px, en3py, en3tw, en3th), Color.White);
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
            spriteBatch.DrawString(debug_font, "Score: "+score, new Vector2(100, 10), Color.White);
           
spriteBatch.DrawString(debug_font, "Level: "+difficulty, new Vector2(GraphicsDevice.Viewport.Width - 100, 10), Color.White);

            if (shoot1||shoot2||shoot3||shoot4||failed)
            {
                spriteBatch.Draw(shootefTexture, new Rectangle(0, GraphicsDevice.Viewport.Height-100, 100, 100), Color.White);
                spriteBatch.Draw(shootef2Texture, new Rectangle(GraphicsDevice.Viewport.Width-100, GraphicsDevice.Viewport.Height-100, 100, 100), Color.White);
            }
            if (debug)
            {
                spriteBatch.DrawString(debug_font, "Player: ", new Vector2(10, 30), Color.White);
                spriteBatch.DrawString(debug_font, "X: " + pointerPosition.X, new Vector2(10, 50), Color.White);
                spriteBatch.DrawString(debug_font, "Y: " + pointerPosition.Y, new Vector2(10, 70), Color.White);
                spriteBatch.DrawString(debug_font, "hp: " + life, new Vector2(10, 90), Color.White);
                spriteBatch.DrawString(debug_font, "shoot1: " + shoot1, new Vector2(10, 110), Color.White);
                spriteBatch.DrawString(debug_font, "cooldown1: " + cooldown1, new Vector2(10, 130), Color.White);
                //spriteBatch.DrawString(debug_font, "revive1time: " + revive1time, new Vector2(0, 10), Color.White);
                //spriteBatch.DrawString(debug_font, "move delay enemy 1: " + endelay1, new Vector2(50, 10), Color.White);
                spriteBatch.DrawString(debug_font, "Enemy: ", new Vector2(10, 150), Color.White);
                spriteBatch.DrawString(debug_font, "en3hp: " + en3hp, new Vector2(10, 170), Color.White);
                spriteBatch.DrawString(debug_font, "lootcont: " + lootcont, new Vector2(10, 190), Color.White);
                spriteBatch.DrawString(debug_font, "alive1: " + isalive1, new Vector2(10, 210), Color.White);
                spriteBatch.DrawString(debug_font, "alive2: " + isalive2, new Vector2(10, 230), Color.White);
                spriteBatch.DrawString(debug_font, "alive3: " + isalive3, new Vector2(10, 250), Color.White);
                spriteBatch.DrawString(debug_font, "alive4: " + isalive4, new Vector2(10, 270), Color.White);
                spriteBatch.DrawString(debug_font, "" +"", new Vector2(10, 290), Color.White);
                spriteBatch.DrawString(debug_font, "level1: " + level1, new Vector2(GraphicsDevice.Viewport.Width - 100, 30), Color.White);
                spriteBatch.DrawString(debug_font, "level2: " + level2, new Vector2(GraphicsDevice.Viewport.Width - 100, 50), Color.White);
                spriteBatch.DrawString(debug_font, "level3: " + level3, new Vector2(GraphicsDevice.Viewport.Width - 100, 70), Color.White);
                spriteBatch.DrawString(debug_font, "level4: " + level4, new Vector2(GraphicsDevice.Viewport.Width - 100, 90), Color.White);
                spriteBatch.DrawString(debug_font, "level5: " + level5, new Vector2(GraphicsDevice.Viewport.Width - 100, 110), Color.White);



                spriteBatch.Draw(keyboardTexture, keyboardPosition, Color.White);
                spriteBatch.Draw(akeyTexture, akeyPosition, Color.White);
                spriteBatch.Draw(skeyTexture, skeyPosition, Color.White);
                spriteBatch.Draw(dkeyTexture, dkeyPosition, Color.White);
                spriteBatch.Draw(wkeyTexture, wkeyPosition, Color.White);
                spriteBatch.Draw(keyboardspcTexture, keyboardspcPosition, Color.White);
                spriteBatch.Draw(spacekeyTexture, spacekeyPosition, Color.White);


            }

            spriteBatch.Draw(pointerTexture, pointerPosition, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}