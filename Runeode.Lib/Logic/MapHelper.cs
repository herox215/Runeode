using Runeode.Lib.World.Tiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Runeode.Lib.Logic {
    /// <summary>
    /// Stellt Hilfsmethoden bereit im Zusammenhang mit einer Map.
    /// </summary>
    public static class TileHelper {
        public static ITile[,] GetEmptyTileArray(int newLength, int newHeight) {
            ITile tileToSet = new Empty();
            ITile[,] tiles = new ITile[newLength, newHeight];
            for (int length = 0; length < newLength; length++) {
                for (int height = 0; height < newHeight; height++) {
                    tiles[length, height] = tileToSet;
                }
            }
            return tiles;
        }
    }
}
