using Microsoft.Xna.Framework;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Sprint0.Collisions;

namespace Sprint0.Enemies
{
    public class NMoblin : AbstractEnemies, IEnemy
    {
        private IPlayer myPlayer;
        private ISprite MoblinSprite;
        private int xPosition, yPosition, xDif, yDif;
        private int frame = 0;
        bool leftmove = false;
        private Rectangle destinationRec, targetRectangle;
        private EnemyAllCollision enemyAllCollision;
        private List<Boolean> UdLrCollid;
        
        public NMoblin(int x, int y, IPlayer player)
        {
            myPlayer = player;
            xPosition = x;
            yPosition = y;
            MoblinSprite = new NMoblinSprite();
            destinationRec = new Rectangle(x, y, 35, 35);
            enemyAllCollision = new EnemyAllCollision(this);
            UdLrCollid = new List<bool>();
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                MoblinSprite.Draw(location, leftmove);
            }
        }

        public override void Update()
        {
            targetRectangle = myPlayer.GetRectangle();
            xDif = targetRectangle.X - xPosition;
            yDif = targetRectangle.Y - yPosition;
            if (Math.Abs(xDif) > Math.Abs(yDif))//Horizontal Chasing Link
            {
                if (!UdLrCollid[1]) { 
                    if (xDif > 0) { xPosition += 3; leftmove = false; }
                    else { xPosition -= 3; leftmove = true; }
                }
                else if (UdLrCollid[1])//Should HorizontalChasing But Collid with Blocks
                {
                    if (yDif > 0) yPosition += 3;
                    else yPosition -= 3;
                }
            }
            else//UpDown Chasing Link
            {
                if (!UdLrCollid[0]) {
                    if (yDif > 0) yPosition += 3;
                    else yPosition -= 3;
                }
                else if(UdLrCollid[0])
                {
                    if (xDif > 0) { xPosition += 3; leftmove = false; }
                    else { xPosition -= 3; leftmove = true; }
                }
            }
            MoblinSprite.Update();
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

        public override void blockCollisionTest(List<IBlock> blocks) { UdLrCollid =  enemyAllCollision.BlockCollisionTest(blocks); }
    }
}