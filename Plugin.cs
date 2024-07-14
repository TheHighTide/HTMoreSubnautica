using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace HTMoreSubnautica
{
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    [BepInDependency("com.snmodding.nautilus")] // Add Nautilus as a dependent library for the mod
    public class Plugin : BaseUnityPlugin
    {
        private const string MyGuid = "com.hightide.modding.sn.moresubnautica";
        private const string PluginName = "HighTide's More Subnautica";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGuid);

        public static ManualLogSource Log;

        private void Awake()
        {
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " " + "loaded.");
            Log = Logger;
        }
    }
}
