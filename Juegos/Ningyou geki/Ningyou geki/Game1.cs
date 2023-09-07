using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static System.Formats.Asn1.AsnWriter;

namespace Ningyou_geki
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D charTexture;
        private Vector2 charPosition;
        private Texture2D charhitboxTexture;
        private Vector2 charhitboxPosition;
        private Texture2D stickTexture;
        private Vector2 stickPosition;
        private Texture2D floorTexture;
        private Vector2 floorPosition;
        private Texture2D floorTexture2;
        private Vector2 floorPosition2;
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
            charhitboxTexture = Content.Load<Texture2D>("resources/char-hitbox");
            charhitboxPosition = charPosition;
            stickTexture = Content.Load<Texture2D>("resources/stick");
            stickPosition = new Vector2(charPosition.X + 13, charPosition.Y+30);
            floorTexture = Content.Load<Texture2D>("resources/floor-temp");
            floorPosition = new Vector2(100, 300);
            floorTexture2 = Content.Load<Texture2D>("resources/floor-temp");
            floorPosition2 = new Vector2(300, 250);
            debug_font = Content.Load<SpriteFont>("resources/debug");
        }
        bool ground = true;bool jump = false;int gravity = 1;int contgrav = 0;int swip = 0;
        int contjmp = 0; int air = 0;
        int look = 1;
        protected override void Update(GameTime gameTime)
        {
            Rectangle charRectangle = new Rectangle((int)charhitboxPosition.X, (int)charhitboxPosition.Y, charhitboxTexture.Width, charhitboxTexture.Height);
            Rectangle floorRectangle = new Rectangle((int)floorPosition.X, (int)floorPosition.Y, floorTexture.Width, floorTexture.Height);
            Rectangle floorRectangle2 = new Rectangle((int)floorPosition2.X, (int)floorPosition2.Y, floorTexture2.Width, floorTexture2.Height);

            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.A))
            {
                look = 2;

                charPosition.X -= 2;
                stickPosition = new Vector2(charPosition.X + 13, charPosition.Y + 30);
                charhitboxPosition = charPosition;
            }
            if (keyboardState.IsKeyDown(Keys.D))
            {
                look = 1;
                charPosition.X += 2;
                stickPosition = new Vector2(charPosition.X + 13, charPosition.Y + 30);
                charhitboxPosition = charPosition;
            }
            if (look == 2)
            {
                charTexture = Content.Load<Texture2D>("resources/char-left");
            }
            if (look == 1)
            {
                charTexture = Content.Load<Texture2D>("resources/char-right");
            }
            if (charRectangle.Intersects(floorRectangle)|| charRectangle.Intersects(floorRectangle2))
            {
                ground = true;
            }
            else
            {
                ground = false;
            }


            if (!ground&&!jump)
            {
                
                charPosition.Y += 7;
                stickPosition = new Vector2(charPosition.X+13, charPosition.Y + 30);
                charhitboxPosition = charPosition;
            }
            if (jump)
            {
                charPosition.Y -= 7;
                stickPosition = new Vector2(charPosition.X + 13, charPosition.Y + 30);
                charhitboxPosition = charPosition;
                air++;
                if (air>10)
                {
                    jump = false;
                    air = 0;
                }

            }
            //if (look == 2)
            //{
            //    charTexture = Content.Load<Texture2D>("resources/char-jump-left");
            //}
            //else
            //{
            //    charTexture = Content.Load<Texture2D>("resources/char-jump-right");
            //}

            if (keyboardState.IsKeyDown(Keys.Space) && ground)
            {
                ground = false;
                jump = true;
                
            }
            contjmp++;
            contgrav++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(stickTexture, stickPosition, Color.White);
            _spriteBatch.Draw(charTexture, charPosition, Color.White);
            
            _spriteBatch.Draw(floorTexture, floorPosition, Color.White);
            _spriteBatch.Draw(floorTexture2, floorPosition2, Color.White);
            _spriteBatch.DrawString(debug_font, "ground: " + ground, new Vector2(0, 10), Color.Black);
            _spriteBatch.DrawString(debug_font, "jump: " + jump, new Vector2(150, 10), Color.Black);
            _spriteBatch.DrawString(debug_font, "air: " + air, new Vector2(300, 10), Color.Black);
            _spriteBatch.DrawString(debug_font, "look: " + look, new Vector2(450, 10), Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}