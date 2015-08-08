using System;
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
    public class Hero
    {
        #region Properties
        Vector2 playerPosition;
        //Vector2 sup1Position;
       // Vector2 sup2Position;
       // Texture2D sup1;
        //Texture2D sup2;
        Texture2D player;
        ContentManager content;
        Level level;
        
        Animation idleAnimation;
        AnimationPlayer spritePlayer;
        #endregion

        public void LoadContent()
        {
            
            player = content.Load<Texture2D>("HeroSprite/Goku1");

            idleAnimation = new Animation(player, 0.1f, true, 6);

            int positionX = (Level.windowWidth / 2) - (idleAnimation.FrameWidth / 4); 
            int positionY = (Level.windowHeight / 2) - (idleAnimation.FrameHeight / 4) - 60;
            playerPosition = new Vector2((float)positionX, (float)positionY);

            spritePlayer.PlayAnimation(idleAnimation);
        }

        public Hero(ContentManager content, Level level)
        {
            this.content = content;
            this.level = level;
        }
        public void Update(GameTime gameTime)
        { 
            if(level.mouseState.LeftButton == ButtonState.Pressed && level.oldMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                player = content.Load<Texture2D>("HeroSprite/Goku3");

                idleAnimation = new Animation(player, 0.1f, true, 6);

                int positionX = (Level.windowWidth / 2) - (idleAnimation.FrameWidth / 4);
                int positionY = (Level.windowHeight / 2) - (idleAnimation.FrameHeight / 4) - 80;
                playerPosition = new Vector2((float)positionX, (float)positionY);
                idleAnimation = new Animation(player, 0.1f, false, 6);

                spritePlayer.PlayAnimation(idleAnimation);
            }
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(player, playerPosition, null, Color.White, 0.0f, Vector2.Zero, 0.5f, SpriteEffects.None, 0.0f);
            playerPosition = new Vector2(250, 225);
            spritePlayer.Draw(gameTime, spriteBatch, playerPosition, SpriteEffects.None);
        }
    }
}
