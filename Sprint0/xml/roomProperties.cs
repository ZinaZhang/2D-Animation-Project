﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint0.Interfaces;
using Sprint0.Player;

namespace Sprint0.xml
{
    public class roomProperties
    {
        public List<IBlock> blockList;
        public List<IItem> itemList;
        public List<IEnemy> enemyList;
        List<IRoom> roomList;
        public List<IHud> hudList;
        public Player1 link;

        //Constructor method
        public roomProperties(List<IBlock> b, List<IItem> i, List<IEnemy> e, List<IRoom> r, List<IHud> h, Player1 p)
        {
            itemList = i;
            enemyList = e;
            blockList = b;
            roomList = r;
            hudList = h;
            link = p;
        }
        public void Draw()
        {
            for (int i = 0; i < roomList.Count; i++)
            {
                roomList[i].Draw();
            }
            for (int i = 0; i < blockList.Count; i++)
            {
                blockList[i].Draw();
            }
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Draw();
            }
            for (int i = 0; i < itemList.Count; i++)
            {
                itemList[i].Draw();
            }
            for (int i = 0; i < hudList.Count; i++)
            {
                hudList[i].Draw();
            }
        }

        public void Update()
        {
            link.Update();
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Update();
            }
            for (int i = 0; i < itemList.Count; i++)
            {
                itemList[i].Update();
            }
            for (int i = 0; i < blockList.Count; i++)
            {
                blockList[i].Update();
            }
            for (int i = 0; i < roomList.Count; i++)
            {
                roomList[i].Update();
            }
            for (int i = 0; i < hudList.Count; i++)
            {
                hudList[i].Update();
            }
        }


    }
}
