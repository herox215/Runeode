using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Runeode.Lib;
using Runeode.Lib.World;
using Runeode.Lib.World.Tiles;
using Runeode_Game.Logic;
using System.IO;

namespace Runeode_Game {
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Main : Game {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Scene currentScrene;
        TexturePipeline pipeline;
        SceneRenderer sceneRenderer;
        FrameCounter _frameCounter = new FrameCounter();
        SpriteFont font;

        public Main() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize() {

            RuntimeEnviroment enviroment = RuntimeEnviroment.GetInstance();
            pipeline = new TexturePipeline(GraphicsDevice);
            sceneRenderer = new SceneRenderer(pipeline);
            font = Content.Load<SpriteFont>("Arial");

            // DEBUG!
            enviroment.Players.Add(new Runeode.Lib.Logic.Player() { Name = "test" });
            currentScrene = new Scene("test");

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.WhiteSmoke);
            spriteBatch.Begin();

            sceneRenderer.Draw(currentScrene, false, spriteBatch, 0);

            DrawFPS(gameTime);

            spriteBatch.End();
            base.Draw(gameTime);
        }

        private void DrawFPS(GameTime gameTime) {
            var deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            _frameCounter.Update(deltaTime);

            var fps = string.Format("FPS: {0}", _frameCounter.AverageFramesPerSecond);

            spriteBatch.DrawString(font, fps, new Vector2(1, 1), Color.Black);
        }
    }
}
