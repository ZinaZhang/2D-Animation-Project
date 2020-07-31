﻿using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint0.Interfaces;

//Author: Gengyi Qin
namespace Sprint0.Sprite
{
    public static class SpriteFactory
    {
        //TO-DO:Initialize all kinds of sprite objects in according methods
        public static LinkNoneMovingDownSprite LinkNoneMovingDown = new LinkNoneMovingDownSprite();
        public static LinkNoneMovingLeftSprite LinkNoneMovingLeft = new LinkNoneMovingLeftSprite();
        public static LinkNoneMovingRightSprite LinkNoneMovingRight = new LinkNoneMovingRightSprite();
        public static LinkNoneMovingUpSprite LinkNoneMovingUp = new LinkNoneMovingUpSprite();
        public static LinkNoneStandingDownSprite LinkNoneStandingDown = new LinkNoneStandingDownSprite();
        public static LinkNoneStandingLeftSprite LinkNoneStandingLeft = new LinkNoneStandingLeftSprite();
        public static LinkNoneStandingRightSprite LinkNoneStandingRight = new LinkNoneStandingRightSprite();
        public static LinkNoneStandingUpSprite LinkNoneStandingUp = new LinkNoneStandingUpSprite();
        public static LinkUsingUpSprite LinkUsingUp = new LinkUsingUpSprite();
        public static LinkUsingLeftSprite LinkUsingLeft = new LinkUsingLeftSprite();
        public static LinkUsingDownSprite LinkUsingDown = new LinkUsingDownSprite();
        public static LinkUsingRightSprite LinkUsingRight = new LinkUsingRightSprite();
        public static LinkPickUpItemSprite LinkPickUpItem = new LinkPickUpItemSprite();

        // Enemy Author: Gengyi Qin
        public static EnemyBornSprite EnemyBorn = new EnemyBornSprite();
        public static EnemyDeathSprite EnemyDeath = new EnemyDeathSprite();
        public static EnemyMoblinSprite EnemyMoblin = new EnemyMoblinSprite(0, 0);
        public static EnemyPeahatSprite EnemyPeahat = new EnemyPeahatSprite(0, 0);
        public static EnemyTektiteSprite EnemyTektite = new EnemyTektiteSprite(0, 0);
        public static EnemyKeeseSprite EnemyKeese = new EnemyKeeseSprite(0, 0);
        public static EnemyStalfosSprite EnemyStalfos = new EnemyStalfosSprite(0, 0);
        public static EnemyGoriyaSprite EnemyGoriya = new EnemyGoriyaSprite(0, 0);
        public static EnemyZolSprite EnemyZol = new EnemyZolSprite(0, 0);
        public static EnemyGelSprite EnemyGel = new EnemyGelSprite(0, 0);
        public static EnemyWallmasterSprite EnemyWallmaster = new EnemyWallmasterSprite(0, 0);
        public static EnemyTrapSprite EnemyTrap = new EnemyTrapSprite(0, 0);
        public static EnemyRopeSprite EnemyRope = new EnemyRopeSprite(0, 0);
        public static EnemyAquaSprite EnemyAqua = new EnemyAquaSprite(0, 0);
        public static EnemyDodongoSprite EnemyDodongo = new EnemyDodongoSprite(0, 0);
        public static EnemyOldmanSprite EnemyOldman = new EnemyOldmanSprite(0, 0);
        public static EnemyBlastSprite EnemyBlast = new EnemyBlastSprite();
        public static NPCMerchantSprite NPCMerchant = new NPCMerchantSprite();
        public static NPCFlameSprite NPCFlame = new NPCFlameSprite();
        public static NGoriyaSprite NGoriya = new NGoriyaSprite();
        public static NAquaSprite NAqua = new NAquaSprite();
        public static NDodongoSprite NDodongo = new NDodongoSprite();
        public static NKeeseSprite NKeese = new NKeeseSprite();
        public static NMoblinSprite NMoblin = new NMoblinSprite();
        public static NPeahatSprite NPeahat = new NPeahatSprite();
        public static NRopeSprite NRope = new NRopeSprite();
        public static NTektiteSprite NTektite = new NTektiteSprite();
        public static NZolSprite NZol = new NZolSprite();
        public static NGelSprite NGel = new NGelSprite();
        public static NStalfosSprite NStalfos = new NStalfosSprite();

