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
using Sprint0.Sprite;
using System.Windows;
using Sprint0.HUD;

namespace Sprint0.GameStates
{
    class GoToPause : IGameState
    {
        Game1 myGame;
        SpriteBatch myBatch;
        roomProperties myCurrentRoom;
        Rectangle roomDestRec = new Rectangle(0, 168, 768, 528);
        Rectangle pauseDestRec = new Rectangle(0, -528, 768, 528);
        Rectangle roomSourceRec;
        Rectangle pauseSourceRec = new Rectangle(0, 0, 491, 325);
        int frame = 0;
        ContentManager myContent;
        private HudMap map;
        private Hud myHud;
        int x = 0;
        int y = 0;
        int mapx = 450;
        int mapy = 450-528;

        public GoToPause(Game1 game, SpriteBatch batch, ContentManager Content)
        {
            myGame = game;
            myCurrentRoom = game.currentRoom;
            roomSourceRec = myCurrentRoom.sourceRec;
            myBatch = batch;
            myContent = Content;
            myHud = new Hud(myGame);
            map = new HudMap(myGame);
        }
        public void loadNextRoom(int nextRoom)
        {
            // nothing
        }

        public void Draw()
        {
            myBatch.Begin();
            myBatch.Draw(myContent.Load<Texture2D>("dungeon"), roomDestRec, roomSourceRec, Color.White);
            myBatch.Draw(myContent.Load<Texture2D>("pause"), pauseDestRec, pauseSourceRec, Color.White);
            myBatch.End();
            myHud.Draw(x, y);
            map.Draw(mapx, mapy);
        }

        public void Update() 
        {                       
            frame++;
            if (frame < 89)
            {
                roomDestRec.Y += 6;
                pauseDestRec.Y += 6;
                y += 6;
                mapy += 6;
            }
            else
            {
                myGame.currentState = myGame.stateList[4];
                frame = 0;
                y = 0;
                mapy = 450 - 528;
                roomDestRec = new Rectangle(0, 168, 768, 528);
                pauseDestRec = new Rectangle(0, -528, 768, 528);
            }
               
            
        }

    }
}