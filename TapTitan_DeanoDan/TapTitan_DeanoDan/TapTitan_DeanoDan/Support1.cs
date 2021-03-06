﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using TapTitanXNA_DeanoDan;

namespace TapTitan_DeanoDan
{
   public class Support1
    {
        #region Properties
       Vector2 sup1Position, sup2Position;
       // Vector2 sup2Position;
        Texture2D sup1;
        Texture2D sup2;
        ContentManager content;
        Level level;
        
        Animation idleAnimation;
        Animation idleAnimation2;
        AnimationPlayer spriteSup1, spriteSup2;
        #endregion

        public void LoadContent()
        {
            
            sup1 = content.Load<Texture2D>("HeroSprite/Trunks");
            sup2 = content.Load<Texture2D>("HeroSprite/Gohan1");

            idleAnimation = new Animation(sup1, 0.1f, true, 6);
            
            int positionX = (Level.windowWidth / 2) - (idleAnimation.FrameWidth/4) ;
            int positionY = (Level.windowHeight / 2) - (idleAnimation.FrameHeight / 4) - 40;
            sup1Position = new Vector2((float)positionX, (float)positionY);

            idleAnimation2 = new Animation(sup2, 0.1f, true, 5);
             positionX = (Level.windowWidth / 2) - (idleAnimation.FrameWidth / 4);
             positionY = (Level.windowHeight / 2) - (idleAnimation.FrameHeight / 4) - 40;
            sup2Position = new Vector2((float)positionX, (float)positionY);

            spriteSup1.PlayAnimation(idleAnimation);
            spriteSup2.PlayAnimation(idleAnimation);
        }

        public Support1(ContentManager content, Level level)
        {
            this.content = content;
            this.level = level;
        }
        public void Update(GameTime gameTime)
        { 
               // sup1 = content.Load<Texture2D>("HeroSprite/Trunks");

                /*idleAnimation = new Animation(sup1, 0.1f, true, 6);

                int positionX = (Level.windowWidth / 2) - (idleAnimation.FrameWidth / 4);
                int positionY = (Level.windowHeight / 2) - (idleAnimation.FrameHeight / 4) - 60;
                sup1Position = new Vector2((float)positionX, (float)positionY);

                spriteSup1.PlayAnimation(idleAnimation);*/ 


        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(player, playerPosition, null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.0f);
            sup1Position = new Vector2(230, 50);
            sup2Position = new Vector2(130, 50);
            spriteSup1.Draw(gameTime, spriteBatch, sup1Position, SpriteEffects.None);
            spriteSup2.Draw(gameTime, spriteBatch, sup1Position, SpriteEffects.None);
        }
    }
}
