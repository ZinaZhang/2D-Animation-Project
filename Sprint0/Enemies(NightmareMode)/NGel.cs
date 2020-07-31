﻿using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Sprint0.Collisions;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class NGel : IEnemy
    {

        private IPlayer myPlayer;
        private ISprite GelSprite;
        private int xPosition, yPosition, xDif, yDif;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        private int health = IntegerHolder.Five; 
        private ISprite Born;
        private ISprite Death;
        private int counter = 0;
        public NGel(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            GelSprite = new NGelSprite();
            destinationRec = new Rectangle(x, y, IntegerHolder.TwentyFour, IntegerHolder.TwentyFour);
            enemyAllCollision = new EnemyAllCollision(this);
            Born = SpriteFactory.EnemyBorn;
            Death = SpriteFactory.EnemyDeath;
        }

        public void Damaged()
        {
            health--;

        }
        public int GetHealth()
        {
            return health;
        }

        public void Draw()
        {
            if (counter < IntegerHolder.ThirtyFour)
            {
                Born.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }

            if (this.GetHealth() > 0 && counter == IntegerHolder.ThirtyFour)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                GelSprite.Draw(location, false);
            }
            if (counter < IntegerHolder.Seventy && this.GetHealth() == 0)
            {
                Death.Draw(new Vector2(destinationRec.X, destinationRec.Y), false);
            }
        }

        public void Update()
        {
            if (counter < IntegerHolder.ThirtyFour)
            {
                Born.Update();
                counter++;
            }
            else if (counter >= IntegerHolder.ThirtyFour && this.GetHealth() == 0 && counter < IntegerHolder.Seventy)
            {
                Death.Update();
                counter++;
            }
            else
            {
                targetRectangle = myPlayer.GetRectangle();
                xDif = targetRectangle.X - xPosition;
                yDif = targetRectangle.Y - yPosition;
                if (Math.Abs(xDif) > Math.Abs(yDif))
                {
                    if (xDif > 0) { xPosition += IntegerHolder.Three; }
                    else { xPosition -= IntegerHolder.Three; }
                }
                else
                {
                    if (yDif > 0) yPosition += IntegerHolder.Three;
                    else yPosition -= IntegerHolder.Three;
                }
                GelSprite.Update();
            }
        }

        public Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, IntegerHolder.ThirtyFive, IntegerHolder.ThirtyFive);
            return destinationRec;
        }

        public void xReverse(int distance, bool plus)
        {
            if (plus) xPosition += distance;
            else { xPosition -= distance; }
        }

        public void yReverse(int distance, bool plus)
        {
            if (plus) yPosition += distance;
            else { yPosition -= distance; }
        }

        public void blockCollisionTest(List<IBlock> blocks) { enemyAllCollision.BlockCollisionTest(blocks); }
    }
}