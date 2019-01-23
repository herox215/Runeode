using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runeode_Game.Logic {
    public class _2dTextureCache {
        private Dictionary<string, Texture2D> Cache = new Dictionary<string, Texture2D>();

        public bool TryGetFromCache(string name, out Texture2D texture) {
            return Cache.TryGetValue(name, out texture);
        }

        public void AddToCache(string name, Texture2D texture) {
            Cache.Add(name, texture);
        }
    }
}
