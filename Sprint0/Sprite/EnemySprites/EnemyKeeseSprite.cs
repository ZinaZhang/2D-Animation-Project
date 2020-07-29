﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0.Sprite
{
    public class EnemyKeeseSprite : ISprite
    {
        private static SpriteBatch mySpriteBatch;
        private static Texture2D myTexture;
        Color myColor = Color.CornflowerBlue;
        Rectangle sourceRec;
        Rectangle destinationRec;
        int frame = 0;
        bool backmove = false;

        public EnemyKeeseSprite(int x, int y)
        {
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public void Update()
        {
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10 && !backmove)
            {
                sourceRec = new Rectangle(183, 11, 16, 16);
                destinationRec.Y += 3;
            }
            else if (frame > 10 && !backmove)
            {
                sourceRec = new Rectangle(200, 11, 16, 16);
                destinationRec.Y += 3;
            }
            else if (frame < 10 && backmove)
            {

                sourceRec = new Rectangle(183, 11, 16, 16);
                destinationRec.Y -= 3;
            }
            else if (frame > 10 && backmove)
            {

                sourceRec = new Rectangle(200, 11, 16, 16);
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
