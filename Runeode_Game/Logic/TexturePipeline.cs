using Microsoft.Xna.Framework.Graphics;
using Runeode.Lib.Graphics;
using Runeode.Lib.World.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runeode_Game.Logic {
    /// <summary>
    /// Lädt Texturen und gibt sie zurück.
    /// </summary>
    public class TexturePipeline {
        private _2dTextureCache _cache;
        private TextureStreamHandler _nodeStreamHandler;
        private GraphicsDevice _device;

        /// <summary>
        /// Erstellt die Pipeline.
        /// </summary>
        public TexturePipeline(GraphicsDevice device) {
            _cache = new _2dTextureCache();
            _nodeStreamHandler = TextureStreamHandler.GetInstance();
            _device = device;
        }

        /// <summary>
        /// Gibt eine 2D Textur anhand eines Tilesets zurück.
        /// </summary>
        /// <param name="tile">Das Tile, aus welcher die Textur zurückgegeben werden soll.</param>
        /// <returns>Die gefundene Texture.</returns>
        public Texture2D Get2DTextureFromTile(ITile tile) {
            Texture2D foundTexture = null;
            string tileName = tile.GetTileName();

            if (!String.IsNullOrEmpty(tileName)) {
                if (!_cache.TryGetFromCache(tileName, out foundTexture)) {
                    foundTexture = Texture2D.FromStream(_device, tile.GetTextureStream());
                    _cache.AddToCache(tileName, foundTexture);
                }
            }

            return foundTexture;
        }
    }
}
