using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace PlantGameIdaru
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Vector2 plantPosition = new Vector2(300, 300);
        Vector2 potPosition = new Vector2(300, 300);
        Texture2D gardenBackground;
        Texture2D plantStage0;
        Texture2D plantStage1;
        Texture2D plantStage2;
        Texture2D plantStage3;
        Texture2D plantStage4;
        Texture2D plantStage5;
        private double timeElapsed;
        private const int FIVE_SECONDS = 5000;
        private const int TEN_SECOUNDS = 10000;
        private const int TWENTY_SECONDS = 20000;
        private const int THIRTY_SECONDS = 30000;
        private const int FOURTY_SECONDS = 40000;
        private const int FIFTY_SECONDS = 50000;
        KeyboardState state = Keyboard.GetState();
        bool isCButtonPressed = false;
        private Pot _pot;
        
        

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 768;
            base.IsMouseVisible = true;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            _pot = new RegularBrownPot();
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            gardenBackground = this.Content.Load<Texture2D>("Pictures/Backgrounds/Garden.png");
            plantStage0 = this.Content.Load<Texture2D>("Pictures/Plants/PlantStage0.png");
            plantStage1 = this.Content.Load<Texture2D>("Pictures/Plants/PlantStage1.png");
            plantStage2 = this.Content.Load<Texture2D>("Pictures/Plants/PlantStage2.png");
            plantStage3 = this.Content.Load<Texture2D>("Pictures/Plants/PlantStage3.png");
            plantStage4 = this.Content.Load<Texture2D>("Pictures/Plants/PlantStage4.png");
            plantStage5 = this.Content.Load<Texture2D>("Pictures/Plants/PlantStage5.png");

            _pot.LoadContent(this.Content);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            

            timeElapsed += gameTime.ElapsedGameTime.Milliseconds;
            Console.WriteLine(timeElapsed);
            // TODO: Add your drawing code here
            spriteBatch.Begin();
            
            spriteBatch.Draw(gardenBackground, new Rectangle(0,0, 1024, 768), Color.White);
            _pot.Draw(gameTime, spriteBatch);

            if(state.IsKeyDown(Keys.C) == true)
                isCButtonPressed = true;

            if(isCButtonPressed == true){
                if (timeElapsed >= FIFTY_SECONDS)
                    spriteBatch.Draw(plantStage5, new Rectangle((int)plantPosition.X, (int)plantPosition.Y, plantStage5.Width * 2, plantStage5.Height * 2), Color.White);
                else if (timeElapsed >= FOURTY_SECONDS)
                    spriteBatch.Draw(plantStage4, new Rectangle((int)plantPosition.X, (int)plantPosition.Y, plantStage4.Width * 2, plantStage4.Height * 2), Color.White);
                else if (timeElapsed >= THIRTY_SECONDS)
                    spriteBatch.Draw(plantStage3, new Rectangle((int)plantPosition.X, (int)plantPosition.Y, plantStage3.Width * 2, plantStage3.Height * 2), Color.White);
                else if (timeElapsed >= TWENTY_SECONDS)
                    spriteBatch.Draw(plantStage2, new Rectangle((int)plantPosition.X, (int)plantPosition.Y, plantStage2.Width * 2, plantStage2.Height * 2), Color.White);
                else if (timeElapsed >= TEN_SECOUNDS)
                    spriteBatch.Draw(plantStage1, new Rectangle((int)plantPosition.X, (int)plantPosition.Y, plantStage1.Width * 2, plantStage1.Height * 2), Color.White);
                else if (timeElapsed >= FIVE_SECONDS)
                    spriteBatch.Draw(plantStage0, new Rectangle((int)plantPosition.X, (int)plantPosition.Y, plantStage0.Width * 2, plantStage0.Height * 2), Color.White);
            }


            
            spriteBatch.End();

            

            base.Draw(gameTime);
        }
    }
}
