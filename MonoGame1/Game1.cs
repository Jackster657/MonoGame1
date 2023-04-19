using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D waveTexture;
        Texture2D boatTexture;
        Texture2D sharkTexture;
        Texture2D subTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 500; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions
            this.Window.Title = "My First Monogame Project";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            waveTexture = Content.Load<Texture2D>("HugeWave2");
            boatTexture = Content.Load<Texture2D>("AircraftCarrier3");
            sharkTexture = Content.Load<Texture2D>("SeaMonster");
            subTexture = Content.Load<Texture2D>("Sub");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Aquamarine);
            _spriteBatch.Begin();
            _spriteBatch.Draw(waveTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(boatTexture, new Vector2(300, 340), Color.White);
            _spriteBatch.Draw(sharkTexture, new Vector2(100, 100), Color.White);
            _spriteBatch.Draw(subTexture, new Vector2(200,180), Color.White);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}