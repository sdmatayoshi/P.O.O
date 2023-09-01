using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        // Encarga de dibujar las texturas en pantalla.
        private SpriteBatch _spriteBatch;
        // Crea la variable de textura 2D "pruebas".
        private Texture2D _monoTexture;
        private Texture2D _slimeTexture;
        private Texture2D _slashTexture;
        private Texture2D _shieldTexture;
        private Texture2D _potionTexture;
        // Crea la variable de posición de "pruebas"
        private Vector2 _monoPosition;
        private Vector2 _slimePosition;
        private Vector2 _slashPosition;
        private Vector2 _shieldPosition;
        private Vector2 _potionPosition;
        // Crea la variable de la velocidad en la que se moverá el sprite.
        private Vector2 _monoSpeed = new Vector2(3, 3);

        private Texture2D _plantTexture;
        private Vector2 _plantPosition;

        private Song _backgroundMusic;

        private bool _plantTocada = false; // Bandera para controlar si se tocó la manzana
        
        private SpriteFont _font;
        private int score = 0;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Permite calcular los graficos(?)
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // Carga la textura "pruebas" en la variable.
            _monoTexture = Content.Load<Texture2D>("img/mono2");
            _slimeTexture = Content.Load<Texture2D>("img/slime1");
            _slashTexture = Content.Load<Texture2D>("img/atkr5");
            _shieldTexture = Content.Load<Texture2D>("img/shieldn");
            _potionTexture = Content.Load<Texture2D>("img/heal");
            // Define la posición de inicio del sprite "pruebas".
            _monoPosition = new Vector2(100, 100);
            _slashPosition = _monoPosition;
            _shieldPosition = _monoPosition;
            _potionPosition = new(GraphicsDevice.Viewport.Width / 2 - _potionTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - _potionTexture.Height / 2);
            _slimePosition = new(GraphicsDevice.Viewport.Width / 2 - _slimeTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - _slimeTexture.Height / 2);
            // Carga las textura "manzana" en la variable.
            _plantTexture = Content.Load<Texture2D>("img/plant");
            _potionTexture = Content.Load<Texture2D>("img/heal");
            // (?)
            _plantPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - _plantTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - _plantTexture.Height / 2);
            _font = Content.Load<SpriteFont>("img/Score");
            //_backgroundMusic = Content.Load<Song>("background_music");
            //MediaPlayer.Play(_backgroundMusic);
            //MediaPlayer.IsRepeating = true;
            
        }
        int _score = 0; int n = 2; int natk = 1; bool atk = false; int _hp = 100;
        int _slimehp = 100; bool enemy_appear = false; bool def = false; bool potion = false;
        int look = 0;
        int cont = 0;
        protected override void Update(GameTime gameTime)
        {
            cont++;
            // Se utiliza para poder recibir el estado del teclado.
            KeyboardState keyboardState = Keyboard.GetState();
            // Se ejecuta cuando la variable _manzanaTocada es "false".
            if (keyboardState.IsKeyDown(Keys.A))
            {
                look = 1;
                if (cont == 16)
                {
                _monoTexture = Content.Load<Texture2D>("img/monol"+n);
                    cont = 0;
                }
                
                if (!keyboardState.IsKeyDown(Keys.LeftControl) && !def)
                {
                    _monoPosition.X -= 2;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else
                if (keyboardState.IsKeyDown(Keys.LeftControl)&& !def)
                {
                    _monoPosition.X -= 3;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }else if (!keyboardState.IsKeyDown(Keys.LeftControl) && def)
                {
                    _monoPosition.X -= 1;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else if (keyboardState.IsKeyDown(Keys.LeftControl) && def)
                {
                    _monoPosition.X -= 2;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                if (_monoPosition.X <= 0)
                {
                    _monoPosition.X = GraphicsDevice.Viewport.Width;
                }
                if (n == 4)
                {
                    n = 0;
                }
                n++;
            }
            if (keyboardState.IsKeyDown(Keys.D))
            {
                look = 2;
                _monoTexture = Content.Load<Texture2D>("img/monor" + n);
                if (!keyboardState.IsKeyDown(Keys.LeftControl) && !def)
                {
                    _monoPosition.X += 2;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else
                if (keyboardState.IsKeyDown(Keys.LeftControl))
                {
                    _monoPosition.X += 3;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else if (!keyboardState.IsKeyDown(Keys.LeftControl) && def)
                {
                    _monoPosition.X += 1;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else if (keyboardState.IsKeyDown(Keys.LeftControl) && def)
                {
                    _monoPosition.X += 2;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                if (_monoPosition.X >= GraphicsDevice.Viewport.Width)
                {
                    _monoPosition.X = 0;
                }
                if (n == 4)
                {
                    n = 0;
                }
                n++;
            }
            if (keyboardState.IsKeyDown(Keys.W))
            {
                look = 3;
                _monoTexture = Content.Load<Texture2D>("img/monob"+n);

                if (!keyboardState.IsKeyDown(Keys.LeftControl) && !def)
                {
                    _monoPosition.Y -= 2;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else if (keyboardState.IsKeyDown(Keys.LeftControl))
                {
                    _monoPosition.Y -= 3;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else if (!keyboardState.IsKeyDown(Keys.LeftControl) && def)
                {
                    _monoPosition.Y -= 1;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else if (keyboardState.IsKeyDown(Keys.LeftControl) && def)
                {
                    _monoPosition.Y -= 2;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                if (_monoPosition.Y <= 0)
                {
                    _monoPosition.Y = GraphicsDevice.Viewport.Height;
                }
                if (n == 4)
                {
                    n = 0;
                }
                n++;

            }
            if (keyboardState.IsKeyDown(Keys.S))
            {
                look = 0;
                _monoTexture = Content.Load<Texture2D>("img/mono"+n);
                
                if (!keyboardState.IsKeyDown(Keys.LeftControl) && !def)
                {
                _monoPosition.Y += 2;
                _slashPosition = _monoPosition;
                _shieldPosition = _monoPosition;
                }
                else if (keyboardState.IsKeyDown(Keys.LeftControl))
                {
                    _monoPosition.Y += 3;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else if (!keyboardState.IsKeyDown(Keys.LeftControl) && def)
                {
                    _monoPosition.Y += 1;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                else if (keyboardState.IsKeyDown(Keys.LeftControl) && def)
                {
                    _monoPosition.Y += 2;
                    _slashPosition = _monoPosition;
                    _shieldPosition = _monoPosition;
                }
                if (_monoPosition.Y >= GraphicsDevice.Viewport.Height)
                {
                    _monoPosition.Y = 0;
                }
                if (n == 4)
                {
                    n = 0;
                }
                n++;
            }



            if (look == 1 && keyboardState.IsKeyDown(Keys.Space))
            {
                atk = true;
                def = false;
                _slashTexture = Content.Load<Texture2D>("img/atkl3");
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");

            }
            else if (look == 1 && !keyboardState.IsKeyDown(Keys.Space))
            {
                atk = false;
                _slashTexture = Content.Load<Texture2D>("img/atkl5");
            }

            if (look == 2 && keyboardState.IsKeyDown(Keys.Space))
            {
                atk = true;
                def = false;
                _slashTexture = Content.Load<Texture2D>("img/atkr3");
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");

            }
            else if (look == 2 && !keyboardState.IsKeyDown(Keys.Space))
            {
                atk = false;
                _slashTexture = Content.Load<Texture2D>("img/atkr5");
            }

            if (look == 3 && keyboardState.IsKeyDown(Keys.Space))
            {
                atk = true;
                def = false;
                _slashTexture = Content.Load<Texture2D>("img/atku3");
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");

            }
            else if (look == 3 && !keyboardState.IsKeyDown(Keys.Space))
            {
                atk = false;
                _slashTexture = Content.Load<Texture2D>("img/atku5");
            }

            if (look == 0 && keyboardState.IsKeyDown(Keys.Space))
            {
                atk = true;
                def = false;
                _slashTexture = Content.Load<Texture2D>("img/atkb3");
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");

            }
            else if (look == 0 && !keyboardState.IsKeyDown(Keys.Space))
            {
                atk = false;
                _slashTexture = Content.Load<Texture2D>("img/atkb5");
            }

            if (look == 1 && keyboardState.IsKeyDown(Keys.Space))
            {
                atk = true;
                def = false;
                _slashTexture = Content.Load<Texture2D>("img/atkl3");
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");

            }
            else if (look == 1 && !keyboardState.IsKeyDown(Keys.Space))
            {
                atk = false;
                _slashTexture = Content.Load<Texture2D>("img/atkl5");
            }

            if (look == 2 && keyboardState.IsKeyDown(Keys.Space))
            {
                atk = true;
                def = false;
                _slashTexture = Content.Load<Texture2D>("img/atkr3");
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");

            }
            else if (look == 2 && !keyboardState.IsKeyDown(Keys.Space))
            {
                atk = false;
                _slashTexture = Content.Load<Texture2D>("img/atkr5");
            }







            if (look == 3 && keyboardState.IsKeyDown(Keys.LeftShift) && !atk)
            {
                def = true;
                _shieldTexture = Content.Load<Texture2D>("img/shieldu");

            }
            else if (look == 3 && (!keyboardState.IsKeyDown(Keys.LeftShift) && atk)||(!keyboardState.IsKeyDown(Keys.LeftShift)))
            {
                def = false;
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");
            }

            if (look == 0 && keyboardState.IsKeyDown(Keys.LeftShift) && !atk)
            {
                def = true;
                _shieldTexture = Content.Load<Texture2D>("img/shieldb");

            }
            else if (look == 0 && (!keyboardState.IsKeyDown(Keys.LeftShift) && atk) || (!keyboardState.IsKeyDown(Keys.LeftShift)))
            {
                def = false;
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");
            }

            if (look == 1 && keyboardState.IsKeyDown(Keys.LeftShift) && !atk)
            {
                def = true;
                _shieldTexture = Content.Load<Texture2D>("img/shieldl");

            }
            else if (look == 1 && (!keyboardState.IsKeyDown(Keys.LeftShift) && atk) || (!keyboardState.IsKeyDown(Keys.LeftShift)))
            {
                def = false;
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");
            }
            if (look == 2 && keyboardState.IsKeyDown(Keys.LeftShift) && !atk)
            {
                def = true;
                _shieldTexture = Content.Load<Texture2D>("img/shieldr");

            }
            else if (look == 2 && (!keyboardState.IsKeyDown(Keys.LeftShift) && atk) || (!keyboardState.IsKeyDown(Keys.LeftShift)))
            {
                def = false;
                _shieldTexture = Content.Load<Texture2D>("img/shieldn");
            }



            if ((keyboardState.IsKeyDown(Keys.A)|| keyboardState.IsKeyDown(Keys.S)|| keyboardState.IsKeyDown(Keys.D)|| keyboardState.IsKeyDown(Keys.W)) && enemy_appear==true)
            {
               
                    Random rn = new Random();
                    int pos = rn.Next(1, 4);
                    if (pos == 1)
                    {
                        _slimePosition.X -= 3;
                    if (_slimePosition.X <= 0)
                    {
                        _slimePosition.X = GraphicsDevice.Viewport.Width;
                    }
                }
                    else if (pos == 2)
                    {
                        _slimePosition.X += 3;
                    if (_slimePosition.X >= GraphicsDevice.Viewport.Width)
                    {
                        _slimePosition.X = 0;
                    }
                }
                    else if (pos == 3)
                    {
                        _slimePosition.Y += 3;
                    if (_slimePosition.Y >= GraphicsDevice.Viewport.Height)
                    {
                        _slimePosition.Y = 0;
                    }
                }
                    else
                    {
                        _slimePosition.Y -= 3;
                    if (_slimePosition.Y <= 0)
                    {
                        _slimePosition.Y = GraphicsDevice.Viewport.Height;
                    }
                }
            }


            // Verificar colisión con la manzana
            Rectangle monoRectangle = new Rectangle((int)_monoPosition.X, (int)_monoPosition.Y, _monoTexture.Width, _monoTexture.Height);
            Rectangle atkRectangle = new Rectangle((int)_slashPosition.X, (int)_slashPosition.Y, _slashTexture.Width, _slashTexture.Height);
            // Es la caja de coliciones de "pruebas" y se basa en el tamaño de la imgane.

            Rectangle plantRectangle = new Rectangle((int)_plantPosition.X, (int)_plantPosition.Y, _plantTexture.Width, _plantTexture.Height);
            Rectangle slimeRectangle = new Rectangle((int)_slimePosition.X, (int)_slimePosition.Y, _slimeTexture.Width, _slimeTexture.Height);
            Rectangle potionRectangle = new Rectangle((int)_potionPosition.X, (int)_potionPosition.Y, _potionTexture.Width, _potionTexture.Height);
            // Es la caja de coliciones de "manzana" y se basa en el tamaño de la imgane.

            if (atkRectangle.Intersects(plantRectangle) && atk)
                {
                    _plantTocada = true;
            }
            if (monoRectangle.Intersects(potionRectangle) && !atk && !def && potion && _hp<100)
            {
                potion = false;
                _hp = _hp + 30;
                if (_hp>100)
                {
                    _hp = 100;
                }
            }
            if (slimeRectangle.Intersects(monoRectangle)&& !def && enemy_appear)
            {
                _hp --;
                Random rn = new Random();
                int dda = rn.Next(1, 3);
                if (dda==2||dda==3)
                {
                    _hp++;
                }
            }
            if (_plantTocada)
            {
                Random rn = new Random();
                int posx = rn.Next(1,GraphicsDevice.Viewport.Width);
                int posy = rn.Next(1, GraphicsDevice.Viewport.Height);
                _plantPosition = new Vector2(posx,posy);
                _score ++;
                int r = rn.Next(1, 4);
                if (r == 2 && !potion)
                {
                    potion = true;
                }
                else if (r == 3 && !enemy_appear)
                {
                    enemy_appear = true;
                }
                _plantTocada = false;
            }
            if (atkRectangle.Intersects(slimeRectangle) && atk)
            {
                _slimehp--;
            }
            if (_slimehp <= 0)
            {
                enemy_appear = false;
                Random rn = new Random();
                int r = rn.Next(1, 4);
                if (r == 2 && potion ==false)
                {
                    potion = true;
                }
                _slimehp = 100;
                score = score + 5;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.DrawString(_font, "Score: "+ _score, new Vector2(100, 10), Color.Black);
            _spriteBatch.DrawString(_font, "Hp: " + _hp, new Vector2(10, 10), Color.Black);
            
            _spriteBatch.Draw(_monoTexture, _monoPosition, Color.White);
            if (enemy_appear)
            {
                _spriteBatch.DrawString(_font, "Slime: " + _slimehp, new (_slimePosition.X, _slimePosition.Y+30), Color.Black);
                _spriteBatch.Draw(_slimeTexture, _slimePosition, Color.White);
            }
            if (potion)
            {
                
                _spriteBatch.Draw(_potionTexture, _potionPosition, Color.White);
            }

            _spriteBatch.Draw(_slashTexture, _slashPosition, Color.White);
            _spriteBatch.Draw(_shieldTexture, _shieldPosition, Color.White);
            if (!_plantTocada)
                _spriteBatch.Draw(_plantTexture, _plantPosition, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}