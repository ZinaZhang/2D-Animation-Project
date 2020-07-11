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

namespace Sprint0
{
    /// <summary>
    /// This is the main type for your game.
    /// 

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        public roomProperties currentRoom;
        public List<roomProperties> roomList;
        public int roomCount;
        private XmlReader reader;
        private List<SoundEffect> sounds;
        private Sound soundEffect;
        private Song intro;
        List<object> controllerList; // could also be defined as List <IController>
        public HealthBar Hpbar;
        public WeaponSlot WpSlot;
        public HudMap map;
        public IGameState currentState;
        public List<IGameState> stateList;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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
            sounds.Add(Content.Load<SoundEffect>("Sounds/SwordSlash"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_Link_Hurt"));
            sounds.Add(Content.Load<SoundEffect>("Sounds/LOZ_MagicalRod"));
            intro = Content.Load<Song>("Sounds/intro");
            MediaPlayer.Play(intro);
            MediaPlayer.IsRepeating = true;
            soundEffect = new Sound(sounds);
            controllerList = new List<object>();
            controllerList.Add(new KeyboardC(this));
            controllerList.Add(new MouseC(this));

            this.IsMouseVisible = true;
            base.Initialize();
            roomCount = 0;
            string Room = "Room";
            string xml = ".xml";
            roomList = new List<roomProperties>();
            for (int i = 0; i <= 16; i++)
            {
                reader = XmlReader.Create(Room + i + xml, new XmlReaderSettings());
                roomList.Add(Loader.LoadFromReader(reader, soundEffect));
            }
            foreach (roomProperties room in roomList)
            {
                room.loadBatchAndContent(Content, spriteBatch);
            }
            currentRoom = roomList[roomCount];
            reader.Close();
            stateList = new List<IGameState>();
            stateList.Add(new InGame(this));
            stateList.Add(new Transitioning(this, spriteBatch, Content));
            stateList.Add(new Pause(this, spriteBatch, Content));
            stateList.Add(new BackToGame(this, spriteBatch, Content));
            currentState = stateList[0];
            Hpbar = new HealthBar(150, 50, this.currentRoom.link);
            WpSlot = new WeaponSlot(250, 50, this.currentRoom.link);
            map = new HudMap(450, 70, this);
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
        }
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            currentState.Draw();
            Hpbar.Draw();
            WpSlot.Draw();
            map.Draw();
            base.Draw(gameTime);
        }
      
    }
}
