﻿using Microsoft.Xna.Framework;
using Sprint0.Commands;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;

//currently not used, since item would not collition with enemy or blocks right now. May update future

namespace Sprint0.Collisions
{
    class ProjectileCollision
    {
        private IProjectile thisProjectile;

        public ProjectileCollision(IProjectile projectile)
        {
            thisProjectile = projectile;
        }
        public void ProjectileEnemiesCollisionTest(List<IEnemy> enemies, Sound s)
        {
            Rectangle thisRectangle = thisProjectile.GetHitBox();
            Rectangle enemyRectangle;
            Rectangle intersectionRectangle;
            foreach (IEnemy enemy in enemies)
            {

                enemyRectangle = enemy.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(thisRectangle, enemyRectangle);
                if (!intersectionRectangle.IsEmpty && enemy.GetHealth() > 0)
                {






                    if (thisProjectile.IsExplode() == 0 && thisProjectile.Type() != "bomb")
                    {
                        enemy.Damaged();
                        thisProjectile.explo(1);
                        if (enemy.GetHealth() == 0)
                        {
                            s.enemyDie();
                        }
                        else
                        {
                            s.enemyHit();


                        }
                    } 
                    else if (thisProjectile.Type() == "bomb" && thisProjectile.IsExplode() == 1)
                    {
                        enemy.Damaged();
                        if (enemy.GetHealth() == 0)
                        {
                            s.enemyDie();
                        }
                        else
                        {
                            s.enemyHit();


                        }
                    }
                }
            }
        }
        public void ProjectileBlocksCollisionTest(List<IBlock> blocks)
        {
            Rectangle thisRectangle = thisProjectile.GetHitBox();
            Rectangle blockRectangle;
            Rectangle intersectionRectangle;
            foreach (IBlock block in blocks)
            {

                blockRectangle = block.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(thisRectangle, blockRectangle);
                if (!intersectionRectangle.IsEmpty && block.GetType() != "Water" && thisProjectile.Type() != "bomb")
                {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.explo(1);
                            }
                            
                       
                    break;//once link has collision with one block, no need to detect other blocks
                
            }
            }
        }
    }
}