        public static PlayerWoodenSwordSprite PlayerWoodenSwordRight = new PlayerWoodenSwordSprite(SpriteEffects.None, 0);
        public static PlayerWoodenSwordSprite PlayerWoodenSwordLeft = new PlayerWoodenSwordSprite(SpriteEffects.FlipHorizontally, 0);
        public static PlayerWoodenSwordSprite PlayerWoodenSwordUp = new PlayerWoodenSwordSprite(SpriteEffects.None, (float)-1.5708);
        public static PlayerWoodenSwordSprite PlayerWoodenSwordDown = new PlayerWoodenSwordSprite(SpriteEffects.None, (float)1.5708);

        public static InfoGoriyaSprite InfoGoriya = new InfoGoriyaSprite();
        public static InfoWallmasterSprite InfoWallmaster = new InfoWallmasterSprite();
        public static InfoMoblinSprite InfoMoblin = new InfoMoblinSprite();
        public static InfoPeahatSprite InfoPeahat = new InfoPeahatSprite();
        public static InfoTektiteSprite InfoTektite = new InfoTektiteSprite();
        public static InfoKeeseSprite InfoKeese = new InfoKeeseSprite();
        public static InfoRopeSprite InfoRope = new InfoRopeSprite();
        public static InfoStalfosSprite InfoStalfos = new InfoStalfosSprite();
        public static InfoAquaSprite InfoAqua = new InfoAquaSprite();
        public static InfoZolSprite InfoZol = new InfoZolSprite();
        public static InfoGelSprite InfoGel = new InfoGelSprite();
        public static InfoDogongoSprite InfoDogongo = new InfoDogongoSprite();

        //Zina
        public static PlayerWoodenSwordShootingSprite PlayerWoodenSwordShootingRight = new PlayerWoodenSwordShootingSprite(SpriteEffects.None, 0);
        public static PlayerWoodenSwordShootingSprite PlayerWoodenSwordShootingLeft = new PlayerWoodenSwordShootingSprite(SpriteEffects.FlipHorizontally, 0);
        public static PlayerWoodenSwordShootingSprite PlayerWoodenSwordShootingUp = new PlayerWoodenSwordShootingSprite(SpriteEffects.None, (float)-1.5708);
        public static PlayerWoodenSwordShootingSprite PlayerWoodenSwordShootingDown = new PlayerWoodenSwordShootingSprite(SpriteEffects.None, (float)1.5708);
        public static PlayerWoodenSwordExplodingSprite PlayerWoodenSwordExploding = new PlayerWoodenSwordExplodingSprite(SpriteEffects.None);
        public static PlayerBombSprite PlayerBomb = new PlayerBombSprite(SpriteEffects.None);
        public static PlayerBombExplodingSprite PlayerBombExploding = new PlayerBombExplodingSprite();
        public static PlayerArrowShootingSprite PlayerArrowShootingRight = new PlayerArrowShootingSprite(SpriteEffects.None, 0);
        public static PlayerArrowShootingSprite PlayerArrowShootingLeft = new PlayerArrowShootingSprite(SpriteEffects.FlipHorizontally, 0);
        public static PlayerArrowShootingSprite PlayerArrowShootingUp = new PlayerArrowShootingSprite(SpriteEffects.None, (float)-1.5708);
        public static PlayerArrowShootingSprite PlayerArrowShootingDown = new PlayerArrowShootingSprite(SpriteEffects.None, (float)1.5708);
        public static PlayerArrowExplodingSprite PlayerArrowExploding = new PlayerArrowExplodingSprite(SpriteEffects.None);
        public static PlayerBoomrangShootingSprite PlayerBoomrangShootingRight = new PlayerBoomrangShootingSprite(SpriteEffects.None, 0);
        public static PlayerBoomrangShootingSprite PlayerBoomrangShootingLeft = new PlayerBoomrangShootingSprite(SpriteEffects.FlipHorizontally, 0);
        public static PlayerBoomrangShootingSprite PlayerBoomrangShootingUp = new PlayerBoomrangShootingSprite(SpriteEffects.None, (float)-1.5708);
        public static PlayerBoomrangShootingSprite PlayerBoomrangShootingDown = new PlayerBoomrangShootingSprite(SpriteEffects.None, (float)1.5708);

