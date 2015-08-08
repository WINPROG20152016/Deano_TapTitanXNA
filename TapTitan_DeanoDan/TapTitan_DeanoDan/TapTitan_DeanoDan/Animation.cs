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

        public int FrameCount;

        public int FrameWidth
        {
            get
            {
                return texture.Width / FrameCount;
            }
        }
        public int FrameHeight
        {
            get
            {
                return texture.Height;
            }

        }

        public Animation(Texture2D texture, float frameTime, bool isLooping, int FrameCount)
        {
            this.texture = texture;
            this.frameTime = frameTime;
            this.islooping = isLooping;
            this.FrameCount = FrameCount;
        }
    }

}

