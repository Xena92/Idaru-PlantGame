using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlantGameIdaru
{
    class SteakPlant : Plant
    {

        public SteakPlant(Vector2 potPosition) 
            : base(potPosition)
        {
            SetTimer();
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

        public override void LoadContent(ContentManager content)
        {
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage0.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/PlantStage1.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Steak/PlantStage2.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Steak/PlantStage3.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Steak/PlantStage4.png"));
            _plantStages.Add(content.Load<Texture2D>("Pictures/Plants/Steak/PlantStage5.png"));
        }


    }
}