        //Zina, FogSprite
        public static FogSprite Fog = new FogSprite();



        // Items Author: Zhizhou He, Chuwen Sun
        public static List<ISprite> ItemList = new List<ISprite>();
        public static ItemHeartContainerSprite ItemHeartContainer = new ItemHeartContainerSprite();
        public static ItemGirlSprite ItemGirl = new ItemGirlSprite();
        public static ItemClockSprite ItemClock = new ItemClockSprite();
        public static ItemBombSprite ItemBomb = new ItemBombSprite();
        public static ItemHeartSprite ItemHeart = new ItemHeartSprite();
        public static ItemCompassSprite ItemCompass = new ItemCompassSprite();
        public static ItemMapSprite ItemMap = new ItemMapSprite();
        public static ItemKeySprite ItemKey = new ItemKeySprite();
        public static ItemTriforceSprite ItemTriforce = new ItemTriforceSprite();
        public static ItemBoomerangSprite ItemBoomerang = new ItemBoomerangSprite();
        public static ItemBowSprite ItemBow = new ItemBowSprite();
        public static ItemRuppySprite ItemRuppy = new ItemRuppySprite();
        public static ItemArrowSprite ItemArrow = new ItemArrowSprite();
        public static ItemWoodenSwordSprite ItemWoodenSword = new ItemWoodenSwordSprite();
        public static ItemBlueCandleSprite ItemBlueCandle = new ItemBlueCandleSprite();
        public static ItemBlueRingSprite ItemBlueRing = new ItemBlueRingSprite();
        public static ItemBluePotionSprite ItemBluePotion = new ItemBluePotionSprite();
        public static BombInfoSprite BombInfo = new BombInfoSprite();
        public static HeartCInfoSprite HeartCInfo = new HeartCInfoSprite();
        public static RingInfoSprite RingInfo = new RingInfoSprite();
        public static PotionInfoSprite PotionInfo = new PotionInfoSprite();
        public static CandleInfoSprite CandleInfo = new CandleInfoSprite();

        // Block Author: Zilin Shao
        public static List<ISprite> BlockList = new List<ISprite>();
        public static ISprite BlockA = new BlockASprite();
        public static ISprite BlockB = new BlockBSprite();
        public static ISprite BlockC = new BlockCSprite();
        public static ISprite Lock = new LockSprite();

        //Hud Author: Zilin Shao
        public static List<IHud> HudList = new List<IHud>();
        public static HudHalfHeartSprite HudHalfHeart = new HudHalfHeartSprite();
        public static HudEmptyHeartSprite HudEmptyHeart = new HudEmptyHeartSprite();
        public static HudHeartSprite HudHeart = new HudHeartSprite();
        public static HudMapPieceSprite HudMapPiece = new HudMapPieceSprite();
        public static HudPointSprite HudPoint = new HudPointSprite();
        public static HudFrameSprite HudFrame = new HudFrameSprite();
        public static HudXSprite HudX = new HudXSprite();
        public static HudOneSprite HudOne = new HudOneSprite();
        public static HudTwoSprite HudTwo = new HudTwoSprite();
        public static HudThreeSprite HudThree = new HudThreeSprite();
        public static HudFourSprite HudFour = new HudFourSprite();
        public static HudFiveSprite HudFive = new HudFiveSprite();
        public static HudSixSprite HudSix = new HudSixSprite();
        public static HudSevenSprite HudSeven = new HudSevenSprite();
        public static HudEightSprite HudEight = new HudEightSprite();
        public static HudNineSprite HudNine = new HudNineSprite();
        public static HudZeroSprite HudZero = new HudZeroSprite();
        public static HudCoverSprite HudCover = new HudCoverSprite();

