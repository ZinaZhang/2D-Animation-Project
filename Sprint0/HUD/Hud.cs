﻿using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Sprint0.Sprite;

namespace Sprint0.HUD
{
    public class Hud : IHud
    {
        private HealthBar Hpbar;
        private WeaponSlot WpSlot;
        private HudMap map;
        private HudFrame frame;
        private int xAix;
        private int yAix;
        private int health;
        Player1 _link;
        //private int width;
        //private int height;
        public Hud(Game1 myGame)
        { 
            _link = myGame.link;
            Hpbar = new HealthBar(myGame);
            WpSlot = new WeaponSlot(myGame);
            map = new HudMap(myGame);
            frame = new HudFrame(myGame);
            //width = w;
            //height = h;
        }
        public void Draw(int x, int y)
        {
            frame.Draw(x, y);
            Hpbar.Draw(x + 528, y + 120);
            WpSlot.Draw(x + 460, y + 72);
            map.Draw(x + 83, y + 118);

        }


        public void Update()
        {

        }

        public Rectangle GetRectangle(int x, int y)
        {
            return new Rectangle(x, y, 32, 32);
        }
    }
}