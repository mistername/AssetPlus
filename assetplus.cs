using BepInEx;
using System.IO;

namespace AssetPlus {
    /// <summary>
    /// Simple class for adding all the individual of AssetPlus together
    /// </summary>
    public class AssetPlus
    {
        internal void Awake()
        {
            SoundPlus.SoundAwake();
            FontPlus.FontAwake();
            TextPlus.LanguageAwake();
        }

        internal static string[] GetFiles(string Extension) {
            return Directory.GetFiles(Paths.PluginPath, "*." + Extension, SearchOption.AllDirectories);
        }
    }
}
