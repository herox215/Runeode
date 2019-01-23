using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Runeode.Lib;
using Runeode.Lib.World;
using Runeode.Lib.World.Tiles;
using Runeode_Game.Logic;

namespace Runeode_Game {
    /// <summary>
    /// Stellt Funktionalität bereit, um eine <see cref="Scene"/> zu rendern.
    /// </summary>
    public class SceneRenderer {
        private TexturePipeline _pipeline = null;
        RuntimeEnviroment _enviroment = null;
        private int _renderDistance = 15;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="pipeline">Die zu setzende Pipeline.</param>
        public SceneRenderer(TexturePipeline pipeline) {
            _pipeline = pipeline;
            _enviroment = RuntimeEnviroment.GetInstance();
        }

        /// <summary>
        /// Zeichnet eine übergebene Scene.
        /// </summary>
        /// <param name="sceneToDraw">Die zu zeichnende Scene.</param>
        /// <param name="renderPlayer">Soll der Player beachtet und gerendert werden?</param>
        /// <param name="batch">Die Spritebatch, auf welcher gerendert werden soll.</param>
        /// <param name="layerToDraw">Der zu zeichnende Layer.</param>
        public void Draw(Scene sceneToDraw, bool renderPlayer, SpriteBatch batch, int layerToDraw) {

            for (int length = 0; length < sceneToDraw.Map.Length; length++) {
                for (int height = 0; height < sceneToDraw.Map.Height; height++) {



                    ITile tileToDraw = sceneToDraw.Map.GetTile(layerToDraw, height, length);

                    if (length == 10)
                        tileToDraw = new Grass();

                    Texture2D spriteAtlas = _pipeline.Get2DTextureFromTile(tileToDraw);

                    batch.Draw(spriteAtlas, new Vector2(length * _enviroment.TilesetResolution, height * _enviroment.TilesetResolution), Color.White);
                }
            }
        }
    }
}
