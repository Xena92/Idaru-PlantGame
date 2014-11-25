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

        public Plant(Vector2 potPosition)
        {
            _potPosition = potPosition;
            _plantStages = new List<Texture2D>();
            _stageTimer = new List<int>();
            _potSize = new Vector2(32, 32);
            _plantPosition = new Vector2((int)_potPosition.X - _potSize.Y, _potPosition.Y - _potSize.X * 3);
        }

        protected abstract void SetTimer();

        public abstract void LoadContent(ContentManager content);
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        
    }
}
