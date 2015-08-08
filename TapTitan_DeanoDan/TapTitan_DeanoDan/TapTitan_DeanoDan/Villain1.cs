using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TapTitanXNA_DeanoDan;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TapTitan_DeanoDan
{
    class Villain
    {
        #region Properties
        Vector2 villain1Position;
        Texture2D villain1;
        ContentManager content;
        Level level;
        Animation BossAnimation1;
        AnimationPlayer spriteVillain1;
        #endregion

        public void LoadContent()
        {

            villain1 = content.Load<Texture2D>("HeroSprite/Frieza1");

            BossAnimation1 = new Animation(villain1, 0.1f, true, 3);
            int positionX = (Level.windowWidth / 2) - (BossAnimation1.FrameWidth / 4);
            int positionY = (Level.windowHeight / 2) - (BossAnimation1.FrameHeight / 4) - 40;
            villain1Position = new Vector2((float)positionX, (float)positionY);
            spriteVillain1.PlayAnimation(BossAnimation1);
        }

        public Villain(ContentManager content, Level level)
        {
            this.content = content;
            this.level = level;
        }
        public void Update(GameTime gameTime)
        {

        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            villain1Position = new Vector2(170, 150);
            spriteVillain1.Draw(gameTime, spriteBatch,villain1Position, SpriteEffects.None);
        }
    }
}
