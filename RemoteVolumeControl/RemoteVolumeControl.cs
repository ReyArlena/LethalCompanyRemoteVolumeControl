using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using RemoteVolumeControl.Patches;
using RemoteVolumeControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteVolumeControl
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class RemoteVolumeControl : BaseUnityPlugin
    {
        private readonly Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
        private static RemoteVolumeControl instance;
        public static ButtonPress InputActionInstance = new ButtonPress();

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            harmony.PatchAll(typeof(RemoteVolumeControl));
            harmony.PatchAll(typeof(VolChangePatch));

        }
    }
}