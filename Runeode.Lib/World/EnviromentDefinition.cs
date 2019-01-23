using Runeode.Lib.World.Tiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Runeode.Lib.World {
    /// <summary>
    /// Stellt eine Umgebung da.
    /// </summary>
    public class EnviromentDefinition {
        /// <summary>
        /// Der Type der Umgebung.
        /// </summary>
        public EnviromentType Type { get; private set; }

        private ITile _tile;

        /// <summary>
        /// Erstellt die Definition.
        /// </summary>
        /// <param name="type">Der zu verwendende Type.</param>
        public EnviromentDefinition(EnviromentType type) {
            Type = type;
            
            switch (type) {
                case EnviromentType.Outside:
                    _tile = new Grass();
                    break;
                default:
                    _tile = new Grass();
                    break;
            }
        }

        /// <summary>
        /// Gibt den Stream zu der Textur zurück.
        /// </summary>
        /// <returns>Der Stream.</returns>
        public FileStream GetTextureFileStream() {
            return _tile.GetTextureStream();
        }
    }
}
