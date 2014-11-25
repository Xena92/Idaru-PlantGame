using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantGameIdaru
{
    class RegularBrownPot : Pot
    {
        

        public RegularBrownPot(Vector2 potPosition, ContentManager content)
            : base(potPosition, content)
        {
            SetTimer();
        }

        public override void LoadContent(ContentManager content)
        {
            _potStages.Add(content.Load<Texture2D>("Pictures/Pots/PotStage0.png"));
            _potStages.Add(content.Load<Texture2D>("Pictures/Pots/PotStage1.png"));
        }

        public override void Update(GameTime gameTime)
        {
            if(_plant != null)
                _plant.Update(gameTime);

            if (Mouse.GetState().LeftButton == ButtonState.Pressed && IsMouseWithinPotPosition() && _plant == null)
            {
                AddBananaPlant(_content);
            }

            if (Mouse.GetState().RightButton == ButtonState.Pressed && IsMouseWithinPotPosition())
            {
                if (_currentStage == 0)
                    _currentStage++;
                else if (_currentStage == 1)
                    _timeElapsed = 0;  
            }
            if (_timeElapsed >= _stageTimer)
            {
                _currentStage--;
                _timeElapsed = 0;
            }
                

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            MouseState mouseState = Mouse.GetState();

            spriteBatch.Draw(_potStages[_currentStage], new Rectangle((int)_potPosition.X, (int)_potPosition.Y, _potStages[_currentStage].Width * 2, _potStages[_currentStage].Height * 2), Color.White);
            if (_plant != null)
                _plant.Draw(gameTime, spriteBatch);

            if(_currentStage == 1)
                _timeElapsed += gameTime.ElapsedGameTime.Milliseconds;
        }

        protected override void SetTimer()
        {
            _stageTimer = 10000;
        }


    }
}
