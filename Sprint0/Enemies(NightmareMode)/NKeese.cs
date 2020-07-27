﻿using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Sprint0.Collisions;

namespace Sprint0.Enemies
{
    public class NKeese : AbstractEnemies, IEnemy
    {

        private IPlayer myPlayer;
        private ISprite KeeseSprite;
        private int xPosition, yPosition, xDif, yDif;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        public NKeese(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            KeeseSprite = new NKeeseSprite();
            destinationRec = new Rectangle(x, y, 35, 35);
            enemyAllCollision = new EnemyAllCollision(this);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                KeeseSprite.Draw(location, false);
            }
        }

        public override void Update()
        {
            targetRectangle = myPlayer.GetRectangle();
            xDif = targetRectangle.X - xPosition;
            yDif = targetRectangle.Y - yPosition;
            if (Math.Abs(xDif) > Math.Abs(yDif))
            {
                if (xDif > 0) xPosition += 3;
                else xPosition -= 3;
            }
            else
            {
                if (yDif > 0) yPosition += 3;
                else yPosition -= 3;
            }
            KeeseSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            destinationRec = new Rectangle(xPosition, yPosition, 35, 35);
            return destinationRec;
        }

        public override void xReverse(int distance, bool plus)
        {
            if (plus) xPosition += distance;
            else { xPosition -= distance; }
        }

        public override void yReverse(int distance, bool plus)
        {
            if (plus) yPosition += distance;
            else { yPosition -= distance; }
        }

        public override void blockCollisionTest(List<IBlock> blocks) { enemyAllCollision.BlockCollisionTest(blocks); }
    }
}