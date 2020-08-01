﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint0.HUDs;
using Sprint0.Interfaces;
using Sprint0.Items;
using Sprint0.Player;
using Sprint0.UtilityClass;

namespace Sprint0.Collisions
{
    class LinkItemCollision
    {
        private Player1 myPlayer;
        private HeartContainer heartC = new HeartContainer(0, 0);
        private Heart heart = new Heart(0, 0);
        private Triforce triforce = new Triforce(0, 0);
        private Ruppy ruppy = new Ruppy(0, 0);
        private Key key = new Key(0, 0);
        private Bomb bomb = new Bomb(0, 0);
        private Arrow arrow = new Arrow(0,0);
        private Bow bow = new Bow(0, 0);
        private Map map = new Map(0, 0);
        private Boomerang boomerang = new Boomerang(0, 0);
        private Compass compass = new Compass(0, 0);
        private WoodenSwordItem woodenSwordItem = new WoodenSwordItem(0, 0);
        private const int GetCompass = 1;
        public LinkItemCollision(Player1 player)
        {
            myPlayer = player;
        }


        public void ItemCollision(List<IItem> items, Sound s)
        {
            Rectangle linkRectangle = myPlayer.GetRectangle();
            Rectangle itemRectangle;
            Rectangle intersectionRectangle;
            foreach (IItem item in items)
            {
                itemRectangle = item.GetRectangle();
                intersectionRectangle = Rectangle.Intersect(linkRectangle, itemRectangle);
                if (!intersectionRectangle.IsEmpty)
                {
                    if (item.GetType() == triforce.GetType() && !item.isPickedUp()) myPlayer.winGame();                    
                    if (item.GetType() == heart.GetType() && !item.isPickedUp()) myPlayer.getHealed();                    
                    if (item.GetType() == heartC.GetType() && !item.isPickedUp()) myPlayer.increaseMaxHp();                    
                    if (item.GetType() == ruppy.GetType() && !item.isPickedUp()) myPlayer.getRuppy();                    
                    if (item.GetType() == key.GetType() && !item.isPickedUp()) myPlayer.getKey();                    
                    
                    if (item.GetType() == bomb.GetType() && !item.isPickedUp())
                    {
                        myPlayer.getBomb();
                        myPlayer.myInventory.addItem(item);
                    }
                    
                    if (item.GetType() == bow.GetType() && !item.isPickedUp())
                    {
                        s.getItem();
                        s.fanfare();
                        myPlayer.myInventory.addItem(item);
                    }
                    
                    if (item.GetType() == boomerang.GetType() && !item.isPickedUp())
                    {
                        s.getItem();
                        s.fanfare();
                        myPlayer.myInventory.addItem(item);
                    }
                    if (item.GetType() == arrow.GetType() && !item.isPickedUp())
                    {
                        s.getItem();
                        s.fanfare();
                    }


                    if (item.GetType() == map.GetType() && !item.isPickedUp()) myPlayer.MapOrCompassGet(0);                    
                    if (item.GetType() == compass.GetType() && !item.isPickedUp()) myPlayer.MapOrCompassGet(GetCompass);                    
                    if (item.GetType() == woodenSwordItem.GetType() && !item.isPickedUp())
                    {
                        s.getItem();
                        s.fanfare();
                        myPlayer.PickBuyWeapon(StringHolder.WoodenSword);
                    }

                    // check the collison occuring direction
                    if ((intersectionRectangle.Width >= intersectionRectangle.Height)) // from up or down
                    {
                        if (linkRectangle.Y > itemRectangle.Y)  item.PickedUp();                        
                        else  item.PickedUp();                       
                    }
                    else //from right or left
                    {
                        if (linkRectangle.X > itemRectangle.X) item.PickedUp();                        
                        else item.PickedUp();                        
                    }
                }
            }
        }
    }
}







