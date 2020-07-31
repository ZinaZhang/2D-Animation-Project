﻿using Sprint0.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint0.UtilityClass;

namespace Sprint0.GameStates
{
    class Win : IGameState
    {
        SpriteBatch myBatch;
        Rectangle DestRec = new Rectangle(0, 0, IntegerHolder.SevenSixEight, 708);
        Rectangle SourceRec = new Rectangle(0, 0, 509, 347);
        ContentManager myContent;

        public Win( SpriteBatch batch, ContentManager Content)
        {
            myBatch = batch;
            myContent = Content;
        }

        public void loadNextRoom(int nextRoom)
        {

        }

        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Winning), DestRec, SourceRec, Color.White);
            myBatch.End();
        }

        public void Update()
        {

        }

        public void NextOption()
        {

        }
        public void LastOption()
        {

        }

        public void Select()
        {

        }
    }
}
