﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint0.Interfaces;
using Sprint0.Player;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Sprint0.UtilityClass;

namespace Sprint0.xml
{

    //Author: Chuwen Sun
    public class roomProperties
    {
        ContentManager myContent;
        SpriteBatch myBatch;
        public int roomID;
        public List<IBlock> blockList;
        public List<IItem> itemList;
        public List<IEnemy> enemyList;
        
        public List<INPC> NPCList;
        public Rectangle sourceRec;
        public Rectangle DestRec;
        public List<IDoor> DoorList;
        //Connectors is a collection of max IntegerHolder.Four integers represents rooms connected to the current room in{up, down, left, right} order. 
        //If there is no access to one direction, -1 will be presented.
        public List<int> Connectors;  
        //Constructor method
        public roomProperties(int id, List<IBlock> b, List<IItem> i, List<IEnemy> e, Rectangle source, List<int> con, List<IDoor> d, List<INPC> n)
        {
            roomID = id;
            itemList = i;
            enemyList = e;
            blockList = b;
            
            sourceRec = source;
            DestRec = new Rectangle(0, IntegerHolder.OneSixEight, IntegerHolder.SevenSixEight, IntegerHolder.FiveTwoEight);
            Connectors = con;
            DoorList = d;
            NPCList = n;
        }
        public void loadBatchAndContent(ContentManager Content, SpriteBatch Batch)
        {
            myContent = Content;
            myBatch = Batch;
        }
        public void Draw()
        {
            if (roomID == 17)
                ChangeSrc();

                myBatch.Begin();
                myBatch.Draw(myContent.Load<Texture2D>(StringHolder.Dungeon), DestRec, sourceRec, Color.White);
                myBatch.End();
                foreach (IBlock Block in blockList)
                {
                    if (Block.getType() == StringHolder.BlockXType || Block.getType() == StringHolder.BlockYType)
                    {
                        Block.Draw();
                    }
/*                if (Block.getType() == StringHolder.BlockType)
                {
                    Block.Draw();
                }*/
                }
                for (int i = 0; i < enemyList.Count; i++)
                {
                    enemyList[i].Draw();
                }
                for (int i = 0; i < itemList.Count; i++)
                {
                    itemList[i].Draw();
                }
                for (int i = 0; i < NPCList.Count; i++)
                {
                    NPCList[i].Draw();
                }
            
        }

        public void Update()
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].blockCollisionTest(blockList);
                enemyList[i].Update();
            }
            for (int i = 0; i < itemList.Count; i++)
            {
                itemList[i].Update();
            }
            for (int i = 0; i < blockList.Count; i++)
            {
                //blockList[i].Update();
            }          
            for (int i = 0; i < DoorList.Count; i++)
            {
                DoorList[i].Update();
            }
        }

        private void ChangeSrc()
        {
            sourceRec = new Rectangle(1, 1, 256, 160);
        }
    }
}
