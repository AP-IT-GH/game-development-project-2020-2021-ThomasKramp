﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sailor.Interfaces.Animation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sailor.World.Abstract
{
    public abstract class SpecialDrawBlok : DrawBlok, IDrawEffect
    {
        public SpriteEffects effect { get; set; }
        public bool Hit { get; set; }

        protected Vector2 richting;

        #region DrawVariables
        // Extra variabelen voor de draw methode
        //  A rotation of this sprite.
        protected float BasicRotation = 0f;
        // Center of the rotation. 0,0 by default.
        protected Vector2 BasicOrigin = new Vector2(0, 0);
        // A scaling of this sprite.
        protected float BasicScale = 1f;
        // A depth of the layer of this sprite.
        protected float BasicLayerDepth = 0f;
        #endregion

        public virtual void Update(GameTime gameTime, List<DrawBlok> Surroundings, List<DynamicBlok> Targets, List<SpecialDrawBlok> Thowables) { }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(CurrentTexture, Positie, Frame, Color.White, BasicRotation, BasicOrigin, BasicScale, effect, BasicLayerDepth);
        }
    }
}