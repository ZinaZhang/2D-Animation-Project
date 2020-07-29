﻿using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.xml;
using Microsoft.Xna.Framework.Content;
using Sprint0.HUDs;
using Sprint0.UtilityClass;

namespace Sprint0.GameStates
{
    class NTransitioning : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        roomProperties myNCurrentRoom;
        int myNextNRoom;
        Rectangle DestRec = new Rectangle(0, 168, 768, 528);
        Rectangle currentSourceRec;
        int frame = 0;
        ContentManager myContent;
        private Hud myHud;
        int x = 0;
        int y = 0;

        public NTransitioning(Game1 game, SpriteBatch batch, ContentManager Content, Hud hud1)
        {
            myGame = game;
            myNCurrentRoom = game.NcurrentRoom;
            currentSourceRec = myNCurrentRoom.sourceRec;
            myBatch = batch;
            myContent = Content;
            myHud = hud1;
        }

        public void loadNextRoom(int nextRoom)
        {
            myNextNRoom = nextRoom;
        }

        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Dungeon), DestRec, currentSourceRec, Color.White);
            myBatch.End();
            myHud.Draw(x, y);
        }

        public void Update()
        {
            frame++;
            if (frame >= 33)
            {
                myGame.NcurrentRoom = myGame.NroomList[myNextNRoom];
                myGame.currentState = myGame.stateList[9];
                frame = 0;
                currentSourceRec = myGame.NcurrentRoom.sourceRec;
                myNCurrentRoom = myGame.NcurrentRoom;
            }
            else {
                switch (myNCurrentRoom.Connectors.IndexOf(myNextNRoom))
                {
                    case 0:
                        if (frame % 2 == 0)
                        {
                            currentSourceRec.Y -= 6;
                        }
                        else
                        {
                            currentSourceRec.Y -= 5;
                        }
                        break;
                    case 1:
                        if (frame % 2 == 0)
                        {
                            currentSourceRec.Y += 6;
                        }
                        else
                        {
                            currentSourceRec.Y += 5;
                        }
                        break;
                    case 2:
                        currentSourceRec.X -= 8;
                        break;
                    case 3:
                        currentSourceRec.X += 8;
                        break;
                }
            }
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