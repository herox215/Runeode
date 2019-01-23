using Runeode.Lib.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Runeode.Lib {
    /// <summary>
    /// Beinhaltet alle, zur Laufzeit relevanten, Daten.
    /// </summary>
    public class RuntimeEnviroment {
        /// <summary>
        /// Die aktuell im Spiel befindlichen Spieler.
        /// </summary>
        public List<Player> Players = new List<Player>();

        public int TilesetResolution { get; private set; }

        private static RuntimeEnviroment _instance;
        
        private RuntimeEnviroment() {
            TilesetResolution = 16;
        }

        public static RuntimeEnviroment GetInstance() {
            if (_instance == null)
                _instance = new RuntimeEnviroment();

            return _instance;
        }
    }
}
