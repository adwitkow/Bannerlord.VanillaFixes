using HarmonyLib;
using SandBox;
using TaleWorlds.Core;

namespace Bannerlord.VanillaFixes.Patches
{
    [HarmonyPatch(typeof(SandBoxMissions), nameof(SandBoxMissions.CreateSandBoxMissionInitializerRecord))]
    public static class SandBoxMissionsPatch
    {
        public static void Postfix(ref MissionInitializerRecord __result)
        {
            // Make the player deal normal damage to their companion
            // (for example, during a tournament)
            __result.DamageFromPlayerToFriendsMultiplier = 1f;
        }
    }
}
