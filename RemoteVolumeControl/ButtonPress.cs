using LethalCompanyInputUtils.Api;
using UnityEngine.InputSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteVolumeControl.Patches
{
    public class ButtonPress : LcInputActions
    {
        [InputAction("<Keyboard>/leftBracket", Name = "Vol -", ActionType = InputActionType.Button)]
        public InputAction BoomboxVolDownKey {  get; set; }

        [InputAction("<Keyboard>/rightBracket", Name = "Vol +", ActionType = InputActionType.Button)]
        public InputAction BoomboxVolUpKey { get; set; }
    }
}
