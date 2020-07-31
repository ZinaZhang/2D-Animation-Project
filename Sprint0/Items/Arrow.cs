﻿using System;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Sprite;

namespace Sprint0.Items
{
    class Arrow : IItem
    {
        private ItemArrowSprite sprite = SpriteFactory.ItemArrow;
        private int xAix;
        private int yAix;
        private int xSize;
        private int ySize;
        private bool picked;
        private int price;

        public Arrow(int x, int y)
        {
            xAix = x;
            yAix = y;
            xSize = 32;
            ySize = 32;
            picked = false;
            price = 2;
        }
        public void Draw()
        {
            Vector2 location = new Vector2(xAix, yAix);
            if (picked == false)
            {
                sprite.Draw(location, false);
            }
        }
       
        public void PickedUp()
        {
            picked = true;
            
        }

        public Boolean isPickedUp()
        {
            return picked;
        }

        public void ItemReset()
        {
            picked = false;
        }

        public void Update()
        {
            //currently, does not need update
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(xAix, yAix, xSize, ySize);
        }

        public int getPrice()
        {
            return price;
        }
    }
}


