using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace Bannerlord.VanillaFixes
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            var harmony = new Harmony("me.quasindro.vanillafixes");
            harmony.PatchAll();
        }
    }
}