using BepInEx;
using HarmonyLib;

namespace RadioAttenuation
{
    [BepInPlugin("com.MandM.RadioAttenuation", "RadioAttenuation", "1.0.0")]
    [BepInProcess("Bomb Rush Cyberfunk.exe")]

    public class Plugin : BaseUnityPlugin
    {

        public void Awake()
        {
            Harmony harmony = new Harmony("MandM.RadioAttenuation.Harmony");
            harmony.PatchAll();
        }
    }
}
