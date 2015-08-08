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
    class Support2
    {
        #region Properties
       Vector2 sup1Position, sup2Position;
       // Vector2 sup2Position;
        Texture2D sup2;
        ContentManager content;
        Level level;
        Animation idleAnimation2;
        AnimationPlayer spriteSup1, spriteSup2;
        #endregion

        public void LoadContent()
        {
            
            sup2 = content.Load<Texture2D>("HeroSprite/Gohan1");

            idleAnimation2 = new Animation(sup2, 0.1f, true, 5);
             int positionX = (Level.windowWidth / 2) - (idleAnimation2.FrameWidth / 4);
             int positionY = (Level.windowHeight / 2) - (idleAnimation2.FrameHeight / 4) - 40;
            sup2Position = new Vector2((float)positionX, (float)positionY);
            spriteSup2.PlayAnimation(idleAnimation2);
        }

        public Support2(ContentManager content, Level level)
        {
            this.content = content;
            this.level = level;
        }
        public void Update(GameTime gameTime)
        { 
               // sup1 = content.Load<Texture2D>("HeroSprite/Trunks");

                idleAnimation2 = new Animation(sup2, 0.1f, true, 6);

                int positionX = (Level.windowWidth / 2) - (idleAnimation2.FrameWidth / 4);
                int positionY = (Level.windowHeight / 2) - (idleAnimation2.FrameHeight / 4) - 60;
                sup1Position = new Vector2((float)positionX, (float)positionY);

                spriteSup1.PlayAnimation(idleAnimation2);


        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            sup2Position = new Vector2(130, 50);
            spriteSup2.Draw(gameTime, spriteBatch, sup1Position, SpriteEffects.None);
        }
    }
}
