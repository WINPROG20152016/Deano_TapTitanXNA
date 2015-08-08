using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TapTitanXNA_DeanoDan;
using TapTitan_DeanoDan;

namespace TapTitanXNA_DeanoDan
{
    public class Level
    {

        public static int windowWidth = 400;
        public static int windowHeight = 500;

        #region Properties
        ContentManager content;

        Texture2D background;

        public MouseState oldMouseState;
        public MouseState mouseState;

        bool mpressed, prev_mpressed = false;
        int mouseX, mouseY;

        Hero hero;
        Support1 sup1;
        Support2 sup2;
        Villain villain1;
        Button playButton;
        Button attackButton;

        SpriteFont damageStringFont;
        int damageNumber = 100;

        #endregion

        public Level(ContentManager content)
        {
            this.content = content;
           
            sup1 = new Support1(content, this);
            sup2 = new Support2(content, this);
            villain1 = new Villain(content, this);
            hero = new Hero(content, this);

        }

        public void LoadContent()
        {
            background = content.Load<Texture2D>("HeroSprite/bg");
            damageStringFont = content.Load<SpriteFont>("Font");

            //playButton = new Button(content, "Button/button_play", Vector2.Zero);
            attackButton = new Button(content, "HeroSprite/AttackAction", new Vector2(175, 365));

            hero.LoadContent();
            sup1.LoadContent();
            sup2.LoadContent();
            villain1.LoadContent();
        }

        public void Update(GameTime gameTime)
        {
            mouseState = Mouse.GetState();

            mouseX = mouseState.X;
            mouseY = mouseState.Y;

            prev_mpressed = mpressed;
            mpressed = mouseState.LeftButton == ButtonState.Pressed;

            hero.Update(gameTime);
            sup1.Update(gameTime);
            sup2.Update(gameTime);
            villain1.Update(gameTime);
            oldMouseState = mouseState;

            if (attackButton.Update(gameTime, mouseX, mouseY,
                mpressed, prev_mpressed))
            {
                damageNumber -= 3;
                if (damageNumber <= 0)
                {
                    damageNumber = 100; 
                    //NewSprite

                }
            }

        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, Vector2.Zero, null, Color.Pink, 0.0f, Vector2.Zero, 1.0f, SpriteEffects.None, 0.4f);
            
            sup1.Draw(gameTime, spriteBatch);
            sup2.Draw(gameTime, spriteBatch);
            hero.Draw(gameTime, spriteBatch);
            villain1.Draw(gameTime, spriteBatch);
            spriteBatch.DrawString(damageStringFont, damageNumber + "/100 Health", Vector2.Zero, Color.Pink);
            attackButton.Draw(gameTime, spriteBatch);
        }
    }
}