        //Author: Chuwen Sun
        public static DoorKLeftSprite DoorKLeft = new DoorKLeftSprite();
        public static DoorKRightSprite DoorKRight = new DoorKRightSprite();
        public static DoorKUpSprite DoorKUp = new DoorKUpSprite();
        public static DoorKDownSprite DoorKDown = new DoorKDownSprite();
        public static DoorBUpSprite DoorBUp = new DoorBUpSprite();
        public static DoorBDownSprite DoorBDown = new DoorBDownSprite();
        public static KeyholeUpSprite KeyholeUp = new KeyholeUpSprite();
        public static KeyholeDownSprite KeyholeDown = new KeyholeDownSprite();
        public static KeyholeLeftSprite KeyholeLeft = new KeyholeLeftSprite();
        public static KeyholeRightSprite KeyholeRight = new KeyholeRightSprite();

        public static PickBoxSprite PickBox = new PickBoxSprite();

        public static void LoadContent(SpriteBatch batch, ContentManager content)
        {
            LoadLinkContent(batch, content);
            LoadItemContent(batch, content);
            LoadEnemyContent(batch, content);
            LoadBlockContent(batch, content);
            LoadHudContent(batch, content);
            LoadDoorContent(batch, content);
        }



        private static void LoadLinkContent(SpriteBatch batch, ContentManager content)
        {
            LinkNoneStandingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneStandingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneStandingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneStandingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneMovingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneMovingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneMovingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkNoneMovingUp.LoadContent(batch, content.Load<Texture2D>("link"));

            LinkUsingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkUsingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkUsingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkUsingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            LinkPickUpItem.LoadContent(batch, content.Load<Texture2D>("link"));

            PlayerWoodenSwordRight.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordUp.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordDown.LoadContent(batch, content.Load<Texture2D>("link"));


            PlayerWoodenSwordShootingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordShootingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordShootingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordShootingDown.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerWoodenSwordExploding.LoadContent(batch, content.Load<Texture2D>("shoot"));

            //Zina
            PlayerBombExploding.LoadContent(batch, content.Load<Texture2D>("link")); 
            PlayerBomb.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowShootingRight.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowShootingLeft.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowShootingUp.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowShootingDown.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerArrowExploding.LoadContent(batch, content.Load<Texture2D>("shoot"));
            PlayerBoomrangShootingRight.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerBoomrangShootingLeft.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerBoomrangShootingUp.LoadContent(batch, content.Load<Texture2D>("link"));
            PlayerBoomrangShootingDown.LoadContent(batch, content.Load<Texture2D>("link"));

           Fog.LoadContent(batch, content.Load<Texture2D>("link-cover"));

        }

        private static void LoadItemContent(SpriteBatch batch, ContentManager content)
        {
            ItemHeartContainer.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemGirl.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemClock.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemBomb.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemHeart.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemCompass.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemKey.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemTriforce.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemBoomerang.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemBow.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemRuppy.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemArrow.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemMap.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemWoodenSword.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemBlueCandle.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemBluePotion.LoadContent(batch, content.Load<Texture2D>("item"));
            ItemBlueRing.LoadContent(batch, content.Load<Texture2D>("item"));
            BombInfo.LoadContent(batch, content.Load<Texture2D>("store"));
            HeartCInfo.LoadContent(batch, content.Load<Texture2D>("store"));
            RingInfo.LoadContent(batch, content.Load<Texture2D>("store"));
            CandleInfo.LoadContent(batch, content.Load<Texture2D>("store"));
            PotionInfo.LoadContent(batch, content.Load<Texture2D>("store"));

            ItemList.Add(ItemHeartContainer);
            ItemList.Add(ItemGirl);
            ItemList.Add(ItemClock);
            ItemList.Add(ItemBomb);
            ItemList.Add(ItemHeart);
            ItemList.Add(ItemCompass);
            ItemList.Add(ItemKey);
            ItemList.Add(ItemTriforce);
            ItemList.Add(ItemBoomerang);
            ItemList.Add(ItemBow);
            ItemList.Add(ItemRuppy);
            ItemList.Add(ItemArrow);
            ItemList.Add(ItemMap);
            ItemList.Add(ItemWoodenSword);
            ItemList.Add(BombInfo);
            ItemList.Add(HeartCInfo);
            ItemList.Add(ItemBluePotion);
            ItemList.Add(ItemBlueRing);
            ItemList.Add(ItemBlueCandle);
            ItemList.Add(RingInfo);
            ItemList.Add(CandleInfo);
            ItemList.Add(PotionInfo);
        }

