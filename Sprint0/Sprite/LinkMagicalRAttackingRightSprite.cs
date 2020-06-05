﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    public class LinkMagicalRAttackingRightSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        public void Update()
        {
            frame++;
            if (frame == 5)
            {
                frame = 0;
            }
            switch (frame)
            {
                case 0:
                    sourceRec = new Rectangle(280, 77, 16, 16);
                    break;
                case 1:
                    sourceRec = new Rectangle(297, 77, 16, 16);
                    break;
                case 3:
                    sourceRec = new Rectangle(325, 77, 16, 16);
                    break;
                case 4:
                    sourceRec = new Rectangle(349, 77, 16, 16);
                    break;
                default:
                    break;
            }
        }
        public void Draw(Vector2 location)
        {

            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 48), sourceRec, myColor);
            mySpriteBatch.End();

        }
        public void LoadContent(SpriteBatch spriteBatch, Texture2D texture)
        {
            mySpriteBatch = spriteBatch;
            myTexture = texture;
        }
    }
}