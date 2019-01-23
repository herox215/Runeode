using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runeode.Lib.Graphics {
    public class TextureStreamHandler {
        private static TextureStreamHandler _instance;
        private TextureStreamHandler() { }
        private Dictionary<string, FileStream> _cache = new Dictionary<string, FileStream>();
        public static TextureStreamHandler GetInstance() {
            if (_instance == null)
                _instance = new TextureStreamHandler();

            return _instance;
        }

        public FileStream TryGetStream(string path) {
            FileStream result = null;

            if(_cache.Keys.Where(k => k == path).Count() > 0) {
                _cache.TryGetValue(path, out result);
            }
            return result;
        }

        public void AddToCache(string path, FileStream stream) {
            _cache.Add(path, stream);
        }
    }
}
