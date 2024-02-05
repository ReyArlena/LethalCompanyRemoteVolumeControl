using HarmonyLib;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteVolumeControl.Patches
{
    [HarmonyPatch(typeof(BoomboxItem))]
    internal class VolChangePatch
    {
        private const float VOL_INCREMENT = 0.1f;
        private const float VOL_MAX = 1.0f;
        private const float VOL_MIN = 0.0f;

        [HarmonyPatch(nameof(BoomboxItem.Update))]
        [HarmonyPostfix]
        static void volumeDown(ref AudioSource ___boomboxAudio)
        {
            if (RemoteVolumeControl.InputActionInstance.BoomboxVolDownKey.triggered && ___boomboxAudio.volume > VOL_MIN)
            {
                ___boomboxAudio.volume -= VOL_INCREMENT;
            } 
            else if(RemoteVolumeControl.InputActionInstance.BoomboxVolUpKey.triggered && ___boomboxAudio.volume < VOL_MAX)
            {
                ___boomboxAudio.volume += VOL_INCREMENT;
            }
        }
    }
}
