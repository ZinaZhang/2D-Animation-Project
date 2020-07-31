﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;
using Sprint0.UtilityClass;

namespace Sprint0.Projectile
{
    class WoodenSword : AbstractProjectile, IProjectile
    {
        private ISprite WoodenSwordSprite;
        private int counter;
        private const int attackDistance = 15;
        int myDirection;
        Vector2 location, location2;

        private enum status
        {
            shoot, stab, explode, none
        }
        private status currentStatus;
        public WoodenSword(Player1 player, int direction)
        {
            counter = 0;
            this.player = player;
            myDirection = direction;
            this.SetPosition(player.xAxis, player.yAxis);
            currentStatus = status.none;
            this.type = "arrow";

        }
        public override void Update()
        {
            if (currentStatus == status.explode && counter < 20)
            {
                counter++;
            }
            else if (currentStatus == status.shoot)
            {
                counter = 0;
            }
            if (counter == 20)
            {
                this.GetPlayerLoction();
                currentStatus = status.none;
                counter = 21;
            }
            if (currentStatus == status.stab) { this.GetPlayerLoction(); counter++; }
            else if (currentStatus == status.shoot) { ShotDistance+=IntegerHolder.Five;
                this.hitBox = new Rectangle(Convert.ToInt32(location.X), Convert.ToInt32(location.Y), IntegerHolder.ThirtyFive, 23);
            }
            else if (currentStatus == status.explode) { }
            if (this.hitBox.X <0 || this.hitBox.X > 720 || this.hitBox.Y < IntegerHolder.OneSixEight || this.hitBox.Y >648)
            {
                currentStatus = status.none;
            }

            

        }
        public void GetPlayerLoction()
        {
            location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
        }
        public override void Shoot()
        {
            if (myDirection == 0) { 
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingUp;
                location = new Vector2(position.X, position.Y - ShotDistance);
            }
            else if (myDirection == 1) { 
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingDown;
                location = new Vector2(position.X, position.Y + ShotDistance);
            }
            else if (myDirection == 2) {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingRight;
                location = new Vector2(position.X + ShotDistance, position.Y);
            }
            else if (myDirection == IntegerHolder.Three) { 
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingLeft;
                location = new Vector2(position.X - ShotDistance, position.Y);
            }
            WoodenSwordSprite.Draw(location, false);
            
        }
        
        public override void Explode()
        {
            WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordExploding;
            //location = new Vector2(this.player.GetRectangle().X, this.player.GetRectangle().Y);
            WoodenSwordSprite.Update();
            WoodenSwordSprite.Draw(location, false);
        }
        public override int IsExplode()
        {
            if (currentStatus == status.explode)
            {
                return 1;
            }
            else if (currentStatus == status.shoot)
            {
                return 0;
            }
            else if(currentStatus == status.stab)
            {
                return IntegerHolder.Three;
            }
            else
            {
                return 2;
            }
        }
        public override void setExplo(int i)
        {
            if (i == 1)
            {
                currentStatus = status.explode;
            }
            else if (i == 0)
            {
                currentStatus = status.shoot;
            }
            else if (i == 2)
            {
                currentStatus = status.stab;
            }
            else
            {
                currentStatus = status.none;
            }

        }
        public override void Stab()
        {
           
            if (myDirection == 0)
            {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingUp;
                location = new Vector2(position.X, position.Y - attackDistance);
                location2 = new Vector2(position.X, position.Y - IntegerHolder.FoutyFive);
            }
            else if (myDirection == 1)
            {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingDown;
                location = new Vector2(position.X, position.Y + attackDistance);
                location2 = new Vector2(position.X, position.Y + 55);
            }
            else if (myDirection == 2)
            {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingRight;
                location = new Vector2(position.X + attackDistance, position.Y);
                location2 = new Vector2(position.X + IntegerHolder.FoutyFive, position.Y);
            }
            else if (myDirection == IntegerHolder.Three)
            {
                WoodenSwordSprite = SpriteFactory.PlayerWoodenSwordShootingLeft;
                location = new Vector2(position.X - attackDistance, position.Y);
                location2 = new Vector2(position.X - IntegerHolder.FoutyFive, position.Y);
            }
            WoodenSwordSprite.Draw(location, false);
            this.hitBox = new Rectangle(Convert.ToInt32(location2.X), Convert.ToInt32(location2.Y), IntegerHolder.ThirtyFive, 23);
            
        }

        public override int getCounter()
        {
            return counter;
        }
    }
}