        private static void LoadHudContent(SpriteBatch batch, ContentManager content)
        {
            HudHalfHeart.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudEmptyHeart.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudHeart.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudMapPiece.LoadContent(batch, content.Load<Texture2D>("Map"));
            HudPoint.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            HudFrame.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudX.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudOne.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudTwo.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudThree.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudFour.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudFive.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudSix.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudSeven.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudEight.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudNine.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudZero.LoadContent(batch, content.Load<Texture2D>("Hud"));
            HudCover.LoadContent(batch, content.Load<Texture2D>("Hud"));
            ItemList.Add(HudHalfHeart);
            ItemList.Add(HudEmptyHeart);
            ItemList.Add(HudHeart);
            PickBox.LoadContent(batch, content.Load<Texture2D>("Hud"));

        }

        private static void LoadEnemyContent(SpriteBatch batch, ContentManager content)
        {
            EnemyBorn.LoadContent(batch, content.Load<Texture2D>("link"));
            EnemyDeath.LoadContent(batch, content.Load<Texture2D>("link"));
            EnemyPeahat.LoadContent(batch, content.Load<Texture2D>("enemy"));
            EnemyMoblin.LoadContent(batch, content.Load<Texture2D>("enemy"));
            EnemyTektite.LoadContent(batch, content.Load<Texture2D>("enemy"));
            EnemyKeese.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyStalfos.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyGoriya.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyZol.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyGel.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyWallmaster.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyTrap.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyRope.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            EnemyAqua.LoadContent(batch, content.Load<Texture2D>("boss"));
            EnemyDodongo.LoadContent(batch, content.Load<Texture2D>("boss"));
            EnemyOldman.LoadContent(batch, content.Load<Texture2D>("npc"));
            EnemyBlast.LoadContent(batch, content.Load<Texture2D>("enemy"));
            NPCMerchant.LoadContent(batch, content.Load<Texture2D>("npc"));
            NPCFlame.LoadContent(batch, content.Load<Texture2D>("npc"));
            NGoriya.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            NAqua.LoadContent(batch, content.Load<Texture2D>("boss"));
            NDodongo.LoadContent(batch, content.Load<Texture2D>("boss"));
            NKeese.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            NMoblin.LoadContent(batch, content.Load<Texture2D>("enemy"));
            NPeahat.LoadContent(batch, content.Load<Texture2D>("enemy"));
            NRope.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            NTektite.LoadContent(batch, content.Load<Texture2D>("enemy"));
            NZol.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            NGel.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            NStalfos.LoadContent(batch, content.Load<Texture2D>("enemy2"));
            InfoGoriya.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoRope.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoStalfos.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoWallmaster.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoMoblin.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoPeahat.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoTektite.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoKeese.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoAqua.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoDogongo.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoZol.LoadContent(batch, content.Load<Texture2D>("handbook"));
            InfoGel.LoadContent(batch, content.Load<Texture2D>("handbook"));
        }

        private static void LoadBlockContent(SpriteBatch batch, ContentManager content)
        {
            BlockA.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            BlockB.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            BlockC.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            Lock.LoadContent(batch, content.Load<Texture2D>("Blocks"));
            BlockList.Add(BlockA);
            BlockList.Add(BlockB);
            BlockList.Add(BlockC);
        }

        private static void LoadDoorContent(SpriteBatch batch, ContentManager content)
        {
            DoorKLeft.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            DoorKRight.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            DoorKUp.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            DoorKDown.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            DoorBUp.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            DoorBDown.LoadContent(batch, content.Load<Texture2D>("dungeon"));
            KeyholeDown.LoadContent(batch, content.Load<Texture2D>("lock"));
            KeyholeUp.LoadContent(batch, content.Load<Texture2D>("lock"));
            KeyholeLeft.LoadContent(batch, content.Load<Texture2D>("lock"));
            KeyholeRight.LoadContent(batch, content.Load<Texture2D>("lock"));
        }
    }
}
