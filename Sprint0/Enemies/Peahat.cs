using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0.Sprite;
using Sprint0.Interfaces;
using Sprint0.Projectile;
using Sprint0.Projectile_Enemy_;

namespace Sprint0.Enemies
{   //Zina
    public class Peahat : AbstractEnemies, IEnemy
    {

        private IProjectile energyBall;
        private ISprite PeahatSprite;
        private int xPosition;
        private int yPosition;
        private int frame = 0;
        bool backmove = false;
        private Rectangle destinationRec;

        public Peahat(int x, int y)
        {
            xPosition = x;
            yPosition = y;
            PeahatSprite = new EnemyPeahatSprite(x, y);
            energyBall = new EnergyBall(this);
            destinationRec = new Rectangle(x, y, 45, 45);
        }



        public override void Draw()
        {
            if (this.GetHealth() > 0)
            {
                Vector2 location = new Vector2(xPosition, yPosition);
                PeahatSprite.Draw(location, false);
                energyBall.Shoot();
            }
        }

        public override void Update()
        {
            energyBall.Update();
            frame++;
            if (frame >= 20) frame = 0;
            if (frame < 10 && !backmove)
            {
                destinationRec.Y += 5;
            }
            else if (frame > 10 && !backmove)
            {
                destinationRec.Y += 5;
            }
            else if (frame < 10 && backmove)
            {
                destinationRec.Y -= 5;
            }
            else if (frame > 10 && backmove)
            {
                destinationRec.Y -= 5;
            }
            if (destinationRec.Y > 555) backmove = true;
            if (destinationRec.Y < 264) backmove = false;
            PeahatSprite.Update();
        }

        public override Rectangle GetRectangle()
        {
            return destinationRec;
        }
    }
}