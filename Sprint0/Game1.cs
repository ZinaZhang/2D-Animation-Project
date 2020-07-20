﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0.Block;
using Sprint0.Controller;
using Sprint0.Enemies;
using Sprint0.Interfaces;
using Microsoft.Xna.Framework.Audio;
using Sprint0.Items;
using Sprint0.Player;
using Sprint0.Sprite;
using System.Collections.Generic;
using System.ComponentModel;
using Sprint0.xml;
using System.Xml;
using Microsoft.Xna.Framework.Media;
using Sprint0.GameStates;
using Sprint0.HUD;
using Sprint0.UtilityClass;

namespace Sprint0
{
    /// <summary>
    /// This is the main type for your game.
    /// 

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        
        public roomProperties currentRoom;
        public List<roomProperties> roomList;

        private XmlReader reader;
        private List<SoundEffect> sounds;
        private List<Song> songs;
        private Sound soundEffect;
        private Song intro, Labyrinth;
        List<object> controllerList; // could also be defined as List <IController>
        public Hud hud;
        public IGameState currentState;
        public List<IGameState> stateList;
        public Player1 link;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        public void Reset()
        {
            Initialize();
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            SpriteFactory.LoadContent(spriteBatch, Content);

            // TODO: Add your initialization logic here
            graphics.PreferredBackBufferHeight = 696;
            graphics.PreferredBackBufferWidth = 768;
            graphics.ApplyChanges();
            //a way to modify screen size, better way probably exists
            sounds = new List<SoundEffect>();
            songs = new List<Song>();
            sounds.Add(Content.Load<SoundEffect>("Sounds/SwordSlash"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Link_Hurt"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_MagicalRod"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Arrow_Boomerang"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Bomb_Blow"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Bomb_Drop"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Enemy_Die"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Enemy_Hit"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Get_Heart"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Link_Die"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_LowHealth"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Sword_Shoot"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Get_Item"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Door_Unlock"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Get_Rupee"));

            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Boss_Scream1"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Boss_Scream2"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Boss_Scream3"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Fanfare"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Key_Appear"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Recorder"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Refill_Loop"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Secret"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Shield"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Shore"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Stairs"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Sword_Combined"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Text"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Text_Slow"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/Triforce"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Candle"));

            songs.Add(Content.Load<Song>("Sounds/intro"));
            songs.Add(Content.Load<Song>("Sounds/Labyrinth"));
            soundEffect = new Sound(sounds, songs);
            soundEffect.labyrinth();
            controllerList = new List<object>();
            controllerList.Add(new KeyboardC(this));
            controllerList.Add(new MouseC(this));
            link = new Player1(IntegerHolder.linkInitialX, IntegerHolder.linkInitialY, IntegerHolder.linkHitBoxSize, IntegerHolder.linkHitBoxSize, soundEffect, this);
            hud = new Hud(this);
            this.IsMouseVisible = true;
            base.Initialize();
            string Room = "Room";
            string xml = ".xml";
            roomList = new List<roomProperties>();
            for (int i = 0; i <= 16; i++)
            {
                reader = XmlReader.Create(Room + i + xml, new XmlReaderSettings());
                roomList.Add(Loader.LoadFromReader(reader, this));
            }
            foreach (roomProperties room in roomList)
            {
                room.loadBatchAndContent(Content, spriteBatch);
            }
            currentRoom = roomList[5];
            reader.Close();
            stateList = new List<IGameState>();
            stateList.Add(new InGame(this, hud));
            stateList.Add(new Transitioning(this, spriteBatch, Content, hud));
            stateList.Add(new GoToPause(this, spriteBatch, Content, hud));
            stateList.Add(new BackToGame(this, spriteBatch, Content, hud));
            stateList.Add(new Pause(this, spriteBatch, Content, hud));
            stateList.Add(new Death(this, spriteBatch, Content));
            stateList.Add(new Win(this, spriteBatch, Content));
            currentState = stateList[0];
        }
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            
        }
        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }

            currentState.Update();
            base.Update(gameTime);
            //link.myInventory.Update();
            //put this line into update() of pause.cs so Game1 can be simple
        }
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            currentState.Draw();
            base.Draw(gameTime);
            if(currentState == stateList[3])
            {
                //this.link.myInventory.showItem();
                //put this line into draw() of pause.cs so Game1 can be simple
            }           
        }
      
    }
}
