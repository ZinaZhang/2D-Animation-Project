﻿namespace Sprint0.Commands
{
    class dRight : ICommand
    {
        private Game1 myGame;

        public dRight(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {

            myGame.link.Right();

        }

    }
}
