using System;
using System.Collections.Generic;
using System.Text;

namespace Runeode.Lib.World.Tiles {
    /// <summary>
    /// Tile, welches Gras darstellt.
    /// </summary>
    public class Grass : TileDefinition, ITile {
        /// <summary>
        /// Erstellt das Gras Tile.
        /// </summary>
        public Grass() : base("Grass") { }
    }
}
