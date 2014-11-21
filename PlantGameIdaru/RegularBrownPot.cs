using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantGameIdaru
{
    class RegularBrownPot : Pot
    {
        Vector2 potPosition = new Vector2(300, 300);
        Texture2D potDry;
        Texture2D potWet;

        public RegularBrownPot()
            : base()
        {
            
        }

        public override void LoadContent(ContentManager content)
        {
            potDry = content.Load<Texture2D>("Pictures/Pots/PotStage0.png");
            potWet = content.Load<Texture2D>("Pictures/Pots/PotStage1.png");
            _potStages.Add(potDry);
            _potStages.Add(potWet);
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(potDry, new Rectangle((int)potPosition.X + potDry.Width, (int)potPosition.Y + potDry.Height * 3, potDry.Width * 2, potDry.Height * 2), Color.White);
        }
    }
}
