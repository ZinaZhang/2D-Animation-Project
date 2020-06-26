﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Sprite;

namespace Sprint0.Commands
{
    class MouseLeftLastRM : ICommand
    {
        private Game1 myGame;

        public MouseLeftLastRM(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            if (myGame.roomCount != 0)
            {
                myGame.roomCount--;
                myGame.currentRoom = myGame.roomList[myGame.roomCount];
            }
        }

    }
}