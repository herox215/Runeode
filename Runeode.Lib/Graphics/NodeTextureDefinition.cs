using System;
using System.IO;

namespace Runeode.Lib.Graphics {
    /// <summary>
    /// Stellt eine Runeode Texture dar.
    /// </summary>
    public class NodeTextureDefinition : IDisposable {
        /// <summary>
        /// Der Pfad zu der Texture.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Der FileStream zu der Texture.
        /// </summary>
        private FileStream _stream;

        /// <summary>
        /// Der Name der Texture, welche geladen werden soll.
        /// Beachte: Textures müssen unter "Textures" abgelegt werden, damit sie gefunden werden!
        /// </summary>
        /// <param name="name"></param>
        public NodeTextureDefinition(string name) {
            Name = name;
            LoadFile();
        }

        /// <summary>
        /// Gibt den Stream der Texture zurück und setzt im Vorfeld die Position des Streams auf 0.
        /// </summary>
        /// <returns>Der Filestream der Texture.</returns>
        public FileStream GetTextureFileStream() {
            _stream.Position = 0;
            return _stream;
        }

        /// <summary>
        /// Löscht den Stream aus.
        /// </summary>
        public void Dispose() {
            if(_stream != null)
                _stream.Dispose();
        }

        /// <summary>
        /// Lädt die TextureFile.
        /// </summary>
        private void LoadFile() {
            _stream = TextureStreamHandler.GetInstance().TryGetStream(Name);
            if (_stream == null) {
                string path = String.Format("Textures/Tiles/{0}.png", Name); // TODO AUFLÖSEN! CHARACTER SHEETS z.b sind keine TILES!!!
                _stream = new FileStream(path, FileMode.Open);
                TextureStreamHandler.GetInstance().AddToCache(Name, _stream);
            }
        }
    }
}
