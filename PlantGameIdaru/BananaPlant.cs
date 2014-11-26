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
        

        public BananaPlant(Vector2 potPosition)
            : base(potPosition)
        {
            SetTimer();
            
        }

        public override void LoadContent(ContentManager content)
        {
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage0.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage1.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Banana/PlantStage2.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Banana/PlantStage3.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Banana/PlantStage4.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Banana/PlantStage5.png"));
            
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
