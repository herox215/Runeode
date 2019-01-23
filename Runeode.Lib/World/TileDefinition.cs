using Runeode.Lib.Graphics;
using System.IO;

namespace Runeode.Lib.World {
    /// <summary>
    /// Stellt ein Tile eines Tilesets da.
    /// </summary>
    public class TileDefinition {
        /// <summary>
        /// Der Name des Tiles.
        /// </summary>
        public string TileName { get; private set; }

        /// <summary>
        /// Ist das Tile begehbar?
        /// </summary>
        public bool IsWalkable { get; set; }

        /// <summary>
        /// Die intern zu verwendende Texture.
        /// </summary>
        private NodeTextureDefinition _textureDefinition;

        /// <summary>
        /// Erstellt die Tile Klasse.
        /// </summary>
        /// <param name="name">Der Name der Texture.</param>
        public TileDefinition(string name) {
            IsWalkable = true;
            TileName = name;
            _textureDefinition = new NodeTextureDefinition(name);
        }

        /// <summary>
        /// Gibt den Tilename zurück.
        /// </summary>
        /// <returns>Der Tilename.</returns>
        public string GetTileName() {
            return TileName;
        }

        /// <summary>
        /// Gibt den Texture-Stream zurück.
        /// </summary>
        /// <returns>Der Stream der Texture.</returns>
        public FileStream GetTextureStream() {
            return _textureDefinition.GetTextureFileStream();
        }
    }
}
