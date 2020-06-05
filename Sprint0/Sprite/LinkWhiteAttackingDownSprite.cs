﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    public class LinkWhiteAttackingDownSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        int frame = 0;
        int shownFrame = 0;
        public void Update()
        {
            frame++;
            if (frame == 40)
            {
                frame = 0;
            }
            if (frame < 10)
            {
                shownFrame = 0;
            }
            else if (frame < 20)
            {
                shownFrame = 1;
            }
            else if (frame < 30)
            {
                shownFrame = 2;
            }
            else
            {
                shownFrame = 3;
            }
            switch (shownFrame)
            {
                case 0:
                    sourceRec = new Rectangle(94, 47, 16, 16);
                    break;
                case 1:
                    sourceRec = new Rectangle(111, 47, 16, 27);
                    break;
                case 2:
                    sourceRec = new Rectangle(128, 47, 16, 23);
                    break;
                case 3:
                    sourceRec = new Rectangle(145, 47, 16, 19);
                    break;
                default:
                    break;
            }
        }
        public void Draw(Vector2 location)
        {
            mySpriteBatch.Begin();
            switch (sourceRec.Height)
            {
                case 16:
                    mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 48), sourceRec, myColor);
                    break;
                case 27:
                    mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 81), sourceRec, myColor);
                    break;
                case 23:
                    mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 69), sourceRec, myColor);
                    break;
                case 19:
                    mySpriteBatch.Draw(myTexture, new Rectangle((int)location.X, (int)location.Y, 48, 57), sourceRec, myColor);
                    break;
                default:
                    break;
            }
            mySpriteBatch.End();

        }
        public void LoadContent(SpriteBatch spriteBatch, Texture2D texture)
        {
            mySpriteBatch = spriteBatch;
            myTexture = texture;
        }
    }
}
