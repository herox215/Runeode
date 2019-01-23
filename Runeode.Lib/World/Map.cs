using Runeode.Lib.World.Tiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Runeode.Lib.World {
    /// <summary>
    /// Beinhaltet alle Informationen zu einem Level.
    /// </summary>
    public class Map {
        /// <summary>
        /// Alle Ebenen der Map.
        /// </summary>
        public List<Layer> Layers = new List<Layer>();

        /// <summary>
        /// Die Höhe der Map.
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Die Länge der Map.
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Leerer Konstuktor, welche eine Map mit Standartwerten erstellt.
        /// </summary>
        public Map() {
            Height = 256;
            Length = 256;

            Layers.Add(new Layer(Length, Height));
        }

        /// <summary>
        /// Gibt ein <see cref="ITile"/> zurück.
        /// </summary>
        /// <param name="layer">Der Layer, auf welchem sich das Tile befindet.</param>
        /// <param name="height">Die Höhe des Layers.</param>
        /// <param name="length">Die Länge des Layers.</param>
        /// <returns>Das gefundende Tile.</returns>
        public ITile GetTile(int layer, int height, int length) {
            Layer foundLayer = Layers[layer];
            return foundLayer.Tiles[length, height];
        }

        public void Save(string path) {
            throw new NotImplementedException("No current functionality!");
        }
    }
}
