﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class EnemyTektiteSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec = new Rectangle(300, 350, 64, 64);
        int frame = 0;
        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10)
            {
                sourceRec = new Rectangle(162, 90, 16, 16);
                destinationRec.Y -= 5;
            }
            else
            {
                sourceRec = new Rectangle(179, 90, 16, 16);
                destinationRec.Y -= 5;
            }
            if (destinationRec.Y < 0) destinationRec.Y = 480;
        }

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location)
        {
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
