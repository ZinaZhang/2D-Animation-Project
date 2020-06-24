﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0.Commands
{
    class D2SecondWeapon : ICommand
    {
        private Game1 myGame;

        public D2SecondWeapon(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.currentRoom.link.UseSecondItem();
        }

    }
}
