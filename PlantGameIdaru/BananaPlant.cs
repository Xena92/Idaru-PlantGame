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
    class BananaPlant : Plant
    {
        private Color _grayColor;
        private Color _normalColor;
        private Color _currentColor;

        public BananaPlant(Vector2 potPosition)
            : base(potPosition)
        {
            SetTimer();
            _grayColor = Color.DimGray;
            _normalColor = Color.White;
            _currentColor = _normalColor;
        }

        public override void LoadContent(ContentManager content)
        {
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage0.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage1.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage2.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage3.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage4.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage5.png"));
            
        }

        public override void Update(GameTime gameTime)
        {
            if(_timeElapsed >= _stageTimer[_currentStage])
            {
                if (_currentStage + 1 > _plantStages.Count - 1)
                {
                    _currentColor = _grayColor;
                }
                else
                {
                    _currentStage++;
                    _timeElapsed = 0;
                }
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_plantStages[_currentStage], new Rectangle((int)_plantPosition.X, (int)_plantPosition.Y, _plantStages[_currentStage].Width * 2, _plantStages[_currentStage].Height * 2), _currentColor);
            _timeElapsed += gameTime.ElapsedGameTime.Milliseconds;
        }

        protected override void SetTimer()
        {
            _stageTimer.Add(5000);
            _stageTimer.Add(5000);
            _stageTimer.Add(5000);
            _stageTimer.Add(5000);
            _stageTimer.Add(5000);
            _stageTimer.Add(5000);
        }
    }
}
