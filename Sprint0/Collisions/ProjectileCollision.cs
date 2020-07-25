﻿using Microsoft.Xna.Framework;
using Sprint0.Commands;
using Sprint0.Interfaces;
using System;
using System.Collections.Generic;
using Sprint0.UtilityClass;
using Sprint0.Player;

//currently not used, since item would not collition with enemy or blocks right now. May update future

namespace Sprint0.Collisions
{
    class ProjectileCollision
    {
        private IProjectile thisProjectile;
        private Player1 myPlayer;
        public ProjectileCollision(IProjectile projectile, Player1 link)
        {
            thisProjectile = projectile;
            myPlayer = link;
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
                    if (thisProjectile.IsExplode() == 0 && thisProjectile.Type() != StringHolder.Bomb)
                    {
                        enemy.Damaged();
                        thisProjectile.setExplo(1);
                        if (enemy.GetHealth() == 0)
                        {
                            s.enemyDie();
                        }
                        else
                        {
                            s.enemyHit();


                        }
                    } 
                    else if (thisProjectile.Type() == StringHolder.Bomb && thisProjectile.IsExplode() == 1)
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
                    else if (thisProjectile.IsExplode() == 3)
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
                if (!intersectionRectangle.IsEmpty && block.getType() != StringHolder.WaterType && thisProjectile.Type() != StringHolder.Bomb)
                {
                            if (thisProjectile.IsExplode() == 0)
                            {
                                thisProjectile.setExplo(1);
                            }
                            
                       
                    break;//once link has collision with one block, no need to detect other blocks
                
            }
            }
        }

        public void ProjectileLinkCollisionTest(Sound s)
        {
            Rectangle thisRectangle = thisProjectile.GetHitBox();
            Rectangle linkRectangle;
            Rectangle intersectionRectangle;
      
                linkRectangle = myPlayer.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(thisRectangle, linkRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    s.linkHurt();
                    myPlayer.takeDmg(1);
                    if (thisProjectile.IsExplode() == 0)
                    {
                        thisProjectile.setExplo(1);
                    }


                }           
        }
    }
}
