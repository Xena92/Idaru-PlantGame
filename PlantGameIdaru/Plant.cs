using Microsoft.Xna.Framework;
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
        protected int _currentStage;

        protected void SetTimer()
        {

        }

        public abstract void LoadContent();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime);

        
    }
}
