using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantGameIdaru
{
    public abstract class Plant
    {
        protected List<Texture2D> _plantStages;
        protected List<int> _stageTimer;
        protected int _currentStage;
        protected Vector2 _potPosition;
        protected Vector2 _plantPosition;
        private Vector2 _potSize;
        protected decimal _timeElapsed;
        protected Color _grayColor;
        protected Color _normalColor;
        protected Color _currentColor;

        public Plant(Vector2 potPosition)
        {
            _potPosition = potPosition;
            _plantStages = new List<Texture2D>();
            _stageTimer = new List<int>();
            _potSize = new Vector2(32, 32);
            _plantPosition = new Vector2((int)_potPosition.X - _potSize.Y, _potPosition.Y - _potSize.X * 3);

            _grayColor = Color.DimGray;
            _normalColor = Color.White;
            _currentColor = _normalColor;
        }

        protected abstract void SetTimer();

        public abstract void LoadContent(ContentManager content);

        public void Update(GameTime gameTime)
        {

            Console.WriteLine(_currentStage);

            if (_timeElapsed >= _stageTimer[_currentStage])
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
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_plantStages[_currentStage], new Rectangle((int)_plantPosition.X, (int)_plantPosition.Y, _plantStages[_currentStage].Width * 2, _plantStages[_currentStage].Height * 2), _currentColor);
            _timeElapsed += gameTime.ElapsedGameTime.Milliseconds;
        }

        
    }
}
