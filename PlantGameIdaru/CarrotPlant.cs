using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantGameIdaru
{
    class CarrotPlant : Plant
    {

        public CarrotPlant(Vector2 potPosition) 
            : base(potPosition)
        {
            SetTimer();
        }

        protected override void SetTimer()
        {
            _stageTimer.Add(2000);
            _stageTimer.Add(3000);
            _stageTimer.Add(4000);
            _stageTimer.Add(5000);
            _stageTimer.Add(6000);
            _stageTimer.Add(7000);
        }

        public override void LoadContent(ContentManager content)
        {
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage0.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage1.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Carrot/PlantStage2.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Carrot/PlantStage3.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Carrot/PlantStage4.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Carrot/PlantStage5.png"));
        }


    }
}
