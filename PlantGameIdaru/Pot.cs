using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantGameIdaru
{
    public abstract class Pot
    {
        protected Plant _plant;
        protected List<Texture2D> _potStages;
        protected int _currentStage;

        public Pot()
        {
            _potStages = new List<Texture2D>();
        }

        public Plant Plant
        { 
            get { return _plant; }
            set{  _plant = value; }
        }

        protected void SetTimer()
        {

        }

        public abstract void LoadContent(ContentManager content);
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

    }
}
