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
        Rectangle destinationRec;
        int frame = 0;
        bool backmove = false;
        public EnemyTektiteSprite(int x, int y)
        {
            destinationRec = new Rectangle(x, y, 45, 45);
        }
        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;

            if (frame < 10 && !backmove)
            {
                sourceRec = new Rectangle(162, 90, 16, 16);
                destinationRec.Y += 3;
            }
            else if (frame > 10 && !backmove)
            {
                sourceRec = new Rectangle(179, 90, 16, 16);
                destinationRec.Y += 3;
            }
            else if (frame < 10 && backmove)
            {

                sourceRec = new Rectangle(107, 291, 16, 16);
                destinationRec.Y -= 3;
            }
            else if (frame > 10 && backmove)
            {

                sourceRec = new Rectangle(124, 291, 16, 16);
                destinationRec.Y -= 3;
            }
            if (destinationRec.Y > 555) backmove = true;
            if (destinationRec.Y < 264) backmove = false;
        }   

        public void LoadContent(SpriteBatch batch, Texture2D texture)
        {
            mySpriteBatch = batch;
            myTexture = texture;
        }

        public void Draw(Vector2 location, bool isDamaged)
        {
            mySpriteBatch.Begin();
            mySpriteBatch.Draw(myTexture, destinationRec, sourceRec, myColor);
            mySpriteBatch.End();
        }
    }
}
