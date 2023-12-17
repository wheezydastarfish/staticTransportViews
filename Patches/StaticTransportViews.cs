using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Colossal.UI;
using Game;
using Game.UI.InGame;

namespace StaticTransportViews.Patches {

    [HarmonyPatch(typeof(TransportationOverviewUISystem), "ResetLinesVisibility")]
    class TransportationOverviewUISystem_NoResetPatch
    {
        static bool Prefix()
        {
            return false; // Ignore original function
        }
    }

}