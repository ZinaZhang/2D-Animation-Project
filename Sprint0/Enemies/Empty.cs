﻿using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System.Collections.Generic;
using Sprint0.UtilityClass;

namespace Sprint0.Enemies
{
    public class Empty :IEnemy
    {
        private ISprite AquaSprite;
        private int xPosition;
        private int yPosition;
        private Rectangle destinationRec;
        private int health = IntegerHolder.Five;
        private ISprite Born;
        private ISprite Death;

        public Empty(int x, int y)
        {

            xPosition = x;
            yPosition = y;
            AquaSprite = new EnemyAquaSprite(x, y);
            destinationRec = new Rectangle(x, y, IntegerHolder.FoutyFive, 60);
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

        }

        public void Update()
        {
           
        }

        public Rectangle GetRectangle()
        {
            return destinationRec;
        }

        public void xReverse(int distance, bool plus)
        {
            throw new System.NotImplementedException();
        }

        public void yReverse(int distance, bool plus)
        {
            throw new System.NotImplementedException();
        }

        public void blockCollisionTest(List<IBlock> blocks)
        {

        }
    }
}