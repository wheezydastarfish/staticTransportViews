using System.Collections.Generic;
using System.Linq;
using Colossal.UI;
using Game.SceneFlow;
using Game.Audio;
using Game.UI.Menu;
using HarmonyLib;
using System.Reflection.Emit;
using Game;

namespace StaticTransportViews.Patches {

    [HarmonyPatch(typeof(MenuUISystem), "IsEditorEnabled")]
    class MenuUISystem_IsEditorEnabledPatch
    {
        static bool Prefix(ref bool __result)
        {
            __result = true;
            return false; // Ignore original function
        }
    }
}