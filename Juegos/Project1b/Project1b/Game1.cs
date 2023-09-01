using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System;
using System.Reflection.Metadata;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        // Encarga de dibujar las texturas en pantalla.
        private SpriteBatch _spriteBatch;
        // Crea la variable de textura 2D "pruebas".
        private Texture2D _monoTexture;
        private Texture2D _monohitTexture;
        private Texture2D _slimeTexture;
        private Texture2D _slashTexture;
        private Texture2D _shieldTexture;
        private Texture2D _potionTexture;
        private Texture2D _dragonTexture;
        // Crea la variable de posición de "pruebas"
        private Vector2 _monoPosition;
        private Vector2 _monohitPosition;
        private Vector2 _slimePosition;
        private Vector2 _slashPosition;
        private Vector2 _shieldPosition;
        private Vector2 _potionPosition;
        private Vector2 _dragonPosition;
        // Crea la variable de la velocidad en la que se moverá el sprite.
        private Vector2 _monoSpeed = new Vector2(3, 3);

        private Texture2D _plantTexture;
        private Vector2 _plantPosition;

        //private Song _backgroundMusic;

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
            _monohitTexture = Content.Load<Texture2D>("resources/img/mono/monohitbox");
            _monoTexture = Content.Load<Texture2D>("resources/img/mono/mono2");
            _slimeTexture = Content.Load<Texture2D>("resources/img/slime/slime1");
            _slashTexture = Content.Load<Texture2D>("resources/img/attack/atkr5");
            _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
            _potionTexture = Content.Load<Texture2D>("resources/img/heal");
            _dragonTexture = Content.Load<Texture2D>("resources/img/dragon1");
            // Define la posición de inicio del sprite "pruebas".
            _monoPosition = new Vector2(100, 100);
            _monohitPosition = _monoPosition;
            _slashPosition = _monoPosition;
            _shieldPosition = _monoPosition;
            _potionPosition = new(GraphicsDevice.Viewport.Width / 2 - _potionTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - _potionTexture.Height / 2);
            _slimePosition = new(GraphicsDevice.Viewport.Width / 2 - _slimeTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - _slimeTexture.Height / 2);
            _dragonPosition = new(GraphicsDevice.Viewport.Width / 2 - _slimeTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - _slimeTexture.Height / 2);
            // Carga las textura "manzana" en la variable.
            _plantTexture = Content.Load<Texture2D>("resources/img/plant");
            _potionTexture = Content.Load<Texture2D>("resources/img/heal");
            // (?)
            _plantPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - _plantTexture.Width / 2, GraphicsDevice.Viewport.Height / 2 - _plantTexture.Height / 2);
            _font = Content.Load<SpriteFont>("resources/img/Score");
            //_backgroundMusic = Content.Load<Song>("background_music");
            //MediaPlayer.Play(_backgroundMusic);
            //MediaPlayer.IsRepeating = true;

        }
        int _score = 0;int n = 2;int natk = 1;bool atk = false;int _hp = 10;int _slimehp = 5;bool enemy_appear = false;bool def = false;bool potion = false;
        bool death = false;int look = 0;int cont = 0;int contslime = 0;bool getpotion = false;int contglob=0;int time = 0;int cantgrass = 1;int contatk=0;
        int contdamage = 0;int contenemy = 0;int conttick = 0;int dragonhp = 30;int contdr = 0;bool dragon_appear = false;
        protected override void Update(GameTime gameTime)
        {
            
            // Se utiliza para poder recibir el estado del teclado.
            KeyboardState keyboardState = Keyboard.GetState();
            // Se ejecuta cuando la variable _manzanaTocada es "false".
            if (!death)
            {


                if (keyboardState.IsKeyDown(Keys.A))
                {
                    look = 1;
                    if (cont >= 3)
                    {
                        _monoTexture = Content.Load<Texture2D>("resources/img/mono/monol" + n);
                        cont = 0;
                    }

                    if (!keyboardState.IsKeyDown(Keys.LeftControl) && !def)
                    {
                        _monoPosition.X -= 2;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else
                    if (keyboardState.IsKeyDown(Keys.LeftControl) && !def)
                    {
                        _monoPosition.X -= 3;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (!keyboardState.IsKeyDown(Keys.LeftControl) && def)
                    {
                        _monoPosition.X -= 1;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (keyboardState.IsKeyDown(Keys.LeftControl) && def)
                    {
                        _monoPosition.X -= 2;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
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
                    if (cont >= 3)
                    {
                        _monoTexture = Content.Load<Texture2D>("resources/img/mono/monor" + n);
                        cont = 0;
                    }
                    if (!keyboardState.IsKeyDown(Keys.LeftControl) && !def)
                    {
                        _monoPosition.X += 2;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else
                    if (keyboardState.IsKeyDown(Keys.LeftControl))
                    {
                        _monoPosition.X += 3;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (!keyboardState.IsKeyDown(Keys.LeftControl) && def)
                    {
                        _monoPosition.X += 1;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (keyboardState.IsKeyDown(Keys.LeftControl) && def)
                    {
                        _monoPosition.X += 2;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
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
                    if (cont >= 3)
                    {
                        _monoTexture = Content.Load<Texture2D>("resources/img/mono/monob" + n);
                        cont = 0;
                    }

                    if (!keyboardState.IsKeyDown(Keys.LeftControl) && !def)
                    {
                        _monoPosition.Y -= 2;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (keyboardState.IsKeyDown(Keys.LeftControl))
                    {
                        _monoPosition.Y -= 3;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (!keyboardState.IsKeyDown(Keys.LeftControl) && def)
                    {
                        _monoPosition.Y -= 1;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (keyboardState.IsKeyDown(Keys.LeftControl) && def)
                    {
                        _monoPosition.Y -= 2;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
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
                    if (cont >= 3)
                    {
                        _monoTexture = Content.Load<Texture2D>("resources/img/mono/mono" + n);
                        cont = 0;
                    }

                    if (!keyboardState.IsKeyDown(Keys.LeftControl) && !def)
                    {
                        _monoPosition.Y += 2;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (keyboardState.IsKeyDown(Keys.LeftControl))
                    {
                        _monoPosition.Y += 3;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (!keyboardState.IsKeyDown(Keys.LeftControl) && def)
                    {
                        _monoPosition.Y += 1;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
                    }
                    else if (keyboardState.IsKeyDown(Keys.LeftControl) && def)
                    {
                        _monoPosition.Y += 2;
                        _slashPosition = _monoPosition;
                        _shieldPosition = _monoPosition;
                        _monohitPosition = new(_monoPosition.X + 15, _monoPosition.Y + 15);
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


                if (contatk > 50)
                {

                
                if (look == 1 && keyboardState.IsKeyDown(Keys.Space))
                {
                    atk = true;
                    def = false;
                    if (contatk >= 5)
                    {
                        _slashTexture = Content.Load<Texture2D>("resources/img/attack/atkl3");
                        _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
                            
contatk = 0;
                        
                    }


                }
                

                if (look == 2 && keyboardState.IsKeyDown(Keys.Space))
                {
                    atk = true;
                    def = false;
                    _slashTexture = Content.Load<Texture2D>("resources/img/attack/atkr3");
                    _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
                        contatk = 0;
                    }
                

                if (look == 3 && keyboardState.IsKeyDown(Keys.Space))
                {
                    atk = true;
                    def = false;
                    _slashTexture = Content.Load<Texture2D>("resources/img/attack/atku3");
                    _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
                        contatk = 0;
                    }
               

                if (look == 0 && keyboardState.IsKeyDown(Keys.Space))
                {
                    atk = true;
                    def = false;
                    _slashTexture = Content.Load<Texture2D>("resources/img/attack/atkb3");
                    _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
                        contatk = 0;
                    }
                

                if (look == 1 && keyboardState.IsKeyDown(Keys.Space))
                {
                    atk = true;
                    def = false;
                    _slashTexture = Content.Load<Texture2D>("resources/img/attack/atkl3");
                    _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
                        contatk = 0;
                    }
               

                if (look == 2 && keyboardState.IsKeyDown(Keys.Space))
                {
                    atk = true;
                    def = false;
                    _slashTexture = Content.Load<Texture2D>("resources/img/attack/atkr3");
                    _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
                        contatk = 0;
                    }
                


            }else
                {
                    if (contatk > 10)
                    {
                       atk = false;
                    _slashTexture = Content.Load<Texture2D>("resources/img/attack/atkr5");
                    }
                    
                }





                if (look == 3 && keyboardState.IsKeyDown(Keys.LeftShift) && !atk)
            {
                def = true;
                _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldu");

            }
            else if (look == 3 && (!keyboardState.IsKeyDown(Keys.LeftShift) && atk) || (!keyboardState.IsKeyDown(Keys.LeftShift)))
            {
                def = false;
                _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
            }

            if (look == 0 && keyboardState.IsKeyDown(Keys.LeftShift) && !atk)
            {
                def = true;
                _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldb");

            }
            else if (look == 0 && (!keyboardState.IsKeyDown(Keys.LeftShift) && atk) || (!keyboardState.IsKeyDown(Keys.LeftShift)))
            {
                def = false;
                _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
            }

            if (look == 1 && keyboardState.IsKeyDown(Keys.LeftShift) && !atk)
            {
                def = true;
                _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldl");

            }
            else if (look == 1 && (!keyboardState.IsKeyDown(Keys.LeftShift) && atk) || (!keyboardState.IsKeyDown(Keys.LeftShift)))
            {
                def = false;
                _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
            }
            if (look == 2 && keyboardState.IsKeyDown(Keys.LeftShift) && !atk)
            {
                def = true;
                _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldr");

            }
            else if (look == 2 && (!keyboardState.IsKeyDown(Keys.LeftShift) && atk) || (!keyboardState.IsKeyDown(Keys.LeftShift)))
            {
                def = false;
                _shieldTexture = Content.Load<Texture2D>("resources/img/shield/shieldn");
            }

            }

            if (enemy_appear == true || death)
            {

                Random rn = new Random();
                int pos = rn.Next(1, 5);
                if (pos == 2)
                {
                    if (contslime >= 5)
                    {
                        _slimePosition.X -= 3;
                        //_slimeTexture = Content.Load<Texture2D>("resources/img/slime/slime6");
                        contslime = 0;
                    }

                    if (_slimePosition.X <= 0)
                    {
                        _slimePosition.X = GraphicsDevice.Viewport.Width;
                    }

                }
                else if (pos == 3)
                {
                    if (contslime >= 5)
                    {
                        _slimePosition.X += 3;
                        contslime = 0;
                    }
                    if (_slimePosition.X >= GraphicsDevice.Viewport.Width)
                    {
                        _slimePosition.X = 0;
                    }
                }
                else if (pos == 4)
                {
                    if (contslime >= 5)
                    {
                        _slimePosition.Y += 3;
                        contslime = 0;
                    }
                    if (_slimePosition.Y >= GraphicsDevice.Viewport.Height)
                    {
                        _slimePosition.Y = 0;
                    }
                }
                else
                {
                    if (contslime >= 5)
                    {
                        {
                            _slimePosition.Y -= 3;
                            contslime = 0;
                        }
                        if (_slimePosition.Y <= 0)
                        {
                            _slimePosition.Y = GraphicsDevice.Viewport.Height;
                        }
                    }
                }
                
            }


            if (dragon_appear == true || death)
            {

                Random rn = new Random();
                int pos = rn.Next(1, 5);
                if (pos == 2)
                {
                    if (contdr >= 5)
                    {
                        _dragonPosition.X -= 5;
                        contdr = 0;
                    }

                    if (_dragonPosition.X <= 0)
                    {
                        _dragonPosition.X = GraphicsDevice.Viewport.Width;
                    }

                }
                else if (pos == 3)
                {
                    if (contdr >= 5)
                    {
                        _dragonPosition.X += 5;
                        contslime = 0;
                    }
                    if (_dragonPosition.X >= GraphicsDevice.Viewport.Width)
                    {
                        _dragonPosition.X = 0;
                    }
                }
                else if (pos == 4)
                {
                    if (contdr >= 5)
                    {
                        _dragonPosition.Y += 5;
                        contdr = 0;
                    }
                    if (_dragonPosition.Y >= GraphicsDevice.Viewport.Height)
                    {
                        _dragonPosition.Y = 0;
                    }
                }
                else
                {
                    if (contdr >= 5)
                    {
                        {
                            _dragonPosition.Y -= 5;
                            contdr = 0;
                        }
                        if (_dragonPosition.Y <= 0)
                        {
                            _dragonPosition.Y = GraphicsDevice.Viewport.Height;
                        }
                    }
                }

            }


            // Verificar colisión con la manzana
            Rectangle monoRectangle = new Rectangle((int)_monohitPosition.X, (int)_monohitPosition.Y, _monohitTexture.Width, _monohitTexture.Height);
            Rectangle atkRectangle = new Rectangle((int)_slashPosition.X, (int)_slashPosition.Y, _slashTexture.Width, _slashTexture.Height);
            // Es la caja de coliciones de "pruebas" y se basa en el tamaño de la imgane.

            Rectangle plantRectangle = new Rectangle((int)_plantPosition.X, (int)_plantPosition.Y, _plantTexture.Width, _plantTexture.Height);
            Rectangle slimeRectangle = new Rectangle((int)_slimePosition.X, (int)_slimePosition.Y, _slimeTexture.Width, _slimeTexture.Height);
            Rectangle dragonRectangle = new Rectangle((int)_dragonPosition.X, (int)_dragonPosition.Y, _dragonTexture.Width, _dragonTexture.Height);
            Rectangle potionRectangle = new Rectangle((int)_potionPosition.X, (int)_potionPosition.Y, _potionTexture.Width, _potionTexture.Height);
            // Es la caja de coliciones de "manzana" y se basa en el tamaño de la imgane.

            if (atkRectangle.Intersects(plantRectangle) && atk)
            {
                _plantTocada = true;
            }
            if (monoRectangle.Intersects(potionRectangle) && !atk && !def && potion && _hp < 10)
            {
               
                potion = false;
                _hp = _hp + 3;
                if (_hp > 10)
                {
                    _hp = 10;
                }
            }
            if (monoRectangle.Intersects(potionRectangle) && potion){
                getpotion = true;
            }

            if (slimeRectangle.Intersects(monoRectangle) && !def && enemy_appear)
            {
                if (contenemy > 20)
                {
                    _hp--;
                Random rn = new Random();
                int dda = rn.Next(1, 3);
                if (dda == 2)
                {
                    _hp++;
                }
                }
                if (contenemy>20){
                    contenemy = 0;
                }
            }
            if (dragonRectangle.Intersects(monoRectangle) && !def && dragon_appear)
            {
                if (contdr > 20)
                {
                    _hp = _hp - 2;
                    Random rn = new Random();
                    int dda = rn.Next(1, 3);
                    if (dda == 2)
                    {
                        _hp++;
                    }
                }
                if (contdr > 20)
                {
                    contdr = 0;
                }
            }

            if (atkRectangle.Intersects(slimeRectangle) && atk && contdamage > 50)
            {
                _slimehp--;
                if (contdamage > 50)
                {
                    contdamage = 0;
                }
            }
            if (atkRectangle.Intersects(dragonRectangle) && atk && contdamage > 50)
            {
                dragonhp--;
                if (contdamage > 50)
                {
                    contdamage = 0;
                }
            }


            if (_slimehp <= 0)
            {
                score = score + 5;
                enemy_appear = false;
                Random rn = new Random();
                int r = rn.Next(1, 4);
                if (r == 2 && potion == false)
                {
                    potion = true;
                }
                _slimehp = 5;

            }
            if (dragonhp <= 0)
            {
                score = score + 10;
                dragon_appear = false;
                Random rn = new Random();
                int r = rn.Next(1, 4);
                if (r == 2 && potion == false)
                {
                    potion = true;
                }
                dragonhp = 30;

            }


            if (_plantTocada)
            {
                Random rn = new Random();
                int posx = rn.Next(1, GraphicsDevice.Viewport.Width);
                int posy = rn.Next(1, GraphicsDevice.Viewport.Height);
                _plantPosition = new Vector2(posx, posy);
                _score++;
                int r = rn.Next(1, 5);
                if (r == 2 && !potion)
                {
                    potion = true;
                }
                else if (r == 3 && !enemy_appear)
                {
                    enemy_appear = true;
                }
                if (r == 4 && time >= 30 && !dragon_appear)
                {
                    dragon_appear = true;
                }
                _plantTocada = false;
            }
            if (_hp<=0){
                death = true;
                    _hp = 0;
                _monoTexture = Content.Load<Texture2D>("resources/img/mono/monodeath");
            }
            if (contglob>=50){
                time++;
                contglob = 0;
            }
            
            cont++;
            contslime++;
            contglob++;
            conttick++;
            contatk++;
            contdamage++;
            contenemy++;
            contdr++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.DrawString(_font, "Score: " + _score, new Vector2(100, 10), Color.Black);
            _spriteBatch.DrawString(_font, "Hp: " + _hp, new Vector2(10, 10), Color.Black);
            _spriteBatch.DrawString(_font, "Time: " + time, new Vector2(200, 10), Color.Black);

            _spriteBatch.DrawString(_font, "contslime: " + contslime, new Vector2(10, 110), Color.Black);
            _spriteBatch.DrawString(_font, "contatk: " + contatk, new Vector2(10, 120), Color.Black);
            _spriteBatch.DrawString(_font, "contdamage: " + contdamage, new Vector2(10, 130), Color.Black);
            _spriteBatch.DrawString(_font, "contenemy: " + contenemy, new Vector2(10, 140), Color.Black);
            _spriteBatch.DrawString(_font, "contdr: " + contdr, new Vector2(10, 150), Color.Black);

            _spriteBatch.Draw(_monoTexture, _monoPosition, Color.White);
            if (enemy_appear)
            {
                _spriteBatch.DrawString(_font, "Slime: " + _slimehp, new(_slimePosition.X-30, _slimePosition.Y - 30), Color.Black);
                _spriteBatch.Draw(_slimeTexture, _slimePosition, Color.White);
            }
            if (dragon_appear)
            {
                _spriteBatch.DrawString(_font, "Dragon: " +dragonhp, new(_dragonPosition.X - 30, _dragonPosition.Y - 30), Color.Black);
                _spriteBatch.Draw(_dragonTexture, _dragonPosition, Color.White);
            }
            if (potion)
            {
                
                _spriteBatch.Draw(_potionTexture, _potionPosition, Color.White);
            }
            if (getpotion && _hp<10)
            {
                _spriteBatch.DrawString(_font, "+3HP", new(_monoPosition.X, _monoPosition.Y - 30), Color.Black);
                getpotion = false;
            }
            else if (getpotion && _hp>=10){
                _spriteBatch.DrawString(_font, "MaxHP", new(_monoPosition.X, _monoPosition.Y - 30), Color.Black);
                getpotion = false;
                getpotion = false;
            }

            _spriteBatch.Draw(_slashTexture, _slashPosition, Color.White);
            _spriteBatch.Draw(_shieldTexture, _shieldPosition, Color.White);
            if (!_plantTocada)
            {
_spriteBatch.Draw(_plantTexture, _plantPosition, Color.White);
                
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}