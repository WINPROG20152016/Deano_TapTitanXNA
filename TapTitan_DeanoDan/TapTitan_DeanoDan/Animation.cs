using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace TapTitan_DeanoDan
{
    class Animation
    {
        public Texture2D texture;
        public float frameTime;
        public bool islooping;
        private object p;
        private float p_2;
        private bool p_3;
        public int FrameCounter;

        public int FrameCount
        {
            get
            {
                return texture.Width / FrameWidth;
            }
        }
        public int FrameWidth
        {
            get
            {
                return texture.Width / FrameCounter;
            }
        }
        public int FrameHeight
        {
            get
            {
                return texture.Height;
            }

        }

        public Animation(Texture2D texture, float frameTime, bool isLooping, int FrameCounter)
        {
            this.texture = texture;
            this.frameTime = frameTime;
            this.islooping = isLooping;
            this.FrameCounter = FrameCounter;
        }
    }

}

