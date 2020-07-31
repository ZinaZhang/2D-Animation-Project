﻿using Sprint0.UtilityClass;

namespace Sprint0.Commands
{
    class enterPause : ICommand
    {
        private Game1 myGame;
        int count = 0;

        public enterPause(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {

            if (myGame.currentState == myGame.stateList[IntegerHolder.Eight])
            {
                if (myGame.normalOrNight == 0)
                {
                    myGame.currentState = myGame.stateList[0];
                }
                else
                {
                    myGame.currentState = myGame.stateList[9];
                }
            }
            else if (myGame.currentState == myGame.stateList[0]
                || myGame.currentState == myGame.stateList[IntegerHolder.Four]
                || myGame.currentState == myGame.stateList[IntegerHolder.Nine])

            {
                if (count == 0)
                {
                    if(myGame.currentState == myGame.stateList[0])
                    {
                        myGame.normalOrNight = 0;
                    }
                    else if (myGame.currentState == myGame.stateList[IntegerHolder.Nine])
                    {
                        myGame.normalOrNight = 9;
                    }
                    myGame.currentState = myGame.stateList[2];
                    count++;
                }
                else
                {
                    myGame.currentState = myGame.stateList[IntegerHolder.Three];
                    count = 0;
                }
            }                       
        }

    }
}
