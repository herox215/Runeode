using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Runeode.Lib.World.Tiles {
    /// <summary>
    /// Beschreibt ein Tile.
    /// </summary>
    public interface ITile {
        /// <summary>
        /// Lässt sich das Tile betreten?
        /// </summary>
        bool IsWalkable {
            get; set;
        }

        string GetTileName();

        /// <summary>
        /// Gibt den Texture-Stream zurück.
        /// </summary>
        /// <returns>Der Stream der Texture.</returns>
        FileStream GetTextureStream();
    }
}
