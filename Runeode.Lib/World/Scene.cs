
namespace Runeode.Lib.World {
    /// <summary>
    /// Stellt ein Spiel-Level da.
    /// </summary>
    public class Scene {

        /// <summary>
        /// Der Name der Szenerie.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Die Umgebung der Szenerie.
        /// </summary>
        public EnviromentDefinition Enviroment { get; private set; }

        /// <summary>
        /// Die "Karte" mit allen Tiles.
        /// </summary>
        public Map Map { get; private set; }

        /// <summary>
        /// Erstellt die Klasse.
        /// Es wird ein Szenerie-Name benötigt.
        /// </summary>
        /// <param name="sceneName">Der Name der Szenerie.</param>
        public Scene(string sceneName) {
            Name = sceneName;
            Enviroment = new EnviromentDefinition(EnviromentType.Outside);
            Map = new Map();
        }
    }
}
