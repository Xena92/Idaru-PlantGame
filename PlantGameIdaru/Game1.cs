using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace PlantGameIdaru
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D gardenBackground;
        private List<Pot> _potList; 

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
            _potList = new List<Pot>();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            _potList.Add(new RegularBrownPot(new Vector2(300, 300), Content));
            _potList.Add(new RegularBrownPot(new Vector2(450, 300), Content));
            _potList.Add(new RegularBrownPot(new Vector2(600, 300), Content));
            _potList.Add(new RegularBrownPot(new Vector2(750, 300), Content));
            _potList.Add(new RegularBrownPot(new Vector2(300, 450), Content));
            _potList.Add(new RegularBrownPot(new Vector2(450, 450), Content));
            _potList.Add(new RegularBrownPot(new Vector2(600, 450), Content));
            _potList.Add(new RegularBrownPot(new Vector2(750, 450), Content));
            _potList[0].AddBananaPlant(Content);
            _potList[1].AddCarrotPlant(Content);
            _potList[2].AddSteakPlant(Content);

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            gardenBackground = this.Content.Load<Texture2D>("Pictures/Backgrounds/Garden.png");

            foreach (Pot p in _potList)
            {
                p.LoadContent(this.Content);
            }

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
            foreach (Pot p in _potList)
            {
                p.Update(gameTime);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            

            // TODO: Add your drawing code here
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, null, null);
            
            spriteBatch.Draw(gardenBackground, new Rectangle(0,0, 1024, 768), Color.White);

            foreach (Pot p in _potList)
            {
                p.Draw(gameTime, spriteBatch);
            }

            spriteBatch.End();

            

            base.Draw(gameTime);
        }
    }
}
