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
    public abstract class Pot
    {
        protected Vector2 _potPosition;
        protected List<Texture2D> _potStages;
        protected int _currentStage;
        protected int _stageTimer;
        protected Plant _plant;
        protected ContentManager _content;
        protected Decimal _timeElapsed;

        public Pot(Vector2 potPosition, ContentManager content)
        {
            _potStages = new List<Texture2D>();
            _potPosition = potPosition;
            _content = content;
        }

        public void AddBananaPlant(ContentManager content)
        {
            _plant = new BananaPlant(_potPosition);
            _plant.LoadContent(content);
        }

        public bool IsMouseWithinPotPosition()
        {
            if (Mouse.GetState().Position.X >= _potPosition.X && Mouse.GetState().Position.Y >= _potPosition.Y &&
                Mouse.GetState().Position.X <= _potStages[0].Width * 2 + _potPosition.X && Mouse.GetState().Position.Y <= _potStages[0].Height * 2 + _potPosition.Y )
                return true;

            else
                return false;
        }

        protected abstract void SetTimer();

        public abstract void LoadContent(ContentManager content);
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

    }
}
