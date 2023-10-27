using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Net.Mail;
using static System.Formats.Asn1.AsnWriter;

namespace Ningyou_geki
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D charTexture;
        private Vector2 charPosition;
        private Texture2D enemyTexture;
        private Vector2 enemyPosition;
        private Texture2D charhitboxTexture;
        private Vector2 charhitboxPosition;
        private Texture2D stickTexture;
        private Vector2 stickPosition;
        private Texture2D floorTexture;
        private Vector2 floorPosition;
        private Texture2D floorTexture2;
        private Vector2 floorPosition2;
        private Texture2D slashTexture;
        private Vector2 slashPosition;
        private SpriteFont debug_font;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            charTexture = Content.Load<Texture2D>("resources/char-right");
            charPosition = new Vector2(100, 240);
            enemyTexture = Content.Load<Texture2D>("resources/char-up");
            enemyPosition = new Vector2(600, 218);
            charhitboxTexture = Content.Load<Texture2D>("resources/char-hitbox");
            charhitboxPosition = charPosition;
            stickTexture = Content.Load<Texture2D>("resources/stick");
            stickPosition = new Vector2(charPosition.X + 13, charPosition.Y + 30);
            floorTexture = Content.Load<Texture2D>("resources/floor-temp");
            floorPosition = new Vector2(100, 300);
            floorTexture2 = Content.Load<Texture2D>("resources/floor-temp");
            floorPosition2 = new Vector2(300, 250);
            slashTexture = Content.Load<Texture2D>("resources/slash-n");
            slashPosition = new Vector2(charPosition.X + 20, charPosition.Y + 20);
            debug_font = Content.Load<SpriteFont>("resources/debug");
        }
        bool ground = true; bool jump = false; int gravity = 1; int contgrav = 0; int swip = 0;
        int contjmp = 0; int air = 0;
        int look = 1; int airtime = 0; bool attack = false;
        int attacktime = 0; int pdmgtime = 0;
        bool game_over = false;
        int enemyhp = 0; int enemydmg = 0;
        int enemymove = 0;
        int enPos = 0;
        protected override void Update(GameTime gameTime)
        {
            Rectangle charRectangle = new Rectangle((int)charhitboxPosition.X, (int)charhitboxPosition.Y, charhitboxTexture.Width, charhitboxTexture.Height);
            Rectangle floorRectangle = new Rectangle((int)floorPosition.X, (int)floorPosition.Y, floorTexture.Width, floorTexture.Height);
            Rectangle floorRectangle2 = new Rectangle((int)floorPosition2.X, (int)floorPosition2.Y, floorTexture2.Width, floorTexture2.Height);
            Rectangle slashRectangle = new Rectangle((int)slashPosition.X, (int)slashPosition.Y, slashTexture.Width, slashTexture.Height);

            Rectangle enemyRectangle = new Rectangle((int)enemyPosition.X, (int)enemyPosition.Y, enemyTexture.Width, enemyTexture.Height);

            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.A)&& !game_over)
            {
                look = 2;
                charPosition.X -= 2;
                stickPosition = new Vector2(charPosition.X + 13, charPosition.Y + 30);
                slashPosition = new Vector2(charPosition.X - 30, charPosition.Y);
                charhitboxPosition = charPosition;
            }
            if (keyboardState.IsKeyDown(Keys.D)&&!game_over)
            {
                look = 1;
                charPosition.X += 2;
                stickPosition = new Vector2(charPosition.X + 13, charPosition.Y + 30);
                slashPosition = new Vector2(charPosition.X + 20, charPosition.Y);
                charhitboxPosition = charPosition;
            }

            if (enemymove>10)
            {
                enPos++;
                if (enPos<10)
                {
                    
                    enemyPosition.X += 2;
                }
                else if (enPos > 10)
                {
                    enemyPosition.X -= 2;
                } 
                if (enPos >= 20)
                {
                    enPos=0;
                }
                
                
                enemymove =0;
            }
            
            if (slashRectangle.Intersects(enemyRectangle) &&pdmgtime>20&&attack)
            {
                enemyhp++;
                pdmgtime = 0;
                enemydmg = 0;
            }
            else
            {
                ground = false;
            }

            if (charRectangle.Intersects(enemyRectangle) && charPosition.X < enemyPosition.X)
            {
                
                charPosition.X -= 10;
                
            }
            else if (charRectangle.Intersects(enemyRectangle) && charPosition.X > enemyPosition.X)
            {
                float cpx = charPosition.X;
                charPosition.X += 10;
            }

            if (charRectangle.Intersects(floorRectangle) || charRectangle.Intersects(floorRectangle2))
            {
                ground = true;
                airtime = 0;
            }
            if (keyboardState.IsKeyDown(Keys.H) && !game_over && attacktime>25)
            {
                attack = true;
                attacktime = 0;
            }
            if (attacktime >20)
            {
                attack=false;
            }
            if (enemydmg > 100)
            {
                enemyhp = 0;
            }
            if (look == 1)
            {
                slashPosition.Y = charPosition.Y;
                charTexture = Content.Load<Texture2D>("resources/char-right");
                if (attack)
                {
                    if (attacktime<20)
                    {
                        slashTexture = Content.Load<Texture2D>("resources/slash-r");
                        slashPosition.X = charPosition.X + 20;
                    }
                }
                else if (!attack)
                {
                    slashTexture = Content.Load<Texture2D>("resources/slash-n");
                    slashPosition.X = charPosition.X + 20;
                }
                 if (!ground)
                {
                    if (attack)
                    {
                        charTexture = Content.Load<Texture2D>("resources/char-jump-attack-right");
                    }
                    else
                    {
                        charTexture = Content.Load<Texture2D>("resources/char-jump-right");
                    }
                }
                else
                {
                    if (attack)
                    {
                        charTexture = Content.Load<Texture2D>("resources/char-attack-right");
                    }
                    else
                    {
                        charTexture = Content.Load<Texture2D>("resources/char-right");
                    }
                }
            }
            if (look == 2)
            {
                slashPosition.Y = charPosition.Y;
                charTexture = Content.Load<Texture2D>("resources/char-left");
                if (attack)
                {
                    if (!ground)
                    {
                        charTexture = Content.Load<Texture2D>("resources/char-jump-attack-left");
                    }
                    slashTexture = Content.Load<Texture2D>("resources/slash-l");
                    slashPosition.X = charPosition.X - 20;
                }
                else if (!attack)
                {
                    slashTexture = Content.Load<Texture2D>("resources/slash-n");
                    slashPosition.X = charPosition.X - 30;
                }
                if (!ground)
                {
                    if (attack)
                    {
                        charTexture = Content.Load<Texture2D>("resources/char-jump-attack-left");
                    }
                    else
                    {
                    charTexture = Content.Load<Texture2D>("resources/char-jump-left");
                    }
                    
                }
                else
                {
                    if (attack)
                    {
                        charTexture = Content.Load<Texture2D>("resources/char-attack-left");
                    }
                    else
                    {
                        charTexture = Content.Load<Texture2D>("resources/char-left");
                    }
                }

            }

            
                
            
           


            if (keyboardState.IsKeyDown(Keys.Space)&&airtime<20)
            {
                jump = true;
                charPosition.Y -= 7;
                stickPosition = new Vector2(charPosition.X + 13, charPosition.Y + 30);
                charhitboxPosition = charPosition;
                airtime++;
                if (airtime>=20)
                {
                    jump = false;
                }
            }
            if (!keyboardState.IsKeyDown(Keys.Space))
            {
                    jump = false;
                
            }
            if ((!jump && airtime <= 20 && !ground)||(!jump&&!ground&&airtime<=20))
            {

                charPosition.Y += 7;
                stickPosition = new Vector2(charPosition.X + 13, charPosition.Y + 30);
                charhitboxPosition = charPosition;
            }
            if (charPosition.Y>650)
            {
                game_over = true;
                charPosition.Y = 650;
                attacktime = 0;
            }
            enemymove++;
            pdmgtime++;
            contjmp++;
            contgrav++;
            attacktime++;
            enemydmg++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(stickTexture, stickPosition, Color.White);
            _spriteBatch.Draw(charTexture, charPosition, Color.White);
            _spriteBatch.Draw(enemyTexture, enemyPosition, Color.White);
            _spriteBatch.Draw(slashTexture, slashPosition, Color.White);
            

            _spriteBatch.Draw(floorTexture, floorPosition, Color.White);
            _spriteBatch.Draw(floorTexture2, floorPosition2, Color.White);
            if (game_over)
            {
                _spriteBatch.DrawString(debug_font, "GAME OVER", new Vector2(GraphicsDevice.Viewport.Width / 2 - enemyTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - enemyTexture.Height / 2), Color.Black);
            }
            
            _spriteBatch.DrawString(debug_font, "ground: " + ground, new Vector2(0, 10), Color.Black);
            _spriteBatch.DrawString(debug_font, "jump: " + jump, new Vector2(150, 10), Color.Black);
            _spriteBatch.DrawString(debug_font, "dmgtime: " + pdmgtime, new Vector2(300, 10), Color.Black);
            _spriteBatch.DrawString(debug_font, "attack: " + attack, new Vector2(450, 10), Color.Black);
            _spriteBatch.DrawString(debug_font, "enPos: " + enPos, new Vector2(600, 10), Color.Black);
            _spriteBatch.DrawString(debug_font, "X: " + charPosition.X, new Vector2(0, 20), Color.Black);
            _spriteBatch.DrawString(debug_font, "Y: " + charPosition.Y, new Vector2(150, 20), Color.Black);
            _spriteBatch.DrawString(debug_font, "DMG: " + enemyhp, new Vector2(enemyPosition.X-5, enemyPosition.Y-20), Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}