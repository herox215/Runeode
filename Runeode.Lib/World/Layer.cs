using Runeode.Lib.Logic;
using Runeode.Lib.World.Tiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Runeode.Lib.World {
    /// <summary>
    /// Ein Layer stellt eine Tiefe einer Map da.
    /// </summary>
    public class Layer {
        /// <summary>
        /// Alle Tiles des Layers.
        /// </summary>
        public ITile[,] Tiles { get; set; }

        /// <summary>
        /// Erstellt ein leeren Layer.
        /// </summary>
        /// <param name="length">Die zu verwendende Länge der Map in Tiles.</param>
        /// <param name="height">Die zu verwendende Höhe der Map in Tiles.</param>
        public Layer(int length, int height) {
            Tiles = TileHelper.GetEmptyTileArray(length, height);
        }
    }
}
