using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runeode.Lib.World.Tiles {
    class Empty : TileDefinition, ITile {
        /// <summary>
        /// Erstellt das "Empty" Tile.
        /// </summary>
        public Empty() : base("Empty") { }
    }
}
